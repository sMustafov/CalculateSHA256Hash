using System;
using System.Security.Cryptography;
using System.Text;

namespace CalculateSHA256Hash
{
    class CalculateSHA
    {
        public static void Main(string[] args)
        {
            string result = getHashSha256("Hello_World");

            Console.WriteLine(result);
        }

        public static string getHashSha256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);

            SHA256Managed hashstring = new SHA256Managed();

            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = null;

            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }

            return hashString;
        }
    }
}