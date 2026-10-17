
using System;

namespace Lab03_OOPAdvanced
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding =
                System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n===== LAB 3 =====");
                Console.WriteLine("1. Bài 1 - Kế thừa");
                Console.WriteLine("2. Bài 2 - Ghi đè phương thức");
                Console.WriteLine("3. Bài 3 - Lớp trừu tượng");
                Console.WriteLine("4. Bài 4 - Interface");
                Console.WriteLine("5. Bài 5 - Danh sách đa hình");
                Console.WriteLine("6. Bài 6 - Quản lý nhân viên");
                Console.WriteLine("7. Bài 7 - Interface IMove");
                Console.WriteLine("8. Bài 8 - Quản lý tài liệu");
                Console.WriteLine("9. Bài 9 - Hệ thống thanh toán");
                Console.WriteLine("10. Bài 10 - Quản lý sinh viên");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn bài: ");

                switch (Console.ReadLine())
                {
                    case "1": Bai1.Chay(); break;
                    case "2": Bai2.Chay(); break;
                    case "3": Bai3.Chay(); break;
                    case "4": Bai4.Chay(); break;
                    case "5": Bai5.Chay(); break;
                    case "6": Bai6.Chay(); break;
                    case "7": Bai7.Chay(); break;
                    case "8": Bai8.Chay(); break;
                    case "9": Bai9.Chay(); break;
                    case "10": Bai10.Chay(); break;
                    case "0": return;
                    default:
                        Console.WriteLine(
                            "Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}
