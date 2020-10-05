using System;

namespace IF_compatto
{
    //operatore condizionale ?
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            operatoreSuVariabile();
            Console.WriteLine("---------------");
            operatoreWriteLine();


            void operatoreSuVariabile()
            {
                double op1 = 5, op2 = 2;
                var result = op1 > op2 ? op2 / op1 : op1 / op2;
                Console.WriteLine(result);
            }

            void operatoreWriteLine()
            {
                string s1 = "ciao";
                Console.WriteLine("String = " + s1);
                Console.WriteLine(s1 == "ciao" ? "Equal to 'ciao'" : "NOT equal to 'ciao'");
                
                Console.WriteLine("---------------");
                
                s1 = "NOTciao";
                Console.WriteLine("String = " + s1);
                Console.WriteLine(s1 == "ciao" ? "Equal to 'ciao'" : "NOT equal to 'ciao'");
            }

        }
    }
}
