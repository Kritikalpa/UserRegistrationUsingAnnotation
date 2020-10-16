using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistrationusingAnnotation
{
    class User
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "First Name Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z][A-Za-z\s]{2,}$")]
        public string firstName { get; set; }

        
    }
}
