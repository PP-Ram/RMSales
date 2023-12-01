namespace RMSales
{
    partial class frmSales
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
            this.dgSaleItem = new System.Windows.Forms.DataGridView();
            this.lblTotalSalePrice = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.pnlAddSaleNew = new System.Windows.Forms.Panel();
            this.lblTotalCurItem = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.dgCurrentSale = new System.Windows.Forms.DataGridView();
            this.lblSaleID = new System.Windows.Forms.Label();
            this.btnSaleRemove = new System.Windows.Forms.LinkLabel();
            this.btnSaleAdd = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cbTechnician = new System.Windows.Forms.ComboBox();
            this.cbSaleProductName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddSaleCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSaleTPrice = new System.Windows.Forms.TextBox();
            this.textSaleGST = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgSaleMaster = new System.Windows.Forms.DataGridView();
            this.lblTotalSaleIten = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleItem)).BeginInit();
            this.pnlAddSaleNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrentSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSaleItem
            // 
            this.dgSaleItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaleItem.Location = new System.Drawing.Point(968, 371);
            this.dgSaleItem.Name = "dgSaleItem";
            this.dgSaleItem.Size = new System.Drawing.Size(578, 257);
            this.dgSaleItem.TabIndex = 5;
            // 
            // lblTotalSalePrice
            // 
            this.lblTotalSalePrice.AutoSize = true;
            this.lblTotalSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalePrice.Location = new System.Drawing.Point(1266, 674);
            this.lblTotalSalePrice.Name = "lblTotalSalePrice";
            this.lblTotalSalePrice.Size = new System.Drawing.Size(66, 24);
            this.lblTotalSalePrice.TabIndex = 9;
            this.lblTotalSalePrice.Text = "label1";
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(1413, 46);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(133, 24);
            this.cbMonth.TabIndex = 10;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // pnlAddSaleNew
            // 
            this.pnlAddSaleNew.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddSaleNew.Controls.Add(this.lblTotalCurItem);
            this.pnlAddSaleNew.Controls.Add(this.lblTotalPrice);
            this.pnlAddSaleNew.Controls.Add(this.dgCurrentSale);
            this.pnlAddSaleNew.Controls.Add(this.lblSaleID);
            this.pnlAddSaleNew.Controls.Add(this.btnSaleRemove);
            this.pnlAddSaleNew.Controls.Add(this.btnSaleAdd);
            this.pnlAddSaleNew.Controls.Add(this.label15);
            this.pnlAddSaleNew.Controls.Add(this.cbTechnician);
            this.pnlAddSaleNew.Controls.Add(this.cbSaleProductName);
            this.pnlAddSaleNew.Controls.Add(this.label8);
            this.pnlAddSaleNew.Controls.Add(this.dpSaleDate);
            this.pnlAddSaleNew.Controls.Add(this.btnAddSaleCancel);
            this.pnlAddSaleNew.Controls.Add(this.label9);
            this.pnlAddSaleNew.Controls.Add(this.label12);
            this.pnlAddSaleNew.Controls.Add(this.txtSaleTPrice);
            this.pnlAddSaleNew.Controls.Add(this.textSaleGST);
            this.pnlAddSaleNew.Controls.Add(this.label13);
            this.pnlAddSaleNew.Controls.Add(this.label14);
            this.pnlAddSaleNew.Controls.Add(this.txtSalePrice);
            this.pnlAddSaleNew.Controls.Add(this.txtQty);
            this.pnlAddSaleNew.Controls.Add(this.label16);
            this.pnlAddSaleNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAddSaleNew.Location = new System.Drawing.Point(52, 82);
            this.pnlAddSaleNew.Name = "pnlAddSaleNew";
            this.pnlAddSaleNew.Size = new System.Drawing.Size(829, 546);
            this.pnlAddSaleNew.TabIndex = 14;
            this.pnlAddSaleNew.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddSaleNew_Paint);
            // 
            // lblTotalCurItem
            // 
            this.lblTotalCurItem.AutoSize = true;
            this.lblTotalCurItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCurItem.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCurItem.Location = new System.Drawing.Point(38, 481);
            this.lblTotalCurItem.Name = "lblTotalCurItem";
            this.lblTotalCurItem.Size = new System.Drawing.Size(76, 20);
            this.lblTotalCurItem.TabIndex = 25;
            this.lblTotalCurItem.Text = "New Sale";
            this.lblTotalCurItem.Click += new System.EventHandler(this.lblTotalCurItem_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(165, 481);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(76, 20);
            this.lblTotalPrice.TabIndex = 24;
            this.lblTotalPrice.Text = "New Sale";
            // 
            // dgCurrentSale
            // 
            this.dgCurrentSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCurrentSale.Location = new System.Drawing.Point(41, 221);
            this.dgCurrentSale.Name = "dgCurrentSale";
            this.dgCurrentSale.Size = new System.Drawing.Size(754, 235);
            this.dgCurrentSale.TabIndex = 23;
            // 
            // lblSaleID
            // 
            this.lblSaleID.AutoSize = true;
            this.lblSaleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleID.Location = new System.Drawing.Point(691, 30);
            this.lblSaleID.Name = "lblSaleID";
            this.lblSaleID.Size = new System.Drawing.Size(76, 20);
            this.lblSaleID.TabIndex = 22;
            this.lblSaleID.Text = "New Sale";
            // 
            // btnSaleRemove
            // 
            this.btnSaleRemove.AutoSize = true;
            this.btnSaleRemove.Location = new System.Drawing.Point(679, 486);
            this.btnSaleRemove.Name = "btnSaleRemove";
            this.btnSaleRemove.Size = new System.Drawing.Size(68, 20);
            this.btnSaleRemove.TabIndex = 21;
            this.btnSaleRemove.TabStop = true;
            this.btnSaleRemove.Text = "Remove";
            this.btnSaleRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSaleRemove_LinkClicked);
            // 
            // btnSaleAdd
            // 
            this.btnSaleAdd.Location = new System.Drawing.Point(644, 155);
            this.btnSaleAdd.Name = "btnSaleAdd";
            this.btnSaleAdd.Size = new System.Drawing.Size(88, 30);
            this.btnSaleAdd.TabIndex = 19;
            this.btnSaleAdd.Text = "Add Item";
            this.btnSaleAdd.UseVisualStyleBackColor = true;
            this.btnSaleAdd.Click += new System.EventHandler(this.btnSaleAdd_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(38, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "Technician Name";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // cbTechnician
            // 
            this.cbTechnician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTechnician.FormattingEnabled = true;
            this.cbTechnician.Location = new System.Drawing.Point(41, 79);
            this.cbTechnician.Name = "cbTechnician";
            this.cbTechnician.Size = new System.Drawing.Size(204, 28);
            this.cbTechnician.TabIndex = 16;
            // 
            // cbSaleProductName
            // 
            this.cbSaleProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSaleProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaleProductName.FormattingEnabled = true;
            this.cbSaleProductName.Location = new System.Drawing.Point(41, 157);
            this.cbSaleProductName.Name = "cbSaleProductName";
            this.cbSaleProductName.Size = new System.Drawing.Size(204, 28);
            this.cbSaleProductName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sale Products";
            // 
            // dpSaleDate
            // 
            this.dpSaleDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpSaleDate.Location = new System.Drawing.Point(582, 65);
            this.dpSaleDate.Name = "dpSaleDate";
            this.dpSaleDate.Size = new System.Drawing.Size(185, 26);
            this.dpSaleDate.TabIndex = 12;
            // 
            // btnAddSaleCancel
            // 
            this.btnAddSaleCancel.BackColor = System.Drawing.Color.Green;
            this.btnAddSaleCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSaleCancel.Location = new System.Drawing.Point(567, 481);
            this.btnAddSaleCancel.Name = "btnAddSaleCancel";
            this.btnAddSaleCancel.Size = new System.Drawing.Size(91, 42);
            this.btnAddSaleCancel.TabIndex = 11;
            this.btnAddSaleCancel.Text = "Save";
            this.btnAddSaleCancel.UseVisualStyleBackColor = false;
            this.btnAddSaleCancel.Click += new System.EventHandler(this.btnAddSaleCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(512, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(416, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "GST";
            // 
            // txtSaleTPrice
            // 
            this.txtSaleTPrice.Location = new System.Drawing.Point(515, 157);
            this.txtSaleTPrice.Name = "txtSaleTPrice";
            this.txtSaleTPrice.Size = new System.Drawing.Size(100, 26);
            this.txtSaleTPrice.TabIndex = 7;
            this.txtSaleTPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textSaleGST
            // 
            this.textSaleGST.Location = new System.Drawing.Point(419, 157);
            this.textSaleGST.Name = "textSaleGST";
            this.textSaleGST.Size = new System.Drawing.Size(73, 26);
            this.textSaleGST.TabIndex = 6;
            this.textSaleGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(321, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(256, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Quantity";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(324, 157);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(83, 26);
            this.txtSalePrice.TabIndex = 3;
            this.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalePrice.TextChanged += new System.EventHandler(this.txtSalePrice_TextChanged);
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(259, 157);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(48, 26);
            this.txtQty.TabIndex = 2;
            this.txtQty.Text = "1";
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Product name";
            // 
            // dgSaleMaster
            // 
            this.dgSaleMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaleMaster.Location = new System.Drawing.Point(968, 82);
            this.dgSaleMaster.Name = "dgSaleMaster";
            this.dgSaleMaster.Size = new System.Drawing.Size(578, 250);
            this.dgSaleMaster.TabIndex = 17;
            this.dgSaleMaster.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSaleMaster_RowEnter);
            // 
            // lblTotalSaleIten
            // 
            this.lblTotalSaleIten.AutoSize = true;
            this.lblTotalSaleIten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaleIten.Location = new System.Drawing.Point(994, 672);
            this.lblTotalSaleIten.Name = "lblTotalSaleIten";
            this.lblTotalSaleIten.Size = new System.Drawing.Size(66, 24);
            this.lblTotalSaleIten.TabIndex = 19;
            this.lblTotalSaleIten.Text = "label1";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 977);
            this.Controls.Add(this.lblTotalSaleIten);
            this.Controls.Add(this.dgSaleMaster);
            this.Controls.Add(this.pnlAddSaleNew);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.lblTotalSalePrice);
            this.Controls.Add(this.dgSaleItem);
            this.Name = "frmSales";
            this.Text = "RM Sale Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRMSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleItem)).EndInit();
            this.pnlAddSaleNew.ResumeLayout(false);
            this.pnlAddSaleNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCurrentSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSaleItem;
        private System.Windows.Forms.Label lblTotalSalePrice;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Panel pnlAddSaleNew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpSaleDate;
        private System.Windows.Forms.Button btnAddSaleCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSaleTPrice;
        private System.Windows.Forms.TextBox textSaleGST;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbSaleProductName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbTechnician;
        private System.Windows.Forms.LinkLabel btnSaleRemove;
        private System.Windows.Forms.Button btnSaleAdd;
        private System.Windows.Forms.DataGridView dgSaleMaster;
        private System.Windows.Forms.Label lblSaleID;
        private System.Windows.Forms.DataGridView dgCurrentSale;
        private System.Windows.Forms.Label lblTotalCurItem;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalSaleIten;
    }
}

