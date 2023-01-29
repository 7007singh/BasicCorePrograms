using System;

namespace BasicCorePrograms
{
    internal class VowelConsonant
    {
        public static void CheckVowelOrConsonant() 
        {
            Console.WriteLine("Please Enter a Alphabet to Check Whether it is Vowel or Not");
            char albhabet = Convert.ToChar(Console.ReadLine());
            if (albhabet == 'a' || albhabet == 'e' || albhabet == 'i' || albhabet == 'O' || albhabet == 'u')
            {
                Console.WriteLine("{0} is a Vowel", albhabet);
            }
            else
            {
                Console.WriteLine("{0} is Consonant", albhabet);
            }
        }
    }
}
