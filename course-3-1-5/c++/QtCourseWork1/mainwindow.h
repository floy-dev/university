#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QElapsedTimer>
#include <QStringList>
#include <QTimer>

QT_BEGIN_NAMESPACE
namespace Ui {
class MainWindow;
}
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = nullptr);
    ~MainWindow() override;

protected:
    bool eventFilter(QObject *object, QEvent *event) override;

private slots:
    void on_startButton_clicked();
    void on_difficultyComboBox_currentIndexChanged(int index);
    void updateTimer();

private:
    QStringList loadDictionary(const QString &fileName);
    void showNextTask();
    void updateTaskHighlight();
    void updateStatistics();
    bool checkTime();
    void finishTest(const QString &reason, bool manuallyStopped = false);

    Ui::MainWindow *ui;
    QTimer *testTimer;
    QElapsedTimer testClock;
    QElapsedTimer symbolClock;

    int testDuration = 40;
    int symbolTimeLimit = 3;
    int targetScore = 40;
    int errorPenalty = 1;
    int timeLeft = 40;
    int score = 0;
    int errorCount = 0;
    int taskPosition = 0;
    bool testRunning = false;

    QStringList trainingData;
    QString currentTask;
};
#endif
