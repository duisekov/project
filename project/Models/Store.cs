using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class Store
    {
        public int StoreId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Store Name cannot exceed 50 characters")]
        public string StoreName { get; set; }
        public List<Book> Books { get; set; }
    }
}
