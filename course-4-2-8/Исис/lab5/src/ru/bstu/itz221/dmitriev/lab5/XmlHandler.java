package ru.bstu.itz221.dmitriev.lab5;

import org.w3c.dom.Document;
import org.w3c.dom.Element;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;
import javax.xml.transform.OutputKeys;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.ArrayList;
import java.util.List;

public class XmlHandler implements CarHandlerInterface {
    private final Path xmlPath;
    private final String errorMessage;

    public XmlHandler(Path xmlPath, String errorMessage) {
        this.xmlPath = xmlPath;
        this.errorMessage = errorMessage;
    }

    @Override
    public void create(CarEntity car) {
        List<CarEntity> cars = select();

        checkUnique(cars, car, null);
        cars.add(car);
        write(cars);
    }

    @Override
    public void update(CarEntity car) {
        List<CarEntity> cars = select();
        int index = findIndex(cars, car.getId());

        if (index == -1) {
            throw new IllegalArgumentException("Автомобиль с таким ID не найден");
        }

        checkUnique(cars, car, car.getId());
        cars.set(index, car);
        write(cars);
    }

    @Override
    public void delete(Long id) {
        List<CarEntity> cars = select();
        int index = findIndex(cars, id);

        if (index == -1) {
            throw new IllegalArgumentException("Автомобиль с таким ID не найден");
        }

        cars.remove(index);
        write(cars);
    }

    @Override
    public List<CarEntity> select() {
        if (Files.notExists(xmlPath)) {
            return new ArrayList<>();
        }

        try {
            SAXParserFactory factory = SAXParserFactory.newInstance();
            SAXParser parser = factory.newSAXParser();
            XmlCarHandler handler = new XmlCarHandler();

            parser.parse(xmlPath.toFile(), handler);

            return handler.getCars();
        } catch (Exception exception) {
            throw new IllegalStateException(errorMessage + exception.getMessage(), exception);
        }
    }

    @Override
    public CarEntity select(Long id) {
        for (CarEntity car : select()) {
            if (car.getId().equals(id)) {
                return car;
            }
        }

        return null;
    }

    @Override
    public List<CarEntity> select(CarFilter filter) {
        List<CarEntity> result = new ArrayList<>();

        for (CarEntity car : select()) {
            if (filter.matches(car)) {
                result.add(car);
            }
        }

        return result;
    }

    @Override
    public void clear() {
        write(new ArrayList<>());
    }

    private int findIndex(List<CarEntity> cars, Long id) {
        for (int i = 0; i < cars.size(); i++) {
            if (cars.get(i).getId().equals(id)) {
                return i;
            }
        }

        return -1;
    }

    private void checkUnique(List<CarEntity> cars, CarEntity newCar, Long ignoredId) {
        for (CarEntity car : cars) {
            boolean isAnotherCar = ignoredId == null || !car.getId().equals(ignoredId);

            if (isAnotherCar && car.getId().equals(newCar.getId())) {
                throw new IllegalArgumentException("Автомобиль с таким ID уже существует");
            }

            if (isAnotherCar && car.getRegistrationNumber().equalsIgnoreCase(newCar.getRegistrationNumber())) {
                throw new IllegalArgumentException("Автомобиль с таким гос. номером уже существует");
            }
        }
    }

    private void write(List<CarEntity> cars) {
        try {
            Files.createDirectories(xmlPath.getParent());

            DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = factory.newDocumentBuilder();
            Document document = builder.newDocument();

            Element root = document.createElement("cars");
            root.setAttribute("version", "1");
            document.appendChild(root);

            for (CarEntity car : cars) {
                root.appendChild(createCarElement(document, car));
            }

            Transformer transformer = TransformerFactory.newInstance().newTransformer();
            transformer.setOutputProperty(OutputKeys.ENCODING, "UTF-8");
            transformer.setOutputProperty(OutputKeys.INDENT, "yes");
            transformer.setOutputProperty("{http://xml.apache.org/xslt}indent-amount", "4");
            transformer.transform(new DOMSource(document), new StreamResult(xmlPath.toFile()));
        } catch (Exception exception) {
            throw new IllegalStateException(errorMessage + exception.getMessage(), exception);
        }
    }

    private Element createCarElement(Document document, CarEntity car) {
        Element carElement = document.createElement("car");
        carElement.setAttribute("id", car.getId().toString());

        appendElement(document, carElement, "brand", car.getBrand());
        appendElement(document, carElement, "model", car.getModel());
        appendElement(document, carElement, "color", car.getColor());
        appendElement(document, carElement, "registrationNumber", car.getRegistrationNumber());

        Element owner = document.createElement("owner");
        appendElement(document, owner, "lastName", car.getOwnerLastName());
        appendElement(document, owner, "firstName", car.getOwnerFirstName());
        appendElement(document, owner, "patronymic", car.getOwnerPatronymic());
        carElement.appendChild(owner);

        appendElement(document, carElement, "manufactureYear", car.getManufactureYear().toString());
        appendElement(document, carElement, "price", car.getPrice().toString());

        return carElement;
    }

    private void appendElement(Document document, Element parent, String name, String value) {
        Element element = document.createElement(name);
        element.appendChild(document.createTextNode(value));
        parent.appendChild(element);
    }
}
