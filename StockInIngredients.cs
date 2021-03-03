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
    public partial class StockInIngredients : Form
    {
        public StockInIngredients()
        {
            InitializeComponent();
            loadCategoryList();
            loadUnitList();
        }

        private void loadCategoryList()
        {
            IngredientsCategoryDB.InitDB();
            List<IngredientsCategoryDB> rows = IngredientsCategoryDB.GetCategories();
            cb_Category.Items.Clear();
            foreach (IngredientsCategoryDB m in rows)
            {
                cb_Category.Items.Add(m.Category);
            }
        }

        private void loadUnitList()
        {
            UnitDB.InitDB();
            List<UnitDB> rows = UnitDB.GetUnits();
            cb_Unit.Items.Clear();
            foreach (UnitDB m in rows)
            {
                cb_Unit.Items.Add(m.Unit);
            }
        }

        private void btn_AddStock_Click(object sender, EventArgs e)
        {

            String itemName = tb_Name.Text;
            double quantity = (double)num_Quantity.Value;
            String unit = cb_Unit.SelectedItem.ToString();
            String supplier = tb_Supplier.Text;
            String category = cb_Category.SelectedItem.ToString();

            String[] row = { itemName, quantity.ToString(), unit, supplier, category };
            var listViewRow = new ListViewItem(row);
            lv_StockIn.Items.Add(listViewRow);
        }

        private void btn_RemoveStock_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = lv_StockIn.CheckedItems;

            foreach(ListViewItem item in checkedItems)
            {
                item.Remove();
            }
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


        private void btn_StockIn_Click(object sender, EventArgs e)
        {
            int rowCount = lv_StockIn.Items.Count;
            String date = dtp_Date.Value.ToString("yyyy-MM-dd");

            for(int i = 0; i < rowCount; i++)
            {
                String[] row = { lv_StockIn.Items[i].SubItems[0].Text, lv_StockIn.Items[i].SubItems[1].Text, 
                                 lv_StockIn.Items[i].SubItems[2].Text, lv_StockIn.Items[i].SubItems[3].Text, 
                                 lv_StockIn.Items[i].SubItems[4].Text, date};
                IngredientsInventoryDB.Insert(row);
            }
        }

    }
}
