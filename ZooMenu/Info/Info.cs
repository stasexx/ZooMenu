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
using ZooMenu.InfoStats;

namespace ZooMenu
{
    public partial class Info : Form
    {
        public static SqlConnection Connection = Program.SqlConnection;
        public Info()
        {
            InitializeComponent();
            var dt = SqlCommandForInfo.FilterForAnimalPlus("Animal", "Age");
            dataGridView1.DataSource = dt;
        }

        private void заЗбільшеннямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dt = SqlCommandForInfo.FilterForAnimalPlus("Animal", "Animal_id");
            dataGridView1.DataSource = dt;
        }

        private void заЗменшеннямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dt = SqlCommandForInfo.FilterForAnimalMinus("Animal", "Animal_id");
            dataGridView1.DataSource = dt;
        }

        private void заToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dt = SqlCommandForInfo.FilterForAnimalPlus("Animal", "Animal_name");
            dataGridView1.DataSource = dt;
        }

        public void LoadComboBox()
        {
            string sql = "SELECT name\r\nFROM sys.objects\r\nWHERE type_desc = 'USER_TABLE'";
            using (SqlCommand command = new SqlCommand(sql, Connection))
            {
                command.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                comboBoxTableName.DataSource = dt;
                comboBoxTableName.DisplayMember = "Name";
                comboBoxTableName.ValueMember = "Name";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TableName = comboBoxTableName.Text;

            if (TableName == "System.Data.DataRowView")
            {
                Console.WriteLine("ex");
            }
            if(TableName == "Feeding")
            {
                string sql = $"SELECT * FROM Feedings";
                using (SqlCommand command = new SqlCommand(sql, Connection))
                {
                    command.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                var items = SqlCommandForInfo.Combo("Feedings");
                comboBox1.Items.Clear();
                comboBoxForSearch.Items.Clear();
            }
            if (TableName == "Menu")
            {
                string sql = $"SELECT * FROM Menus";
                using (SqlCommand command = new SqlCommand(sql, Connection))
                {
                    command.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                var items = SqlCommandForInfo.Combo("Menus");
                comboBox1.Items.Clear();
                comboBoxForSearch.Items.Clear();
            }
            if (TableName == "Cage")
            {
                string sql = $"SELECT * FROM Cages";
                using (SqlCommand command = new SqlCommand(sql, Connection))
                {
                    command.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                var items = SqlCommandForInfo.Combo("Menus");
                comboBox1.Items.Clear();
                comboBoxForSearch.Items.Clear();
            }
            if (TableName != "Feeding" && (TableName != "System.Data.DataRowView") && TableName != "Menu" && TableName != "Cage")
            {
                string sql = $"SELECT * FROM {TableName}";
                using (SqlCommand command = new SqlCommand(sql, Connection))
                {
                    command.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                var items = SqlCommandForInfo.Combo(TableName);
                comboBox1.Items.Clear();
                comboBoxForSearch.Items.Clear();
                if(TableName == "Animal")
                {
                    labelForAnimalAge.Show();
                    labelForAnimalCalories.Show();
                    labelForAnimalWeight.Show();
                    label6.Hide();
                    label7.Hide();
                    label4.Hide();
                    button2.Show();
                    button3.Hide();
                    comboBoxFilterAge.Show();
                    comboBoxFilterWeight.Show();
                    comboBoxCalories.Show();
                    comboBoxForCaloric.Hide();
                    comboBoxForKind.Hide();
                }
                if (TableName == "Feed")
                {
                    labelForAnimalAge.Hide();
                    labelForAnimalCalories.Hide();
                    labelForAnimalWeight.Hide();
                    label6.Show();
                    label7.Show();
                    label4.Show();
                    button2.Hide();
                    button3.Show();
                    comboBoxForCaloric.Show();
                    comboBoxForKind.Show();
                    comboBoxCalories.Hide();
                    comboBoxFilterWeight.Hide();
                    comboBoxFilterAge.Hide();
                }
                if(TableName != "Feed" && TableName != "Animal")
                {
                    labelForAnimalAge.Hide();
                    labelForAnimalCalories.Hide();
                    labelForAnimalWeight.Hide();
                    label6.Hide();
                    label7.Hide();
                    label4.Hide();
                    button2.Hide();
                    button3.Hide();
                    comboBoxCalories.Hide();
                    comboBoxForKind.Hide();
                    comboBoxFilterAge.Hide();
                    comboBoxFilterWeight.Hide();
                    comboBoxForCaloric.Hide();
                }
                comboBox1.Text = "";
                comboBoxForSearch.Text = "";
                foreach (var i in items)
                {
                    comboBox1.Items.Add(i);
                    comboBoxForSearch.Items.Add(i);
                }
            }
        }

        private void Info_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "За зрозтанням")
            {
                var dt = SqlCommandForInfo.FilterForAnimalPlus(comboBoxTableName.Text, comboBox1.Text);
                dataGridView1.DataSource = dt;
            }
            if(comboBox3.Text == "За зменшенням")
            {
                var dt = SqlCommandForInfo.FilterForAnimalMinus(comboBoxTableName.Text, comboBox1.Text);
                dataGridView1.DataSource = dt;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var dt = SqlCommandForInfo.Searching(textBox1.Text, comboBoxTableName.Text, comboBoxForSearch.Text);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBoxFilterAge.Text !="" && comboBoxCalories.Text == "" && comboBoxFilterWeight.Text == "")
            {
                var dt = SqlCommandForInfo.FilterForAnimalFor1Age(comboBoxFilterAge.Text);
                dataGridView1.DataSource = dt;
            }
            if (comboBoxFilterAge.Text == "" && comboBoxCalories.Text == "" && comboBoxFilterWeight.Text != "")
            {
                var dt = SqlCommandForInfo.FilterForAnimalFor1Weight(comboBoxFilterWeight.Text);
                dataGridView1.DataSource = dt;
            }
            if (comboBoxFilterAge.Text == "" && comboBoxCalories.Text != "" && comboBoxFilterWeight.Text == "")
            {
                var dt = SqlCommandForInfo.FilterForAnimalFor1Calories(comboBoxCalories.Text);
                dataGridView1.DataSource = dt;
            }
            if (comboBoxFilterAge.Text != "" && comboBoxCalories.Text == "" && comboBoxFilterWeight.Text != "")
            {
                var dt = SqlCommandForInfo.FilterForAnimalFor2AgeAndWeight(comboBoxFilterAge.Text, comboBoxFilterWeight.Text);
                dataGridView1.DataSource = dt;
            }
            if (comboBoxFilterAge.Text != "" && comboBoxCalories.Text != "" && comboBoxFilterWeight.Text == "")
            {
                var dt = SqlCommandForInfo.FilterForAnimalFor2AgeAndCalories(comboBoxFilterAge.Text, comboBoxCalories.Text);
                dataGridView1.DataSource = dt;
            }
            if (comboBoxFilterAge.Text == "" && comboBoxCalories.Text != "" && comboBoxFilterWeight.Text != "")
            {
                var dt = SqlCommandForInfo.FilterForAnimalFor2WeightAndCalories(comboBoxFilterWeight.Text, comboBoxCalories.Text);
                dataGridView1.DataSource = dt;
            }
            if (comboBoxFilterAge.Text != "" && comboBoxCalories.Text != "" && comboBoxFilterWeight.Text != "")
            {
                var dt = SqlCommandForInfo.FilterForAnimalFor3WeightAndCaloriesAndAge(comboBoxFilterWeight.Text, comboBoxCalories.Text, comboBoxFilterAge.Text);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBoxForCaloric.Text!="" && comboBoxForKind.Text == "")
            {
                var dt = SqlCommandForInfo.FilterForFeedFor1Calories(comboBoxForCaloric.Text);
                dataGridView1.DataSource = dt;
            }
            if (comboBoxForCaloric.Text == "" && comboBoxForKind.Text != "")
            {
                var dt = SqlCommandForInfo.FilterForFeedForKind(comboBoxForKind.Text);
                dataGridView1.DataSource = dt;
            }
            if (comboBoxForCaloric.Text != "" && comboBoxForKind.Text != "")
            {
                var dt = SqlCommandForInfo.FilterForFeedKindAndCalories(comboBoxForKind.Text, comboBoxForCaloric.Text);
                dataGridView1.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBoxCalories.Text = "";
            comboBoxFilterAge.Text = "";
            comboBoxFilterWeight.Text = "";
            comboBoxForKind.Text = "";
            comboBoxForCaloric.Text = "";
            Info_Load(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            comboBoxCalories.Text = "";
            comboBoxFilterAge.Text = "";
            comboBoxFilterWeight.Text = "";
            comboBoxForKind.Text = "";
            comboBoxForCaloric.Text = "";
            Info_Load(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
