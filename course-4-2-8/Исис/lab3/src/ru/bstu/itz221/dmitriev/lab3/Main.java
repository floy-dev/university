package ru.bstu.itz221.dmitriev.lab3;

import java.util.*;

public class Main {
    private static final Hashtable<Integer, String[]> TYPES = new Hashtable<>();

    static {
        TYPES.put(1, new String[] {GasStove.class.getName(), "Газовая плита"});
        TYPES.put(2, new String[] {Microwave.class.getName(), "Микроволновка"});
        TYPES.put(3, new String[] {WashingMachine.class.getName(), "Стиральная машинка"});
    }

    static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int count = getCount(scanner);
        HouseholdAppliances[] householdAppliances = new HouseholdAppliances[count];
        int i = 0;

        while (i < count) {
            printTypes();

            HouseholdAppliances householdAppliance = createAppliance(scanner);
            householdAppliances[i] = householdAppliance;

            i++;
        }

        for (HouseholdAppliances householdAppliance : householdAppliances) {
            IO.println(householdAppliance.toString());
        }

        HouseholdAppliances mostExpensive = findMostExpensive(householdAppliances);
        IO.println("Техника с наибольшей стоимостью:");
        IO.println(mostExpensive.toString());
    }

    private static HouseholdAppliances createAppliance(Scanner scanner) {
        String productClassName = "";

        try {
            IO.println("Номер техники:");
            int productType = scanner.nextInt();

            if (!TYPES.containsKey(productType)) {
                throw new IllegalArgumentException("Тип техники не найден");
            }

            productClassName = TYPES.get(productType)[0];
        } catch (Exception exception) {
            throw new IllegalArgumentException("Техника с таким типом не найдена");
        }

        try {
            Class<?> objectClass = Class.forName(productClassName);
            return (HouseholdAppliances) objectClass.getDeclaredConstructor(Scanner.class).newInstance(scanner);
        } catch (Exception exception) {
            throw new IllegalArgumentException("Техника с таким типом не найдена в базе данных");
        }
    }

    private static HouseholdAppliances findMostExpensive(HouseholdAppliances[] householdAppliances) {
        List<HouseholdAppliances> appliances = Arrays.asList(householdAppliances);
        return Collections.max(appliances, Comparator.comparingDouble(HouseholdAppliances::getCost));
    }

    private static void printTypes() {
        IO.println("Доступная техника:");

        for (int i = 1; i < TYPES.size() + 1; i++) {
            IO.println(String.format("%d - %s", i, TYPES.get(i)[1]));
        }
    }

    private static Integer getCount(Scanner scanner) {
        IO.println("Введите количество товаров:");

        StringBuilder count = new StringBuilder();
        boolean isNumbersStarts = false;

        for (String character : scanner.nextLine().split("")) {
            if (isInteger(character)) {
                count.append(character);
                isNumbersStarts = true;
            }

            if (isNumbersStarts && !isInteger(character)) {
                break;
            }
        }

        return Integer.parseInt(count.toString());
    }

    private static boolean isInteger(String value) {
        try {
            Integer.parseInt(value.trim());
            return true;
        } catch (NumberFormatException exception) {
            return false;
        }
    }
}
