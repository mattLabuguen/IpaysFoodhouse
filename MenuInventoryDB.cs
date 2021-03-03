using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IpaysFoodhouse
{
    public class MenuInventoryDB
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
        public String Image { get; private set; }
        public String Category { get; private set; }
        public String Name { get; private set; }
        public double Price { get; private set; }
        public String Date { get; private set; }
        public String Status { get; private set; }


        private MenuInventoryDB(int id, String image, String category, String name, double price, String date, String status)
        {
            Id = id;
            Image = image;
            Category = category;
            Name = name;
            Price = price;
            Date = date;
            Status = status;
        }

        public static List<MenuInventoryDB> GetRows()
        {
            List<MenuInventoryDB> rows = new List<MenuInventoryDB>();
            String query = "SELECT * FROM menu_inventory";

            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["menu_id"];
                String image = reader["menu_imagedirectory"].ToString();
                String category = reader["menu_category"].ToString();
                String name = reader["menu_name"].ToString();
                double price = (double)reader["menu_price"];
                String date = reader["menu_date"].ToString();
                String status = reader["menu_status"].ToString();

                MenuInventoryDB m = new MenuInventoryDB(id, image, category, name, price, date, status);

                rows.Add(m);
            }
            reader.Close();
            dbCon.Close();
            return rows;
        }

        public static List<MenuInventoryDB> Search(String searchText)
        {
            List<MenuInventoryDB> rows = new List<MenuInventoryDB>();
            String query = "SELECT * FROM menu_inventory WHERE INSTR(menu_name, '" + searchText + "') > 0;";

            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["menu_id"];
                String image = reader["menu_imagedirectory"].ToString();
                String category = reader["menu_category"].ToString();
                String name = reader["menu_name"].ToString();
                double price = (double)reader["menu_price"];
                String date = reader["menu_date"].ToString();
                String status = reader["menu_status"].ToString();

                MenuInventoryDB m = new MenuInventoryDB(id, image, category, name, price, date, status);

                rows.Add(m);
            }
            reader.Close();
            dbCon.Close();
            return rows;
        }

        public static int getMaxID()
        {
            int maxID = 0;
            String query = "SELECT MAX(menu_id) AS 'menu_id' FROM menu_inventory;";
            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                maxID = (int)reader["menu_id"];
            }
            reader.Close();
            dbCon.Close();
            return maxID + 1;
        }

        public static MenuInventoryDB Insert(String image, String category, String name, double price)
        {
            String date = DateTime.Now.ToString("yyyy/M/d");
            String status = "0";

            String query = string.Format("INSERT INTO menu_inventory(menu_imagedirectory, menu_category, menu_name, menu_price, menu_date, menu_status)" +
                " VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", image, category, name, price, date, status);

            MySqlCommand cmd = new MySqlCommand(query, dbCon);

            dbCon.Open();

            cmd.ExecuteNonQuery();
            int id = (int)cmd.LastInsertedId;

            MenuInventoryDB new_row = new MenuInventoryDB(id, image, category, name, price, date, status);

            dbCon.Close();

            return new_row;
        }

        public static void Delete(int id)
        {
            String query = string.Format("DELETE FROM menu_inventory WHERE menu_id ={0}", id);
            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            cmd.ExecuteNonQuery();
            dbCon.Close();
        } 
    }

}
