
using System;

namespace Lab03_OOPAdvanced
{
    public class ThanhToanTienMat : IPayment
    {
        public string TenPhuongThuc => "Tiền mặt";

        public decimal TienKhachDua { get; set; }

        public ThanhToanTienMat(decimal tienKhachDua)
        {
            TienKhachDua = tienKhachDua;
        }

        public bool KiemTra(decimal soTien)
        {
            return soTien > 0 && TienKhachDua >= soTien;
        }

        public void ThanhToan(decimal soTien)
        {
            if (!KiemTra(soTien))
            {
                Console.WriteLine(
                    "Thanh toán thất bại: Số tiền không hợp lệ hoặc không đủ!");
                return;
            }

            decimal tienThua = TienKhachDua - soTien;

            Console.WriteLine("Thanh toán tiền mặt thành công!");
            Console.WriteLine("Tiền khách đưa: {0:N0} VNĐ",
                TienKhachDua);
            Console.WriteLine("Tiền thừa: {0:N0} VNĐ",
                tienThua);
        }
    }
}
