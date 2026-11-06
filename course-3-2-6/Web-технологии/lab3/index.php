<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="style.css">
    <title>Свой ход - Главная</title>
</head>
<body>
    <?php include_once 'templates/header.php' ?>
    <main>

        <div class="about column">
            <div class="about__info">КЛУБ НАСТОЛЬНЫХ ИГР</div>
            <div class="row">
                <div class="about__data">
                    <div class="about__title">
                        <p>Хорошая компания начинается с игры</p>
                    </div>
                    <div class="about__description">
                        <p>Приходите с друзьями или знакомьтесь за игровым столом. Поможем выбрать игру и разобраться в правилах</p>
                    </div>
                    <div class="about__buttons row">
                        <button class="button-green about__view-all">Смотреть игры</button>
                        <button class="button-white about__view-schedule">Расписание встреч</button>
                    </div>
                </div>
                <div class="about-image"></div>
            </div>
            <div class="about__posttitle">
                <p>Для новичков и опытных игроков</p>
            </div>
        </div>

        <div class="steps row">
            <div class="step column">
                <p class="step-title">01 Выберите игру</p>
                <p class="step-description">Стратегии, семейные игры и игры для компании</p>
            </div>
            <div class="step column">
                <p class="step-title">02 Садитесь за стол</p>
                <p class="step-description">Можно прийти одному — найдём компанию</p>
            </div>
            <div class="step column">
                <p class="step-title">03 Сделайте свой ход</p>
                <p class="step-description">Объясним правила и поможем начать</p>
            </div>
        </div>

        <?php include_once 'templates/cards.php' ?>

    </main>
    <?php include_once 'templates/footer.php' ?>

    <script type="module" src="src/js/script.js"></script>
</body>
</html>
