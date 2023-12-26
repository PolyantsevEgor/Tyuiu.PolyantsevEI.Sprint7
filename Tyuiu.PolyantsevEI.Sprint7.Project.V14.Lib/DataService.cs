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

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToString(line_r[c]);
                }
            }

            return matrix;
        }

        public int GetCount(string[,] matrix)
        {
            int n = matrix.GetLength(0)-1;
            return n;
        }
        public int GetACount(string[,] matrix)
        {
            int n = matrix.GetLength(0);
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, 1] == "Автобус") k++;
            }
            return k;
        }
        public int GetMCount(string[,] matrix)
        {
            int n = matrix.GetLength(0);
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, 1] == "Маршрутное такси") k++;
            }
            return k;
        }
        public double GetMaxS(string[,] matrix)
        {
            int n = matrix.GetLength(0);
            double max = -1;
            for (int i = 1; i < n; i++)
            {
                if (Convert.ToDouble(matrix[i, 5]) > max) max = Convert.ToDouble(matrix[i, 5]);
            }
            return max;
        }
        public double GetMinS(string[,] matrix)
        {
            int n = matrix.GetLength(0);
            double min = 9999999;
            for (int i = 1; i < n; i++)
            {
                if (Convert.ToDouble(matrix[i, 5]) < min) min = Convert.ToDouble(matrix[i, 5]);
            }
            return min;
        }
        public double GetSrS(string[,] matrix)
        {
            int n = matrix.GetLength(0);
            double s = 0;
            for (int i = 1; i < n; i++)
            {
                s += Convert.ToDouble(matrix[i, 5]);
            }
            return Math.Round(s/(n-1), 2);
        }
        public int GetNSBO(string[,] matrix)
        {
            int n = matrix.GetLength(0);
            int k = 0;
            for (int i = 1; i < n; i++)
            {
                if (matrix[i, 6] == "да") k++;
            }
            return k;
        }
        public int GetNSAOO(string[,] matrix)
        {
            int n = matrix.GetLength(0);
            int k = 0;
            for (int i = 1; i < n; i++)
            {
                if (matrix[i, 7] == "да") k++;
            }
            return k;
        }
    }
}
