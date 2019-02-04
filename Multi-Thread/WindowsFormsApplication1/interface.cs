using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface A
    {
         void A();
    }
    interface B
    {
       void B();
    }
    class @interface:A
    {
        void A.A()
        {
            throw new NotImplementedException();
        }
      

    }
}
