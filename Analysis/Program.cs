using System;
using System.Text;

namespace Analysis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var s0 = "Ahmed";
            s0 = "Tarek";
            Console.WriteLine(s0); // Tarek

            var s1 = "Ahmed";
            var s2 = "Ahmed";
            Console.WriteLine(s1 == s2); // True
            Console.WriteLine(Object.ReferenceEquals(s1, s2)); // True

            var s3 = "Ahmed";
            char[] charArray1 = { 'A', 'h', 'm', 'e', 'd' };
            var s4 = new String(charArray1);
            char[] charArray2 = { 'A', 'h', 'm', 'e', 'd' };
            var s5 = new String(charArray2);
            Console.WriteLine(s3 == s4 && s4 == s5); // True
            Console.WriteLine(Object.ReferenceEquals(s3, s4)); // False
            Console.WriteLine(Object.ReferenceEquals(s4, s5)); // False

            var s6 = "Ahmed";
            var s7 = s6;
            s6 = "Tarek";
            Console.WriteLine(s6); // Tarek
            Console.WriteLine(s7); // Ahmed

            var s8 = "Ahmed";
            var s9 = s8;
            UpdateStr(ref s8);
            Console.WriteLine(s8); // Ahmed_
            Console.WriteLine(s9); // Ahmed

            var s10 = "";

            for (var i = 1; i <= 5000; i++)
            {
                s10 += i;
            }

            Console.WriteLine(s10);

            var builder = new StringBuilder();

            for (var i = 1; i <= 5000; i++)
            {
                builder.Append(i);
            }

            Console.WriteLine(builder.ToString());

            Console.ReadLine();
        }

        public static void UpdateStr(ref string str)
        {
            str += "_";
        }
    }
}