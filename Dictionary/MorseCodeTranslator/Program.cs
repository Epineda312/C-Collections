using System;

namespace Practice
{
    class Program
    {
        public static void Main()
        {
            while(true)
            {
              Console.Write(": ");
              string input = Console.ReadLine();
              
              if(string.IsNullOrWhiteSpace(input))
              {
                break;
              }
                 
              string output = MorseCodeTranslator.ToMorse(input);            
              Console.WriteLine(output);
              }
        }
     } 
 }

 