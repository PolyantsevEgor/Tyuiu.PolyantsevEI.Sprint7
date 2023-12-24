using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
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
        static int index;

        private void buttonDelete_PEI_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить \nвыбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                index = dataGridMatrix_PEI.CurrentCell.RowIndex;
                dataGridMatrix_PEI.Rows.RemoveAt(index);
            }
        }
        
        private void buttonAdd_PEI_Click(object sender, EventArgs e)
        {
            dataGridMatrix_PEI.Rows.Add();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_PEI.ShowDialog();
                path = openFileDialog_PEI.FileName;
                matrix = ds.GetMatrix(path);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridMatrix_PEI.DataSource = null;
                dataGridMatrix_PEI.Rows.Clear();
                dataGridMatrix_PEI.Refresh();
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

                buttonAdd_PEI.Enabled = true;
                buttonDelete_PEI.Enabled = true;
                buttonSave_PEI.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_PEI_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_PEI.FileName = ".csv";
                saveFileDialog_PEI.InitialDirectory = @":L";
                if (saveFileDialog_PEI.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_PEI.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridMatrix_PEI.RowCount;
                    int columns = dataGridMatrix_PEI.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridMatrix_PEI.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
