
namespace Lab03_OOPAdvanced
{
    public abstract class NguoiHoc : IPrintable
    {
        public string MaSV { get; set; } = "";
        public string HoTen { get; set; } = "";
        public int SoTinChi { get; set; }

        public abstract decimal TinhHocPhi();

        public virtual string ToDisplayText()
        {
            return "Mã SV: " + MaSV +
                   " | Họ tên: " + HoTen +
                   " | Số tín chỉ: " + SoTinChi;
        }
    }
}
