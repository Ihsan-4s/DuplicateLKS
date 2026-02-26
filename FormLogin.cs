using System;
using DuplicateLKS.admin;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateLKS
{
    public partial class FormLogin : Form
    {

        public static int UserId { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }


        private void LogActivity(int UserId, string Activity)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=db_lksdesktop;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string query = "INSERT INTO tbl_log (waktu, aktivitas, id_user) VALUES (@waktu, @aktivitas, @id_user)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@waktu", DateTime.Now);
                cmd.Parameters.AddWithValue("@aktivitas", Activity);
                cmd.Parameters.AddWithValue("@id_user", UserId);
                cmd.ExecuteNonQuery();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Silahkan Masukan Username Dan Password Terlebih Dahulu!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Silahkan Masukan Username Terlebih Dahulu!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Silahkan Masukan Password Terlebih Dahulu!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=db_lksdesktop;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string query = "SELECT COUNT(*), tipe_user, id_user FROM tbl_user WHERE username=@username AND password=@password GROUP BY tipe_user, id_user";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() && reader.GetInt32(0) > 0)
                {
                    string tipe_user = reader.GetString(1);
                    UserId = reader.GetInt32(2);
                    LogActivity(UserId, "Login");
                    con.Close();

                    MessageBox.Show("Login Berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    if (tipe_user == "Admin")
                    {
                        Sidebar dashboard = new Sidebar();
                        dashboard.Show();
                    }
                    //else if (tipe_user == "Gudang")
                    //{
                    //    FormStuff stuffs = new FormStuff();
                    //    stuffs.Show();
                    //}
                    //else if (tipe_user == "Kasir")
                    //{
                    //    string cashierName = txtEmail.Text;
                    //    FormCashier cashier = new FormCashier(cashierName);
                    //    cashier.Show();
                    //}

                }
                else
                {
                    con.Close();
                    MessageBox.Show("Silahkan Masukan Email Atau Password Dengan Benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = checkPassword.Checked ? '\0' : '*';
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mereset semua input?", "Konfirmasi Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        
    }
}
