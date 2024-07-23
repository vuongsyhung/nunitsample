using HungNUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungNUnitTest
{
    public class TestLapLai
    {
        public TinhToan tinhToan;

        // Thuoc tinh [SetUp] dung de tao doi tuong tinhtoan dung chung cho ca class 
        [SetUp]
        public void SetUp()
        {
            tinhToan = new TinhToan();
        }

        // Thuoc tinh [TearDown] dung de giai phong cac tai nguyen da bi chiem dung boi tinhtoan
        [TearDown]
        public void TearDown() 
        {
            tinhToan = null;
        }

        // Cach 1:  Dung thuoc tinh [TestCase(3, 4, 7)]
        // Thuc hien kiem thu phuong thuc Cong trong class TinhToan
        // Thuc hien lap lai mhieu lan voi nhieu bo gia tri khac nhau
        // Su dung thuoc tinh [TestCase]
        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(3, 7, 10)]
        [TestCase(11, 2, 13)]
        public void CongTestLapLai(int x, int y, int expected)
        {
            int result = tinhToan.Cong(x, y);
            Assert.That(result, Is.EqualTo(expected));
        }

        // Cach 2: Dung thuoc tinh [TestCaseSource]
        [Test]
        [TestCaseSource(nameof(BoDuLieuTestData))]        
        public void CongTestLapLaiTestCaseSource(int x, int y, int expected) 
        {
            int result = tinhToan.Cong(x, y);
            Assert.That(result, Is.EqualTo(expected));
        }

        // Tao nguon du lieu dung chung
        public static Object[] BoDuLieuTestData = new Object[]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 9 },
            new int[] { 10, 11, 21 }
        };
    }
}
