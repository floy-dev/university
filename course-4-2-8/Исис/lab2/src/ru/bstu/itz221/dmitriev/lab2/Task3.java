package ru.bstu.itz221.dmitriev.lab2;

import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;

import java.io.File;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.util.Locale;
import java.util.Scanner;

/**
 * <p>Вычисляет значения функции на заданном отрезке двумя видами циклов</p>
 */
public class Task3 {
    private static final Logger LOGGER = LogManager.getLogger(Task3.class);

    /**
     * <p>Вычисляет и выводит значения функции циклами for и while</p>
     */
    public static void run() {
        double[] values = getValues();
        double start = values[0];
        double end = values[1];
        double step = values[2];

        IO.println("Цикл for:");
        for (double x = start; x <= end; x += step) {
            double result = Math.sin(x) + Math.tan(x);
            IO.println(String.format(
                    Locale.US, "x = %.2f, F(x) = %.4f", x, result
            ));
        }

        IO.println("Цикл while:");
        double x = start;
        while (x <= end) {
            double result = Math.sin(x) + Math.tan(x);
            IO.println(String.format(
                    Locale.US, "x = %.2f, F(x) = %.4f", x, result
            ));
            x += step;
        }

        LOGGER.info("Задание 3 завершено");
    }

    /**
     * <p>Читает начало и конец отрезка, а также шаг вычисления</p>
     *
     * @return массив с началом отрезка, концом отрезка и шагом
     * @throws IllegalArgumentException если параметры невозможно прочитать
     * или они имеют недопустимые значения
     */
    private static double[] getValues() {
        Scanner scanner = new Scanner(System.in);
        IO.println("1 - клавиатура, 2 - файл");
        String mode = scanner.nextLine().trim();

        if (!mode.equals("1") && !mode.equals("2")) {
            LOGGER.warn("Выбран неизвестный режим ввода: {}", mode);
            throw new IllegalArgumentException("Режим не найден");
        }

        boolean fileMode = mode.equals("2");
        if (fileMode) {
            try {
                scanner = new Scanner(
                        new File("function.txt"), StandardCharsets.UTF_8
                );
            } catch (IOException exception) {
                LOGGER.error("Не удалось открыть файл function.txt", exception);
                throw new IllegalArgumentException(
                        "Файл function.txt не найден", exception
                );
            }
        }

        scanner.useLocale(Locale.US);

        double start;
        double end;
        double step;

        try {
            if (!fileMode) {
                IO.println("Введите начало отрезка:");
            }
            start = scanner.nextDouble();

            if (!fileMode) {
                IO.println("Введите конец отрезка:");
            }
            end = scanner.nextDouble();

            if (!fileMode) {
                IO.println("Введите шаг:");
            }
            step = scanner.nextDouble();
        } catch (RuntimeException exception) {
            LOGGER.error("Не удалось прочитать параметры функции", exception);
            throw new IllegalArgumentException(
                    "Некорректные параметры функции", exception
            );
        } finally {
            if (fileMode) {
                scanner.close();
            }
        }

        if (start > end) {
            LOGGER.warn("Начало отрезка {} больше конца {}", start, end);
            throw new IllegalArgumentException("Начало отрезка больше конца");
        }
        if (step <= 0) {
            LOGGER.warn("Получен недопустимый шаг: {}", step);
            throw new IllegalArgumentException("Шаг должен быть больше нуля");
        }

        LOGGER.debug(
                "Параметры функции: начало = {}, конец = {}, шаг = {}",
                start, end, step
        );
        return new double[] {start, end, step};
    }
}
