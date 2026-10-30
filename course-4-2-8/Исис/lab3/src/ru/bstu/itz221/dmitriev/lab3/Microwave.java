package ru.bstu.itz221.dmitriev.lab3;

import java.util.Scanner;

public class Microwave extends ElectronicEquipment {
    private Double volume;

    public Microwave(Scanner scanner) {
        super(scanner);
    }

    @Override
    public void init(Scanner scanner) {
        super.init(scanner);
        IO.println("Введите объем");
        this.volume = scanner.nextDouble();
    }

    @Override
    public String toString() {
        return super.toString(
                "Микроволновка",
                String.format("мощность %s, объем %s", this.power, this.volume)
        );
    }
}
