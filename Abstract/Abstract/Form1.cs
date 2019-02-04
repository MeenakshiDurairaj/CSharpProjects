using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cannot create an instance of the abstract class
            //Class1 m_abstract = new Class1();
            cat m_cat = new cat();
            MessageBox.Show(m_cat.sound());
            MessageBox.Show(m_cat.testsound());
        }
    }
}
