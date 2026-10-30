package ru.bstu.itz221.dmitriev.lab5;

import java.util.List;

public interface CarHandlerInterface {
    void create(CarEntity car);

    void update(CarEntity car);

    void delete(Long id);

    List<CarEntity> select();

    CarEntity select(Long id);

    List<CarEntity> select(CarFilter filter);

    void clear();

    default void convertTo(CarHandlerInterface target) {
        List<CarEntity> cars = select();

        target.clear();

        for (CarEntity car : cars) {
            target.create(car);
        }
    }
}
