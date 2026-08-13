using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NTH_Day01
{
    internal class Bai1
    {
        public static void chay()
        {
            List<Student> students = new List<Student>();
            int choice;
            do
            {
                menu();
                Console.Write("Moi ban chon chuc nang: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        themSinhVien(students);
                        break;
                    case 2:
                        hienThiDanhSach(students);
                        break;
                    case 3:
                        timTheoMa(students);
                        break;
                    case 4:
                        timTheoTen(students);
                        break;
                    case 5:
                        capNhatSinhVien(students);
                        break;
                    case 6:
                        xoaSinhVien(students);
                        break;
                    case 7:
                        sapXepTheoTen(students);
                        break;
                    case 8:
                        sapXepTheoDiem(students);
                        break;
                    case 9:
                        hienThiSinhVienTu8(students);
                        break;
                    case 10:
                        hienThiDiemCaoNhat(students);
                        break;
                    case 11:
                        tinhDiemTrungBinh(students);
                        break;
                    case 12:
                        thongKeTheoNganh(students);
                        break;
                    case 13:
                        thongKeTheoTrangThai(students);
                        break;
                    case 0:
                        Console.WriteLine("Da thoat chuong trinh!");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            } while (choice != 0);
        }
        static void menu()
        {
            Console.WriteLine("=============CHUC NANG============");
            Console.WriteLine("1.\tThem sinh vien.\r" +
                "\n2. \tHien thi danh sach.\r" +
                "\n3. \tTim sinh vien theo ma.\r" +
                "\n4. \tTim gan dung theo ho ten.\r" +
                "\n5. \tCap nhat sinh vien.\r" +
                "\n6. \tXoa sinh vien.\r" +
                "\n7. \tSap xep theo ho ten.\r" +
                "\n8. \tSap xep theo diem trung binh.\r" +
                "\n9. \tHien thi sinh vien co diem tu 8 tro len.\r" +
                "\n10. \tHien thi sinh vien co diem cao nhat.\r" +
                "\n11. \tTinh diem trung binh toan bo sinh vien.\r" +
                "\n12. \tThong ke sinh vien theo nganh.\r" +
                "\n13. \tThong ke sinh vien theo trang thai.\r" +
                "\n0. \tThoat");
            Console.WriteLine("===========================================");
        }
        static void themSinhVien(List<Student> students)
        {
            Console.WriteLine("=====THEM SINH VIEN=====");
            Console.Write("Ma sinh vien: ");
            string ma = Console.ReadLine();
            foreach (Student sv in students)
            {
                if (sv.maSV == ma)
                {
                    Console.WriteLine("Ma sinh vien da ton tai!");
                    return;
                }
            }
            Console.Write("Ho ten: ");
            string ten = Console.ReadLine();

            Console.Write("Ngay sinh (dd/MM/yyyy): ");
            DateTime ngaySinh = DateTime.Parse(Console.ReadLine());

            Console.Write("Gioi tinh: ");
            string gioiTinh = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("So dien thoai: ");
            string soDT = Console.ReadLine();

            Console.Write("Nganh hoc: ");
            string nganh = Console.ReadLine();

            Console.Write("Diem trung binh: ");
            double diem = double.Parse(Console.ReadLine());

            Console.Write("Trang thai hoc tap: ");
            string trangThai = Console.ReadLine();

            Student svNew = new Student(ma, ten, ngaySinh, gioiTinh, email, soDT, nganh, diem, trangThai);
            students.Add(svNew);
            Console.WriteLine("Them sinh vien thanh cong!");
        }
        static void hienThiDanhSach(List<Student> students)
        {
            Console.WriteLine("=====HIEN THI DANH SACH=====");
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }
            foreach (Student sv in students)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Ma sinh vien:\t" + sv.maSV);
                Console.WriteLine("Ho ten:\t" + sv.hoTen);
                Console.WriteLine("Ngay sinh:\t" + sv.ngaySinh.ToString("dd/MM/yyyy"));
                Console.WriteLine("Gioi tinh:\t" + sv.gioiTinh);
                Console.WriteLine("Email:\t" + sv.email);
                Console.WriteLine("So dien thoai:\t" + sv.soDT);
                Console.WriteLine("Nganh hoc:\t" + sv.nganhHoc);
                Console.WriteLine("Diem trung binh:\t" + sv.diemTB.ToString("F2"));
                Console.WriteLine("Trang thai:\t" + sv.trangThai);
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Tong so sinh vien: " + students.Count);
        }
        static void timTheoMa(List<Student> students)
        {
            Console.WriteLine("======TIM SINH VIEN THEO MA=====");
            Console.Write("Nhap ma sinh vien can tim: ");
            string ma = Console.ReadLine();
            foreach (Student sv in students)
            {
                if (sv.maSV == ma)
                {
                    hienThiSinhVien(sv);
                    return;
                }
            }
            Console.WriteLine("Khong tim thay sinh vien!");
        }
        static void timTheoTen(List<Student> students)
        {
            Console.WriteLine("=====TIM SINH VIEN THEO TEN=====");
            Console.WriteLine("Nhap ten sinh vien can tim: ");
            string ten = Console.ReadLine();
            bool timThay = false;
            foreach (Student sv in students)
            {
                if (sv.hoTen.ToLower().Contains(ten.ToLower()))
                {
                    hienThiSinhVien(sv);
                    timThay = true;
                }
            }
            if (!timThay)
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }
        }
        static void capNhatSinhVien(List<Student> students)
        {
            Console.WriteLine("===== CAP NHAT SINH VIEN =====");

            Console.Write("Nhap ma sinh vien: ");
            string ma = Console.ReadLine();

            foreach (Student sv in students)
            {
                if (sv.maSV == ma)
                {
                    Console.Write("Ho ten moi: ");
                    sv.hoTen = Console.ReadLine();

                    Console.Write("Ngay sinh moi (dd/MM/yyyy): ");
                    sv.ngaySinh = DateTime.Parse(
                        Console.ReadLine());

                    Console.Write("Gioi tinh moi: ");
                    sv.gioiTinh = Console.ReadLine();

                    Console.Write("Email moi: ");
                    sv.email = Console.ReadLine();

                    Console.Write("SDT moi: ");
                    sv.soDT = Console.ReadLine();

                    Console.Write("Nganh hoc moi: ");
                    sv.nganhHoc = Console.ReadLine();

                    Console.Write("Diem TB moi: ");
                    sv.diemTB = double.Parse(Console.ReadLine());

                    Console.Write("Trang thai moi: ");
                    sv.trangThai = Console.ReadLine();

                    Console.WriteLine(
                        "Cap nhat thanh cong!");

                    return;
                }
            }

            Console.WriteLine("Khong tim thay sinh vien!");
        }
        static void xoaSinhVien(List<Student> students)
        {
            Console.WriteLine("===== XOA SINH VIEN =====");

            Console.Write("Nhap ma sinh vien: ");
            string ma = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].maSV == ma)
                {
                    students.RemoveAt(i);

                    Console.WriteLine(
                        "Xoa sinh vien thanh cong!");

                    return;
                }
            }

            Console.WriteLine("Khong tim thay sinh vien!");
        }
        static void sapXepTheoTen(List<Student> students)
        {
            Console.WriteLine("===== SAP XEP THEO HO TEN =====");

            students = students.OrderBy(sv => sv.hoTen).ToList();

            hienThiDanhSach(students);
        }
        static void sapXepTheoDiem(List<Student> students)
        {
            Console.WriteLine(
                "===== SAP XEP THEO DIEM TRUNG BINH =====");

            students = students.OrderByDescending(sv => sv.diemTB).ToList();

            hienThiDanhSach(students);
        }
        static void hienThiSinhVienTu8(List<Student> students)
        {
            Console.WriteLine(
                "===== SINH VIEN CO DIEM TU 8 TRO LEN =====");

            bool coSinhVien = false;

            foreach (Student sv in students)
            {
                if (sv.diemTB >= 8)
                {
                    hienThiSinhVien(sv);
                    coSinhVien = true;
                }
            }

            if (!coSinhVien)
            {
                Console.WriteLine(
                    "Khong co sinh vien nao!");
            }
        }
        static void hienThiDiemCaoNhat(List<Student> students)
        {
            Console.WriteLine(
                "===== SINH VIEN CO DIEM CAO NHAT =====");

            if (students.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }

            double max = students.Max(sv => sv.diemTB);

            foreach (Student sv in students)
            {
                if (sv.diemTB == max)
                {
                    hienThiSinhVien(sv);
                }
            }
        }
        static void tinhDiemTrungBinh(List<Student> students)
        {
            Console.WriteLine(
                "===== DIEM TRUNG BINH TOAN BO =====");

            if (students.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }

            double tong = 0;

            foreach (Student sv in students)
            {
                tong += sv.diemTB;
            }

            double trungBinh = tong / students.Count;

            Console.WriteLine("Diem trung binh: " + trungBinh.ToString("F2"));
        }
        static void thongKeTheoNganh(List<Student> students)
        {
            Console.WriteLine(
                "===== THONG KE THEO NGANH =====");

            var ketQua = students.GroupBy(sv => sv.nganhHoc);

            foreach (var nhom in ketQua)
            {
                Console.WriteLine(nhom.Key + ": " + nhom.Count() + " sinh vien");
            }
        }
        static void thongKeTheoTrangThai(List<Student> students)
        {
            Console.WriteLine(
                "===== THONG KE THEO TRANG THAI =====");

            var ketQua = students.GroupBy(sv => sv.trangThai);

            foreach (var nhom in ketQua)
            {
                Console.WriteLine(nhom.Key + ": " + nhom.Count() + " sinh vien");
            }
        }
        static void hienThiSinhVien(Student sv)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ma SV      : " + sv.maSV);
            Console.WriteLine("Ho ten     : " + sv.hoTen);
            Console.WriteLine("Ngay sinh  : " + sv.ngaySinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("Gioi tinh  : " + sv.gioiTinh);
            Console.WriteLine("Email      : " + sv.email);
            Console.WriteLine("SDT        : " + sv.soDT);
            Console.WriteLine("Nganh      : " + sv.nganhHoc);
            Console.WriteLine("Diem TB    : " + sv.diemTB.ToString("F2"));
            Console.WriteLine("Trang thai : " + sv.trangThai);
            Console.WriteLine("----------------------------------------");
        }
    }
}
