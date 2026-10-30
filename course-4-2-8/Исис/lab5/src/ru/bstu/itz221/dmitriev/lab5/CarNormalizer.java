package ru.bstu.itz221.dmitriev.lab5;

import java.util.Scanner;

public class CarNormalizer {
    public static CarEntity denormalize(Scanner scanner, Long existingId) {
        Long id = existingId == null ? readId(scanner) : existingId;
        String brand = readRequiredString(scanner, "Марка:");
        String model = readRequiredString(scanner, "Модель:");
        String color = readRequiredString(scanner, "Цвет:");
        String registrationNumber = readRequiredString(scanner,"Государственный номер:");
        String ownerLastName = readRequiredString(scanner,"Фамилия владельца:");
        String ownerFirstName = readRequiredString(scanner,"Имя владельца:");
        String ownerPatronymic = readRequiredString(scanner,"Отчество владельца:");
        Integer manufactureYear = readYear(scanner);
        Double price = readPrice(scanner);

        return new CarEntity(
                id,
                brand,
                model,
                color,
                registrationNumber,
                ownerLastName,
                ownerFirstName,
                ownerPatronymic,
                manufactureYear,
                price
        );
    }

    public static Long readId(Scanner scanner) {
        IO.println("ID автомобиля:");
        Long id = scanner.nextLong();
        scanner.nextLine();
        return id;
    }

    private static Integer readYear(Scanner scanner) {
        IO.println("Год выпуска:");
        Integer year = scanner.nextInt();
        scanner.nextLine();
        return year;
    }

    private static Double readPrice(Scanner scanner) {
        IO.println("Стоимость:");
        Double price = scanner.nextDouble();
        scanner.nextLine();
        return price;
    }

    private static String readRequiredString(Scanner scanner, String message) {
        String result = "";

        while (result.isEmpty()) {
            IO.println(message);
            result = scanner.nextLine().trim();
        }

        return result;
    }

    public static CarFilter denormalizeFilter(Scanner scanner) {
        IO.println("Если параметр не используется - пропуск");

        IO.println("Минимальный год выпуска:");
        String minYear = scanner.nextLine().trim();
        IO.println("Максимальный год выпуска:");
        String maxYear = scanner.nextLine().trim();
        IO.println("Минимальная стоимость:");
        String minPrice = scanner.nextLine().trim();
        IO.println("Максимальная стоимость:");
        String maxPrice = scanner.nextLine().trim();

        return new CarFilter(
                minYear.isEmpty() ? null : Integer.valueOf(minYear),
                maxYear.isEmpty() ? null : Integer.valueOf(maxYear),
                minPrice.isEmpty() ? null : Double.valueOf(minPrice),
                maxPrice.isEmpty() ? null : Double.valueOf(maxPrice)
        );

    }
}
