﻿namespace Northwind.WinUI.Forms.FormCategories
{
    partial class FormAddCategory
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
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.grpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(207, 158);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(130, 42);
            this.btnAddCategory.TabIndex = 19;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(115, 44);
            this.txtCategoryDescription.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtCategoryDescription.MaxLength = 300;
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(164, 68);
            this.txtCategoryDescription.TabIndex = 18;
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.Location = new System.Drawing.Point(13, 48);
            this.lblCategoryDescription.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(60, 13);
            this.lblCategoryDescription.TabIndex = 17;
            this.lblCategoryDescription.Text = "Description";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(115, 18);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtCategoryName.MaxLength = 15;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(164, 20);
            this.txtCategoryName.TabIndex = 16;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(13, 21);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(80, 13);
            this.lblCategoryName.TabIndex = 15;
            this.lblCategoryName.Text = "Category Name";
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.txtCategoryName);
            this.grpControls.Controls.Add(this.txtCategoryDescription);
            this.grpControls.Controls.Add(this.lblCategoryDescription);
            this.grpControls.Controls.Add(this.lblCategoryName);
            this.grpControls.Location = new System.Drawing.Point(12, 12);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(325, 139);
            this.grpControls.TabIndex = 20;
            this.grpControls.TabStop = false;
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 211);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.btnAddCategory);
            this.Name = "FormAddCategory";
            this.Text = "Form Add Category";
            this.Load += new System.EventHandler(this.FormAddCategory_Load);
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.GroupBox grpControls;
    }
}