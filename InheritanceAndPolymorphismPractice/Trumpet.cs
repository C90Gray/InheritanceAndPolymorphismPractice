using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Trumpet : Instrument
    {
        private bool muteIn;

        public bool MuteIn
        {
            get { return this.muteIn; }
            set { this.muteIn = value; }
        }

        public Trumpet(bool muteIn, bool isAcoustic) : base("Trumpet", "Bb")
        {
            this.muteIn = muteIn;
            this.IsAcoustic = isAcoustic;
        }

        public void Tune()
        {
            Random r = new Random();
            int cent = r.Next(1, 23);

            Console.WriteLine("You are " + cent + " cents sharp!");

        }

        public void Spit()
        {
            Console.WriteLine("You could have at least used a towel instead of emptying your spit all over the floor...");
        }

        
    
    }
}
