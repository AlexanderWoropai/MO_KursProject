using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            if (variablesTextBox.Text == "" || rulesTextBox.Text == "") 
            { 
                MessageBox.Show("Введите ограничения!"); 
                return; 
            }
            var variables = Convert.ToInt32(variablesTextBox.Text);
            var rules = Convert.ToInt32(rulesTextBox.Text);
            var newForm = new Form2(variables, rules);
            newForm.Show();
            Hide();
        }
    }
}
