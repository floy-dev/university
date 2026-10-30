package ru.bstu.itz221.dmitriev.lab5;

import java.io.InputStream;
import java.io.InputStreamReader;
import java.nio.charset.StandardCharsets;
import java.util.Properties;

public class ParameterBag {
    public static Properties load() {
        Properties properties = new Properties();

        try (InputStream stream = Main.class.getClassLoader().getResourceAsStream("application.properties")) {
            if (stream == null) {
                throw new IllegalStateException("Файл application.properties не найден");
            }

            properties.load(new InputStreamReader(stream, StandardCharsets.UTF_8));
            return properties;
        } catch (Exception exception) {
            throw new IllegalStateException("Не удалось прочитать настройки: " + exception.getMessage(), exception);
        }
    }
}
