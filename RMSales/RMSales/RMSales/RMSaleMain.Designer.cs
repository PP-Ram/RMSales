namespace RMSales
{
    partial class RMSaleMain
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.rMSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProductManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnInvestmentDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnlOmanagemt = new System.Windows.Forms.LinkLabel();
            this.lnkReport = new System.Windows.Forms.LinkLabel();
            this.lnkProManagement = new System.Windows.Forms.LinkLabel();
            this.lnkPurchase = new System.Windows.Forms.LinkLabel();
            this.lnkSales = new System.Windows.Forms.LinkLabel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.mnMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 486);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1123, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mnMain
            // 
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rMSalesToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(1123, 24);
            this.mnMain.TabIndex = 12;
            this.mnMain.Text = "menuStrip1";
            // 
            // rMSalesToolStripMenuItem
            // 
            this.rMSalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProductManagement,
            this.mnSales,
            this.mnPurchase,
            this.mnInvestmentDetails,
            this.mnCustomer,
            this.mnSupplier,
            this.mnExit});
            this.rMSalesToolStripMenuItem.Name = "rMSalesToolStripMenuItem";
            this.rMSalesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rMSalesToolStripMenuItem.Text = "RM Sales";
            // 
            // mnProductManagement
            // 
            this.mnProductManagement.Name = "mnProductManagement";
            this.mnProductManagement.Size = new System.Drawing.Size(190, 22);
            this.mnProductManagement.Text = "Product Management";
            this.mnProductManagement.Click += new System.EventHandler(this.mnProductManagement_Click);
            // 
            // mnSales
            // 
            this.mnSales.Name = "mnSales";
            this.mnSales.Size = new System.Drawing.Size(190, 22);
            this.mnSales.Text = "Sales";
            this.mnSales.Click += new System.EventHandler(this.mnSales_Click);
            // 
            // mnPurchase
            // 
            this.mnPurchase.Name = "mnPurchase";
            this.mnPurchase.Size = new System.Drawing.Size(190, 22);
            this.mnPurchase.Text = "Purchase";
            this.mnPurchase.Click += new System.EventHandler(this.mnPurchase_Click);
            // 
            // mnInvestmentDetails
            // 
            this.mnInvestmentDetails.Name = "mnInvestmentDetails";
            this.mnInvestmentDetails.Size = new System.Drawing.Size(190, 22);
            this.mnInvestmentDetails.Text = "Investment Details";
            // 
            // mnCustomer
            // 
            this.mnCustomer.Name = "mnCustomer";
            this.mnCustomer.Size = new System.Drawing.Size(190, 22);
            this.mnCustomer.Text = "Customer";
            // 
            // mnSupplier
            // 
            this.mnSupplier.Name = "mnSupplier";
            this.mnSupplier.Size = new System.Drawing.Size(190, 22);
            this.mnSupplier.Text = "Supplier";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(190, 22);
            this.mnExit.Text = "Exit";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesDetailsToolStripMenuItem,
            this.purchaseDetailsToolStripMenuItem,
            this.productDetailsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salesDetailsToolStripMenuItem
            // 
            this.salesDetailsToolStripMenuItem.Name = "salesDetailsToolStripMenuItem";
            this.salesDetailsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salesDetailsToolStripMenuItem.Text = "Sales Details";
            // 
            // purchaseDetailsToolStripMenuItem
            // 
            this.purchaseDetailsToolStripMenuItem.Name = "purchaseDetailsToolStripMenuItem";
            this.purchaseDetailsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.purchaseDetailsToolStripMenuItem.Text = "Purchase Details";
            // 
            // productDetailsToolStripMenuItem
            // 
            this.productDetailsToolStripMenuItem.Name = "productDetailsToolStripMenuItem";
            this.productDetailsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.productDetailsToolStripMenuItem.Text = "Product Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lnlOmanagemt);
            this.panel1.Controls.Add(this.lnkReport);
            this.panel1.Controls.Add(this.lnkProManagement);
            this.panel1.Controls.Add(this.lnkPurchase);
            this.panel1.Controls.Add(this.lnkSales);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 43);
            this.panel1.TabIndex = 13;
            // 
            // lnlOmanagemt
            // 
            this.lnlOmanagemt.AutoSize = true;
            this.lnlOmanagemt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlOmanagemt.Location = new System.Drawing.Point(382, 20);
            this.lnlOmanagemt.Name = "lnlOmanagemt";
            this.lnlOmanagemt.Size = new System.Drawing.Size(124, 16);
            this.lnlOmanagemt.TabIndex = 19;
            this.lnlOmanagemt.TabStop = true;
            this.lnlOmanagemt.Text = "Order Management";
            this.lnlOmanagemt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlOmanagemt_LinkClicked);
            // 
            // lnkReport
            // 
            this.lnkReport.AutoSize = true;
            this.lnkReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReport.Location = new System.Drawing.Point(835, 20);
            this.lnkReport.Name = "lnkReport";
            this.lnkReport.Size = new System.Drawing.Size(56, 16);
            this.lnkReport.TabIndex = 18;
            this.lnkReport.TabStop = true;
            this.lnkReport.Text = "Reports";
            // 
            // lnkProManagement
            // 
            this.lnkProManagement.AutoSize = true;
            this.lnkProManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkProManagement.Location = new System.Drawing.Point(228, 20);
            this.lnkProManagement.Name = "lnkProManagement";
            this.lnkProManagement.Size = new System.Drawing.Size(143, 16);
            this.lnkProManagement.TabIndex = 17;
            this.lnkProManagement.TabStop = true;
            this.lnkProManagement.Text = "Prouduct Management";
            this.lnkProManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProduct_LinkClicked);
            // 
            // lnkPurchase
            // 
            this.lnkPurchase.AutoSize = true;
            this.lnkPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPurchase.Location = new System.Drawing.Point(114, 20);
            this.lnkPurchase.Name = "lnkPurchase";
            this.lnkPurchase.Size = new System.Drawing.Size(108, 16);
            this.lnkPurchase.TabIndex = 16;
            this.lnkPurchase.TabStop = true;
            this.lnkPurchase.Text = "Create Purchase";
            this.lnkPurchase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPurchase_Click);
            // 
            // lnkSales
            // 
            this.lnkSales.AutoSize = true;
            this.lnkSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSales.Location = new System.Drawing.Point(37, 20);
            this.lnkSales.Name = "lnkSales";
            this.lnkSales.Size = new System.Drawing.Size(71, 16);
            this.lnkSales.TabIndex = 15;
            this.lnkSales.TabStop = true;
            this.lnkSales.Text = "Add Sales";
            this.lnkSales.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSales_LinkClicked);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1050, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(526, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(133, 20);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "RM Enterprises";
            // 
            // RMSaleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnMain);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "RMSaleMain";
            this.Text = "RMSaleMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RMSaleMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem rMSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnProductManagement;
        private System.Windows.Forms.ToolStripMenuItem mnSales;
        private System.Windows.Forms.ToolStripMenuItem mnPurchase;
        private System.Windows.Forms.ToolStripMenuItem mnInvestmentDetails;
        private System.Windows.Forms.ToolStripMenuItem mnCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDetailsToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkSales;
        private System.Windows.Forms.LinkLabel lnlOmanagemt;
        private System.Windows.Forms.LinkLabel lnkReport;
        private System.Windows.Forms.LinkLabel lnkProManagement;
        private System.Windows.Forms.LinkLabel lnkPurchase;
    }
}



