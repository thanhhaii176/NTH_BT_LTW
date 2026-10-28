using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Lab3_TH2.Models
{
    public class Student
    {
        public int Id { get; set; }            //Mã sinh vien

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ tên phải có từ 4 đến 100 ký tự")]
        [Display(Name = "Họ và tên")]
        public string? Name { get; set; } //Ho tên

        [Required(ErrorMessage = "Email bắt buoc phải được nhập")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        [Display(Name = "Địa chỉ email")]
        public string? Email { get; set; } //Email

        [Required(ErrorMessage = "Mật khẩu bắt buộc phải được nhập")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z\d\s]).{8,100}$",
            ErrorMessage = "Mật khẩu phải có chữ hoa, chữ thường, chữ số và ký tự đặc biệt")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string? Password { get; set; }//Mật khẩu

        [Required(ErrorMessage = "Vui lòng chọn ngành học")]
        [Display(Name = "Ngành học")]
        public Branch? Branch { get; set; }//Nganh học

        [Required(ErrorMessage = "Vui lòng chọn giới tính")]
        [Display(Name = "Giới tính")]
        public Gender? Gender { get; set; }//Giới tính

        [Display(Name = "Hệ chính quy")]
        public bool IsRegular { get; set; }//He: true-chinh quy, false-phi chinh quy

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }//Địa chỉ

        [Required(ErrorMessage = "Ngày sinh bắt buộc phải được nhập")]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh")]
        [Range(typeof(DateTime), "1963-01-01", "2005-12-31", ErrorMessage = "Ngày sinh phải từ năm 1963 đến năm 2005")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh
        [Required(ErrorMessage = "Điểm bắt buộc phải được nhập")]
        [Range(typeof(double), "0.0", "10.0", ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0")]
        [Display(Name = "Điểm")]
        public double? Score { get; set; }
    }
}
