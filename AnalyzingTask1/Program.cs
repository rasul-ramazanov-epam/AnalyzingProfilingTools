// See https://aka.ms/new-console-template for more information
using AnalyzingTask1;
using System.Security.Cryptography;

public class Program
{
    private static void Main(string[] args)
    {
        var generator = new PasswordGenerator();

        string passwordText = "MySuperSecurePassword";
        byte[] salt;
        new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
        generator.GeneratePasswordHashUsingSalt(passwordText, salt);

        Console.WriteLine("Hello world");
    }
}