using FirstProgram._15._Packages.SchoolManagement.Models;

namespace FirstProgram._15._Packages.SchoolManagement.Services;

public static class StudentService
{
    public static void PrintStudent(Student student)
    {
        Console.WriteLine(student.Name);
    }
}