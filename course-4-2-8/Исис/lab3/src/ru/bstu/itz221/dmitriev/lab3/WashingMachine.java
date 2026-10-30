package ru.bstu.itz221.dmitriev.lab3;

import java.util.Scanner;

public class WashingMachine extends ElectronicEquipment {
    protected Double maxLoad;

    public WashingMachine(Scanner scanner) {
        super(scanner);
    }

    @Override
    public void init(Scanner scanner) {
        super.init(scanner);
        IO.println("Введите максимальную загрузку");
        this.maxLoad = scanner.nextDouble();
    }

    @Override
    public String toString() {
        return super.toString(
                "Стиральная машинка",
                String.format("мощность %s, загрузка %s", this.power, this.maxLoad)
        );
    }
}
