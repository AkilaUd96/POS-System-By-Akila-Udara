using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using POS_System_By_Akila_Udara.General;

namespace POS_System_By_Akila_Udara.ProductsF
{
    public partial class DefineProductScreen : MetroFramework.Forms.MetroForm
    {
        public DefineProductScreen()
        {
            InitializeComponent();
        }

        public bool IsUpdate { get; set; }

        private void DefineProductScreen_Load(object sender, EventArgs e)
        {
            if (!this.IsUpdate)
            {

            }
            LoadAllSizesinDataGridView();
            LoadDataintocombo();

        }

        private void LoadDataintocombo()
        {

            productCategoryCombo.DataSource = GetComboBoxData(1);
            productCategoryCombo.DisplayMember = "Description";
            productCategoryCombo.ValueMember = "ID";
            ProductSupplierCombo.DataSource = GetComboBoxData(2);
            ProductSupplierCombo.DisplayMember = "Description";
            ProductSupplierCombo.ValueMember = "ID";



        }

        private DataTable GetComboBoxData(int listTypeID)
        {
            DataTable drecord = new DataTable();
            {

                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_ListTypesData_LoadDataIntoCombo", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ListTypeID", listTypeID);
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        drecord.Load(sdr);
                    }

                }
                return drecord;
            }
        }

    

       
            
        private void LoadAllSizesinDataGridView()
        {
            dataGridView1.DataSource = GetSizeData();
            dataGridView1.Columns[0].Visible = false;
        }

        private DataTable GetSizeData()
        {
            DataTable dtsize = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("usp_Sizes_LoadAllSizes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ListTypeID", 1);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtsize.Load(sdr);
                }

            }


            return dtsize;
        }

            private void metroButton3_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            ProductName.Clear();
            PurchasePricetext.Clear();
            ProductSupplierCombo.SelectedIndex = -1;
            productCategoryCombo.SelectedIndex = -1;
            SalesPriceText.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Select"].Value = 0;
            }

            ProductName.Focus();
        }

        private void ProductName_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (isValid())
                
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {

                    using (SqlCommand cmd = new SqlCommand("usp_Products_InsertNewProduct", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", ProductName.Text);
                        cmd.Parameters.AddWithValue("@CategoryID", productCategoryCombo.SelectedValue);
                        cmd.Parameters.AddWithValue("@SupplierID", ProductSupplierCombo.SelectedValue);
                        cmd.Parameters.AddWithValue("@PurchasePrice", PurchasePricetext.Text);
                        cmd.Parameters.AddWithValue("@SalesPrice", SalesPriceText.Text);
                        con.Open();

                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show("Product is saved succsessfully to the system", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private bool isValid()
        {
           if (ProductName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Product Name is requried","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductName.Focus();
                return false;
            }

            if (PurchasePricetext.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Purchase price is requried", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PurchasePricetext.Focus();
                return false;
            }
            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductSupplierCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
