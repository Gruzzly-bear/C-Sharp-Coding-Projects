
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Fname
    {
        public Fname(string inputName) : this (inputName, 100)
        {

        }
        public Fname(string inputName, int inputHealth)
        {
            
        }
        public Fname() { }
        public string inputName { get; set; }
        public int inputHealth { get; set; }





    }
}