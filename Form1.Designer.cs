namespace IpaysFoodhouse
{
    partial class mainForm
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
            this.pnl_Sidebar = new System.Windows.Forms.Panel();
            this.pnl_KOTSubmenu = new System.Windows.Forms.Panel();
            this.btn_Completed = new System.Windows.Forms.Button();
            this.btn_Pending = new System.Windows.Forms.Button();
            this.btn_KOT = new System.Windows.Forms.Button();
            this.pnl_OrdersSubmenu = new System.Windows.Forms.Panel();
            this.btn_Delivery = new System.Windows.Forms.Button();
            this.btn_DineIn = new System.Windows.Forms.Button();
            this.btn_Orders = new System.Windows.Forms.Button();
            this.pnl_InventorySubmenu = new System.Windows.Forms.Panel();
            this.btn_IngredientsInventory = new System.Windows.Forms.Button();
            this.btn_MenuInventory = new System.Windows.Forms.Button();
            this.btn_Inventory = new System.Windows.Forms.Button();
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_RestaurantName = new System.Windows.Forms.Label();
            this.dineInOrders1 = new IpaysFoodhouse.DineInOrders();
            this.ingredientsInventory1 = new IpaysFoodhouse.IngredientsInventory();
            this.menuInventory1 = new IpaysFoodhouse.MenuInventory();
            this.deliveryOrders1 = new IpaysFoodhouse.DeliveryOrders();
            this.pnl_Sidebar.SuspendLayout();
            this.pnl_KOTSubmenu.SuspendLayout();
            this.pnl_OrdersSubmenu.SuspendLayout();
            this.pnl_InventorySubmenu.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Sidebar
            // 
            this.pnl_Sidebar.AutoScroll = true;
            this.pnl_Sidebar.BackColor = System.Drawing.Color.Black;
            this.pnl_Sidebar.Controls.Add(this.pnl_KOTSubmenu);
            this.pnl_Sidebar.Controls.Add(this.btn_KOT);
            this.pnl_Sidebar.Controls.Add(this.pnl_OrdersSubmenu);
            this.pnl_Sidebar.Controls.Add(this.btn_Orders);
            this.pnl_Sidebar.Controls.Add(this.pnl_InventorySubmenu);
            this.pnl_Sidebar.Controls.Add(this.btn_Inventory);
            this.pnl_Sidebar.Controls.Add(this.pnl_Logo);
            this.pnl_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Sidebar.Name = "pnl_Sidebar";
            this.pnl_Sidebar.Size = new System.Drawing.Size(166, 537);
            this.pnl_Sidebar.TabIndex = 0;
            // 
            // pnl_KOTSubmenu
            // 
            this.pnl_KOTSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnl_KOTSubmenu.Controls.Add(this.btn_Completed);
            this.pnl_KOTSubmenu.Controls.Add(this.btn_Pending);
            this.pnl_KOTSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_KOTSubmenu.Location = new System.Drawing.Point(0, 366);
            this.pnl_KOTSubmenu.Name = "pnl_KOTSubmenu";
            this.pnl_KOTSubmenu.Size = new System.Drawing.Size(166, 80);
            this.pnl_KOTSubmenu.TabIndex = 6;
            // 
            // btn_Completed
            // 
            this.btn_Completed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Completed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Completed.FlatAppearance.BorderSize = 0;
            this.btn_Completed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Completed.Font = new System.Drawing.Font("Roboto Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Completed.ForeColor = System.Drawing.Color.White;
            this.btn_Completed.Location = new System.Drawing.Point(0, 40);
            this.btn_Completed.Name = "btn_Completed";
            this.btn_Completed.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Completed.Size = new System.Drawing.Size(166, 40);
            this.btn_Completed.TabIndex = 3;
            this.btn_Completed.Text = "Completed";
            this.btn_Completed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Completed.UseVisualStyleBackColor = false;
            this.btn_Completed.Click += new System.EventHandler(this.btn_Completed_Click);
            // 
            // btn_Pending
            // 
            this.btn_Pending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Pending.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Pending.FlatAppearance.BorderSize = 0;
            this.btn_Pending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pending.Font = new System.Drawing.Font("Roboto Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pending.ForeColor = System.Drawing.Color.White;
            this.btn_Pending.Location = new System.Drawing.Point(0, 0);
            this.btn_Pending.Name = "btn_Pending";
            this.btn_Pending.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Pending.Size = new System.Drawing.Size(166, 40);
            this.btn_Pending.TabIndex = 0;
            this.btn_Pending.Text = "Pending";
            this.btn_Pending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pending.UseVisualStyleBackColor = false;
            this.btn_Pending.Click += new System.EventHandler(this.btn_Pending_Click);
            // 
            // btn_KOT
            // 
            this.btn_KOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_KOT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KOT.FlatAppearance.BorderSize = 0;
            this.btn_KOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KOT.Font = new System.Drawing.Font("Roboto Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KOT.ForeColor = System.Drawing.Color.White;
            this.btn_KOT.Location = new System.Drawing.Point(0, 316);
            this.btn_KOT.Name = "btn_KOT";
            this.btn_KOT.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_KOT.Size = new System.Drawing.Size(166, 50);
            this.btn_KOT.TabIndex = 5;
            this.btn_KOT.Text = "K.O.T.";
            this.btn_KOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KOT.UseVisualStyleBackColor = false;
            this.btn_KOT.Click += new System.EventHandler(this.btn_KOT_Click);
            // 
            // pnl_OrdersSubmenu
            // 
            this.pnl_OrdersSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnl_OrdersSubmenu.Controls.Add(this.btn_Delivery);
            this.pnl_OrdersSubmenu.Controls.Add(this.btn_DineIn);
            this.pnl_OrdersSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_OrdersSubmenu.Location = new System.Drawing.Point(0, 234);
            this.pnl_OrdersSubmenu.Name = "pnl_OrdersSubmenu";
            this.pnl_OrdersSubmenu.Size = new System.Drawing.Size(166, 82);
            this.pnl_OrdersSubmenu.TabIndex = 4;
            // 
            // btn_Delivery
            // 
            this.btn_Delivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Delivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Delivery.FlatAppearance.BorderSize = 0;
            this.btn_Delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delivery.Font = new System.Drawing.Font("Roboto Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delivery.ForeColor = System.Drawing.Color.White;
            this.btn_Delivery.Location = new System.Drawing.Point(0, 40);
            this.btn_Delivery.Name = "btn_Delivery";
            this.btn_Delivery.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Delivery.Size = new System.Drawing.Size(166, 40);
            this.btn_Delivery.TabIndex = 3;
            this.btn_Delivery.Text = "Delivery";
            this.btn_Delivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delivery.UseVisualStyleBackColor = false;
            this.btn_Delivery.Click += new System.EventHandler(this.btn_Delivery_Click);
            // 
            // btn_DineIn
            // 
            this.btn_DineIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_DineIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DineIn.FlatAppearance.BorderSize = 0;
            this.btn_DineIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DineIn.Font = new System.Drawing.Font("Roboto Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DineIn.ForeColor = System.Drawing.Color.White;
            this.btn_DineIn.Location = new System.Drawing.Point(0, 0);
            this.btn_DineIn.Name = "btn_DineIn";
            this.btn_DineIn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_DineIn.Size = new System.Drawing.Size(166, 40);
            this.btn_DineIn.TabIndex = 0;
            this.btn_DineIn.Text = "Dine-In";
            this.btn_DineIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DineIn.UseVisualStyleBackColor = false;
            this.btn_DineIn.Click += new System.EventHandler(this.btn_DineIn_Click);
            // 
            // btn_Orders
            // 
            this.btn_Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Orders.FlatAppearance.BorderSize = 0;
            this.btn_Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Orders.Font = new System.Drawing.Font("Roboto Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Orders.ForeColor = System.Drawing.Color.White;
            this.btn_Orders.Location = new System.Drawing.Point(0, 184);
            this.btn_Orders.Name = "btn_Orders";
            this.btn_Orders.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Orders.Size = new System.Drawing.Size(166, 50);
            this.btn_Orders.TabIndex = 3;
            this.btn_Orders.Text = "Orders";
            this.btn_Orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Orders.UseVisualStyleBackColor = false;
            this.btn_Orders.Click += new System.EventHandler(this.btn_Orders_Click);
            // 
            // pnl_InventorySubmenu
            // 
            this.pnl_InventorySubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnl_InventorySubmenu.Controls.Add(this.btn_IngredientsInventory);
            this.pnl_InventorySubmenu.Controls.Add(this.btn_MenuInventory);
            this.pnl_InventorySubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_InventorySubmenu.Location = new System.Drawing.Point(0, 102);
            this.pnl_InventorySubmenu.Name = "pnl_InventorySubmenu";
            this.pnl_InventorySubmenu.Size = new System.Drawing.Size(166, 82);
            this.pnl_InventorySubmenu.TabIndex = 2;
            // 
            // btn_IngredientsInventory
            // 
            this.btn_IngredientsInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_IngredientsInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_IngredientsInventory.FlatAppearance.BorderSize = 0;
            this.btn_IngredientsInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IngredientsInventory.Font = new System.Drawing.Font("Roboto Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IngredientsInventory.ForeColor = System.Drawing.Color.White;
            this.btn_IngredientsInventory.Location = new System.Drawing.Point(0, 40);
            this.btn_IngredientsInventory.Name = "btn_IngredientsInventory";
            this.btn_IngredientsInventory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_IngredientsInventory.Size = new System.Drawing.Size(166, 40);
            this.btn_IngredientsInventory.TabIndex = 3;
            this.btn_IngredientsInventory.Text = "Ingredients";
            this.btn_IngredientsInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_IngredientsInventory.UseVisualStyleBackColor = false;
            this.btn_IngredientsInventory.Click += new System.EventHandler(this.btn_IngredientsInventory_Click);
            // 
            // btn_MenuInventory
            // 
            this.btn_MenuInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_MenuInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MenuInventory.FlatAppearance.BorderSize = 0;
            this.btn_MenuInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuInventory.Font = new System.Drawing.Font("Roboto Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MenuInventory.ForeColor = System.Drawing.Color.White;
            this.btn_MenuInventory.Location = new System.Drawing.Point(0, 0);
            this.btn_MenuInventory.Name = "btn_MenuInventory";
            this.btn_MenuInventory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_MenuInventory.Size = new System.Drawing.Size(166, 40);
            this.btn_MenuInventory.TabIndex = 0;
            this.btn_MenuInventory.Text = "Menu";
            this.btn_MenuInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuInventory.UseVisualStyleBackColor = false;
            this.btn_MenuInventory.Click += new System.EventHandler(this.btn_MenuInventory_Click);
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Inventory.FlatAppearance.BorderSize = 0;
            this.btn_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inventory.Font = new System.Drawing.Font("Roboto Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventory.ForeColor = System.Drawing.Color.White;
            this.btn_Inventory.Location = new System.Drawing.Point(0, 52);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Inventory.Size = new System.Drawing.Size(166, 50);
            this.btn_Inventory.TabIndex = 1;
            this.btn_Inventory.Text = "Inventory";
            this.btn_Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventory.UseVisualStyleBackColor = false;
            this.btn_Inventory.Click += new System.EventHandler(this.btn_Inventory_Click);
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(166, 52);
            this.pnl_Logo.TabIndex = 0;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.pnl_Top.Controls.Add(this.lbl_RestaurantName);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(166, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(842, 52);
            this.pnl_Top.TabIndex = 1;
            // 
            // lbl_RestaurantName
            // 
            this.lbl_RestaurantName.AutoSize = true;
            this.lbl_RestaurantName.Font = new System.Drawing.Font("Roboto Black", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RestaurantName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.lbl_RestaurantName.Location = new System.Drawing.Point(6, 9);
            this.lbl_RestaurantName.Name = "lbl_RestaurantName";
            this.lbl_RestaurantName.Size = new System.Drawing.Size(233, 34);
            this.lbl_RestaurantName.TabIndex = 0;
            this.lbl_RestaurantName.Text = "Ipay\'s Foodhouse";
            // 
            // dineInOrders1
            // 
            this.dineInOrders1.AutoScroll = true;
            this.dineInOrders1.Location = new System.Drawing.Point(166, 52);
            this.dineInOrders1.Name = "dineInOrders1";
            this.dineInOrders1.Size = new System.Drawing.Size(842, 485);
            this.dineInOrders1.TabIndex = 4;
            // 
            // ingredientsInventory1
            // 
            this.ingredientsInventory1.Location = new System.Drawing.Point(166, 52);
            this.ingredientsInventory1.Name = "ingredientsInventory1";
            this.ingredientsInventory1.Size = new System.Drawing.Size(842, 485);
            this.ingredientsInventory1.TabIndex = 2;
            // 
            // menuInventory1
            // 
            this.menuInventory1.Location = new System.Drawing.Point(166, 52);
            this.menuInventory1.Name = "menuInventory1";
            this.menuInventory1.Size = new System.Drawing.Size(842, 485);
            this.menuInventory1.TabIndex = 3;
            // 
            // deliveryOrders1
            // 
            this.deliveryOrders1.AutoScroll = true;
            this.deliveryOrders1.Location = new System.Drawing.Point(166, 52);
            this.deliveryOrders1.Name = "deliveryOrders1";
            this.deliveryOrders1.Size = new System.Drawing.Size(842, 485);
            this.deliveryOrders1.TabIndex = 5;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.dineInOrders1);
            this.Controls.Add(this.ingredientsInventory1);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.pnl_Sidebar);
            this.Controls.Add(this.menuInventory1);
            this.Controls.Add(this.deliveryOrders1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1024, 576);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ipay\'s Foodhouse";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.pnl_Sidebar.ResumeLayout(false);
            this.pnl_KOTSubmenu.ResumeLayout(false);
            this.pnl_OrdersSubmenu.ResumeLayout(false);
            this.pnl_InventorySubmenu.ResumeLayout(false);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Sidebar;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_RestaurantName;
        private System.Windows.Forms.Panel pnl_Logo;
        private System.Windows.Forms.Panel pnl_InventorySubmenu;
        private System.Windows.Forms.Button btn_Inventory;
        private System.Windows.Forms.Button btn_MenuInventory;
        private System.Windows.Forms.Button btn_IngredientsInventory;
        private System.Windows.Forms.Button btn_Orders;
        private System.Windows.Forms.Button btn_KOT;
        private System.Windows.Forms.Panel pnl_OrdersSubmenu;
        private System.Windows.Forms.Button btn_Delivery;
        private System.Windows.Forms.Button btn_DineIn;
        private System.Windows.Forms.Panel pnl_KOTSubmenu;
        private System.Windows.Forms.Button btn_Completed;
        private System.Windows.Forms.Button btn_Pending;
        private IngredientsInventory ingredientsInventory1;
        private MenuInventory menuInventory1;
        private DineInOrders dineInOrders1;
        private DeliveryOrders deliveryOrders1;
    }
}

