package ru.bstu.itz221.dmitriev.lab3;

import java.util.Scanner;

public abstract class ElectronicEquipment extends HouseholdAppliances {
    protected Double power;

    public ElectronicEquipment(Scanner scanner) {
        super(scanner);
    }

    @Override
    public void init(Scanner scanner) {
        super.init(scanner);
        IO.println("Введите мощность");
        this.power = scanner.nextDouble();
    }
}
