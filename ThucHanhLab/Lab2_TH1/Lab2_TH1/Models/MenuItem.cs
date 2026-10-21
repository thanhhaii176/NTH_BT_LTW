using System.ComponentModel.DataAnnotations;

namespace Lab2_TH1.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
    }
}
