using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateDiary.Models
{
    public class Case
    {
        public int CaseId { get; set; }
        public string CaseName { get; set; } = null!;
        public int ClientId { get; set; }
        public int CaseType { get; set; }
        public string Status { get; set; } = null!;
        public string OppositeParty { get; set; } = null!; 
        public string OppositeLawyer { get; set; } = null!;
        public int CourtId { get; set; }
        public string Desciption { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

    }
}
