using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooMenu.Stats
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = SqlCommandForStats.FirstStats();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dt = SqlCommandForStats.SecondStats();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dt = SqlCommandForStats.ThirdStats();
            dataGridView1.DataSource = dt;
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.zooDataSet.Animal);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Спочатку оберіть тварину!!!");
            }
            if (comboBox1.SelectedValue != null)
            {
                var dt = SqlCommandForStats.FourthStats(Convert.ToInt32(comboBox1.SelectedValue));
                dataGridView1.DataSource = dt;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
    }
}
