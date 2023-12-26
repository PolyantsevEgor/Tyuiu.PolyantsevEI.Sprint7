using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.PolyantsevEI.Sprint7.Project.V14.Lib;

namespace Tyuiu.PolyantsevEI.Sprint7.Project.V14
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        static string path;
        static string[,] matrix;

        private void buttonOpen_PEI_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_PEI.ShowDialog();
                path = openFileDialog_PEI.FileName;
                matrix = ds.GetMatrix(path);

                labelACount_PEI.Visible = true;
                labelMCount_PEI.Visible = true;
                labelCount_PEI.Visible = true;
                labelMaxS_PEI.Visible = true;
                labelMinS_PEI.Visible = true;
                labelSrS_PEI.Visible = true;
                labelNSBOCount_PEI.Visible = true;
                labelNSAOOCount_PEI.Visible = true;

                textBoxACount_PEI.Text = Convert.ToString(ds.GetACount(matrix));
                textBoxMCount_PEI.Text = Convert.ToString(ds.GetMCount(matrix));
                textBox_PEI.Text = Convert.ToString(ds.GetCount(matrix));
                textBoxMaxS_PEI.Text = Convert.ToString(ds.GetMaxS(matrix));
                textBoxMinS_PEI.Text = Convert.ToString(ds.GetMinS(matrix));
                textBoxSrS_PEI.Text = Convert.ToString(ds.GetSrS(matrix));
                textBoxNSBOCount_PEI.Text = Convert.ToString(ds.GetNSBO(matrix));
                textBoxNSAOOCount_PEI.Text = Convert.ToString(ds.GetNSAOO(matrix));

                string[] seriesArray = { "Автобусы", "Маршрутки" };
                int[] pointsArray = {ds.GetACount(matrix), ds.GetMCount(matrix)};
                chartMA_PEI.Series.Clear();


                for (int i = 0; i < seriesArray.Length; i++)
                {
                    Series series = this.chartMA_PEI.Series.Add(seriesArray[i]);
                    series.Points.Add(pointsArray[i]);
                }
            }

            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
