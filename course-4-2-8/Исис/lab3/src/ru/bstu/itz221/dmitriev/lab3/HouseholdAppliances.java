package ru.bstu.itz221.dmitriev.lab3;

import java.util.Scanner;

public abstract class HouseholdAppliances {
    protected Double length;
    protected Double width;
    protected Double height;
    protected Double cost;

    public HouseholdAppliances(Scanner scanner) {
        init(scanner);
    }

    public void init(Scanner scanner) {
        IO.println("Введите ширину");
        this.width = scanner.nextDouble();
        IO.println("Введите длину");
        this.length = scanner.nextDouble();
        IO.println("Введите высоту");
        this.height = scanner.nextDouble();
        IO.println("Введите стоимость");
        this.cost = scanner.nextDouble();
    }

    public Double getCost() {
        return this.cost;
    }

    protected String toString(String name, String parameters) {
        String additionalParameters = parameters.isEmpty() ? "" : parameters + ", ";

        return String.format(
                "%s (%sширина %s, длина %s, высота %s), стоимость %s",
                name,
                additionalParameters,
                this.width,
                this.length,
                this.height,
                this.cost
        );
    }
}
