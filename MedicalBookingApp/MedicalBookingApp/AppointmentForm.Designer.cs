namespace MedicalBookingApp
{
    partial class AppointmentForm
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
            comboDoctor = new ComboBox();
            comboPatient = new ComboBox();
            dateAppointment = new DateTimePicker();
            txtNotes = new TextBox();
            btnBook = new Button();
            label1 = new Label();
            docLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboDoctor
            // 
            comboDoctor.FormattingEnabled = true;
            comboDoctor.Location = new Point(190, 72);
            comboDoctor.Name = "comboDoctor";
            comboDoctor.Size = new Size(259, 23);
            comboDoctor.TabIndex = 0;
            // 
            // comboPatient
            // 
            comboPatient.FormattingEnabled = true;
            comboPatient.Location = new Point(190, 137);
            comboPatient.Name = "comboPatient";
            comboPatient.Size = new Size(259, 23);
            comboPatient.TabIndex = 1;
            // 
            // dateAppointment
            // 
            dateAppointment.Location = new Point(188, 186);
            dateAppointment.Name = "dateAppointment";
            dateAppointment.Size = new Size(261, 23);
            dateAppointment.TabIndex = 2;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(188, 233);
            txtNotes.Margin = new Padding(3, 10, 3, 3);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(261, 139);
            txtNotes.TabIndex = 3;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(188, 401);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(170, 23);
            btnBook.TabIndex = 4;
            btnBook.Text = "Book Appointment";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 9);
            label1.Margin = new Padding(3, 0, 3, 5);
            label1.Name = "label1";
            label1.Padding = new Padding(45, 0, 45, 0);
            label1.Size = new Size(292, 30);
            label1.TabIndex = 5;
            label1.Text = "Book Appointment";
            label1.Click += label1_Click;
            // 
            // docLabel
            // 
            docLabel.AutoSize = true;
            docLabel.Location = new Point(89, 75);
            docLabel.Name = "docLabel";
            docLabel.Padding = new Padding(0, 4, 0, 0);
            docLabel.Size = new Size(80, 19);
            docLabel.TabIndex = 6;
            docLabel.Text = "Select Doctor:";
            docLabel.Click += docLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 141);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 4, 0, 0);
            label2.Size = new Size(81, 19);
            label2.TabIndex = 7;
            label2.Text = "Select Patient:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 186);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 4, 0, 0);
            label3.Size = new Size(70, 19);
            label3.TabIndex = 8;
            label3.Text = "Pick A Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 286);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 4, 0, 0);
            label4.Size = new Size(67, 19);
            label4.TabIndex = 9;
            label4.Text = "Short Note:";
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(docLabel);
            Controls.Add(label1);
            Controls.Add(btnBook);
            Controls.Add(txtNotes);
            Controls.Add(dateAppointment);
            Controls.Add(comboPatient);
            Controls.Add(comboDoctor);
            Name = "AppointmentForm";
            Text = "AppointmentForm";
            Load += AppointmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboDoctor;
        private ComboBox comboPatient;
        private DateTimePicker dateAppointment;
        private TextBox txtNotes;
        private Button btnBook;
        private Label label1;
        private Label docLabel;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}