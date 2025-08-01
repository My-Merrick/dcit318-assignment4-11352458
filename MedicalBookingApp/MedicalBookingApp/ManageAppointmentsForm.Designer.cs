namespace MedicalBookingApp
{
    partial class ManageAppointmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewAppointments = new DataGridView();
            btnLoad = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.AllowUserToOrderColumns = true;
            dataGridViewAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointments.Location = new Point(-2, 47);
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.Size = new Size(804, 304);
            dataGridViewAppointments.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.DarkGreen;
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(12, 381);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(201, 41);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load Appointments";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(164, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 30);
            label1.TabIndex = 2;
            label1.Text = "Manage Appointments Form";
            label1.Click += label1_Click;
            // 
            // ManageAppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnLoad);
            Controls.Add(dataGridViewAppointments);
            Name = "ManageAppointmentsForm";
            Text = "ManageAppointmentsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAppointments;
        private Button btnLoad;
        private Label label1;
    }
}