using System.ComponentModel.DataAnnotations;

namespace AdvocateDiary.Models
{
    public class Appoinment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        [MaxLength(250, ErrorMessage = "Name Max length must less then or equal to 250 character")]
        [MinLength(1, ErrorMessage = "Name must at least one character")]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Please Enter Appointment Type")]
        [MaxLength(50, ErrorMessage = "Appointment Type Max length must less then or equal to 50 character")]
        [MinLength(1, ErrorMessage = "Appointment Type must at least one character")]
        [Display(Name = "Appointment Type")]
        public string AppointmentType { get; set; } = null!;

        [Required(ErrorMessage = "Please Enter Date")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [MaxLength(500, ErrorMessage = "Desciption Max length must less then or equal to 500 character")]
        [Display(Name = "Desciption")]
        public string Description { get; set; } = null!;

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ModificationDate { get; set; }
    }
}
