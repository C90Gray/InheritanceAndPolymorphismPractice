using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Trumpet cornet = new Trumpet(false, true);

            Piano rhodes = new Piano(87, false);

            cornet.Tune();

            cornet.Spit();

            Console.WriteLine(rhodes.IsAcoustic);

            rhodes.Keyboard();

            Console.WriteLine(rhodes.IsAcoustic);

            rhodes.Play();

            Console.WriteLine(cornet.IsAcoustic);

            cornet.Play();
            

           



        }
    }
}
