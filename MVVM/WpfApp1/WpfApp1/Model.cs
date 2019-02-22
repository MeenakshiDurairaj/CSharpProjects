using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Model
    {
        Model()
        {
            // Initialize.
        }
        public string m_name
        {
            get;set;
        }
        static readonly Model _instance = new Model();
        public static Model Instance
        {
            get
            {
                return _instance;
            }
        }
    


        public Model m_Model
        {
            get
            {
                return m_Model;
            }
        }
    }
}
