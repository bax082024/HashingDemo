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

    }

}