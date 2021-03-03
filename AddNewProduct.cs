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
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
            CategoryDB.InitDB();
            MenuInventoryDB.InitDB();
            initializeID();
            loadCategoryItems();
        }

        private void btn_FileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\School\3RD YEAR\2ND SEMESTER - ONLINE\SYSTEM INTREGRATION AND ARCHITECTURE 2\IpaysFoodhouseMain\menuImages",
                Title = "Find Menu Item Images",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png|All Files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_ImageDirectory.Text = openFileDialog1.FileName;
            }
        }

        private void initializeID()
        {
            lbl_ActualID.Text = MenuInventoryDB.getMaxID().ToString();
        }

        private void loadCategoryItems()
        {
            List<CategoryDB> rows = CategoryDB.GetCategories();
            lb_Category.Items.Clear();
            foreach(CategoryDB m in rows)
            {
                lb_Category.Items.Add(m.Category);
            }
        }

        public String slashInsertion(String imgDir)
        {
            String output = imgDir;
            char[] charArray = imgDir.ToCharArray();
            int length = imgDir.Split('\\').Length - 1;
            List<int> occurrences = new List<int>();
            int index = 0;
            foreach(char ch in charArray)
            {
                if(ch == '\\') occurrences.Add(index);
                index++;
            }
            index = 0;
            foreach(int occurrence in occurrences)
            {
                System.Diagnostics.Debug.WriteLine(occurrence);
                System.Diagnostics.Debug.WriteLine(output.Insert(occurrence, "\\"));
                output = output.Insert(occurrence+index, "\\");
                index++;
            }
            return output;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            String imageDirectory = slashInsertion(tb_ImageDirectory.Text);
            String category = lb_Category.GetItemText(lb_Category.SelectedItem);
            String productName = tb_ProdName.Text;
            double price = Convert.ToDouble(tb_Price.Text);

            MenuInventoryDB.Insert(imageDirectory, category, productName, price);
            MessageBox.Show("You have successfully added a new Menu Item!");
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            using (var form = new AddCategoryMenu())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String newCategory = form.returnCategory;
                    CategoryDB.Insert(newCategory);
                    loadCategoryItems();
                }
            }
        }

        private void btn_RemoveCategory_Click(object sender, EventArgs e)
        {
            DialogResult confirmRemove = MessageBox.Show("Are you sure you want to remove this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmRemove == DialogResult.Yes)
            {
                int id = CategoryDB.findID(lb_Category.SelectedItem.ToString());
                CategoryDB.Delete(id);
            }
            loadCategoryItems();
        }
            
    }
}
