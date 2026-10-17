
using System;

namespace Lab03_OOPAdvanced
{
    public class ChuyenKhoan : IPayment
    {
        public string TenPhuongThuc => "Chuyển khoản";

        public string SoTaiKhoan { get; set; }
        public decimal SoDu { get; set; }

        public ChuyenKhoan(string soTaiKhoan, decimal soDu)
        {
            SoTaiKhoan = soTaiKhoan;
            SoDu = soDu;
        }

        public bool KiemTra(decimal soTien)
        {
            return soTien > 0
                && !string.IsNullOrWhiteSpace(SoTaiKhoan)
                && SoDu >= soTien;
        }

        public void ThanhToan(decimal soTien)
        {
            if (!KiemTra(soTien))
            {
                Console.WriteLine(
                    "Chuyển khoản thất bại: Kiểm tra tài khoản hoặc số dư!");
                return;
            }

            SoDu -= soTien;

            Console.WriteLine("Chuyển khoản thành công!");
            Console.WriteLine("Số tài khoản: " + SoTaiKhoan);
            Console.WriteLine("Số dư còn lại: {0:N0} VNĐ",
                SoDu);
        }
    }
}
