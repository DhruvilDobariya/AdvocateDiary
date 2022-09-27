using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocateDiary.Models
{
    public class Appoinment
    {
        [Key]
        public int AppointmentId { get; set; }

        public string Name { get; set; } = null!;
        public string AppointmentType { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Description { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
