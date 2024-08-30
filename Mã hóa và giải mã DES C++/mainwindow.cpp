#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "bits/stdc++.h"
#include "des.h"
#include <QFileDialog>
#include <QMessageBox>
#include <QRandomGenerator>

using namespace std;
char letters[] = "0123456789ABCDEF";

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);

}

MainWindow::~MainWindow()
{
    delete ui;
}


string addCharacters(string s){
    for(int i = s.length() ; i < 16 ; i++) s += letters[rand() % 16];
    return s;
}


void MainWindow::on_decript_clicked()
{
    string cipher = ui->cipher2->toPlainText().toStdString();
    string key = ui->key2->toPlainText().toStdString();
    if(key.length() < 16) key = addCharacters(key);
    if(cipher.length() < 16) cipher = addCharacters(cipher);
    if(cipher.length() == 16 and key.length() == 16){
        unsigned long long K, C;
        unsigned int K1, K2, C1, C2;
        C = stoull(cipher, 0, 16);
        K = stoull(key, 0, 16);
        SplitUlonglong(K, K1, K2);
        SplitUlonglong(C, C1, C2);

        unsigned int MC1, MC2;
        GiaiMaDES(C1,C2,K1,K2,MC1,MC2);
        cout << "\nBan giai ma MC = ";
        string message = ShowByte(MC1) +  ShowByte(MC2) ;
        ui->key2->document()->setPlainText(QString::fromStdString(key));
        ui->cipher2->document()->setPlainText(QString::fromStdString(cipher));
        ui->message2->document()->setPlainText(QString::fromStdString(message));
        //QMessageBox::information(this, tr("Thông báo"), tr("Giải mã thành công."));
        QMessageBox msgBox;
        msgBox.setStyleSheet("QMessageBox { background-color: beige; color: black; }");
        msgBox.setWindowTitle(tr("Thông báo"));
        msgBox.setText(tr("Giải mã thành công."));
        msgBox.exec();


    }else{
        //QMessageBox::information(this, tr("Thông báo"), tr("Đầu vào không hợp lệ."));
        QMessageBox msgBox;
        msgBox.setStyleSheet("QMessageBox { background-color: beige; color: black; }");
        msgBox.setWindowTitle(tr("Thông báo"));
        msgBox.setText(tr("Đầu vào không hợp lệ."));
        msgBox.setIcon(QMessageBox::Warning);
        msgBox.exec();
        ui->key2->clear();
        ui->cipher2->clear();
        ui->message2->clear();
    }



}


void MainWindow::on_encript_clicked()
{
    string message = ui->message1->toPlainText().toStdString();
    string key = ui->key1->toPlainText().toStdString();
    if(key.length() < 16) key = addCharacters(key);
    if(message.length() < 16) message = addCharacters(message);
    if(message.length() == 16 and key.length() == 16){
        unsigned long long K, M;
        unsigned int K1, K2, M1, M2;
        M = stoull(message, 0, 16);
        K = stoull(key, 0, 16);
        SplitUlonglong(K, K1, K2);
        SplitUlonglong(M, M1, M2);

        unsigned int C1, C2;
        MahoaDES(M1,M2,K1,K2,C1,C2);
        string cript = ShowByte(C1) + ShowByte(C2) ;
        ui->key1->document()->setPlainText(QString::fromStdString(key));
        ui->message1->document()->setPlainText(QString::fromStdString(message));
        ui->cipher1->document()->setPlainText(QString::fromStdString(cript));
        //QMessageBox::information(this, tr("Thông báo"), tr("Mã hóa thành công."));
        QMessageBox msgBox;
        msgBox.setStyleSheet("QMessageBox { background-color: beige; color: black; }");
        msgBox.setWindowTitle(tr("Thông báo"));
        msgBox.setText(tr("Mã hóa thành công."));
        msgBox.exec();

    }else{
        //QMessageBox::information(this, tr("Thông báo"), tr("Đầu vào không hợp lệ."));
        QMessageBox msgBox;
        msgBox.setStyleSheet("QMessageBox { background-color: beige; color: black; }");
        msgBox.setWindowTitle(tr("Thông báo"));
        msgBox.setText(tr("Đầu vào không hợp lệ."));
        msgBox.setIcon(QMessageBox::Warning);
        msgBox.exec();
        ui->key1->clear();
        ui->message1->clear();
        ui->cipher1->clear();
    }
}



