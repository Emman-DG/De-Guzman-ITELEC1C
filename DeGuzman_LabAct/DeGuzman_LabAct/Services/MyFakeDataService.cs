using DeGuzman_LabAct.Services;
using DeGuzman_LabAct.Models;
namespace DeGuzman_LabAct.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }
        //Constructor
        public MyFakeDataService() 
        {
            StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "ghaby021@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "zyx@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "aerdriel@gmail.com"
                }
            };

            InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,
                    FName = "Jason",
                    LName = "Beltran",
                    Rank = Rank.Instructor,
                    HiringDate = DateTime.Parse("2022-08-26"),
                    IsTenured = true
                },
                new Instructor()
                {
                    Id= 2,
                    FName = "Manuel",
                    LName = "Barce",
                    Rank = Rank.AssistantProfessor,
                    HiringDate = DateTime.Parse("2022-08-07"),
                    IsTenured = true
                },
                new Instructor()
                {
                    Id= 3,
                    FName = "Mikhail",
                    LName = "De Guzman",
                    Rank = Rank.AssociateProfessor,
                    HiringDate = DateTime.Parse("2020-01-25"),
                    IsTenured = false
                },
                new Instructor()
                {
                    Id= 4,
                    FName = "Marie",
                    LName = "Ronquillo",
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("2019-01-25"),
                    IsTenured = true
                }
            };
        }

    }
}
