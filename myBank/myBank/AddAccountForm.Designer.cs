namespace myBank
{
    partial class AddAccountForm
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
            this.btnConfirmAddAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioEveryday = new System.Windows.Forms.RadioButton();
            this.radioInvestment = new System.Windows.Forms.RadioButton();
            this.radioOmni = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepositBalance = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirmAddAccount
            // 
            this.btnConfirmAddAccount.BackColor = System.Drawing.Color.Blue;
            this.btnConfirmAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnConfirmAddAccount.Location = new System.Drawing.Point(76, 187);
            this.btnConfirmAddAccount.Name = "btnConfirmAddAccount";
            this.btnConfirmAddAccount.Size = new System.Drawing.Size(132, 31);
            this.btnConfirmAddAccount.TabIndex = 11;
            this.btnConfirmAddAccount.Text = "Confirm";
            this.btnConfirmAddAccount.UseVisualStyleBackColor = false;
            this.btnConfirmAddAccount.Click += new System.EventHandler(this.btnConfirmAddAccount_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Account Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioEveryday
            // 
            this.radioEveryday.AutoSize = true;
            this.radioEveryday.ForeColor = System.Drawing.Color.Blue;
            this.radioEveryday.Location = new System.Drawing.Point(96, 73);
            this.radioEveryday.Name = "radioEveryday";
            this.radioEveryday.Size = new System.Drawing.Size(112, 17);
            this.radioEveryday.TabIndex = 12;
            this.radioEveryday.TabStop = true;
            this.radioEveryday.Text = "Everyday Account";
            this.radioEveryday.UseVisualStyleBackColor = true;
            // 
            // radioInvestment
            // 
            this.radioInvestment.AutoSize = true;
            this.radioInvestment.ForeColor = System.Drawing.Color.Blue;
            this.radioInvestment.Location = new System.Drawing.Point(96, 96);
            this.radioInvestment.Name = "radioInvestment";
            this.radioInvestment.Size = new System.Drawing.Size(120, 17);
            this.radioInvestment.TabIndex = 13;
            this.radioInvestment.TabStop = true;
            this.radioInvestment.Text = "Investment Account";
            this.radioInvestment.UseVisualStyleBackColor = true;
            // 
            // radioOmni
            // 
            this.radioOmni.AutoSize = true;
            this.radioOmni.ForeColor = System.Drawing.Color.Blue;
            this.radioOmni.Location = new System.Drawing.Point(96, 119);
            this.radioOmni.Name = "radioOmni";
            this.radioOmni.Size = new System.Drawing.Size(92, 17);
            this.radioOmni.TabIndex = 14;
            this.radioOmni.TabStop = true;
            this.radioOmni.Text = "Omni Account";
            this.radioOmni.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(33, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Deposit Amount:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDepositBalance
            // 
            this.txtDepositBalance.Location = new System.Drawing.Point(160, 148);
            this.txtDepositBalance.Name = "txtDepositBalance";
            this.txtDepositBalance.Size = new System.Drawing.Size(100, 20);
            this.txtDepositBalance.TabIndex = 16;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(88, 12);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerId.TabIndex = 17;
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 227);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtDepositBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioOmni);
            this.Controls.Add(this.radioInvestment);
            this.Controls.Add(this.radioEveryday);
            this.Controls.Add(this.btnConfirmAddAccount);
            this.Controls.Add(this.label2);
            this.Name = "AddAccountForm";
            this.Text = "AddAccountForm";
            this.Load += new System.EventHandler(this.AddAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmAddAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioEveryday;
        private System.Windows.Forms.RadioButton radioInvestment;
        private System.Windows.Forms.RadioButton radioOmni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepositBalance;
        private System.Windows.Forms.TextBox txtCustomerId;
    }
}