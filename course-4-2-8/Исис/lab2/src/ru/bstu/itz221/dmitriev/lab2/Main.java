package ru.bstu.itz221.dmitriev.lab2;

import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;

/**
 * <p>Запускает задания второй лабораторной работы</p>
 */
public class Main {
    private static final Logger LOGGER = LogManager.getLogger(Main.class);

    /**
     * <p>Последовательно запускает четыре задания и обрабатывает ошибки</p>
     *
     * @param args аргументы командной строки
     */
    public static void main(String[] args) {
        try {
            Task1.run();
            Task2.run();
            Task3.run();
            Task4.run();
        } catch (Exception exception) {
            LOGGER.fatal("Выполнение программы прервано", exception);
            IO.println("Программа завершена с ошибкой: " + exception.getMessage());
        } finally {
            IO.println("Нажмите Enter для завершения программы");
            IO.readln();
            LOGGER.info("Программа лабораторной работы №2 завершена");
        }
    }
}
