namespace Northwind.WinUI.Forms.FormEmployees
{
    partial class FormDeleteEmployee
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
            this.cmbEmployeeList = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEmployeeList
            // 
            this.cmbEmployeeList.FormattingEnabled = true;
            this.cmbEmployeeList.Location = new System.Drawing.Point(30, 40);
            this.cmbEmployeeList.Name = "cmbEmployeeList";
            this.cmbEmployeeList.Size = new System.Drawing.Size(353, 21);
            this.cmbEmployeeList.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(27, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(217, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Select the employee you would like to delete";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(122, 105);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(171, 47);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // FormDeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 195);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmbEmployeeList);
            this.Name = "FormDeleteEmployee";
            this.Text = "FormDeleteEmployee";
            this.Load += new System.EventHandler(this.FormDeleteEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployeeList;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDeleteEmployee;
    }
}