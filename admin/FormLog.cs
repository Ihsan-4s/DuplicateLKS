using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DuplicateLKS.admin
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        private void loadLogData(DateTime? startDate = null, DateTime? endDate = null)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=db_lksdesktop;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string query = "SELECT l.waktu, l.aktivitas, u.username FROM tbl_log l JOIN tbl_user u ON l.id_user = u.id_user WHERE (@startDate IS NULL OR l.waktu >= @startDate) AND (@endDate IS NULL OR l.waktu <= @endDate) AND tipe_user = 'admin'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@startDate", (object)startDate ?? DBNull.Value);
                da.SelectCommand.Parameters.AddWithValue("@endDate", (object)endDate ?? DBNull.Value);
                SqlDataReader dr = da.SelectCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("No", typeof(int));
                dt.Columns.Add("Username", typeof(string));
                dt.Columns.Add("Waktu", typeof(DateTime));
                dt.Columns.Add("Aktivitas", typeof(string));

                int i = 1;
                while (dr.Read())
                {
                    dt.Rows.Add(i, dr["username"], dr["waktu"], dr["aktivitas"]);
                    i++;
                }

                tableLog.DataSource = dt;
            }
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            loadLogData();
            showDate();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateFrom.Value.Date;
            DateTime endDate = dateUntil.Value.Date.AddDays(1).AddTicks(-1);
            loadLogData(startDate, endDate);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            var culture = new System.Globalization.CultureInfo("id-ID");
            string date = now.ToString("dddd, dd MMMM yyyy", culture);

            string hour = now.ToString("HH:mm:ss");

            txtDate.Text = date;
            txtHour.Text = hour;
        }

        private void showDate()
        {
            var culture = new System.Globalization.CultureInfo("id-ID");
            DateTime now = DateTime.Now;

            txtDate.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo
                .ToTitleCase(now.ToString("dddd, dd MMMM yyyy", culture));

            txtHour.Text = now.ToString("HH:mm:ss");
        }
    }
}

