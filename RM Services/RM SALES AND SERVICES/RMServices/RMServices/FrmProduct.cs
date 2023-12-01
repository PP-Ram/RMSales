using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace RMServices
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            string sqlInsert = string.Format("INSERT INTO tblproducts(Description,stockQty,wholesaleprice,technicianprice,totalQty,purchasedate) " +
                                    "values('{0}','{1}','{2}','{3}','{4}','{5}')", txtDescription.Text, txtStockQty.Text, txtWholesalePrice.Text, txtTechnicianprice.Text, txtTotalQty.Text, dtpPurchaseDate.Text);

            using var cmd = new SQLiteCommand(sqlInsert, GetConnection());
            cmd.ExecuteNonQuery();
            MessageBox.Show("New product added");
            clearAll();
            LoadData();
        }
        private void clearAll()
        {
            txtDescription.Text = "";
            txtStockQty.Text = "";
            txtTechnicianprice.Text = "";
            txtTotalQty.Text = "";
            txtWholesalePrice.Text = "";
        }
        private void LoadData()
        {
            using var cmd = new SQLiteCommand("Select * from tblProducts", GetConnection());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            grdproducts.DataSource = dt;
        }

        public SQLiteConnection GetConnection()
        {
            string conStr = @"URI=file:{0}";
            SQLiteConnection con = new SQLiteConnection(string.Format(conStr, "C:\\RM Services\\RM-Services.db"));
            con.Open();
            return con;
        }

        private void lnkAddnew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpMain.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grpMain.Visible = false;
        }
    }
}
