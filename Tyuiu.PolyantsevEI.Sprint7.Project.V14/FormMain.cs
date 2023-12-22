﻿using System;
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


        private void buttonDone_Click(object sender, EventArgs e)
        {
            string[,] matrix = ds.GetMatrix(path);
            
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0;j < matrix.GetLength(1); j++)
                {
                    comboBoxNum_PEI.Items.Add(matrix[i,0]);
                    comboBoxNum_PEI.Items.Add("test");
                }
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
            openFileDialog_PEI.ShowDialog();
            path = openFileDialog_PEI.FileName;
            buttonDone_PEI.Enabled = true;
        }
        
        private void buttonRed_Click(object sender, EventArgs e)
        {

        }
    }
}
