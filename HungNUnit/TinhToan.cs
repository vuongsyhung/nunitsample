using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungNUnit
{
    public class TinhToan
    {
        public int Cong(int a, int b) => (a+ b);
        public int Tru(int a, int b) => (a - b);

        public float Nhan(float a, float b)
        {
            float result = a * b;
            return result;
        }

        public float Chia(float a, float b)
        {
            if (b == 0)
            {
                // Ngoai le trong test case phai giong kieu ngoai le nay
                throw new DivideByZeroException("Divide by zero");            
            }

            float result = a / b;
            return result;
        }

        public float ChiaNgoaiLeThamSo(float a, float b)  
        {
            if (b == 0)
            {
                // Ngoai le trong test case phai giong kieu ngoai le nay
                throw new ArgumentException();
            }

            float result = a / b;
            return result;
        }

        public float ChiaTestNgoaiLe(float a, float b)
        {
            if (b == 0)
            {
                // Ngoai le trong test case phai giong kieu ngoai le nay
                throw new Exception();
            }

            float result = a / b;
            return result;
        }

        public int TimSoLonNhatTrongMang(int[] arrs)
        {
            int SoLonNhat = int.MinValue;

            for (int i = 0; i < arrs.Length; i++)
            {
                if (SoLonNhat < arrs[i])
                {
                    SoLonNhat = arrs[i];
                }
            }
            return SoLonNhat;
        }
    }
}
