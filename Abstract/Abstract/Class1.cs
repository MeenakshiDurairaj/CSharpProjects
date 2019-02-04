using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Class1
    {
        public string name = "cat";
        public abstract string sound(); //all classes that inherit Animal must have a sound method

        public string testsound()
        {
            return "Meow";
        }
    }
    public class cat : Class1
    {
        public cat()
        {
            //this.name = "Cat";
        }
        public override string  sound() //implemented sound method from the abstract class & method
        {
            return name;
        }
    }
}
