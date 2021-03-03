using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace IpaysFoodhouse
{
    public class IngredientsCategoryDB
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
            Application.ApplicationExit += (sender, args) =>
            {
                if (dbCon != null)
                {
                    dbCon.Dispose();
                    dbCon = null;
                }
            };
        }

        public int Id { get; private set; }
        public String Category { get; private set; }

        private IngredientsCategoryDB(int id, String category)
        {
            Id = id;
            Category = category;
        }

        public static List<IngredientsCategoryDB> GetCategories()
        {
            List<IngredientsCategoryDB> categories = new List<IngredientsCategoryDB>();
            String query = "SELECT * FROM ingredients_category";

            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["i_category_id"];
                String category = reader["i_category_name"].ToString();
                IngredientsCategoryDB m = new IngredientsCategoryDB(id, category);

                categories.Add(m);
            }
            reader.Close();
            dbCon.Close();
            return categories;
        }

        public static IngredientsCategoryDB Insert(String category)
        {
            String query = string.Format("INSERT INTO ingredients_category(i_category_name) VALUES('{0}')", category);

            MySqlCommand cmd = new MySqlCommand(query, dbCon);

            dbCon.Open();

            cmd.ExecuteNonQuery();
            int id = (int)cmd.LastInsertedId;

            IngredientsCategoryDB new_row = new IngredientsCategoryDB(id, category);

            dbCon.Close();

            return new_row;
        }

        public static void Delete(int id)
        {
            String query = string.Format("DELETE FROM ingredients_category WHERE i_category_id ={0}", id);
            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public static int findID(String categoryName)
        {
            int id = 0;
            String query = string.Format("SELECT i_category_id FROM ingredients_category WHERE i_category_name = '{0}'", categoryName);

            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = (int)reader["i_category_id"];
            }
            reader.Close();
            dbCon.Close();

            return id;
        }
    }


}
