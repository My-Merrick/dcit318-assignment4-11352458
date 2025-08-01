using System;
using System.Windows.Forms;

namespace MedicalBookingApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Optional: Add any startup logic if needed.
        }

        private void btnViewDoctors_Click(object sender, EventArgs e)
        {
            DoctorListForm form = new DoctorListForm();
            form.Show();
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm form = new AppointmentForm();
            form.Show();
        }

        private void btnManageAppointments_Click(object sender, EventArgs e)
        {
            ManageAppointmentsForm form = new ManageAppointmentsForm();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
