﻿namespace MedicalBookingApp
{
    partial class DoctorListForm
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
            dataGridViewDoctors = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctors).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDoctors
            // 
            dataGridViewDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctors.Location = new Point(12, 42);
            dataGridViewDoctors.Name = "dataGridViewDoctors";
            dataGridViewDoctors.Size = new Size(788, 408);
            dataGridViewDoctors.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 0, 20, 0);
            label1.Size = new Size(199, 30);
            label1.TabIndex = 1;
            label1.Text = "List Of Doctors";
            // 
            // DoctorListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridViewDoctors);
            Name = "DoctorListForm";
            Text = "DoctorListForm";
            Load += DoctorListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDoctors;
        private Label label1;
    }
}