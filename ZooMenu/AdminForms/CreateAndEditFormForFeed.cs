using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ZooMenu.ZooDataSetTableAdapters;

namespace ZooMenu.AdminForms
{
    public partial class CreateAndEditFormForFeed : Form
    {
        private bool edit;
        public static int idKey;
        public CreateAndEditFormForFeed(int id)
        {
            InitializeComponent();
            feed_idTextBox.Text = id.ToString();
            idKey = Convert.ToInt32(feed_idTextBox.Text);
        }
        public CreateAndEditFormForFeed(int feedId, double Caloric, string nameOfFeed, int Parcel_id, string Kind):this(feedId)
        {
            feed_idTextBox.Text = feedId.ToString();
            caloricTextBox.Text = Caloric.ToString();
            name_of_feedTextBox.Text = nameOfFeed;
            comboBoxParcel.SelectedValue = Parcel_id.ToString();
            comboBoxKindOfFood.Text = Kind.ToString();
            edit = true;
        }

        private void feedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.feedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);

        }

        private void CreateAndEditFormForFeed_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Parcel". При необходимости она может быть перемещена или удалена.
            this.parcelTableAdapter.Fill(this.zooDataSet.Parcel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Parcel". При необходимости она может быть перемещена или удалена.       // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Feed". При необходимости она может быть перемещена или удалена.
            this.feedTableAdapter.Fill(this.zooDataSet.Feed);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (edit)
                    {
                        feedTableAdapter.UpdateQuery(Convert.ToInt32(feed_idTextBox.Text), Convert.ToDouble(caloricTextBox.Text),
                            name_of_feedTextBox.Text, Convert.ToInt32(comboBoxParcel.SelectedValue), comboBoxKindOfFood.Text);
                        MessageBox.Show("Дані про корм успішно оновлені");
                        Close();

                    }
                    else
                    {
                        feedTableAdapter.InsertQuery(Convert.ToInt32(feed_idTextBox.Text), Convert.ToDouble(caloricTextBox.Text),
                            name_of_feedTextBox.Text, Convert.ToInt32(comboBoxParcel.SelectedValue), comboBoxKindOfFood.Text);
                        MessageBox.Show("Новий корм успішно додано!");
                        Close();
                    }
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Перевірте первинний та зовнішні ключі!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
