using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamBelt.Models
{
    public class User
    {
        [Key]
        public int UserID {get; set;}

        [Required(ErrorMessage = "The First name field is required")]
        [MinLength(2, ErrorMessage = "Length must be at least 2 characters long")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "The Last name field is required")]
        [MinLength(2, ErrorMessage = "Length must be at least 2 characters long")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "The Field is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        
        [Required]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Password must contain atleast 1 uppercase 1 lowercase and 1 number")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters long")]
        public string Password { get; set; }

        [Required]
        public DateTime created_at {get; set;} = DateTime.Now;
        [Required]
        public DateTime updated_at {get; set;} = DateTime.Now;
        
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords don't match")]
        public string ConfirmPassword { get; set; }

        public List<Participant> AllActivities {get; set;}
    }
}