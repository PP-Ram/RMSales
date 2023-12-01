using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RMSales
{
    public partial class frmSales : Form
    {
        private DataObject db = new DataObject();
        private Utilities utl = new Utilities();
        private int saleID;

        DataTable dt = new DataTable();
        public frmSales()
        {
            InitializeComponent();
        }
        private void frmRMSales_Load(object sender, EventArgs e)
        {
            cbMonth.Items.AddRange(Utilities.MonthsFull.ToArray<object>());
            cbMonth.SelectedIndex = DateTime.Now.Month-1;
            
            cbTechnician.DataSource = db.GetTableAll(TableType.Technician);
            cbTechnician.DisplayMember = "Name";
            cbSaleProductName.DataSource = db.GetTableAll(TableType.Product);
            cbSaleProductName.DisplayMember = "Details";
            cbSaleProductName.ValueMember = "Code";

            LoadMasterSaleGrid();
            LoadSaleItemGrid();
            txtSaleTPrice.ReadOnly = true;
            lblTotalCurItem.Text = "";
            lblTotalPrice.Text = "";
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            var columnsList = dgSaleItem.Columns.Cast<DataGridViewColumn>()
              .Where(x => x.Visible && x.ValueType == typeof(string))
              .Select(x => x.DataPropertyName);
            var filter = string.Join(" OR ", columnsList.Select(x => "{x} like '%" + cbMonth.Text + "'%'"));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnSaleAdd_Click(object sender, EventArgs e)
        {
            if (txtSalePrice.Text == "")
            {
                utl.ShowMessage("Please enter the price.");
            }
            else
            {
                cbTechnician.Enabled = false;
                if (saleID == 0)
                {
                    saleID = db.AddSale(cbTechnician.Text, dpSaleDate.Text, "1", txtSaleTPrice.Text);
                    lblSaleID.Text = "Sale Id:" + saleID.ToString();
                }

                db.AddSaleItem(saleID.ToString(), cbSaleProductName.SelectedValue.ToString() , cbSaleProductName.Text, txtQty.Text, txtSaleTPrice.Text, txtSalePrice.Text);
                db.UpdateSale(saleID.ToString());

                RefreshGrid();
            }
        }
        
        private void RefreshGrid()
        {
            dgCurrentSale.DataSource = db.GetSalesItemBySaleID(saleID.ToString());
            dgCurrentSale.ReadOnly = true;
            dgCurrentSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCurrentSale.AllowUserToAddRows = false;
            dgCurrentSale.Columns[0].Visible = false;
            dgCurrentSale.Columns[1].Width = 50;
            dgCurrentSale.Columns[2].Width = 200;
            dgCurrentSale.RowHeadersVisible = false;

            decimal qty = 0, tp=0;
            for (int i = 0; i < dgCurrentSale.Rows.Count; i++)
            {
                qty += Convert.ToDecimal(dgCurrentSale.Rows[i].Cells["Quantity"].Value);
                tp += Convert.ToDecimal(dgCurrentSale.Rows[i].Cells["TotalPrice"].Value);
            }

            lblTotalCurItem.Visible = true;
            lblTotalPrice.Visible = true;
            lblTotalCurItem.Text = "Total Item : " + qty.ToString();
            lblTotalPrice.Text = "Total Price : " + tp.ToString();

            txtQty.Text = "1";
            txtSalePrice.Text = "";
            txtSaleTPrice.Text = "";
        }

        private void LoadMasterSaleGrid()
        {
            DataTable dt = db.GetTableAll(TableType.Sales);
            dgSaleMaster.DataSource = dt;
            dgSaleMaster.ReadOnly = true;
            dgSaleMaster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSaleMaster.AllowUserToAddRows = false;
            dgSaleMaster.RowHeadersVisible = false;
            dgSaleMaster.Columns[0].Width= 50;
            dgSaleMaster.Columns[1].Width = 150;
            dgSaleMaster.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgSaleMaster.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgSaleMaster.Columns[3].Visible = false;
            dgSaleMaster.Columns[6].Visible = false;
            decimal price = 0;
            decimal qty = 0;
            for (int i = 0; i < dgSaleMaster.Rows.Count; i++)
            {
                qty += Convert.ToDecimal(dgSaleMaster.Rows[i].Cells["Quantity"].Value);
                price += Convert.ToDecimal(dgSaleMaster.Rows[i].Cells["TotalPrice"].Value);
            }
            lblTotalSalePrice.Text = "Today Total Sale: " + price.ToString("#,##0");
            lblTotalSaleIten.Text = "Total Item: " + qty.ToString("#,##0");

        }
        private void LoadSaleItemGrid()
        {
            if (dgSaleMaster.SelectedRows.Count >= 1)
            {
                DataGridViewCellCollection dc = dgSaleMaster.SelectedRows[0].Cells;
                dgSaleItem.DataSource = db.GetSalesItemBySaleID(dc[0].Value.ToString());

                dgSaleItem.ReadOnly = true;
                dgSaleItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgSaleItem.AllowUserToAddRows = false;
                dgSaleItem.RowHeadersVisible = false;
                dgSaleItem.Columns[1].Width = 50;
                dgSaleItem.Columns[2].Width = 150;
                dgSaleItem.Columns[0].Visible = false;
                dgSaleItem.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgSaleItem.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgSaleItem.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void btnSaleNew_Click(object sender, EventArgs e)
        {
            cbTechnician.Enabled = true;
            lblSaleID.Text = "";
            dgCurrentSale.DataSource = null;
            txtSaleTPrice.Text = "";
            txtQty.Text = "";
            saleID = 0;
            lblTotalCurItem.Text = "";
            lblTotalPrice.Text = "";
        }

        private void btnSaleRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgCurrentSale.CurrentCell != null)
            {
                DataGridViewCellCollection dc = dgCurrentSale.SelectedRows[0].Cells;
                if (utl.ShowQuestion("Do you want remove item : " + dc[2].Value.ToString()) == DialogResult.Yes)
                {
                    db.SalesItemDeleteByID(dc[0].Value.ToString());
                    db.UpdateSale(saleID.ToString());
                    RefreshGrid();
                }
            }
        }

        private void dgSaleMaster_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgSaleMaster.CurrentCell != null)
            {
                LoadSaleItemGrid();
            }
        }

        private void txtSalePrice_TextChanged(object sender, EventArgs e)
        {
            GetTotal();
        }

        private void GetTotal()
        {
            if (txtSalePrice.Text != "" && txtQty.Text != "")
            {
                txtSaleTPrice.Text = (Convert.ToInt16(txtSalePrice.Text) * Convert.ToInt16(txtQty.Text)).ToString();
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(sender, e);
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSaleAdd_Click(sender, e);
            }
        }

        private static void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAddSaleCancel_Click(object sender, EventArgs e)
        {
            dgCurrentSale.DataSource = null;
            LoadMasterSaleGrid();
            LoadSaleItemGrid();

            cbTechnician.Enabled = true;
            lblTotalCurItem.Text = "";
            lblTotalPrice.Text = "";
            saleID = 0;
            lblSaleID.Text = "";
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            GetTotal();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(sender, e);
        }

        private void lblTotalCurItem_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddSaleNew_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
