using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpaysFoodhouse
{
    public partial class EditIngredientList : Form
    {
        ListView.CheckedListViewItemCollection checkedItem;
        public int menuItemId = 0;
        public EditIngredientList()
        {
            InitializeComponent();
            IngredientListDB.InitDB();
            loadIngredientList();
        }

        public EditIngredientList(ListView.CheckedListViewItemCollection row)
        {
            InitializeComponent();
            IngredientListDB.InitDB();
            IngredientsCategoryDB.InitDB();
            UnitDB.InitDB();
            checkedItem = row;
            initCheckedItemData();
            loadIngredientList();
            loadCategoryList();
            loadUnitList();
        }


        private void initCheckedItemData()
        {
            foreach(ListViewItem item in checkedItem)
            {
                menuItemId = Int32.Parse(item.SubItems[0].Text);
                lbl_MenuItemName.Text = item.SubItems[3].Text;
            }
        }
        private void loadCategoryList()
        {
            List<IngredientsCategoryDB> rows = IngredientsCategoryDB.GetCategories();
            cb_Category.Items.Clear();
            foreach (IngredientsCategoryDB m in rows)
            {
                cb_Category.Items.Add(m.Category);
            }
        }

        private void loadUnitList()
        {
            List<UnitDB> rows = UnitDB.GetUnits();
            cb_Unit.Items.Clear();
            foreach (UnitDB m in rows)
            {
                cb_Unit.Items.Add(m.Unit);
            }
        }

        private void loadIngredientList()
        {

            List<IngredientListDB> rows = IngredientListDB.GetRow(menuItemId);
            lv_IngredientList.Items.Clear();

            foreach (IngredientListDB m in rows)
            {
                ListViewItem item = new ListViewItem(new String[] { m.Id.ToString(), m.Name, m.Unit, m.Category, m.Quantity.ToString()});
                item.Tag = m;
                lv_IngredientList.Items.Add(item);
            }
        }

        private void btn_AddIngredient_Click(object sender, EventArgs e)
        {
            String name = tb_IngredientName.Text;
            String unit = cb_Unit.Text;
            String category = cb_Category.SelectedItem.ToString();
            double quantity = (double)num_Quantity.Value;
            IngredientListDB.Insert(name, unit, category, quantity, menuItemId);
            loadIngredientList();
        }

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            using (var form = new AddCategoryMenu())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String newCategory = form.returnCategory;
                    IngredientsCategoryDB.Insert(newCategory);
                    loadCategoryList();
                }
            }
        }

        private void btn_RemoveCategory_Click(object sender, EventArgs e)
        {
            DialogResult confirmRemove = MessageBox.Show("Are you sure you want to remove this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmRemove == DialogResult.Yes)
            {
                int id = IngredientsCategoryDB.findID(cb_Category.SelectedItem.ToString());
                IngredientsCategoryDB.Delete(id);
            }
            loadCategoryList();
        }

        private void btn_AddUnit_Click(object sender, EventArgs e)
        {
            using (var form = new Add_Unit())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String newUnit = form.returnUnit;
                    UnitDB.Insert(newUnit);
                    loadUnitList();
                }
            }
        }

        private void btn_RemoveUnit_Click(object sender, EventArgs e)
        {
            DialogResult confirmRemove = MessageBox.Show("Are you sure you want to remove this unit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmRemove == DialogResult.Yes)
            {
                int id = UnitDB.findID(cb_Unit.SelectedItem.ToString());
                UnitDB.Delete(id);
            }
            loadUnitList();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_IngredientName.Text = "";
            cb_Category.ResetText();
            cb_Unit.ResetText();
            num_Quantity.Value = 0;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = lv_IngredientList.CheckedItems;
            if (checkedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to remove these ingredients?", "Remove Ingredients", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    foreach (ListViewItem item in checkedItems)
                    {
                        IngredientListDB.Delete(Int32.Parse(item.SubItems[0].Text));
                    }
                    MessageBox.Show("You have successfully removed an ingredient/s!");
                    loadIngredientList();
                }
                else loadIngredientList();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Please select an ingredient!", "No Ingredients Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
