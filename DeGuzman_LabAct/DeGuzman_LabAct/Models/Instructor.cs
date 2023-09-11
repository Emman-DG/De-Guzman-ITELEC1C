namespace DeGuzman_LabAct.Models
{

    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public Rank Rank { get; set; }
        public DateTime HiringDate { get; set; }
        public bool IsTenured { get; set; }
    }
}
