using System.ComponentModel.DataAnnotations;

namespace SKCatalog.Models
{
    public class SKClass
    {
        [Key]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Class name is required.")]
        [Display(Name = "Class Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Class number is required.")]
        [Display(Name = "Class Number")]
        public string Number { get; set; } = string.Empty;

        [Required(ErrorMessage = "Department is required.")]
        public string Department { get; set; } = string.Empty;

        [Required(ErrorMessage = "Credit hour is required.")]
        [Range(1, 6, ErrorMessage = "Credit must be between 1 and 6.")]
        [Display(Name = "Credit Hour")]
        public int Credit { get; set; }

        [Required(ErrorMessage = "Capacity is required.")]
        [Range(1, 200, ErrorMessage = "Capacity must be between 1 and 200.")]
        public int Capacity { get; set; }
    }
}
