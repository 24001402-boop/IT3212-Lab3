
namespace Lab03_OOPAdvanced
{
    public class TaiLieu
    {
        public string MaTaiLieu { get; set; }
        public string TenTaiLieu { get; set; }

        public TaiLieu(string ma, string ten)
        {
            MaTaiLieu = ma;
            TenTaiLieu = ten;
        }

        public virtual string HienThi()
        {
            return "Mã: " + MaTaiLieu +
                   " | Tên: " + TenTaiLieu;
        }
    }
}
