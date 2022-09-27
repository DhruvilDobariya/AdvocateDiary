using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateDiary.Models
{
    public class CaseDate
    {
        [Key]
        public int CaseDateId { get; set; }
        public DateTime Date { get; set; }

        public int CaseId { get; set; }

        [ForeignKey("CaseId")]
        public virtual Case? Case { get; set; }
    }
}
