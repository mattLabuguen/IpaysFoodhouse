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
using System.Globalization;

namespace IpaysFoodhouse
{
    public partial class IngredientsInventory : UserControl
    {
        public IngredientsInventory()
        {
            InitializeComponent();
            IngredientsInventoryDB.InitDB();
            initializeDate();
        }

        private String initializeDate()
        {
            DateTime maxDate = DateTime.ParseExact(IngredientsInventoryDB.GetDate(), "MM-dd-yyyy", CultureInfo.InvariantCulture);
            lbl_CurrentDate.Text = maxDate.ToString("MM-dd-yyyy");
            loadInventoryWithDate(maxDate.ToString("yyyy-MM-dd"));

            return maxDate.ToString("yyyy-MM-dd");
        }

        private void loadInventoryWithDate(String date)
        {
            List<IngredientsInventoryDB> rows = IngredientsInventoryDB.GetRowsWithDate(date);

            lv_IngredientsInventory.Items.Clear();

            foreach (IngredientsInventoryDB m in rows)
            {
                ListViewItem item = new ListViewItem(new String[] { m.Id.ToString(), m.Name, m.Unit, m.Before.ToString(), m.Used.ToString(), m.Ending.ToString(), m.Category });
                item.Tag = m;
                lv_IngredientsInventory.Items.Add(item);
            }
        }

        private void loadInventoryWithDate()
        {
            List<IngredientsInventoryDB> rows = IngredientsInventoryDB.GetRowsWithDate(initializeDate());
            lv_IngredientsInventory.Items.Clear();

            foreach (IngredientsInventoryDB m in rows)
            {
                ListViewItem item = new ListViewItem(new String[] { m.Id.ToString(), m.Name, m.Unit, m.Before.ToString(), m.Used.ToString(), m.Ending.ToString(), m.Category });
                item.Tag = m;
                lv_IngredientsInventory.Items.Add(item);
            }
        }
        private void loadSearch(String searchText)
        {
            List<IngredientsInventoryDB> rows = IngredientsInventoryDB.Search(searchText);
            lv_IngredientsInventory.Items.Clear();

            foreach (IngredientsInventoryDB m in rows)
            {
                ListViewItem item = new ListViewItem(new String[] { m.Id.ToString(), m.Name, m.Unit, m.Before.ToString(), m.Used.ToString(), m.Ending.ToString(), m.Category });
                item.Tag = m;
                lv_IngredientsInventory.Items.Add(item);
            }
        }

        private void txt_SearchBar_TextChanged(object sender, EventArgs e)
        {
            String searchText = txt_SearchBar.Text;
            loadSearch(searchText);
        }

        private void btn_AddNewProd_Click(object sender, EventArgs e)
        {
            StockInIngredients stockInForm = new StockInIngredients();
            stockInForm.FormClosed += StockInIngredients_FormClosed;
            stockInForm.ShowDialog();
        }

        private void StockInIngredients_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadInventoryWithDate();
        }

        private void btn_PreviousDay_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.ParseExact(lbl_CurrentDate.Text, "MM-dd-yyyy", CultureInfo.InvariantCulture).AddDays(-1);
            lbl_CurrentDate.Text = currentDate.ToString("MM-dd-yyyy");
            loadInventoryWithDate(currentDate.ToString("yyyy-MM-dd"));
        }

        private void btn_NextDay_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.ParseExact(lbl_CurrentDate.Text, "MM-dd-yyyy", CultureInfo.InvariantCulture).AddDays(1);
            lbl_CurrentDate.Text = currentDate.ToString("MM-dd-yyyy");
            loadInventoryWithDate(currentDate.ToString("yyyy-MM-dd"));
        }
    }
}
