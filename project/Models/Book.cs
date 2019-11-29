using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Title cannot exceed 50 characters")]
        public string Title { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; }


        public List<GenreBook> Genres { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        [Required]
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

        [Required]
        public int StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}
