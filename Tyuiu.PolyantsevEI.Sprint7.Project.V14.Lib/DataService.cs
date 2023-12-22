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
            int n = 0, m = 0;
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    n = values.Length;

                    m++;
                }
            }
            string[,] matrix = new string[n, m];
            using (var reader = new StreamReader(path))
            {
                int i = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    for (int j = 0; j < values.Length; j++)
                        matrix[i, j] = values[j];
                }
            }

            return matrix;
        }
    }
}
