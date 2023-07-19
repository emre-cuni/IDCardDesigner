using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Xml.Linq;

namespace IDCardDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seconds = 0, defaultX = 0, defaultY = 0;
        bool control = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            control = !control;
            defaultX = Location.X;
            defaultY = Location.Y;
            labelImportantInfoDetail.Text = "1-Bu Kart, verildiği kadroda geçerlidir. Başka kadroya atanma durumunda geri verilir.\n\n" +
                "2-Bu Kart, sadece kart sahibinin çalıştığı binada kullanılır.\n\n" +
                "3-Kartın kaybolması durumunda hemen ilgili birime bilgi verilir.\n\n" +
                "4-Kart, bina içinde sol yakada veya boyunda asılı okunacak şekilde bulundurulur.\n\n" +
                "5-Kart, sahibinden başkası tarafından kullanılamaz.\n\n" +
                "6-Tel: 123456678";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex == 1)
                {
                    Size = new Size(730, 521);
                    tabControl1.Size = new Size(705, 436);
                }
                else
                {
                    Size = new Size(726, 521);
                    tabControl1.Size = new Size(699, 437);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Sekme Değiştirme Hatası");
            }
        }

        private void panelStaffInfo_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                int borderWidth = 3;
                Color borderColor = Color.Black;

                ControlPaint.DrawBorder(e.Graphics, panelStaffInfo.ClientRectangle,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Çerçeve Çizme Hatası");
            }
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                int borderWidth = 5;
                Color borderColor = Color.Black;

                ControlPaint.DrawBorder(e.Graphics, panelTitle.ClientRectangle,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Çerçeve Çizme Hatası");
            }
        }

        private void panelImportantInfo_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                int borderWidth = 5;
                Color borderColor = Color.Black;

                ControlPaint.DrawBorder(e.Graphics, panelImportantInfo.ClientRectangle,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Çerçeve Çizme Hatası");
            }
        }

        private void pictureBoxPhoto_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                int borderWidth = 3;
                Color borderColor = Color.Black;

                ControlPaint.DrawBorder(e.Graphics, pictureBoxPhoto.ClientRectangle,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Çerçeve Çizme Hatası");
            }
        }

        private void pictureBoxEmblem1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pictureBoxEmblem1.Image = null;
                openFileDialog1.Filter = "Resim Dosyaları |*.png|Resim Dosyaları |*.jpeg|Resim Dosyaları |*.jpg";
                openFileDialog1.Title = "Bir Resim Seçiniz...";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxEmblem1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                    pictureBoxEmblem1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Fotoğraf Seçme Hatası");
            }
        }

        private void pictureBoxEmblem2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pictureBoxEmblem2.Image = null;
                openFileDialog1.Filter = "Resim Dosyaları |*.png|Resim Dosyaları |*.jpeg|Resim Dosyaları |*.jpg";
                openFileDialog1.Title = "Bir Resim Seçiniz...";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxEmblem2.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                    pictureBoxEmblem2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Fotoğraf Seçme Hatası");
            }
        }

        private void pictureBoxEmblem3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pictureBoxEmblem3.Image = null;
                openFileDialog1.Filter = "Resim Dosyaları |*.png|Resim Dosyaları |*.jpeg|Resim Dosyaları |*.jpg";
                openFileDialog1.Title = "Bir Resim Seçiniz...";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxEmblem3.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                    pictureBoxEmblem3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Fotoğraf Seçme Hatası");
            }
        }

        private void pictureBoxPhoto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pictureBoxPhoto.Image = null;
                openFileDialog1.Filter = "Resim Dosyaları |*.png|Resim Dosyaları |*.jpeg|Resim Dosyaları |*.jpg";
                openFileDialog1.Title = "Bir Resim Seçiniz...";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPhoto.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                    pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Fotoğraf Seçme Hatası");
            }
        }

        private void textBoxTitle_Enter(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                textBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "TextBox Enter Hatası");
            }
        }

        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)(sender);
                if (textBox.Text == string.Empty)
                    textBox.Text = ".................................................................................";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "TextBox Leave Hatası");
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectedIndex = 0;
                timer1.Enabled = true;
                timer1.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Çıktı Hatası");
            }
        }

        private void Screenshots(int width, int height, int x, int y, string fileName)
        {
            try
            {
                Bitmap bitmap = new Bitmap(width, height);
                Graphics graphic = Graphics.FromImage(bitmap);
                graphic.CopyFromScreen(y, x, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                bitmap.Save(Application.StartupPath + "\\" + fileName, ImageFormat.Png);
                bitmap.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Ekran Görüntüsü Alma Hatası");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                seconds++;

                if (seconds == 1)
                {
                    //ön sayfa ss
                    int panelTitleWidth = 677;
                    int panelTitleHeight = 390;
                    int panelTitleX = Location.X + panelTitle.Location.X + 93;
                    int panelTitleY = Location.Y + panelTitle.Location.Y + 18;

                    Screenshots(panelTitleWidth, panelTitleHeight, panelTitleX, panelTitleY, "frontPage.png");

                    tabControl1.SelectedIndex = 1;
                    //ön sayfa ss
                }
                else if (seconds > 2)
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    seconds = 0;

                    // arka sayfa ss
                    int panelImportantWidth = 690;
                    int panelImportantHeight = 393;
                    int panelImportantX = Location.X + panelImportantInfo.Location.X + 93;
                    int panelImportantY = Location.Y + panelImportantInfo.Location.Y + 16;

                    Screenshots(panelImportantWidth, panelImportantHeight, panelImportantX, panelImportantY, "backPage.png");

                    iTextSharp.text.Document report = new Document();

                    string fileName = "_" + DateTime.Now.Hour + DateTime.Now.Minute + "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year;
                    if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ID Card Designer"))
                        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ID Card Designer");
                    PdfWriter.GetInstance(report, new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ID Card Designer\\IDCard" + fileName + ".pdf", FileMode.Create));

                    iTextSharp.text.Image frontPage = iTextSharp.text.Image.GetInstance(Application.StartupPath + "\\frontPage.png");
                    iTextSharp.text.Image backPage = iTextSharp.text.Image.GetInstance(Application.StartupPath + "\\backPage.png");
                    report.SetPageSize(iTextSharp.text.PageSize.A3);
                    report.AddAuthor("Emre Cüni");
                    report.AddCreationDate();
                    report.AddCreator("devE");
                    report.AddSubject("ID Card");
                    report.AddKeywords("ID Card Designer");

                    if (report.IsOpen() == false)
                        report.Open();

                    report.Add(frontPage);
                    report.Add(new Paragraph("\n\n"));
                    report.Add(backPage);
                    report.Close();
                    // arka sayfa ss

                    File.Delete(Application.StartupPath + "\\frontPage.png");
                    File.Delete(Application.StartupPath + "\\backPage.png");

                    MessageBox.Show("Çıktı Başarıyla Alındı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Çıktı Alma Hatası");
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            try
            {
                if (control)
                    Location = new Point(defaultX, defaultY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Konum Hatası");
            }
        }

        private void panelImportantInfo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Resim Dosyaları |*.png|Resim Dosyaları |*.jpeg|Resim Dosyaları |*.jpg";
                openFileDialog1.Title = "Bir Resim Seçiniz...";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    panelImportantInfo.BackgroundImage = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                    panelImportantInfo.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.StackTrace + " stacktrace: " + ex.StackTrace, "Önemli Bilgileri Arka Plan Hatası");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAbout formAbout = new FormAbout();
                formAbout.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Hakkında Hatası");
            }
        }
    }
}
