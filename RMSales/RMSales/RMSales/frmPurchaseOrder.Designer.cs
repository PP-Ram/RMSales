namespace RMSales
{
    partial class frmPurchaseOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgStock = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgPurchase = new System.Windows.Forms.DataGridView();
            this.lblTotalSalePrice = new System.Windows.Forms.Label();
            this.dgSale = new System.Windows.Forms.DataGridView();
            this.ntmCreateOrder = new System.Windows.Forms.Button();
            this.pnlPO = new System.Windows.Forms.Panel();
            this.lblSaleID = new System.Windows.Forms.Label();
            this.btnRemorePOItem = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddPO = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblNoItem = new System.Windows.Forms.Label();
            this.lnkShow = new System.Windows.Forms.LinkLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).BeginInit();
            this.pnlPO.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgStock
            // 
            this.dgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.pcode,
            this.pname,
            this.Bqty,
            this.Sqty,
            this.stock,
            this.price,
            this.Oqty,
            this.OrderAmt});
            this.dgStock.Location = new System.Drawing.Point(49, 76);
            this.dgStock.Name = "dgStock";
            this.dgStock.Size = new System.Drawing.Size(670, 638);
            this.dgStock.TabIndex = 1;
            this.dgStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStock_Click);
            this.dgStock.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStock_CellLeave);
            this.dgStock.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStock_CellValueChanged);
            // 
            // Select
            // 
            this.Select.FillWeight = 50F;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Width = 50;
            // 
            // pcode
            // 
            this.pcode.FillWeight = 50F;
            this.pcode.HeaderText = "Code";
            this.pcode.Name = "pcode";
            this.pcode.ReadOnly = true;
            this.pcode.Width = 50;
            // 
            // pname
            // 
            this.pname.FillWeight = 200F;
            this.pname.HeaderText = "Name";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            this.pname.Width = 180;
            // 
            // Bqty
            // 
            this.Bqty.HeaderText = "Buy Qty";
            this.Bqty.Name = "Bqty";
            this.Bqty.ReadOnly = true;
            this.Bqty.Width = 60;
            // 
            // Sqty
            // 
            this.Sqty.HeaderText = "Sell Qty";
            this.Sqty.Name = "Sqty";
            this.Sqty.ReadOnly = true;
            this.Sqty.Width = 60;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 60;
            // 
            // price
            // 
            this.price.HeaderText = "Unit Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 60;
            // 
            // Oqty
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Oqty.DefaultCellStyle = dataGridViewCellStyle6;
            this.Oqty.HeaderText = "Order Qty";
            this.Oqty.Name = "Oqty";
            this.Oqty.Width = 40;
            // 
            // OrderAmt
            // 
            this.OrderAmt.HeaderText = "OrderAmt";
            this.OrderAmt.Name = "OrderAmt";
            this.OrderAmt.ReadOnly = true;
            this.OrderAmt.Width = 50;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(560, 720);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgPurchase
            // 
            this.dgPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchase.Location = new System.Drawing.Point(771, 76);
            this.dgPurchase.Name = "dgPurchase";
            this.dgPurchase.Size = new System.Drawing.Size(569, 291);
            this.dgPurchase.TabIndex = 5;
            // 
            // lblTotalSalePrice
            // 
            this.lblTotalSalePrice.AutoSize = true;
            this.lblTotalSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalePrice.Location = new System.Drawing.Point(1621, 738);
            this.lblTotalSalePrice.Name = "lblTotalSalePrice";
            this.lblTotalSalePrice.Size = new System.Drawing.Size(51, 16);
            this.lblTotalSalePrice.TabIndex = 9;
            this.lblTotalSalePrice.Text = "label1";
            // 
            // dgSale
            // 
            this.dgSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSale.Location = new System.Drawing.Point(771, 409);
            this.dgSale.Name = "dgSale";
            this.dgSale.Size = new System.Drawing.Size(569, 269);
            this.dgSale.TabIndex = 12;
            // 
            // ntmCreateOrder
            // 
            this.ntmCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntmCreateOrder.Location = new System.Drawing.Point(519, 33);
            this.ntmCreateOrder.Name = "ntmCreateOrder";
            this.ntmCreateOrder.Size = new System.Drawing.Size(193, 29);
            this.ntmCreateOrder.TabIndex = 13;
            this.ntmCreateOrder.Text = "Checkout";
            this.ntmCreateOrder.UseVisualStyleBackColor = true;
            this.ntmCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // pnlPO
            // 
            this.pnlPO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPO.Controls.Add(this.lblSaleID);
            this.pnlPO.Controls.Add(this.btnRemorePOItem);
            this.pnlPO.Controls.Add(this.lblTotalPrice);
            this.pnlPO.Controls.Add(this.lblNoItem);
            this.pnlPO.Controls.Add(this.lblQty);
            this.pnlPO.Controls.Add(this.label8);
            this.pnlPO.Controls.Add(this.btnAddPO);
            this.pnlPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPO.Location = new System.Drawing.Point(732, 71);
            this.pnlPO.Name = "pnlPO";
            this.pnlPO.Size = new System.Drawing.Size(685, 648);
            this.pnlPO.TabIndex = 15;
            this.pnlPO.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPO_Paint);
            // 
            // lblSaleID
            // 
            this.lblSaleID.AutoSize = true;
            this.lblSaleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleID.Location = new System.Drawing.Point(572, 30);
            this.lblSaleID.Name = "lblSaleID";
            this.lblSaleID.Size = new System.Drawing.Size(76, 20);
            this.lblSaleID.TabIndex = 22;
            this.lblSaleID.Text = "New Sale";
            // 
            // btnRemorePOItem
            // 
            this.btnRemorePOItem.AutoSize = true;
            this.btnRemorePOItem.Location = new System.Drawing.Point(490, 610);
            this.btnRemorePOItem.Name = "btnRemorePOItem";
            this.btnRemorePOItem.Size = new System.Drawing.Size(68, 20);
            this.btnRemorePOItem.TabIndex = 21;
            this.btnRemorePOItem.TabStop = true;
            this.btnRemorePOItem.Text = "Remove";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Confirm";
            // 
            // btnAddPO
            // 
            this.btnAddPO.BackColor = System.Drawing.Color.Green;
            this.btnAddPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPO.Location = new System.Drawing.Point(327, 599);
            this.btnAddPO.Name = "btnAddPO";
            this.btnAddPO.Size = new System.Drawing.Size(121, 42);
            this.btnAddPO.TabIndex = 11;
            this.btnAddPO.Text = "Save Order";
            this.btnAddPO.UseVisualStyleBackColor = false;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.Red;
            this.lblQty.Location = new System.Drawing.Point(168, 556);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(68, 20);
            this.lblQty.TabIndex = 25;
            this.lblQty.Text = "Quantity";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(450, 556);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(83, 20);
            this.lblTotalPrice.TabIndex = 24;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "Supplier Name";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(49, 34);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(331, 28);
            this.cbSupplier.TabIndex = 16;
            // 
            // lblNoItem
            // 
            this.lblNoItem.AutoSize = true;
            this.lblNoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoItem.ForeColor = System.Drawing.Color.Red;
            this.lblNoItem.Location = new System.Drawing.Point(33, 556);
            this.lblNoItem.Name = "lblNoItem";
            this.lblNoItem.Size = new System.Drawing.Size(90, 20);
            this.lblNoItem.TabIndex = 26;
            this.lblNoItem.Text = "No. Of Item";
            // 
            // lnkShow
            // 
            this.lnkShow.AutoSize = true;
            this.lnkShow.Location = new System.Drawing.Point(445, 49);
            this.lnkShow.Name = "lnkShow";
            this.lnkShow.Size = new System.Drawing.Size(57, 13);
            this.lnkShow.TabIndex = 27;
            this.lnkShow.TabStop = true;
            this.lnkShow.Text = "Show Item";
            this.lnkShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShow_LinkClicked);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(771, 151);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(512, 462);
            this.webBrowser1.TabIndex = 28;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lnkShow);
            this.Controls.Add(this.pnlPO);
            this.Controls.Add(this.ntmCreateOrder);
            this.Controls.Add(this.dgSale);
            this.Controls.Add(this.lblTotalSalePrice);
            this.Controls.Add(this.dgPurchase);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.dgStock);
            this.Name = "frmPurchaseOrder";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).EndInit();
            this.pnlPO.ResumeLayout(false);
            this.pnlPO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgStock;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgPurchase;
        private System.Windows.Forms.Label lblTotalSalePrice;
        private System.Windows.Forms.DataGridView dgSale;
        private System.Windows.Forms.Button ntmCreateOrder;
        private System.Windows.Forms.Panel pnlPO;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblSaleID;
        private System.Windows.Forms.LinkLabel btnRemorePOItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddPO;
        private System.Windows.Forms.Label lblNoItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAmt;
        private System.Windows.Forms.LinkLabel lnkShow;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

