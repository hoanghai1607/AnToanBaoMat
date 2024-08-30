/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 6.7.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QSlider>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QTextEdit>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralwidget;
    QLabel *label;
    QLabel *label_2;
    QTextEdit *message1;
    QLabel *label_3;
    QTextEdit *key1;
    QPushButton *file1;
    QPushButton *encript;
    QLabel *label_4;
    QTextEdit *cipher1;
    QPushButton *file2;
    QLabel *label_5;
    QTextEdit *key2;
    QLabel *label_6;
    QTextEdit *cipher2;
    QLabel *label_7;
    QPushButton *decript;
    QLabel *label_8;
    QTextEdit *message2;
    QPushButton *reset;
    QPushButton *exit;
    QSlider *verticalSlider;
    QPushButton *Save;
    QPushButton *Save_3;
    QPushButton *kngaunhien;
    QPushButton *kngaunhien_2;
    QLabel *label_9;
    QMenuBar *menubar;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName("MainWindow");
        MainWindow->resize(1065, 573);
        MainWindow->setStyleSheet(QString::fromUtf8("background-color: rgb(206, 238, 255);\n"
"font: 700 10pt \"Comic Sans MS\";"));
        centralwidget = new QWidget(MainWindow);
        centralwidget->setObjectName("centralwidget");
        label = new QLabel(centralwidget);
        label->setObjectName("label");
        label->setGeometry(QRect(-8, 35, 541, 31));
        label->setStyleSheet(QString::fromUtf8("background-color: rgb(255, 244, 84);\n"
"font: 700 bold 13pt \"Comic Sans MS\";"));
        label->setAlignment(Qt::AlignBottom|Qt::AlignHCenter);
        label_2 = new QLabel(centralwidget);
        label_2->setObjectName("label_2");
        label_2->setGeometry(QRect(40, 85, 61, 21));
        message1 = new QTextEdit(centralwidget);
        message1->setObjectName("message1");
        message1->setGeometry(QRect(40, 110, 331, 91));
        message1->setStyleSheet(QString::fromUtf8("background-color: rgb(246, 255, 255);\n"
"border-radius: 10px;\n"
""));
        label_3 = new QLabel(centralwidget);
        label_3->setObjectName("label_3");
        label_3->setGeometry(QRect(40, 230, 51, 16));
        key1 = new QTextEdit(centralwidget);
        key1->setObjectName("key1");
        key1->setGeometry(QRect(40, 250, 331, 31));
        key1->setStyleSheet(QString::fromUtf8("background-color: rgb(246, 255, 255);\n"
"border-radius: 10px;\n"
""));
        file1 = new QPushButton(centralwidget);
        file1->setObjectName("file1");
        file1->setGeometry(QRect(400, 140, 81, 31));
        file1->setAutoFillBackground(false);
        file1->setStyleSheet(QString::fromUtf8("\n"
"background-color: rgb(148, 106, 255);\n"
"border-radius: 10px;"));
        encript = new QPushButton(centralwidget);
        encript->setObjectName("encript");
        encript->setGeometry(QRect(160, 300, 80, 31));
        encript->setStyleSheet(QString::fromUtf8("background-color: rgb(148, 106, 255);\n"
"border-radius: 10px;"));
        label_4 = new QLabel(centralwidget);
        label_4->setObjectName("label_4");
        label_4->setGeometry(QRect(40, 350, 71, 16));
        cipher1 = new QTextEdit(centralwidget);
        cipher1->setObjectName("cipher1");
        cipher1->setGeometry(QRect(40, 370, 331, 91));
        cipher1->setStyleSheet(QString::fromUtf8("background-color: rgb(246, 255, 255);\n"
"border-radius: 10px;\n"
""));
        cipher1->setReadOnly(true);
        file2 = new QPushButton(centralwidget);
        file2->setObjectName("file2");
        file2->setGeometry(QRect(940, 140, 81, 31));
        file2->setStyleSheet(QString::fromUtf8("\n"
"background-color: rgb(148, 106, 255);\n"
"border-radius: 10px;"));
        label_5 = new QLabel(centralwidget);
        label_5->setObjectName("label_5");
        label_5->setGeometry(QRect(539, 35, 531, 31));
        label_5->setStyleSheet(QString::fromUtf8("background-color: rgb(255, 244, 84);\n"
"font: 700 bold 13pt \"Comic Sans MS\";"));
        label_5->setAlignment(Qt::AlignBottom|Qt::AlignHCenter);
        key2 = new QTextEdit(centralwidget);
        key2->setObjectName("key2");
        key2->setGeometry(QRect(580, 250, 331, 31));
        key2->setStyleSheet(QString::fromUtf8("background-color: rgb(246, 255, 255);\n"
"border-radius: 10px;\n"
""));
        label_6 = new QLabel(centralwidget);
        label_6->setObjectName("label_6");
        label_6->setGeometry(QRect(580, 230, 61, 16));
        cipher2 = new QTextEdit(centralwidget);
        cipher2->setObjectName("cipher2");
        cipher2->setGeometry(QRect(580, 110, 331, 91));
        cipher2->setStyleSheet(QString::fromUtf8("background-color: rgb(246, 255, 255);\n"
"border-radius: 10px;"));
        label_7 = new QLabel(centralwidget);
        label_7->setObjectName("label_7");
        label_7->setGeometry(QRect(580, 90, 61, 16));
        decript = new QPushButton(centralwidget);
        decript->setObjectName("decript");
        decript->setGeometry(QRect(720, 300, 80, 31));
        decript->setStyleSheet(QString::fromUtf8("background-color: rgb(148, 106, 255);\n"
"border-radius: 10px;"));
        label_8 = new QLabel(centralwidget);
        label_8->setObjectName("label_8");
        label_8->setGeometry(QRect(580, 350, 61, 16));
        message2 = new QTextEdit(centralwidget);
        message2->setObjectName("message2");
        message2->setGeometry(QRect(580, 370, 331, 91));
        message2->setStyleSheet(QString::fromUtf8("background-color: rgb(246, 255, 255);\n"
"border-radius: 10px;\n"
""));
        message2->setReadOnly(true);
        reset = new QPushButton(centralwidget);
        reset->setObjectName("reset");
        reset->setGeometry(QRect(430, 510, 80, 31));
        reset->setStyleSheet(QString::fromUtf8("background-color: rgb(0, 170, 0);\n"
"border-radius: 10px;"));
        exit = new QPushButton(centralwidget);
        exit->setObjectName("exit");
        exit->setGeometry(QRect(560, 510, 80, 31));
        exit->setStyleSheet(QString::fromUtf8("background-color: rgb(0, 170, 0);\n"
"border-radius: 10px;"));
        verticalSlider = new QSlider(centralwidget);
        verticalSlider->setObjectName("verticalSlider");
        verticalSlider->setGeometry(QRect(528, 30, 16, 521));
        verticalSlider->setStyleSheet(QString::fromUtf8("background-color: rgb(255, 173, 8);"));
        verticalSlider->setOrientation(Qt::Vertical);
        Save = new QPushButton(centralwidget);
        Save->setObjectName("Save");
        Save->setGeometry(QRect(400, 400, 81, 31));
        Save->setStyleSheet(QString::fromUtf8("background-color: rgb(148, 106, 255);\n"
"border-radius: 10px;"));
        Save_3 = new QPushButton(centralwidget);
        Save_3->setObjectName("Save_3");
        Save_3->setGeometry(QRect(940, 380, 81, 31));
        Save_3->setStyleSheet(QString::fromUtf8("background-color: rgb(148, 106, 255);\n"
"border-radius: 10px;"));
        kngaunhien = new QPushButton(centralwidget);
        kngaunhien->setObjectName("kngaunhien");
        kngaunhien->setGeometry(QRect(400, 250, 101, 31));
        kngaunhien->setAutoFillBackground(false);
        kngaunhien->setStyleSheet(QString::fromUtf8("\n"
"background-color: rgb(148, 106, 255);\n"
"border-radius: 10px;"));
        kngaunhien_2 = new QPushButton(centralwidget);
        kngaunhien_2->setObjectName("kngaunhien_2");
        kngaunhien_2->setGeometry(QRect(940, 250, 101, 31));
        kngaunhien_2->setAutoFillBackground(false);
        kngaunhien_2->setStyleSheet(QString::fromUtf8("\n"
"background-color: rgb(148, 106, 255);\n"
"border-radius: 10px;"));
        label_9 = new QLabel(centralwidget);
        label_9->setObjectName("label_9");
        label_9->setGeometry(QRect(0, -6, 1081, 41));
        label_9->setStyleSheet(QString::fromUtf8("background-color: rgb(255, 170, 255);\n"
"font: 700 bold 19pt \"Comic Sans MS\";"));
        label_9->setAlignment(Qt::AlignBottom|Qt::AlignHCenter);
        MainWindow->setCentralWidget(centralwidget);
        menubar = new QMenuBar(MainWindow);
        menubar->setObjectName("menubar");
        menubar->setGeometry(QRect(0, 0, 1065, 24));
        MainWindow->setMenuBar(menubar);
        statusbar = new QStatusBar(MainWindow);
        statusbar->setObjectName("statusbar");
        MainWindow->setStatusBar(statusbar);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QCoreApplication::translate("MainWindow", "MainWindow", nullptr));
        label->setText(QCoreApplication::translate("MainWindow", "M\303\203 H\303\223A", nullptr));
        label_2->setText(QCoreApplication::translate("MainWindow", "B\341\272\242N R\303\225", nullptr));
        label_3->setText(QCoreApplication::translate("MainWindow", "KH\303\223A K", nullptr));
        file1->setText(QCoreApplication::translate("MainWindow", "CH\341\273\214N FILE", nullptr));
        encript->setText(QCoreApplication::translate("MainWindow", "M\303\203 H\303\223A", nullptr));
        label_4->setText(QCoreApplication::translate("MainWindow", "B\341\272\242N M\303\203", nullptr));
        file2->setText(QCoreApplication::translate("MainWindow", "CH\341\273\214N FILE", nullptr));
        label_5->setText(QCoreApplication::translate("MainWindow", "GI\341\272\242I M\303\203", nullptr));
        label_6->setText(QCoreApplication::translate("MainWindow", "KH\303\223A K", nullptr));
        label_7->setText(QCoreApplication::translate("MainWindow", "B\341\272\242N M\303\203", nullptr));
        decript->setText(QCoreApplication::translate("MainWindow", "GI\341\272\242I M\303\203", nullptr));
        label_8->setText(QCoreApplication::translate("MainWindow", "B\341\272\242N R\303\225", nullptr));
        reset->setText(QCoreApplication::translate("MainWindow", "RESET", nullptr));
        exit->setText(QCoreApplication::translate("MainWindow", "THO\303\201T", nullptr));
        Save->setText(QCoreApplication::translate("MainWindow", "SAVE FILE", nullptr));
        Save_3->setText(QCoreApplication::translate("MainWindow", "SAVE FILE", nullptr));
        kngaunhien->setText(QCoreApplication::translate("MainWindow", "NG\341\272\252U NHI\303\212N", nullptr));
        kngaunhien_2->setText(QCoreApplication::translate("MainWindow", "NG\341\272\252U NHI\303\212N", nullptr));
        label_9->setText(QCoreApplication::translate("MainWindow", "THU\341\272\254T TO\303\201N DES", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
