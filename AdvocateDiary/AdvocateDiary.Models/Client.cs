using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateDiary.Models
{
    public class Client
    {
        public Client()
        {
            Cases = new HashSet<Case>();
            Fees = new HashSet<Fees>();
        }

        public int ClientId { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string ContectNo { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

        public virtual ICollection<Case> Cases { get; set; }
        public virtual ICollection<Fees> Fees { get; set; } 
    }
}
