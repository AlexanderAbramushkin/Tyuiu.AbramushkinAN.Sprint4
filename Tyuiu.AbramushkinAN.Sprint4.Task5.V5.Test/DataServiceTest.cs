using Tyuiu.AbramushkinAN.Sprint4.Task5.V5.Lib;

namespace Tyuiu.AbramushkinAN.Sprint4.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            
            int[,] matrix = new int[3,3] { { 1, -5, 3 }, 
                                           { 2, -5, 4 }, 
                                           { 3, -5, 5 } };
            int res = ds.Calculate(matrix);
            int wait = 18;

            Assert.AreEqual(wait, res);

        }
    }
}