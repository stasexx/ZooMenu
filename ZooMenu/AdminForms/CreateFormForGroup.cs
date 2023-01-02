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
    public partial class CreateFormForGroup : Form
    {
        private bool edit = false;
        public CreateFormForGroup(int id)
        {
            InitializeComponent();
            group_of_animal_idTextBox.Text = id.ToString();
        }
        public CreateFormForGroup(int groupId, string groupName, string foodMethod):this(groupId)
        {
            edit = true;
            group_of_animal_idTextBox.Text = groupId.ToString();
            name_of_groupTextBox.Text = groupName.ToString();
            comboBox1.Text = foodMethod.ToString();
        }

        private void groupOfAnimalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupOfAnimalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);

        }

        private void groupOfAnimalBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.groupOfAnimalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooDataSet);

        }

        private void CreateFormForGroup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zooDataSet.GroupOfAnimal". При необходимости она может быть перемещена или удалена.
            this.groupOfAnimalTableAdapter.Fill(this.zooDataSet.GroupOfAnimal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете додати/змінити дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    groupOfAnimalTableAdapter.UpdateQuery(Convert.ToInt32(group_of_animal_idTextBox.Text), name_of_groupTextBox.Text, comboBox1.Text);
                    MessageBox.Show("Дані про групу тварин успішно оновлені!");
                    Close();
                }
                else
                {
                    groupOfAnimalTableAdapter.InsertQuery(Convert.ToInt32(group_of_animal_idTextBox.Text), name_of_groupTextBox.Text, comboBox1.Text);
                    MessageBox.Show("Дані про групу тварин успішно додані!");
                    Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
