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
    public partial class CreateFormForAnimal : Form
    {
        private bool edit = false;
        public int idForSelect = 0;
        public CreateFormForAnimal(int id)
        {
            InitializeComponent();
            var items = SqlCommandForAdmin.SelectorForCageInAnimalCreate();
            foreach (var item in items)
            {
                comboBox1.Items.Add(item);
            }
            animal_idTextBox.Text = id.ToString();
        }
        public CreateFormForAnimal(int animal_id, string animalName, int age, 
            int weightOfAnimal, DateTime dateOfAdd, string sex, int groupOfAnimalId,
            int cageId, double caloriesPerDay, string health) : this(animal_id)
        {
            animalTableAdapter.Fill(zooDataSet.Animal);
            animal_nameTextBox.Text = animalName;
            animal_idTextBox.Text = animal_id.ToString();
            ageTextBox.Text = age.ToString();
            weight_of_animalTextBox.Text = weightOfAnimal.ToString();
            date_addDateTimePicker.Value = dateOfAdd;
            comboBox2.Text = sex.ToString();
            group_of_animal_idCombo.SelectedValue = groupOfAnimalId;
            /*group_of_animal_idCombo.SelectedItem = SqlCommandForAdmin.SelectorForNameGroup(groupOfAnimalId);*/
            comboBox1.SelectedItem = cageId;
            calories_per_dayTextBox.Text = caloriesPerDay.ToString();
            comboBoxHealth.Text = health;
            comboBox1.Items.Clear();
            edit = true;
            var items = SqlCommandForAdmin.SelectorForCageInAnimalEdit(groupOfAnimalId);
            foreach (var item in items)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.Text = cageId.ToString();
        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);

        }

        private void animalBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);

        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet1.Animal". При необходимости она может быть перемещена или удалена.
            this.animalTableAdapter.Fill(this.zooDataSet1.Animal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet3.Cage". При необходимости она может быть перемещена или удалена.
            this.cageTableAdapter.Fill(this.zooDataSet3.Cage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet1.GroupOfAnimal". При необходимости она может быть перемещена или удалена.
            this.groupOfAnimalTableAdapter.Fill(this.zooDataSet1.GroupOfAnimal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (edit)
                    {
                        animalTableAdapter.UpdateQuery(Convert.ToInt32(animal_idTextBox.Text), animal_nameTextBox.Text, Convert.ToInt32(ageTextBox.Text),
                        Convert.ToInt32(weight_of_animalTextBox.Text), date_addDateTimePicker.Value.ToString(), comboBox2.Text.ToString(),
                        Convert.ToInt32(group_of_animal_idCombo.SelectedValue), Convert.ToInt32(comboBox1.Text),
                        Convert.ToDouble(calories_per_dayTextBox.Text), comboBoxHealth.Text);
                        MessageBox.Show("Дані про тварину успішно оновлені!");
                        Close();

                    }
                    else
                    {
                        animalTableAdapter.InsertQuery(Convert.ToInt32(animal_idTextBox.Text), animal_nameTextBox.Text, Convert.ToInt32(ageTextBox.Text),
                        Convert.ToInt32(weight_of_animalTextBox.Text), date_addDateTimePicker.Value.ToString(), comboBox2.Text.ToString(),
                        Convert.ToInt32(group_of_animal_idCombo.SelectedValue), Convert.ToInt32(comboBox1.Text),
                        Convert.ToDouble(calories_per_dayTextBox.Text), comboBoxHealth.Text);
                        MessageBox.Show("Нова тварина успішно додана!");
                        idForSelect = Convert.ToInt32(animal_idTextBox.Text);
                        Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Перевірте первинний та зовнішні ключі!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void group_of_animal_idCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = SqlCommandForAdmin.SelectorForCageInAnimalEdit(Convert.ToInt32(group_of_animal_idCombo.SelectedValue));
            comboBox1.Items.Clear();
            foreach (var item in items)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
