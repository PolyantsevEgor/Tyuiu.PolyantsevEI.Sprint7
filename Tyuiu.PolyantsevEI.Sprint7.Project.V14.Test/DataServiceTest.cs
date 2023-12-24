using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PolyantsevEI.Sprint7.Project.V14.Lib;

namespace Tyuiu.PolyantsevEI.Sprint7.Project.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = $"C:\\Users\\Admin\\source\\repos\\Tyuiu.PolyantsevEI.Sprint7\\Tyuiu.PolyantsevEI.Sprint7.Project.V14\\Properties\\DataBase.csv\\";
            string[,] matrix = ds.GetMatrix(path);
            CollectionAssert.AreEqual(matrix, ds.GetMatrix(path));
        }
    }
}
