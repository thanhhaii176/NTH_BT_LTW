using System;
using System.Collections.Generic;
using System.Text;

namespace NTH_Day01
{
    internal class Bai2
    {
        static List<Employee> danhSach = new List<Employee>();
        public static void chay()
        {
            int chon;
            do
            {
                menu();
                Console.WriteLine("Moi ban chon chuc nang: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        themNhanVienTheoLoai();
                        break;

                    case 2:
                        hienThiDanhSach();
                        break;

                    case 3:
                        tinhLuong();
                        break;

                    case 4:
                        hienThiTongQuyLuong();
                        break;

                    case 5:
                        timLuongCaoNhat();
                        break;

                    case 6:
                        sapXepTheoLuong();
                        break;

                    case 7:
                        thongKeTheoPhongBan();
                        break;

                    case 8:
                        locNhanVienTren3Nam();
                        break;

                    case 0:
                        Console.WriteLine("Ket thuc!");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            } while (chon != 0);

        }
        static void menu()
        {
            Console.WriteLine("QUAN LY NHAN VIEN VÀ TINH LUONG");
            Console.WriteLine("============================");
            Console.WriteLine("1.\tThem nhân vien theo loai.");
            Console.WriteLine("2.\tHien thi danh sach.");
            Console.WriteLine("3.\tTinh luong tung nhan vien.");
            Console.WriteLine("4.\tTinh tong quy luong.");
            Console.WriteLine("5.\tTim nhan vien luong cao nhat.");
            Console.WriteLine("6.\tSap xep theo luong.");
            Console.WriteLine("7.\tThong ke theo phong ban.");
            Console.WriteLine("8.\tLoc nhan vien tren 3 nam.");
            Console.WriteLine("0.\tThoat");
            Console.WriteLine("=============================");
        }
        static void themNhanVienTheoLoai()
        {
            Console.WriteLine("\n===== THEM NHAN VIEN =====");
            Console.WriteLine("1.\tNhan vien chinh thuc.");
            Console.WriteLine("2.\tNhan vien thoi vu.");
            Console.WriteLine("3.\tNhan vien thu viec.");
            Console.WriteLine("4.\tNhan vien kinh doanh.");
            Console.Write("Chon loai nhan vien: ");

            int loai = int.Parse(Console.ReadLine());

            switch (loai)
            {
                case 1:
                    themNhanVienChinhThuc();
                    break;

                case 2:
                    themNhanVienThoiVu();
                    break;

                case 3:
                    themNhanVienThuViec();
                    break;

                case 4:
                    themNhanVienKinhDoanh();
                    break;

                default:
                    Console.WriteLine("Loai nhan vien khong hop le!");
                    break;
            }

        }
        static void themNhanVienChinhThuc()
        {
            Console.WriteLine("\n===== NHAP NHAN VIEN CHINH THUC =====");

            Console.Write("Ma nhan vien: ");
            string ma = Console.ReadLine();

            Console.Write("Ho ten: ");
            string ten = Console.ReadLine();

            Console.Write("Phong ban: ");
            string phongBan = Console.ReadLine();

            Console.Write("Ngay vao lam (dd/MM/yyyy): ");
            DateTime ngayVao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Luong co ban: ");
            double luongCoBan = double.Parse(Console.ReadLine());

            Console.Write("Phu cap: ");
            double phuCap = double.Parse(Console.ReadLine());

            nhanVienChinhThuc nv = new nhanVienChinhThuc(
                ma,
                ten,
                phongBan,
                ngayVao,
                luongCoBan,
                phuCap
            );

            danhSach.Add(nv);
        }
        static void themNhanVienThoiVu()
        {
            Console.WriteLine("\n===== NHAP NHAN VIEN THOI VU =====");

            Console.Write("Ma nhan vien: ");
            string ma = Console.ReadLine();

            Console.Write("Ho ten: ");
            string ten = Console.ReadLine();

            Console.Write("Phong ban: ");
            string phongBan = Console.ReadLine();

            Console.Write("Ngay vao lam (dd/MM/yyyy): ");
            DateTime ngayVao = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);

            Console.Write("Luong co ban: ");
            double luongCoBan = double.Parse(Console.ReadLine());

            Console.Write("So gio lam: ");
            double soGio = double.Parse(Console.ReadLine());

            Console.Write("Đon gia gio: ");
            double donGia = double.Parse(Console.ReadLine());

            nhanVienThoiVu nv = new nhanVienThoiVu(
                ma,
                ten,
                phongBan,
                ngayVao,
                luongCoBan,
                soGio,
                donGia
            );

            danhSach.Add(nv);
        }
        static void themNhanVienThuViec()
        {
            Console.WriteLine("\n===== NHAP NHAN VIEN THU VIEC =====");

            Console.Write("Ma nhan vien: ");
            string ma = Console.ReadLine();

            Console.Write("Ho ten: ");
            string ten = Console.ReadLine();

            Console.Write("Phong ban: ");
            string phongBan = Console.ReadLine();

            Console.Write("Ngay vao lam (dd/MM/yyyy): ");
            DateTime ngayVao = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);

