using Tyuiu.AbramushkinAN.Sprint4.Task2.V10.Lib;

namespace Tyuiu.AbramushkinAN.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = {5,3,4,1,2,8,5,4};
            int result = ds.Calculate(numsArray);
            int wait = 75;
            Assert.AreEqual(wait, result);
        }
    }
}