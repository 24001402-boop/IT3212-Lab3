
using System;

namespace Lab03_OOPAdvanced
{
    public class Bai3
    {
        public static void Chay()
        {
            Console.WriteLine(
                "=== BÀI 3: LỚP TRỪU TƯỢNG HỌC PHÍ ===");

            SinhVienChinhQuy sv1 = new SinhVienChinhQuy
            {
                HoTen = "Nguyễn Trung Quân",
                SoTinChi = 18
            };

            SinhVienLienThong sv2 = new SinhVienLienThong
            {
                HoTen = "Trần Văn Bình",
                SoTinChi = 15
            };

            Console.WriteLine("\n1. Sinh viên chính quy:");
            Console.WriteLine("Họ tên: " + sv1.HoTen);
            Console.WriteLine("Số tín chỉ: " + sv1.SoTinChi);
            Console.WriteLine("Học phí: " +
                sv1.TinhHocPhi().ToString("N0") + " VNĐ");

            Console.WriteLine("\n2. Sinh viên liên thông:");
            Console.WriteLine("Họ tên: " + sv2.HoTen);
            Console.WriteLine("Số tín chỉ: " + sv2.SoTinChi);
            Console.WriteLine("Học phí: " +
                sv2.TinhHocPhi().ToString("N0") + " VNĐ");
        }
    }
}
