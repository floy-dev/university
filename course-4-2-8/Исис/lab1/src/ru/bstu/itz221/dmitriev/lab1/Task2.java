package ru.bstu.itz221.dmitriev.lab1;

import java.io.File;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.util.Hashtable;
import java.util.Scanner;

public class Task2 {
    static Hashtable<String, String> dictionary = new Hashtable<>() {{
        put("0", "zero");
        put("1", "one");
        put("2", "two");
        put("3", "three");
        put("4", "four");
        put("5", "five");
        put("6", "six");
        put("7", "seven");
        put("8", "eight");
        put("9", "nine");
    }};

    static void run() {
        for (String character : getNumbers().replaceAll("[\\s,.]+", "").split("")) {
            IO.println(
                    dictionary.containsKey(character)
                        ? dictionary.get(character)
                        : String.format("Элемент %s не найден в словаре", character)
            );
        }
    }

    static String getNumbers() {
        Scanner scanner = new Scanner(System.in);
        IO.println("1 - клавиатура, 2 - файл");
        String mode = scanner.nextLine().trim();
        if (!mode.equals("1") && !mode.equals("2")) {
            throw new IllegalArgumentException("Режим не найден");
        }

        String numbers = "";

        if (mode.equals("1")) {
            IO.println("Введите строку из цифр:");
            numbers = scanner.nextLine();
        }
        if (mode.equals("2")) {
            try {
                scanner = new Scanner(new File("numbers.txt"), StandardCharsets.UTF_8);
            } catch (IOException e) {
                IO.println("Файл не найден");
                throw new IllegalArgumentException("Некорректный ввод");
            }
            numbers = scanner.nextLine();
        }

        return numbers;
    }
}
