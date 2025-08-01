using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MedicalBookingApp
{
    public partial class AppointmentForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["MedicalDB"].ConnectionString;

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            LoadPatients();
        }

        private void LoadDoctors()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DoctorID, FullName FROM Doctors WHERE Availability = 1", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboDoctor.Items.Add(new ComboBoxItem(reader["FullName"].ToString(), (int)reader["DoctorID"]));
                }
            }
        }

        private void LoadPatients()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT PatientID, FullName FROM Patients", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboPatient.Items.Add(new ComboBoxItem(reader["FullName"].ToString(), (int)reader["PatientID"]));
                }
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (comboDoctor.SelectedItem == null || comboPatient.SelectedItem == null)
            {
                MessageBox.Show("Select both doctor and patient.");
                return;
            }

            int doctorId = ((ComboBoxItem)comboDoctor.SelectedItem).Value;
            int patientId = ((ComboBoxItem)comboPatient.SelectedItem).Value;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Appointments (DoctorID, PatientID, AppointmentDate, Notes) " +
                    "VALUES (@DoctorID, @PatientID, @Date, @Notes)", conn);

                cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                cmd.Parameters.AddWithValue("@PatientID", patientId);
                cmd.Parameters.AddWithValue("@Date", dateAppointment.Value);
                cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment booked!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void docLabel_Click(object sender, EventArgs e)
        {

        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString() => Text;
    }
}
