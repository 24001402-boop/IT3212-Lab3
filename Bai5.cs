
using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced
{
    public class Bai5
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 5: DANH SÁCH ĐA HÌNH ===");

            List<NguoiHoc> ds = new List<NguoiHoc>();

            ds.Add(new SinhVienChinhQuy
            {
                HoTen = "Nguyễn Trung Quân",
                SoTinChi = 18
            });

            ds.Add(new SinhVienLienThong
            {
                HoTen = "Trần Văn Bình",
                SoTinChi = 15
            });

            ds.Add(new SinhVienChinhQuy
            {
                HoTen = "Lê Thị Mai",
                SoTinChi = 20
            });

            ds.Add(new SinhVienLienThong
            {
                HoTen = "Phạm Minh Đức",
                SoTinChi = 12
            });

            decimal tong = 0;

            Console.WriteLine("\nDANH SÁCH HỌC PHÍ:");

            foreach (NguoiHoc item in ds)
            {
                decimal hocPhi = item.TinhHocPhi();
                tong += hocPhi;

                Console.WriteLine(
                    "{0} - {1} tín chỉ - {2:N0} VNĐ",
                    item.HoTen, item.SoTinChi, hocPhi);
            }

            Console.WriteLine("\nTổng số sinh viên: " + ds.Count);
            Console.WriteLine("Tổng học phí: {0:N0} VNĐ", tong);
        }
    }
}
