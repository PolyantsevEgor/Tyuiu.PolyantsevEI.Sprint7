using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.PolyantsevEI.Sprint7.Project.V14.Lib;

namespace Tyuiu.PolyantsevEI.Sprint7.Project.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        static string path;
        static string[,] matrix;
        static string[] nums = { };


        private void buttonDone_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            textBoxNum_PEI.Visible = true;
            textBoxStartName_PEI.Visible = true;
            textBoxStopName_PEI.Visible = true;
            try
            {
                int k = comboBoxNum_PEI.SelectedIndex + 1;

                textBoxNum_PEI.Text = Convert.ToString(matrix[k, 0]);
                textBoxStartName_PEI.Text = Convert.ToString(matrix[k, 3]);
                textBoxStopName_PEI.Text = Convert.ToString(matrix[k, 4]);
                textBoxType_PEI.Text = Convert.ToString(matrix[k, 1]);
                textBoxNSBO_PEI.Text = Convert.ToString(matrix[k, 6]);
                textBoxNSOO_PEI.Text = Convert.ToString(matrix[k, 7]);
                textBoxS_PEI.Text = Convert.ToString(matrix[k, 5] + " км");
                textBoxDate_PEI.Text = Convert.ToString(matrix[k, 8]);
                textBoxUr_PEI.Text = Convert.ToString(matrix[k, 9]);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStopName_PEI_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_PEI.ShowDialog();
                path = openFileDialog_PEI.FileName;

                matrix = ds.GetMatrix(path);

                for (int i = 1; i < matrix.GetLength(0) - 1; i++)
                {
                    comboBoxNum_PEI.Items.Add(Convert.ToString(matrix[i, 0]));
                    nums.Append(Convert.ToString(matrix[i, 0]));
                }
                buttonDone_PEI.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void buttonRed_Click(object sender, EventArgs e)
        {
            FormRed formred = new FormRed();
            formred.ShowDialog();
        }
        
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInfo forminfo = new FormInfo();
            forminfo.ShowDialog();
        }

        private void groupBoxOut_PEI_Enter(object sender, EventArgs e)
        {

        }
    }
}
