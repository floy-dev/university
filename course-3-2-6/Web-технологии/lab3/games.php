<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="style.css">
    <title>Свой ход - Игры</title>
</head>
<body>

    <?php include_once 'templates/header.php' ?>
    <main>
        <div class="games-about column">
            <p class="games__top">НАША КОЛЛЕКЦИЯ</p>
            <p class="games__title">Игры для любого настроения</p>
            <p class="games__description">Выбирайте спокойную стратегию, семейную игру или шумную партию с друзьями</p>
        </div>

        <div class="tabs row">
            <button class="tab tab-active">Все игры</button>
            <button class="tab">Стратегии</button>
            <button class="tab">Для семьи</button>
            <button class="tab">Для компании</button>
        </div>

        <?php include_once 'templates/cards.php' ?>

        <div class="research-tab row">
            <div class="research-left column">
                <p class="research-tab__title">Не знаете, с чего начать?</p>
                <p class="research-tab__description">Расскажите, сколько вас и какие игры вам нравятся — поможем выбрать</p>
            </div>
            <div class="research-right">
                <button class="button-green button-ask-qa">Задать вопрос</button>
            </div>
        </div>
    </main>
    <?php include_once 'templates/footer.php' ?>

<script type="module" src="src/js/script.js"></script>

</body>
</html>
