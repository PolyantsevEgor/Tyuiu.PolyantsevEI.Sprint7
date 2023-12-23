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
using Tyuiu.PolyantsevEI.Sprint7.Project.V14.Lib;

namespace Tyuiu.PolyantsevEI.Sprint7.Project.V14
{
    public partial class FormRed : Form
    {
        public FormRed()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        static string path;
        static string[,] matrix;
        static int rows;
        static int columns;

        private void buttonDelete_PEI_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog_PEI.ShowDialog();
            path = openFileDialog_PEI.FileName;
            matrix = ds.GetMatrix(path);

            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);

            dataGridMatrix_PEI.RowCount = rows + 1;
            dataGridMatrix_PEI.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridMatrix_PEI.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            dataGridMatrix_PEI.AutoResizeColumns();
            dataGridMatrix_PEI.ScrollBars = ScrollBars.Both;
        }
    }
}
