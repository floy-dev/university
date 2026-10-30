package ru.bstu.itz221.dmitriev.lab5;

import org.xml.sax.Attributes;
import org.xml.sax.helpers.DefaultHandler;

import java.util.ArrayList;
import java.util.List;

public class XmlCarHandler extends DefaultHandler {
    private final List<CarEntity> cars = new ArrayList<>();
    private final StringBuilder text = new StringBuilder();
    private Long id;
    private String brand;
    private String model;
    private String color;
    private String registrationNumber;
    private String ownerLastName;
    private String ownerFirstName;
    private String ownerPatronymic;
    private Integer manufactureYear;
    private Double price;

    public List<CarEntity> getCars() {
        return cars;
    }

    @Override
    public void startElement(String uri, String localName, String qName, Attributes attributes) {
        text.setLength(0);

        if (qName.equals("car")) {
            id = Long.valueOf(attributes.getValue("id"));
        }
    }

    @Override
    public void characters(char[] characters, int start, int length) {
        text.append(characters, start, length);
    }

    @Override
    public void endElement(String uri, String localName, String qName) {
        String value = text.toString().trim();

        switch (qName) {
            case "brand" -> brand = value;
            case "model" -> model = value;
            case "color" -> color = value;
            case "registrationNumber" -> registrationNumber = value;
            case "lastName" -> ownerLastName = value;
            case "firstName" -> ownerFirstName = value;
            case "patronymic" -> ownerPatronymic = value;
            case "manufactureYear" -> manufactureYear = Integer.valueOf(value);
            case "price" -> price = Double.valueOf(value);
            case "car" -> cars.add(new CarEntity(
                    id,
                    brand,
                    model,
                    color,
                    registrationNumber,
                    ownerLastName,
                    ownerFirstName,
                    ownerPatronymic,
                    manufactureYear,
                    price
            ));
        }
    }
}
