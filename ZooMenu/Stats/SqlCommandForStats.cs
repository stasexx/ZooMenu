using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooMenu.Stats
{
    internal class SqlCommandForStats
    {
        public static SqlConnection Connection = Program.SqlConnection;
        public static DataTable FirstStats()
        {
            string sql = "SELECT DISTINCT Animal.Animal_name, Feed.Name_of_feed, COUNT(Feeding.Animal_id) AS Count" +
                "\r\nFROM Animal, Feeding, Menu, Feed" +
                "\r\nWHERE Animal.Animal_id = Feeding.Animal_id AND Feeding.Menu_id = Menu.Menu_id AND Menu.Feed_id = Feed.Feed_id" +
                "\r\nGROUP BY Animal.Animal_name, Feed.Name_of_feed";

            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                string result = dt.Rows[0].ItemArray[0].ToString();
                return dt;
            }
        }
        public static DataTable SecondStats()
        {
            string sql = "SELECT DISTINCT Feed.Name_of_feed, COUNT(DISTINCT Animal.Animal_id) AS Count_of_animal, SUM(Feeding.Portion_size) AS Sum_of_size" +
                "\r\nFROM Feed, Animal, Feeding, Menu" +
                "\r\nWHERE Animal.Animal_id = Feeding.Animal_id AND Feeding.Menu_id = Menu.Menu_id AND Menu.Feed_id = Feed.Feed_id" +
                "\r\nGROUP BY Feed.Name_of_feed";

            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                string result = dt.Rows[0].ItemArray[0].ToString();
                return dt;
            }
        }
        public static DataTable ThirdStats()
        {
            string sql = "SELECT Cage.Cage_id, Max_count_of_animal,ROUND(CAST(COUNT(Animal.Animal_id) AS DECIMAL (9,2))/Cage.Max_count_of_animal, 3) AS Filling_the_cage" +
                "\r\nFROM Cage, Animal" +
                "\r\nWHERE Cage.Cage_id = Animal.Cage_id" +
                "\r\nGROUP By Cage.Cage_id, Cage.Max_count_of_animal, Cage.Group_of_animal_id";

            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                string result = dt.Rows[0].ItemArray[0].ToString();
                return dt;
            }
        }
        public static DataTable FourthStats(int x)
        {
            string sql = "SELECT Animal.Animal_name, Feed.Name_of_feed, Feeding.Portion_size, Feeding.Date_of_feeding" +
                "\r\nFROM Animal, Feed, Feeding, Menu" +
                "\r\nWHERE Animal.Animal_id = Feeding.Animal_id " +
                "\r\nAND Feeding.Menu_id = Menu.Menu_id " +
                "\r\nAND Menu.Feed_id = Feed.Feed_id " +
                $"\r\nAND Animal.Animal_id = {x}" +
                "\r\nGROUP BY Animal.Animal_name, Feed.Name_of_feed, Feeding.Portion_size, Feeding.Date_of_feeding" +
                "\r\nHAVING (DATEDIFF(day, GETDATE(), Feeding.Date_of_feeding))<30" +
                "\r\nORDER BY Feeding.Date_of_feeding";

            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
