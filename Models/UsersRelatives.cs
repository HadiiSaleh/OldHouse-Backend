using OldHouse_Backend.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OldHouse_Backend.Models
{
    public class UsersRelatives
    {
        [Range(0, 1000000000)]
        public int RelativeId { get; set; }

        [ForeignKey("RelativeId")]
        public Relative Relative { get; set; }

        [StringLength(256, ErrorMessage = "Maximum length for display name is {1}")]
        public string PatientId { get; set; }

        [ForeignKey("PatientId")]
        public AppUser Patient { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;


    }
}
