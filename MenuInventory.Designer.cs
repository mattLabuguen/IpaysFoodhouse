namespace IpaysFoodhouse
{
    partial class MenuInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_SearchBar = new System.Windows.Forms.TextBox();
            this.lbl_PageTitle = new System.Windows.Forms.Label();
            this.btn_AddNewProd = new System.Windows.Forms.Button();
            this.btn_RemoveProd = new System.Windows.Forms.Button();
            this.lv_MenuInventory = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_IngredientList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_SearchBar
            // 
            this.txt_SearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SearchBar.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_SearchBar.Location = new System.Drawing.Point(101, 74);
            this.txt_SearchBar.Multiline = true;
            this.txt_SearchBar.Name = "txt_SearchBar";
            this.txt_SearchBar.Size = new System.Drawing.Size(273, 26);
            this.txt_SearchBar.TabIndex = 9;
            this.txt_SearchBar.TextChanged += new System.EventHandler(this.txt_SearchBar_TextChanged);
            // 
            // lbl_PageTitle
            // 
            this.lbl_PageTitle.AutoSize = true;
            this.lbl_PageTitle.Font = new System.Drawing.Font("Roboto Black", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PageTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_PageTitle.Location = new System.Drawing.Point(3, 14);
            this.lbl_PageTitle.Name = "lbl_PageTitle";
            this.lbl_PageTitle.Size = new System.Drawing.Size(295, 47);
            this.lbl_PageTitle.TabIndex = 7;
            this.lbl_PageTitle.Text = "Menu Inventory";
            // 
            // btn_AddNewProd
            // 
            this.btn_AddNewProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btn_AddNewProd.FlatAppearance.BorderSize = 0;
            this.btn_AddNewProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewProd.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewProd.ForeColor = System.Drawing.Color.White;
            this.btn_AddNewProd.Location = new System.Drawing.Point(532, 74);
            this.btn_AddNewProd.Name = "btn_AddNewProd";
            this.btn_AddNewProd.Size = new System.Drawing.Size(131, 26);
            this.btn_AddNewProd.TabIndex = 10;
            this.btn_AddNewProd.Text = "Add New Product";
            this.btn_AddNewProd.UseVisualStyleBackColor = false;
            this.btn_AddNewProd.Click += new System.EventHandler(this.btn_AddNewProd_Click);
            // 
            // btn_RemoveProd
            // 
            this.btn_RemoveProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.btn_RemoveProd.FlatAppearance.BorderSize = 0;
            this.btn_RemoveProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveProd.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveProd.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveProd.Location = new System.Drawing.Point(669, 74);
            this.btn_RemoveProd.Name = "btn_RemoveProd";
            this.btn_RemoveProd.Size = new System.Drawing.Size(131, 26);
            this.btn_RemoveProd.TabIndex = 11;
            this.btn_RemoveProd.Text = "Remove Product";
            this.btn_RemoveProd.UseVisualStyleBackColor = false;
            this.btn_RemoveProd.Click += new System.EventHandler(this.btn_RemoveProd_Click);
            // 
            // lv_MenuInventory
            // 
            this.lv_MenuInventory.BackColor = System.Drawing.Color.White;
            this.lv_MenuInventory.CheckBoxes = true;
            this.lv_MenuInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Image,
            this.Category,
            this.ProductName,
            this.Price,
            this.Status});
            this.lv_MenuInventory.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_MenuInventory.FullRowSelect = true;
            this.lv_MenuInventory.GridLines = true;
            this.lv_MenuInventory.HideSelection = false;
            this.lv_MenuInventory.Location = new System.Drawing.Point(11, 115);
            this.lv_MenuInventory.MultiSelect = false;
            this.lv_MenuInventory.Name = "lv_MenuInventory";
            this.lv_MenuInventory.Scrollable = false;
            this.lv_MenuInventory.Size = new System.Drawing.Size(789, 338);
            this.lv_MenuInventory.TabIndex = 12;
            this.lv_MenuInventory.UseCompatibleStateImageBehavior = false;
            this.lv_MenuInventory.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 51;
            // 
            // Image
            // 
            this.Image.Text = "Image";
            this.Image.Width = 122;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 119;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 186;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 149;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 159;
            // 
            // btn_IngredientList
            // 
            this.btn_IngredientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(193)))));
            this.btn_IngredientList.FlatAppearance.BorderSize = 0;
            this.btn_IngredientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IngredientList.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IngredientList.ForeColor = System.Drawing.Color.White;
            this.btn_IngredientList.Location = new System.Drawing.Point(395, 74);
            this.btn_IngredientList.Name = "btn_IngredientList";
            this.btn_IngredientList.Size = new System.Drawing.Size(131, 26);
            this.btn_IngredientList.TabIndex = 13;
            this.btn_IngredientList.Text = "Edit Ingredient List";
            this.btn_IngredientList.UseVisualStyleBackColor = false;
            this.btn_IngredientList.Click += new System.EventHandler(this.btn_IngredientList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search Name:";
            // 
            // MenuInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_IngredientList);
            this.Controls.Add(this.lv_MenuInventory);
            this.Controls.Add(this.btn_RemoveProd);
            this.Controls.Add(this.btn_AddNewProd);
            this.Controls.Add(this.txt_SearchBar);
            this.Controls.Add(this.lbl_PageTitle);
            this.Name = "MenuInventory";
            this.Size = new System.Drawing.Size(842, 485);
            this.Load += new System.EventHandler(this.MenuInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SearchBar;
        private System.Windows.Forms.Label lbl_PageTitle;
        private System.Windows.Forms.Button btn_AddNewProd;
        private System.Windows.Forms.Button btn_RemoveProd;
        private System.Windows.Forms.ListView lv_MenuInventory;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Image;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button btn_IngredientList;
        private System.Windows.Forms.Label label1;
    }
}
