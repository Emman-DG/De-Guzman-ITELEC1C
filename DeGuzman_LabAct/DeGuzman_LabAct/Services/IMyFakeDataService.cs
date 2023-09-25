using DeGuzman_LabAct.Models;

namespace DeGuzman_LabAct.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }

        List<Instructor> InstructorList { get; }
    }
}
