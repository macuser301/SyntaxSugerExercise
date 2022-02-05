using System;

namespace SyntaxSugerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int answer = 88.9;
              string response;

              if (answer < 47)
              {
                  response = answer + " is less than forty-seven";
              }
              else
              {
                  response = answer + “greater than or equal to forty-seven”;
              }*/

            var answer = 88.9;
            var response = (answer < 47) ? $"{answer} is less than forty-seven" : $"{answer} is greater than forty-seven";

            Console.WriteLine(response);











        }
    }
}
