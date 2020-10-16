﻿using System;
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

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name Should be minimum 3 characters and a maximum of 20 characters")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z][A-Za-z\s]{2,}$")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Email Id is required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-z0-9][a-z0-9+_-]*\.?[a-z0-9]+@([a-z0-9]([a-z0-9-]*[a-z])?\.)([a-z0-9]([a-z0-9-]*[a-z])\.?)([a-z]{2})?)$")]
        public string emailId { get; set; }
    }
}
