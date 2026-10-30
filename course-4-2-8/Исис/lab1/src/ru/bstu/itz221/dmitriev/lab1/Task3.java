package ru.bstu.itz221.dmitriev.lab1;

import java.io.File;
import java.io.IOException;
import java.lang.IO;
import java.nio.charset.StandardCharsets;
import java.util.Locale;
import java.util.Scanner;

public class Task3 {
    static void run() {
        double[] values = getValues();
        double start = values[0];
        double end = values[1];
        double step = values[2];

        IO.println("Цикл for:");
        for (double x = start; x <= end; x += step) {
            double result = Math.sin(x) + Math.tan(x);
            IO.println(String.format(Locale.US, "x = %.2f, F(x) = %.4f", x, result));
        }

        IO.println("Цикл while:");
        double x = start;
        while (x <= end) {
            double result = Math.sin(x) + Math.tan(x);
            IO.println(String.format(Locale.US, "x = %.2f, F(x) = %.4f", x, result));
            x += step;
        }
    }

    static double[] getValues() {
        Scanner scanner = new Scanner(System.in);

        IO.println("1 - клавиатура, 2 - файл");
        String mode = scanner.nextLine().trim();

        if (!mode.equals("1") && !mode.equals("2")) {
            throw new IllegalArgumentException("Режим не найден");
        }

        if (mode.equals("2")) {
            try {
                scanner = new Scanner(new File("function.txt"), StandardCharsets.UTF_8);
            } catch (IOException e) {
                IO.println("Файл не найден");
                throw new IllegalArgumentException("Некорректный ввод");
            }
        }

        scanner.useLocale(Locale.US);

        if (mode.equals("1")) {
            IO.println("Введите начало отрезка:");
        }
        double start = scanner.nextDouble();

        if (mode.equals("1")) {
            IO.println("Введите конец отрезка:");
        }
        double end = scanner.nextDouble();

        if (mode.equals("1")) {
            IO.println("Введите шаг:");
        }
        double step = scanner.nextDouble();

        if (start > end) {
            throw new IllegalArgumentException("Начало отрезка больше конца");
        }
        if (step <= 0) {
            throw new IllegalArgumentException("Шаг должен быть больше нуля");
        }

        return new double[] {start, end, step};
    }
}
