using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.IO;





namespace TaskManagementApp
{

    public partial class Form2 : Form
    {
        private OleDbConnection connection;
        public Form2()
        {
            InitializeComponent();
            PasswordTb.PasswordChar = '●';
            PasswordSU.PasswordChar = '●';
            ConfirmPasswordSU.PasswordChar = '●';

            // تنظیم مسیر فایل دیتابیس
            string databasePath = AppDomain.CurrentDomain.BaseDirectory + "Database.accdb";

            // بررسی وجود فایل دیتابیس
            if (!File.Exists(databasePath))
            {
                MessageBox.Show("فایل دیتابیس یافت نشد! لطفاً مسیر فایل را بررسی کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // مقداردهی اولیه اتصال دیتابیس
            connection = new OleDbConnection($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}");

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // مدیریت نمایش یا مخفی کردن رمز عبور در لاگین
            PasswordTb.PasswordChar = ShowPassword.Checked ? '\0' : '●';
        }

        private void ClearTxt_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel3.Height = panel9.Height; // تنظیم ارتفاع پنل ثبت‌نام به ارتفاع پنل اصلی یا نمایش فرم ثبت‌نام
            panel9.Location = new Point(5, 5); // تغییر موقعیت پنل اصلی به سمت چپ
            panel3.Location = new Point(0, 0); // تنظیم موقعیت فرم مربوط به نمایش
        }

        private void UserNameSU_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailSU_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordSU_TextChanged(object sender, EventArgs e)
        {
            PasswordSU.PasswordChar = ShowPassword.Checked ? '\0' : '●';
        }

        private void ConfirmPasswordSU_TextChanged(object sender, EventArgs e)
        {
            ConfirmPasswordSU.PasswordChar = checkBox2.Checked ? '\0' : '●';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            PasswordSU.PasswordChar = checkBox2.Checked ? '\0' : '●';
            ConfirmPasswordSU.PasswordChar = checkBox2.Checked ? '\0' : '●';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Register button

            try
            {
                if (UserNameSU.Text == "" || EmailSU.Text == "" || PasswordSU.Text == "" || ConfirmPasswordSU.Text == "")
                {
                    MessageBox.Show("لطفاً تمامی فیلدها را پر کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (PasswordSU.Text != ConfirmPasswordSU.Text)
                {
                    MessageBox.Show("رمز عبور و تأیید آن یکسان نیستند!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connection.Open();

                // اصلاح کوئری
                string query = "INSERT INTO Users ([UserName], [Email], [Password]) VALUES (@UserName, @Email, @Password)";
                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@UserName", UserNameSU.Text);
                command.Parameters.AddWithValue("@Email", EmailSU.Text);
                command.Parameters.AddWithValue("@Password", PasswordSU.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("ثبت‌نام با موفقیت انجام شد!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داد: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

        }

        private void Clear2_Click(object sender, EventArgs e)
        {
            UserNameSU.Text = "";
            EmailSU.Text = "";
            PasswordSU.Text = "";
            ConfirmPasswordSU.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel3.Height = 0;
            panel3.Location = new Point(0, 0);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (UnameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("لطفاً نام کاربری و رمز عبور را وارد کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Password = @Password";
                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@UserName", UnameTb.Text);
                command.Parameters.AddWithValue("@Password", PasswordTb.Text);

                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("ورود با موفقیت انجام شد!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داد: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
