using FirstProgram._15._Packages.SchoolManagement.Models;
using Newtonsoft.Json;

namespace FirstProgram._15._Packages.SchoolManagement;

public class Program
{
    public static void Run()
    {
        var student = new Student { Name = "John Doe" };
        var json = JsonConvert.SerializeObject(student);
        Console.WriteLine(json);
    }
}