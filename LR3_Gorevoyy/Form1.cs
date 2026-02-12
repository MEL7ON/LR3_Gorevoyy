using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LR3_Gorevoyy.ModelEF;

namespace LR3_Gorevoyy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1 model = new Model1();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = model.Users.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddUsers formAddUsers = new FormAddUsers();
            formAddUsers.ShowDialog();
            dataGridView1.DataSource = model.Users.ToList() ;
        }
    }
}
