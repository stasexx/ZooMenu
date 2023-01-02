using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooMenu
{
    public class SqlCommandForAdmin
    {
        public static string password = "admin";
        public static SqlConnection Connection = Program.SqlConnection;
        public static List<int> SelectorForCageInAnimalCreate()
        {
            string sql = "SELECT Cage.Cage_id " +
                "\r\nFROM Cage " +
                "\r\nWHERE Cage.Max_count_of_animal > (SELECT COUNT(Animal.Animal_id) " +
                "\r\nFROM Animal" +
                "\r\nWHERE Animal.Cage_id = Cage.Cage_id)";

            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                List<int> result = new List<int>();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        result.Add(Convert.ToInt32(item));
                    }
                }
                return result;
            }
        }
        public static List<int> SelectorForCageInAnimalEdit(int id)
        {
            string sql = "SELECT Cage.Cage_id " +
                "\r\nFROM Cage " +
                "\r\nWHERE Cage.Max_count_of_animal > (SELECT COUNT(Animal.Animal_id) " +
                "\r\nFROM Animal" +
                $"\r\nWHERE Animal.Cage_id = Cage.Cage_id) AND Cage.Group_of_animal_id = {id}";

            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                List<int> result = new List<int>();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        result.Add(Convert.ToInt32(item));
                    }
                }
                return result;
            }
        }
        public static string SelectorForNameGroup(int id)
        {
            string sql = "SELECT GroupOfAnimal.Name_of_group " +
                "\r\nFROM GroupOfAnimal" +
                $"\r\nWHERE Group_of_animal_id = {id}";

            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                string result = dt.Rows[0].ItemArray[0].ToString();
                return result;
            }
        }
        public static List<string> SelectorForNameNameGroup()
        {
            string sql = "SELECT Name_of_group FROM GroupOfAnimal";

            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                List <string > list = new List<string>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in dt.Rows[i].ItemArray)
                    {
                        list.Add(item.ToString());
                    }
                }
                string result = dt.Rows[0].ItemArray[0].ToString();
                return list;
            }
        }

        public static int GetNumber()
        {
            string sql = "SELECT COUNT(Animal_id)" +
                "\r\nFROM Animal";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                int result = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                return result;
            }
        }
        public static int GetNumberForFeed()
        {
            string sql = "SELECT COUNT(Feed_id)" +
                "\r\nFROM Feed";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                int result = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                return result;
            }
        }
        public static int GetNumberForGroupOfAnimal()
        {
            string sql = "SELECT COUNT(Group_of_animal_id)" +
                "\r\nFROM GroupOfAnimal";
            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                int result = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                return result;
            }
        }
        public static int SelectorForDataGrid(DataGridView dataGrid, int id)
        {
            for(int i = 0; i<dataGrid.Rows.Count; i++)
            {
                if (id == Convert.ToInt32(dataGrid.Rows[i].Cells[0].Value))
                {
                    return i;
                }
            }
            return 404;
        }
    }
}
