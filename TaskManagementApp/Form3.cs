using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Drawing2D;
using System.IO;

namespace TaskManagementApp
{
    public partial class Form3 : Form
    {
        public event Action<Image> PictureChanged;

        public Form3()
        {
            InitializeComponent();
        }

        private void txtProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
                Title = "Select a Profile Picture"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // بارگذاری تصویر اصلی
                Image originalImage = Image.FromFile(openFileDialog.FileName);

                // ایجاد تصویر دایره‌ای
                Image circularImage = CreateCircularImage(originalImage);

                //  pictureProfile تنظیم تصویر دایره‌ای در
                pictureProfile.Image = circularImage;
                pictureProfile.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
            private Image CreateCircularImage(Image originalImage)
        {
            //  pictureProfile اندازه مورد نیاز برای دایره‌ای کردن تصویر براساس اندازه کنترل
            int diameter = Math.Min(pictureProfile.Width, pictureProfile.Height);
            Bitmap circularBitmap = new Bitmap(diameter, diameter);

            using (Graphics graphics = Graphics.FromImage(circularBitmap))
            {
                // ایجاد قلموهای کیفیت بالا
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // ساختن ماسک دایره‌ای
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, diameter, diameter);
                    graphics.SetClip(path);
                    graphics.DrawImage(originalImage, 0, 0, diameter, diameter);
                }
            }
            return circularBitmap;
        }

        private void BtnTManagement_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
