using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssignment.Models
{
    public class EmailTemplate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? EmailTemplateId { get; set; }

        [Required]
        [StringLength(100)]
        public string EmailTemplateName { get; set; }

        [Required]
        [StringLength(200)]
        public string EmailTemplateSubject { get; set; }

        [Required]
        public string EmailTemplateBody { get; set; }

        public DateTime LastModified { get; set; } = DateTime.UtcNow;
    }
}
