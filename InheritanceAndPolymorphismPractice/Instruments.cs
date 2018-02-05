using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Instrument
    {
        protected string name;
        protected string kind;
        protected bool isAcoustic;
        protected string concertKey;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string ConcertKey
        {
            get { return this.concertKey; }
            set { this.concertKey = value; }
        }

        public bool IsAcoustic
        {
            get { return this.isAcoustic; }
            set { this.isAcoustic = value; }
        }

        public Instrument()
        {

        }

        public Instrument (string name, string concertKey)
        {
            this.name = name;
            this.concertKey = concertKey;
        }

        //this virtual keyword allows this method to be used by all derived classes!
        public virtual void Play()
        {
            if (isAcoustic == true)
            {
                Console.WriteLine("\a");
            }
            else
            {
                Console.WriteLine("That thing's a computer, not an instrument");
            }
        }
    }
}
