using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateLKS.admin
{
    public partial class Sidebar : Form
    {
        public Sidebar()
        {
            InitializeComponent();
            this.Load += formDefault;
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

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form frm = Form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(frm);
            this.mainPanel.Tag = frm;
            frm.Show();
        }

        private void formDefault(object sender, EventArgs e)
        {
            loadForm(new FormLog());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apa Kamu Yakin Akan Logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogActivity(FormLogin.UserId, "Logout");
                this.Close();
                FormLogin loginForm = new FormLogin();
                loginForm.Show();
            }
        }

        private void btnUser_Click_1(object sender, EventArgs e)
        {
            loadForm(new FormUser());
        }

        private void btnLog_Click_1(object sender, EventArgs e)
        {
            loadForm(new FormLog());
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            loadForm(new FormReport());
        }
    }
}
