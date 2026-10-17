
namespace Lab03_OOPAdvanced
{
    public interface IMove
    {
        string TenPhuongTien { get; }

        double TocDo { get; }

        void DiChuyen();

        decimal TinhChiPhi(double soKm);
    }
}
