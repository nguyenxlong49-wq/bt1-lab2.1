using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace bt1_lab2._1
{
    internal class Program
    {
        class NotNegativeException : Exception
        {
            public NotNegativeException() : base("Gia tri duoi dau can < 0")
            {
            }
            public NotNegativeException(string message) : base(message)
            {
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap x:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap y:");
                int y = int.Parse(Console.ReadLine());
                int mau = 2 * x - y;
                if(mau==0)
                {
                    throw new DivideByZeroException("Mau so khong duoc bang 0");
                }
                double bieuThuc = (x + y) / mau;
                if(bieuThuc < 0)
                {
                    throw new NotNegativeException();
                }
                double H = Math.Sqrt(bieuThuc);
                Console.WriteLine($"Ket qua H = {H}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Loi : {ex.Message}");
            }
            catch (NotNegativeException ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi khong xac dinh: {ex.Message}");
            }
        }
    }
}
