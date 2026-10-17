
using System;

namespace Lab03_OOPAdvanced
{
    public class Bai2
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 2: GHI ĐÈ PHƯƠNG THỨC ===");

            Nguoi nguoi = new Nguoi(
                "Nguyễn Trung Quân",
                new DateTime(2006, 1, 12)
            );

            SinhVien sv = new SinhVien(
                "24001402",
                "Nguyễn Trung Quân",
                new DateTime(2006, 1, 12),
                8.2
            );

            Console.WriteLine("\n1. Phương thức lớp cha:");
            Console.WriteLine(nguoi.MoTa());

            Console.WriteLine("\n2. Phương thức lớp con:");
            Console.WriteLine(sv.MoTa());

            Console.WriteLine("\n3. Minh họa tính đa hình:");
            Nguoi n = sv;
            Console.WriteLine(n.MoTa());
        }
    }
}
