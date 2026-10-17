
namespace Lab03_OOPAdvanced
{
    public class SinhVienChinhQuy : NguoiHoc
    {
        public override decimal TinhHocPhi()
        {
            return SoTinChi * 450000m;
        }

        public override string ToDisplayText()
        {
            return "[Chính quy] " +
                   base.ToDisplayText() +
                   " | Học phí: " +
                   TinhHocPhi().ToString("N0") + " VNĐ";
        }
    }
}
