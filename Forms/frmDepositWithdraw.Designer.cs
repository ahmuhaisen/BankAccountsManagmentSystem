namespace BankManagmentSystem_WinForms.Forms
{
    partial class frmDepositWithdraw
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
            this.pTitle = new System.Windows.Forms.Panel();
            this.pbScreenIcon = new System.Windows.Forms.PictureBox();
            this.lblScreenName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pCurrentAccountInfo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblAccountOwner = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFindStatus = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pAmount = new System.Windows.Forms.Panel();
            this.pEnterAccountNumber = new System.Windows.Forms.Panel();
            this.pTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenIcon)).BeginInit();
            this.pCurrentAccountInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pAmount.SuspendLayout();
            this.pEnterAccountNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.pTitle.Controls.Add(this.pbScreenIcon);
            this.pTitle.Controls.Add(this.lblScreenName);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(938, 56);
            this.pTitle.TabIndex = 4;
            // 
            // pbScreenIcon
            // 
            this.pbScreenIcon.Image = global::BankManagmentSystem_WinForms.Properties.Resources.transaction;
            this.pbScreenIcon.Location = new System.Drawing.Point(22, 13);
            this.pbScreenIcon.Name = "pbScreenIcon";
            this.pbScreenIcon.Size = new System.Drawing.Size(41, 33);
            this.pbScreenIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScreenIcon.TabIndex = 4;
            this.pbScreenIcon.TabStop = false;
            // 
            // lblScreenName
            // 
            this.lblScreenName.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Bold);
            this.lblScreenName.ForeColor = System.Drawing.Color.Black;
            this.lblScreenName.Location = new System.Drawing.Point(62, 0);
            this.lblScreenName.Name = "lblScreenName";
            this.lblScreenName.Size = new System.Drawing.Size(351, 56);
            this.lblScreenName.TabIndex = 0;
            this.lblScreenName.Text = "Deposit/Withdraw Screen";
            this.lblScreenName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(384, 565);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 46);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pCurrentAccountInfo
            // 
            this.pCurrentAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCurrentAccountInfo.Controls.Add(this.panel3);
            this.pCurrentAccountInfo.Controls.Add(this.panel2);
            this.pCurrentAccountInfo.Controls.Add(this.label1);
            this.pCurrentAccountInfo.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCurrentAccountInfo.Location = new System.Drawing.Point(584, 145);
            this.pCurrentAccountInfo.Name = "pCurrentAccountInfo";
            this.pCurrentAccountInfo.Size = new System.Drawing.Size(313, 267);
            this.pCurrentAccountInfo.TabIndex = 12;
            this.pCurrentAccountInfo.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblAccountBalance);
            this.panel3.Controls.Add(this.lblAccountType);
            this.panel3.Controls.Add(this.lblAccountOwner);
            this.panel3.Controls.Add(this.lblAccountID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(152, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 228);
            this.panel3.TabIndex = 2;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.BackColor = System.Drawing.Color.White;
            this.lblAccountBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccountBalance.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountBalance.Location = new System.Drawing.Point(0, 111);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(159, 37);
            this.lblAccountBalance.TabIndex = 9;
            this.lblAccountBalance.Text = "Account Info";
            this.lblAccountBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountType
            // 
            this.lblAccountType.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAccountType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccountType.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(0, 74);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(159, 37);
            this.lblAccountType.TabIndex = 8;
            this.lblAccountType.Text = "Account Info";
            this.lblAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountOwner
            // 
            this.lblAccountOwner.BackColor = System.Drawing.Color.White;
            this.lblAccountOwner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccountOwner.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountOwner.Location = new System.Drawing.Point(0, 37);
            this.lblAccountOwner.Name = "lblAccountOwner";
            this.lblAccountOwner.Size = new System.Drawing.Size(159, 37);
            this.lblAccountOwner.TabIndex = 7;
            this.lblAccountOwner.Text = "Account Info";
            this.lblAccountOwner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountID
            // 
            this.lblAccountID.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAccountID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccountID.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.Location = new System.Drawing.Point(0, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(159, 37);
            this.lblAccountID.TabIndex = 6;
            this.lblAccountID.Text = "Account Info";
            this.lblAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 228);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Available Balance:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Account Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Account Owner:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Account ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Account Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(15, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 38);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(489, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter an Account Number...";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFindStatus
            // 
            this.lblFindStatus.ForeColor = System.Drawing.Color.Red;
            this.lblFindStatus.Location = new System.Drawing.Point(114, 103);
            this.lblFindStatus.Name = "lblFindStatus";
            this.lblFindStatus.Size = new System.Drawing.Size(226, 28);
            this.lblFindStatus.TabIndex = 16;
            this.lblFindStatus.Text = "Account not found!! Try again";
            this.lblFindStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFindStatus.Visible = false;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(15, 98);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(93, 38);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtAccountID
            // 
            this.txtAccountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountID.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountID.Location = new System.Drawing.Point(15, 62);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(325, 28);
            this.txtAccountID.TabIndex = 14;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(15, 70);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(325, 28);
            this.txtAmount.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(15, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(491, 38);
            this.panel4.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(489, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter Deposit Amount...";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(15, 108);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(93, 38);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // pAmount
            // 
            this.pAmount.Controls.Add(this.btnConfirm);
            this.pAmount.Controls.Add(this.txtAmount);
            this.pAmount.Controls.Add(this.panel4);
            this.pAmount.Location = new System.Drawing.Point(40, 275);
            this.pAmount.Name = "pAmount";
            this.pAmount.Size = new System.Drawing.Size(520, 158);
            this.pAmount.TabIndex = 20;
            this.pAmount.Visible = false;
            // 
            // pEnterAccountNumber
            // 
            this.pEnterAccountNumber.Controls.Add(this.lblFindStatus);
            this.pEnterAccountNumber.Controls.Add(this.btnFind);
            this.pEnterAccountNumber.Controls.Add(this.txtAccountID);
            this.pEnterAccountNumber.Controls.Add(this.panel1);
            this.pEnterAccountNumber.Location = new System.Drawing.Point(40, 134);
            this.pEnterAccountNumber.Name = "pEnterAccountNumber";
            this.pEnterAccountNumber.Size = new System.Drawing.Size(521, 141);
            this.pEnterAccountNumber.TabIndex = 21;
            // 
            // frmDepositWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 670);
            this.Controls.Add(this.pEnterAccountNumber);
            this.Controls.Add(this.pAmount);
            this.Controls.Add(this.pCurrentAccountInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDepositWithdraw";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDepositWithdraw";
            this.pTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenIcon)).EndInit();
            this.pCurrentAccountInfo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pAmount.ResumeLayout(false);
            this.pAmount.PerformLayout();
            this.pEnterAccountNumber.ResumeLayout(false);
            this.pEnterAccountNumber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.PictureBox pbScreenIcon;
        private System.Windows.Forms.Label lblScreenName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pCurrentAccountInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblAccountOwner;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFindStatus;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pAmount;
        private System.Windows.Forms.Panel pEnterAccountNumber;
    }
}