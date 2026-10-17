
using System;
using System.Collections.Generic;

namespace Lab03_OOPAdvanced
{
    public class Bai6
    {
        public static void Chay()
        {
            Console.WriteLine(
                "=== BÀI 6: QUẢN LÝ NHÂN VIÊN ===");

            List<NhanVien> danhSach = new List<NhanVien>();

            danhSach.Add(new NhanVienVanPhong(
                "NV01", "Nguyễn Trung Quân",
                8000000m, 1500000m));

            danhSach.Add(new NhanVienKinhDoanh(
                "NV02", "Trần Văn Bình",
                6000000m, 100000000m, 0.05m));

            danhSach.Add(new GiangVien(
                "GV01", "Lê Thị Mai",
                80, 150000m));

            decimal tongLuong = 0;

            Console.WriteLine("\nDANH SÁCH LƯƠNG NHÂN VIÊN:");

            foreach (NhanVien nv in danhSach)
            {
                decimal luong = nv.TinhLuong();
                tongLuong += luong;

                Console.WriteLine("\nMã NV: " + nv.MaNV);
                Console.WriteLine("Họ tên: " + nv.HoTen);
                Console.WriteLine("Loại: " + nv.GetType().Name);
                Console.WriteLine(
                    "Lương: {0:N0} VNĐ", luong);
            }

            Console.WriteLine(
                "\nTổng số nhân viên: " + danhSach.Count);

            Console.WriteLine(
                "Tổng lương: {0:N0} VNĐ", tongLuong);
        }
    }
}
