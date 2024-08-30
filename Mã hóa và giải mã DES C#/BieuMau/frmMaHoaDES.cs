using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MaHoaDES.DoiTuong;



using System.Threading;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Numerics;
using System.Security.AccessControl;
using DocumentFormat.OpenXml;
using System.Text;

namespace MaHoaDES.BieuMau
{
   
    public partial class frmMaHoaDES : Form
    {
       

        string flag = "";
        DataTable dtShamir;
        BigInteger[] V;
        BigInteger[] fV;
        BigInteger k, p;
        int w, t;
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("v");
            dt.Columns.Add("fv");
            return dt;
        }
        public frmMaHoaDES()
        {
            InitializeComponent();
          


        }
       
        private void EnableHoacDisableNut(bool b)
        {
            btnChonFile.Enabled  = btnGiaiMaVanBan.Enabled = btnMaHoaVanBan.Enabled = b;
        }
        int MaHoaHayGiaiMa = 1;
        DES64Bit MaHoaDES64;
        Khoa Khoa;
        Thread thread;
        private void Chay()
        {
            ThreadStart start= new ThreadStart(MaHoa);
            thread = new Thread(start);
            thread.Start();
        }
        #region Mã hóa
        private void MaHoa()
        {
           
                Khoa = new Khoa(txtKhoaVanBan.Text);
                if (MaHoaHayGiaiMa == 1)
                {

                    MaHoaDES64 = new DES64Bit();
                    string kq=MaHoaDES64.ThucHienDESText(Khoa, txtVanBanNguon.Text, 1);
                    txtVanBanDich.Text = kq;
                    MessageBox.Show("Mã hóa chuỗi thành công");
                }
                //else
                //{
                //    MaHoaDES64 = new DES64Bit();
                //    string kq = MaHoaDES64.ThucHienDESText(Khoa, txtVanBanNguon.Text, -1);
                //    txtVanBanDich.Text = kq;
                //    if (kq == "")
                //    {
                //        return;
                //    }
                //    MessageBox.Show("Giải mã chuỗi thành công");
                //}
                
        }
        #endregion
        #region Giải mã
        //private void GiaiMa()
        //{

        //    //Khoa = new Khoa(txtKhoaVanBan.Text);
        //    //if (MaHoaHayGiaiMa == 1)
        //    //{

        //    //    MaHoaDES64 = new DES64Bit();
        //    //    string kq = MaHoaDES64.ThucHienDESText(Khoa, txtVanBanNguon.Text, 1);
        //    //    txtVanBanDich.Text = kq;
        //    //    MessageBox.Show("Mã hóa chuỗi thành công");
        //    //}
        //    Khoa = new Khoa(txtKhoaVanBan2.Text);
        //    if (MaHoaHayGiaiMa != 1)
        //    {
        //        MaHoaDES64 = new DES64Bit();
        //        string kq = MaHoaDES64.ThucHienDESText(Khoa, txtVanBanNguon2.Text, -1);
        //        txtVanBanDich2.Text = kq;
        //        if (kq == "")
        //        {
        //            return;
        //        }
        //        MessageBox.Show("Giải mã chuỗi thành công");
        //    }

