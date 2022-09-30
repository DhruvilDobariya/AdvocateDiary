using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvocateDiary.Models
{
    public class CaseDate
    {
        [Key]
        public int CaseDateId { get; set; }

        [Required(ErrorMessage = "Please Enter Case Date")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please Enter Case Name")]
        [MaxLength(250, ErrorMessage = "Case Name Max length must less then or equal to 250 character")]
        [MinLength(1, ErrorMessage = "Case Name must at least one character")]
        [Display(Name = "Case Name")]
        public int CaseId { get; set; }
        [MaxLength(500, ErrorMessage = "Desciption Max length must less then or equal to 500 character")]
        [Display(Name = "Desciption")]
        public string? Desciption { get; set; }

        [ForeignKey("CaseId")]
        public virtual Case? Case { get; set; }
    }
}
