using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace RMServices
{
    public partial class FrmExpenditure : Form
    {
        public FrmExpenditure()
        {
            InitializeComponent();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmExpenditure_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sqlInsert = string.Format("INSERT INTO tblExpenditure(Description,Totalamount,Date,Details) " +
                                    "values('{0}','{1}','{2}','{3}')", txtDescription.Text, txtTotalamount.Text, dtpdate.Text, txtDetails);

            using var cmd = new SQLiteCommand(sqlInsert, GetConnection());
            cmd.ExecuteNonQuery();
            MessageBox.Show("New product added");
            clearAll();
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           clearAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grpexpenditure.Visible = false;
        }
        private void LoadData()
        {
            using var cmd = new SQLiteCommand("Select * from tblExpenditure", GetConnection());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            grdExpenditure.DataSource = dt;

        }
        public SQLiteConnection GetConnection()
        {
            string conStr = @"URI=file:{0}";
            SQLiteConnection con = new SQLiteConnection(string.Format(conStr, "C:\\RM Services\\RM-Services.db"));
            con.Open();
            return con;
        }
        private void clearAll()
        {
            txtDescription.Text = "";
            txtTotalamount.Text = "";
            dtpdate.Text = "";
            txtDetails.Text = "";


        
        

        }

        private void lblTotalamount_Click(object sender, EventArgs e)
        {

        }
    }
}
