
namespace Lab03_OOPAdvanced
{
    public class SinhVienLienThong : NguoiHoc
    {
        public override decimal TinhHocPhi()
        {
            return SoTinChi * 520000m;
        }

        public override string ToDisplayText()
        {
            return "[Liên thông] " +
                   base.ToDisplayText() +
                   " | Học phí: " +
                   TinhHocPhi().ToString("N0") + " VNĐ";
        }
    }
}
