using System;
using System.ComponentModel.DataAnnotations;

namespace BooksAdministration.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(
            50, 
            ErrorMessage = "The {0} should be {2} and max {1}", 
            MinimumLength = 2)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(
            100,
            ErrorMessage = "The {0} should be {2} and max {1}",
            MinimumLength = 2)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime Created_At { get; set; }

        [Required(ErrorMessage = "Author is required")]
        [StringLength(
            50,
            ErrorMessage = "The {0} should be {2} and max {1}",
            MinimumLength = 2)]
        public string Author { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [StringLength(
            50,
            ErrorMessage = "The {0} should be {2} and max {1}",
            MinimumLength = 2)]
        public int Price { get; set; }
    }
}
