package ru.bstu.itz221.dmitriev.lab4;

import java.util.Scanner;

public class Main {
    static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        IO.println("Введите текст:");
        String text = scanner.nextLine();

        IO.println("Результат:");
        IO.println(convert(text));
    }

    public static String convert(String text) {
        return text
                .replaceAll("(?i)\\[font=\"([^\"]+)\"]", "<span style=\"font-family: $1\">")
                .replaceAll("(?i)\\[/font]", "</span>")
                .replaceAll("(?i)\\[size=\"([^\"]+)\"]", "<span style=\"font-size: $1\">")
                .replaceAll("(?i)\\[/size]", "</span>")
                .replaceAll("(?i)\\[color=\"([^\"]+)\"]", "<span style=\"color: $1\">")
                .replaceAll("(?i)\\[/color]", "</span>")
                .replaceAll("(?i)\\[url=\"([^\"]+)\"]", "<a href=\"$1\">")
                .replaceAll("(?i)\\[/url]", "</a>")
                .replaceAll("(?i)\\[img=\"([^\"]+)\"]", "<img src=\"$1\" />");
    }
}
