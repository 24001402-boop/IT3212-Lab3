
using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced
{
    public class Bai8
    {
        public static void Chay()
        {
            Console.WriteLine(
                "=== BÀI 8: QUẢN LÝ TÀI LIỆU ===");

            List<TaiLieu> danhSach = new List<TaiLieu>
            {
                new Sach(
                    "S01", "Lập trình C#",
                    "Nguyễn Văn An"),

                new Sach(
                    "S02", "Cấu trúc dữ liệu",
                    "Trần Minh Đức"),

                new TapChi(
                    "TC01", "Công nghệ thông tin",
                    10),

                new LuanVan(
                    "LV01", "Ứng dụng AI trong giáo dục",
                    "Nguyễn Trung Quân")
            };

            Console.WriteLine("\nDANH SÁCH TÀI LIỆU:");

            foreach (TaiLieu tl in danhSach)
            {
                Console.WriteLine(tl.HienThi());
            }

            Console.WriteLine("\nTÌM KIẾM THEO LOẠI:");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Luận văn");
            Console.Write("Chọn loại tài liệu: ");

            string luaChon = Console.ReadLine() ?? "";
            bool timThay = false;

            foreach (TaiLieu tl in danhSach)
            {
                bool phuHop =
                    (luaChon == "1" && tl is Sach) ||
                    (luaChon == "2" && tl is TapChi) ||
                    (luaChon == "3" && tl is LuanVan);

                if (phuHop)
                {
                    Console.WriteLine(tl.HienThi());
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine(
                    "Không tìm thấy tài liệu phù hợp!");
            }
        }
    }
}
