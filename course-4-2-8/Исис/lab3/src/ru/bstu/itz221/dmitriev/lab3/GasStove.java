package ru.bstu.itz221.dmitriev.lab3;

import java.util.Scanner;

public class GasStove extends HouseholdAppliances {
    private Integer burnerCount;

    public GasStove(Scanner scanner) {
        super(scanner);
    }

    @Override
    public void init(Scanner scanner) {
        super.init(scanner);
        IO.println("Введите количество конфорок");
        this.burnerCount = scanner.nextInt();
    }

    @Override
    public String toString() {
        return super.toString(
                "Газовая плита",
                String.format("количество конфорок %s", this.burnerCount)
        );
    }
}
