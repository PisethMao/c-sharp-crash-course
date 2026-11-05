using FirstProgram._20._C__New_Features.C__8.Positional_Patterns.Class;
using FirstProgram._20._C__New_Features.C__8.Positional_Patterns.Nested;
using FirstProgram._20._C__New_Features.C__8.Positional_Patterns.Property;
using Student = FirstProgram._20._C__New_Features.C__8.Positional_Patterns.Record.Student;

namespace FirstProgram._20._C__New_Features.C__8.Positional_Patterns;

public class PositionalPattern
{
    public static void Run()
    {
        // 1. Using Tuple Positional
        var student = ("John Doe", 21);
        Console.WriteLine(student is ("John Doe", 21)
            ? "Student is John Doe"
            : "Not Student is John Doe");
        // 2. Using Record Positional
        Student student1 = new(1, "John", 21);
        Console.WriteLine(student1 is (1, "John Doe", 21)
            ? "Student is John Doe"
            : "Student is not John Doe");
        // 3. Using Class Positional
        Person person = new("John", 21);
        if (person is ("John", 21))
        {
            Console.WriteLine("Person is John Doe");
        }

        // 4. Using Var Positional
        var student2 = ("John Doe", 21);
        var (name, age) = student2;
        Console.WriteLine($"Name: {name}, Age: {age}");

        // 5. Using Discard Positional
        var student3 = (1001, "John Doe", 21);
        if (student3 is (1001, _, _))
        {
            Console.WriteLine("Student ID is matched!");
        }

        if (student3 is (_, "John Doe", _))
        {
            Console.WriteLine("Student Name is matched!");
        }

        if (student3 is (_, _, >= 18))
        {
            Console.WriteLine("Student Age is an Adult!");
        }

        // 6. Using Relational and Logical Positional
        var employee = ("John Doe", 21, 370m);
        if (employee is ("John Doe", >= 18 and <= 60, <= 400m))
        {
            Console.WriteLine("Employee Information is matched!");
        }

        // 7. Using Nested Positional
        Nested.Student student4 = new("John Doe", 21,
            new Address("Phnom Penh", "Cambodia"));
        if (student4 is ("John Doe", >= 18,
            ("Phnom Penh", "Cambodia")))
        {
            Console.WriteLine("Student is matched!");
        }

        // 8. Using Switch Positional
        var point = (0, 10);
        var result = point switch
        {
            (0, 0) => "Origin",
            (0, _) => "Y-Axis",
            (_, 0) => "X-Axis",
            (> 0, > 0) => "First Quadrant",
            _ => "Other Positional Pattern"
        };
        Console.WriteLine($"Result: {result}");

        // 9. Combining Positional and Property
        Employee employee1 = new("John Doe", 21) 
            { Department = "Engineering" };
        if (employee1 is ("John Doe", >= 18))
        {
            Console.WriteLine("Employee is matched!");
        }
        
        // 10. Using Named Positional
        var student5 = (Id: 1001, Name: "John Doe", Age: 21);
        if (student5 is (Id: 1001, Name: "John Doe", Age: >= 18))
        {
            Console.WriteLine("Student is matched!");
        }
    }
}