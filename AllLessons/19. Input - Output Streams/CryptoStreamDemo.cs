using System.Security.Cryptography;
using System.Text;

namespace FirstProgram._19._Input___Output_Streams;

public class CryptoStreamDemo
{
    public static void Run()
    {
        const string message = "Hello Secure C# Stream!";
        using var aes = Aes.Create();
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;
        aes.GenerateKey();
        aes.GenerateIV();
        var original = Encoding.UTF8.GetBytes(message);
        byte[] encrypted;
        using (MemoryStream ms = new())
        {
            using (CryptoStream cs = new(
                       ms,
                       aes.CreateEncryptor(),
                       CryptoStreamMode.Write,
                       leaveOpen: true))
            {
                cs.Write(original, 0, original.Length);
                cs.FlushFinalBlock();
            }

            encrypted = ms.ToArray();
        }

        Console.WriteLine($"Encrypted: {encrypted.Length}");
        using MemoryStream input = new(encrypted);
        using CryptoStream decryptor = new(
            input, aes.CreateDecryptor(), CryptoStreamMode.Read);
        using MemoryStream output = new();
        decryptor.CopyTo(output);
        var decrypted = Encoding.UTF8.GetString(output.ToArray());
        Console.WriteLine($"Decrypted: {decrypted}");
    }
}