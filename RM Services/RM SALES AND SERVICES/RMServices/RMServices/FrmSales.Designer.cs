
namespace RMServices
{
    partial class FrmSales
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
            this.lblproductdetails = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.grdDaySales = new System.Windows.Forms.DataGridView();
            this.grdSummary = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDaySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblproductdetails
            // 
            this.lblproductdetails.AutoSize = true;
            this.lblproductdetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblproductdetails.Location = new System.Drawing.Point(413, 9);
            this.lblproductdetails.Name = "lblproductdetails";
            this.lblproductdetails.Size = new System.Drawing.Size(148, 31);
            this.lblproductdetails.TabIndex = 15;
            this.lblproductdetails.Text = "Sales Details";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(289, 68);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(229, 27);
            this.dtpToDate.TabIndex = 20;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(37, 68);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(229, 27);
            this.dtpFromDate.TabIndex = 21;
            // 
            // grdDaySales
            // 
            this.grdDaySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDaySales.Location = new System.Drawing.Point(37, 101);
            this.grdDaySales.Name = "grdDaySales";
            this.grdDaySales.RowHeadersWidth = 51;
            this.grdDaySales.RowTemplate.Height = 29;
            this.grdDaySales.Size = new System.Drawing.Size(601, 600);
            this.grdDaySales.TabIndex = 22;
            // 
            // grdSummary
            // 
            this.grdSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSummary.Location = new System.Drawing.Point(702, 104);
            this.grdSummary.Name = "grdSummary";
            this.grdSummary.RowHeadersWidth = 51;
            this.grdSummary.Size = new System.Drawing.Size(295, 600);
            this.grdSummary.TabIndex = 23;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(702, 66);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 29);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 716);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grdSummary);
            this.Controls.Add(this.grdDaySales);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.lblproductdetails);
            this.Name = "FrmSales";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDaySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblproductdetails;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DataGridView grdDaySales;
        private System.Windows.Forms.DataGridView grdSummary;
        private System.Windows.Forms.Button btnRefresh;
    }
}

