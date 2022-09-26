using System;
using System.Collections.Generic;
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

        public int CourtId { get; set; }
        public string CourtName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string State { get; set; } = null!;
        public string City { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

        public virtual ICollection<Case> Cases { get; set; }
    }
}
