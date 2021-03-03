namespace IpaysFoodhouse
{
    partial class DineInOrders
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
            this.components = new System.ComponentModel.Container();
            this.lbl_PageTitle = new System.Windows.Forms.Label();
            this.pnl_OrderList = new System.Windows.Forms.Panel();
            this.lbl_OrderDetails = new System.Windows.Forms.Label();
            this.lbl_OrderNo = new System.Windows.Forms.Label();
            this.lbl_Payment = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_ItemList = new System.Windows.Forms.Label();
            this.pnl_ItemList = new System.Windows.Forms.Panel();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.pnl_CustomerDetails = new System.Windows.Forms.Panel();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_CustomerDetails = new System.Windows.Forms.Label();
            this.btn_ProcessOrder = new System.Windows.Forms.Button();
            this.btn_Fulfilled = new System.Windows.Forms.Button();
            this.btn_Active = new System.Windows.Forms.Button();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pnl_OrderList.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_PageTitle
            // 
            this.lbl_PageTitle.AutoSize = true;
            this.lbl_PageTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_PageTitle.Font = new System.Drawing.Font("Roboto Black", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PageTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_PageTitle.Location = new System.Drawing.Point(3, 14);
            this.lbl_PageTitle.Name = "lbl_PageTitle";
            this.lbl_PageTitle.Size = new System.Drawing.Size(140, 47);
            this.lbl_PageTitle.TabIndex = 8;
            this.lbl_PageTitle.Text = "Orders";
            this.lbl_PageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_OrderList
            // 
            this.pnl_OrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_OrderList.Controls.Add(this.pnl_Top);
            this.pnl_OrderList.Location = new System.Drawing.Point(11, 64);
            this.pnl_OrderList.Name = "pnl_OrderList";
            this.pnl_OrderList.Size = new System.Drawing.Size(234, 520);
            this.pnl_OrderList.TabIndex = 9;
            // 
            // lbl_OrderDetails
            // 
            this.lbl_OrderDetails.AutoSize = true;
            this.lbl_OrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_OrderDetails.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_OrderDetails.Location = new System.Drawing.Point(250, 64);
            this.lbl_OrderDetails.Name = "lbl_OrderDetails";
            this.lbl_OrderDetails.Size = new System.Drawing.Size(155, 29);
            this.lbl_OrderDetails.TabIndex = 10;
            this.lbl_OrderDetails.Text = "Order Details";
            this.lbl_OrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_OrderNo
            // 
            this.lbl_OrderNo.AutoSize = true;
            this.lbl_OrderNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_OrderNo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lbl_OrderNo.Location = new System.Drawing.Point(251, 102);
            this.lbl_OrderNo.Name = "lbl_OrderNo";
            this.lbl_OrderNo.Size = new System.Drawing.Size(107, 19);
            this.lbl_OrderNo.TabIndex = 11;
            this.lbl_OrderNo.Text = "Order Number";
            this.lbl_OrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Payment
            // 
            this.lbl_Payment.AutoSize = true;
            this.lbl_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Payment.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lbl_Payment.Location = new System.Drawing.Point(470, 102);
            this.lbl_Payment.Name = "lbl_Payment";
            this.lbl_Payment.Size = new System.Drawing.Size(72, 19);
            this.lbl_Payment.TabIndex = 12;
            this.lbl_Payment.Text = "Payment";
            this.lbl_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Status.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lbl_Status.Location = new System.Drawing.Point(648, 102);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(55, 19);
            this.lbl_Status.TabIndex = 13;
            this.lbl_Status.Text = "Status";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ItemList
            // 
            this.lbl_ItemList.AutoSize = true;
            this.lbl_ItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ItemList.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemList.ForeColor = System.Drawing.Color.Black;
            this.lbl_ItemList.Location = new System.Drawing.Point(251, 200);
            this.lbl_ItemList.Name = "lbl_ItemList";
            this.lbl_ItemList.Size = new System.Drawing.Size(77, 19);
            this.lbl_ItemList.TabIndex = 14;
            this.lbl_ItemList.Text = "Item List:";
            this.lbl_ItemList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_ItemList
            // 
            this.pnl_ItemList.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_ItemList.Location = new System.Drawing.Point(255, 223);
            this.pnl_ItemList.Name = "pnl_ItemList";
            this.pnl_ItemList.Size = new System.Drawing.Size(554, 100);
            this.pnl_ItemList.TabIndex = 15;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtotal.ForeColor = System.Drawing.Color.Black;
            this.lbl_Subtotal.Location = new System.Drawing.Point(251, 336);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(74, 19);
            this.lbl_Subtotal.TabIndex = 16;
            this.lbl_Subtotal.Text = "Subtotal:";
            this.lbl_Subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_CustomerDetails
            // 
            this.pnl_CustomerDetails.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_CustomerDetails.Location = new System.Drawing.Point(255, 407);
            this.pnl_CustomerDetails.Name = "pnl_CustomerDetails";
            this.pnl_CustomerDetails.Size = new System.Drawing.Size(554, 94);
            this.pnl_CustomerDetails.TabIndex = 17;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(149, 27);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(96, 23);
            this.btnAddOrder.TabIndex = 18;
            this.btnAddOrder.Text = "Add New Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbl_CustomerDetails
            // 
            this.lbl_CustomerDetails.AutoSize = true;
            this.lbl_CustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CustomerDetails.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerDetails.ForeColor = System.Drawing.Color.Black;
            this.lbl_CustomerDetails.Location = new System.Drawing.Point(251, 385);
            this.lbl_CustomerDetails.Name = "lbl_CustomerDetails";
            this.lbl_CustomerDetails.Size = new System.Drawing.Size(137, 19);
            this.lbl_CustomerDetails.TabIndex = 19;
            this.lbl_CustomerDetails.Text = "Customer Details:";
            this.lbl_CustomerDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ProcessOrder
            // 
            this.btn_ProcessOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.btn_ProcessOrder.FlatAppearance.BorderSize = 0;
            this.btn_ProcessOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProcessOrder.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProcessOrder.ForeColor = System.Drawing.Color.White;
            this.btn_ProcessOrder.Location = new System.Drawing.Point(456, 540);
            this.btn_ProcessOrder.Name = "btn_ProcessOrder";
            this.btn_ProcessOrder.Size = new System.Drawing.Size(146, 32);
            this.btn_ProcessOrder.TabIndex = 20;
            this.btn_ProcessOrder.Text = "Process Order";
            this.btn_ProcessOrder.UseVisualStyleBackColor = false;
            // 
            // btn_Fulfilled
            // 
            this.btn_Fulfilled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_Fulfilled.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Fulfilled.FlatAppearance.BorderSize = 0;
            this.btn_Fulfilled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fulfilled.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fulfilled.Location = new System.Drawing.Point(118, 0);
            this.btn_Fulfilled.Name = "btn_Fulfilled";
            this.btn_Fulfilled.Size = new System.Drawing.Size(116, 29);
            this.btn_Fulfilled.TabIndex = 1;
            this.btn_Fulfilled.Text = "Fulfilled";
            this.btn_Fulfilled.UseVisualStyleBackColor = false;
            this.btn_Fulfilled.Click += new System.EventHandler(this.btn_Fulfilled_Click);
            // 
            // btn_Active
            // 
            this.btn_Active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btn_Active.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Active.FlatAppearance.BorderSize = 0;
            this.btn_Active.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Active.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Active.ForeColor = System.Drawing.Color.White;
            this.btn_Active.Location = new System.Drawing.Point(0, 0);
            this.btn_Active.Name = "btn_Active";
            this.btn_Active.Size = new System.Drawing.Size(116, 29);
            this.btn_Active.TabIndex = 0;
            this.btn_Active.Text = "Active";
            this.btn_Active.UseVisualStyleBackColor = false;
            this.btn_Active.Click += new System.EventHandler(this.btn_Active_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.btn_Fulfilled);
            this.pnl_Top.Controls.Add(this.btn_Active);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(234, 29);
            this.pnl_Top.TabIndex = 1;
            // 
            // DineInOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ProcessOrder);
            this.Controls.Add(this.lbl_CustomerDetails);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.pnl_CustomerDetails);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.pnl_ItemList);
            this.Controls.Add(this.lbl_ItemList);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Payment);
            this.Controls.Add(this.lbl_OrderNo);
            this.Controls.Add(this.lbl_OrderDetails);
            this.Controls.Add(this.pnl_OrderList);
            this.Controls.Add(this.lbl_PageTitle);
            this.Name = "DineInOrders";
            this.Size = new System.Drawing.Size(842, 615);
            this.pnl_OrderList.ResumeLayout(false);
            this.pnl_Top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PageTitle;
        private System.Windows.Forms.Panel pnl_OrderList;
        private System.Windows.Forms.Label lbl_OrderDetails;
        private System.Windows.Forms.Label lbl_OrderNo;
        private System.Windows.Forms.Label lbl_Payment;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_ItemList;
        private System.Windows.Forms.Panel pnl_ItemList;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Panel pnl_CustomerDetails;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl_CustomerDetails;
        private System.Windows.Forms.Button btn_ProcessOrder;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Button btn_Fulfilled;
        private System.Windows.Forms.Button btn_Active;
    }
}
