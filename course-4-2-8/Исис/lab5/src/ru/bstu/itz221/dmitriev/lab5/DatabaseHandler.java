package ru.bstu.itz221.dmitriev.lab5;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.Properties;

public class DatabaseHandler implements CarHandlerInterface {
    private static final String COLUMNS = "id, brand, model, color, registration_number, "
            + "owner_last_name, owner_first_name, owner_patronymic, manufacture_year, price";

    private final String url;
    private final String user;
    private final String password;
    private final String errorMessage;
    private final Integer minYear;
    private final Integer maxYear;
    private final Double minPrice;

    public DatabaseHandler(Properties properties) {
        url = properties.getProperty("db.url");
        user = properties.getProperty("db.user");
        password = properties.getProperty("db.password");
        errorMessage = properties.getProperty("message.error.database");
        minYear = Integer.valueOf(properties.getProperty("car.year.min"));
        maxYear = Integer.valueOf(properties.getProperty("car.year.max"));
        minPrice = Double.valueOf(properties.getProperty("car.price.min"));
    }

    @Override
    public void create(CarEntity car) {
        String sql = "INSERT INTO cars (" + COLUMNS + ") VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

        try (Connection connection = openConnection();
            PreparedStatement statement = connection.prepareStatement(sql)) {
            setCarParameters(statement, car, false);
            statement.executeUpdate();
        } catch (SQLException exception) {
            throw new IllegalStateException(errorMessage + exception.getMessage(), exception);
        }
    }

    @Override
    public void update(CarEntity car) {
        String sql = "UPDATE cars SET brand = ?, model = ?, color = ?, registration_number = ?, "
                + "owner_last_name = ?, owner_first_name = ?, owner_patronymic = ?, "
                + "manufacture_year = ?, price = ? WHERE id = ?";

        try (Connection connection = openConnection();
            PreparedStatement statement = connection.prepareStatement(sql)) {
            setCarParameters(statement, car, true);

            if (statement.executeUpdate() == 0) {
                throw new IllegalArgumentException("Автомобиль с таким ID не найден");
            }
        } catch (SQLException exception) {
            throw new IllegalStateException(errorMessage + exception.getMessage(), exception);
        }
    }

    @Override
    public void delete(Long id) {
        String sql = "DELETE FROM cars WHERE id = ?";

        try (Connection connection = openConnection();
             PreparedStatement statement = connection.prepareStatement(sql)) {
            statement.setLong(1, id);

            if (statement.executeUpdate() == 0) {
                throw new IllegalArgumentException("Автомобиль с таким ID не найден");
            }
        } catch (SQLException exception) {
            throw new IllegalStateException(errorMessage + exception.getMessage(), exception);
        }
    }

    @Override
    public List<CarEntity> select() {
        return readBySql("SELECT " + COLUMNS + " FROM cars ORDER BY id", new ArrayList<>());
    }

    @Override
    public CarEntity select(Long id) {
        String sql = "SELECT " + COLUMNS + " FROM cars WHERE id = ?";
        List<Object> parameters = new ArrayList<>();
        parameters.add(id);
        List<CarEntity> cars = readBySql(sql, parameters);

        if (cars.isEmpty()) {
            return null;
        }

        return cars.get(0);
    }

    @Override
    public List<CarEntity> select(CarFilter filter) {
        StringBuilder sql = new StringBuilder("SELECT " + COLUMNS + " FROM cars WHERE 1 = 1");
        List<Object> parameters = new ArrayList<>();

        addNumberFilter(sql, parameters, "manufacture_year", ">=", filter.getMinYear());
        addNumberFilter(sql, parameters, "manufacture_year", "<=", filter.getMaxYear());
        addNumberFilter(sql, parameters, "price", ">=", filter.getMinPrice());
        addNumberFilter(sql, parameters, "price", "<=", filter.getMaxPrice());
        sql.append(" ORDER BY id");

        return readBySql(sql.toString(), parameters);
    }

    @Override
    public void clear() {
        try (Connection connection = openConnection();
             Statement statement = connection.createStatement()) {
            statement.executeUpdate("DELETE FROM cars");
        } catch (SQLException exception) {
            throw new IllegalStateException(errorMessage + exception.getMessage(), exception);
        }
    }

