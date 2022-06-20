using System;

namespace Syntax_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var answer = 4;
            //string response;
            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";
            //}
            
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
        }
    }
}
