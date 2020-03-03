using Microsoft.AspNetCore.Identity;
using OldHouse_Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OldHouse_Backend.Data
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for first name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(256, ErrorMessage = "Maximum length for middle name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for last name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(256, ErrorMessage = "Maximum length for display name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        [Display(Name = "Name")]
        public string DisplayName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [StringLength(256, ErrorMessage = "Maximum length for display name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        public string Gender { get; set; }

        [StringLength(256, ErrorMessage = "Maximum length for display name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        public string BloodType { get; set; }

        [StringLength(int.MaxValue, ErrorMessage = "Maximum length for display name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        public string PhotoUrl { get; set; }

        [StringLength(int.MaxValue, ErrorMessage = "Maximum length for display name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        public string MachineId { get; set; }

        [Required]
        [Range(0, 1000000000)]
        public int CurrentStateId { get; set; }

        [ForeignKey("CurrentStateId")]
        public Record CurrentState { get; set; }

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Updated At")]
        public DateTime? UpdatedAt { get; set; }

        public bool IsAlive { get; set; }

        public List<Record> Records { get; set; }

        public List<UsersRelatives> UsersRelatives { get; set; }

        public List<Alert> Alerts { get; set; }
    }
}
