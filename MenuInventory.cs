using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IpaysFoodhouse
{
    public partial class MenuInventory : UserControl
    {
        public MenuInventory()
        {
            InitializeComponent();
            MenuInventoryDB.InitDB();
        }

        private void loadMenuDB()
        {
            List<MenuInventoryDB> rows = MenuInventoryDB.GetRows();
            lv_MenuInventory.Items.Clear();

            foreach(MenuInventoryDB m in rows)
            {
                ListViewItem item = new ListViewItem(new String[] { m.Id.ToString(), m.Image, m.Category, m.Name, m.Price.ToString(), m.Status.ToString()});
                item.Tag = m;
                lv_MenuInventory.Items.Add(item);
            }
        }

        private void loadSearch(String searchText)
        {
            List<MenuInventoryDB> rows = MenuInventoryDB.Search(searchText);
            lv_MenuInventory.Items.Clear();

            foreach (MenuInventoryDB m in rows)
            {
                ListViewItem item = new ListViewItem(new String[] { m.Id.ToString(), m.Image, m.Category, m.Name, m.Price.ToString(), m.Status.ToString() });
                item.Tag = m;
                lv_MenuInventory.Items.Add(item);
            }
        }

        private void MenuInventory_Load(object sender, EventArgs e)
        {
            loadMenuDB();
        }

        private void btn_AddNewProd_Click(object sender, EventArgs e)
        {
            AddNewProduct addProdForm = new AddNewProduct();
            addProdForm.FormClosed += AddNewProduct_FormClosed;
            addProdForm.ShowDialog();
        }

        private void AddNewProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadMenuDB();
        }

        private void EditIngredientList_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btn_RemoveProd_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = lv_MenuInventory.CheckedItems;
            if (checkedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to remove these items?", "Remove Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    foreach (ListViewItem item in checkedItems)
                    {
                        MenuInventoryDB.Delete(Int32.Parse(item.SubItems[0].Text));
                    }
                    MessageBox.Show("You have successfully removed a Menu Item/s!");
                    loadMenuDB();
                }
                else loadMenuDB();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Please select a menu item!", "No Menu Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_IngredientList_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = lv_MenuInventory.CheckedItems;
            if (checkedItems.Count <= 0)
            {
                DialogResult dr = MessageBox.Show("Please select one menu item!", "No Menu Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (checkedItems.Count > 1)
            {
                DialogResult dr = MessageBox.Show("You can only edit one menu item at a time.", "Select only one menu item.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EditIngredientList ingredientForm = new EditIngredientList(checkedItems);
                ingredientForm.FormClosed += AddNewProduct_FormClosed;
                ingredientForm.ShowDialog();
            }

        }

        private void txt_SearchBar_TextChanged(object sender, EventArgs e)
        {
            String searchText = txt_SearchBar.Text;
            loadSearch(searchText);
        }
    }
}
