using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IpaysFoodhouse
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            customizeDesign();
           
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            pnl_InventorySubmenu.Visible = false;
            pnl_OrdersSubmenu.Visible = false;
            pnl_KOTSubmenu.Visible = false;
            ingredientsInventory1.Visible = false;
            menuInventory1.Visible = false;
            dineInOrders1.Visible = false;
            deliveryOrders1.Visible = false;
        }

        /// User Control
        private void hideUserControl()
        {
            if (ingredientsInventory1.Visible == true)
                ingredientsInventory1.Visible = false;
            if (menuInventory1.Visible == true)
                menuInventory1.Visible = false;
            if (dineInOrders1.Visible == true)
                dineInOrders1.Visible = false;
            if (deliveryOrders1.Visible == true)
                deliveryOrders1.Visible = false;
        }

        private void showUserControl(UserControl page)
        {
            if (page.Visible == false)
            {
                hideUserControl();
                page.Visible = true;
            }
        }

        // Submenu Methods
        private void hideSubMenu()
        {
            if (pnl_InventorySubmenu.Visible == true)
                pnl_InventorySubmenu.Visible = false;
            if (pnl_OrdersSubmenu.Visible == true)
                pnl_OrdersSubmenu.Visible = false;
            if (pnl_KOTSubmenu.Visible == true)
                pnl_KOTSubmenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        // Button Click Methods

        private void otherClicked()
        {
            btn_IngredientsInventory.BackColor = Color.FromArgb(60, 60, 60);
            btn_MenuInventory.BackColor = Color.FromArgb(60, 60, 60);
            btn_DineIn.BackColor = Color.FromArgb(60, 60, 60);
            btn_Delivery.BackColor = Color.FromArgb(60, 60, 60);
            btn_Completed.BackColor = Color.FromArgb(60, 60, 60);
            btn_Pending.BackColor = Color.FromArgb(60, 60, 60);
        }
        
        private void subMenuClicked(Button btn)
        {
            btn.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_InventorySubmenu);
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_OrdersSubmenu);
        }

        private void btn_KOT_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_KOTSubmenu);
        }

        private void btn_IngredientsInventory_Click(object sender, EventArgs e)
        {
            showUserControl(ingredientsInventory1);
            otherClicked();
            btn_IngredientsInventory.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_MenuInventory_Click(object sender, EventArgs e)
        {
            showUserControl(menuInventory1);
            otherClicked();
            btn_MenuInventory.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_DineIn_Click(object sender, EventArgs e)
        {
            showUserControl(dineInOrders1);
            otherClicked();
            btn_DineIn.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_Delivery_Click(object sender, EventArgs e)
        {
            showUserControl(deliveryOrders1);
            otherClicked();
            btn_Delivery.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_Pending_Click(object sender, EventArgs e)
        {
            //showUserControl(menuInventory1);
            otherClicked();
            btn_Pending.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_Completed_Click(object sender, EventArgs e)
        {
            //showUserControl(menuInventory1);
            otherClicked();
            btn_Completed.BackColor = Color.FromArgb(80, 80, 80);
        }
    }
}
