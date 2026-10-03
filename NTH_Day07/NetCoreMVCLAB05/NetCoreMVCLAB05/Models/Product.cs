using System.ComponentModel.DataAnnotations;

namespace NetCoreMVCLAB05.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm")]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "Tên sản phẩm phải từ 6 đến 150 kí tự")]
        public string Name { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;
        [Required(ErrorMessage = "Vui lòng nhập giá sản phẩm")]               
        
        [Range(100000, float.MaxValue, ErrorMessage = "Giá phải lớn hơn hoặc bằng 100000")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá khuyến mãi")]
        [Range(0, float.MaxValue, ErrorMessage = "Giá khuyến mãi không được âm")]
        public float SalePrice { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả")]
        [StringLength(1500, ErrorMessage = "Mô tả không được quá 1500 kí tự")]
        public string Description { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn danh mục")]
        public int CategoryId { get; set; }
    }
}
