namespace myBank
{
    partial class AddCustomerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContactDetails = new System.Windows.Forms.TextBox();
            this.btnCancelConfirmCustomer = new System.Windows.Forms.Button();
            this.btnConfirmAddCustomer = new System.Windows.Forms.Button();
            this.checkBoxIsStaff = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "CustomerID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact Details:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "IsStaff:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(159, 13);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtContactDetails
            // 
            this.txtContactDetails.Location = new System.Drawing.Point(159, 59);
            this.txtContactDetails.Name = "txtContactDetails";
            this.txtContactDetails.Size = new System.Drawing.Size(205, 20);
            this.txtContactDetails.TabIndex = 7;
            // 
            // btnCancelConfirmCustomer
            // 
            this.btnCancelConfirmCustomer.BackColor = System.Drawing.Color.Red;
            this.btnCancelConfirmCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelConfirmCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelConfirmCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCancelConfirmCustomer.Location = new System.Drawing.Point(186, 120);
            this.btnCancelConfirmCustomer.Name = "btnCancelConfirmCustomer";
            this.btnCancelConfirmCustomer.Size = new System.Drawing.Size(122, 31);
            this.btnCancelConfirmCustomer.TabIndex = 10;
            this.btnCancelConfirmCustomer.Text = "Cancel";
            this.btnCancelConfirmCustomer.UseVisualStyleBackColor = false;
            this.btnCancelConfirmCustomer.Click += new System.EventHandler(this.btnCancelConfirmCustomer_Click);
            // 
            // btnConfirmAddCustomer
            // 
            this.btnConfirmAddCustomer.BackColor = System.Drawing.Color.Blue;
            this.btnConfirmAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnConfirmAddCustomer.Location = new System.Drawing.Point(48, 120);
            this.btnConfirmAddCustomer.Name = "btnConfirmAddCustomer";
            this.btnConfirmAddCustomer.Size = new System.Drawing.Size(132, 31);
            this.btnConfirmAddCustomer.TabIndex = 9;
            this.btnConfirmAddCustomer.Text = "Confirm";
            this.btnConfirmAddCustomer.UseVisualStyleBackColor = false;
            this.btnConfirmAddCustomer.Click += new System.EventHandler(this.btnConfirmAddCustomer_Click);
            // 
            // checkBoxIsStaff
            // 
            this.checkBoxIsStaff.AutoSize = true;
            this.checkBoxIsStaff.Location = new System.Drawing.Point(159, 85);
            this.checkBoxIsStaff.Name = "checkBoxIsStaff";
            this.checkBoxIsStaff.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsStaff.TabIndex = 11;
            this.checkBoxIsStaff.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 253);
            this.Controls.Add(this.checkBoxIsStaff);
            this.Controls.Add(this.btnCancelConfirmCustomer);
            this.Controls.Add(this.btnConfirmAddCustomer);
            this.Controls.Add(this.txtContactDetails);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContactDetails;
        private System.Windows.Forms.Button btnCancelConfirmCustomer;
        private System.Windows.Forms.Button btnConfirmAddCustomer;
        private System.Windows.Forms.CheckBox checkBoxIsStaff;
    }
}