        //}
        private void GiaiMa()
        {
            // Kiểm tra xem dữ liệu khoá và dữ liệu nguồn có được cung cấp không
            if (string.IsNullOrEmpty(txtKhoaVanBan2.Text))
            {
                MessageBox.Show("Vui lòng nhập khoá để thực hiện giải mã.");
                return;
            }

            if (string.IsNullOrEmpty(txtVanBanNguon2.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu cần giải mã.");
                return;
            }

            // Sử dụng khoá từ textbox
            Khoa = new Khoa(txtKhoaVanBan2.Text);

            // Thực hiện giải mã
            MaHoaDES64 = new DES64Bit();
            string kq = MaHoaDES64.ThucHienDESText(Khoa, txtVanBanNguon2.Text, -1);

            if (string.IsNullOrEmpty(kq))
            {
                MessageBox.Show("Không thể giải mã dữ liệu đã cho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị kết quả giải mã
            txtVanBanDich2.Text = kq;
            MessageBox.Show("Giải mã chuỗi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        #endregion
        #region Kiểm tra dữuliệu

        //public bool checkData()
        //{

        //    if (string.IsNullOrEmpty(txt_k.Text))
        //    {
        //        MessageBox.Show("Bạn chưa nhập khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txt_k.Focus();
        //        return false;
        //    }


        //    if (string.IsNullOrEmpty(txt_w.Text))
        //    {
        //        MessageBox.Show("Bạn chưa nhập số thành viên giữ khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txt_w.Focus();
        //        return false;
        //    }

        //    if (string.IsNullOrEmpty(txt_t.Text))
        //    {
        //        MessageBox.Show("Bạn chưa nhập số thành viên tối thiểu để mở khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txt_t.Focus();
        //        return false;
        //    }

        //    w = int.Parse(txt_w.Text);
        //    t = int.Parse(txt_t.Text);
        //    if (t > w)
        //    {
        //        MessageBox.Show("Số thành viên tối thiểu để mở khóa không được lớn hơn số thành viên giữ khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txt_t.Text = "";
        //        txt_t.Focus();
        //        return false;
        //    }

        //    if (string.IsNullOrEmpty(txt_p.Text))
        //    {
        //        MessageBox.Show("Bạn chưa nhập số nguyên tố p", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txt_p.Focus();
        //        return false;
        //    }

        //    return true;
        //}
        #endregion
        #region Chuyển chuỗi hex sang số thập phân
        public BigInteger hexToDec(string x)
        {
            string hexChars = "0123456789ABCDEF";

            BigInteger decimalValue = 0;
            for (int i = 0; i < x.Length; i++)
            {
                char hexChar = x[i];//Duyệt từng ký tự
                int hexCharValue = hexChars.IndexOf(hexChar);//Lấy giá trị
                decimalValue = decimalValue * 16 + hexCharValue;
            }
            return decimalValue;
        }
        #endregion
        #region Chuyển chuỗi dec sang chuỗi hex
        public string decToHex(string x)
        {
            BigInteger decInt = BigInteger.Parse(x);
            string hexValue = "";
            while (decInt > 0)
            {
                BigInteger value = decInt % 16;
                if (value < 10)
                {
                    hexValue = value.ToString() + hexValue;
                }
                else
                {
                    hexValue = ((char)('A' + value - 10)).ToString() + hexValue;
                }
                decInt /= 16;
            }
            return hexValue;
        }
        #endregion
        //#region Chia khóa
        //public void ProcessData()
        //{
        //    k = hexToDec(txt_k.Text.ToUpper());
        //    w = int.Parse(txt_w.Text);
        //    t = int.Parse(txt_t.Text);
        //    p = BigInteger.Parse(txt_p.Text);

        //    V = new BigInteger[w];
        //    for (int i = 0; i < w; i++)
        //    {
        //        V[i] = i + 1;
        //    }

        //    BigInteger[] a = new BigInteger[t - 1];
        //    Random random = new Random();
        //    for (int i = 0; i < t - 1; i++)
        //    {
        //        a[i] = random.Next(1 * txt_k.Text.Length, 99 * txt_k.Text.Length);
        //    }

        //    fV = new BigInteger[w];
        //    for (int i = 0; i < w; i++)
        //    {
        //        fV[i] = k % p;
        //        for (int j = t - 2; j >= 0; j--)
        //        {
        //            fV[i] = fV[i] + BigInteger.Pow(V[i], j + 1) * a[j];
        //        }
        //        fV[i] = fV[i] % p;
        //    }
        //    //Thêm dữ liệu vào dataGridView
        //    for (int i = 0; i < w; i++)
        //    {
        //        dtShamir.Rows.Add(V[i], fV[i]);
        //        dataGridView_ChiaKhoa.DataSource = dtShamir;
        //        dataGridView_ChiaKhoa.RefreshEdit();
        //        dataGridView_KhoiPhuc.DataSource = dtShamir;
        //        dataGridView_KhoiPhuc.RefreshEdit();
        //    }
        //}
        //#endregion
        #region Tìm nghịch đảo
        BigInteger mul_inv(BigInteger a, BigInteger b) //a^-1 mod b
        {
            BigInteger b0 = b, c, q;
            BigInteger x0 = 0, x1 = 1;
            if (b == 1) return 1;
            while (a < 0) a += b;
            while (a > 1)
            {
                q = (BigInteger)a / b;
                c = b; b = a % b; a = c;
                c = x0; x0 = x1 - q * x0; x1 = c;
            }
            if (x1 < 0) x1 += b0;
            return x1;
        }
        #endregion
        //#region Khôi phục khóa
        //public void FindKey()
        //{
        //    int s = 0;
        //    t = int.Parse(txt_t.Text);
        //    // Lặp qua hàng trong DataGridView
        //    foreach (DataGridViewRow check in (dataGridView_KhoiPhuc).Rows)
        //    {
        //        if ((bool)check.Cells["col_luaChon"].FormattedValue)
        //        {
        //            s++;
        //        }
        //    }
        //    if (s < t)
        //    {
        //        label_khoiPhuc.Text = "Khong du thanh vien!";
        //    }
        //    else
        //    {
        //        BigInteger[] b = new BigInteger[t];
        //        BigInteger[] subV = new BigInteger[t];
        //        BigInteger[] subFV = new BigInteger[t];
        //        int i = 0;
        //        foreach (DataGridViewRow check in (dataGridView_KhoiPhuc).Rows)
        //        {
        //            if ((bool)check.Cells["col_luaChon"].FormattedValue && i <= t - 1)
        //            {
        //                subV[i] = BigInteger.Parse(check.Cells["col_xi2"].Value.ToString());
        //                subFV[i] = BigInteger.Parse(check.Cells["col_pi2"].Value.ToString());
        //                i++;
        //            }
        //        }
        //        for (i = 0; i < t; i++)
        //        {
        //            b[i] = 1;
        //            for (int j = 0; j < t; j++)
        //            {
        //                if (i != j)
        //                {
        //                    b[i] = b[i] * mul_inv(subV[j] - subV[i], p) * subV[j] % p;
        //                }
        //            }
        //        }
        //        BigInteger key = 0;
        //        for (i = 0; i < t; i++)
        //        {
        //            key = (key + subFV[i] * b[i]) % p;
        //        }
        //        label_khoiPhuc.Text = "Khóa bí mật là: " + decToHex(key.ToString());
        //    }
        //}
       // #endregion

        #region Xử lý xự kiện
        private void txtMaHoaVanBan_Click(object sender, EventArgs e)
        {
            if (txtVanBanNguon.Text == "")
            {
                MessageBox.Show("Hãy nhập vào hộp text hoặc chọn 1 File");
                return;
            }
            if (txtKhoaVanBan.Text.Length != 16|| txtKhoaVanBan.Text.Length==0)
            {
                MessageBox.Show("Hãy nhập 1 khóa Hexa gồm 16 ký tự");
                txtKhoaVanBan.Focus();
            }
            else
            {
                MaHoaHayGiaiMa = 1;
                EnableHoacDisableNut(false);
                MaHoa();
                EnableHoacDisableNut(true);
            }
        }

        //private void txtGiaiMaVanBan_Click(object sender, EventArgs e)
        //{
        //    if (txtVanBanNguon2.Text == "")
        //    {
        //        MessageBox.Show("Hãy nhập vào hộp text hoặc chọn 1 File");
        //        return;
        //    }
        //    MaHoaHayGiaiMa = -1;
        //    EnableHoacDisableNut(false);
        //    //MaHoa();
        //    GiaiMa();
        //    EnableHoacDisableNut(true);

        //}
        private void txtGiaiMaVanBan_Click(object sender, EventArgs e)
        {
            if (txtVanBanNguon2.Text == "")
            {
                MessageBox.Show("Hãy nhập vào hộp text hoặc chọn 1 File");
                return;
            }

            string vanBanDich = txtVanBanDich.Text.Trim();
            string vanBanNguon2 = txtVanBanNguon2.Text.Trim();

            // Nếu nội dung của txtVanBanNguon2 khác txtVanBanDich2
            if (vanBanNguon2 != vanBanDich)
            {
                DialogResult result = MessageBox.Show("Nội dung đã thay đổi so với bản mã hóa. Bạn có muốn tiếp tục nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Cho phép nhập tiếp và tiến hành giải mã
                    txtVanBanDich.Text = "";
                    MaHoaHayGiaiMa = -1;
                    EnableHoacDisableNut(false);
                    GiaiMa();
                    EnableHoacDisableNut(true);
                }
                else
                {
                    // Người dùng không muốn nhập tiếp, không làm gì cả
                }
            }
            else
            {
                // Nếu nội dung giống nhau, tiến hành giải mã
                MaHoaHayGiaiMa = -1;
                EnableHoacDisableNut(false);
                GiaiMa();
                EnableHoacDisableNut(true);
            }
        }




        private void btnChonFile_Click(object sender, EventArgs e)
        {
            txtFileNguon.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileNguon.Text = openFileDialog1.FileName;
            }
            string filePath = txtFileNguon.Text;
            if (filePath.EndsWith("txt"))
            {
                txtVanBanNguon.Text = File.ReadAllText(filePath);
            }
            else if (filePath.EndsWith("docx"))
            {
                txtVanBanNguon.Text = "";
                using (var document = WordprocessingDocument.Open(filePath, false))
                {
                    var body = document.MainDocumentPart.Document.Body;

                    // Duyệt các phần tử trong tài liệu Word
                    foreach (var element in body.ChildElements)
                    {
                        // Nếu phần tử là một đoạn văn bản (Paragraph), thêm nội dung vào TextBox
                        if (element is Paragraph paragraph)
                        {
                            txtVanBanNguon.Text += paragraph.InnerText + "\r\n";
                        }
                        // Nếu phần tử là một bảng (Table), duyệt từng ô trong bảng
                        else if (element is Table table)
                        {
                            foreach (var row in table.Elements<TableRow>())
                            {
                                foreach (var cell in row.Elements<TableCell>())
                                {
                                    // Thêm nội dung của từng ô vào TextBox
                                    foreach (Paragraph paragra in cell.Elements<Paragraph>())
                                    {
                                        txtVanBanNguon.Text += paragra.InnerText + "\t";
                                    }
                                }
                                txtVanBanNguon.Text += "\r\n";
                            }
                        }
                        // Nếu phần tử là một hình ảnh (Drawing), thêm tên hình vào TextBox
                        else if (element is Drawing drawing)
                        {
                            var imageName = drawing.Descendants<DocumentFormat.OpenXml.Drawing.Blip>().FirstOrDefault()?.Embed.Value;
                            txtVanBanNguon.Text += "Image: " + imageName + "\r\n";
                        }
                        // Thêm các phần tử khác vào TextBox (vd: Header, Footer)
                        else
                        {
                            txtVanBanNguon.Text += element.InnerText + "\r\n";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn file txt hoặc file word!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void frmMaHoaDES_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread!=null && thread.ThreadState == ThreadState.Running)
                thread.Abort();
            //e.Cancel = DangChay;
        }

        private void txtKhoaFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !(ChuoiHexa.BoHexa.Contains(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        //private void btn_chiaKhoa_Click(object sender, EventArgs e)
        //{
        //    if (checkData())
        //    {
        //        ProcessData();
        //        flag = "ChiaKhoa";
        //        btn_khoiPhuc.Enabled = true;
        //    }
        //    if (flag == "ChiaKhoa")
        //    {
        //        dtShamir.Rows.Clear();
        //        ProcessData();
        //    }
        //    flag = "";
        //    label_khoiPhuc.Text = "";
        //}

        //private void btn_khoiPhuc_Click(object sender, EventArgs e)
        //{
        //    FindKey();
        //}

        private void txt_k_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !(ChuoiHexa.BoHexa.Contains(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_w_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự vừa nhập vào TextBox có phải là số nguyên hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự vừa nhập vào TextBox có phải là số nguyên hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_p_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự vừa nhập vào TextBox có phải là số nguyên hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVanBanNguon.Text = txtVanBanDich.Text =txtFileNguon.Text= "";
        }

        private void txtVanBanNguon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFileNguon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChonFile2_Click(object sender, EventArgs e)
        {
            txtFileNguon2.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileNguon2.Text = openFileDialog1.FileName;
            }
            string filePath = txtFileNguon2.Text;
            if (filePath.EndsWith("txt"))
            {
                txtVanBanNguon2.Text = File.ReadAllText(filePath);
            }
            else if (filePath.EndsWith("docx"))
            {
                txtVanBanNguon2.Text = "";
                using (var document = WordprocessingDocument.Open(filePath, false))
                {
                    var body = document.MainDocumentPart.Document.Body;

                    // Duyệt các phần tử trong tài liệu Word
                    foreach (var element in body.ChildElements)
                    {
                        // Nếu phần tử là một đoạn văn bản (Paragraph), thêm nội dung vào TextBox
                        if (element is Paragraph paragraph)
                        {
                            txtVanBanNguon2.Text += paragraph.InnerText + "\r\n";
                        }
                        // Nếu phần tử là một bảng (Table), duyệt từng ô trong bảng
                        else if (element is Table table)
                        {
                            foreach (var row in table.Elements<TableRow>())
                            {
                                foreach (var cell in row.Elements<TableCell>())
                                {
                                    // Thêm nội dung của từng ô vào TextBox
                                    foreach (Paragraph paragra in cell.Elements<Paragraph>())
                                    {
                                        txtVanBanNguon2.Text += paragra.InnerText + "\t";
                                    }
                                }
                                txtVanBanNguon2.Text += "\r\n";
                            }
                        }
                        // Nếu phần tử là một hình ảnh (Drawing), thêm tên hình vào TextBox
                        else if (element is Drawing drawing)
                        {
                            var imageName = drawing.Descendants<DocumentFormat.OpenXml.Drawing.Blip>().FirstOrDefault()?.Embed.Value;
                            txtVanBanNguon2.Text += "Image: " + imageName + "\r\n";
                        }
                        // Thêm các phần tử khác vào TextBox (vd: Header, Footer)
                        else
                        {
                            txtVanBanNguon2.Text += element.InnerText + "\r\n";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn file txt hoặc file word!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtVanBanNguon2.Text = txtVanBanDich2.Text = txtFileNguon.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtKhoaVanBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuuVanBan_Click_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|Word Documents (*.docx)|*.docx";
            saveFileDialog1.Title = "Save an Encrypted or Decrypted File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                if (filePath.EndsWith("txt"))
                {
                    File.WriteAllText(filePath, txtVanBanDich.Text);
                }
                else if (filePath.EndsWith("docx"))
                {
                    using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                    {
                        MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                        mainPart.Document = new Document();
                        Body body = new Body();
                        Paragraph para = new Paragraph();
                        Run run = new Run();
                        run.AppendChild(new Text(txtVanBanDich.Text));
                        para.AppendChild(run);
                        body.AppendChild(para);
                        mainPart.Document.AppendChild(body);
                        mainPart.Document.Save();
                    }
                }
                MessageBox.Show("Lưu file thành công!");
            }
        }

        private void btnLuuVanBan2_Click_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|Word Documents (*.docx)|*.docx";
            saveFileDialog1.Title = "Save an Encrypted or Decrypted File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                if (filePath.EndsWith("txt"))
                {
                    File.WriteAllText(filePath, txtVanBanDich2.Text);
                }
                else if (filePath.EndsWith("docx"))
                {
                    using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                    {
                        MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                        mainPart.Document = new Document();
                        Body body = new Body();
                        Paragraph para = new Paragraph();
                        Run run = new Run();
                        run.AppendChild(new Text(txtVanBanDich2.Text));
                        para.AppendChild(run);
                        body.AppendChild(para);
                        mainPart.Document.AppendChild(body);
                        mainPart.Document.Save();
                    }
                }
                MessageBox.Show("Lưu file thành công!");
            }
        }

        private void btnChuyen_Click_Click(object sender, EventArgs e)
        {
            txtVanBanNguon2.Text = txtVanBanDich.Text;
        }

        private void txtFileNguon2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVanBanNguon2_TextChanged(object sender, EventArgs e)
        {

        }

        // Hàm sinh khóa ngẫu nhiên


        private void GenerateRandomKey(bool forEncryption, TextBox textBox)
        {
            Random random = new Random();
            string hexChars = "0123456789ABCDEF";
            StringBuilder sb = new StringBuilder(16);

            for (int i = 0; i < 16; i++)
            {
                int index = random.Next(0, hexChars.Length);
                sb.Append(hexChars[index]);
            }

            if (forEncryption)
            {
                txtKhoaVanBan.Text = sb.ToString();
            }
            else
            {
                txtKhoaVanBan2.Text = sb.ToString();
            }
        }
        private void GenerateSecureRandomKey(bool forEncryption, TextBox textBox)
        {
            byte[] bytes = new byte[8]; // 8 bytes = 64 bits
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }

            StringBuilder sb = new StringBuilder(16);
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("X2")); // Convert to hexadecimal
            }

            if (forEncryption)
            {
                txtKhoaVanBan.Text = sb.ToString();
            }
            else
            {
                txtKhoaVanBan2.Text = sb.ToString();
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            GenerateSecureRandomKey(true, txtKhoaVanBan);
        }

        private void btnChiaKhoaNgauNhien2_Click_Click(object sender, EventArgs e)
        {
            GenerateSecureRandomKey(false, txtKhoaVanBan2);
        }

        private void txtVanBanDich_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btn_nhapLai_Click(object sender, EventArgs e)
        //{
        //    txt_k.Text = txt_w.Text = txt_t.Text = txt_p.Text = "";
        //    dtShamir.Rows.Clear();
        //    btn_khoiPhuc.Enabled = false;
        //    label_khoiPhuc.Text = "";
        //}

        #endregion
        private void frmMaHoaDES_Load(object sender, EventArgs e)
        {
            //btn_khoiPhuc.Enabled = false;
            dtShamir = createTable();
        }
    }
}
