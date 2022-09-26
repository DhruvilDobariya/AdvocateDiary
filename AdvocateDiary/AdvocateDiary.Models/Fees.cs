using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateDiary.Models
{
    public class Fees
    {
        public int FeesId { get; set; }
        public int ClientId { get; set; }
        public int CaseId { get; set; }
        public decimal TotalFees { get; set; }
        public decimal PendingFess { get; set; }
        public string FeesType { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime ModificationDate { get; set; }
        public DateTime CreationDate { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client? Client { get; set; }
        [ForeignKey("CaseId")]
        public virtual Case? Case { get; set; }
    }
}
