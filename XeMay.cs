
using System;

namespace Lab03_OOPAdvanced
{
    public class XeMay : IMove
    {
        public string TenPhuongTien => "Xe máy";

        public double TocDo => 50;

        public void DiChuyen()
        {
            Console.WriteLine("Xe máy đang di chuyển.");
        }

        public decimal TinhChiPhi(double soKm)
        {
            return (decimal)soKm * 1500m;
        }
    }
}
