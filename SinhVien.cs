
using System;

namespace Lab03_OOPAdvanced
{
    public class SinhVien : Nguoi, IValidatable, IPrintable
    {
        public string MaSV { get; set; }
        public double DiemTB { get; set; }

        public SinhVien(string ma, string ten,
                        DateTime ngaySinh, double diem)
            : base(ten, ngaySinh)
        {
            MaSV = ma;
            DiemTB = diem;
        }

        // Bài 1: Hiển thị thông tin
        public void HienThi()
        {
            Console.WriteLine("Mã SV: " + MaSV);
            Console.WriteLine("Họ tên: " + HoTen);
            Console.WriteLine("Ngày sinh: " +
                NgaySinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("Điểm TB: " + DiemTB);
        }

        // Bài 2: Ghi đè phương thức
        public override string MoTa()
        {
            return base.MoTa() + " - " +
                   MaSV + " - " + DiemTB.ToString("N2");
        }

        // Bài 4: Kiểm tra dữ liệu
        public bool IsValid(out string message)
        {
            if (string.IsNullOrWhiteSpace(MaSV))
            {
                message = "Thiếu mã sinh viên";
                return false;
            }

            if (string.IsNullOrWhiteSpace(HoTen))
            {
                message = "Thiếu họ tên";
                return false;
            }

            if (double.IsNaN(DiemTB) ||
                double.IsInfinity(DiemTB) ||
                DiemTB < 0 || DiemTB > 10)
            {
                message = "Điểm trung bình không hợp lệ";
                return false;
            }

            message = "Dữ liệu hợp lệ";
            return true;
        }

        // Bài 4: Xuất dữ liệu
        public string ToDisplayText()
        {
            return MaSV + " - " + HoTen +
                   " - Điểm TB: " + DiemTB;
        }
    }
}
