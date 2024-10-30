using Tyuiu.AbramushkinAN.Sprint4.Task7.V30.Lib;

namespace Tyuiu.AbramushkinAN.Sprint4.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int n, m;
            n = 5;
            m = 3;
            string value = "684259137159648";
            int res = ds.Calculate(n,m,value);
            int wait = 73728;
            Assert.AreEqual(wait, res);





        }
    }
}