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
using ZooMenu.AdminForms;
using ZooMenu.InfoStats;
using ZooMenu.ZooDataSetTableAdapters;

namespace ZooMenu
{
    public partial class AdminForm : Form
    {

        public SqlConnection Connection = Program.SqlConnection;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Cage". При необходимости она может быть перемещена или удалена.
            this.cageTableAdapter.Fill(this.zooDataSet.Cage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.zooDataSet.Animal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Parcel". При необходимости она может быть перемещена или удалена.
            this.parcelTableAdapter.Fill(this.zooDataSet.Parcel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet2.Feed". При необходимости она может быть перемещена или удалена.
            this.feedTableAdapter.Fill(this.zooDataSet2.Feed);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet2.Parcel". При необходимости она может быть перемещена или удалена.
            this.parcelTableAdapter.Fill(this.zooDataSet2.Parcel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet1.GroupOfAnimal". При необходимости она может быть перемещена или удалена.
            this.groupOfAnimalTableAdapter.Fill(this.zooDataSet1.GroupOfAnimal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.zooDataSet.Animal);
            LoadComboBox();

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void LoadComboBox()
        {
            string sql = "SELECT name\r\nFROM sys.objects\r\nWHERE type_desc = 'USER_TABLE'";
            using (SqlCommand command = new SqlCommand(sql, Connection))
            {
                command.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Name";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TableName = comboBox2.Text;
            if(TableName == "System.Data.DataRowView")
            {
                Console.WriteLine("ex");
            }
            else
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
                string sql2 = $"SELECT * FROM {TableName}";
                using (SqlCommand command = new SqlCommand(sql2, Connection))
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
                if (TableName == "Animal")
                {
                    labelForAnimalAge.Show();
                    labelForAnimalCalories.Show();
                    labelForAnimalWeight.Show();
                    label6.Hide();
                    label7.Hide();
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
                    button2.Hide();
                    button3.Show();
                    comboBoxForCaloric.Show();
                    comboBoxForKind.Show();
                    comboBoxCalories.Hide();
                    comboBoxFilterWeight.Hide();
                    comboBoxFilterAge.Hide();
                }
                if (TableName != "Feed" && TableName != "Animal")
                {
                    labelForAnimalAge.Hide();
                    labelForAnimalCalories.Hide();
                    labelForAnimalWeight.Hide();
                    label6.Hide();
                    label7.Hide();
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

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            string TableName = comboBox2.SelectedItem.ToString();

            string sql = $"SELECT * FROM {TableName}";
            using (SqlCommand command = new SqlCommand(sql, Connection))
            {
                command.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Cheker(string TableName)
        {
            if (TableName == "System.Data.DataRowView")
            {
                Console.WriteLine("ex");
            }
            else
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
            }
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new ZooDataSet.AnimalDataTable();
                animalTableAdapter.Fill(st);
                object[] row = st.Rows[stb - 1].ItemArray;
                var edt = new CreateFormForAnimal(
                Convert.ToInt32(row[0]),
                row[1].ToString(),
                Convert.ToInt32(row[2]),
                Convert.ToInt32(row[3]),
                Convert.ToDateTime(row[4]),
                row[5].ToString(),
                Convert.ToInt32(row[6]),
                Convert.ToInt32(row[7]),
                Convert.ToDouble(row[8]),
                row[9].ToString());
                edt.ShowDialog();
                animalTableAdapter.Fill(zooDataSet.Animal);
                zooDataSet.AcceptChanges();
                comboBox2.SelectedItem = "Animal";
                var table = comboBox2.Text;
                Show();
                AdminForm_Load(sender, e);
                comboBox2.Text = table;
                dataGridView1.Rows[ind].Selected = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Спочатку оберіть рядок!!!");
            }

        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = SqlCommandForAdmin.GetNumberForGroupOfAnimal() + 1;
            var group = new CreateFormForGroup(id);
            group.ShowDialog();
            AdminForm_Load(sender, e);
        }

        private void animalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = SqlCommandForAdmin.GetNumber()+1;
            var create = new CreateFormForAnimal(id);
            create.ShowDialog();
            AdminForm_Load(sender, e);
            comboBox2.SelectedItem = comboBox2.Items[3];
            int idAnimal = create.idForSelect;
            int rowId = SqlCommandForAdmin.SelectorForDataGrid(dataGridView1, id);
        }


        private void groupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new ZooDataSet.GroupOfAnimalDataTable();
                groupOfAnimalTableAdapter.Fill(st);
                object[] row = st.Rows[stb - 1].ItemArray;
                var edt = new CreateFormForGroup(
                Convert.ToInt32(row[0]),
                row[1].ToString(),
                row[2].ToString());
                edt.ShowDialog();
                groupOfAnimalTableAdapter.Fill(zooDataSet.GroupOfAnimal);
                zooDataSet.AcceptChanges();
                AdminForm_Load(sender, e);
                dataGridView1.Rows[ind].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Спочатку оберіть рядок!!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void feedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = SqlCommandForAdmin.GetNumberForFeed() + 1;
            var create = new CreateAndEditFormForFeed(id);
            create.ShowDialog();
            AdminForm_Load(sender, e);
        }

        private void parcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = SqlCommandForAdmin.GetNumberForFeed() + 1;
            var create = new CreateAndEditFormForParcel(id);
            create.ShowDialog();
            AdminForm_Load(sender, e);
        }

        private void parcelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new ZooDataSet.ParcelDataTable();
                parcelTableAdapter.Fill(st);
                object[] row = st.Rows[stb - 1].ItemArray;
                var edt = new CreateAndEditFormForParcel(
                Convert.ToInt32(row[0]),
                row[1].ToString(),
                Convert.ToDateTime(row[2]),
                Convert.ToDateTime(row[3]),
                Convert.ToInt32(row[4]));
                Hide();
                edt.ShowDialog();
                Show();
                parcelTableAdapter.Fill(zooDataSet.Parcel);
                zooDataSet.AcceptChanges();
                AdminForm_Load(sender, e);
                dataGridView1.Rows[ind].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Спочатку оберіть рядок!!!");
            }
        }

