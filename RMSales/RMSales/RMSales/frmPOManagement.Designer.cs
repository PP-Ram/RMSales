namespace RMSales
{
    partial class frmPOManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgMasterPO = new System.Windows.Forms.DataGridView();
            this.dgPOitems = new System.Windows.Forms.DataGridView();
            this.btnPOsave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbPOStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPOitems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMasterPO
            // 
            this.dgMasterPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMasterPO.Location = new System.Drawing.Point(51, 59);
            this.dgMasterPO.Name = "dgMasterPO";
            this.dgMasterPO.Size = new System.Drawing.Size(307, 241);
            this.dgMasterPO.TabIndex = 17;
            this.dgMasterPO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMasterPO_CellClick);
            // 
            // dgPOitems
            // 
            this.dgPOitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPOitems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.Code,
            this.ProductName,
            this.OrderQty,
            this.OrderPrice,
            this.ReceivedQty,
            this.SalePrice});
            this.dgPOitems.Location = new System.Drawing.Point(401, 59);
            this.dgPOitems.Name = "dgPOitems";
            this.dgPOitems.Size = new System.Drawing.Size(644, 450);
            this.dgPOitems.TabIndex = 18;
            this.dgPOitems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPOitems_CellContentClick);
            // 
            // btnPOsave
            // 
            this.btnPOsave.Location = new System.Drawing.Point(659, 565);
            this.btnPOsave.Name = "btnPOsave";
            this.btnPOsave.Size = new System.Drawing.Size(75, 23);
            this.btnPOsave.TabIndex = 19;
            this.btnPOsave.Text = "Save";
            this.btnPOsave.UseVisualStyleBackColor = true;
            this.btnPOsave.Click += new System.EventHandler(this.btnPOsave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(786, 565);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbPOStatus
            // 
            this.cbPOStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPOStatus.FormattingEnabled = true;
            this.cbPOStatus.Items.AddRange(new object[] {
            "Received",
            "Received Partial",
            "Cancelled"});
            this.cbPOStatus.Location = new System.Drawing.Point(679, 23);
            this.cbPOStatus.Name = "cbPOStatus";
            this.cbPOStatus.Size = new System.Drawing.Size(201, 21);
            this.cbPOStatus.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Purchase Order Status";
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.Visible = false;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // OrderQty
            // 
            this.OrderQty.HeaderText = "OrderQty";
            this.OrderQty.Name = "OrderQty";
            this.OrderQty.ReadOnly = true;
            // 
            // OrderPrice
            // 
            this.OrderPrice.HeaderText = "OrderPrice";
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.ReadOnly = true;
            // 
            // ReceivedQty
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ReceivedQty.DefaultCellStyle = dataGridViewCellStyle1;
            this.ReceivedQty.HeaderText = "ReceivedQty";
            this.ReceivedQty.Name = "ReceivedQty";
            // 
            // SalePrice
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SalePrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalePrice.HeaderText = "SalePrice";
            this.SalePrice.Name = "SalePrice";
            // 
            // frmPOManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPOStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPOsave);
            this.Controls.Add(this.dgPOitems);
            this.Controls.Add(this.dgMasterPO);
            this.Name = "frmPOManagement";
            this.Load += new System.EventHandler(this.frmPOManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPOitems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMasterPO;
        private System.Windows.Forms.DataGridView dgPOitems;
        private System.Windows.Forms.Button btnPOsave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbPOStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
    }
}