using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = "test";

            Console.WriteLine(SecurityTools.Encrypting.Encrypt(plainText));
            Console.ReadLine();
            Console.WriteLine(SecurityTools.Encrypting.Decrypt(SecurityTools.Encrypting.Encrypt(plainText)));
            Console.ReadLine();
        }
    }
}
