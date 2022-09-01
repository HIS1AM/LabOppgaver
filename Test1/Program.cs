using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int alder = 8;
                

            if (alder > 17)
            {
                //Console.WriteLine("Gammel nok til å kjøre bil");
            }
            else
            {
                //Console.WriteLine("ikke Gammel nok til å kjøre bil");
            }


            
            


            ///her er en oppg 0109
            ///oppg om temp
            ///
            Console.WriteLine("tast inn temp");
            //lese inn verdi fra console
            string stringTemp=Console.ReadLine();
            //konvertere stringen til et tall ved å bruke parse
            int temp=int.Parse(stringTemp);

            if(temp>0)
            {
                Console.WriteLine("Plussgrader");
            }
            else if(temp<0)
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

        private string Test()
        {
            return "tull";
        }
    }
}
