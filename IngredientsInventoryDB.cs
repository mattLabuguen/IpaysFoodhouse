using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IpaysFoodhouse
{
    public class IngredientsInventoryDB
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
            builder.AllowZeroDateTime = true;

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
        public double Before { get; private set; }
        public double Used { get; private set; }
        public double Ending { get; private set; }
        public String Category { get; private set; }
        public String Date { get; private set; }
        public String Supplier { get; private set; }

        private IngredientsInventoryDB(int id, String name, String unit, double before, double used, double ending, String category, String date, String supplier)
        {
            Id = id;
            Name = name;
            Unit = unit;
            Before = before;
            Used = used;
            Ending = ending;
            Category= category;
            Date = date;
            Supplier = supplier;
        }

        public static List<IngredientsInventoryDB> GetRows()
        {
            List<IngredientsInventoryDB> rows = new List<IngredientsInventoryDB>();
            String query = "SELECT * FROM ingredients_inventory";

            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["ingredients_id"];
                String name = reader["ingredients_name"].ToString();
                String unit = reader["ingredients_unit"].ToString();
                double before = (double)reader["ingredients_before"];
                double used = (double)reader["ingredients_used"];
                double ending = (double)reader["ingredients_ending"];
                String category = reader["ingredients_category"].ToString();
                String date = reader["ingredients_date"].ToString();
                String supplier = reader["ingredients_supplier"].ToString();

                IngredientsInventoryDB m = new IngredientsInventoryDB(id, name, unit, before, used, ending, category, date, supplier);

                rows.Add(m);
            }
            reader.Close();
            dbCon.Close();
            return rows;
        }

        public static List<IngredientsInventoryDB> GetRowsWithDate(String currentDate)
        {
            List<IngredientsInventoryDB> rows = new List<IngredientsInventoryDB>();
            String query = "SELECT * FROM ingredients_inventory WHERE ingredients_date = '" + currentDate + "';";

            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["ingredients_id"];
                String name = reader["ingredients_name"].ToString();
                String unit = reader["ingredients_unit"].ToString();
                double before = (double)reader["ingredients_before"];
                double used = (double)reader["ingredients_used"];
                double ending = (double)reader["ingredients_ending"];
                String category = reader["ingredients_category"].ToString();
                String date = reader["ingredients_date"].ToString();
                String supplier = reader["ingredients_supplier"].ToString();

                IngredientsInventoryDB m = new IngredientsInventoryDB(id, name, unit, before, used, ending, category, date, supplier);

                rows.Add(m);
            }
            reader.Close();
            dbCon.Close();
            return rows;
        }

        public static List<IngredientsInventoryDB> Search(String searchText)
        {
            List<IngredientsInventoryDB> rows = new List<IngredientsInventoryDB>();
            String query = "SELECT * FROM ingredients_inventory WHERE INSTR(ingredients_name, '" + searchText + "') > 0;";

            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["ingredients_id"];
                String name = reader["ingredients_name"].ToString();
                String unit = reader["ingredients_unit"].ToString();
                double before = (double)reader["ingredients_before"];
                double used = (double)reader["ingredients_used"];
                double ending = (double)reader["ingredients_ending"];
                String category = reader["ingredients_category"].ToString();
                String date = reader["ingredients_date"].ToString();
                String supplier = reader["ingredients_supplier"].ToString();

                IngredientsInventoryDB m = new IngredientsInventoryDB(id, name, unit, before, used, ending, category, date, supplier);

                rows.Add(m);
            }
            reader.Close();
            dbCon.Close();
            return rows;
        }

        public static IngredientsInventoryDB Insert(String[] row)
        { 
            String query = string.Format("INSERT INTO ingredients_inventory(ingredients_name, ingredients_before, ingredients_unit, ingredients_supplier, ingredients_category, ingredients_date)" +
                " VALUES('{0}',{1}, '{2}','{3}','{4}', '{5}')", row[0], row[1], row[2], row[3], row[4], row[5]);

            MySqlCommand cmd = new MySqlCommand(query, dbCon);

            dbCon.Open();

            cmd.ExecuteNonQuery();
            int id = (int)cmd.LastInsertedId;

            double used = 0;
            double ending = 0;

            IngredientsInventoryDB new_row = new IngredientsInventoryDB(id, row[0], row[2], Convert.ToDouble(row[1]), used, ending, row[3], row[4], row[5]);

            dbCon.Close();

            return new_row;
        }

        public static void Delete(int id)
        {
            String query = string.Format("DELETE FROM ingredients_inventory WHERE ingredients_id ={0}", id);
            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public static String GetDate()
        {
            String query = "SELECT max(date_format(ingredients_date, '%m-%d-%Y')) AS 'Date' FROM ingredients_inventory;";
            String currentDate = "";
            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                currentDate = reader["Date"].ToString();
            }

            reader.Close();
            dbCon.Close();

            return currentDate;
        }

    }
}
