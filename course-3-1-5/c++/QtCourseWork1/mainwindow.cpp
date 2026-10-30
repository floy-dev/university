#include "mainwindow.h"
#include "ui_mainwindow.h"

#include <QFile>
#include <QEvent>
#include <QKeyEvent>
#include <QRandomGenerator>
#include <QStringConverter>
#include <QTextStream>
#include <QtMath>

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    testTimer = new QTimer(this);
    testTimer->setInterval(50);
    testTimer->setTimerType(Qt::PreciseTimer);
    connect(testTimer, &QTimer::timeout, this, &MainWindow::updateTimer);

    ui->typingLineEdit->setReadOnly(true);
    ui->typingLineEdit->setEnabled(false);
    ui->typingLineEdit->installEventFilter(this);

    ui->feedbackLabel->setEnabled(true);
    ui->taskTextLabel->setTextFormat(Qt::RichText);

    on_difficultyComboBox_currentIndexChanged(ui->difficultyComboBox->currentIndex());

    QStringList letters = loadDictionary(":/library/letters.ru.dic");
    QStringList syllables = loadDictionary(":/library/syllables.ru.dic");
    QStringList words = loadDictionary(":/library/words.ru.dic");

    if (letters.isEmpty() || syllables.isEmpty() || words.isEmpty()) {
        ui->feedbackLabel->setText(QStringLiteral("Не удалось загрузить словари или один из них пуст"));
        ui->startButton->setEnabled(false);
        return;
    }

    trainingData = letters + syllables + words;
}

MainWindow::~MainWindow()
{
    testTimer->stop();
    delete ui;
}

void MainWindow::on_startButton_clicked()
{
    if (testRunning) {
        if (checkTime()) {
            finishTest(QStringLiteral("Остановлено пользователем"), true);
        }
        return;
    }

    if (trainingData.isEmpty()) {
        ui->feedbackLabel->setText(QStringLiteral("Словари пусты"));
        return;
    }

    score = 0;
    errorCount = 0;
    timeLeft = testDuration;
    testRunning = true;

    testClock.start();
    symbolClock.start();

    ui->difficultyComboBox->setEnabled(false);
    ui->startButton->setText("Завершить");
    ui->taskCaptionLabel->setText("Задание:");

    ui->typingLineEdit->show();
    ui->typingLineEdit->setEnabled(true);

    ui->feedbackLabel->setText("Введите выделенную букву | Ошибок: 0");

    showNextTask();
    updateStatistics();

    testTimer->start();

    ui->typingLineEdit->setFocus();
}

bool MainWindow::eventFilter(QObject *object, QEvent *event)
{
    if (object != ui->typingLineEdit || event->type() != QEvent::KeyPress) {
        return QMainWindow::eventFilter(object, event);
    }

    if (!testRunning) {
        return true;
    }

    QKeyEvent *keyEvent = static_cast<QKeyEvent *>(event);
    if (keyEvent->modifiers() & (Qt::ControlModifier | Qt::AltModifier | Qt::MetaModifier)) {
        return QMainWindow::eventFilter(object, event);
    }

    QString text = keyEvent->text();
    if (text.isEmpty() || !text.at(0).isPrint()) {
        return QMainWindow::eventFilter(object, event);
    }

    if (!checkTime()) {
        return true;
    }

    if (text.size() == 1 && text.at(0) == currentTask.at(taskPosition)) {
        score++;
        taskPosition++;
        symbolClock.restart();

        if (taskPosition == currentTask.size()) {
            showNextTask();
        } else {
            ui->typingLineEdit->setText(currentTask.left(taskPosition));
            ui->typingLineEdit->setCursorPosition(taskPosition);
            updateTaskHighlight();
        }

        ui->feedbackLabel->setStyleSheet(QStringLiteral("color: #616161;"));
        ui->feedbackLabel->setText(
            QStringLiteral("Введите выделенную букву | Ошибок: %1").arg(errorCount));
    } else {
        ++errorCount;
        score -= errorPenalty;
        ui->feedbackLabel->setStyleSheet(QStringLiteral("color: #b42318;"));
        ui->feedbackLabel->setText(
            QStringLiteral("Неверно — нужна буква «%1» | Ошибок: %2")
                .arg(currentTask.mid(taskPosition, 1)).arg(errorCount));
    }

    updateStatistics();
    return true;
}

void MainWindow::showNextTask()
{
    int index = QRandomGenerator::global()->bounded(static_cast<int>(trainingData.size()));
    currentTask = trainingData[index];
    taskPosition = 0;
    ui->typingLineEdit->clear();
    updateTaskHighlight();
}

void MainWindow::updateTaskHighlight()
{
    QString text;

    for (int i = 0; i < currentTask.size(); ++i) {
        QString letter = currentTask.mid(i, 1).toHtmlEscaped();

        if (i < taskPosition) {
            text += QStringLiteral("<span style=\"color: #16803c;\">%1</span>").arg(letter);
        } else if (i == taskPosition) {
            text += QStringLiteral("<span style=\"color: #005fb8; background-color: #e6f2ff; text-decoration: underline;\">%1</span>").arg(letter);
        } else {
            text += QStringLiteral("<span style=\"color: #202020;\">%1</span>").arg(letter);
        }
    }

    ui->taskTextLabel->setText(text);
}

