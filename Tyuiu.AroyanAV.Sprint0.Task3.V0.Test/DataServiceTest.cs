using Tyuiu.AroyanAV.Sprint0.Task3.V0.Lib;

namespace Tyuiu.AroyanAV.Sprint0.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedVaild()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5)); 
        }
    }
}
