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
        public void ValidGet()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Admin\source\repos\Tyuiu.PolyantsevEI.Sprint7\Tyuiu.PolyantsevEI.Sprint7.Project.V14\Properties\DataBase.csv";
            string[,] matrix = ds.GetMatrix(path);
            CollectionAssert.AreEqual(matrix, ds.GetMatrix(path));
            Assert.AreEqual(68, ds.GetACount(matrix));
            Assert.AreEqual(27, ds.GetMCount(matrix));
            Assert.AreEqual(95, ds.GetCount(matrix));
            Assert.AreEqual(68.38, ds.GetMaxS(matrix));
            Assert.AreEqual(9.8, ds.GetMinS(matrix));
            Assert.AreEqual(36.17, ds.GetSrS(matrix));
            Assert.AreEqual(79, ds.GetNSBO(matrix));
            Assert.AreEqual(68, ds.GetNSAOO(matrix));

        }
    }
}