        private void feedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new ZooDataSet.FeedDataTable();
                feedTableAdapter.Fill(st);
                object[] row = st.Rows[stb - 1].ItemArray;
                var edt = new CreateAndEditFormForFeed(
                Convert.ToInt32(row[0]),
                Convert.ToDouble(row[1]),
                row[2].ToString(),
                Convert.ToInt32(row[3]),
                row[4].ToString());
                edt.ShowDialog();
                feedTableAdapter.Fill(zooDataSet.Feed);
                zooDataSet.AcceptChanges();
                string TableName = comboBox2.Text;
                string sql = $"SELECT * FROM {TableName}";
                using (SqlCommand command = new SqlCommand(sql, Connection))
                {
                    command.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                AdminForm_Load(sender, e);
                dataGridView1.Rows[ind].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Спочатку оберіть рядок!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender,e);
        }

        private void cageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = SqlCommandForAdmin.GetNumberForGroupOfAnimal() + 1;
            var cage = new CreateAndEditFormForCage(id);
            cage.ShowDialog();
            AdminForm_Load(sender, e);
        }

        private void cageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                var stb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var st = new ZooDataSet.CageDataTable();
                cageTableAdapter.Fill(st);
                object[] row = st.Rows[stb - 1].ItemArray;
                var edt = new CreateAndEditFormForCage(
                Convert.ToInt32(row[0]),
                Convert.ToInt32(row[1]),
                Convert.ToInt32(row[2]));
                edt.ShowDialog();
                cageTableAdapter.Fill(zooDataSet.Cage);
                zooDataSet.AcceptChanges();
                AdminForm_Load(sender, e);
                dataGridView1.Rows[ind].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Спочатку оберіть рядок!!!");
            }
        }

        private void animalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string TableName = comboBox2.Text;
            animalTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            animalTableAdapter.Fill(zooDataSet.Animal);
            zooDataSet.AcceptChanges();
            AdminForm_Load(sender, e);
            comboBox2.Text = TableName;
            MessageBox.Show("Успішно видалено!");
        }

        private void groupToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string TableName = comboBox2.Text;
            groupOfAnimalTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            groupOfAnimalTableAdapter.Fill(zooDataSet.GroupOfAnimal);
            zooDataSet.AcceptChanges();
            AdminForm_Load(sender, e);
            comboBox2.Text = TableName;
            MessageBox.Show("Успішно видалено!");
        }

        private void parcelToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string TableName = comboBox2.Text;
            parcelTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            parcelTableAdapter.Fill(zooDataSet.Parcel);
            zooDataSet.AcceptChanges();
            MessageBox.Show("Успішно видалено!");
            comboBox2.Text = TableName;
        }

        private void feedToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string TableName = comboBox2.Text;
            feedTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            feedTableAdapter.Fill(zooDataSet.Feed);
            zooDataSet.AcceptChanges();
            MessageBox.Show("Успішно видалено!");
            comboBox2.Text = TableName;
        }

        private void cageToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string TableName = comboBox2.Text;
            cageTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            cageTableAdapter.Fill(zooDataSet.Cage);
            zooDataSet.AcceptChanges();
            MessageBox.Show("Успішно видалено!");
            comboBox2.Text = TableName;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var dt = SqlCommandForInfo.Searching(textBox1.Text, comboBox2.Text, comboBoxForSearch.Text);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxFilterAge.Text != "" && comboBoxCalories.Text == "" && comboBoxFilterWeight.Text == "")
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            comboBoxCalories.Text = "";
            comboBoxFilterAge.Text = "";
            comboBoxFilterWeight.Text = "";
            comboBoxForKind.Text = "";
            comboBoxForCaloric.Text = "";
            AdminForm_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (comboBoxForCaloric.Text != "" && comboBoxForKind.Text == "")
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
    }
}
