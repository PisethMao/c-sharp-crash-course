namespace FirstProgram._20._C__New_Features.C__8.Property_Patterns;

public class Program
{
    public static void Run()
    {
        Person person = new()
        {
            Name = "John Doe",
            Age = 21,
            IsActive = true,
            Address = new Address
            {
                City = "Phnom Penh",
                Country = "Cambodia"
            }
        };
        // 1. Use Single Property
        if (person is { Age: 21 })
        {
            Console.WriteLine($"Person {person.Name} is {person.Age} years old.");
        }

        // 2. Use Multiple Property
        if (person is { Name: "John Doe", Age: 21, IsActive: true })
        {
            Console.WriteLine($"Person {person.Name} is {person.Age} years old.");
        }

        // 3. Use Typed Property
        object data = person;
        if (data is Person { Age: >= 18, IsActive: true })
        {
            Console.WriteLine($"Person {person.Name} is {person.Age} years old.");
        }

        // 4. Use Empty Property
        Person? secondPerson = null;
        CheckPerson(person);
        Console.WriteLine(secondPerson is { });

        // 5. Nested Property
        if (person is
            {
                Age: 21,
                Address: { City: "Phnom Penh", Country: "Cambodia" }
            })
        {
            Console.WriteLine($"Person {person.Name} is {person.Age} years old.");
        }

        // 6. Extended Property
        if (person is
            {
                Age: 21, IsActive: true,
                Address.City: "Phnom Penh", Address.Country: "Cambodia"
            })
        {
            Console.WriteLine($"Person {person.Name} is {person.Age} years old.");
        }

        // 7. Relational Property
        if (person is { Age: >= 18 })
        {
            Console.WriteLine($"Person {person.Name} is {person.Age} years old.");
        }

        // 8. Logical Property
        if (person is { Age: >= 18 and <= 30 })
        {
            Console.WriteLine($"Person {person.Name} is {person.Age} years old.");
        }

        if (person is { Age: 18 or 25 or 30 })
        {
            Console.WriteLine($"Person {person.Name} is {person.Age} years old.");
        }

        if (person is { Name: not "Devid" })
        {
            Console.WriteLine("Name is not Devid");
        }

        // 9. Null Property
        if (person is { Address: { } })
        {
            Console.WriteLine("Address is exists!");
        }

        // 10. Capturing Property
        if (person is { Name: var name, Age: var age })
        {
            Console.WriteLine($"Person {name} is {age} years old.");
        }

        // 11. Switch Property
        Console.WriteLine(GetStatus(person));
    }

    private static string GetStatus(Person? person)
    {
        return person switch
        {
            null => "No Person",
            { Age: < 18 } => "Minor",
            { Age: >= 18, IsActive: true } => "Active Adult",
            { Age: >= 18, IsActive: false } => "Inactive Adult"
        };
    }

    private static void CheckPerson(Person? person)
    {
        Console.WriteLine(person is { });
    }
}