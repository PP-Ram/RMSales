
namespace RMServices
{
    partial class FrmProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdproducts = new System.Windows.Forms.DataGridView();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.lblWholesaleprice = new System.Windows.Forms.Label();
            this.lblTechnicianprice = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtStockQty = new System.Windows.Forms.TextBox();
            this.txtWholesalePrice = new System.Windows.Forms.TextBox();
            this.txtTechnicianprice = new System.Windows.Forms.TextBox();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblproductdetails = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lnkAddnew = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdproducts)).BeginInit();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdproducts
            // 
            this.grdproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdproducts.Location = new System.Drawing.Point(61, 204);
            this.grdproducts.Name = "grdproducts";
            this.grdproducts.RowHeadersWidth = 51;
            this.grdproducts.RowTemplate.Height = 29;
            this.grdproducts.Size = new System.Drawing.Size(1032, 443);
            this.grdproducts.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(126, 50);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Location = new System.Drawing.Point(126, 115);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(68, 20);
            this.lblStockQty.TabIndex = 3;
            this.lblStockQty.Text = "StockQty";
            // 
            // lblWholesaleprice
            // 
            this.lblWholesaleprice.AutoSize = true;
            this.lblWholesaleprice.Location = new System.Drawing.Point(126, 163);
            this.lblWholesaleprice.Name = "lblWholesaleprice";
            this.lblWholesaleprice.Size = new System.Drawing.Size(111, 20);
            this.lblWholesaleprice.TabIndex = 4;
            this.lblWholesaleprice.Text = "Wholesaleprice";
            // 
            // lblTechnicianprice
            // 
            this.lblTechnicianprice.AutoSize = true;
            this.lblTechnicianprice.Location = new System.Drawing.Point(126, 211);
            this.lblTechnicianprice.Name = "lblTechnicianprice";
            this.lblTechnicianprice.Size = new System.Drawing.Size(110, 20);
            this.lblTechnicianprice.TabIndex = 5;
            this.lblTechnicianprice.Text = "TechnicianPrice";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Location = new System.Drawing.Point(129, 260);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(65, 20);
            this.lblTotalQty.TabIndex = 6;
            this.lblTotalQty.Text = "TotalQty";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(126, 313);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(99, 20);
            this.lblPurchaseDate.TabIndex = 7;
            this.lblPurchaseDate.Text = "PurchaseDate";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(285, 31);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(329, 68);
            this.txtDescription.TabIndex = 9;
            // 
            // txtStockQty
            // 
            this.txtStockQty.Location = new System.Drawing.Point(285, 115);
            this.txtStockQty.Name = "txtStockQty";
            this.txtStockQty.Size = new System.Drawing.Size(179, 27);
            this.txtStockQty.TabIndex = 10;
            // 
            // txtWholesalePrice
            // 
            this.txtWholesalePrice.Location = new System.Drawing.Point(285, 160);
            this.txtWholesalePrice.Name = "txtWholesalePrice";
            this.txtWholesalePrice.Size = new System.Drawing.Size(179, 27);
            this.txtWholesalePrice.TabIndex = 11;
            // 
            // txtTechnicianprice
            // 
            this.txtTechnicianprice.Location = new System.Drawing.Point(285, 204);
            this.txtTechnicianprice.Name = "txtTechnicianprice";
            this.txtTechnicianprice.Size = new System.Drawing.Size(179, 27);
            this.txtTechnicianprice.TabIndex = 12;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Location = new System.Drawing.Point(285, 253);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(179, 27);
            this.txtTotalQty.TabIndex = 13;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Location = new System.Drawing.Point(285, 306);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(250, 27);
            this.dtpPurchaseDate.TabIndex = 14;
            // 
            // lblproductdetails
            // 
            this.lblproductdetails.AutoSize = true;
            this.lblproductdetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblproductdetails.Location = new System.Drawing.Point(413, 9);
            this.lblproductdetails.Name = "lblproductdetails";
            this.lblproductdetails.Size = new System.Drawing.Size(179, 31);
            this.lblproductdetails.TabIndex = 15;
            this.lblproductdetails.Text = "Product Details";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(131, 365);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(334, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnClose);
            this.grpMain.Controls.Add(this.btnCancel);
            this.grpMain.Controls.Add(this.btnInsert);
            this.grpMain.Controls.Add(this.dtpPurchaseDate);
            this.grpMain.Controls.Add(this.txtTotalQty);
            this.grpMain.Controls.Add(this.txtTechnicianprice);
            this.grpMain.Controls.Add(this.txtWholesalePrice);
            this.grpMain.Controls.Add(this.txtStockQty);
            this.grpMain.Controls.Add(this.txtDescription);
            this.grpMain.Controls.Add(this.lblPurchaseDate);
            this.grpMain.Controls.Add(this.lblTotalQty);
            this.grpMain.Controls.Add(this.lblTechnicianprice);
            this.grpMain.Controls.Add(this.lblWholesaleprice);
            this.grpMain.Controls.Add(this.lblStockQty);
            this.grpMain.Controls.Add(this.lblDescription);
            this.grpMain.Location = new System.Drawing.Point(133, 54);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(687, 414);
            this.grpMain.TabIndex = 18;
            this.grpMain.TabStop = false;
            this.grpMain.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(505, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lnkAddnew
            // 
            this.lnkAddnew.AutoSize = true;
            this.lnkAddnew.Location = new System.Drawing.Point(1014, 167);
            this.lnkAddnew.Name = "lnkAddnew";
            this.lnkAddnew.Size = new System.Drawing.Size(64, 20);
            this.lnkAddnew.TabIndex = 19;
            this.lnkAddnew.TabStop = true;
            this.lnkAddnew.Text = "Addnew";
            this.lnkAddnew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddnew_LinkClicked);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 716);
            this.Controls.Add(this.lnkAddnew);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.lblproductdetails);
            this.Controls.Add(this.grdproducts);
            this.Name = "FrmProduct";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdproducts)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdproducts;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.Label lblWholesaleprice;
        private System.Windows.Forms.Label lblTechnicianprice;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtStockQty;
        private System.Windows.Forms.TextBox txtWholesalePrice;
        private System.Windows.Forms.TextBox txtTechnicianprice;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label lblproductdetails;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.LinkLabel lnkAddnew;
        private System.Windows.Forms.Button btnClose;
    }
}

