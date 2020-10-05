using System;

namespace IF_compatto
{
    //operatore condizionale ?
    //DOC: https://docs.microsoft.com/it-it/dotnet/csharp/language-reference/operators/conditional-operator#:~:text=%20Operatore%20%3F%3A%20%28Riferimenti%20per%20C%23%29%3F%3A%20operator%20%28C%23,degli%20operatori%0AOperator%20overloadability.%20Un%20tipo%20definito...%20More%20
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
