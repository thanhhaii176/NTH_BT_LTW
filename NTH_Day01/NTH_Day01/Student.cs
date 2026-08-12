using System;
using System.Collections.Generic;
using System.Text;

namespace NTH_Day01
{
    /// <summary>
    /// class: Student
    /// </summary>
    internal class Student
    {
        public string maSV { get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string email { get; set; }
        public string soDT { get; set; }
        public string nganhHoc { get; set; }
        public double diemTB { get; set; }
        public string trangThai { get; set; }
        public Student(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh, string email, string soDT, string nganhHoc, double diemTB, string trangThai)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.email = email;
            this.soDT = soDT;
            this.nganhHoc = nganhHoc;
            this.diemTB = diemTB;
            this.trangThai = trangThai;
        }
    }
}
