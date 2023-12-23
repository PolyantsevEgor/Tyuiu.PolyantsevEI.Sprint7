using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PolyantsevEI.Sprint7.Project.V14.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] matrix = new string[rows, columns];

            for (int r = 0; r < rows - 1; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToString(line_r[c]);
                }
            }

            return matrix;

            //string fileData = File.ReadAllText(path);
            //List<string> lines = File.ReadAllLines(path).ToList();

            //File.WriteAllLines(path, lines);
            //fileData = fileData.Replace('\n', '\r');
            //string[] liness = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //int rows = liness.Length;
            //int columns = liness[0].Split(';').Length;
            //string[,] arrayValues = new string[rows, columns];
            //for (int r = 0; r < rows-1; r++)
            //{
            //    string[] line_r = lines[r].Split(';');
            //    for (int c = 0; c < columns; c++)
            //    {
            //        arrayValues[r, c] = (line_r[c]);
            //    }
            //}
            //return arrayValues;
        }
    }
}
