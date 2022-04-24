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
    public partial class Form2 : Form
    {
        int variables;
        int rules;

        public Form2(int variables, int rules)
        {
            InitializeComponent();
            this.variables = variables;
            this.rules = rules;

            var values = new DataGridViewTextBoxColumn();
            values.HeaderText = String.Format("Значения");
            mainDataGridView.Columns.Add(values);
            var conditions = new DataGridViewTextBoxColumn();
            conditions.HeaderText = String.Format("Условия");
            mainDataGridView.Columns.Add(conditions);
            for (int i = 0; i < variables; i++) 
            {
                var Column = new DataGridViewTextBoxColumn();
                Column.HeaderText = String.Format("X{0}",i+1);
                mainDataGridView.Columns.Add(Column);
            }
            
            var MasINT = new int[variables + 2];
            var MasSTRING = new string[variables + 2];
            for (int i = 0; i < MasINT.Length; i++) 
            {
                MasSTRING[i] = MasINT[i].ToString();
            }
            for (int i = 0; i < rules; i++) 
            {
                var dcombo = new DataGridViewComboBoxCell();
                dcombo.Items.Add("=");
                dcombo.Items.Add(">=");
                dcombo.Items.Add("=<");
                mainDataGridView.Rows.Add(MasSTRING);
                mainDataGridView.Rows[i].HeaderCell.Value = (i+1).ToString();
                mainDataGridView.Rows[i].Cells[1] = dcombo;
            }
            var comboBox = new DataGridViewComboBoxCell();
            comboBox.Items.Add("=");
            comboBox.Items.Add(">=");
            comboBox.Items.Add("=<");
            mainDataGridView.Rows.Add(MasSTRING);
            mainDataGridView.Rows[mainDataGridView.Rows.Count - 2].HeaderCell.Value = "-Z";
            mainDataGridView.Rows[mainDataGridView.Rows.Count - 2].Cells[1] = comboBox;
            mainDataGridView.RowHeadersWidth = 70;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var mas = new double[rules+1, variables+1];
            var MasList = new List<List<double>>();
            for (int i = 0; i < mainDataGridView.Rows.Count-1; i++) 
            {
                var doubleList = new List<double>();
                for (int j = 0; j < mainDataGridView.Columns.Count; j++) 
                {   
                    if (j == 1) { continue; }
                    doubleList.Add(Convert.ToDouble(mainDataGridView[j, i].Value));
                }
                MasList.Add(doubleList);
            }
            for (int i = 0; i < MasList.Count; i++) 
            {
                for (int j = 0; j < MasList[i].Count; j++) 
                {
                    mas[i, j] = MasList[i][j];
                }
            }
            Simplex S = new Simplex(mas);

            double[,] table_result;
            double[] result = new double[variables];
            table_result = S.Calculate(result);
            string res = "";
            for (int i =0; i<result.Length; i++)  
            {
                res += String.Format("X{0} = {1} \r\n", i, (int)result[i]);  
            }

            resultTextBox.Text = res;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
