using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateDiary.Models
{
    public class CaseType
    {
        public CaseType()
        {
            Cases = new HashSet<Case>();
        }

        [Key]
        public int CaseTypeId { get; set; }

        [Required(ErrorMessage = "Please Enter Case Type Name")]
        [MaxLength(50, ErrorMessage = "Case Type Name Max length must less then or equal to 50 character")]
        [MinLength(1, ErrorMessage = "Case Type Name must at least one character")]
        [Display(Name = "Case Type Name")]
        public string CaseTypeName { get; set; }

        [MaxLength(500, ErrorMessage = "Desciption Max length must less then or equal to 500 character")]
        [Display(Name = "Desciption")]
        public string? Desciption { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ModificationDate { get; set; }

        public virtual ICollection<Case> Cases { get; set; }
    }
}
