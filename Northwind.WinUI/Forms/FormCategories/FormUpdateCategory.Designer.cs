namespace Northwind.WinUI.Forms.FormCategories
{
    partial class FormUpdateCategory
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
            this.cmbCategoryList = new System.Windows.Forms.ComboBox();
            this.btnShowCategoryDetails = new System.Windows.Forms.Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryDesc = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCategoryList
            // 
            this.cmbCategoryList.FormattingEnabled = true;
            this.cmbCategoryList.Location = new System.Drawing.Point(33, 40);
            this.cmbCategoryList.Name = "cmbCategoryList";
            this.cmbCategoryList.Size = new System.Drawing.Size(222, 21);
            this.cmbCategoryList.TabIndex = 0;
            // 
            // btnShowCategoryDetails
            // 
            this.btnShowCategoryDetails.Location = new System.Drawing.Point(301, 38);
            this.btnShowCategoryDetails.Name = "btnShowCategoryDetails";
            this.btnShowCategoryDetails.Size = new System.Drawing.Size(132, 23);
            this.btnShowCategoryDetails.TabIndex = 1;
            this.btnShowCategoryDetails.Text = "Show Category Details";
            this.btnShowCategoryDetails.UseVisualStyleBackColor = true;
            this.btnShowCategoryDetails.Click += new System.EventHandler(this.btnShowCategoryDetails_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(33, 129);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(80, 13);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "Category Name";
            // 
            // lblCategoryDesc
            // 
            this.lblCategoryDesc.AutoSize = true;
            this.lblCategoryDesc.Location = new System.Drawing.Point(33, 156);
            this.lblCategoryDesc.Name = "lblCategoryDesc";
            this.lblCategoryDesc.Size = new System.Drawing.Size(105, 13);
            this.lblCategoryDesc.TabIndex = 2;
            this.lblCategoryDesc.Text = "Category Description";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(212, 126);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(199, 20);
            this.txtCategoryName.TabIndex = 3;
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(212, 153);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(199, 73);
            this.txtCategoryDescription.TabIndex = 3;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(468, 144);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(138, 70);
            this.btnUpdateCategory.TabIndex = 4;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // FormUpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 238);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lblCategoryDesc);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.btnShowCategoryDetails);
            this.Controls.Add(this.cmbCategoryList);
            this.Name = "FormUpdateCategory";
            this.Text = "FormUpdateCategory";
            this.Load += new System.EventHandler(this.FormUpdateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoryList;
        private System.Windows.Forms.Button btnShowCategoryDetails;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryDesc;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Button btnUpdateCategory;
    }
}