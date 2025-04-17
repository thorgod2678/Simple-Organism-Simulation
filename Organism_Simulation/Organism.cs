using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organism_Simulation
{
    public class Organism
    {
        //simulation releated variables
        public Point position;
        public Rectangle sense;
        public float energy;
        public float idle_eu;
        public float move_eu;
        public int sense_size;
        public int speed;
      
        public bool dead;
        public float waste;
        
        //visualisation releated variables
        
        public bool selected;
      
    }
}
