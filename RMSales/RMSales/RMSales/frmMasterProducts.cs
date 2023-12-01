using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMSales
{
    public partial class frmMasterProducts : Form
    {
        public frmMasterProducts()
        {
            InitializeComponent();
        }
        private DataObject db = new DataObject();
        private Utilities utl = new Utilities();

        private void pnlAddSale_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmMasterProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void showProducts(String strProdutName)
        {
            (dgMasterProduct.DataSource as DataTable).DefaultView.RowFilter = string.Format("Type = '{0}'", strProdutName);
        }

        private void rdAC_CheckedChanged(object sender, EventArgs e)
        {
            showProducts("AC");
        }

        private void rdFridge_CheckedChanged(object sender, EventArgs e)
        {
            showProducts("FR");
        }

        private void rdOthers_CheckedChanged(object sender, EventArgs e)
        {
            showProducts("OT");
        }

        private void LoadProducts()
        {
            dgMasterProduct.DataSource = db.GetTableAll(TableType.Product);
            dgMasterProduct.RowHeadersVisible = false;
            dgMasterProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMasterProduct.Columns[4].Visible = false;
            dgMasterProduct.Columns[0].Width = 50;
            dgMasterProduct.Columns[1].Width = 50;
            dgMasterProduct.Columns[2].Width = 50;
            dgMasterProduct.Columns[3].Width = 200; 
            dgMasterProduct.AllowUserToAddRows = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) 
        {
            string Query = "";
            if (txtSearch.Text != string.Empty)
                Query += "Details like '%" + txtSearch.Text.Trim() + "%' ";
            (dgMasterProduct.DataSource as DataTable).DefaultView.RowFilter = Query;
        }

        private void lnkAddnew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlNewProduct.Visible = true;
            txtProductName.Text = "";
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            db.AddMasterProduct(cbProductType.Text, txtProductName.Text, txtOrderPrice.Text, txtSalePrice.Text);
            RMSaleMain t = new RMSaleMain();
            MessageBox.Show("New Product Added.", "RM Enterprises", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnlNewProduct.Visible = false;
            LoadProducts();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void btnANPrdouctCancel_Click(object sender, EventArgs e)
        {
            pnlNewProduct.Visible = false;
        }

        private void dgMasterProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var q = dgMasterProduct;
            if (e.RowIndex <= q.Rows.Count - 1)
            {
                string colHeader = q.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (colHeader != "")
                {
                    string rowHeader = q.Columns[e.ColumnIndex].HeaderText.ToString();
                    string val = q.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    db.UpdateProductPrice(rowHeader, colHeader, val);
                }
            }
        }

        private void lnkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadProducts();
        }
    }
}
