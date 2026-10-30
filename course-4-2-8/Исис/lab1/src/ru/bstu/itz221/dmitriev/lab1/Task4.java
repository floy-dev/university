package ru.bstu.itz221.dmitriev.lab1;

import java.io.File;
import java.io.IOException;
import java.lang.IO;
import java.nio.charset.StandardCharsets;
import java.util.Arrays;
import java.util.Scanner;

public class Task4 {
    static void run() {
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

        IO.println("Элементы с четными номерами: " + Arrays.toString(evenPositions));
        IO.println("Элементы с нечетными номерами: " + Arrays.toString(oddPositions));
    }

    static int[] getNumbers() {
        Scanner scanner = new Scanner(System.in);

        IO.println("1 - клавиатура, 2 - файл");
        String mode = scanner.nextLine().trim();

        if (!mode.equals("1") && !mode.equals("2")) {
            throw new IllegalArgumentException("Режим не найден");
        }

        if (mode.equals("2")) {
            try {
                scanner = new Scanner(new File("array.txt"), StandardCharsets.UTF_8);
            } catch (IOException e) {
                IO.println("Файл не найден");
                throw new IllegalArgumentException("Некорректный ввод");
            }
        }

        if (mode.equals("1")) {
            IO.println("Введите количество элементов массива:");
        }

        int count = scanner.nextInt();
        int[] numbers = new int[count];

        for (int i = 0; i < numbers.length; i++) {
            if (mode.equals("1")) {
                IO.println("Введите элемент " + (i + 1) + ":");
            }
            numbers[i] = scanner.nextInt();
        }

        return numbers;
    }
}
