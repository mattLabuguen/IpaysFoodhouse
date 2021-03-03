
namespace IpaysFoodhouse
{
    partial class StockInIngredients
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
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lv_StockIn = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_StockIn = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.num_Quantity = new System.Windows.Forms.NumericUpDown();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.cb_Unit = new System.Windows.Forms.ComboBox();
            this.tb_Supplier = new System.Windows.Forms.TextBox();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.btn_RemoveStock = new System.Windows.Forms.Button();
            this.btn_AddStock = new System.Windows.Forms.Button();
            this.btn_RemoveUnit = new System.Windows.Forms.Button();
            this.btn_AddUnit = new System.Windows.Forms.Button();
            this.btn_RemoveCategory = new System.Windows.Forms.Button();
            this.btn_AddCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(12, 35);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(43, 18);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date:";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(84, 35);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(220, 20);
            this.dtp_Date.TabIndex = 1;
            // 
            // lv_StockIn
            // 
            this.lv_StockIn.CheckBoxes = true;
            this.lv_StockIn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.Quantity,
            this.Unit,
            this.Supplier,
            this.Category});
            this.lv_StockIn.GridLines = true;
            this.lv_StockIn.HideSelection = false;
            this.lv_StockIn.Location = new System.Drawing.Point(16, 261);
            this.lv_StockIn.Name = "lv_StockIn";
            this.lv_StockIn.Size = new System.Drawing.Size(612, 221);
            this.lv_StockIn.TabIndex = 2;
            this.lv_StockIn.UseCompatibleStateImageBehavior = false;
            this.lv_StockIn.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 162;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 101;
            // 
            // Unit
            // 
            this.Unit.Text = "Unit";
            this.Unit.Width = 71;
            // 
            // Supplier
            // 
            this.Supplier.Text = "Supplier";
            this.Supplier.Width = 148;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 126;
            // 
            // btn_StockIn
            // 
            this.btn_StockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.btn_StockIn.FlatAppearance.BorderSize = 0;
            this.btn_StockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StockIn.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StockIn.ForeColor = System.Drawing.Color.White;
            this.btn_StockIn.Location = new System.Drawing.Point(471, 488);
            this.btn_StockIn.Name = "btn_StockIn";
            this.btn_StockIn.Size = new System.Drawing.Size(157, 26);
            this.btn_StockIn.TabIndex = 17;
            this.btn_StockIn.Text = "Stock-In Thru Invoice";
            this.btn_StockIn.UseVisualStyleBackColor = false;
            this.btn_StockIn.Click += new System.EventHandler(this.btn_StockIn_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(13, 93);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(66, 13);
            this.lbl_Name.TabIndex = 18;
            this.lbl_Name.Text = "Item Name:";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(27, 144);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(52, 13);
            this.lbl_Quantity.TabIndex = 19;
            this.lbl_Quantity.Text = "Quantity:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(85, 89);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(220, 20);
            this.tb_Name.TabIndex = 20;
            // 
            // num_Quantity
            // 
            this.num_Quantity.Location = new System.Drawing.Point(85, 141);
            this.num_Quantity.Name = "num_Quantity";
            this.num_Quantity.Size = new System.Drawing.Size(220, 20);
            this.num_Quantity.TabIndex = 21;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(49, 195);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(30, 13);
            this.lbl_Unit.TabIndex = 22;
            this.lbl_Unit.Text = "Unit:";
            // 
            // cb_Unit
            // 
            this.cb_Unit.FormattingEnabled = true;
            this.cb_Unit.Location = new System.Drawing.Point(85, 191);
            this.cb_Unit.Name = "cb_Unit";
            this.cb_Unit.Size = new System.Drawing.Size(220, 21);
            this.cb_Unit.TabIndex = 23;
            // 
            // tb_Supplier
            // 
            this.tb_Supplier.Location = new System.Drawing.Point(397, 141);
            this.tb_Supplier.Name = "tb_Supplier";
            this.tb_Supplier.Size = new System.Drawing.Size(220, 20);
            this.tb_Supplier.TabIndex = 25;
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier.Location = new System.Drawing.Point(340, 145);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(51, 13);
            this.lbl_Supplier.TabIndex = 24;
            this.lbl_Supplier.Text = "Supplier:";
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(397, 88);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(220, 21);
            this.cb_Category.TabIndex = 27;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(337, 93);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(54, 13);
            this.lbl_Category.TabIndex = 26;
            this.lbl_Category.Text = "Category:";
            // 
            // btn_RemoveStock
            // 
            this.btn_RemoveStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.btn_RemoveStock.FlatAppearance.BorderSize = 0;
            this.btn_RemoveStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveStock.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveStock.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveStock.Location = new System.Drawing.Point(521, 234);
            this.btn_RemoveStock.Name = "btn_RemoveStock";
            this.btn_RemoveStock.Size = new System.Drawing.Size(107, 21);
            this.btn_RemoveStock.TabIndex = 29;
            this.btn_RemoveStock.Text = "Remove Stock";
            this.btn_RemoveStock.UseVisualStyleBackColor = false;
            this.btn_RemoveStock.Click += new System.EventHandler(this.btn_RemoveStock_Click);
            // 
            // btn_AddStock
            // 
            this.btn_AddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.btn_AddStock.FlatAppearance.BorderSize = 0;
            this.btn_AddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStock.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddStock.ForeColor = System.Drawing.Color.White;
            this.btn_AddStock.Location = new System.Drawing.Point(408, 234);
            this.btn_AddStock.Name = "btn_AddStock";
            this.btn_AddStock.Size = new System.Drawing.Size(107, 21);
            this.btn_AddStock.TabIndex = 28;
            this.btn_AddStock.Text = "Add Stock";
            this.btn_AddStock.UseVisualStyleBackColor = false;
            this.btn_AddStock.Click += new System.EventHandler(this.btn_AddStock_Click);
            // 
            // btn_RemoveUnit
            // 
            this.btn_RemoveUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.btn_RemoveUnit.FlatAppearance.BorderSize = 0;
            this.btn_RemoveUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveUnit.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveUnit.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveUnit.Location = new System.Drawing.Point(284, 218);
            this.btn_RemoveUnit.Name = "btn_RemoveUnit";
            this.btn_RemoveUnit.Size = new System.Drawing.Size(20, 20);
            this.btn_RemoveUnit.TabIndex = 32;
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
            this.btn_AddUnit.Location = new System.Drawing.Point(258, 218);
            this.btn_AddUnit.Name = "btn_AddUnit";
            this.btn_AddUnit.Size = new System.Drawing.Size(20, 20);
            this.btn_AddUnit.TabIndex = 31;
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
            this.btn_RemoveCategory.Location = new System.Drawing.Point(597, 115);
            this.btn_RemoveCategory.Name = "btn_RemoveCategory";
            this.btn_RemoveCategory.Size = new System.Drawing.Size(20, 20);
            this.btn_RemoveCategory.TabIndex = 34;
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
            this.btn_AddCategory.Location = new System.Drawing.Point(571, 115);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(20, 20);
            this.btn_AddCategory.TabIndex = 33;
            this.btn_AddCategory.Text = "+";
            this.btn_AddCategory.UseVisualStyleBackColor = false;
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // StockInIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 536);
            this.Controls.Add(this.btn_RemoveCategory);
            this.Controls.Add(this.btn_AddCategory);
            this.Controls.Add(this.btn_RemoveUnit);
            this.Controls.Add(this.btn_AddUnit);
            this.Controls.Add(this.btn_RemoveStock);
            this.Controls.Add(this.btn_AddStock);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.tb_Supplier);
            this.Controls.Add(this.lbl_Supplier);
            this.Controls.Add(this.cb_Unit);
            this.Controls.Add(this.lbl_Unit);
            this.Controls.Add(this.num_Quantity);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_StockIn);
            this.Controls.Add(this.lv_StockIn);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_Date);
            this.Name = "StockInIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock-In";
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.ListView lv_StockIn;
        private System.Windows.Forms.Button btn_StockIn;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Unit;
        private System.Windows.Forms.ColumnHeader Supplier;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.NumericUpDown num_Quantity;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.ComboBox cb_Unit;
        private System.Windows.Forms.TextBox tb_Supplier;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Button btn_RemoveStock;
        private System.Windows.Forms.Button btn_AddStock;
        private System.Windows.Forms.Button btn_RemoveUnit;
        private System.Windows.Forms.Button btn_AddUnit;
        private System.Windows.Forms.Button btn_RemoveCategory;
        private System.Windows.Forms.Button btn_AddCategory;
    }
}