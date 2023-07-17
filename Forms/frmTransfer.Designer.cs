namespace BankManagmentSystem_WinForms.Forms
{
    partial class frmTransfer
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
            this.lblScreenName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbScreenIcon = new System.Windows.Forms.PictureBox();
            this.pEnterSenderAccountNumber = new System.Windows.Forms.Panel();
            this.lblSenderFindStatus = new System.Windows.Forms.Label();
            this.btnFindSender = new System.Windows.Forms.Button();
            this.txtSenderAccountID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pEnterReciverAccountNumber = new System.Windows.Forms.Panel();
            this.lblReciverFindStatus = new System.Windows.Forms.Label();
            this.btnFindReciver = new System.Windows.Forms.Button();
            this.txtReciverAccountID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.pTransferAmount = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pSenderBalance = new System.Windows.Forms.Panel();
            this.lblSenderAvailablebalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmountStatus = new System.Windows.Forms.Label();
            this.pTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenIcon)).BeginInit();
            this.pEnterSenderAccountNumber.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pEnterReciverAccountNumber.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pTransferAmount.SuspendLayout();
            this.pSenderBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.pTitle.Controls.Add(this.lblScreenName);
            this.pTitle.Controls.Add(this.label1);
            this.pTitle.Controls.Add(this.pbScreenIcon);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(938, 77);
            this.pTitle.TabIndex = 5;
            // 
            // lblScreenName
            // 
            this.lblScreenName.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Bold);
            this.lblScreenName.ForeColor = System.Drawing.Color.Black;
            this.lblScreenName.Location = new System.Drawing.Point(77, 17);
            this.lblScreenName.Name = "lblScreenName";
            this.lblScreenName.Size = new System.Drawing.Size(351, 29);
            this.lblScreenName.TabIndex = 0;
            this.lblScreenName.Text = "Transfer Screen";
            this.lblScreenName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Open Sans", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(77, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Send money from one account to another";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbScreenIcon
            // 
            this.pbScreenIcon.Image = global::BankManagmentSystem_WinForms.Properties.Resources.transfer;
            this.pbScreenIcon.Location = new System.Drawing.Point(24, 25);
            this.pbScreenIcon.Name = "pbScreenIcon";
            this.pbScreenIcon.Size = new System.Drawing.Size(41, 33);
            this.pbScreenIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScreenIcon.TabIndex = 4;
            this.pbScreenIcon.TabStop = false;
            // 
            // pEnterSenderAccountNumber
            // 
            this.pEnterSenderAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEnterSenderAccountNumber.Controls.Add(this.lblSenderFindStatus);
            this.pEnterSenderAccountNumber.Controls.Add(this.btnFindSender);
            this.pEnterSenderAccountNumber.Controls.Add(this.txtSenderAccountID);
            this.pEnterSenderAccountNumber.Controls.Add(this.panel1);
            this.pEnterSenderAccountNumber.Location = new System.Drawing.Point(50, 119);
            this.pEnterSenderAccountNumber.Name = "pEnterSenderAccountNumber";
            this.pEnterSenderAccountNumber.Size = new System.Drawing.Size(354, 150);
            this.pEnterSenderAccountNumber.TabIndex = 22;
            // 
            // lblSenderFindStatus
            // 
            this.lblSenderFindStatus.ForeColor = System.Drawing.Color.Red;
            this.lblSenderFindStatus.Location = new System.Drawing.Point(114, 103);
            this.lblSenderFindStatus.Name = "lblSenderFindStatus";
            this.lblSenderFindStatus.Size = new System.Drawing.Size(226, 28);
            this.lblSenderFindStatus.TabIndex = 16;
            this.lblSenderFindStatus.Text = "Account not found!! Try again";
            this.lblSenderFindStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSenderFindStatus.Visible = false;
            // 
            // btnFindSender
            // 
            this.btnFindSender.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSender.Location = new System.Drawing.Point(15, 98);
            this.btnFindSender.Name = "btnFindSender";
            this.btnFindSender.Size = new System.Drawing.Size(93, 38);
            this.btnFindSender.TabIndex = 15;
            this.btnFindSender.Text = "Find";
            this.btnFindSender.UseVisualStyleBackColor = true;
            this.btnFindSender.Click += new System.EventHandler(this.btnFindSender_Click);
            // 
            // txtSenderAccountID
            // 
            this.txtSenderAccountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenderAccountID.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderAccountID.Location = new System.Drawing.Point(15, 62);
            this.txtSenderAccountID.Name = "txtSenderAccountID";
            this.txtSenderAccountID.Size = new System.Drawing.Size(325, 28);
            this.txtSenderAccountID.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(15, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 38);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter the sender Account number...";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pEnterReciverAccountNumber
            // 
            this.pEnterReciverAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEnterReciverAccountNumber.Controls.Add(this.lblReciverFindStatus);
            this.pEnterReciverAccountNumber.Controls.Add(this.btnFindReciver);
            this.pEnterReciverAccountNumber.Controls.Add(this.txtReciverAccountID);
            this.pEnterReciverAccountNumber.Controls.Add(this.panel3);
            this.pEnterReciverAccountNumber.Location = new System.Drawing.Point(531, 119);
            this.pEnterReciverAccountNumber.Name = "pEnterReciverAccountNumber";
            this.pEnterReciverAccountNumber.Size = new System.Drawing.Size(354, 150);
            this.pEnterReciverAccountNumber.TabIndex = 23;
            this.pEnterReciverAccountNumber.Visible = false;
            // 
            // lblReciverFindStatus
            // 
            this.lblReciverFindStatus.ForeColor = System.Drawing.Color.Red;
            this.lblReciverFindStatus.Location = new System.Drawing.Point(114, 103);
            this.lblReciverFindStatus.Name = "lblReciverFindStatus";
            this.lblReciverFindStatus.Size = new System.Drawing.Size(226, 28);
            this.lblReciverFindStatus.TabIndex = 16;
            this.lblReciverFindStatus.Text = "Account not found!! Try again";
            this.lblReciverFindStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReciverFindStatus.Visible = false;
            // 
            // btnFindReciver
            // 
            this.btnFindReciver.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindReciver.Location = new System.Drawing.Point(15, 98);
            this.btnFindReciver.Name = "btnFindReciver";
            this.btnFindReciver.Size = new System.Drawing.Size(93, 38);
            this.btnFindReciver.TabIndex = 15;
            this.btnFindReciver.Text = "Find";
            this.btnFindReciver.UseVisualStyleBackColor = true;
            this.btnFindReciver.Click += new System.EventHandler(this.btnFindReciver_Click);
            // 
            // txtReciverAccountID
            // 
            this.txtReciverAccountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReciverAccountID.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReciverAccountID.Location = new System.Drawing.Point(15, 62);
            this.txtReciverAccountID.Name = "txtReciverAccountID";
            this.txtReciverAccountID.Size = new System.Drawing.Size(325, 28);
            this.txtReciverAccountID.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(15, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 38);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter the reciver Account number...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankManagmentSystem_WinForms.Properties.Resources.send_money;
            this.pictureBox1.Location = new System.Drawing.Point(427, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(231)))), ((int)(((byte)(65)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(16, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 38);
            this.panel2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "How much would you like to transfer?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(16, 109);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(127, 38);
            this.btnTransfer.TabIndex = 28;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransferAmount.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferAmount.Location = new System.Drawing.Point(16, 73);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(325, 28);
            this.txtTransferAmount.TabIndex = 27;
            // 
            // pTransferAmount
            // 
            this.pTransferAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTransferAmount.Controls.Add(this.lblAmountStatus);
            this.pTransferAmount.Controls.Add(this.btnTransfer);
            this.pTransferAmount.Controls.Add(this.txtTransferAmount);
            this.pTransferAmount.Controls.Add(this.panel2);
            this.pTransferAmount.Location = new System.Drawing.Point(50, 296);
            this.pTransferAmount.Name = "pTransferAmount";
            this.pTransferAmount.Size = new System.Drawing.Size(458, 164);
            this.pTransferAmount.TabIndex = 29;
            this.pTransferAmount.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(746, 598);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 46);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pSenderBalance
            // 
            this.pSenderBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pSenderBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSenderBalance.Controls.Add(this.lblSenderAvailablebalance);
            this.pSenderBalance.Controls.Add(this.label4);
            this.pSenderBalance.Location = new System.Drawing.Point(531, 296);
            this.pSenderBalance.Name = "pSenderBalance";
            this.pSenderBalance.Size = new System.Drawing.Size(353, 81);
            this.pSenderBalance.TabIndex = 31;
            this.pSenderBalance.Visible = false;
            // 
            // lblSenderAvailablebalance
            // 
            this.lblSenderAvailablebalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(231)))), ((int)(((byte)(65)))));
            this.lblSenderAvailablebalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderAvailablebalance.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Italic);
            this.lblSenderAvailablebalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenderAvailablebalance.Location = new System.Drawing.Point(0, 39);
            this.lblSenderAvailablebalance.Name = "lblSenderAvailablebalance";
            this.lblSenderAvailablebalance.Size = new System.Drawing.Size(351, 39);
            this.lblSenderAvailablebalance.TabIndex = 18;
            this.lblSenderAvailablebalance.Text = "Sender Available balance";
            this.lblSenderAvailablebalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(199)))), ((int)(((byte)(16)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sender Available balance";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmountStatus
            // 
            this.lblAmountStatus.ForeColor = System.Drawing.Color.Red;
            this.lblAmountStatus.Location = new System.Drawing.Point(151, 115);
            this.lblAmountStatus.Name = "lblAmountStatus";
            this.lblAmountStatus.Size = new System.Drawing.Size(226, 28);
            this.lblAmountStatus.TabIndex = 17;
            this.lblAmountStatus.Text = "Enter a valid amount (5, 10, ...)";
            this.lblAmountStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAmountStatus.Visible = false;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(938, 670);
            this.Controls.Add(this.pSenderBalance);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pTransferAmount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pEnterReciverAccountNumber);
            this.Controls.Add(this.pEnterSenderAccountNumber);
            this.Controls.Add(this.pTitle);
            this.Name = "frmTransfer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.pTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenIcon)).EndInit();
            this.pEnterSenderAccountNumber.ResumeLayout(false);
            this.pEnterSenderAccountNumber.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pEnterReciverAccountNumber.ResumeLayout(false);
            this.pEnterReciverAccountNumber.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pTransferAmount.ResumeLayout(false);
            this.pTransferAmount.PerformLayout();
            this.pSenderBalance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.PictureBox pbScreenIcon;
        private System.Windows.Forms.Label lblScreenName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pEnterSenderAccountNumber;
        private System.Windows.Forms.Label lblSenderFindStatus;
        private System.Windows.Forms.Button btnFindSender;
        private System.Windows.Forms.TextBox txtSenderAccountID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pEnterReciverAccountNumber;
        private System.Windows.Forms.Label lblReciverFindStatus;
        private System.Windows.Forms.Button btnFindReciver;
        private System.Windows.Forms.TextBox txtReciverAccountID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.Panel pTransferAmount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pSenderBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSenderAvailablebalance;
        private System.Windows.Forms.Label lblAmountStatus;
    }
}