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
    public partial class RMSaleMain : Form
    {
        private int childFormNumber = 0;

        public RMSaleMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mnSales_Click(object sender, EventArgs e)
        {
            LoadForm("sales");
        }

        private void RMSaleMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd dd-MMM-yyyy");
            LoadForm("sales");
        }
        private void LoadForm(string frmName)
        {
            switch (frmName)
            {
                case "purchase":
                    {
                    var obj = new frmPurchaseOrder();
                    obj.MdiParent = this;
                    obj.Show();
                    break;
                    }
                case "sales":
                    {
                        var obj = new frmSales();
                        obj.MdiParent = this;
                        obj.Show();
                        break;
                    }
                case "Product":
                    {
                        var obj = new frmMasterProducts();
                        obj.MdiParent = this;
                        obj.Show();
                        break;
                    }
                case "Omanagement":
                    {
                        var obj = new frmPOManagement();
                        obj.MdiParent = this;
                        obj.Show();
                        break;
                    }
            }

        }

        private void mnPurchase_Click(object sender, EventArgs e)
        {
            LoadForm("purchase");
        }

        private void mnProductManagement_Click(object sender, EventArgs e)
        {
            LoadForm("Product");
        }

        private void lnkSales_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadForm("sales");
        }

        private void LinkPurchase_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadForm("purchase");
        }

        private void lnkProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadForm("Product");
        }

        private void lnlOmanagemt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadForm("Omanagement");
        }
    }
}
