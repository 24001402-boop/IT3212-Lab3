
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03_OOPAdvanced
{
    public class Bai10
    {
        public static void Chay()
        {
            List<NguoiHoc> danhSach = new List<NguoiHoc>
            {
                new SinhVienChinhQuy
                {
                    MaSV = "24001402",
                    HoTen = "Nguyễn Trung Quân",
                    SoTinChi = 18
                },

                new SinhVienLienThong
                {
                    MaSV = "SV002",
                    HoTen = "Trần Văn Bình",
                    SoTinChi = 15
                },

                new SinhVienChinhQuy
                {
                    MaSV = "SV003",
                    HoTen = "Lê Thị Mai",
                    SoTinChi = 20
                },

                new SinhVienLienThong
                {
                    MaSV = "SV004",
                    HoTen = "Phạm Minh Đức",
                    SoTinChi = 12
                }
            };

            while (true)
            {
                Console.WriteLine(
                    "\n===== BÀI 10: QUẢN LÝ SINH VIÊN =====");
                Console.WriteLine("1. Hiển thị danh sách");
                Console.WriteLine("2. Tìm kiếm theo mã sinh viên");
                Console.WriteLine("3. Thống kê theo loại");
                Console.WriteLine("4. Tính tổng học phí");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Chọn chức năng: ");

                string chon = Console.ReadLine() ?? "";

                switch (chon)
                {
                    case "1":
                        Console.WriteLine(
                            "\nDANH SÁCH SINH VIÊN:");

                        foreach (NguoiHoc sv in danhSach)
                        {
                            IPrintable printable = sv;
                            Console.WriteLine(
                                printable.ToDisplayText());
                        }
                        break;

                    case "2":
                        Console.Write("Nhập mã sinh viên: ");
                        string ma = Console.ReadLine() ?? "";

                        NguoiHoc? ketQua = danhSach.FirstOrDefault(
                            sv => sv.MaSV.Equals(
                                ma,
                                StringComparison.OrdinalIgnoreCase));

                        if (ketQua != null)
                        {
                            Console.WriteLine(
                                "Tìm thấy: " +
                                ketQua.ToDisplayText());
                        }
                        else
                        {
                            Console.WriteLine(
                                "Không tìm thấy sinh viên!");
                        }
                        break;

                    case "3":
                        int chinhQuy = danhSach.Count(
                            sv => sv is SinhVienChinhQuy);

                        int lienThong = danhSach.Count(
                            sv => sv is SinhVienLienThong);

                        Console.WriteLine(
                            "\nTHỐNG KÊ SINH VIÊN:");
                        Console.WriteLine(
                            "Tổng số: " + danhSach.Count);
                        Console.WriteLine(
                            "Chính quy: " + chinhQuy);
                        Console.WriteLine(
                            "Liên thông: " + lienThong);
                        break;

                    case "4":
                        decimal tongHocPhi = danhSach.Sum(
                            sv => sv.TinhHocPhi());

                        Console.WriteLine(
                            "\nTổng học phí: {0:N0} VNĐ",
                            tongHocPhi);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine(
                            "Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}
