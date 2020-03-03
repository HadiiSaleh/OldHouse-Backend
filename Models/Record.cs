using OldHouse_Backend.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OldHouse_Backend.Models
{
    public class Record
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(int.MaxValue, ErrorMessage = "Maximum length for first name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        public string Description { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for first name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        public string BloodPressur { get; set; }

        [Required]
        [Range(0, 1000000000)]
        public int HeartBeatPerSecond { get; set; }

        [Required]
        [Range(0, 1000000000)]
        public int Temperature { get; set; }

        [Required]
        [Range(0, 1000000000)]
        public int BloodSugarLevel { get; set; }

        [Required]
        [Range(0, 1000000000)]
        public int CholesterolLevel { get; set; }

        [Range(0, 1000000000)]
        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        public AppUser Patient { get; set; }

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool Deleted { get; set; }
    }
}
