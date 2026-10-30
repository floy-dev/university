package ru.bstu.itz221.dmitriev.lab5;

import java.util.List;
import java.util.Properties;
import java.util.Scanner;

public class CarRepository {
    private final CarHandlerInterface storage;
    private final Scanner scanner;
    private final Properties properties;

    public CarRepository(CarHandlerInterface storage, Scanner scanner, Properties properties) {
        this.storage = storage;
        this.scanner = scanner;
        this.properties = properties;
    }

    public void showAll() {
        printCars(storage.select());
    }

    public void findById() {
        Long id = CarNormalizer.readId(scanner);
        CarEntity car = storage.select(id);

        if (car == null) {
            IO.println(properties.getProperty("message.car.not.found"));
        } else {
            IO.println(car);
        }
    }

    public void search() {
        CarFilter filter = CarNormalizer.denormalizeFilter(scanner);
        printCars(storage.select(filter));
    }

    public void create() {
        storage.create(CarNormalizer.denormalize(scanner, null));
        IO.println(properties.getProperty("message.created"));
    }

    public void update() {
        Long id = CarNormalizer.readId(scanner);

        if (storage.select(id) == null) {
            throw new IllegalArgumentException(properties.getProperty("message.car.not.found"));
        }

        storage.update(CarNormalizer.denormalize(scanner, id));
        IO.println(properties.getProperty("message.updated"));
    }

    public void delete() {
        storage.delete(CarNormalizer.readId(scanner));
        IO.println(properties.getProperty("message.deleted"));
    }

    private void printCars(List<CarEntity> cars) {
        if (cars.isEmpty()) {
            IO.println(properties.getProperty("message.list.empty"));
            return;
        }

        for (CarEntity car : cars) {
            IO.println(car);
        }
    }
}
