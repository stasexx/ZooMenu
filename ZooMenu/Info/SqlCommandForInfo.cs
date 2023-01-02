using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooMenu.InfoStats
{
    public class SqlCommandForInfo
    {
        public static SqlConnection Connection = Program.SqlConnection;
        public static DataTable FilterForAnimalPlus(string tableName, string row)
        {
            string sql = "SELECT *" +
                $"\r\nFROM {tableName}" +
                $"\r\nORDER BY {row}";

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
        public static DataTable FilterForAnimalMinus(string tableName, string row)
        {
            string sql = "SELECT *" +
                $"\r\nFROM {tableName}" +
                $"\r\nORDER BY {row} DESC";

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
        public static List<string> Combo(string name)
        {
            string sql = "SELECT COLUMN_NAME" +
                "\r\nFROM Zoo.INFORMATION_SCHEMA.COLUMNS" +
                $"\r\nWHERE TABLE_NAME = N'{name}'";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                List<string> result = new List<string>();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        result.Add(item.ToString());
                    }
                }
                return result;
            }
        }
        public static DataTable Searching(string argument, string table, string column)
        {
            string sql = $"SELECT *" +
                $"\r\nFROM {table}" +
                $"\r\nWHERE {column} LIKE '%{argument}%'";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable FilterForAnimalFor1Age(string x)
        {
            string sql = "";
            if(x == "<3")
            {
                sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 0 AND 2 ";
            }
            if (x == "3-5")
            {
                sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 3 AND 5 ";
            }
            if (x == ">5")
            {
                sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 6 AND 1000 ";
            }
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable FilterForAnimalFor1Weight(string x)
        {
            string sql = "";
            if (x == "<20")
            {
                sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 0 AND 19";
            }
            if (x == "20-100")
            {
                sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100 ";
            }
            if (x == ">100")
            {
                sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 10000 ";
            }
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable FilterForAnimalFor1Calories(string x)
        {
            string sql = "";
            if (x == "<1000")
            {
                sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Calories_per_day BETWEEN 0 AND 999";
            }
            if (x == "1000-3000")
            {
                sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Calories_per_day BETWEEN 1000 AND 3000";
            }
            if (x == ">3000")
            {
                sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Calories_per_day BETWEEN 3001 AND 1000000000";
            }
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable FilterForAnimalFor2AgeAndWeight(string x, string y)
        {
            string sql = "";
            if (x == "<3")
            {
                if(y == "<20")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 0 AND 2" +
                $"AND Weight_of_animal BETWEEN 0 AND 19";
                }
                if (y == "20-100")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 0 AND 2" +
                $"AND Weight_of_animal BETWEEN 20 AND 100";
                }
                if (y == ">100")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 0 AND 2" +
                $"AND Weight_of_animal BETWEEN 101 AND 10000";
                }
            }
            if (x == "3-5")
            {
                if (y == "<20")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 3 AND 5" +
                $"AND Weight_of_animal BETWEEN 0 AND 19";
                }
                if (y == "20-100")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 3 AND 5" +
                $"AND Weight_of_animal BETWEEN 20 AND 100";
                }
                if (y == ">100")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 3 AND 5" +
                $"AND Weight_of_animal BETWEEN 101 AND 10000000";
                }
            }
            if (x == ">5")
            {
                if (y == "<20")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 6 AND 19999" +
                $"AND Weight_of_animal BETWEEN 0 AND 19";
                }
                if (y == "20-100")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 6 AND 19999" +
                $"AND Weight_of_animal BETWEEN 20 AND 100";
                }
                if (y == ">100")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 6 AND 19999" +
                $"AND Weight_of_animal BETWEEN 100 AND 10000";
                }
            }
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable FilterForAnimalFor2AgeAndCalories(string x, string y)
        {
            string sql = "";
            if (x == "<3")
            {
                if (y == "<1000")
                {

                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 0 AND 2" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 ";
                }
                if (y == "1000-3000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 0 AND 2" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 ";
                }
                if (y == ">3000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 0 AND 2" +
                $"AND Animal.Calories_per_day BETWEEN 3001 AND 10000000000000 ";
                }
            }
            if (x == "3-5")
            {
                if (y == "<1000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 3 AND 5" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 ";
                }
                if (y == "1000-3000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 3 AND 5" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 ";
                }
                if (y == ">3000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 3 AND 5" +
                $"AND Animal.Calories_per_day BETWEEN 3001 AND 10000000000000 ";
                }
            }
            if (x == ">5")
            {
                if (y == "<1000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 6 AND 100000" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 ";
                }
                if (y == "1000-3000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 6 AND 100000" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 ";
                }
                if (y == ">3000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Animal.Age BETWEEN 6 AND 100000" +
                $"AND Animal.Calories_per_day BETWEEN 3001 AND 10000000000000 ";
                }
            }
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable FilterForAnimalFor2WeightAndCalories(string x, string y)
        {
            string sql = "";
            if (x == "<20")
            {
                if (y == "<1000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 0 AND 19" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 ";
                }
                if (y == "1000-3000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 0 AND 19" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 ";
                }
                if (y == ">3000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 0 AND 19" +
                $"AND Animal.Calories_per_day BETWEEN 3001 AND 10000000000000 ";
                }
            }
            if (x == "20-100")
            {
                if (y == "<1000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 ";
                }
                if (y == "1000-3000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 ";
                }
                if (y == ">3000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100" +
                $"AND Animal.Calories_per_day BETWEEN 3001 AND 10000000000000 ";
                }
            }
            if (x == ">100")
            {
                if (y == "<1000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 100000" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 ";
                }
                if (y == "1000-3000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 100000" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 ";
                }
                if (y == ">3000")
                {
                    sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 100000" +
                $"AND Animal.Calories_per_day BETWEEN 3001 AND 10000000000000 ";
                }
            }
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable FilterForAnimalFor3WeightAndCaloriesAndAge(string x, string y, string z)
        {
            string sql = "";
            if (x == "<20")
            {
                if (y == "<1000")
                {
                    if (z == "<3")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 0 AND 19" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 " +
                $"AND Animal.Age BETWEEN 0 AND 2";
                    }
                    if (z == "3-5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 3 AND 5" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 " +
                $"AND Animal.Age BETWEEN 3 AND 5";
                    }
                    if (z == ">5")
                    {
                        sql = $"SELECT *" +
                                        $"\r\nFROM Animal" +
                                        $"\r\nWHERE Weight_of_animal BETWEEN 6 AND 100000" +
                                        $"AND Animal.Calories_per_day BETWEEN 0 AND 999 " +
                                        $"AND Animal.Age BETWEEN 6 AND 1000";
                    }
                   
                }
                if (y == "1000-3000")
                {
                    if (z == "<3")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 0 AND 19" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 " +
                $"AND Animal.Age BETWEEN 0 AND 2";
                    }
                    if (z == "3-5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 0 AND 19" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 " +
                $"AND Animal.Age BETWEEN 3 AND 5";
                    }
                    if (z == ">5")
                    {
                        sql = $"SELECT *" +
                                        $"\r\nFROM Animal" +
                                        $"\r\nWHERE Weight_of_animal BETWEEN 0 AND 19" +
                                        $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 " +
                                        $"AND Animal.Age BETWEEN 6 AND 1000";
                    }
                }
                if (y == ">3000")
                {
                    if (z == "<3")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 0 AND 19" +
                $"AND Animal.Calories_per_day BETWEEN 3000 AND 10000000 " +
                $"AND Animal.Age BETWEEN 0 AND 2";
                    }
                    if (z == "3-5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 0 AND 19" +
                $"AND Animal.Calories_per_day BETWEEN 3000 AND 10000000 " +
                $"AND Animal.Age BETWEEN 3 AND 5";
                    }
                    if (z == ">5")
                    {
                        sql = $"SELECT *" +
                                        $"\r\nFROM Animal" +
                                        $"\r\nWHERE Weight_of_animal BETWEEN 0 AND 19" +
                                        $"AND Animal.Calories_per_day BETWEEN 3000 AND 10000000 " +
                                        $"AND Animal.Age BETWEEN 6 AND 1000";
                    }
                }
            }
            if (x == "20-100")
            {
                if (y == "<1000")
                {
                    if (z == "<3")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 " +
                $"AND Animal.Age BETWEEN 0 AND 2";
                    }
                    if (z == "3-5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 " +
                $"AND Animal.Age BETWEEN 3 AND 5";
                    }
                    if (z == ">5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 " +
                $"AND Animal.Age BETWEEN 6 AND 10000";
                    }
                }
                if (y == "1000-3000")
                {
                    if (z == "<3")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 " +
                $"AND Animal.Age BETWEEN 0 AND 2";
                    }
                    if (z == "3-5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 " +
                $"AND Animal.Age BETWEEN 3 AND 5";
                    }
                    if (z == ">5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 " +
                $"AND Animal.Age BETWEEN 6 AND 10000";
                    }
                }
                if (y == ">3000")
                {
                    if (z == "<3")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100" +
                $"AND Animal.Calories_per_day BETWEEN 3000 AND 100000 " +
                $"AND Animal.Age BETWEEN 0 AND 2";
                    }
                    if (z == "3-5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100" +
                $"AND Animal.Calories_per_day BETWEEN 3000 AND 100000 " +
                $"AND Animal.Age BETWEEN 3 AND 5";
                    }
                    if (z == ">5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 20 AND 100" +
                $"AND Animal.Calories_per_day BETWEEN 3000 AND 100000 " +
                $"AND Animal.Age BETWEEN 6 AND 10000";
                    }
                }
            }
            if (x == ">100")
            {
                if (y == "<1000")
                {
                    if (z == "<3")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 100000000" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 " +
                $"AND Animal.Age BETWEEN 0 AND 2";
                    }
                    if (z == "3-5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 1000000" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 " +
                $"AND Animal.Age BETWEEN 3 AND 5";
                    }
                    if (z == ">5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 100001" +
                $"AND Animal.Calories_per_day BETWEEN 0 AND 999 " +
                $"AND Animal.Age BETWEEN 6 AND 10000";
                    }
                }
                if (y == "1000-3000")
                {
                    if (z == "<3")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 1000000" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 " +
                $"AND Animal.Age BETWEEN 0 AND 2";
                    }
                    if (z == "3-5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 1000000" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 " +
                $"AND Animal.Age BETWEEN 3 AND 5";
                    }
                    if (z == ">5")
                    {
                        sql = $"SELECT *" +
                $"\r\nFROM Animal" +
                $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 100001" +
                $"AND Animal.Calories_per_day BETWEEN 1000 AND 3000 " +
                $"AND Animal.Age BETWEEN 6 AND 10000";
                    }
                }
                if (y == ">3000")
                {
                        if (z == "<3")
                        {
                            sql = $"SELECT *" +
                    $"\r\nFROM Animal" +
                    $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 1000000" +
                    $"AND Animal.Calories_per_day BETWEEN 3000 AND 10000000 " +
                    $"AND Animal.Age BETWEEN 0 AND 2";
                        }
                        if (z == "3-5")
                        {
                            sql = $"SELECT *" +
                    $"\r\nFROM Animal" +
                    $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 1000000" +
                    $"AND Animal.Calories_per_day BETWEEN 3000 AND 10000000 " +
                    $"AND Animal.Age BETWEEN 3 AND 5";
                        }
                        if (z == ">5")
                        {
                            sql = $"SELECT *" +
                    $"\r\nFROM Animal" +
                    $"\r\nWHERE Weight_of_animal BETWEEN 101 AND 100001" +
                    $"AND Animal.Calories_per_day BETWEEN 3000 AND 10000000" +
                    $"AND Animal.Age BETWEEN 6 AND 10000";
                        }
                }
            
            }
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable FilterForFeedFor1Calories(string x)
        {
            string sql = "";
            if (x == "<100")
            {
                sql = $"SELECT *" +
                    $"\r\nFROM Feed" +
                    $"\r\nWHERE Caloric BETWEEN 0 AND 100";
            }
            if (x == "100-300")
            {
                sql = $"SELECT *" +
                    $"\r\nFROM Feed" +
                    $"\r\nWHERE Caloric BETWEEN 101 AND 300";
            }
            if (x == ">300")
            {
                sql = $"SELECT *" +
                    $"\r\nFROM Feed" +
                    $"\r\nWHERE Caloric BETWEEN 301 AND 100000";
            }
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable FilterForFeedForKind(string x)
        {
            string sql = "";
            if (x == "М'ясоїд")
            {
                sql = $"SELECT *" +
                    $"\r\nFROM Feed" +
                    $"\r\nWHERE Kind = 'М`ясоїд'";
            }
            if (x == "Травоїд")
            {
                sql = $"SELECT *" +
                    $"\r\nFROM Feed" +
                    $"\r\nWHERE Kind = 'Травоїд'";
            }

            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable FilterForFeedKindAndCalories(string x, string y)
        {
            string sql = "";
            if (x == "М'ясоїд")
            {
                if (y == "<100")
                {
                    sql = $"SELECT *" +
                    $"\r\nFROM Feed" +
                    $"\r\nWHERE Kind = 'М`ясоїд' AND Caloric BETWEEN 0 AND 99";
                }
                if (y == "100-300")
                {
                    sql = $"SELECT *" +
                    $"\r\nFROM Feed" +
                    $"\r\nWHERE Kind = 'М`ясоїд' AND Caloric BETWEEN 100 AND 300";
                }
                if (y == ">300")
                {
                    sql = $"SELECT *" +
                    $"\r\nFROM Feed" +
                    $"\r\nWHERE Kind = 'М`ясоїд' AND Caloric BETWEEN 301 AND 10000";
                }
            }
            if (x == "Травоїд")
            {
                if (y == "<100")
                {
                    sql = $"SELECT *" +
                    $"\r\nFROM Feed" +
                    $"\r\nWHERE Kind = 'Травоїд' AND Caloric BETWEEN 0 AND 99";
                }
                if (y == "100-300")
                {
                    sql = $"SELECT *" +
                    $"\r\nFROM Feed" +
                    $"\r\nWHERE Kind = 'Травоїд' AND Caloric BETWEEN 100 AND 300";
                }
                if (y == ">300")
                {
                    sql = $"SELECT *" +
                    $"\r\nFROM Feed" +
                    $"\r\nWHERE Kind = 'Травоїд' AND Caloric BETWEEN 301 AND 10000";
                }
            }
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
