using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IpaysFoodhouse
{
    public class UnitDB
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
        public String Unit { get; private set; }

        private UnitDB(int id, String unit)
        {
            Id = id;
            Unit = unit;
        }

        public static List<UnitDB> GetUnits()
        {
            List<UnitDB> units = new List<UnitDB>();
            String query = "SELECT * FROM ingredients_unit";

            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["unit_id"];
                String unit = reader["unit_name"].ToString();
                UnitDB m = new UnitDB(id, unit);

                units.Add(m);
            }
            reader.Close();
            dbCon.Close();
            return units;
        }

        public static UnitDB Insert(String unit)
        {
            String query = string.Format("INSERT INTO ingredients_unit(unit_name) VALUES('{0}')", unit);

            MySqlCommand cmd = new MySqlCommand(query, dbCon);

            dbCon.Open();

            cmd.ExecuteNonQuery();
            int id = (int)cmd.LastInsertedId;

            UnitDB new_row = new UnitDB(id, unit);

            dbCon.Close();

            return new_row;
        }

        public static void Delete(int id)
        {
            String query = string.Format("DELETE FROM ingredients_unit WHERE unit_id ={0}", id);
            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            cmd.ExecuteNonQuery();
            dbCon.Close();
        }

        public static int findID(String unitName)
        {
            int id = 0;
            String query = string.Format("SELECT unit_id FROM ingredients_unit WHERE unit_name = '{0}'", unitName);

            MySqlCommand cmd = new MySqlCommand(query, dbCon);
            dbCon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = (int)reader["unit_id"];
            }
            reader.Close();
            dbCon.Close();

            return id;
        }
    }

}
