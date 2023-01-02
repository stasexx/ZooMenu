using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooMenu.Report;
using ZooMenu.Stats;

namespace ZooMenu
{
    public partial class HomeForm : Form
    {
        bool rule = false;
        public HomeForm()
        {
            InitializeComponent();
            if(Program.adminRules == true)
            {
                rule = true;
            }
            if (rule != true)
            {
                pictureBoxAdmin.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(rule == true)
            {
                AdminForm adminForm = new AdminForm();
                Hide();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Ви немаєте доступу до цього розділу!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Statistics stats = new Statistics();
            stats.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBoxForPassword.Text == SqlCommandForAdmin.password)
            {
                Program.adminRules = true;
                rule = true;
                pictureBoxAdmin.Show();
                MessageBox.Show("Права адміністратора активовано!");
                textBoxForPassword.Clear();
            }
            else
            {
                MessageBox.Show("Невірний ключ!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rule = false;
            Program.adminRules = false;
            pictureBoxAdmin.Hide();
            MessageBox.Show("Права адміністратора деактивовано!");
        }
    }
}
