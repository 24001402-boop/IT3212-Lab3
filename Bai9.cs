
using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced
{
    public class Bai9
    {
        public static void Chay()
        {
            Console.WriteLine(
                "=== BÀI 9: HỆ THỐNG THANH TOÁN ===");

            List<IPayment> danhSach = new List<IPayment>
            {
                new ThanhToanTienMat(500000m),
                new ChuyenKhoan("123456789", 2000000m),
                new ViDienTu("VI001", 100000m)
            };

            decimal soTien = 300000m;

            Console.WriteLine(
                "\nSố tiền cần thanh toán: {0:N0} VNĐ",
                soTien);

            foreach (IPayment payment in danhSach)
            {
                Console.WriteLine(
                    "\n--- " + payment.TenPhuongThuc + " ---");

                if (payment.KiemTra(soTien))
                {
                    Console.WriteLine("Kiểm tra: Hợp lệ");
                }
                else
                {
                    Console.WriteLine("Kiểm tra: Không hợp lệ");
                }

                payment.ThanhToan(soTien);
            }
        }
    }
}
