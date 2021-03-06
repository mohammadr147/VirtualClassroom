﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VirtualClassroom.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public IEnumerable<string> Roles { get; set; }

        public string StatusMessage { get; set; }
    }
}
