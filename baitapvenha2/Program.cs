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
                Console.Write("Nhap ban kinh r (đơn vi cm): ");
                double r = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhap chieu cao h (đơn vi cm): ");
                double h = Convert.ToDouble(Console.ReadLine());

                // Tính toán sử dụng thư viện lib_baitoan
                double l = Class1.TinhDuongSinh(r, h);
                double dienTichDay = Class1.TinhDienTichDay(r);
                double dienTichXungQuanh = Class1.TinhDienTichXungQuanh(r, l);
                double dienTichToanPhan = Class1.TinhDienTichToanPhan(r, h);

                // Hiển thị kết quả
                Console.WriteLine("Do dai đưong sinh l: " + l + " cm");
                Console.WriteLine("Dien tich đay: " + dienTichDay + " cm²");
                Console.WriteLine("Dien tich xung quanh: " + dienTichXungQuanh + " cm²");
                Console.WriteLine("Dien tich toan phan: " + dienTichToanPhan + " cm²");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui lòng nhập số hợp lệ.");
                
            }
            Console.ReadLine();
        }
    }
}
