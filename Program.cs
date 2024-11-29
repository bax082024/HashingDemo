using System;
using System.Security.Cryptography;
using System.Text;

namespace HashingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hashing Demo");

            // Get user input
            Console.WriteLine("Enter string to hash");
            string input = Console.ReadLine();

            // Hash string usig SHA-256
            string hashedString = ComputeSHA256Hash(input);

            // Display hashed value
            Console.WriteLine($"SHA-256 Hash: {hashedString}");
        }

        static string ComputeSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert input to bytes
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);

                // Compute Hash
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Convert hash bytes to hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }

        }
    }

}