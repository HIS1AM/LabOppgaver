using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {

        static void Main(string[] args)//entry
        {
            Program prog=new Program();
            //prog.Oppgave1();
            prog.PrintStar();

            

        }

        private void Oppgave1()
        {
            ///her er en oppg 0109
            ///oppg om temp
            ///
            Console.WriteLine("tast inn temp");
            //lese inn verdi fra console
            string stringTemp = Console.ReadLine();
            //konvertere stringen til et tall ved å bruke parse
            int temp = int.Parse(stringTemp);

            if (temp > 0)
            {
                Console.WriteLine("Plussgrader");
            }
            else if (temp < 0)
            {
                Console.WriteLine("minusgrader");
            }
            else
            {
                Console.WriteLine("det er null");
            }

            //if (temp == 0)
            //{
            //    Console.WriteLine("det er 0");
            //}


            //en ny oppg
            int test = 1;
            Console.ReadKey();
        }


        private void PrintStar()
        {
            int num = 7;

            for(int i=0;i<=num;i++)
                Console.WriteLine("*");
        }

    }
}
