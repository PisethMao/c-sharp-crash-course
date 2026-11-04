namespace FirstProgram._19._Input___Output_Streams;

public class BinaryStreamDemo
{
    public static void Run()
    {
        const string path = "student.bin";
        using (FileStream fs = new(path, FileMode.Create, FileAccess.Write))
        using (BinaryWriter bw = new(fs))
        {
            bw.Write(101);
            bw.Write("Piseth");
            bw.Write(95.5);
            bw.Write(true);
        }

        Console.WriteLine("Binary Data Save!");
        using (FileStream fs = new(path, FileMode.Open, FileAccess.Read))
        using (BinaryReader br = new(fs))
        {
            var count = br.ReadInt32();
            var name = br.ReadString();
            var value = br.ReadDouble();
            var isActive = br.ReadBoolean();
            Console.WriteLine($"ID: {count}, Name: {name}, Value: {value}, IsActive: {isActive}");
        }
    }
}