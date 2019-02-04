using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace Singleton
{
    //It ensures at any given point of time only one instance of an object is alive
    public sealed class Singleton
    {
       
        //we should mark the constructor of the type as private member
        private Singleton() { }

        //“static” means “relating to the type itself, rather than an instance of the type”.
        //    You access a static member using the type name instead of a reference or a value, e.g.Singleton.Instance.

        public static Singleton Obj_instance = null;
        public static Singleton Instance
        {
            get
            {
                if (Obj_instance == null)
                {

                    Obj_instance = new Singleton();
                    MessageBox.Show("Created only once");
                }
                return Obj_instance;
            }
        }
        public void testmessage()
        {
            MessageBox.Show("hi.. you did it");
        }
    }
}
