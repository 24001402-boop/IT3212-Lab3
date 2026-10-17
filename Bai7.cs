
using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced
{
    public class Bai7
    {
        public static void Chay()
        {
            Console.WriteLine(
                "=== BÀI 7: INTERFACE IMove ===");

            List<IMove> danhSach = new List<IMove>
            {
                new XeMay(),
                new OTo(),
                new XeDap()
            };

            double quangDuong = 20;

            Console.WriteLine(
                "\nQuãng đường: " + quangDuong + " km");

            foreach (IMove xe in danhSach)
            {
                Console.WriteLine(
                    "\nPhương tiện: " + xe.TenPhuongTien);

                Console.WriteLine(
                    "Tốc độ: " + xe.TocDo + " km/h");

                xe.DiChuyen();

                decimal chiPhi = xe.TinhChiPhi(quangDuong);

                Console.WriteLine(
                    "Chi phí: {0:N0} VNĐ", chiPhi);
            }
        }
    }
}
