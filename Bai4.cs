
using System;

namespace Lab03_OOPAdvanced
{
    public class Bai4
    {
        public static void Chay()
        {
            Console.WriteLine(
                "=== BÀI 4: INTERFACE KIỂM TRA VÀ IN DỮ LIỆU ===");

            // Sinh viên có dữ liệu hợp lệ
            SinhVien sv1 = new SinhVien(
                "24001402",
                "Nguyễn Trung Quân",
                new DateTime(2006, 1, 12),
                8.2
            );

            // Sinh viên có dữ liệu không hợp lệ
            SinhVien sv2 = new SinhVien(
                "",
                "Trần Văn Bình",
                new DateTime(2005, 9, 3),
                12
            );

            Console.WriteLine("\n1. Kiểm tra sinh viên hợp lệ:");

            string message;

            if (sv1.IsValid(out message))
            {
                Console.WriteLine(message);
                Console.WriteLine(sv1.ToDisplayText());
            }
            else
            {
                Console.WriteLine(message);
            }

            Console.WriteLine("\n2. Kiểm tra sinh viên không hợp lệ:");

            if (sv2.IsValid(out message))
            {
                Console.WriteLine(message);
                Console.WriteLine(sv2.ToDisplayText());
            }
            else
            {
                Console.WriteLine("Lỗi: " + message);
            }

            // Sử dụng tham chiếu Interface
            Console.WriteLine("\n3. Sử dụng Interface IPrintable:");

            IPrintable printable = sv1;
            Console.WriteLine(printable.ToDisplayText());
        }
    }
}
