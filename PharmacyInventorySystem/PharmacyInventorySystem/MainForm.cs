using Microsoft.Data.SqlClient; // ✅ ONLY THIS
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PharmacyInventorySystem
{
    public partial class MainForm : Form
    {
        private readonly string connStr = ConfigurationManager.ConnectionStrings["PharmacyDB"].ConnectionString;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnViewAll.PerformClick();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new("AddMedicine", conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Medicine added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new("SearchMedicine", conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@SearchTerm", txtSearchTerm.Text);
                SqlDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);
                dataGridViewMedicines.DataSource = dt;
                dataGridViewMedicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new("UpdateStock", conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@MedicineID", Convert.ToInt32(txtMedicineID.Text));
                cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtNewQuantity.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Stock updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }

        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new("RecordSale", conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@MedicineID", Convert.ToInt32(txtMedicineID.Text));
                cmd.Parameters.AddWithValue("@QuantitySold", Convert.ToInt32(txtQuantitySold.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Sale recorded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new("GetAllMedicines", conn) { CommandType = CommandType.StoredProcedure };
                SqlDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);
                dataGridViewMedicines.DataSource = dt;
                dataGridViewMedicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ " + ex.Message);
            }
        }
    }
}
