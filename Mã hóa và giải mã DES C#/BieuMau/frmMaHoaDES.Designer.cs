
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace MaHoaDES.BieuMau
{
    partial class frmMaHoaDES:Form

    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        // Thiết lập màu sắc cho các thành phần trong frmMaHoaDES

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BoxTextCrypt = new System.Windows.Forms.GroupBox();
            this.btnChiaKhoaNgauNhien2_Click = new MaHoaDES.BieuMau.RoundedButton();
            this.btnLuuVanBan2_Click = new MaHoaDES.BieuMau.RoundedButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKhoaVanBan2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVanBanDich2 = new MaHoaDES.BieuMau.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVanBanNguon2 = new MaHoaDES.BieuMau.CustomTextBox();
            this.btnClear2 = new MaHoaDES.BieuMau.RoundedButton();
            this.txtFileNguon2 = new System.Windows.Forms.TextBox();
            this.btnChonFile2 = new MaHoaDES.BieuMau.RoundedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGiaiMaVanBan = new MaHoaDES.BieuMau.RoundedButton();
            this.txtKhoaVanBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxFileCrypt = new System.Windows.Forms.GroupBox();
            this.btnChiaKhoaNgauNhien_Click = new MaHoaDES.BieuMau.RoundedButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChuyen_Click = new MaHoaDES.BieuMau.RoundedButton();
            this.btnLuuVanBan_Click = new MaHoaDES.BieuMau.RoundedButton();
            this.txtFileNguon = new System.Windows.Forms.TextBox();
            this.btnClear = new MaHoaDES.BieuMau.RoundedButton();
            this.txtVanBanDich = new MaHoaDES.BieuMau.CustomTextBox();
            this.txtVanBanNguon = new MaHoaDES.BieuMau.CustomTextBox();
            this.btnMaHoaVanBan = new MaHoaDES.BieuMau.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonFile = new MaHoaDES.BieuMau.RoundedButton();
            this.lblEncryptedFilename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BoxTextCrypt.SuspendLayout();
            this.BoxFileCrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxTextCrypt
            // 
            this.BoxTextCrypt.BackColor = System.Drawing.Color.MistyRose;
            this.BoxTextCrypt.Controls.Add(this.btnChiaKhoaNgauNhien2_Click);
            this.BoxTextCrypt.Controls.Add(this.btnLuuVanBan2_Click);
            this.BoxTextCrypt.Controls.Add(this.label8);
            this.BoxTextCrypt.Controls.Add(this.txtKhoaVanBan2);
            this.BoxTextCrypt.Controls.Add(this.label7);
            this.BoxTextCrypt.Controls.Add(this.txtVanBanDich2);
            this.BoxTextCrypt.Controls.Add(this.label6);
            this.BoxTextCrypt.Controls.Add(this.txtVanBanNguon2);
            this.BoxTextCrypt.Controls.Add(this.btnClear2);
            this.BoxTextCrypt.Controls.Add(this.txtFileNguon2);
            this.BoxTextCrypt.Controls.Add(this.btnChonFile2);
            this.BoxTextCrypt.Controls.Add(this.label4);
            this.BoxTextCrypt.Controls.Add(this.btnGiaiMaVanBan);
            this.BoxTextCrypt.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BoxTextCrypt.ForeColor = System.Drawing.Color.Teal;
            this.BoxTextCrypt.Location = new System.Drawing.Point(590, 13);
            this.BoxTextCrypt.Margin = new System.Windows.Forms.Padding(4);
            this.BoxTextCrypt.Name = "BoxTextCrypt";
            this.BoxTextCrypt.Padding = new System.Windows.Forms.Padding(4);
            this.BoxTextCrypt.Size = new System.Drawing.Size(586, 634);
            this.BoxTextCrypt.TabIndex = 26;
            this.BoxTextCrypt.TabStop = false;
            this.BoxTextCrypt.Text = "GIẢI MÃ";
            // 
            // btnChiaKhoaNgauNhien2_Click
            // 
            this.btnChiaKhoaNgauNhien2_Click.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChiaKhoaNgauNhien2_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiaKhoaNgauNhien2_Click.Font = new System.Drawing.Font("Arial", 5F, System.Drawing.FontStyle.Bold);
            this.btnChiaKhoaNgauNhien2_Click.ForeColor = System.Drawing.Color.White;
            this.btnChiaKhoaNgauNhien2_Click.Location = new System.Drawing.Point(451, 342);
            this.btnChiaKhoaNgauNhien2_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnChiaKhoaNgauNhien2_Click.Name = "btnChiaKhoaNgauNhien2_Click";
            this.btnChiaKhoaNgauNhien2_Click.Size = new System.Drawing.Size(135, 28);
            this.btnChiaKhoaNgauNhien2_Click.TabIndex = 32;
            this.btnChiaKhoaNgauNhien2_Click.Text = "Khóa ngẫu nhiên";
            this.btnChiaKhoaNgauNhien2_Click.UseVisualStyleBackColor = false;
            this.btnChiaKhoaNgauNhien2_Click.Click += new System.EventHandler(this.btnChiaKhoaNgauNhien2_Click_Click);
            // 
            // btnLuuVanBan2_Click
            // 
            this.btnLuuVanBan2_Click.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLuuVanBan2_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuVanBan2_Click.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuVanBan2_Click.ForeColor = System.Drawing.Color.White;
            this.btnLuuVanBan2_Click.Location = new System.Drawing.Point(482, 394);
            this.btnLuuVanBan2_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuVanBan2_Click.Name = "btnLuuVanBan2_Click";
            this.btnLuuVanBan2_Click.Size = new System.Drawing.Size(96, 28);
            this.btnLuuVanBan2_Click.TabIndex = 29;
            this.btnLuuVanBan2_Click.Text = "Lưu file";
            this.btnLuuVanBan2_Click.UseVisualStyleBackColor = false;
            this.btnLuuVanBan2_Click.Click += new System.EventHandler(this.btnLuuVanBan2_Click_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.Location = new System.Drawing.Point(9, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "File : ";
            // 
            // txtKhoaVanBan2
            // 
            this.txtKhoaVanBan2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKhoaVanBan2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtKhoaVanBan2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaVanBan2.Location = new System.Drawing.Point(72, 337);
            this.txtKhoaVanBan2.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhoaVanBan2.MaxLength = 16;
            this.txtKhoaVanBan2.Name = "txtKhoaVanBan2";
            this.txtKhoaVanBan2.Size = new System.Drawing.Size(371, 27);
            this.txtKhoaVanBan2.TabIndex = 28;
            this.txtKhoaVanBan2.Text = "ABCDEF0123456789";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.Location = new System.Drawing.Point(8, 344);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Khoá";
            // 
            // txtVanBanDich2
            // 
            this.txtVanBanDich2.BackColor = System.Drawing.Color.PeachPuff;
            this.txtVanBanDich2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVanBanDich2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtVanBanDich2.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtVanBanDich2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtVanBanDich2.Location = new System.Drawing.Point(72, 375);
            this.txtVanBanDich2.Margin = new System.Windows.Forms.Padding(4);
            this.txtVanBanDich2.Multiline = true;
            this.txtVanBanDich2.Name = "txtVanBanDich2";
            this.txtVanBanDich2.Size = new System.Drawing.Size(402, 152);
            this.txtVanBanDich2.TabIndex = 28;
            this.txtVanBanDich2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.Location = new System.Drawing.Point(8, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Text : ";
            // 
            // txtVanBanNguon2
            // 
            this.txtVanBanNguon2.BackColor = System.Drawing.Color.Tan;
            this.txtVanBanNguon2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVanBanNguon2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtVanBanNguon2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVanBanNguon2.Location = new System.Drawing.Point(72, 131);
            this.txtVanBanNguon2.Margin = new System.Windows.Forms.Padding(4);
            this.txtVanBanNguon2.Multiline = true;
            this.txtVanBanNguon2.Name = "txtVanBanNguon2";
            this.txtVanBanNguon2.Size = new System.Drawing.Size(402, 179);
            this.txtVanBanNguon2.TabIndex = 28;
            this.txtVanBanNguon2.TextChanged += new System.EventHandler(this.txtVanBanNguon2_TextChanged);
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear2.ForeColor = System.Drawing.Color.White;
            this.btnClear2.Location = new System.Drawing.Point(279, 535);
            this.btnClear2.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(142, 42);
            this.btnClear2.TabIndex = 28;
            this.btnClear2.Text = "Nhập lại";
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // txtFileNguon2
            // 
            this.txtFileNguon2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFileNguon2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFileNguon2.Location = new System.Drawing.Point(72, 72);
            this.txtFileNguon2.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileNguon2.Name = "txtFileNguon2";
            this.txtFileNguon2.ReadOnly = true;
            this.txtFileNguon2.Size = new System.Drawing.Size(402, 27);
            this.txtFileNguon2.TabIndex = 28;
            this.txtFileNguon2.TextChanged += new System.EventHandler(this.txtFileNguon2_TextChanged);
            // 
            // btnChonFile2
            // 
            this.btnChonFile2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChonFile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonFile2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnChonFile2.ForeColor = System.Drawing.Color.White;
            this.btnChonFile2.Location = new System.Drawing.Point(482, 73);
            this.btnChonFile2.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonFile2.Name = "btnChonFile2";
            this.btnChonFile2.Size = new System.Drawing.Size(96, 28);
            this.btnChonFile2.TabIndex = 28;
            this.btnChonFile2.Text = "Chọn File";
            this.btnChonFile2.UseVisualStyleBackColor = false;
            this.btnChonFile2.Click += new System.EventHandler(this.btnChonFile2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kết quả giải mã";
            // 
            // btnGiaiMaVanBan
            // 
            this.btnGiaiMaVanBan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGiaiMaVanBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaiMaVanBan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnGiaiMaVanBan.ForeColor = System.Drawing.Color.White;
            this.btnGiaiMaVanBan.Location = new System.Drawing.Point(110, 535);
            this.btnGiaiMaVanBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiaiMaVanBan.Name = "btnGiaiMaVanBan";
            this.btnGiaiMaVanBan.Size = new System.Drawing.Size(149, 41);
            this.btnGiaiMaVanBan.TabIndex = 13;
            this.btnGiaiMaVanBan.Text = "Giải mã văn bản";
            this.btnGiaiMaVanBan.UseVisualStyleBackColor = false;
            this.btnGiaiMaVanBan.Click += new System.EventHandler(this.txtGiaiMaVanBan_Click);
            // 
            // txtKhoaVanBan
            // 
            this.txtKhoaVanBan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKhoaVanBan.Font = new System.Drawing.Font("Arial", 10F);
            this.txtKhoaVanBan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaVanBan.Location = new System.Drawing.Point(60, 336);
            this.txtKhoaVanBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhoaVanBan.MaxLength = 16;
            this.txtKhoaVanBan.Name = "txtKhoaVanBan";
            this.txtKhoaVanBan.Size = new System.Drawing.Size(371, 27);
            this.txtKhoaVanBan.TabIndex = 17;
            this.txtKhoaVanBan.Text = "ABCDEF0123456789";
            this.txtKhoaVanBan.TextChanged += new System.EventHandler(this.txtKhoaVanBan_TextChanged);
            this.txtKhoaVanBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoaFile_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(1, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Khoá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(1, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Text : ";
            // 
            // BoxFileCrypt
            // 
            this.BoxFileCrypt.BackColor = System.Drawing.Color.MistyRose;
            this.BoxFileCrypt.Controls.Add(this.btnChiaKhoaNgauNhien_Click);
            this.BoxFileCrypt.Controls.Add(this.label9);
            this.BoxFileCrypt.Controls.Add(this.btnChuyen_Click);
            this.BoxFileCrypt.Controls.Add(this.btnLuuVanBan_Click);
            this.BoxFileCrypt.Controls.Add(this.txtFileNguon);
            this.BoxFileCrypt.Controls.Add(this.btnClear);
            this.BoxFileCrypt.Controls.Add(this.txtVanBanDich);
            this.BoxFileCrypt.Controls.Add(this.txtKhoaVanBan);
            this.BoxFileCrypt.Controls.Add(this.txtVanBanNguon);
            this.BoxFileCrypt.Controls.Add(this.btnMaHoaVanBan);
            this.BoxFileCrypt.Controls.Add(this.label1);
            this.BoxFileCrypt.Controls.Add(this.label5);
            this.BoxFileCrypt.Controls.Add(this.btnChonFile);
            this.BoxFileCrypt.Controls.Add(this.lblEncryptedFilename);
            this.BoxFileCrypt.Controls.Add(this.label3);
            this.BoxFileCrypt.Controls.Add(this.label2);
            this.BoxFileCrypt.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BoxFileCrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BoxFileCrypt.Location = new System.Drawing.Point(16, 13);
            this.BoxFileCrypt.Margin = new System.Windows.Forms.Padding(4);
            this.BoxFileCrypt.Name = "BoxFileCrypt";
            this.BoxFileCrypt.Padding = new System.Windows.Forms.Padding(4);
            this.BoxFileCrypt.Size = new System.Drawing.Size(575, 635);
            this.BoxFileCrypt.TabIndex = 24;
            this.BoxFileCrypt.TabStop = false;
            this.BoxFileCrypt.Text = "MÃ HÓA";
            // 
            // btnChiaKhoaNgauNhien_Click
            // 
            this.btnChiaKhoaNgauNhien_Click.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChiaKhoaNgauNhien_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiaKhoaNgauNhien_Click.Font = new System.Drawing.Font("Arial", 5F, System.Drawing.FontStyle.Bold);
            this.btnChiaKhoaNgauNhien_Click.ForeColor = System.Drawing.Color.White;
            this.btnChiaKhoaNgauNhien_Click.Location = new System.Drawing.Point(439, 336);
            this.btnChiaKhoaNgauNhien_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnChiaKhoaNgauNhien_Click.Name = "btnChiaKhoaNgauNhien_Click";
            this.btnChiaKhoaNgauNhien_Click.Size = new System.Drawing.Size(135, 28);
            this.btnChiaKhoaNgauNhien_Click.TabIndex = 31;
            this.btnChiaKhoaNgauNhien_Click.Text = "Khóa ngẫu nhiên";
            this.btnChiaKhoaNgauNhien_Click.UseVisualStyleBackColor = false;
            this.btnChiaKhoaNgauNhien_Click.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.Location = new System.Drawing.Point(5, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 19);
            this.label9.TabIndex = 30;
            this.label9.Text = "Kết quả mã hoá ";
            // 
            // btnChuyen_Click
            // 
            this.btnChuyen_Click.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChuyen_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyen_Click.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnChuyen_Click.ForeColor = System.Drawing.Color.White;
            this.btnChuyen_Click.Location = new System.Drawing.Point(459, 450);
            this.btnChuyen_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnChuyen_Click.Name = "btnChuyen_Click";
            this.btnChuyen_Click.Size = new System.Drawing.Size(97, 30);
            this.btnChuyen_Click.TabIndex = 29;
            this.btnChuyen_Click.Text = "Chuyển";
            this.btnChuyen_Click.UseVisualStyleBackColor = false;
            this.btnChuyen_Click.Click += new System.EventHandler(this.btnChuyen_Click_Click);
            // 
            // btnLuuVanBan_Click
            // 
            this.btnLuuVanBan_Click.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLuuVanBan_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuVanBan_Click.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuVanBan_Click.ForeColor = System.Drawing.Color.White;
            this.btnLuuVanBan_Click.Location = new System.Drawing.Point(460, 394);
            this.btnLuuVanBan_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuVanBan_Click.Name = "btnLuuVanBan_Click";
            this.btnLuuVanBan_Click.Size = new System.Drawing.Size(96, 28);
            this.btnLuuVanBan_Click.TabIndex = 28;
            this.btnLuuVanBan_Click.Text = "Lưu file";
            this.btnLuuVanBan_Click.UseVisualStyleBackColor = false;
            this.btnLuuVanBan_Click.Click += new System.EventHandler(this.btnLuuVanBan_Click_Click);
            // 
            // txtFileNguon
            // 
            this.txtFileNguon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFileNguon.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFileNguon.Location = new System.Drawing.Point(60, 71);
            this.txtFileNguon.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileNguon.Name = "txtFileNguon";
            this.txtFileNguon.ReadOnly = true;
            this.txtFileNguon.Size = new System.Drawing.Size(391, 27);
            this.txtFileNguon.TabIndex = 5;
            this.txtFileNguon.TextChanged += new System.EventHandler(this.txtFileNguon_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(259, 535);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 42);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Nhập lại";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtVanBanDich
            // 
            this.txtVanBanDich.BackColor = System.Drawing.Color.PeachPuff;
            this.txtVanBanDich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVanBanDich.Font = new System.Drawing.Font("Arial", 10F);
            this.txtVanBanDich.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtVanBanDich.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtVanBanDich.Location = new System.Drawing.Point(60, 375);
            this.txtVanBanDich.Margin = new System.Windows.Forms.Padding(4);
            this.txtVanBanDich.Multiline = true;
            this.txtVanBanDich.Name = "txtVanBanDich";
            this.txtVanBanDich.Size = new System.Drawing.Size(391, 152);
            this.txtVanBanDich.TabIndex = 26;
            this.txtVanBanDich.TabStop = false;
            this.txtVanBanDich.TextChanged += new System.EventHandler(this.txtVanBanDich_TextChanged);
            // 
            // txtVanBanNguon
            // 
            this.txtVanBanNguon.BackColor = System.Drawing.Color.Tan;
            this.txtVanBanNguon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVanBanNguon.Font = new System.Drawing.Font("Arial", 10F);
            this.txtVanBanNguon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVanBanNguon.Location = new System.Drawing.Point(60, 129);
            this.txtVanBanNguon.Margin = new System.Windows.Forms.Padding(4);
            this.txtVanBanNguon.Multiline = true;
            this.txtVanBanNguon.Name = "txtVanBanNguon";
            this.txtVanBanNguon.Size = new System.Drawing.Size(391, 179);
            this.txtVanBanNguon.TabIndex = 26;
            this.txtVanBanNguon.TextChanged += new System.EventHandler(this.txtVanBanNguon_TextChanged);
            // 
            // btnMaHoaVanBan
            // 
            this.btnMaHoaVanBan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMaHoaVanBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaHoaVanBan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaHoaVanBan.ForeColor = System.Drawing.Color.White;
            this.btnMaHoaVanBan.Location = new System.Drawing.Point(102, 534);
            this.btnMaHoaVanBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaHoaVanBan.Name = "btnMaHoaVanBan";
            this.btnMaHoaVanBan.Size = new System.Drawing.Size(149, 42);
            this.btnMaHoaVanBan.TabIndex = 10;
            this.btnMaHoaVanBan.Text = "Mã hoá văn bản";
            this.btnMaHoaVanBan.UseVisualStyleBackColor = false;
            this.btnMaHoaVanBan.Click += new System.EventHandler(this.txtMaHoaVanBan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(5, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "File : ";
            // 
            // btnChonFile
            // 
            this.btnChonFile.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonFile.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnChonFile.ForeColor = System.Drawing.Color.White;
            this.btnChonFile.Location = new System.Drawing.Point(460, 70);
            this.btnChonFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(96, 28);
            this.btnChonFile.TabIndex = 16;
            this.btnChonFile.Text = "Chọn File";
            this.btnChonFile.UseVisualStyleBackColor = false;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // lblEncryptedFilename
            // 
            this.lblEncryptedFilename.AutoSize = true;
            this.lblEncryptedFilename.Font = new System.Drawing.Font("Arial", 10F);
            this.lblEncryptedFilename.Location = new System.Drawing.Point(11, 59);
            this.lblEncryptedFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncryptedFilename.Name = "lblEncryptedFilename";
            this.lblEncryptedFilename.Size = new System.Drawing.Size(0, 19);
            this.lblEncryptedFilename.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMaHoaDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 661);
            this.Controls.Add(this.BoxTextCrypt);
            this.Controls.Add(this.BoxFileCrypt);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMaHoaDES";
            this.Text = "NHÓM 9_THUẬT TOÁN DES ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMaHoaDES_FormClosing);
            this.Load += new System.EventHandler(this.frmMaHoaDES_Load);
            this.BoxTextCrypt.ResumeLayout(false);
            this.BoxTextCrypt.PerformLayout();
            this.BoxFileCrypt.ResumeLayout(false);
            this.BoxFileCrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox BoxTextCrypt;
        private System.Windows.Forms.TextBox txtKhoaVanBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox BoxFileCrypt;
        private System.Windows.Forms.TextBox txtFileNguon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEncryptedFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        //private System.Windows.Forms.RichTextBox txtVanBanDich;
        private MaHoaDES.BieuMau.CustomTextBox txtVanBanDich;
        //private System.Windows.Forms.RichTextBox txtVanBanNguon;
        private MaHoaDES.BieuMau.CustomTextBox txtVanBanNguon;
        private RoundedButton btnMaHoaVanBan;
        private RoundedButton btnGiaiMaVanBan;
        private RoundedButton btnChonFile;
        private RoundedButton btnClear;
        private RoundedButton btnChonFile2;
        private TextBox txtFileNguon2;
        private RoundedButton btnClear2;
        private CustomTextBox txtVanBanNguon2;
        private Label label6;
        private CustomTextBox txtVanBanDich2;
        private Label label7;
        private TextBox txtKhoaVanBan2;
        private RoundedButton btnLuuVanBan_Click;
        private RoundedButton btnLuuVanBan2_Click;
        private Label label8;
        private RoundedButton btnChuyen_Click;
        private Label label9;
        private RoundedButton btnChiaKhoaNgauNhien_Click;
        private RoundedButton btnChiaKhoaNgauNhien2_Click;
    }
}