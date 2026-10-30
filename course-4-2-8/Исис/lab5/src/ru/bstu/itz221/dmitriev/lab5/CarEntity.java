package ru.bstu.itz221.dmitriev.lab5;

public class CarEntity {
    private final Long id;
    private final String brand;
    private final String model;
    private final String color;
    private final String registrationNumber;
    private final String ownerLastName;
    private final String ownerFirstName;
    private final String ownerPatronymic;
    private final Integer manufactureYear;
    private final Double price;

    public CarEntity(
            Long id,
            String brand,
            String model,
            String color,
            String registrationNumber,
            String ownerLastName,
            String ownerFirstName,
            String ownerPatronymic,
            Integer manufactureYear,
            Double price
    ) {
        this.id = id;
        this.brand = brand;
        this.model = model;
        this.color = color;
        this.registrationNumber = registrationNumber;
        this.ownerLastName = ownerLastName;
        this.ownerFirstName = ownerFirstName;
        this.ownerPatronymic = ownerPatronymic;
        this.manufactureYear = manufactureYear;
        this.price = price;
    }

    public Long getId() {
        return id;
    }

    public String getBrand() {
        return brand;
    }

    public String getModel() {
        return model;
    }

    public String getColor() {
        return color;
    }

    public String getRegistrationNumber() {
        return registrationNumber;
    }

    public String getOwnerLastName() {
        return ownerLastName;
    }

    public String getOwnerFirstName() {
        return ownerFirstName;
    }

    public String getOwnerPatronymic() {
        return ownerPatronymic;
    }

    public Integer getManufactureYear() {
        return manufactureYear;
    }

    public Double getPrice() {
        return price;
    }

    @Override
    public String toString() {
        return String.format(
                "%d. %s %s, цвет: %s, гос. номер: %s, владелец: %s %s %s, год: %d, стоимость: %.2f",
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
        );
    }
}
