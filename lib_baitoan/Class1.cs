using System;
using System.Collections.Generic;
using System.Text;

namespace lib_baitoan
{
    public class Class1
    {
    
        // Tính độ dài đường sinh
        public static double TinhDuongSinh(double r, double h)
        {
            return Math.Sqrt(r * r + h * h);
        }

        // Tính diện tích đáy
        public static double TinhDienTichDay(double r)
        {
            return Math.PI * r * r;
        }

        // Tính diện tích xung quanh
        public static double TinhDienTichXungQuanh(double r, double l)
        {
            return Math.PI * r * l;
        }

        // Tính diện tích toàn phần
        public static double TinhDienTichToanPhan(double r, double h)
        {
            double l = TinhDuongSinh(r, h);
            double dienTichDay = TinhDienTichDay(r);
            double dienTichXungQuanh = TinhDienTichXungQuanh(r, l);
            return dienTichDay + dienTichXungQuanh;
        }
    }
}
  
