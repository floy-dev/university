package ru.bstu.itz221.dmitriev.lab2;

import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;

import java.io.File;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.util.Hashtable;
import java.util.Scanner;

/**
 * <p>Заменяет цифры в строке их английскими названиями</p>
 */
public class Task2 {
    private static final Logger LOGGER = LogManager.getLogger(Task2.class);
    private static final Hashtable<String, String> DICTIONARY = new Hashtable<>();

    static {
        DICTIONARY.put("0", "zero");
        DICTIONARY.put("1", "one");
        DICTIONARY.put("2", "two");
        DICTIONARY.put("3", "three");
        DICTIONARY.put("4", "four");
        DICTIONARY.put("5", "five");
        DICTIONARY.put("6", "six");
        DICTIONARY.put("7", "seven");
        DICTIONARY.put("8", "eight");
        DICTIONARY.put("9", "nine");
    }

    /**
     * <p>Читает строку, разделяет её на символы
     * и выполняет поиск в словаре</p>
     */
    public static void run() {
        String numbers = getNumbers();
        String characters = numbers.replaceAll("[\\s,.]+", "");
        LOGGER.debug("Строка после удаления разделителей: {}", characters);

        for (String character : characters.split("")) {
            if (DICTIONARY.containsKey(character)) {
                String value = DICTIONARY.get(character);
                IO.println(value);
            } else {
                String message = String.format(
                        "Элемент %s не найден в словаре", character
                );
                IO.println(message);
                LOGGER.warn(message);
            }
        }

        LOGGER.info("Задание 2 завершено");
    }

    /**
     * <p>Читает строку с цифрами с клавиатуры или из файла</p>
     *
     * @return исходная строка с цифрами
     * @throws IllegalArgumentException если выбран неизвестный режим или
     * строку невозможно прочитать
     */
    private static String getNumbers() {
        Scanner scanner = new Scanner(System.in);
        IO.println("1 - клавиатура, 2 - файл");
        String mode = scanner.nextLine().trim();

        if (!mode.equals("1") && !mode.equals("2")) {
            LOGGER.warn("Выбран неизвестный режим ввода: {}", mode);
            throw new IllegalArgumentException("Режим не найден");
        }

        if (mode.equals("1")) {
            IO.println("Введите строку из цифр:");
            String numbers = scanner.nextLine();
            return numbers;
        }

        try (Scanner fileScanner = new Scanner(
                new File("numbers.txt"), StandardCharsets.UTF_8)) {
            String numbers = fileScanner.nextLine();
            return numbers;
        } catch (IOException | RuntimeException exception) {
            LOGGER.error("Не удалось прочитать файл numbers.txt", exception);
            throw new IllegalArgumentException(
                    "Некорректные данные в файле numbers.txt", exception
            );
        }
    }
}
