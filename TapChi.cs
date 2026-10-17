
namespace Lab03_OOPAdvanced
{
    public class TapChi : TaiLieu
    {
        public int SoPhatHanh { get; set; }

        public TapChi(string ma, string ten, int soPhatHanh)
            : base(ma, ten)
        {
            SoPhatHanh = soPhatHanh;
        }

        public override string HienThi()
        {
            return "[Tạp chí] " + base.HienThi() +
                   " | Số phát hành: " + SoPhatHanh;
        }
    }
}
