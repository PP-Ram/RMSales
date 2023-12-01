
namespace RMServices
{
    partial class FrmExpenditure
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalamount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtTotalamount = new System.Windows.Forms.TextBox();
            this.lblExpendituredetails = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpexpenditure = new System.Windows.Forms.GroupBox();
            this.grdExpenditure = new System.Windows.Forms.DataGridView();
            this.grpexpenditure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenditure)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // lblTotalamount
            // 
            this.lblTotalamount.AutoSize = true;
            this.lblTotalamount.Location = new System.Drawing.Point(96, 157);
            this.lblTotalamount.Name = "lblTotalamount";
            this.lblTotalamount.Size = new System.Drawing.Size(93, 20);
            this.lblTotalamount.TabIndex = 1;
            this.lblTotalamount.Text = "Totalamount";
            this.lblTotalamount.Click += new System.EventHandler(this.lblTotalamount_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(96, 210);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(96, 278);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(55, 20);
            this.lblDetails.TabIndex = 3;
            this.lblDetails.Text = "Details";
            // 
            // txtTotalamount
            // 
            this.txtTotalamount.Location = new System.Drawing.Point(227, 150);
            this.txtTotalamount.Name = "txtTotalamount";
            this.txtTotalamount.Size = new System.Drawing.Size(125, 27);
            this.txtTotalamount.TabIndex = 5;
            // 
            // lblExpendituredetails
            // 
            this.lblExpendituredetails.AutoSize = true;
            this.lblExpendituredetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpendituredetails.Location = new System.Drawing.Point(213, 1);
            this.lblExpendituredetails.Name = "lblExpendituredetails";
            this.lblExpendituredetails.Size = new System.Drawing.Size(215, 31);
            this.lblExpendituredetails.TabIndex = 7;
            this.lblExpendituredetails.Text = "Expendituredetails";
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(227, 205);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(250, 27);
            this.dtpdate.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(227, 51);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 68);
            this.txtDescription.TabIndex = 21;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(227, 249);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(265, 68);
            this.txtDetails.TabIndex = 22;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(57, 347);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(334, 347);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpexpenditure
            // 
            this.grpexpenditure.Controls.Add(this.grdExpenditure);
            this.grpexpenditure.Controls.Add(this.btnClose);
            this.grpexpenditure.Controls.Add(this.btnCancel);
            this.grpexpenditure.Controls.Add(this.txtDetails);
            this.grpexpenditure.Controls.Add(this.btnInsert);
            this.grpexpenditure.Controls.Add(this.txtDescription);
            this.grpexpenditure.Controls.Add(this.dtpdate);
            this.grpexpenditure.Controls.Add(this.lblExpendituredetails);
            this.grpexpenditure.Controls.Add(this.txtTotalamount);
            this.grpexpenditure.Controls.Add(this.lblDetails);
            this.grpexpenditure.Controls.Add(this.lblDate);
            this.grpexpenditure.Controls.Add(this.lblTotalamount);
            this.grpexpenditure.Controls.Add(this.label1);
            this.grpexpenditure.Location = new System.Drawing.Point(123, 17);
            this.grpexpenditure.Name = "grpexpenditure";
            this.grpexpenditure.Size = new System.Drawing.Size(555, 434);
            this.grpexpenditure.TabIndex = 26;
            this.grpexpenditure.TabStop = false;
            // 
            // grdExpenditure
            // 
            this.grdExpenditure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpenditure.Location = new System.Drawing.Point(-111, 249);
            this.grdExpenditure.Name = "grdExpenditure";
            this.grdExpenditure.RowHeadersWidth = 51;
            this.grdExpenditure.RowTemplate.Height = 29;
            this.grdExpenditure.Size = new System.Drawing.Size(796, 391);
            this.grdExpenditure.TabIndex = 27;
            // 
            // FrmExpenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 687);
            this.Controls.Add(this.grpexpenditure);
            this.Name = "FrmExpenditure";
            this.Text = "FrmExpenditure";
            this.Load += new System.EventHandler(this.FrmExpenditure_Load);
            this.grpexpenditure.ResumeLayout(false);
            this.grpexpenditure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenditure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalamount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtTotalamount;
        private System.Windows.Forms.Label lblExpendituredetails;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpexpenditure;
        private System.Windows.Forms.DataGridView grdExpenditure;
    }
}