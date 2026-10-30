package ru.bstu.itz221.dmitriev.lab2;

import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;

import java.io.File;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.util.Arrays;
import java.util.Scanner;

/**
 * <p>Разделяет элементы массива по чётным и нечётным номерам</p>
 */
public class Task4 {
    private static final Logger LOGGER = LogManager.getLogger(Task4.class);

    /**
     * <p>Формирует два массива и выводит разделённые элементы</p>
     */
    public static void run() {
        int[] numbers = getNumbers();

        int[] evenPositions = new int[numbers.length / 2];
        int[] oddPositions = new int[(numbers.length + 1) / 2];

        int evenIndex = 0;
        int oddIndex = 0;

        for (int i = 0; i < numbers.length; i++) {
            if ((i + 1) % 2 == 0) {
                evenPositions[evenIndex] = numbers[i];
                evenIndex++;
            } else {
                oddPositions[oddIndex] = numbers[i];
                oddIndex++;
            }
        }

        IO.println( "Элементы с четными номерами: " + Arrays.toString(evenPositions));
        IO.println( "Элементы с нечетными номерами: " + Arrays.toString(oddPositions));

        LOGGER.info("Задание 4 завершено");
    }

    /**
     * <p>Читает количество элементов и значения массива</p>
     *
     * @return массив целых чисел
     * @throws IllegalArgumentException если выбран неизвестный режим или
     * элементы массива невозможно прочитать
     */
    private static int[] getNumbers() {
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
                        new File("array.txt"), StandardCharsets.UTF_8
                );
            } catch (IOException exception) {
                LOGGER.error("Не удалось открыть файл array.txt", exception);
                throw new IllegalArgumentException(
                        "Файл array.txt не найден", exception
                );
            }
        }

        try {
            if (!fileMode) {
                IO.println("Введите количество элементов массива:");
            }

            int count = scanner.nextInt();
            if (count < 0) {
                LOGGER.warn(
                        "Получено отрицательное количество элементов: {}",
                        count
                );
                throw new IllegalArgumentException(
                        "Количество элементов не может быть отрицательным"
                );
            }

            int[] numbers = new int[count];
            for (int i = 0; i < numbers.length; i++) {
                if (!fileMode) {
                    IO.println("Введите элемент " + (i + 1) + ":");
                }
                numbers[i] = scanner.nextInt();
            }

            LOGGER.debug("Получен массив: {}", Arrays.toString(numbers));
            return numbers;
        } catch (IllegalArgumentException exception) {
            throw exception;
        } catch (RuntimeException exception) {
            LOGGER.error("Не удалось прочитать элементы массива", exception);
            throw new IllegalArgumentException(
                    "Некорректные данные массива", exception
            );
        } finally {
            if (fileMode) {
                scanner.close();
            }
        }
    }
}
