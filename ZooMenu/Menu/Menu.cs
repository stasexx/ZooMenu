using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooMenu.ZooDataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZooMenu
{
    public partial class Menu : Form
    {
        private bool type = false;
        private int group_id;
        private int animal_id;
        List<int> parcelIds = new List<int>();
        public SqlConnection Connection = Program.SqlConnection;
        public Menu()
        {
            InitializeComponent();
        }
        private string AnimalCheker()
        {
            try
            {
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new ZooDataSet.AnimalDataTable();
                animalTableAdapter.Fill(st);
                object[] row = st.Rows[stb - 1].ItemArray;
                animal_id = Convert.ToInt32(row[0]);
                Kind.Text = row[3].ToString();
                Wei.Text = row[8].ToString();
                var rowForSql = row[6].ToString();
                group_id = Convert.ToInt32(row[6]);

                return rowForSql;
            }
            catch(Exception ex)
            {
                
            }
            return "";
        }
        private Dictionary<string, double> CalculatorForAnimal()
        {
            var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var st = new ZooDataSet.AnimalDataTable();
            animalTableAdapter.Fill(st);
            object[] row = st.Rows[stb - 1].ItemArray;
            Kind.Text = row[3].ToString();
            double AvarageCalories = (Convert.ToInt32(row[8]))/3;
            double AnimalHealth=1;
            if(row[9].ToString() == "Здорова")
            {
                AnimalHealth = 1;
            }
            if (row[9].ToString() == "Хвора")
            {
                AnimalHealth = 0;
            }
            Dictionary<string, double> result = new Dictionary<string, double>()
            {
                {"AvarageCalories", AvarageCalories },
                {"AnimalHealth",  AnimalHealth}

            };
            return result;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            parcelIds = new List<int>();
            type = type;           
           
            var rowForSql = AnimalCheker();
            if (rowForSql == "")
            {
                MessageBox.Show("Спочатку оберіть тварину!!!");
                return;
            }
            string sqlMethodOfFood = $"SELECT GroupOfAnimal.Food_method \r\nFROM GroupOfAnimal, Animal\r\nWHERE GroupOfAnimal.Group_of_animal_id = {rowForSql}";
            using (SqlCommand com = new SqlCommand(sqlMethodOfFood, Connection))
            {
                com.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                object[] rows = dt.Rows[0].ItemArray;
                CaloriesPerDay.Text = rows[0].ToString();
            }
            Dictionary<string, double> result = CalculatorForAnimal();
            string firstFeed = "";
            string firstFeedId = "";
            int afterCalories = 0;
            var dtWithLastFeedings = SqlCommandForMenu.DeviationCheker(animal_id);
            for(int i = 0; i < dtWithLastFeedings.Rows.Count; i++)
            {
                afterCalories += Convert.ToInt32(dtWithLastFeedings.Rows[i].ItemArray[0]);
            }
            for (int i = 0; i<3; i++)
            {
                if (i == 0)
                {
                    Dictionary<string, int> AvarageCalories = new Dictionary<string, int>();
                    AvarageCalories = avarageCalories(afterCalories, result);
                    var dtWithMinDate = SqlCommandForMenu.Min(CaloriesPerDay.Text, AvarageCalories["AvarageCalories"], AvarageCalories["Deviation"]);
                    if (dtWithMinDate.Rows.Count == 0)
                    {
                        MessageBox.Show("Упс... Якась помилка(" +
                            "Скоріш за все, закінчився корм!");
                        return;
                    }
                    object[] rs = dtWithMinDate.Rows[0].ItemArray;
                    textBoxForFeed.Text = rs[0].ToString();
                    firstFeed = rs[0].ToString();
                    var dtWithSelectFeed = SqlCommandForMenu.SelectFeed(firstFeed);
                    object[] rows = dtWithSelectFeed.Rows[0].ItemArray;
                    int parcelId = (Convert.ToInt32(rows[3]));
                    parcelIds.Add(parcelId);
                    textBoxForFeed.Text = rows[0].ToString();
                    double Size = AvarageCalories["AvarageCalories"] / (Convert.ToInt32(rows[1]));
                    textBoxForCaloricIn100_1.Text = rows[1].ToString();
                    textBoxNameOfFeed1.Text = rows[2].ToString();
                    textBoxForFeed.Text = (Convert.ToInt32(rows[1]) * Size).ToString();
                    textBoxForId1.Text = rows[0].ToString();
                    textBoxForSize1.Text = (Size / 10).ToString();
                }
                if(i == 1)
                {
                    int counter = 0;
                    bool stopper = false;
                    while (stopper == false)
                    {
                        Dictionary<string, int> AvarageCalories = new Dictionary<string, int>();
                        AvarageCalories = avarageCalories(afterCalories, result);
                        var dtWithRandomFeed = SqlCommandForMenu.RandomFeed(CaloriesPerDay.Text, AvarageCalories["AvarageCalories"]);
                        object[] rs = dtWithRandomFeed.Rows[dtWithRandomFeed.Rows.Count - 1].ItemArray;
                        firstFeedId = rs[0].ToString();
                        if(counter == 20)
                        {
                            MessageBox.Show("Упс... Якась помилка(" +
                            "Скоріш за все, закінчився корм!");
                            stopper = true;
                            return;
                        }
                        var dtWithSelectFeed = SqlCommandForMenu.SelectFeed(firstFeedId);
                        object[] rows = dtWithSelectFeed.Rows[0].ItemArray;
                        double Size = AvarageCalories["AvarageCalories"] / Convert.ToInt32(rows[1]);
                        textBoxForCaloricIn100_2.Text = rows[1].ToString();
                        textBoxNameOfFeed2.Text = rows[2].ToString();
                        textBoxForSecondFeed.Text = (Convert.ToInt32(rows[1]) * Size).ToString();
                        textBoxForId2.Text = rows[0].ToString();
                        textBoxForSize2.Text = (Size / 10).ToString();
                        counter++;
                        if ((rows[0].ToString()) != firstFeed)
                        {
                            stopper = true;
                            parcelIds.Add(Convert.ToInt32(rows[3]));
                        }
                    }
                }
                if (i == 2)
                {
                    int AvarageCalories = Convert.ToInt32(result["AvarageCalories"] - (result["AvarageCalories"] * 0.3));
                    var dtWithMinDate = SqlCommandForMenu.Min(CaloriesPerDay.Text, AvarageCalories, 0);

                    if (dtWithMinDate.Rows.Count >= 2)
                    {

                        object[] rss = dtWithMinDate.Rows[1].ItemArray;
                        firstFeed = rss[0].ToString();
                        var dtWithSelectFeeds = SqlCommandForMenu.SelectFeed(firstFeed);
                        object[] row = dtWithSelectFeeds.Rows[0].ItemArray;
                        parcelIds.Add(Convert.ToInt32(row[3]));
                        double AvarageCalories2 = result["AvarageCalories"] - (result["AvarageCalories"] * 0.3);
                        double Size = AvarageCalories2 / Convert.ToInt32(row[1]);
                        textBoxForCaloricIn100_3.Text = row[1].ToString();
                        textBoxNameOfFeed3.Text = row[2].ToString();
                        textBoxForThirdFeed.Text = (Convert.ToInt32(row[1]) * Size).ToString();
                        textBoxForId3.Text = row[0].ToString();
                        textBoxForSize3.Text = (Size / 10).ToString();
                        continue;
                    }
                    object[] rs = dtWithMinDate.Rows[0].ItemArray;
                    firstFeed = rs[0].ToString();
                    var dtWithSelectFeed = SqlCommandForMenu.SelectFeed(firstFeed);
                    object[] rows = dtWithSelectFeed.Rows[0].ItemArray;
                    parcelIds.Add(Convert.ToInt32(rows[3]));
                    double Size1 = AvarageCalories / Convert.ToInt32(rows[1]);
                    textBoxForCaloricIn100_3.Text = rows[1].ToString();
                    textBoxNameOfFeed3.Text = rows[2].ToString();
                    textBoxForThirdFeed.Text = (Convert.ToInt32(rows[1]) * Size1).ToString();
                    textBoxForId3.Text = rows[0].ToString();
                    textBoxForSize3.Text = (Size1 / 10).ToString();
                }
                
            }
        }
        public Dictionary<string, int> avarageCalories(int afterCalories, Dictionary<string, double> result)
        {
            Dictionary<string, int> CaloriseAndDeviation = new Dictionary<string, int>();
            int AvarageCalories = 0;
            if (afterCalories > (result["AvarageCalories"] * 3) * 0.8 && afterCalories != 0)
            {
                if (result["AnimalHealth"] == 1)
                {
                    AvarageCalories = Convert.ToInt32(result["AvarageCalories"] + (result["AvarageCalories"] * 0.1));
                    CaloriseAndDeviation.Add("AvarageCalories", AvarageCalories);
                    CaloriseAndDeviation.Add("Deviation", 0);
                }
                if (result["AnimalHealth"] == 0)
                {
                    AvarageCalories = Convert.ToInt32(result["AvarageCalories"] - (result["AvarageCalories"] * 0.2));
                    CaloriseAndDeviation.Add("AvarageCalories", AvarageCalories);
                    CaloriseAndDeviation.Add("Deviation", 0);
                }
            }
            if (afterCalories < (result["AvarageCalories"] * 3) * 0.8 && afterCalories != 0)
            {
                if (result["AnimalHealth"] == 1)
                {
                    AvarageCalories = Convert.ToInt32(result["AvarageCalories"] + (result["AvarageCalories"] * 0.3));
                    CaloriseAndDeviation.Add("AvarageCalories", AvarageCalories);
                    CaloriseAndDeviation.Add("Deviation", 1);
                }
                if (result["AnimalHealth"] == 0)
                {
                    AvarageCalories = Convert.ToInt32(result["AvarageCalories"] - (result["AvarageCalories"] * 0.2));
                    CaloriseAndDeviation.Add("AvarageCalories", AvarageCalories);
                    CaloriseAndDeviation.Add("Deviation", 1);
                }
            }
            if (afterCalories == 0)
            {
                if (result["AnimalHealth"] == 1)
                {
                    AvarageCalories = Convert.ToInt32(result["AvarageCalories"] + (result["AvarageCalories"] * 0.1));
                    CaloriseAndDeviation.Add("AvarageCalories", AvarageCalories);
                    CaloriseAndDeviation.Add("Deviation", 0);
                }
                if (result["AnimalHealth"] == 0)
                {
                    AvarageCalories = Convert.ToInt32(result["AvarageCalories"] - (result["AvarageCalories"] * 0.2));
                    CaloriseAndDeviation.Add("AvarageCalories", AvarageCalories);
                    CaloriseAndDeviation.Add("Deviation", 0);
                }
            }
            return CaloriseAndDeviation;
        }
       
        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Parcel". При необходимости она может быть перемещена или удалена.
            this.parcelTableAdapter.Fill(this.zooDataSet.Parcel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet2.Feeding". При необходимости она может быть перемещена или удалена.
            this.feedingTableAdapter.Fill(this.zooDataSet2.Feeding);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet2.Menu". При необходимости она может быть перемещена или удалена.
            this.menuTableAdapter.Fill(this.zooDataSet2.Menu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet1.Menu". При необходимости она может быть перемещена или удалена.
            this.menuTableAdapter.Fill(this.zooDataSet1.Menu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.zooDataSet.Animal);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if(i== 0)
                {
                    var maxForMenu = Convert.ToInt32(menuTableAdapter.MaxManuQuery());
                    var maxForFeeding = Convert.ToInt32(feedingTableAdapter.ScalarQuery());
                    menuTableAdapter.InsertQuery(maxForMenu + 1, Convert.ToInt32(textBoxForId1.Text), group_id);
                    feedingTableAdapter.InsertQuery(maxForFeeding + 1, animal_id, maxForMenu + 1, Convert.ToDouble(textBoxForSize1.Text), DateTime.Now.ToString());
                    double countOfFeed = SqlCommandForMenu.CountOfFeedInPArcelNow(parcelIds[i]);
                    countOfFeed = countOfFeed - Convert.ToDouble(textBoxForSize1.Text);
                    parcelTableAdapter.UpdateCount(parcelIds[i], countOfFeed);
                }
                if (i == 1)
                {
                    var maxForMenu = Convert.ToInt32(menuTableAdapter.MaxManuQuery());
                    var maxForFeeding = Convert.ToInt32(feedingTableAdapter.ScalarQuery());
                    menuTableAdapter.InsertQuery(maxForMenu +1,Convert.ToInt32(textBoxForId2.Text), group_id);
                    feedingTableAdapter.InsertQuery(maxForFeeding + 1, animal_id, maxForMenu + 1, Convert.ToDouble(textBoxForSize2.Text), DateTime.Now.ToString());
                    double countOfFeed = SqlCommandForMenu.CountOfFeedInPArcelNow(parcelIds[i]);
                    countOfFeed = countOfFeed - Convert.ToDouble(textBoxForSize2.Text);
                    parcelTableAdapter.UpdateCount(parcelIds[i], countOfFeed);


                }
                if (i == 2)
                {
                    var maxForMenu = Convert.ToInt32(menuTableAdapter.MaxManuQuery());
                    var maxForFeeding = Convert.ToInt32(feedingTableAdapter.ScalarQuery());
                    menuTableAdapter.InsertQuery(maxForMenu +1,Convert.ToInt32(textBoxForId3.Text), group_id);
                    feedingTableAdapter.InsertQuery(maxForFeeding + 1, animal_id, maxForMenu + 1, Convert.ToDouble(textBoxForSize3.Text), DateTime.Now.ToString());
                    double countOfFeed = SqlCommandForMenu.CountOfFeedInPArcelNow(parcelIds[i]);
                    countOfFeed = countOfFeed - Convert.ToDouble(textBoxForSize3.Text);
                    parcelTableAdapter.UpdateCount(parcelIds[i], countOfFeed);
                }

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
    }
}
