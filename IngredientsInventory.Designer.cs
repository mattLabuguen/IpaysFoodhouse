namespace IpaysFoodhouse
{
    partial class IngredientsInventory
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
            this.lv_IngredientsInventory = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Before = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Used = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ending = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddNewProd = new System.Windows.Forms.Button();
            this.lbl_CurrentDate = new System.Windows.Forms.Label();
            this.btn_PreviousDay = new System.Windows.Forms.Button();
            this.btn_NextDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_SearchBar
            // 
            this.txt_SearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SearchBar.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_SearchBar.Location = new System.Drawing.Point(101, 73);
            this.txt_SearchBar.Multiline = true;
            this.txt_SearchBar.Name = "txt_SearchBar";
            this.txt_SearchBar.Size = new System.Drawing.Size(207, 26);
            this.txt_SearchBar.TabIndex = 6;
            this.txt_SearchBar.TextChanged += new System.EventHandler(this.txt_SearchBar_TextChanged);
            // 
            // lbl_PageTitle
            // 
            this.lbl_PageTitle.AutoSize = true;
            this.lbl_PageTitle.Font = new System.Drawing.Font("Roboto Black", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PageTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_PageTitle.Location = new System.Drawing.Point(3, 14);
            this.lbl_PageTitle.Name = "lbl_PageTitle";
            this.lbl_PageTitle.Size = new System.Drawing.Size(397, 47);
            this.lbl_PageTitle.TabIndex = 4;
            this.lbl_PageTitle.Text = "Ingredients Inventory";
            // 
            // lv_IngredientsInventory
            // 
            this.lv_IngredientsInventory.BackColor = System.Drawing.Color.White;
            this.lv_IngredientsInventory.CheckBoxes = true;
            this.lv_IngredientsInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ItemName,
            this.Unit,
            this.Before,
            this.Used,
            this.Ending,
            this.Category});
            this.lv_IngredientsInventory.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_IngredientsInventory.GridLines = true;
            this.lv_IngredientsInventory.HideSelection = false;
            this.lv_IngredientsInventory.Location = new System.Drawing.Point(11, 115);
            this.lv_IngredientsInventory.Name = "lv_IngredientsInventory";
            this.lv_IngredientsInventory.Scrollable = false;
            this.lv_IngredientsInventory.Size = new System.Drawing.Size(816, 317);
            this.lv_IngredientsInventory.TabIndex = 13;
            this.lv_IngredientsInventory.UseCompatibleStateImageBehavior = false;
            this.lv_IngredientsInventory.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 51;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 180;
            // 
            // Unit
            // 
            this.Unit.Text = "Unit";
            this.Unit.Width = 119;
            // 
            // Before
            // 
            this.Before.Text = "Before";
            this.Before.Width = 100;
            // 
            // Used
            // 
            this.Used.Text = "Used";
            this.Used.Width = 100;
            // 
            // Ending
            // 
            this.Ending.Text = "Ending";
            this.Ending.Width = 100;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search Name:";
            // 
            // btn_AddNewProd
            // 
            this.btn_AddNewProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.btn_AddNewProd.FlatAppearance.BorderSize = 0;
            this.btn_AddNewProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewProd.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewProd.ForeColor = System.Drawing.Color.White;
            this.btn_AddNewProd.Location = new System.Drawing.Point(670, 447);
            this.btn_AddNewProd.Name = "btn_AddNewProd";
            this.btn_AddNewProd.Size = new System.Drawing.Size(157, 26);
            this.btn_AddNewProd.TabIndex = 16;
            this.btn_AddNewProd.Text = "Stock-In Thru Invoice";
            this.btn_AddNewProd.UseVisualStyleBackColor = false;
            this.btn_AddNewProd.Click += new System.EventHandler(this.btn_AddNewProd_Click);
            // 
            // lbl_CurrentDate
            // 
            this.lbl_CurrentDate.AutoSize = true;
            this.lbl_CurrentDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_CurrentDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentDate.Location = new System.Drawing.Point(450, 74);
            this.lbl_CurrentDate.Name = "lbl_CurrentDate";
            this.lbl_CurrentDate.Size = new System.Drawing.Size(93, 19);
            this.lbl_CurrentDate.TabIndex = 17;
            this.lbl_CurrentDate.Text = "01/01/2001";
            // 
            // btn_PreviousDay
            // 
            this.btn_PreviousDay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_PreviousDay.FlatAppearance.BorderSize = 0;
            this.btn_PreviousDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PreviousDay.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PreviousDay.Location = new System.Drawing.Point(396, 73);
            this.btn_PreviousDay.Name = "btn_PreviousDay";
            this.btn_PreviousDay.Size = new System.Drawing.Size(36, 26);
            this.btn_PreviousDay.TabIndex = 18;
            this.btn_PreviousDay.Text = "<";
            this.btn_PreviousDay.UseVisualStyleBackColor = false;
            this.btn_PreviousDay.Click += new System.EventHandler(this.btn_PreviousDay_Click);
            // 
            // btn_NextDay
            // 
            this.btn_NextDay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_NextDay.FlatAppearance.BorderSize = 0;
            this.btn_NextDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextDay.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextDay.Location = new System.Drawing.Point(561, 73);
            this.btn_NextDay.Name = "btn_NextDay";
            this.btn_NextDay.Size = new System.Drawing.Size(36, 26);
            this.btn_NextDay.TabIndex = 19;
            this.btn_NextDay.Text = ">";
            this.btn_NextDay.UseVisualStyleBackColor = false;
            this.btn_NextDay.Click += new System.EventHandler(this.btn_NextDay_Click);
            // 
            // IngredientsInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btn_NextDay);
            this.Controls.Add(this.btn_PreviousDay);
            this.Controls.Add(this.lbl_CurrentDate);
            this.Controls.Add(this.btn_AddNewProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_IngredientsInventory);
            this.Controls.Add(this.txt_SearchBar);
            this.Controls.Add(this.lbl_PageTitle);
            this.Name = "IngredientsInventory";
            this.Size = new System.Drawing.Size(842, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SearchBar;
        private System.Windows.Forms.Label lbl_PageTitle;
        private System.Windows.Forms.ListView lv_IngredientsInventory;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Unit;
        private System.Windows.Forms.ColumnHeader Before;
        private System.Windows.Forms.ColumnHeader Used;
        private System.Windows.Forms.ColumnHeader Ending;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddNewProd;
        private System.Windows.Forms.Label lbl_CurrentDate;
        private System.Windows.Forms.Button btn_PreviousDay;
        private System.Windows.Forms.Button btn_NextDay;
    }
}
