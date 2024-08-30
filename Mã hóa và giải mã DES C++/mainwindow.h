#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>

QT_BEGIN_NAMESPACE
namespace Ui {
class MainWindow;
}
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private slots:
    void on_encript_clicked();

    void on_decript_clicked();

    void on_file1_clicked();

    void on_file2_clicked();

    void on_reset_clicked();

    void on_exit_clicked();

    void on_Save_clicked();

    void on_Save_3_clicked();

    void on_kngaunhien_clicked();

    void on_kngaunhien_2_clicked();

private:
    Ui::MainWindow *ui;
};
#endif // MAINWINDOW_H
