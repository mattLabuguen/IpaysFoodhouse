namespace IpaysFoodhouse
{
    partial class AddNewProduct
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
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.btn_FileDialog = new System.Windows.Forms.Button();
            this.tb_ImageDirectory = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_ActualID = new System.Windows.Forms.Label();
            this.lb_Category = new System.Windows.Forms.ListBox();
            this.btn_AddCategory = new System.Windows.Forms.Button();
            this.btn_RemoveCategory = new System.Windows.Forms.Button();
            this.lbl_ProdName = new System.Windows.Forms.Label();
            this.tb_ProdName = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_AddNewProduct = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(14, 70);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(33, 19);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "ID: ";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.Location = new System.Drawing.Point(12, 111);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(64, 19);
            this.lbl_Image.TabIndex = 1;
            this.lbl_Image.Text = "Image: ";
            // 
            // btn_FileDialog
            // 
            this.btn_FileDialog.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FileDialog.Location = new System.Drawing.Point(512, 111);
            this.btn_FileDialog.Name = "btn_FileDialog";
            this.btn_FileDialog.Size = new System.Drawing.Size(75, 23);
            this.btn_FileDialog.TabIndex = 2;
            this.btn_FileDialog.Text = "Browse";
            this.btn_FileDialog.UseVisualStyleBackColor = true;
            this.btn_FileDialog.Click += new System.EventHandler(this.btn_FileDialog_Click);
            // 
            // tb_ImageDirectory
            // 
            this.tb_ImageDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ImageDirectory.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ImageDirectory.Location = new System.Drawing.Point(151, 112);
            this.tb_ImageDirectory.Multiline = true;
            this.tb_ImageDirectory.Name = "tb_ImageDirectory";
            this.tb_ImageDirectory.Size = new System.Drawing.Size(355, 77);
            this.tb_ImageDirectory.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbl_AddNewProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 51);
            this.panel1.TabIndex = 4;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(14, 226);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(79, 19);
            this.lbl_Category.TabIndex = 5;
            this.lbl_Category.Text = "Category:";
            // 
            // lbl_ActualID
            // 
            this.lbl_ActualID.AutoSize = true;
            this.lbl_ActualID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ActualID.Location = new System.Drawing.Point(147, 71);
            this.lbl_ActualID.Name = "lbl_ActualID";
            this.lbl_ActualID.Size = new System.Drawing.Size(18, 19);
            this.lbl_ActualID.TabIndex = 6;
            this.lbl_ActualID.Text = "0";
            // 
            // lb_Category
            // 
            this.lb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Category.FormattingEnabled = true;
            this.lb_Category.ItemHeight = 16;
            this.lb_Category.Location = new System.Drawing.Point(151, 227);
            this.lb_Category.Name = "lb_Category";
            this.lb_Category.Size = new System.Drawing.Size(355, 68);
            this.lb_Category.TabIndex = 7;
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.btn_AddCategory.FlatAppearance.BorderSize = 0;
            this.btn_AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCategory.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCategory.ForeColor = System.Drawing.Color.White;
            this.btn_AddCategory.Location = new System.Drawing.Point(151, 302);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(75, 23);
            this.btn_AddCategory.TabIndex = 8;
            this.btn_AddCategory.Text = "+";
            this.btn_AddCategory.UseVisualStyleBackColor = false;
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // btn_RemoveCategory
            // 
            this.btn_RemoveCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.btn_RemoveCategory.FlatAppearance.BorderSize = 0;
            this.btn_RemoveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveCategory.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveCategory.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveCategory.Location = new System.Drawing.Point(232, 302);
            this.btn_RemoveCategory.Name = "btn_RemoveCategory";
            this.btn_RemoveCategory.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveCategory.TabIndex = 9;
            this.btn_RemoveCategory.Text = "-";
            this.btn_RemoveCategory.UseVisualStyleBackColor = false;
            this.btn_RemoveCategory.Click += new System.EventHandler(this.btn_RemoveCategory_Click);
            // 
            // lbl_ProdName
            // 
            this.lbl_ProdName.AutoSize = true;
            this.lbl_ProdName.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdName.Location = new System.Drawing.Point(12, 340);
            this.lbl_ProdName.Name = "lbl_ProdName";
            this.lbl_ProdName.Size = new System.Drawing.Size(117, 19);
            this.lbl_ProdName.TabIndex = 10;
            this.lbl_ProdName.Text = "Product Name:";
            // 
            // tb_ProdName
            // 
            this.tb_ProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ProdName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ProdName.Location = new System.Drawing.Point(151, 340);
            this.tb_ProdName.Name = "tb_ProdName";
            this.tb_ProdName.Size = new System.Drawing.Size(355, 23);
            this.tb_ProdName.TabIndex = 11;
            // 
            // tb_Price
            // 
            this.tb_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Price.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(151, 387);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(129, 23);
            this.tb_Price.TabIndex = 13;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(12, 387);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(51, 19);
            this.lbl_Price.TabIndex = 12;
            this.lbl_Price.Text = "Price:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(512, 458);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(431, 458);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(12, 9);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(267, 38);
            this.lbl_AddNewProduct.TabIndex = 15;
            this.lbl_AddNewProduct.Text = "Add New Product";
            // 
            // AddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 493);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.tb_ProdName);
            this.Controls.Add(this.lbl_ProdName);
            this.Controls.Add(this.btn_RemoveCategory);
            this.Controls.Add(this.btn_AddCategory);
            this.Controls.Add(this.lb_Category);
            this.Controls.Add(this.lbl_ActualID);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_ImageDirectory);
            this.Controls.Add(this.btn_FileDialog);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Product";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewProduct_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Button btn_FileDialog;
        private System.Windows.Forms.TextBox tb_ImageDirectory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_ActualID;
        private System.Windows.Forms.ListBox lb_Category;
        private System.Windows.Forms.Button btn_AddCategory;
        private System.Windows.Forms.Button btn_RemoveCategory;
        private System.Windows.Forms.Label lbl_ProdName;
        private System.Windows.Forms.TextBox tb_ProdName;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_AddNewProduct;
    }
}