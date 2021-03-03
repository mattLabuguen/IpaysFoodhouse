using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace IpaysFoodhouse
{
    public class IngredientListDB
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "ipaysfoodhouse_db";
        private const String UID = "root";
        private const String PASSWORD = "root";
        private static MySqlConnection dbCon;

        public static void InitDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            String conString = builder.ToString();
            builder = null;
            dbCon = new MySqlConnection(conString);
            Application.ApplicationExit += (sender, args) => {
                if (dbCon != null)
                {
                    dbCon.Dispose();
                    dbCon = null;
                }
            };
        }

        public int Id { get; private set; }
        public String Name { get; private set; }
        public String Unit { get; private set; }
        public String Category { get; private set; }
        public double Quantity { get; private set; }
        public int MenuItemId { get; private set; }

        private IngredientListDB(int id, String name, String unit, String category, double quantity, int menuItemId)
        {
            Id = id;
            Name = name;
            Unit = unit;
            Category = category;
            Quantity = quantity;
            MenuItemId = menuItemId;
        }

        public static List<IngredientListDB> GetRow(int selectedItemId)
        {
            List<IngredientListDB> rows = new List<IngredientListDB>();
            String query = "SELECT * FROM ingredients_list WHERE list_menuitemid = " + selectedItemId + ";";

            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["list_id"];
                String name = reader["list_ingredientname"].ToString();
                String unit = reader["list_unit"].ToString();
                String category = reader["list_category"].ToString();
                double quantity = (double)reader["list_quantity"];
                int menuItemId = (int)reader["list_menuitemid"];

                IngredientListDB m = new IngredientListDB(id, name, unit, category, quantity, menuItemId);

                rows.Add(m);
            }
            reader.Close();
            dbCon.Close();
            return rows;
        }


        public static IngredientListDB Insert(String name, String unit, String category, double quantity, int menuItemId)
        {
            String query = string.Format("INSERT INTO ingredients_list(list_ingredientname, list_unit, list_category, list_quantity, list_menuitemid)" +
                " VALUES('{0}','{1}','{2}','{3}','{4}')", name, unit, category, quantity, menuItemId);

            MySqlCommand cmd = new MySqlCommand(query, dbCon);

            dbCon.Open();

            cmd.ExecuteNonQuery();
            int id = (int)cmd.LastInsertedId;

            IngredientListDB new_row = new IngredientListDB(id, name, unit, category, quantity, menuItemId);

            dbCon.Close();

            return new_row;
        }

        public static void Delete(int id)
        {
            String query = string.Format("DELETE FROM ingredients_list WHERE list_id ={0}", id);
            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

    }
}
