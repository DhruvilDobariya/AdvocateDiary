using System;
using System.Collections.Generic;
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

        public int CaseTypeId { get; set; }
        public string CaseTypeName { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

        public virtual ICollection<Case> Cases { get; set; }
    }
}
