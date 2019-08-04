using System;
using System.Text;

namespace SoloLearn
{
	class Program
	{
	    static string generatePswd(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(validChars[rnd.Next(validChars.Length)]);
            }
            return res.ToString();
        }
        
		static void Main(string[] args)
		{
			Console.Write("Enter how many passwords you want to generate: ");
			int numpass = int.Parse(Console.ReadLine());
			for(int i=0; i<numpass; i++)
			{
				Console.Write("Select a length for {0}. pasword: ", i+1);
				int length = int.Parse(Console.ReadLine());
				string pass = generatePswd(length);
				Console.WriteLine("Your {0}. password: {1}", i+1, pass);
			}
		}
	}
}