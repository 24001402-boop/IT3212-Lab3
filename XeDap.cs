
using System;

namespace Lab03_OOPAdvanced
{
    public class XeDap : IMove
    {
        public string TenPhuongTien => "Xe đạp";

        public double TocDo => 15;

        public void DiChuyen()
        {
            Console.WriteLine("Xe đạp đang di chuyển.");
        }

        public decimal TinhChiPhi(double soKm)
        {
            return 0m;
        }
    }
}
