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
            this.lblCategoryDesc = new System.Windows.Forms.Label();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.grpCategoryUpdateOrDelete = new System.Windows.Forms.GroupBox();
            this.grpCategoryUpdateOrDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategoryList
            // 
            this.cmbCategoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryList.FormattingEnabled = true;
            this.cmbCategoryList.Location = new System.Drawing.Point(15, 19);
            this.cmbCategoryList.Name = "cmbCategoryList";
            this.cmbCategoryList.Size = new System.Drawing.Size(378, 21);
            this.cmbCategoryList.TabIndex = 0;
            this.cmbCategoryList.SelectionChangeCommitted += new System.EventHandler(this.cmbCategoryList_SelectionChangeCommitted);
            // 
            // lblCategoryDesc
            // 
            this.lblCategoryDesc.AutoSize = true;
            this.lblCategoryDesc.Location = new System.Drawing.Point(15, 104);
            this.lblCategoryDesc.Name = "lblCategoryDesc";
            this.lblCategoryDesc.Size = new System.Drawing.Size(105, 13);
            this.lblCategoryDesc.TabIndex = 2;
            this.lblCategoryDesc.Text = "Category Description";
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(141, 101);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(199, 73);
            this.txtCategoryDescription.TabIndex = 3;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(377, 73);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(140, 44);
            this.btnUpdateCategory.TabIndex = 4;
            this.btnUpdateCategory.Text = "Update Selected Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(377, 127);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(140, 44);
            this.btnDeleteCategory.TabIndex = 4;
            this.btnDeleteCategory.Text = "Delete Selected Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // grpCategoryUpdateOrDelete
            // 
            this.grpCategoryUpdateOrDelete.Controls.Add(this.cmbCategoryList);
            this.grpCategoryUpdateOrDelete.Controls.Add(this.btnDeleteCategory);
            this.grpCategoryUpdateOrDelete.Controls.Add(this.btnUpdateCategory);
            this.grpCategoryUpdateOrDelete.Controls.Add(this.lblCategoryDesc);
            this.grpCategoryUpdateOrDelete.Controls.Add(this.txtCategoryDescription);
            this.grpCategoryUpdateOrDelete.Location = new System.Drawing.Point(12, 12);
            this.grpCategoryUpdateOrDelete.Name = "grpCategoryUpdateOrDelete";
            this.grpCategoryUpdateOrDelete.Size = new System.Drawing.Size(542, 217);
            this.grpCategoryUpdateOrDelete.TabIndex = 5;
            this.grpCategoryUpdateOrDelete.TabStop = false;
            // 
            // FormUpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 248);
            this.Controls.Add(this.grpCategoryUpdateOrDelete);
            this.Name = "FormUpdateCategory";
            this.Text = "FormUpdateCategory";
            this.Load += new System.EventHandler(this.FormUpdateCategory_Load);
            this.grpCategoryUpdateOrDelete.ResumeLayout(false);
            this.grpCategoryUpdateOrDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoryList;
        private System.Windows.Forms.Label lblCategoryDesc;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.GroupBox grpCategoryUpdateOrDelete;
    }
}