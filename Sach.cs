
namespace Lab03_OOPAdvanced
{
    public class Sach : TaiLieu
    {
        public string TacGia { get; set; }

        public Sach(string ma, string ten, string tacGia)
            : base(ma, ten)
        {
            TacGia = tacGia;
        }

        public override string HienThi()
        {
            return "[Sách] " + base.HienThi() +
                   " | Tác giả: " + TacGia;
        }
    }
}
