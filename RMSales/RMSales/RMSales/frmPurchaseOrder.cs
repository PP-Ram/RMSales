using System;
using System.Text;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RMSales
{
    public partial class frmPurchaseOrder : Form
    {
        private DataObject db = new DataObject();
        private Utilities utl = new Utilities();
        DataTable dt = new DataTable();
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            cbSupplier.DataSource = db.GetTableAll(TableType.Supplier);
            cbSupplier.DisplayMember = "SupplierName";
            pnlPO.Visible = false;

            ShowStockDetails();
        }

        private void ShowStockDetails()
        {
            //dgStock.DataSource = code, details, OrderCount, SaleCount, OrderCount-SaleCount As Stock, BuyPrice  
            foreach (DataRow item in db.GetTableAll(TableType.Stock).Rows)
            {
                int i = dgStock.Rows.Add();
                dgStock.Rows[i].Cells[0].Value = false;
                dgStock.Rows[i].Cells[1].Value = item["code"].ToString();
                dgStock.Rows[i].Cells[2].Value = item["details"].ToString();
                dgStock.Rows[i].Cells[3].Value = item["ordercount"].ToString();
                dgStock.Rows[i].Cells[4].Value = item["salecount"].ToString();
                dgStock.Rows[i].Cells[5].Value = item["stock"].ToString();
                dgStock.Rows[i].Cells[6].Value = item["buyprice"].ToString();
            } 
            //dgStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStock.ReadOnly = false;
            dgStock.AllowUserToAddRows = false;
            dgStock.RowHeadersVisible = false;
        }

        private void LoadSaleOrderDetails()
        {
            string value = dgStock.Rows[dgStock.CurrentCell.RowIndex].Cells[1].Value.ToString();
            dgSale.DataSource = db.GetSaleByCode(value);
            dgSale.ReadOnly = true;
            dgSale.AllowUserToAddRows = false;
            dgSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSale.Columns[1].Width = 50;

            dgPurchase.DataSource = db.GetOrderByCode(value);
            dgPurchase.ReadOnly = true;
            dgPurchase.AllowUserToAddRows = false;
            dgPurchase.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPurchase.Columns[1].Width = 50;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        int itemcount;
        int totalQty;
        int totalPrice;
        private void dgStock_Click(object sender, DataGridViewCellEventArgs e)
        {
            LoadSaleOrderDetails();
           
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            /*

            int poid = db.CreateOrder(cbSupplier.Text, DateTime.Now.ToString());
            foreach (DataGridViewRow item in dgStock.Rows)
            {
                if(bool.Parse(item.Cells[0].Value.ToString()))
                {
                    db.CreatePoItem(poid.ToString(), item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[7].Value.ToString(), item.Cells[6].Value.ToString());
                }
            }

            db.UpdateOrder(poid.ToString());

            utl.ShowMessage("New Purchase Order Created. " + Environment.NewLine +
                "Total Item: " + itemcount + Environment.NewLine +
                "Total Quantity: " + totalQty + Environment.NewLine +
                "Total Price: " + totalPrice);*/

            StringBuilder strB = new StringBuilder();
            //create html & table
            strB.AppendLine("<html><body><center><" +
                            "table border='1' cellpadding='0' cellspacing='0'>");
            strB.AppendLine("<tr>");
            //cteate table header
            for (int i = 0; i < dgStock.Columns.Count; i++)
            {
                strB.AppendLine("<td align='center' font='12' BGcolor='gray' valign='middle'>" +
                                dgStock.Columns[i].HeaderText + "</td>");
            }
            //create table body
            strB.AppendLine("<tr>");
            foreach (DataGridViewRow item in dgStock.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    strB.AppendLine("<tr>");
                    foreach (DataGridViewCell dgvc in item.Cells)
                    {
                        if (dgvc.Value != null)
                        {
                            strB.AppendLine("<td align='center' valign='middle'>" +
                                            dgvc.Value.ToString() + "</td>");
                        }
                    }
                    strB.AppendLine("</tr>");
                }
            }
            //table footer & end of html file
            strB.AppendLine("</table></center></body></html>");
            webBrowser1.DocumentText = strB.ToString();
        }

        private void dgStock_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int itemcount = 0;
            foreach (DataGridViewRow item in dgStock.Rows)
            {
                if (item.Cells[0].Value != null && bool.Parse(item.Cells[0].Value.ToString()))
                {
                    itemcount++;
                }
            }
            lblNoItem.Text = "No of Item: " + itemcount.ToString();
        }

        private void dgStock_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 0 || e.ColumnIndex == 7))
            {
                ShowCheckout();
            }
        }

        private void ShowCheckout()
        {
            itemcount = 0;
            totalQty = 0;
            totalPrice = 0;
            foreach (DataGridViewRow item in dgStock.Rows)
            {
                if (item.Cells[0].Value != null && bool.Parse(item.Cells[0].Value.ToString()))
                {
                    itemcount++;
                    if (item.Cells[7].Value != null)
                    {
                        totalQty += Convert.ToInt16(item.Cells[7].Value.ToString());
                        totalPrice += (Convert.ToInt16(item.Cells[6].Value.ToString()) * Convert.ToInt16(item.Cells[7].Value.ToString()));

                        item.Cells[8].Value = Convert.ToInt16(item.Cells[6].Value) * Convert.ToInt16(item.Cells[7].Value);
                    }
                }
            }
            lblNoItem.Text = "No of Item: " + itemcount.ToString();
            lblQty.Text = "Total Quantity: " + totalQty;
            lblTotalPrice.Text = "Total Amount: " + totalPrice;
        }

        private void lnkShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlPO.Visible = true;
            ShowCheckout();

            foreach (DataGridViewRow item in dgStock.Rows)
            {
                if (item.Cells[0].Value != null && bool.Parse(item.Cells[0].Value.ToString()))
                {
                }
            }
        }

        private void pnlPO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
