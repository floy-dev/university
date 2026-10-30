package ru.bstu.itz221.dmitriev.lab5;

public class CarFilter {
    private final Integer minYear;
    private final Integer maxYear;
    private final Double minPrice;
    private final Double maxPrice;

    public CarFilter(
            Integer minYear,
            Integer maxYear,
            Double minPrice,
            Double maxPrice
    ) {
        this.minYear = minYear;
        this.maxYear = maxYear;
        this.minPrice = minPrice;
        this.maxPrice = maxPrice;
    }

    public Integer getMinYear() {
        return minYear;
    }

    public Integer getMaxYear() {
        return maxYear;
    }

    public Double getMinPrice() {
        return minPrice;
    }

    public Double getMaxPrice() {
        return maxPrice;
    }

    public boolean matches(CarEntity car) {
        return (minYear == null || car.getManufactureYear() >= minYear)
                && (maxYear == null || car.getManufactureYear() <= maxYear)
                && (minPrice == null || car.getPrice() >= minPrice)
                && (maxPrice == null || car.getPrice() <= maxPrice);
    }
}
