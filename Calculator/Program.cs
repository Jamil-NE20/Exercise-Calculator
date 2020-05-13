using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Enter The FirstNumber: ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Operator: ");
            char Operator = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter The SecondNumber: ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            if (Operator == '+')
            { 
                Console.WriteLine("Output:\n {0} + {1} = {2}", FirstNumber, SecondNumber, FirstNumber + SecondNumber);
            }
            else if (Operator == '-')
            {
                Console.WriteLine("Output:\n {0} - {1} = {2}", FirstNumber, SecondNumber, FirstNumber - SecondNumber);
            }   
            else if (Operator == '*')
            {
                Console.WriteLine("Output:\n {0} * {1} = {2}", FirstNumber, SecondNumber, FirstNumber * SecondNumber);
            }
            else if (Operator == '/')
            {
                             
                Console.WriteLine("Output:\n {0} / {1} = {2}", FirstNumber, SecondNumber, FirstNumber / SecondNumber);
            }   
            else
            {
                Console.WriteLine("You enter the wrong Operation! Have Nice Day!");
            }        
            Console.ReadLine();
        }
    }
}
