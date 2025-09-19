using Tyuiu.AroyanAV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AroyanAV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Армине";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Армине", res);
        }
    }
}
