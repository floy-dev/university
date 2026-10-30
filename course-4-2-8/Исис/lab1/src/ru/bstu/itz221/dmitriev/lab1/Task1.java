package ru.bstu.itz221.dmitriev.lab1;

import java.io.File;
import java.io.IOException;
import java.lang.IO;
import java.nio.charset.StandardCharsets;
import java.util.Locale;
import java.util.Scanner;

public class Task1  {
    static void run() {
        double[][] coordinates = getCoordinates();

        double distanceAB = Math.pow(coordinates[1][0] - coordinates[0][0], 2)
                + Math.pow(coordinates[1][1] - coordinates[0][1], 2);
        double distanceAC = Math.pow(coordinates[2][0] - coordinates[0][0], 2)
                + Math.pow(coordinates[2][1] - coordinates[0][1], 2);

        if (distanceAB < distanceAC) {
            IO.println("Точка B ближе к точке A");
        } else if (distanceAC < distanceAB) {
            IO.println("Точка C ближе к точке A");
        } else {
            IO.println("Точки B и C находятся на одинаковом расстоянии от A");
        }
    }

    static double[][] getCoordinates() {
        Scanner scanner = new Scanner(System.in);
        IO.println("1 - клавиатура, 2 - файл");
        String mode = scanner.nextLine().trim();
        if (!mode.equals("1") && !mode.equals("2")) {
            throw new IllegalArgumentException("Режим не найден");
        }

        double ax = 0.0;
        double ay = 0.0;
        double bx = 0.0;
        double by = 0.0;
        double cx = 0.0;
        double cy = 0.0;

        if (mode.equals("1")) {
            try {
                IO.println("Введите координаты a(x):");
                ax = scanner.nextDouble();
                IO.println("Введите координаты a(y):");
                ay = scanner.nextDouble();
                IO.println("Введите координаты b(x):");
                bx = scanner.nextDouble();
                IO.println("Введите координаты b(y):");
                by = scanner.nextDouble();
                IO.println("Введите координаты c(x):");
                cx = scanner.nextDouble();
                IO.println("Введите координаты c(y):");
                cy = scanner.nextDouble();
            }
            catch (Exception e) {
                throw new IllegalArgumentException("Некорректный ввод");
            }
        }
        if (mode.equals("2")) {
            try {
                scanner = new Scanner(new File("points.txt"), StandardCharsets.UTF_8);
            } catch (IOException e) {
                IO.println("Файл не найден");
                throw new IllegalArgumentException("Некорректный ввод");
            }

            scanner.useLocale(Locale.US);

            ax = scanner.nextDouble();
            ay = scanner.nextDouble();
            bx = scanner.nextDouble();
            by = scanner.nextDouble();
            cx = scanner.nextDouble();
            cy = scanner.nextDouble();
        }

        return new double[][] {
            {ax, ay},
            {bx, by},
            {cx, cy},
        };
    }
}
