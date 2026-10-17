
namespace Lab03_OOPAdvanced
{
    public class GiangVien : NhanVien
    {
        public int SoTietDay { get; set; }
        public decimal DonGiaTietDay { get; set; }

        public GiangVien(
            string ma, string ten,
            int soTietDay, decimal donGiaTietDay)
            : base(ma, ten)
        {
            SoTietDay = soTietDay;
            DonGiaTietDay = donGiaTietDay;
        }

        public override decimal TinhLuong()
        {
            return SoTietDay * DonGiaTietDay;
        }
    }
}
