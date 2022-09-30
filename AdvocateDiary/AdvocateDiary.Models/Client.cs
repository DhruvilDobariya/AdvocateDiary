using System.ComponentModel.DataAnnotations;

namespace AdvocateDiary.Models
{
    public class Client
    {
        public Client()
        {
            Cases = new HashSet<Case>();
            Fees = new HashSet<Fees>();
        }

        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        [MaxLength(250, ErrorMessage = "Name Max length must less then or equal to 250 character")]
        [MinLength(1, ErrorMessage = "Name must at least one character")]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Please Enter Gender")]
        [MaxLength(50, ErrorMessage = "Gender Max length must less then or equal to 50 character")]
        [MinLength(1, ErrorMessage = "Gender must at least one character")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Gender")]
        public string Gender { get; set; } = null!;

        [Required(ErrorMessage = "Please Enter Date of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please Enter Contect No")]
        [MaxLength(50, ErrorMessage = "Contect No Max length must less then or equal to 50 character")]
        [MinLength(1, ErrorMessage = "Contect No must at least one character")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contect No")]
        public string ContectNo { get; set; } = null!;

        [MaxLength(250, ErrorMessage = "Email Max length must less then or equal to 250 character")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [MaxLength(500, ErrorMessage = "Address Max length must less then or equal to 500 character")]
        [Display(Name = "Address")]
        public string? Address { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ModificationDate { get; set; }

        public virtual ICollection<Case> Cases { get; set; }
        public virtual ICollection<Fees> Fees { get; set; }
    }
}
