namespace RMSales
{
    partial class frmMasterProducts
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
            this.lnkRefresh = new System.Windows.Forms.LinkLabel();
            this.pnlNewProduct = new System.Windows.Forms.Panel();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnANPrdouctCancel = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lnkAddnew = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgMasterProduct = new System.Windows.Forms.DataGridView();
            this.pnlNewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.AutoSize = true;
            this.lnkRefresh.Location = new System.Drawing.Point(735, 634);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(44, 13);
            this.lnkRefresh.TabIndex = 21;
            this.lnkRefresh.TabStop = true;
            this.lnkRefresh.Text = "Refresh";
            this.lnkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefresh_LinkClicked);
            // 
            // pnlNewProduct
            // 
            this.pnlNewProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNewProduct.Controls.Add(this.txtSalePrice);
            this.pnlNewProduct.Controls.Add(this.txtOrderPrice);
            this.pnlNewProduct.Controls.Add(this.label3);
            this.pnlNewProduct.Controls.Add(this.label2);
            this.pnlNewProduct.Controls.Add(this.cbProductType);
            this.pnlNewProduct.Controls.Add(this.label7);
            this.pnlNewProduct.Controls.Add(this.btnANPrdouctCancel);
            this.pnlNewProduct.Controls.Add(this.btnAddNewProduct);
            this.pnlNewProduct.Controls.Add(this.label10);
            this.pnlNewProduct.Controls.Add(this.label11);
            this.pnlNewProduct.Controls.Add(this.txtProductName);
            this.pnlNewProduct.Location = new System.Drawing.Point(29, 147);
            this.pnlNewProduct.Name = "pnlNewProduct";
            this.pnlNewProduct.Size = new System.Drawing.Size(416, 286);
            this.pnlNewProduct.TabIndex = 20;
            this.pnlNewProduct.Visible = false;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(331, 163);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(70, 20);
            this.txtSalePrice.TabIndex = 18;
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.Location = new System.Drawing.Point(138, 163);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.Size = new System.Drawing.Size(66, 20);
            this.txtOrderPrice.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Order Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sale Price";
            // 
            // cbProductType
            // 
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Items.AddRange(new object[] {
            "Washning Machine",
            "AC",
            "Fridge",
            "Ohter"});
            this.cbProductType.Location = new System.Drawing.Point(138, 116);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(263, 21);
            this.cbProductType.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "New Product";
            // 
            // btnANPrdouctCancel
            // 
            this.btnANPrdouctCancel.Location = new System.Drawing.Point(234, 221);
            this.btnANPrdouctCancel.Name = "btnANPrdouctCancel";
            this.btnANPrdouctCancel.Size = new System.Drawing.Size(91, 23);
            this.btnANPrdouctCancel.TabIndex = 11;
            this.btnANPrdouctCancel.Text = "Cancel";
            this.btnANPrdouctCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(105, 221);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(91, 23);
            this.btnAddNewProduct.TabIndex = 10;
            this.btnAddNewProduct.Text = "Add New Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(138, 67);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(263, 20);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.Text = "1";
            // 
            // lnkAddnew
            // 
            this.lnkAddnew.AutoSize = true;
            this.lnkAddnew.Location = new System.Drawing.Point(633, 634);
            this.lnkAddnew.Name = "lnkAddnew";
            this.lnkAddnew.Size = new System.Drawing.Size(88, 13);
            this.lnkAddnew.TabIndex = 19;
            this.lnkAddnew.TabStop = true;
            this.lnkAddnew.Text = "Add new product";
            this.lnkAddnew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddnew_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search by product name";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(408, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 26);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgMasterProduct
            // 
            this.dgMasterProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMasterProduct.Location = new System.Drawing.Point(90, 60);
            this.dgMasterProduct.Name = "dgMasterProduct";
            this.dgMasterProduct.Size = new System.Drawing.Size(670, 561);
            this.dgMasterProduct.TabIndex = 16;
            this.dgMasterProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMasterProduct_CellValueChanged);
            // 
            // frmMasterProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 808);
            this.Controls.Add(this.lnkRefresh);
            this.Controls.Add(this.pnlNewProduct);
            this.Controls.Add(this.lnkAddnew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgMasterProduct);
            this.Name = "frmMasterProducts";
            this.Text = "frmMasterProducts";
            this.Load += new System.EventHandler(this.frmMasterProducts_Load);
            this.pnlNewProduct.ResumeLayout(false);
            this.pnlNewProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkRefresh;
        private System.Windows.Forms.Panel pnlNewProduct;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnANPrdouctCancel;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.LinkLabel lnkAddnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgMasterProduct;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}