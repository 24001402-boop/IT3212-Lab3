
namespace Lab03_OOPAdvanced
{
    public class NhanVienVanPhong : NhanVien
    {
        public decimal LuongCoBan { get; set; }
        public decimal PhuCap { get; set; }

        public NhanVienVanPhong(
            string ma, string ten,
            decimal luongCoBan, decimal phuCap)
            : base(ma, ten)
        {
            LuongCoBan = luongCoBan;
            PhuCap = phuCap;
        }

        public override decimal TinhLuong()
        {
            return LuongCoBan + PhuCap;
        }
    }
}
