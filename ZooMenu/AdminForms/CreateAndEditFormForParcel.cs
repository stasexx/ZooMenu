using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooMenu.AdminForms
{
    public partial class CreateAndEditFormForParcel : Form
    {
        private bool edit;
        public CreateAndEditFormForParcel(int id)
        {
            InitializeComponent();
            parcel_idTextBox.Text = id.ToString();
        }
        public CreateAndEditFormForParcel(int parcerId, string feedName, DateTime dateOfReceipt, DateTime dateOfOverdue, int countOfFeed):this(parcerId)
        {
            edit = true;
            parcel_idTextBox.Text = parcerId.ToString();
            feed_nameTextBox.Text = feedName.ToString();
            date_of_receiptDateTimePicker.Value = dateOfReceipt;
            date_of_overdueDateTimePicker.Value = dateOfOverdue;
            count_of_feedTextBox.Text = countOfFeed.ToString();
        }

        private void parcelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.parcelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);

        }

        private void CreateAndEditFormForParcel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Parcel". При необходимости она может быть перемещена или удалена.
            this.parcelTableAdapter.Fill(this.zooDataSet.Parcel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    parcelTableAdapter.UpdateQuery(Convert.ToInt32(parcel_idTextBox.Text), feed_nameTextBox.Text, date_of_receiptDateTimePicker.Value,
                        date_of_overdueDateTimePicker.Value, Convert.ToInt32(count_of_feedTextBox.Text));
                    MessageBox.Show("Дані про партію успішно оновлені!");
                    Close();
                }
                else
                {
                    parcelTableAdapter.InsertQuery(Convert.ToInt32(parcel_idTextBox.Text), feed_nameTextBox.Text, date_of_receiptDateTimePicker.Value.ToString(),
                        date_of_overdueDateTimePicker.Value.ToString(), Convert.ToInt32(count_of_feedTextBox.Text));
                    MessageBox.Show("Дані про партію успішно додані!");
                    Close();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
