using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvocateDiary.Models
{
    public class Fees
    {
        [Key]
        public int FeesId { get; set; }

        [Required(ErrorMessage = "Please Enter Client Name")]
        [MaxLength(250, ErrorMessage = "Client Name Max length must less then or equal to 250 character")]
        [MinLength(1, ErrorMessage = "Client Name must at least one character")]
        [Display(Name = "Client Name")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Please Enter Case Name")]
        [MaxLength(250, ErrorMessage = "Case Name Max length must less then or equal to 250 character")]
        [MinLength(1, ErrorMessage = "Case Name must at least one character")]
        [Display(Name = "Case Name")]
        public int CaseId { get; set; }

        [Required(ErrorMessage = "Please Enter Total Fees")]
        [DataType(DataType.Currency)]
        [Display(Name = "Total Fees")]
        public decimal TotalFees { get; set; }

        [Required(ErrorMessage = "Please Enter Pending Fees")]
        [DataType(DataType.Currency)]
        [Display(Name = "Pending Fees")]
        public decimal PendingFess { get; set; }

        [Required(ErrorMessage = "Please Enter Fees Type")]
        [MaxLength(50, ErrorMessage = "Fees Type Max length must less then or equal to 50 character")]
        [MinLength(1, ErrorMessage = "Fees Type must at least one character")]
        [Display(Name = "Fees Type")]
        public string FeesType { get; set; } = null!;

        [MaxLength(500, ErrorMessage = "Desciption Max length must less then or equal to 500 character")]
        [Display(Name = "Desciption")]
        public string? Desciption { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ModificationDate { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client? Client { get; set; }
        [ForeignKey("CaseId")]
        public virtual Case? Case { get; set; }
    }
}
