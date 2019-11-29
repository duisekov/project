using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.Validators
{
    public class CheckNationality : ValidationAttribute
    {
        public string[] allowedNationalities = { "Kazakh, Russian" };
        protected override ValidationResult IsValid (object nationality, ValidationContext validationContext)
        {
            if (!allowedNationalities.Contains(nationality))
                return new ValidationResult("Please choose a valid nationality(Kazakh, Russian)");
        
            return ValidationResult.Success;
        }
    }
}
