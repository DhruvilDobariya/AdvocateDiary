using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateDiary.Models
{
    public class Court
    {
        public Court()
        {
            Cases = new HashSet<Case>();
        }

        [Key]
        public int CourtId { get; set; }

        [Required(ErrorMessage = "Please Enter Court Name")]
        [MaxLength(250, ErrorMessage = "Court Name Max length must less then or equal to 250 character")]
        [MinLength(1, ErrorMessage = "Court Name must at least one character")]
        [Display(Name = "Court Name")]
        public string CourtName { get; set; } = null!;

        [Required(ErrorMessage = "Please Enter Country")]
        [MaxLength(50, ErrorMessage = "Country Max length must less then or equal to 50 character")]
        [MinLength(1, ErrorMessage = "Country must at least one character")]
        [Display(Name = "Country")]
        public string Country { get; set; } = null!;

        [Required(ErrorMessage = "Please Enter State")]
        [MaxLength(50, ErrorMessage = "State Max length must less then or equal to 50 character")]
        [MinLength(1, ErrorMessage = "State must at least one character")]
        [Display(Name = "State")]
        public string State { get; set; } = null!;

        [Required(ErrorMessage = "Please Enter City")]
        [MaxLength(50, ErrorMessage = "City Max length must less then or equal to 50 character")]
        [MinLength(1, ErrorMessage = "State must at least one character")]
        [Display(Name = "City")]
        public string City { get; set; } = null!;

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ModificationDate { get; set; }

        public virtual ICollection<Case> Cases { get; set; }
    }
}
