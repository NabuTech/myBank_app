namespace myBank
{
    partial class DeleteCustomerForm
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
            this.btnCancelDeleteCustomer = new System.Windows.Forms.Button();
            this.btnConfirmDeleteCustomer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelDeleteCustomer
            // 
            this.btnCancelDeleteCustomer.BackColor = System.Drawing.Color.Red;
            this.btnCancelDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCancelDeleteCustomer.Location = new System.Drawing.Point(219, 103);
            this.btnCancelDeleteCustomer.Name = "btnCancelDeleteCustomer";
            this.btnCancelDeleteCustomer.Size = new System.Drawing.Size(122, 31);
            this.btnCancelDeleteCustomer.TabIndex = 23;
            this.btnCancelDeleteCustomer.Text = "Cancel";
            this.btnCancelDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // btnConfirmDeleteCustomer
            // 
            this.btnConfirmDeleteCustomer.BackColor = System.Drawing.Color.Blue;
            this.btnConfirmDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnConfirmDeleteCustomer.Location = new System.Drawing.Point(81, 103);
            this.btnConfirmDeleteCustomer.Name = "btnConfirmDeleteCustomer";
            this.btnConfirmDeleteCustomer.Size = new System.Drawing.Size(132, 31);
            this.btnConfirmDeleteCustomer.TabIndex = 22;
            this.btnConfirmDeleteCustomer.Text = "Confirm";
            this.btnConfirmDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnConfirmDeleteCustomer.Click += new System.EventHandler(this.btnConfirmDeleteCustomer_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Are you sure you want to delete the customer?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 253);
            this.Controls.Add(this.btnCancelDeleteCustomer);
            this.Controls.Add(this.btnConfirmDeleteCustomer);
            this.Controls.Add(this.label3);
            this.Name = "DeleteCustomerForm";
            this.Text = "DeleteCustomerForm";
            this.Load += new System.EventHandler(this.DeleteCustomerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelDeleteCustomer;
        private System.Windows.Forms.Button btnConfirmDeleteCustomer;
        private System.Windows.Forms.Label label3;
    }
}