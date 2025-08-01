using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace MedicalBookingApp
{
    public partial class DoctorListForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["MedicalDB"].ConnectionString;

        public DoctorListForm()
        {
            InitializeComponent();
        }

        private void DoctorListForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Doctors", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewDoctors.DataSource = dt;
            }
        }
    }
}
