
namespace Lab03_OOPAdvanced
{
    public interface IPayment
    {
        string TenPhuongThuc { get; }

        bool KiemTra(decimal soTien);

        void ThanhToan(decimal soTien);
    }
}
