using Microsoft.AspNetCore.Mvc;
using project.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class AuthorBiography : IValidatableObject
    {
        public int AuthorBiographyId { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Biography cannot exceed 500 characters")]
        public string Biography { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Place Of Birth cannot exceed 50 characters")]
        public string PlaceOfBirth { get; set; }

        [CheckNationality]
        [Required]
        [MaxLength(50, ErrorMessage = "Nationality cannot exceed 50 characters")]
        public string Nationality { get; set; }

        [Required]
        public int AuthorRef { get; set; }

        public Author Author { get; set; }

        //IValidatableObject
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateOfBirth > DateTime.Now)
            {
                yield return new ValidationResult("Date of birth can't be in future");
            }
        }
    }
}
