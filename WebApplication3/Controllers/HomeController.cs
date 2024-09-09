using Microsoft.AspNetCore.Mvc;
using lib_baitoan;  // Sử dụng thư viện bạn đã tạo

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        // Phương thức để render trang index
        public IActionResult Index()
        {
            return View();
        }

        // Phương thức để xử lý tính toán và trả kết quả
        [HttpPost]
        public JsonResult TinhDienTich([FromBody] HinhNonInput input)
        {
            if (input.Radius <= 0 || input.Height <= 0)
            {
                return Json(new { error = "Bán kính và chiều cao phải lớn hơn 0." });
            }

            double l = Class1.TinhDuongSinh(input.Radius, input.Height);
            double dienTichDay = Class1.TinhDienTichDay(input.Radius);
            double dienTichXungQuanh = Class1.TinhDienTichXungQuanh(input.Radius, l);
            double dienTichToanPhan = Class1.TinhDienTichToanPhan(input.Radius, input.Height);

            return Json(new
            {
                l = l.ToString("0.00"),
                dienTichDay = dienTichDay.ToString("0.00"),
                dienTichXungQuanh = dienTichXungQuanh.ToString("0.00"),
                dienTichToanPhan = dienTichToanPhan.ToString("0.00")
            });
        }
    }

    public class HinhNonInput
    {
        public double Radius { get; set; }
        public double Height { get; set; }
    }
}
