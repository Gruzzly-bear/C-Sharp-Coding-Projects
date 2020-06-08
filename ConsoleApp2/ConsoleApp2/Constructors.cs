
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
            inputName1 = inputName;
            inputHealth1 = inputHealth;
        }
        public Fname() { }
        public string inputName1 { get; set; }
        public int inputHealth1 { get; set; }





    }
}