void MainWindow::updateStatistics()
{
    if (testRunning) {
        timeLeft = testDuration - static_cast<int>(testClock.elapsed() / 1000);
        if (timeLeft < 0) {
            timeLeft = 0;
        }
    }

    ui->remainingTimeLabel->setText(
        QStringLiteral("Осталось: 00:%1").arg(timeLeft, 2, 10, QChar('0')));
    ui->scoreLabel->setText(QStringLiteral("Очки: %1 / %2").arg(score).arg(targetScore));
}

bool MainWindow::checkTime()
{
    if (!testRunning) {
        return false;
    }

    if (testClock.elapsed() >= testDuration * 1000) {
        finishTest(QStringLiteral("Время теста истекло"));
        return false;
    }

    if (symbolClock.elapsed() >= symbolTimeLimit * 1000) {
        finishTest(QStringLiteral("Время на ввод буквы истекло"));
        return false;
    }

    return true;
}

void MainWindow::updateTimer()
{
    if (checkTime()) {
        updateStatistics();
    }
}

void MainWindow::finishTest(const QString &reason, bool manuallyStopped)
{
    if (!testRunning) {
        return;
    }

    testTimer->stop();
    updateStatistics();
    testRunning = false;

    double elapsedSeconds = testClock.elapsed() / 1000.0;
    if (elapsedSeconds > testDuration) {
        elapsedSeconds = testDuration;
    }

    int speed = 0;
    if (elapsedSeconds > 0 && score > 0) {
        speed = qRound(score * 60.0 / elapsedSeconds);
    }

    ui->taskCaptionLabel->setText(reason);
    if (manuallyStopped) {
        ui->taskTextLabel->setText(QStringLiteral("Тест остановлен"));
    } else if (score >= targetScore) {
        ui->taskTextLabel->setText(QStringLiteral("<span style=\"color: #16803c;\">Тест пройден</span>"));
    } else {
        ui->taskTextLabel->setText(QStringLiteral("<span style=\"color: #b42318;\">Тест не пройден</span>"));
    }

    ui->typingLineEdit->setEnabled(false);
    ui->typingLineEdit->hide();
    ui->difficultyComboBox->setEnabled(true);
    ui->startButton->setText(QStringLiteral("Ещё раз"));
    ui->feedbackLabel->setStyleSheet(QStringLiteral("color: #616161;"));
    ui->feedbackLabel->setText(
        QStringLiteral("Ошибок: %1 | Скорость: %2 симв/мин").arg(errorCount).arg(speed));
    ui->startButton->setFocus();
}

QStringList MainWindow::loadDictionary(const QString &fileName)
{
    QStringList dictionary;
    QFile file(fileName);

    if (!file.open(QIODevice::ReadOnly)) {
        return dictionary;
    }

    QTextStream stream(&file);
    stream.setEncoding(QStringConverter::Utf8);

    while (!stream.atEnd()) {
        QString text = stream.readLine().trimmed();
        if (!text.isEmpty()) {
            dictionary.append(text);
        }
    }

    return dictionary;
}

void MainWindow::on_difficultyComboBox_currentIndexChanged(int index)
{
    if (testRunning) {
        return;
    }

    switch (index) {
    case 0:
        testDuration = 40;
        symbolTimeLimit = 3;
        targetScore = 40;
        errorPenalty = 1;
        break;
    case 1:
        testDuration = 30;
        symbolTimeLimit = 2;
        targetScore = 60;
        errorPenalty = 2;
        break;
    case 2:
        testDuration = 25;
        symbolTimeLimit = 1;
        targetScore = 80;
        errorPenalty = 3;
        break;
    default:
        return;
    }

    const QString secondsWord = symbolTimeLimit == 1
        ? QStringLiteral("секунда")
        : QStringLiteral("секунды");
    const QString pointsWord = errorPenalty == 1
        ? QStringLiteral("очко")
        : QStringLiteral("очка");

    ui->testDurationLabel->setText(
        QStringLiteral("%1 секунд на тест").arg(testDuration));
    ui->symbolTimeLimitLabel->setText(
        QStringLiteral("%1 %2 на символ").arg(symbolTimeLimit).arg(secondsWord));
    ui->targetScoreLabel->setText(
        QStringLiteral("Цель: %1 очков").arg(targetScore));
    ui->errorPenaltyLabel->setText(
        QStringLiteral("Ошибка: -%1 %2").arg(errorPenalty).arg(pointsWord));
    score = 0;
    errorCount = 0;
    taskPosition = 0;
    timeLeft = testDuration;
    ui->taskCaptionLabel->setText(QStringLiteral("Задание:"));
    ui->taskTextLabel->setText(QStringLiteral("Вода"));
    ui->typingLineEdit->clear();
    ui->typingLineEdit->show();
    ui->typingLineEdit->setEnabled(false);
    ui->feedbackLabel->setStyleSheet(QStringLiteral("color: #616161;"));
    ui->feedbackLabel->setText(QStringLiteral("Нажмите начать тренировку"));
    ui->startButton->setText(QStringLiteral("Начать тренировку"));
    updateStatistics();
}
