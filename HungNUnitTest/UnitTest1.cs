using HungNUnit;
using System.Reflection.Metadata;
using System;

namespace HungNUnitTest
{
    [TestFixture]
    public class TinhToanTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CongTest()
        {
            TinhToan tinhToan = new TinhToan();
            int result = tinhToan.Cong(15, 5);
            int expexted = 20;
            Assert.That(expexted, Is.EqualTo(result));
        }

        [Test]
        public void TruTest()
        {
            TinhToan tinhToan = new TinhToan();
            int result = tinhToan.Tru(15, 5);
            int expexted = 10;
            Assert.That(expexted, Is.EqualTo(result));
        }

        [Test]
        public void NhanTest()
        {
            TinhToan tinhToan = new TinhToan();
            float result = tinhToan.Nhan(15, 5);
            float expexted = 75;
            Assert.That(expexted, Is.EqualTo(result));
        }

        [Test]
        public void ChiaTest()
        {
            TinhToan tinhToan = new TinhToan();
            float result = tinhToan.Chia(15, 5);
            float expexted = 3;
            Assert.That(expexted, Is.EqualTo(result));
        }

        [Test]
        public void TimSoLonNhatTrongMangTest()
        {
            int[] abc = { 5, 7, 9, 21 };
            TinhToan tinhToan = new TinhToan();
            int result = tinhToan.TimSoLonNhatTrongMang(abc);
            int expexted = 21;
            Assert.That(expexted, Is.EqualTo(result));
        }
    }
}

/*
Exception is the base class for all exceptions. 
ArgumentException is used to say that a parameter is not valid.
It subclasses from Exception.
With catch, you can actually filter base on: 
the type of the exception 
and handle each one differently.
*/