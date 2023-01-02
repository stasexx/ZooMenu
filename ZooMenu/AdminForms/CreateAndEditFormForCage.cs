using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooMenu.ZooDataSetTableAdapters;

namespace ZooMenu.AdminForms
{
    public partial class CreateAndEditFormForCage : Form
    {
        private bool edit;
        public CreateAndEditFormForCage(int id)
        {
            InitializeComponent();
            cage_idTextBox.Text = id.ToString();
        }
        public CreateAndEditFormForCage(int cageId, int max, int groupOfAnimal) : this(cageId)
        {
            cage_idTextBox.Text = cageId.ToString();
            max_count_of_animalTextBox.Text = max.ToString();
            comboBox1.SelectedValue = groupOfAnimal;
            edit = true;
        }

        private void cageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);

        }

        private void CreateAndEditFormForCage_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.GroupOfAnimal". При необходимости она может быть перемещена или удалена.
            this.groupOfAnimalTableAdapter.Fill(this.zooDataSet.GroupOfAnimal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.Cage". При необходимости она может быть перемещена или удалена.
            this.cageTableAdapter.Fill(this.zooDataSet.Cage);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit)
                {
                    if(MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cageTableAdapter.UpdateQuery(Convert.ToInt32(cage_idTextBox.Text), Convert.ToInt32(max_count_of_animalTextBox.Text), Convert.ToInt32(comboBox1.SelectedValue));
                        MessageBox.Show("Дані про клітку успішно оновлені");
                        Close();
                    }                  
                }
                else
                {
                    if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cageTableAdapter.InsertQuery(Convert.ToInt32(cage_idTextBox.Text), Convert.ToInt32(max_count_of_animalTextBox.Text), Convert.ToInt32(comboBox1.SelectedValue));
                        MessageBox.Show("Нова клітка успішно додана!");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Перевірте первинний та зовнішні ключі!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
