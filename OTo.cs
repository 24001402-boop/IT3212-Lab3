
using System;

namespace Lab03_OOPAdvanced
{
    public class OTo : IMove
    {
        public string TenPhuongTien => "Ô tô";

        public double TocDo => 80;

        public void DiChuyen()
        {
            Console.WriteLine("Ô tô đang di chuyển.");
        }

        public decimal TinhChiPhi(double soKm)
        {
            return (decimal)soKm * 5000m;
        }
    }
}
