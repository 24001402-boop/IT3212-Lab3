
namespace Lab03_OOPAdvanced
{
    public class LuanVan : TaiLieu
    {
        public string NguoiThucHien { get; set; }

        public LuanVan(string ma, string ten,
                       string nguoiThucHien)
            : base(ma, ten)
        {
            NguoiThucHien = nguoiThucHien;
        }

        public override string HienThi()
        {
            return "[Luận văn] " + base.HienThi() +
                   " | Người thực hiện: " + NguoiThucHien;
        }
    }
}
