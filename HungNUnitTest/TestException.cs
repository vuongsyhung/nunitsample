using HungNUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungNUnitTest
{
    [TestFixture]
    public class TestException
    {
            [Test]
            public void ChiaKhongTest()
            {
                TinhToan tinhToan = new TinhToan();
                // Ngoai le trong test case phai giong kieu ngoai le trong ham goc
                Assert.Throws(typeof(DivideByZeroException), () => tinhToan.Chia(17, 0));
            }

            [Test]
            public void ChiaKhongTestThamSoNgoaiLe()
            {
                TinhToan tinhToan = new TinhToan();
                // Tham số ngoại lệ 
                // Ngoai le trong test case phai giong kieu ngoai le trong ham goc
                Assert.Throws<ArgumentException>(() => tinhToan.ChiaNgoaiLeThamSo(15, 0));
            }

            [Test]
            public void ChiaKhongTestThamSoNgoaiLeTryCatch()
            {
                TinhToan tinhToan = new TinhToan();
                try
                {
                    tinhToan.ChiaNgoaiLeThamSo(12, 0);
                    Assert.Fail("Divide by zero");
                }
                catch (Exception ex)
                {
                    // Ngoai le trong test case phai giong kieu ngoai le trong ham goc
                    Assert.That(ex, Is.InstanceOf<ArgumentException>());
                }
            }

            [Test]
            public void ChiaKhongTestNgoaiLeTryCatch()
            {
                TinhToan tinhToan = new TinhToan();
                try
                {
                    tinhToan.ChiaTestNgoaiLe(12, 0);
                    Assert.Fail("Divide by zero");
                }
                catch (Exception ex)
                {
                    // Ngoai le trong test case phai giong kieu ngoai le trong ham goc
                    Assert.That(ex, Is.InstanceOf<Exception>());
                }
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