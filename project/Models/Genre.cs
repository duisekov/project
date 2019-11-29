using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "FirstName cannot exceed 20 characters")]
        public string GenreName { get; set; }

        public List<GenreBook> Books { get; set; }
    }
}
