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

            for (int i = 0; i < variables; i++) 
            {
                var Column = new DataGridViewTextBoxColumn();
                Column.HeaderText = String.Format("X{0}",i);
                mainDataGridView.Columns.Add(Column);
            }
            var conditions = new DataGridViewTextBoxColumn();
            conditions.HeaderText = String.Format("conditions");
            mainDataGridView.Columns.Add(conditions);
            var values = new DataGridViewTextBoxColumn();
            values.HeaderText = String.Format("values");
            mainDataGridView.Columns.Add(values);


            
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
                mainDataGridView.Rows[i].Cells[variables] = dcombo;
            }
            /*var StringMas = new String[variables+2];*/
            

            /*DataGridViewTextBoxColumn idColumn =
            new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idColumn.Resizable = DataGridViewTriState.False;
            idColumn.ReadOnly = true;
            idColumn.Width = 20;

            DataGridViewTextBoxColumn titleColumn =
                new DataGridViewTextBoxColumn();
            titleColumn.HeaderText = "Title";
            titleColumn.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            mainDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewTextBoxColumn subTitleColumn =
                new DataGridViewTextBoxColumn();
            subTitleColumn.HeaderText = "Subtitle";
            subTitleColumn.MinimumWidth = 50;
            subTitleColumn.FillWeight = 100;

            DataGridViewTextBoxColumn summaryColumn =
            new DataGridViewTextBoxColumn();
            summaryColumn.HeaderText = "Summary";
            summaryColumn.MinimumWidth = 50;
            summaryColumn.FillWeight = 200;

            DataGridViewTextBoxColumn contentColumn =
                new DataGridViewTextBoxColumn();
            contentColumn.HeaderText = "Content";
            contentColumn.MinimumWidth = 50;
            contentColumn.FillWeight = 300;

            mainDataGridView.Columns.AddRange(new DataGridViewTextBoxColumn[] {
            idColumn, titleColumn, subTitleColumn,
            summaryColumn, contentColumn });
            mainDataGridView.Rows.Add(new String[] { "1" });
            mainDataGridView.Rows[0].HeaderCell.Value = "12";

            try
            {
                DataGridViewComboBoxCell dcombo = new DataGridViewComboBoxCell();
                dcombo.Items.Add("A");
                dcombo.Items.Add("B");
                dcombo.Items.Add("C");
                mainDataGridView.Rows[0].Cells[2] = dcombo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }*/
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
