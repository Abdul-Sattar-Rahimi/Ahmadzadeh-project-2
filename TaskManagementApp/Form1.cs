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

namespace TaskManagementApp
{
    public partial class Form1 : Form
    {

        private string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\Tasks.accdb;";
        public Form1()
        {
            InitializeComponent();
        }

        private void IDtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Titletb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Descriptiontb_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartDatetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Statustb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDuties.SelectedRows.Count > 0)
            {
                var row = dgvDuties.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["ID"].Value);

                var result = MessageBox.Show("آیا مطمئن هستید که می‌خواهید این وظیفه را حذف کنید؟", "تأیید حذف", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new OleDbConnection(connectionString))
                    {
                        var query = "DELETE FROM Tasks WHERE ID = @ID";
                        var command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@ID", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("وظیفه با موفقیت حذف شد!");
                    }
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("لطفاً یک وظیفه را انتخاب کنید.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDuties.SelectedRows.Count > 0)
            {
                var row = dgvDuties.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                string title = Titletb.Text;
                string description = Descriptiontb.Text;
                DateTime startDate = DateTime.Parse(StartDatetb.Text);
                string status = Statustb.Text;

                using (var connection = new OleDbConnection(connectionString))
                {
                    var query = "UPDATE Tasks SET Title = @Title, Description = @Description, StartDate = @StartDate, Status = @Status WHERE ID = @ID";
                    var command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("وظیفه با موفقیت ویرایش شد!");
                }
                LoadTasks();
            }
            else
            {
                MessageBox.Show("لطفاً یک وظیفه را برای ویرایش انتخاب کنید.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = Titletb.Text;
            string description = Descriptiontb.Text;
            string status = Statustb.Text;

            // بررسی و تبدیل مقدار تاریخ
            DateTime startDate;
            if (!DateTime.TryParse(StartDatetb.Text, out startDate))
            {
                MessageBox.Show("لطفاً تاریخ معتبر وارد کنید.");
                return;
            }

            using (var connection = new OleDbConnection(connectionString))
            {
                var query = "INSERT INTO Tasks (Title, Description, StartDate, Status) VALUES (@Title, @Description, @StartDate, @Status)";
                var command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@Status", status);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("وظیفه جدید با موفقیت اضافه شد!");
            }

            LoadTasks(); // بارگذاری مجدد وظایف
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void dgvDuties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDuties.Rows[e.RowIndex];
                IDtb.Text = row.Cells["ID"].Value.ToString();
                Titletb.Text = row.Cells["Title"].Value.ToString();
                Descriptiontb.Text = row.Cells["Description"].Value.ToString();
                StartDatetb.Text = row.Cells["StartDate"].Value.ToString();
                Statustb.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void LoadTasks()
        {
            try
            {
                using (var connection = new OleDbConnection(connectionString))
                {
                    var query = "SELECT * FROM Tasks";
                    var adapter = new OleDbDataAdapter(query, connection);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dgvDuties.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری وظایف: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
