using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooMenu.Report
{
    internal class SqlCommandForReport
    {
        public static SqlConnection Connection = Program.SqlConnection;
        public static DataTable InfoForSeasonReport()
        {
            string sql = "SELECT SUM(Feeding.Portion_size)" +
                "\r\nFROM Feeding" +
                "\r\nWHERE Feeding.Date_of_feeding BETWEEN '01.09.2022' AND '01.12.2022'" +
                "\r\nUNION" +
                "\r\nSELECT SUM(Feeding.Portion_size)" +
                "\r\nFROM Feeding" +
                "\r\nWHERE Feeding.Date_of_feeding BETWEEN '01.12.2022' AND '01.02.2023'" +
                "\r\nUNION" +
                "\r\nSELECT SUM(Feeding.Portion_size)" +
                "\r\nFROM Feeding" +
                "\r\nWHERE Feeding.Date_of_feeding BETWEEN '01.03.2023' AND '01.06.2023'" +
                "\r\nUNION" +
                "\r\nSELECT SUM(Feeding.Portion_size)" +
                "\r\nFROM Feeding" +
                "\r\nWHERE Feeding.Date_of_feeding BETWEEN '01.06.2023' AND '01.09.2023'";

            string sqlNew = "DECLARE @Autumn Int;" +
                "\r\nDECLARE @Winter Int;" +
                "\r\nDECLARE @Sprint Int;" +
                "\r\nDECLARE @Summer Int;" +
                "\r\nSELECT @Autumn=SUM(Feeding.Portion_size)" +
                "\r\nFROM Feeding" +
                "\r\nWHERE Feeding.Date_of_feeding BETWEEN '01.09.2022' AND '01.12.2022'" +
                "\r\nSELECT @Winter=SUM(Feeding.Portion_size)" +
                "\r\nFROM Feeding" +
                "\r\nWHERE Feeding.Date_of_feeding BETWEEN '01.12.2022' AND '01.02.2023'" +
                "\r\nSELECT @Sprint =  SUM(Feeding.Portion_size)" +
                "\r\nFROM Feeding" +
                "\r\nWHERE Feeding.Date_of_feeding BETWEEN '01.03.2023' AND '01.06.2023'" +
                "\r\nSELECT @Summer = SUM(Feeding.Portion_size)" +
                "\r\nFROM Feeding" +
                "\r\nWHERE Feeding.Date_of_feeding BETWEEN '01.06.2023' AND '01.09.2023'";

            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static double InfoForAnimalPerMonthFirstFeed(int animal_id, int feed_id)
        {
            string sql = "SELECT DISTINCT ((Animal.Calories_per_day/Feed.Caloric)*30)/3" +
                $"\r\nFROM Animal, Feed" +
                $"\r\nWHERE Animal.Animal_id = {animal_id} " +
                $"\r\nAND Feed.Feed_id = {feed_id}\r\n";

            using (SqlCommand comFeed = new SqlCommand(sql, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                double result = Convert.ToDouble(dt.Rows[0].ItemArray[0]);
                return result;
            }
        }
    }
}
