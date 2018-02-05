using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Piano : Instrument
    {
        private int keys;

        public int Keys
        {
            get { return this.keys; }
            set { this.keys = value; }
        }

        public Piano(int keys, bool isAcoustic) : base("Piano", "C")
        {
            this.keys = keys;
            this.IsAcoustic = isAcoustic;
        } 

        public void Keyboard()
        {
            if (isAcoustic == false)
            {
                isAcoustic = true;
                Console.WriteLine("You unplugged the keyboard");
            }
            else if (isAcoustic == true)
            {
                isAcoustic = false;
                Console.WriteLine("The keyboard is unplugged. Let's plug it in...");     
            }
        }

        public void GiveUp()
        {
            Console.WriteLine("After violently slamming down on all of the keys, you have quit practicing the piano");
        }


    }
}
