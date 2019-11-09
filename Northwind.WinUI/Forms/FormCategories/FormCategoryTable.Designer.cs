namespace Northwind.WinUI.Forms.FormCategories
{
    partial class FormCategoryTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridCategories = new System.Windows.Forms.DataGridView();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.btnUpdateOrDeleteCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCategories
            // 
            this.dataGridCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategories.Location = new System.Drawing.Point(10, 102);
            this.dataGridCategories.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridCategories.Name = "dataGridCategories";
            this.dataGridCategories.RowHeadersVisible = false;
            this.dataGridCategories.RowHeadersWidth = 150;
            this.dataGridCategories.Size = new System.Drawing.Size(418, 353);
            this.dataGridCategories.TabIndex = 15;
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Location = new System.Drawing.Point(120, 21);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(141, 55);
            this.btnAddNewCategory.TabIndex = 16;
            this.btnAddNewCategory.Text = "Add New Category";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // btnUpdateOrDeleteCategory
            // 
            this.btnUpdateOrDeleteCategory.Location = new System.Drawing.Point(282, 21);
            this.btnUpdateOrDeleteCategory.Name = "btnUpdateOrDeleteCategory";
            this.btnUpdateOrDeleteCategory.Size = new System.Drawing.Size(146, 55);
            this.btnUpdateOrDeleteCategory.TabIndex = 16;
            this.btnUpdateOrDeleteCategory.Text = "Update or Delete Category";
            this.btnUpdateOrDeleteCategory.UseVisualStyleBackColor = true;
            this.btnUpdateOrDeleteCategory.Click += new System.EventHandler(this.btnUpdateOrDeleteCategory_Click);
            // 
            // FormCategoryTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 466);
            this.Controls.Add(this.btnUpdateOrDeleteCategory);
            this.Controls.Add(this.btnAddNewCategory);
            this.Controls.Add(this.dataGridCategories);
            this.Name = "FormCategoryTable";
            this.Text = "FormCategoryTable";
            this.Load += new System.EventHandler(this.FormCategoryTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCategories;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Button btnUpdateOrDeleteCategory;
    }
}