using System;
using System.Security.Policy;
using lib_baitoan;  // Thêm namespace của thư viện DLL

namespace ConsoleAppUsingLibBaiToan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Nhập bán kính và chiều cao
                Console.Write("Nhập bán kính r (đơn vị cm): ");
                double r = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhập chiều cao h (đơn vị cm): ");
                double h = Convert.ToDouble(Console.ReadLine());

                // Tính toán sử dụng thư viện lib_baitoan
                double l = Class1.TinhDuongSinh(r, h);
                double dienTichDay = Class1.TinhDienTichDay(r);
                double dienTichXungQuanh = Class1.TinhDienTichXungQuanh(r, l);
                double dienTichToanPhan = Class1.TinhDienTichToanPhan(r, h);

                // Hiển thị kết quả
                Console.WriteLine("Độ dài đường sinh l: " + l + " cm");
                Console.WriteLine("Diện tích đáy: " + dienTichDay + " cm²");
                Console.WriteLine("Diện tích xung quanh: " + dienTichXungQuanh + " cm²");
                Console.WriteLine("Diện tích toàn phần: " + dienTichToanPhan + " cm²");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui lòng nhập số hợp lệ.");
                
            }
            Console.ReadLine();
        }
    }
}
