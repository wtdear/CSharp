using System.Security.Cryptography;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.Write("Choice password: ");
        string pass = Console.ReadLine();

        MD5 MD5Hash = MD5.Create();

        byte[] inputBytes = Encoding.ASCII.GetBytes(pass); 
        byte[] hash = MD5Hash.ComputeHash(inputBytes); 

        pass = Convert.ToHexString(hash);
        Console.WriteLine(pass);
    }
}