using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooMenu.Report
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void buttonForSeasons_Click(object sender, EventArgs e)
        {
            var dt = SqlCommandForReport.InfoForSeasonReport();
            double autumn = Convert.ToInt32(dt.Rows[3].ItemArray[0]);
            double winter = Convert.ToInt32(dt.Rows[2].ItemArray[0]);
            double spring = Convert.ToInt32(dt.Rows[1].ItemArray[0]);
            double summer = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            Services.DocForSeason(autumn, winter, spring, summer);     
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Feed". При необходимости она может быть перемещена или удалена.
            this.feedTableAdapter.Fill(this.zooDataSet.Feed);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.zooDataSet.Animal);

        }

        private void buttonForParcel_Click(object sender, EventArgs e)
        {
            double countForFirstFeed = SqlCommandForReport.InfoForAnimalPerMonthFirstFeed(Convert.ToInt16(comboBoxForAnimal.SelectedValue), Convert.ToInt16(comboBoxForFirstFeed.SelectedValue)) / 10;
            double countForSecondFeed = SqlCommandForReport.InfoForAnimalPerMonthFirstFeed(Convert.ToInt16(comboBoxForAnimal.SelectedValue), Convert.ToInt16(comboBoxForSecondFeed.SelectedValue)) / 10;
            double countForThirdFeed = SqlCommandForReport.InfoForAnimalPerMonthFirstFeed(Convert.ToInt16(comboBoxForAnimal.SelectedValue), Convert.ToInt16(comboBoxForThirdFeed.SelectedValue)) / 10;
            Services.DocForAnimal(countForFirstFeed, countForSecondFeed, countForThirdFeed, comboBoxForAnimal.Text, comboBoxForFirstFeed.Text, comboBoxForSecondFeed.Text, comboBoxForThirdFeed.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
    }
}
