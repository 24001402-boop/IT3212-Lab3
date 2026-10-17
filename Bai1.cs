
using System;

namespace Lab03_OOPAdvanced
{
    public class Bai1
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 1: KẾ THỪA ===");

            SinhVien sv = new SinhVien(
                "24001402",
                "Nguyễn Trung Quân",
                new DateTime(2006, 1, 12),
                8.2
            );

            sv.HienThi();
        }
    }
}
