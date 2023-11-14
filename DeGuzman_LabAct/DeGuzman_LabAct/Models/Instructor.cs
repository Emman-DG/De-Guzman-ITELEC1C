using System.ComponentModel.DataAnnotations;

namespace DeGuzman_LabAct.Models
{

    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {

        [Required]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string? FName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string? LName { get; set; }

        [Display(Name = "Is Tenured")]
        public bool IsTenured { get; set; }

        [Required]
        [Display(Name = "Academic Rank")]
        public Rank Rank { get; set; }

        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}",
            ErrorMessage = "You must follow the format 000-000-0000!")]
        [Display(Name = "Office Phone Number")]
        public string? PhoneNumber { get; set; }

        [EmailAddress]
        [Display(Name = "Email Address")]
        public string? EmailAddress { get; set; }

        [Url]
        [Display(Name = "Personal Webpage")]
        public string? Url { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Password (we won't use this!)")]
        [DataType(DataType.Password)]
        public string? UnusedPassword { get; set; }
    }
}
