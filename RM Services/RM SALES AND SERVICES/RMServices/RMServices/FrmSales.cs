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
    public partial class FrmSales : Form
    {
        public FrmSales()
        {
            InitializeComponent();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            ShowDaySale();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

           /* string sqlInsert = string.Format("INSERT INTO tblsales(Pcode,Description,Saledate,SalePrice,Quantity) " +
                                    "values('{0}','{1}','{2}','{3}','{4}')", txtpcode.Text, txtDescription.Text, dtpSaleDate.Text, txtsaleprice.Text,txtQuantity.Text);

            using var cmd = new SQLiteCommand(sqlInsert, GetConnection());
            cmd.ExecuteNonQuery();
            MessageBox.Show("New product added");
            clearAll();
            LoadData();*/
        }
        private void clearAll()
        {
          
        }
        private void ShowDaySale()
        {
            var q = grdDaySales;
            q.RowTemplate.Resizable = DataGridViewTriState.True;
            q.AllowUserToAddRows = true;
            q.RowHeadersVisible = q.EnableHeadersVisualStyles = false;
            q.RowTemplate.MinimumHeight = 35;
            q.Font = new Font("Tahoma", 12);
            q.DataSource = LoadData();
            q.Columns[0].Visible = false;
            
            q.Columns[1].Width = q.Columns[3].Width = q.Columns[4].Width = q.Columns[4].Width = 100;
            q.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            q.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
          
        }

        private DataTable LoadData()
        {
            using var cmd = new SQLiteCommand("Select * from tblSales", GetConnection());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public SQLiteConnection GetConnection()
        {
            string conStr = @"URI=file:{0}";
            SQLiteConnection con = new SQLiteConnection(string.Format(conStr, "C:\\RM Services\\RM-Services.db"));
            con.Open();
            return con;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
