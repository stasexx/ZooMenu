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
    public class SqlCommandForMenu
    {
        public static bool cheker = false;
        public static SqlConnection Connection = Program.SqlConnection;
        public static DataTable Min(string foodMethod, int AvarageCaloric, int deviation)
        {
            
            string sql2PortionWithDeviation = "SELECT Feed_id, MIN(DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)) AS 'DayO'" +
                "\r\nFROM Feed, Parcel" +
                "\r\nWHERE Feed.Parcel_id = Parcel.Parcel_id" +
                "\r\nGROUP BY Feed_id" +
                "\r\nHAVING MIN(DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)) =" +
                "\r\nAll(SELECT MIN(DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)) " +
                "\r\nFROM Feed, Parcel WHERE Feed.Parcel_id = Parcel.Parcel_id " +
                $"\r\nAND (2.4*({AvarageCaloric}/(Feed.Caloric*10)))<= Parcel.Count_of_feed AND Feed.Kind = '{foodMethod}' " +
                $"AND DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)>=0)";


            string sql2Portion = "SELECT Feed_id, MIN(DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)) AS 'DayO'" +
                "\r\nFROM Feed, Parcel" +
                "\r\nWHERE Feed.Parcel_id = Parcel.Parcel_id" +
                "\r\nGROUP BY Feed_id" +
                "\r\nHAVING MIN(DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)) =" +
                "\r\nAll(SELECT MIN(DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)) " +
                "\r\nFROM Feed, Parcel WHERE Feed.Parcel_id = Parcel.Parcel_id " +
                $"\r\nAND (1.8*({AvarageCaloric}/(Feed.Caloric*10)))<= Parcel.Count_of_feed AND Feed.Kind = '{foodMethod}' " +
                $"AND DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)>=0)";

            string sql1Portion = "SELECT Feed_id, Count_of_feed, MIN(DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)) AS 'DayO'" +
                "\r\nFROM Feed, Parcel" +
                "\r\nWHERE Feed.Parcel_id = Parcel.Parcel_id" +
                "\r\nGROUP BY Feed_id, Count_of_feed" +
                "\r\nHAVING MIN(DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)) =" +
                "\r\nAll(SELECT MIN(DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)) " +
                "\r\nFROM Feed, Parcel WHERE Feed.Parcel_id = Parcel.Parcel_id " +
                $"\r\nAND ({AvarageCaloric}/(Feed.Caloric*10))<= Parcel.Count_of_feed AND Feed.Kind = '{foodMethod}' " +
                $"AND DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)>=0)";

            try
            {
                if (deviation == 1)
                {
                    using (SqlCommand command = new SqlCommand(sql2PortionWithDeviation, Connection))
                    {
                        command.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count != 0 )
                        {
                            return dt;
                        }
                    }
                }
                if(deviation == 0 )
                {
                    using (SqlCommand command = new SqlCommand(sql2Portion, Connection))
                    {
                        command.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count != 0)
                        {
                            return dt;
                        }
                    }
                }
                using (SqlCommand c = new SqlCommand(sql1Portion, Connection))
                {
                    c.CommandType = CommandType.Text;
                    SqlDataAdapter adap = new SqlDataAdapter(c);
                    DataTable datatable = new DataTable();
                    adap.Fill(datatable);
                    var row = datatable.Rows[0];
                    return datatable;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Закінчився корм(");
                DataTable datatable = new DataTable();
                return datatable;            
            }
            
        }
        public static DataTable SelectFeed(string firstFeed)
        {
            string sqlForFeed = $"SELECT *\r\nFROM Feed\r\nWHERE Feed_id = {firstFeed}";
            using (SqlCommand command = new SqlCommand(sqlForFeed, Connection))
            {
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable RandomFeed(string foodMethod, int AvarageCaloric)
        {
            string sqlForFeed = $"SELECT TOP 1 Feed_id " +
                $"\r\nFROM Feed, Parcel" +
                $"\r\nWHERE Feed.Kind = '{foodMethod}' AND Feed.Parcel_id = Parcel.Parcel_id " +
                $"\r\nAND ({AvarageCaloric}/(Feed.Caloric*10))<= Parcel.Count_of_feed AND DATEDIFF(day, GETDATE(), Parcel.Date_of_overdue)>=0" +
                $"\r\nORDER BY NEWID() ";
            using (SqlCommand comFeed = new SqlCommand(sqlForFeed, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable DeviationCheker(int animal_id)
        {
            string sqlForFeed = $"SELECT SUM((Feed.Caloric*Portion_size)*10)" +
                $"\r\nFROM Feeding, Menu, Feed" +
                $"\r\nWHERE Feeding.Animal_id = {animal_id} AND Menu.Menu_id = Feeding.Menu_id AND Feed.Feed_id = Menu.Feed_id" +
                $"\r\nGROUP BY Feeding_id" +
                $"\r\nHAVING MIN(DATEDIFF(day, Feeding.Date_of_feeding, GETDATE())) = " +
                $"All(SELECT MIN(DATEDIFF(day, Feeding.Date_of_feeding, GETDATE())) FROM Feeding WHERE Feeding.Animal_id = {animal_id})\r\n";
            using (SqlCommand comFeed = new SqlCommand(sqlForFeed, Connection))
            {
                comFeed.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static double Calc(List<int> listOfFeedingId)
        {
            double Caloric = 0;
            double Proteins = 0;
            double Fat = 0;
            double Carboh = 0;
            Dictionary<string, int> feed = new Dictionary<string, int>();
            double portion_size = 0;
            List<int> menu_id = new List<int>();
            List<int> calc = new List<int>();
            foreach (int i in listOfFeedingId)
            {
                int counter = 0;
                string sql = "SELECT Portion_size, Menu_id" +
                "\r\nFROM Feeding" +
                $"\r\nWHERE Feeding_id = {i}";
                using (SqlCommand comFeed = new SqlCommand(sql, Connection))
                {
                    comFeed.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                        portion_size = Convert.ToDouble(dt.Rows[0].ItemArray[0]);

                        menu_id.Add(Convert.ToInt32(dt.Rows[0].ItemArray[1]));

                }

                    string sqlForFeed = "SELECT Feed.Caloric" +
                    "\r\nFROM Feed, Menu, Feeding" +
                    $"\r\nWHERE Feeding.Menu_id = Menu.Menu_id AND Menu.Feed_id = Feed.Feed_id AND Menu.Menu_id = {menu_id[counter]}";
                    using (SqlCommand comFeed = new SqlCommand(sqlForFeed, Connection))
                    {
                        comFeed.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(comFeed);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        for (int r = 0; r < dt.Rows.Count; r++)
                        {
                            Caloric += Convert.ToDouble(dt.Rows[r].ItemArray[0]) * 10 * portion_size;
                        }
                    }
            }
            return Caloric;
        }
        public static double CountOfFeedInPArcelNow(int id)
        {
            string sql = "SELECT Count_of_feed" +
                "\r\nFROM Parcel" +
                $"\r\nWHERE Parcel.Parcel_id = {id}";
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
        public static bool CheckForMoreThenOneFeedId(double portionSize, string foodMethod)
        {
            string sql = "SELECT Feed_id" +
                "\r\nFROM Feed, Parcel " +
                $"\r\nWHERE Feed.Parcel_id = Parcel.Parcel_id AND Parcel.Count_of_feed >= 2 AND Feed.Kind = 'М`ясоїд';";
            return false;
        }
        public static string StringBilderForSqlDouble(string str)
        {
            int index = 0;
            string dot = ".";
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',')
                {
                    index++;
                    break;
                }
            }
            str = str.Remove(index, 1).Insert(index, dot.ToString());
            return str;
        }
    }
}
