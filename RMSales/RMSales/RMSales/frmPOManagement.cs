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
    public partial class frmPOManagement : Form
    {
        public frmPOManagement()
        {
            InitializeComponent();
        }
        private DataObject db = new DataObject();
        private Utilities utl = new Utilities();


        private void frmPOManagement_Load(object sender, EventArgs e)
        {
            LoadPO();
            cbPOStatus.SelectedIndex = 0;
        }

        private void LoadPO()
        {
            dgMasterPO.DataSource = db.GetTableAll(TableType.Purchase);
            dgMasterPO.RowHeadersVisible = false;
            dgMasterPO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMasterPO.AllowUserToAddRows = false;
            dgMasterPO.ReadOnly = true;
            dgMasterPO.Columns[0].Visible = false;
            dgMasterPO.Columns[1].Width = 150;
            dgMasterPO.Columns[2].Width = 100;
            dgMasterPO.Columns[3].Width = 60;
            dgMasterPO.Columns[4].Width = 60;
            dgMasterPO.Columns[7].Visible = false;
            dgMasterPO.Columns[6].Visible = false;
        }

        private void dgMasterPO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgPOitems.Rows.Clear();
            foreach (DataRow item in db.GetOrderItemByID(dgMasterPO.SelectedRows[0].Cells[0].Value.ToString()).Rows)
            {
                int i = dgPOitems.Rows.Add();

                dgPOitems.Rows[i].Cells[0].Value = item["ID"].ToString();
                dgPOitems.Rows[i].Cells[1].Value = item["ProductCode"].ToString();
                dgPOitems.Rows[i].Cells[2].Value = item["ProductName"].ToString();
                dgPOitems.Rows[i].Cells[3].Value = item["OrderQty"].ToString();
                dgPOitems.Rows[i].Cells[4].Value = item["PurchasedPrice"].ToString();
                dgPOitems.Rows[i].Cells[5].Value = item["OrderQty"].ToString();
                dgPOitems.Rows[i].Cells[6].Value = (Convert.ToInt16(item["PurchasedPrice"]) * 1.1).ToString();
            }
            dgPOitems.Columns[0].Visible = false;
            dgPOitems.AllowUserToAddRows = false;
            dgPOitems.RowHeadersVisible = false;

        }

        private void btnPOsave_Click(object sender, EventArgs e)
        {
            db.UpdatePOstatus(dgMasterPO.SelectedRows[0].Cells[0].Value.ToString(), cbPOStatus.Text);
            foreach (DataGridViewRow item in dgPOitems.Rows)
            {
                if (item != null)
                {
                    db.UpdatePoItem(item.Cells[0].Value.ToString(), item.Cells[5].Value.ToString(), item.Cells[6].Value.ToString());
                }
            }
            LoadPO();
            dgPOitems.Rows.Clear();
            utl.ShowMessage("Order status updated, Now you can sell this items.");
        }

        private void dgPOitems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