    private Connection openConnection() throws SQLException {
        Connection connection = DriverManager.getConnection(url, user, password);

        try {
            createTable(connection);
            return connection;
        } catch (SQLException exception) {
            connection.close();
            throw exception;
        }
    }

    private void createTable(Connection connection) throws SQLException {
        String sql = "CREATE TABLE IF NOT EXISTS cars ("
                + "id BIGINT PRIMARY KEY, "
                + "brand VARCHAR(50) NOT NULL, "
                + "model VARCHAR(50) NOT NULL, "
                + "color VARCHAR(30) NOT NULL, "
                + "registration_number VARCHAR(20) NOT NULL UNIQUE, "
                + "owner_last_name VARCHAR(50) NOT NULL, "
                + "owner_first_name VARCHAR(50) NOT NULL, "
                + "owner_patronymic VARCHAR(50) NOT NULL, "
                + "manufacture_year INTEGER NOT NULL CHECK (manufacture_year BETWEEN "
                + minYear + " AND " + maxYear + "), "
                + "price NUMERIC(12, 2) NOT NULL CHECK (price >= " + minPrice + ")"
                + ")";

        try (Statement statement = connection.createStatement()) {
            statement.executeUpdate(sql);
        }
    }

    private List<CarEntity> readBySql(String sql, List<Object> parameters) {
        List<CarEntity> cars = new ArrayList<>();

        try (Connection connection = openConnection();
             PreparedStatement statement = connection.prepareStatement(sql)) {
            setParameters(statement, parameters);

            try (ResultSet resultSet = statement.executeQuery()) {
                while (resultSet.next()) {
                    cars.add(readCar(resultSet));
                }
            }
        } catch (SQLException exception) {
            throw new IllegalStateException(errorMessage + exception.getMessage(), exception);
        }

        return cars;
    }

    private CarEntity readCar(ResultSet resultSet) throws SQLException {
        return new CarEntity(
                resultSet.getLong("id"),
                resultSet.getString("brand"),
                resultSet.getString("model"),
                resultSet.getString("color"),
                resultSet.getString("registration_number"),
                resultSet.getString("owner_last_name"),
                resultSet.getString("owner_first_name"),
                resultSet.getString("owner_patronymic"),
                resultSet.getInt("manufacture_year"),
                resultSet.getDouble("price")
        );
    }

    private void setCarParameters(PreparedStatement statement, CarEntity car, boolean update) throws SQLException {
        if (update) {
            statement.setString(1, car.getBrand());
            statement.setString(2, car.getModel());
            statement.setString(3, car.getColor());
            statement.setString(4, car.getRegistrationNumber());
            statement.setString(5, car.getOwnerLastName());
            statement.setString(6, car.getOwnerFirstName());
            statement.setString(7, car.getOwnerPatronymic());
            statement.setInt(8, car.getManufactureYear());
            statement.setDouble(9, car.getPrice());
            statement.setLong(10, car.getId());
        } else {
            statement.setLong(1, car.getId());
            statement.setString(2, car.getBrand());
            statement.setString(3, car.getModel());
            statement.setString(4, car.getColor());
            statement.setString(5, car.getRegistrationNumber());
            statement.setString(6, car.getOwnerLastName());
            statement.setString(7, car.getOwnerFirstName());
            statement.setString(8, car.getOwnerPatronymic());
            statement.setInt(9, car.getManufactureYear());
            statement.setDouble(10, car.getPrice());
        }
    }

    private void setParameters(PreparedStatement statement, List<Object> parameters) throws SQLException {
        for (int i = 0; i < parameters.size(); i++) {
            statement.setObject(i + 1, parameters.get(i));
        }
    }

    private void addNumberFilter(
            StringBuilder sql,
            List<Object> parameters,
            String column,
            String operation,
            Number value
    ) {
        if (value != null) {
            sql.append(" AND ").append(column).append(" ").append(operation).append(" ?");
            parameters.add(value);
        }
    }

}
