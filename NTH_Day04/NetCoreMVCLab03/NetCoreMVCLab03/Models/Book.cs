using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreMVCLab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image {  get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        //Danh sach cac cuon sach
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chí Phèo",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b1.jfif",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },

                new Book()
                {
                    Id = 2,
                    Title = "Lão Hạc",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b2.jfif",
                    Price = 700000,
                    Sumary = "",
                    TotalPage = 200
                },

                new Book()
                {
                    Id =  4,
                    Title = "Tắt Đèn",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b3.jfif",
                    Price = 650000,
                    Sumary = "",
                    TotalPage = 150
                },
                new Book()
                {
                    Id = 6,
                    Title = "Đường Xưa Mây Trắng",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b4.jfif",
                    Price = 850000,
                    Sumary = "",
                    TotalPage = 300
                }
            };

            return books;
        }

        //Chi tiet mot cuon sach theo ID
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        //SelectListItem Authors
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Nam Cao"},
            new SelectListItem {Value = "2", Text = "Tô Hoài"},
            new SelectListItem {Value = "3", Text = "Ngô Tất Tố"},
            new SelectListItem {Value = "4", Text = "Thiền sư Thích Nhất Hạnh"}
        };

        //SelectListItem Genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Truyện tranh"},
            new SelectListItem {Value = "2", Text = "Văn học hiện đại"},
            new SelectListItem {Value = "3", Text = "Văn học đương đại"},
            new SelectListItem {Value = "4", Text = "Phạt học phổ thông"}
        };
    }
}
