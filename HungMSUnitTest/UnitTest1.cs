using HungNUnit;

namespace HungMSUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMSCong()
        {
            TinhToan tinhToan = new TinhToan();
            int result = tinhToan.Cong(15, 5);
            int expexted = 20;
            Assert.AreEqual(expexted, result);
        }

        [TestMethod]
        public void TestMSTru()
        {
            TinhToan tinhToan = new TinhToan();
            int result = tinhToan.Tru(15, 5);
            int expexted = 10;
            Assert.AreEqual(expexted, result);
        }
    }
}