            Console.Write("Luong co ban: ");
            double luongCoBan = double.Parse(Console.ReadLine());

            nhanVienThuViec nv = new nhanVienThuViec(
                ma,
                ten,
                phongBan,
                ngayVao,
                luongCoBan
            );

            danhSach.Add(nv);
        }
        static void themNhanVienKinhDoanh()
        {
            Console.WriteLine("\n===== NHAP NHAN VIEN KINH DOANH =====");

            Console.Write("Ma nhan vien: ");
            string ma = Console.ReadLine();

            Console.Write("Ho ten: ");
            string ten = Console.ReadLine();

            Console.Write("Phong ban: ");
            string phongBan = Console.ReadLine();

            Console.Write("Ngay vao lam (dd/MM/yyyy): ");
            DateTime ngayVao = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);

            Console.Write("Luong co ban: ");
            double luongCoBan = double.Parse(Console.ReadLine());

            Console.Write("Doanh so: ");
            double doanhSo = double.Parse(Console.ReadLine());

            Console.Write("Ty le hoa hong: ");
            double hoaHong = double.Parse(Console.ReadLine());

            nhanVienKinhDoanh nv = new nhanVienKinhDoanh(
                ma,
                ten,
                phongBan,
                ngayVao,
                luongCoBan,
                doanhSo,
                hoaHong
            );

            danhSach.Add(nv);
        }
        static void hienThiDanhSach()
        {
            Console.WriteLine("\n================ DANH SACH NHAN VIEN ================");

            Console.WriteLine(
                $"{"Ma NV",-10}" +
                $"{"Ho ten",-20}" +
                $"{"Phong ban",-15}" +
                $"{"Ngay vao lam",-15}" +
                $"{"Luong co ban",-15}" +
                $"{"Luong",-15}"
            );

            Console.WriteLine(
                "--------------------------------------------------------------------------"
            );

            foreach (Employee nv in danhSach)
            {
                nv.hienThi();
            }
        }

        static void tinhLuong()
        {
            Console.WriteLine("\n===== BANG LUONG =====");

            foreach (Employee nv in danhSach)
            {
                Console.WriteLine($"{nv.maNV,-10} {nv.hoTen,-20} " + $"Luong: {nv.CalculateSalary():N0}");
            }
        }
        static double tongQuyLuong()
        {
            return danhSach.Sum(nv => nv.CalculateSalary());
        }

        static void hienThiTongQuyLuong()
        {
            Console.WriteLine($"Tong quy luong: {tongQuyLuong():N0} VNĐ");
        }
        static void timLuongCaoNhat()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sach trong!");
                return;
            }

            double max = danhSach.Max(nv => nv.CalculateSalary());

            Console.WriteLine("\n===== NHAN VIEN CO LUONG CAO NHAT =====");

            foreach (Employee nv in danhSach)
            {
                if (nv.CalculateSalary() == max)
                {
                    nv.hienThi();
                }
            }
        }
        static void sapXepTheoLuong()
        {
            var dsSapXep = danhSach.OrderByDescending(nv => nv.CalculateSalary()).ToList();

            Console.WriteLine("\n===== SAP XEP THEO LUONG GIAM DAN =====");

            foreach (Employee nv in dsSapXep)
            {
                nv.hienThi();
            }
        }
        static void thongKeTheoPhongBan()
        {
            Console.WriteLine("\n===== THONG KE LUONG THEO PHONG BAN =====");

            var thongKe = danhSach.GroupBy(nv => nv.phongBan).Select(g => new
                {
                    PhongBan = g.Key,
                    SoNhanVien = g.Count(),
                    TongLuong = g.Sum(nv => nv.CalculateSalary())
                });

            foreach (var item in thongKe)
            {
                Console.WriteLine($"Phong: {item.PhongBan,-15} | " + $"So NV: {item.SoNhanVien,-5} | " + $"Tong luong: {item.TongLuong:N0}");
            }
        }
        static void locNhanVienTren3Nam()
        {
            DateTime mocThoiGian = DateTime.Now.AddYears(-3);

            var ketQua = danhSach.Where(nv => nv.ngayVaoLam <= mocThoiGian).ToList();

            Console.WriteLine("\n===== NHAN VIEN LAM VIEC TREN 3 NAM =====");

            if (ketQua.Count == 0)
            {
                Console.WriteLine("Khong co nhan vien nao.");
                return;
            }

            foreach (Employee nv in ketQua)
            {
                nv.hienThi();
            }
        }

    }

}
