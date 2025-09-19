using Tyuiu.AroyanAV.Sprint0.Task4.V0.Lib;

namespace Tyuiu.AroyanAV.Sprint0.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChekedAddition()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void ChekedSubtractionVaild()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void ChekedMultipplicationVaild()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void ChekedDivisionVaild()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
