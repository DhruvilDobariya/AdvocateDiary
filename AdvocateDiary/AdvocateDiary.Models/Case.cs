using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvocateDiary.Models
{
    public class Case
    {
        public Case()
        {
            Fees = new HashSet<Fees>();
            Cases = new HashSet<Case>();
        }

        [Key]
        public int CaseId { get; set; }

        [Required(ErrorMessage = "Please Enter Case Name")]
        [MaxLength(250, ErrorMessage = "Case Name Max length must less then or equal to 250 character")]
        [MinLength(1, ErrorMessage = "Case Name must at least one character")]
        [Display(Name = "Case Name")]
        public string CaseName { get; set; } = null!;

        [Required(ErrorMessage = "Please Enter Client Name")]
        [MaxLength(250, ErrorMessage = "Client Name Max length must less then or equal to 250 character")]
        [MinLength(1, ErrorMessage = "Client Name must at least one character")]
        [Display(Name = "Client Name")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Please Enter Case Type")]
        [MaxLength(50, ErrorMessage = "Case Type Max length must less then or equal to 50 character")]
        [MinLength(1, ErrorMessage = "Case Type must at least one character")]
        [Display(Name = "Case Type")]
        public int CaseTypeId { get; set; }

        [Required(ErrorMessage = "Please Enter Status")]
        [MaxLength(50, ErrorMessage = "Status Max length must less then or equal to 50 character")]
        [MinLength(1, ErrorMessage = "Status must at least one character")]
        [Display(Name = "Status")]
        public string Status { get; set; } = null!;

        [Required(ErrorMessage = "Please Enter Opposite Party")]
        [MaxLength(250, ErrorMessage = "Opposite Party Max length must less then or equal to 250 character")]
        [MinLength(1, ErrorMessage = "Opposite Party must at least one character")]
        [Display(Name = "Opposite Party")]
        public string OppositeParty { get; set; } = null!;

        [Required(ErrorMessage = "Please Enter Opposite Lawyer")]
        [MaxLength(250, ErrorMessage = "Opposite Lawyer Max length must less then or equal to 250 character")]
        [MinLength(1, ErrorMessage = "Opposite Lawyer must at least one character")]
        [Display(Name = "Opposite Lawyer")]
        public string OppositeLawyer { get; set; } = null!;

        [Required(ErrorMessage = "Please Enter Court Name")]
        [MaxLength(250, ErrorMessage = "Court Name Max length must less then or equal to 250 character")]
        [MinLength(1, ErrorMessage = "Court Name must at least one character")]
        [Display(Name = "Court Name")]
        public int CourtId { get; set; }

        [MaxLength(500, ErrorMessage = "Desciption Max length must less then or equal to 500 character")]
        [Display(Name = "Desciption")]
        public string? Desciption { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ModificationDate { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client? Client { get; set; }
        [ForeignKey("CourtId")]
        public virtual Court? Court { get; set; }
        [ForeignKey("CaseTypeId")]
        public virtual CaseType? CaseType { get; set; }

        public virtual ICollection<Fees> Fees { get; set; }
        public virtual ICollection<Case> Cases { get; set; }

    }
}
