using System;
using System.Collections.Generic;
using System.Text;

namespace baitapvenha
{
    internal class Program
    //Họ Tên : Cao Đức Thành
    //Bắt Đầu làm bài toán
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

                // Tính độ dài đường sinh l
                double l = Math.Sqrt(r * r + h * h);

                // Tính diện tích đáy
                double dienTichDay = Math.PI * r * r;

                // Tính diện tích xung quanh
                double dienTichXungQuanh = Math.PI * r * l;

                // Tính diện tích toàn phần
                double dienTichToanPhan = dienTichDay + dienTichXungQuanh;

                // Hiển thị kết quả
                Console.WriteLine("Đo dai duong sinh l: " + l + " cm");
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
