
using System;

namespace Lab03_OOPAdvanced
{
    public class ViDienTu : IPayment
    {
        public string TenPhuongThuc => "Ví điện tử";

        public string MaVi { get; set; }
        public decimal SoDu { get; set; }

        public ViDienTu(string maVi, decimal soDu)
        {
            MaVi = maVi;
            SoDu = soDu;
        }

        public bool KiemTra(decimal soTien)
        {
            return soTien > 0
                && !string.IsNullOrWhiteSpace(MaVi)
                && SoDu >= soTien;
        }

        public void ThanhToan(decimal soTien)
        {
            if (!KiemTra(soTien))
            {
                Console.WriteLine(
                    "Thanh toán ví điện tử thất bại: Kiểm tra mã ví hoặc số dư!");
                return;
            }

            SoDu -= soTien;

            Console.WriteLine("Thanh toán ví điện tử thành công!");
            Console.WriteLine("Mã ví: " + MaVi);
            Console.WriteLine("Số dư còn lại: {0:N0} VNĐ",
                SoDu);
        }
    }
}
