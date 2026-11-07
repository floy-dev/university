<?php
    ini_set('display_errors', '1');
    error_reporting(E_ALL);

    $errors = [];

    if ($_SERVER["REQUEST_METHOD"] === "POST") {

        $name = htmlspecialchars(trim($_POST['name']), ENT_QUOTES, 'UTF-8');
        $email = htmlspecialchars(trim($_POST['email']), ENT_QUOTES, 'UTF-8');
        $message = htmlspecialchars(trim($_POST['message']), ENT_QUOTES, 'UTF-8');

        $isValid = true;

        if (mb_strlen($name) < 2 || mb_strlen($name) > 10) {
            $errors['name'] = 'Неверное имя пользователя';
            $isValid = false;
        }

        if (preg_match('/^[^\s@]+@[^\s@]+\.[^\s@]+$/', $email) === 0) {
            $errors['email'] = 'Неверный Email';
            $isValid = false;
        }

        if (mb_strlen($message) > 1000) {
            $errors['message'] = 'Сообщение слишком большое';
            $isValid = false;
        }

        if ($isValid) {
            $to = 'svoy-hod@mail.ru';
            $subject = 'Свой ход - Новое сообщение';
            $mailMessage = sprintf('Пользователь: `%s`, email: `%s`, оставил следующее сообщение: %s', $name, $email, $message);
            $headers = 'From: svoy-hod@mail.ru' . "\r\n" . 'X-Mailer: PHP/' . phpversion();

            try {
                mail($to, $subject, $mailMessage, $headers);
            }
            catch (Exception $e) {
                // затычка
            }
        }
    }

?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="style.css">
    <title>Свой ход - Контакты</title>
</head>
<body>

    <?php include_once 'templates/header.php' ?>
    <main>
        <div class="games-about column">
            <p class="games__top">ОСТАЁМСЯ НА СВЯЗИ</p>
            <p class="games__title">Приходите играть</p>
            <p class="games__description">Поможем выбрать встречу, найти компанию и ответим на ваши вопросы</p>
        </div>

        <div class="contacts row">
            <div class="contacts-left column">
                <div class="contacts-about-us column">
                    <p class="contacts-about-us__title">Клуб «Свой ход»</p>
                    <p class="contacts-about-us__label">Адрес клуба</p>
                    <p class="contacts-about-us__data">Славянская ул., 15</p>
                    <p class="contacts-about-us__label">Электронная почта</p>
                    <p class="contacts-about-us__data">svoy-hod@mail.ru</p>
                    <p class="contacts-about-us__label">Часы работы</p>
                    <p class="contacts-about-us__data">14:00 - 23:00</p>
                </div>
                <div class="contacts-qa column">
                    <p class="contacts-qa__label">Можно прийти одному?</p>
                    <p class="contacts-qa__data">Да, ведущий поможет найти компанию и подходящую игру</p>
                    <p class="contacts-qa__label">Нужно ли знать правила?</p>
                    <p class="contacts-qa__data">Нет, мы объясним всё перед началом партии</p>
                </div>
            </div>
            <div class="contacts-right column">
                <p class="contacts-form__title">Напишите нам</p>
                <p class="contacts-form__description">Оставьте сообщение — мы ответим на ваш email</p>
                <form class="contacts-form column" method="post" action="contacts.php">
                    <div class="column">
                        <label class="contacts-form__label" for="name">Представьтесь</label>
                        <input class="contacts-form__input" name="name" id="name" placeholder="Ваше имя"
                            <?php
                                if (!empty($name)) {
                                    echo 'value="' . $name . '"';
                                }
                            ?>
                        >
                        <?php
                            echo !empty($errors['name'])
                                ? '<p class="contacts-form__error">' . $errors['name'] . '</p>'
                                : '';
                        ?>
                    </div>
                    <div class="column">
                        <label class="contacts-form__label" for="email">Ваш E-mail</label>
                        <input class="contacts-form__input" name="email" id="email" placeholder="name@example.com"
                            <?php
                                if (!empty($email)) {
                                    echo 'value="' . $email . '"';
                                }
                            ?>
                        >
                        <?php
                            echo !empty($errors['email'])
                                    ? '<p class="contacts-form__error">' . $errors['email'] . '</p>'
                                    : '';
                        ?>
                    </div>
                    <div class="column">
                        <label class="contacts-form__label" for="message">Текст сообщения</label>
                        <input class="contacts-form__input" name="message" id="message" placeholder="Что вы хотели бы узнать?"
                            <?php
                                if (!empty($message)) {
                                    echo 'value="' . $message . '"';
                                }
                            ?>
                        >
                        <?php
                            echo !empty($errors['message'])
                                    ? '<p class="contacts-form__error">' . $errors['message'] . '</p>'
                                    : '';
                        ?>
                    </div>
                    <button class="button-green" type="submit">Отправить сообщение</button>
                    <p class="contacts-form__hint">Все поля обязательны для заполнения</p>
                </form>
            </div>
        </div>
    </main>

    <?php include_once 'templates/footer.php' ?>

    <script type="module" src="src/js/script.js"></script>
</body>
</html>
