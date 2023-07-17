namespace BankManagmentSystem_WinForms.Forms
{
    partial class frmAddUpdateAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAddUpdateIcon = new System.Windows.Forms.PictureBox();
            this.lblScreenName = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.pAccountInfo = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtpDateOpened = new System.Windows.Forms.DateTimePicker();
            this.cbAccountTypes = new System.Windows.Forms.ComboBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUpdateIcon)).BeginInit();
            this.pAccountInfo.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.pbAddUpdateIcon);
            this.panel1.Controls.Add(this.lblScreenName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 56);
            this.panel1.TabIndex = 3;
            // 
            // pbAddUpdateIcon
            // 
            this.pbAddUpdateIcon.Image = global::BankManagmentSystem_WinForms.Properties.Resources.add;
            this.pbAddUpdateIcon.Location = new System.Drawing.Point(22, 13);
            this.pbAddUpdateIcon.Name = "pbAddUpdateIcon";
            this.pbAddUpdateIcon.Size = new System.Drawing.Size(41, 33);
            this.pbAddUpdateIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddUpdateIcon.TabIndex = 4;
            this.pbAddUpdateIcon.TabStop = false;
            // 
            // lblScreenName
            // 
            this.lblScreenName.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Bold);
            this.lblScreenName.ForeColor = System.Drawing.Color.Black;
            this.lblScreenName.Location = new System.Drawing.Point(62, 0);
            this.lblScreenName.Name = "lblScreenName";
            this.lblScreenName.Size = new System.Drawing.Size(351, 56);
            this.lblScreenName.TabIndex = 0;
            this.lblScreenName.Text = "Add New Account Screen";
            this.lblScreenName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(0, 57);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(269, 28);
            this.txtCustomerID.TabIndex = 1;
            // 
            // pAccountInfo
            // 
            this.pAccountInfo.BackColor = System.Drawing.Color.LightCyan;
            this.pAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAccountInfo.Controls.Add(this.panel10);
            this.pAccountInfo.Controls.Add(this.panel11);
            this.pAccountInfo.Location = new System.Drawing.Point(103, 166);
            this.pAccountInfo.Name = "pAccountInfo";
            this.pAccountInfo.Size = new System.Drawing.Size(732, 293);
            this.pAccountInfo.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dtpDateOpened);
            this.panel10.Controls.Add(this.cbAccountTypes);
            this.panel10.Controls.Add(this.txtBalance);
            this.panel10.Controls.Add(this.txtPinCode);
            this.panel10.Controls.Add(this.lblAccountID);
            this.panel10.Controls.Add(this.txtCustomerID);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(235, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(496, 291);
            this.panel10.TabIndex = 1;
            // 
            // dtpDateOpened
            // 
            this.dtpDateOpened.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dtpDateOpened.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpDateOpened.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOpened.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOpened.Location = new System.Drawing.Point(0, 99);
            this.dtpDateOpened.MaxDate = new System.DateTime(2029, 7, 6, 0, 0, 0, 0);
            this.dtpDateOpened.Name = "dtpDateOpened";
            this.dtpDateOpened.Size = new System.Drawing.Size(269, 28);
            this.dtpDateOpened.TabIndex = 2;
            this.dtpDateOpened.Value = new System.DateTime(2023, 7, 6, 0, 0, 0, 0);
            // 
            // cbAccountTypes
            // 
            this.cbAccountTypes.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccountTypes.FormattingEnabled = true;
            this.cbAccountTypes.Location = new System.Drawing.Point(0, 148);
            this.cbAccountTypes.Name = "cbAccountTypes";
            this.cbAccountTypes.Size = new System.Drawing.Size(269, 28);
            this.cbAccountTypes.TabIndex = 3;
            // 
            // txtBalance
            // 
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBalance.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(0, 195);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(269, 28);
            this.txtBalance.TabIndex = 4;
            // 
            // txtPinCode
            // 
            this.txtPinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPinCode.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.Location = new System.Drawing.Point(0, 241);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(269, 28);
            this.txtPinCode.TabIndex = 5;
            // 
            // lblAccountID
            // 
            this.lblAccountID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccountID.Font = new System.Drawing.Font("Open Sans", 9F);
            this.lblAccountID.ForeColor = System.Drawing.Color.Black;
            this.lblAccountID.Location = new System.Drawing.Point(0, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(496, 46);
            this.lblAccountID.TabIndex = 14;
            this.lblAccountID.Text = "-----";
            this.lblAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(235, 291);
            this.panel11.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pin Code:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(0, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 46);
            this.label12.TabIndex = 13;
            this.label12.Text = "Balance:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(0, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 46);
            this.label11.TabIndex = 12;
            this.label11.Text = "Account Type:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(0, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 46);
            this.label10.TabIndex = 11;
            this.label10.Text = "Date Opened:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(0, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 46);
            this.label9.TabIndex = 10;
            this.label9.Text = "Customer ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 46);
            this.label7.TabIndex = 9;
            this.label7.Text = "Account ID:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(330, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 46);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(477, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 46);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(938, 670);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pAccountInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddUpdateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/UpdateAccount";
            this.Load += new System.EventHandler(this.frmAddUpdateAccount_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUpdateIcon)).EndInit();
            this.pAccountInfo.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAddUpdateIcon;
        private System.Windows.Forms.Label lblScreenName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Panel pAccountInfo;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker dtpDateOpened;
        private System.Windows.Forms.ComboBox cbAccountTypes;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}