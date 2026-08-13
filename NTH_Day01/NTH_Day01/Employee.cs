using System;
using System.Collections.Generic;
using System.Text;

namespace NTH_Day01
{
    interface Ipayable
    {
        double CalculateSalary();
    }
    abstract class Employee : Ipayable
    {
        public string maNV {  get; set; }
        public string hoTen { get; set; }
        public string phongBan { get; set; }
        public DateTime ngayVaoLam {  get; set; }
        public double luongCoBan { get; set; }

        public Employee(string maNV, string hoTen, string phongBan, DateTime ngayVaoLam, double luongCoBan)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.phongBan = phongBan;
            this.ngayVaoLam = ngayVaoLam;
            this.luongCoBan = luongCoBan;
        }
        public abstract double CalculateSalary();
        public virtual void hienThi()
        {
            Console.WriteLine(
                $"{maNV,-10}" +
                $"{hoTen,-20}" +
                $"{phongBan,-15}" +
                $"{ngayVaoLam.ToString("dd/MM/yyyy"),-15}" +
                $"{luongCoBan,-15:N2}" +
                $"{CalculateSalary(),-15:N2}"
            );
        }

    }
    class nhanVienChinhThuc : Employee
    {
        public double phuCap {  get; set; }
        public nhanVienChinhThuc(
            string maNV, 
            string hoTen, 
            string phongBan, 
            DateTime ngayVaoLam, 
            double luongCoBan, 
            double phuCap) 
            : base(
                  maNV, 
                  hoTen, 
                  phongBan, 
                  ngayVaoLam, 
                  luongCoBan)      
        {
            this.phuCap = phuCap;
        }
        public override double CalculateSalary()
        {
            return luongCoBan + phuCap;
        }
        public override void hienThi()
        {
            base.hienThi();

            Console.WriteLine("Phu cap:\t" + phuCap.ToString("N2"));

            Console.WriteLine("Loai:\tNhan vien chinh thuc");
        }
    }
    class nhanVienThuViec : Employee
    {
        public nhanVienThuViec(
            string maNV,
            string hoTen,
            string phongBan,
            DateTime ngayVaoLam,
            double luongCoBan)
            : base(
                maNV,
                hoTen,
                phongBan,
                ngayVaoLam,
                luongCoBan)
        {
        }

        public override double CalculateSalary()
        {
            return luongCoBan * 0.85;
        }

        public override void hienThi()
        {
            base.hienThi();

            Console.WriteLine("Loai:\tNhan vien thu viec");
        }
    }
    class nhanVienThoiVu : Employee
    {
        public double soGioLam {  get; set; }
        public double donGiaGio {  get; set; }

        public nhanVienThoiVu(
            string maNV,
            string hoTen,
            string phongBan,
            DateTime ngayVaoLam,
            double luongCoBan,
            double soGioLam,
            double donGiaGio)
            : base(
                maNV,
                hoTen,
                phongBan,
                ngayVaoLam,
                luongCoBan)
        {
            this.soGioLam = soGioLam;
            this.donGiaGio = donGiaGio;
        }
        public override double CalculateSalary()
        {
            return soGioLam * donGiaGio;
        }
        public override void hienThi()
        {
            base.hienThi();

            Console.WriteLine("So gio lam   : " + soGioLam);
            Console.WriteLine("Don gia gio  : " + donGiaGio.ToString("N2"));
            Console.WriteLine("Loai:\tNhan vien thoi vu");
        }
    }
    class nhanVienKinhDoanh : Employee
    {
        public double doanhSo;
        public double tyLeHoaHong;

        public nhanVienKinhDoanh(
            string maNV,
            string hoTen,
            string phongBan,
            DateTime ngayVaoLam,
            double luongCoBan,
            double doanhSo,
            double tyLeHoaHong)
            : base(
                maNV,
                hoTen,
                phongBan,
                ngayVaoLam,
                luongCoBan)
        {
            this.doanhSo = doanhSo;
            this.tyLeHoaHong = tyLeHoaHong;
        }
        public override double CalculateSalary()
        {
            return luongCoBan + doanhSo * tyLeHoaHong;
        }
        public override void hienThi()
        {
            base.hienThi();
            Console.WriteLine("Doanh so:\t " + doanhSo.ToString("N2"));
            Console.WriteLine("Ty le hoa hong:\t" + (tyLeHoaHong * 100).ToString("N2") + "%");
            Console.WriteLine("Loai:\tNhan vien kinh doanh");
        }
    }
}