void MainWindow::on_file1_clicked()
{
    QString filename = QFileDialog::getOpenFileName(
        this,
        tr("Open File"),
        "D://",
        "Text File (*.txt)"
        );

    QFile file(filename);
    if (file.open(QIODevice::ReadOnly | QIODevice::Text)) {
        QTextStream in(&file);
        QString fileContent = in.readAll();
        file.close();
        string message = fileContent.toStdString();
        QMessageBox msgBox;
        msgBox.setStyleSheet("QMessageBox { background-color: beige; color: black; }");
        msgBox.setWindowTitle(tr("Thông báo"));
        msgBox.setText(tr("Đã lấy dữ liệu từ file."));
        msgBox.exec();
        ui->message1->document()->setPlainText(QString::fromStdString(message));

    }
    else {
        QMessageBox msgBox;
        msgBox.setStyleSheet("QMessageBox { background-color: beige; color: black; }");
        msgBox.setWindowTitle(tr("Error"));
        msgBox.setText(tr("Có lỗi chi chọn file."));
        msgBox.setIcon(QMessageBox::Warning);
        msgBox.exec();
    }
}


void MainWindow::on_file2_clicked()
{
    QString filename = QFileDialog::getOpenFileName(
        this,
        tr("Open File"),
        "D://",
        "Text File (*.txt)"
        );

    QFile file(filename);
    if (file.open(QIODevice::ReadOnly | QIODevice::Text)) {
        QTextStream in(&file);
        QString fileContent = in.readAll();
        file.close();
        string message = fileContent.toStdString();
        QMessageBox msgBox;
        msgBox.setStyleSheet("QMessageBox { background-color: beige; color: black; }");
        msgBox.setWindowTitle(tr("Thông báo"));
        msgBox.setText(tr("Đã lấy dữ liệu từ file."));
        msgBox.exec();
        ui->cipher2->document()->setPlainText(QString::fromStdString(message));


    }
    else {
        QMessageBox msgBox;
        msgBox.setStyleSheet("QMessageBox { background-color: beige; color: black; }");
        msgBox.setWindowTitle(tr("Error"));
        msgBox.setText(tr("Có lỗi chi chọn file."));
        msgBox.setIcon(QMessageBox::Warning);
        msgBox.exec();
    }
}


void MainWindow::on_reset_clicked()
{
    ui->message1->clear();
    ui->message2->clear();
    ui->key1->clear();
    ui->key2->clear();
    ui->cipher1->clear();
    ui->cipher2->clear();
}


void MainWindow::on_exit_clicked()
{
    delete ui;
}


void MainWindow::on_Save_clicked()
{
    string cript = ui->cipher1->toPlainText().toStdString();
    ofstream outfile;
    outfile.open ("D:/output.txt");
    outfile << cript;
    outfile.close();
    QMessageBox msgBox;
    msgBox.setStyleSheet("QMessageBox { background-color: beige; color: black; }");
    msgBox.setWindowTitle(tr("Thông báo"));
    msgBox.setText(tr("Đã lưu vào D:/output.txt."));
    msgBox.exec();
}


void MainWindow::on_Save_3_clicked()
{
    string message = ui->message2->toPlainText().toStdString();
    ofstream outfile;
    outfile.open ("D:/output2.txt");
    outfile << message;
    outfile.close();
    QMessageBox msgBox;
    msgBox.setStyleSheet("QMessageBox { background-color: beige; color: black; }");
    msgBox.setWindowTitle(tr("Thông báo"));
    msgBox.setText(tr("Đã lưu vào D:/output2.txt."));
    msgBox.exec();
}


void MainWindow::on_kngaunhien_clicked()
{
    QString randomKey;
    for (int i = 0; i < 16; ++i) {
        int randomIndex = QRandomGenerator::global()->bounded(16); // Sinh số ngẫu nhiên từ 0 đến 15
        randomKey.append(letters[randomIndex]); // Thêm ký tự tương ứng từ mảng 'letters'
    }

    // Hiển thị khóa ngẫu nhiên vào ô nhập khóa
    ui->key1->document()->setPlainText(randomKey);
}


void MainWindow::on_kngaunhien_2_clicked()
{
    QString randomKey;
    for (int i = 0; i < 16; ++i) {
        int randomIndex = QRandomGenerator::global()->bounded(16); // Sinh số ngẫu nhiên từ 0 đến 15
        randomKey.append(letters[randomIndex]); // Thêm ký tự tương ứng từ mảng 'letters'
    }

    // Hiển thị khóa ngẫu nhiên vào ô nhập khóa
    ui->key2->document()->setPlainText(randomKey);
}


