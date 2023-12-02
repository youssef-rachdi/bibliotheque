using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBooks.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        [DisplayName("Book Name")]
        [Required(ErrorMessage = "Title is required")]
        public string? BookTitle { get; set; }

        [DisplayName("Book Description")]
        [Required(ErrorMessage = "description is required")]
        public string? BookDescription { get; set; }
        
        [DisplayName("Book Image")]
        [Required(ErrorMessage = "image is required")]
        public string? BookImage { get; set; }

        [DisplayName("Book Auther")]
        [Required(ErrorMessage = "Auther is required")]
        public string? Author { get; set; }

        [DisplayName("Category")]
        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}