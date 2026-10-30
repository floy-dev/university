package ru.bstu.itz221.dmitriev.lab5;

import java.nio.file.Path;
import java.util.Properties;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Properties properties = ParameterBag.load();
        Scanner scanner = new Scanner(System.in);

        CarHandlerInterface xmlStorage = new XmlHandler(
                Path.of(
                        properties.getProperty("work.directory"),
                        properties.getProperty("xml.file")
                ),
                properties.getProperty("message.error.xml")
        );
        CarHandlerInterface databaseStorage = new DatabaseHandler(properties);

        CarHandlerInterface activeStorage = selectStorage(scanner, xmlStorage, databaseStorage);
        CarRepository repository = new CarRepository(activeStorage, scanner, properties);
        int command = -1;

        while (command != 0) {
            IO.println(storageName(activeStorage, properties));
            IO.println("1 - показать записи\n2 - найти по ID\n3 - поиск по параметрам\n4 - добавить\n5 - изменить\n6 - удалить\n7 - XML -> PostgreSQL\n8 - PostgreSQL -> XML\n0 - завершить");
            IO.println("Команда:");

            command = scanner.nextInt();
            scanner.nextLine();

            try {
                switch (command) {
                    case 1 -> repository.showAll();
                    case 2 -> repository.findById();
                    case 3 -> repository.search();
                    case 4 -> repository.create();
                    case 5 -> repository.update();
                    case 6 -> repository.delete();
                    case 7 -> {
                        xmlStorage.convertTo(databaseStorage);
                        activeStorage = databaseStorage;
                        repository = new CarRepository(activeStorage, scanner, properties);
                        IO.println(properties.getProperty("message.converted.xml.database"));
                    }
                    case 8 -> {
                        databaseStorage.convertTo(xmlStorage);
                        activeStorage = xmlStorage;
                        repository = new CarRepository(activeStorage, scanner, properties);
                        IO.println(properties.getProperty("message.converted.database.xml"));
                    }
                    case 0 -> IO.println(properties.getProperty("message.finished"));
                    default -> IO.println(properties.getProperty("message.command.not.found"));
                }
            } catch (RuntimeException exception) {
                IO.println(properties.getProperty("message.error.operation") + exception.getMessage());
            }
        }
    }

    private static CarHandlerInterface selectStorage(
            Scanner scanner,
            CarHandlerInterface xmlStorage,
            CarHandlerInterface databaseStorage
    ) {
        int storageNumber = 0;

        while (storageNumber != 1 && storageNumber != 2) {
            IO.println("Выберите хранилище: 1 - XML, 2 - PostgreSQL");
            IO.println("Номер хранилища:");

            storageNumber = scanner.nextInt();
            scanner.nextLine();

            if (storageNumber != 1 && storageNumber != 2) {
                IO.println("Хранилище не найдено");
            }
        }

        if (storageNumber == 1) {
            return xmlStorage;
        }

        return databaseStorage;
    }

    private static String storageName(CarHandlerInterface storage, Properties properties) {
        if (storage instanceof XmlHandler) {
            return properties.getProperty("message.storage.xml");
        }

        return properties.getProperty("message.storage.database");
    }
}
