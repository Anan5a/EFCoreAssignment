﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssignment.Models
{
    public class Sla
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? SlaId { get; set; }

        [Required]
        [StringLength(100)]
        public string SlaName { get; set; }

        public string SlaFrequencyTransaction { get; set; }

        public string SlaFrequencyPosition { get; set; }

        public string SlaAnniversary { get; set; }

        public bool SlaExcludeWeekends { get; set; }

        public int? SlaReminderDays { get; set; }

        public int? SlaEscalationDays { get; set; }

        public DateTime LastModified { get; set; } = DateTime.UtcNow;
    }
}