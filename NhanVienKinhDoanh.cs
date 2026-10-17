
namespace Lab03_OOPAdvanced
{
    public class NhanVienKinhDoanh : NhanVien
    {
        public decimal LuongCoBan { get; set; }
        public decimal DoanhSo { get; set; }
        public decimal TyLeHoaHong { get; set; }

        public NhanVienKinhDoanh(
            string ma, string ten,
            decimal luongCoBan,
            decimal doanhSo,
            decimal tyLeHoaHong)
            : base(ma, ten)
        {
            LuongCoBan = luongCoBan;
            DoanhSo = doanhSo;
            TyLeHoaHong = tyLeHoaHong;
        }

        public override decimal TinhLuong()
        {
            return LuongCoBan + DoanhSo * TyLeHoaHong;
        }
    }
}
