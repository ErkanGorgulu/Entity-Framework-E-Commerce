namespace Northwind.WinUI.Forms.FormCategories
{
    partial class FormDeleteCategory
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
            this.lblCategoryInfo = new System.Windows.Forms.Label();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCategoryList
            // 
            this.cmbCategoryList.FormattingEnabled = true;
            this.cmbCategoryList.Location = new System.Drawing.Point(39, 60);
            this.cmbCategoryList.Name = "cmbCategoryList";
            this.cmbCategoryList.Size = new System.Drawing.Size(234, 21);
            this.cmbCategoryList.TabIndex = 0;
            // 
            // lblCategoryInfo
            // 
            this.lblCategoryInfo.AutoSize = true;
            this.lblCategoryInfo.Location = new System.Drawing.Point(36, 35);
            this.lblCategoryInfo.Name = "lblCategoryInfo";
            this.lblCategoryInfo.Size = new System.Drawing.Size(213, 13);
            this.lblCategoryInfo.TabIndex = 1;
            this.lblCategoryInfo.Text = "Select the category you would like to delete";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(336, 35);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(132, 45);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // FormDeleteCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 127);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.lblCategoryInfo);
            this.Controls.Add(this.cmbCategoryList);
            this.Name = "FormDeleteCategory";
            this.Text = "FormDeleteCategory";
            this.Load += new System.EventHandler(this.FormDeleteCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoryList;
        private System.Windows.Forms.Label lblCategoryInfo;
        private System.Windows.Forms.Button btnDeleteCategory;
    }
}