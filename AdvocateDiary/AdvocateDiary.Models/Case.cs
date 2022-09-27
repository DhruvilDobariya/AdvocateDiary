using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string CaseName { get; set; } = null!;
        public int ClientId { get; set; }
        public int CaseTypeId { get; set; }
        public string Status { get; set; } = null!;
        public string OppositeParty { get; set; } = null!; 
        public string OppositeLawyer { get; set; } = null!;
        public int CourtId { get; set; }
        public string Desciption { get; set; } = null!;
        public DateTime CreationDate { get; set; }
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
