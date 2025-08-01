namespace MedicalBookingApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnViewDoctors = new Button();
            btnBookAppointment = new Button();
            btnManageAppointments = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnViewDoctors
            // 
            btnViewDoctors.Location = new Point(327, 127);
            btnViewDoctors.Name = "btnViewDoctors";
            btnViewDoctors.Size = new Size(205, 35);
            btnViewDoctors.TabIndex = 0;
            btnViewDoctors.Text = "View Doctors";
            btnViewDoctors.UseVisualStyleBackColor = true;
            btnViewDoctors.Click += btnViewDoctors_Click;
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.Location = new Point(81, 127);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new Size(202, 35);
            btnBookAppointment.TabIndex = 1;
            btnBookAppointment.Text = "Book Appointment";
            btnBookAppointment.UseVisualStyleBackColor = true;
            btnBookAppointment.Click += btnBookAppointment_Click;
            // 
            // btnManageAppointments
            // 
            btnManageAppointments.Location = new Point(559, 127);
            btnManageAppointments.Name = "btnManageAppointments";
            btnManageAppointments.Size = new Size(201, 35);
            btnManageAppointments.TabIndex = 2;
            btnManageAppointments.Text = "Manage Appointments";
            btnManageAppointments.UseVisualStyleBackColor = true;
            btnManageAppointments.Click += btnManageAppointments_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(206, 28);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 5, 20, 5);
            label1.Size = new Size(326, 40);
            label1.TabIndex = 3;
            label1.Text = "Medical Booking App";
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnManageAppointments);
            Controls.Add(btnBookAppointment);
            Controls.Add(btnViewDoctors);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewDoctors;
        private Button btnBookAppointment;
        private Button btnManageAppointments;
        private Label label1;
    }
}
