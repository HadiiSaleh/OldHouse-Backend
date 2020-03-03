using OldHouse_Backend.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OldHouse_Backend.Models
{
    public class Alert
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(int.MaxValue, ErrorMessage = "Maximum length for first name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]

        public string Description { get; set; }

        [Range(0, 1000000000)]
        public int AlertLevelId { get; set; }

        [ForeignKey("AlertLevelId")]
        public AlertLevel AlertLevel { get; set; }

        [StringLength(256, ErrorMessage = "Maximum length for display name is {1}")]
        public string PatientId { get; set; }

        [ForeignKey("PatientId")]
        public AppUser Patient { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool Seen { get; set; }

        public DateTime SeenAt { get; set; }

    }
}
