package ru.bstu.itz221.dmitriev.lab2;

import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;

import java.io.File;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.util.Locale;
import java.util.Scanner;

/**
 * <p>Определяет, какая из точек B и C расположена ближе к точке A</p>
 */
public class Task1 {
    private static final Logger LOGGER = LogManager.getLogger(Task1.class);

    /**
     * <p>Получает координаты точек, сравнивает расстояния
     * и выводит результат</p>
     */
    public static void run() {
        double[][] coordinates = getCoordinates();

        double distanceAB = Math.pow(coordinates[1][0] - coordinates[0][0], 2)
                + Math.pow(coordinates[1][1] - coordinates[0][1], 2);
        double distanceAC = Math.pow(coordinates[2][0] - coordinates[0][0], 2)
                + Math.pow(coordinates[2][1] - coordinates[0][1], 2);

        String result;
        if (distanceAB < distanceAC) {
            result = "Точка B ближе к точке A";
        } else if (distanceAC < distanceAB) {
            result = "Точка C ближе к точке A";
        } else {
            result = "Точки B и C находятся на одинаковом расстоянии от A";
        }

        IO.println(result);
        LOGGER.info("Задание 1 завершено: {}", result);
    }

    /**
     * <p>Читает координаты трёх точек с клавиатуры или из файла</p>
     *
     * @return двумерный массив с координатами точек A, B и C
     * @throws IllegalArgumentException если выбран неизвестный режим или
     * координаты невозможно прочитать
     */
    private static double[][] getCoordinates() {
        Scanner scanner = new Scanner(System.in);
        IO.println("1 - клавиатура, 2 - файл");
        String mode = scanner.nextLine().trim();

        if (!mode.equals("1") && !mode.equals("2")) {
            LOGGER.warn("Выбран неизвестный режим ввода: {}", mode);
            throw new IllegalArgumentException("Режим не найден");
        }

        double ax;
        double ay;
        double bx;
        double by;
        double cx;
        double cy;

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
            } catch (RuntimeException exception) {
                LOGGER.error(
                        "Не удалось прочитать координаты с клавиатуры",
                        exception
                );
                throw new IllegalArgumentException(
                        "Некорректный ввод", exception
                );
            }
        } else {
            try (Scanner fileScanner = new Scanner(
                    new File("points.txt"), StandardCharsets.UTF_8)) {
                fileScanner.useLocale(Locale.US);
                ax = fileScanner.nextDouble();
                ay = fileScanner.nextDouble();
                bx = fileScanner.nextDouble();
                by = fileScanner.nextDouble();
                cx = fileScanner.nextDouble();
                cy = fileScanner.nextDouble();
            } catch (IOException | RuntimeException exception) {
                LOGGER.error(
                        "Не удалось прочитать координаты из файла points.txt",
                        exception
                );
                throw new IllegalArgumentException(
                        "Некорректные данные в файле points.txt", exception
                );
            }
        }

        LOGGER.debug(
                "Получены координаты: A({}, {}), B({}, {}), C({}, {})",
                ax, ay, bx, by, cx, cy
        );

        return new double[][] {
            {ax, ay},
            {bx, by},
            {cx, cy}
        };
    }
}
