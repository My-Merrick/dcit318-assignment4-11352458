using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MedicalBookingApp
{
    public partial class ManageAppointmentsForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["MedicalDB"].ConnectionString;

        public ManageAppointmentsForm()
        {
            InitializeComponent();
        }

        private void ManageAppointmentsForm_Load(object sender, EventArgs e)
        {
            // Nothing yet — optional.
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT a.AppointmentID, d.FullName AS Doctor, p.FullName AS Patient, 
                             a.AppointmentDate, a.Notes 
                      FROM Appointments a
                      JOIN Doctors d ON a.DoctorID = d.DoctorID
                      JOIN Patients p ON a.PatientID = p.PatientID", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewAppointments.DataSource = dt;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
