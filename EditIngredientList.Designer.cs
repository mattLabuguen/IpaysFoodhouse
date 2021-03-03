namespace IpaysFoodhouse
{
    partial class EditIngredientList
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
            this.lv_IngredientList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IngredientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_IngredientList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_MenuItemName = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_IngredientName = new System.Windows.Forms.TextBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.cb_Unit = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Quantity = new System.Windows.Forms.NumericUpDown();
            this.btn_AddIngredient = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_RemoveUnit = new System.Windows.Forms.Button();
            this.btn_AddUnit = new System.Windows.Forms.Button();
            this.btn_RemoveCategory = new System.Windows.Forms.Button();
            this.btn_AddCategory = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_IngredientList
            // 
            this.lv_IngredientList.BackColor = System.Drawing.Color.White;
            this.lv_IngredientList.CheckBoxes = true;
            this.lv_IngredientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.IngredientName,
            this.Unit,
            this.Category,
            this.Quantity});
            this.lv_IngredientList.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_IngredientList.FullRowSelect = true;
            this.lv_IngredientList.GridLines = true;
            this.lv_IngredientList.HideSelection = false;
            this.lv_IngredientList.Location = new System.Drawing.Point(12, 111);
            this.lv_IngredientList.MultiSelect = false;
            this.lv_IngredientList.Name = "lv_IngredientList";
            this.lv_IngredientList.Scrollable = false;
            this.lv_IngredientList.Size = new System.Drawing.Size(579, 316);
            this.lv_IngredientList.TabIndex = 13;
            this.lv_IngredientList.UseCompatibleStateImageBehavior = false;
            this.lv_IngredientList.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 51;
            // 
            // IngredientName
            // 
            this.IngredientName.Text = "Ingredient Name";
            this.IngredientName.Width = 200;
            // 
            // Unit
            // 
            this.Unit.Text = "Unit";
            this.Unit.Width = 100;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 100;
            // 
            // lbl_IngredientList
            // 
            this.lbl_IngredientList.AutoSize = true;
            this.lbl_IngredientList.Font = new System.Drawing.Font("Roboto Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IngredientList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.lbl_IngredientList.Location = new System.Drawing.Point(4, 9);
            this.lbl_IngredientList.Name = "lbl_IngredientList";
            this.lbl_IngredientList.Size = new System.Drawing.Size(263, 44);
            this.lbl_IngredientList.TabIndex = 14;
            this.lbl_IngredientList.Text = "Ingredient List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbl_IngredientList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 60);
            this.panel1.TabIndex = 15;
            // 
            // lbl_MenuItemName
            // 
            this.lbl_MenuItemName.AutoSize = true;
            this.lbl_MenuItemName.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MenuItemName.Location = new System.Drawing.Point(12, 74);
            this.lbl_MenuItemName.Name = "lbl_MenuItemName";
            this.lbl_MenuItemName.Size = new System.Drawing.Size(156, 23);
            this.lbl_MenuItemName.TabIndex = 16;
            this.lbl_MenuItemName.Text = "Menu Item Name";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(598, 112);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(104, 15);
            this.lbl_Name.TabIndex = 17;
            this.lbl_Name.Text = "Ingredient Name:";
            // 
            // tb_IngredientName
            // 
            this.tb_IngredientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_IngredientName.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IngredientName.Location = new System.Drawing.Point(708, 111);
            this.tb_IngredientName.Name = "tb_IngredientName";
            this.tb_IngredientName.Size = new System.Drawing.Size(216, 22);
            this.tb_IngredientName.TabIndex = 18;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(670, 153);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(32, 15);
            this.lbl_Unit.TabIndex = 19;
            this.lbl_Unit.Text = "Unit:";
            // 
            // cb_Unit
            // 
            this.cb_Unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Unit.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Unit.FormattingEnabled = true;
            this.cb_Unit.Location = new System.Drawing.Point(708, 151);
            this.cb_Unit.Name = "cb_Unit";
            this.cb_Unit.Size = new System.Drawing.Size(216, 22);
            this.cb_Unit.TabIndex = 21;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(642, 217);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(60, 15);
            this.lbl_Category.TabIndex = 22;
            this.lbl_Category.Text = "Category:";
            // 
            // cb_Category
            // 
            this.cb_Category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Category.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(708, 215);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(216, 22);
            this.cb_Category.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quantity:";
            // 
            // num_Quantity
            // 
            this.num_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Quantity.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Quantity.Location = new System.Drawing.Point(708, 281);
            this.num_Quantity.Name = "num_Quantity";
            this.num_Quantity.Size = new System.Drawing.Size(216, 22);
            this.num_Quantity.TabIndex = 25;
            // 
            // btn_AddIngredient
            // 
            this.btn_AddIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.btn_AddIngredient.FlatAppearance.BorderSize = 0;
            this.btn_AddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddIngredient.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddIngredient.ForeColor = System.Drawing.Color.White;
            this.btn_AddIngredient.Location = new System.Drawing.Point(708, 318);
            this.btn_AddIngredient.Name = "btn_AddIngredient";
            this.btn_AddIngredient.Size = new System.Drawing.Size(100, 36);
            this.btn_AddIngredient.TabIndex = 26;
            this.btn_AddIngredient.Text = "Add Ingredient";
            this.btn_AddIngredient.UseVisualStyleBackColor = false;
            this.btn_AddIngredient.Click += new System.EventHandler(this.btn_AddIngredient_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(708, 402);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 25);
            this.btn_Clear.TabIndex = 27;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(824, 402);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 25);
            this.btn_Cancel.TabIndex = 28;
            this.btn_Cancel.Text = "Exit";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_RemoveUnit
            // 
            this.btn_RemoveUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.btn_RemoveUnit.FlatAppearance.BorderSize = 0;
            this.btn_RemoveUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveUnit.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveUnit.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveUnit.Location = new System.Drawing.Point(744, 179);
            this.btn_RemoveUnit.Name = "btn_RemoveUnit";
            this.btn_RemoveUnit.Size = new System.Drawing.Size(30, 23);
            this.btn_RemoveUnit.TabIndex = 30;
            this.btn_RemoveUnit.Text = "-";
            this.btn_RemoveUnit.UseVisualStyleBackColor = false;
            this.btn_RemoveUnit.Click += new System.EventHandler(this.btn_RemoveUnit_Click);
            // 
            // btn_AddUnit
            // 
            this.btn_AddUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.btn_AddUnit.FlatAppearance.BorderSize = 0;
            this.btn_AddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddUnit.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUnit.ForeColor = System.Drawing.Color.White;
            this.btn_AddUnit.Location = new System.Drawing.Point(708, 179);
            this.btn_AddUnit.Name = "btn_AddUnit";
            this.btn_AddUnit.Size = new System.Drawing.Size(30, 23);
            this.btn_AddUnit.TabIndex = 29;
            this.btn_AddUnit.Text = "+";
            this.btn_AddUnit.UseVisualStyleBackColor = false;
            this.btn_AddUnit.Click += new System.EventHandler(this.btn_AddUnit_Click);
            // 
            // btn_RemoveCategory
            // 
            this.btn_RemoveCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.btn_RemoveCategory.FlatAppearance.BorderSize = 0;
            this.btn_RemoveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveCategory.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveCategory.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveCategory.Location = new System.Drawing.Point(744, 243);
            this.btn_RemoveCategory.Name = "btn_RemoveCategory";
            this.btn_RemoveCategory.Size = new System.Drawing.Size(30, 23);
            this.btn_RemoveCategory.TabIndex = 32;
            this.btn_RemoveCategory.Text = "-";
            this.btn_RemoveCategory.UseVisualStyleBackColor = false;
            this.btn_RemoveCategory.Click += new System.EventHandler(this.btn_RemoveCategory_Click);
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.btn_AddCategory.FlatAppearance.BorderSize = 0;
            this.btn_AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCategory.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCategory.ForeColor = System.Drawing.Color.White;
            this.btn_AddCategory.Location = new System.Drawing.Point(708, 243);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(30, 23);
            this.btn_AddCategory.TabIndex = 31;
            this.btn_AddCategory.Text = "+";
            this.btn_AddCategory.UseVisualStyleBackColor = false;
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.btn_Remove.FlatAppearance.BorderSize = 0;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.White;
            this.btn_Remove.Location = new System.Drawing.Point(824, 318);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(100, 36);
            this.btn_Remove.TabIndex = 33;
            this.btn_Remove.Text = "Remove Ingredient";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // EditIngredientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 439);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_RemoveCategory);
            this.Controls.Add(this.btn_AddCategory);
            this.Controls.Add(this.btn_RemoveUnit);
            this.Controls.Add(this.btn_AddUnit);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_AddIngredient);
            this.Controls.Add(this.num_Quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.cb_Unit);
            this.Controls.Add(this.lbl_Unit);
            this.Controls.Add(this.tb_IngredientName);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_MenuItemName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lv_IngredientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditIngredientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingredient List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_IngredientList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader IngredientName;
        private System.Windows.Forms.ColumnHeader Unit;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Label lbl_IngredientList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_MenuItemName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_IngredientName;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.ComboBox cb_Unit;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_Quantity;
        private System.Windows.Forms.Button btn_AddIngredient;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_RemoveUnit;
        private System.Windows.Forms.Button btn_AddUnit;
        private System.Windows.Forms.Button btn_RemoveCategory;
        private System.Windows.Forms.Button btn_AddCategory;
        private System.Windows.Forms.Button btn_Remove;
    }
}