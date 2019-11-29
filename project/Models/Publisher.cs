using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Publisher Name cannot exceed 50 characters")]
        public string PublisherName { get; set; }
        public List<Book> Books { get; set; }
    }
}
