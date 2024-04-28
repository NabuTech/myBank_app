namespace myBank
{
    partial class EditCustomerForm
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
            this.btnCancelEditCustomer = new System.Windows.Forms.Button();
            this.btnConfirmEditCustomer = new System.Windows.Forms.Button();
            this.txtEditContactDetails = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxIsStaff = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancelEditCustomer
            // 
            this.btnCancelEditCustomer.BackColor = System.Drawing.Color.Red;
            this.btnCancelEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCancelEditCustomer.Location = new System.Drawing.Point(186, 121);
            this.btnCancelEditCustomer.Name = "btnCancelEditCustomer";
            this.btnCancelEditCustomer.Size = new System.Drawing.Size(122, 31);
            this.btnCancelEditCustomer.TabIndex = 20;
            this.btnCancelEditCustomer.Text = "Cancel";
            this.btnCancelEditCustomer.UseVisualStyleBackColor = false;
            this.btnCancelEditCustomer.Click += new System.EventHandler(this.btnCancelEditCustomer_Click);
            // 
            // btnConfirmEditCustomer
            // 
            this.btnConfirmEditCustomer.BackColor = System.Drawing.Color.Blue;
            this.btnConfirmEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btnConfirmEditCustomer.Location = new System.Drawing.Point(48, 121);
            this.btnConfirmEditCustomer.Name = "btnConfirmEditCustomer";
            this.btnConfirmEditCustomer.Size = new System.Drawing.Size(132, 31);
            this.btnConfirmEditCustomer.TabIndex = 19;
            this.btnConfirmEditCustomer.Text = "Confirm";
            this.btnConfirmEditCustomer.UseVisualStyleBackColor = false;
            this.btnConfirmEditCustomer.Click += new System.EventHandler(this.btnConfirmEditCustomer_Click);
            // 
            // txtEditContactDetails
            // 
            this.txtEditContactDetails.Location = new System.Drawing.Point(159, 60);
            this.txtEditContactDetails.Name = "txtEditContactDetails";
            this.txtEditContactDetails.Size = new System.Drawing.Size(205, 20);
            this.txtEditContactDetails.TabIndex = 17;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(159, 37);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(205, 20);
            this.txtEditName.TabIndex = 16;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(159, 14);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "IsStaff:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contact Details:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "CustomerID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxIsStaff
            // 
            this.checkBoxIsStaff.AutoSize = true;
            this.checkBoxIsStaff.Location = new System.Drawing.Point(159, 86);
            this.checkBoxIsStaff.Name = "checkBoxIsStaff";
            this.checkBoxIsStaff.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsStaff.TabIndex = 21;
            this.checkBoxIsStaff.UseVisualStyleBackColor = true;
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 253);
            this.Controls.Add(this.checkBoxIsStaff);
            this.Controls.Add(this.btnCancelEditCustomer);
            this.Controls.Add(this.btnConfirmEditCustomer);
            this.Controls.Add(this.txtEditContactDetails);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "EditCustomerForm";
            this.Text = "EditCustomerForm";
            this.Load += new System.EventHandler(this.EditCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelEditCustomer;
        private System.Windows.Forms.Button btnConfirmEditCustomer;
        private System.Windows.Forms.TextBox txtEditContactDetails;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxIsStaff;
    }
}