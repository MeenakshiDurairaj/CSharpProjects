using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        private void button1_Click(object sender, EventArgs e)
        {
            Thread firstthread = new Thread(new ThreadStart(func1));
            Thread secondthread = new Thread(new ThreadStart(func2));
            firstthread.Start();
            //Thread.Sleep(1000);//blocks the current executing thread for 1 second
            secondthread.Start();
            bool threadalive = firstthread.IsAlive;
            //MessageBox.Show(threadalive.ToString());
            int i =(int) Days.Fri;
            MessageBox.Show(Days.Sun.ToString());
            MessageBox.Show(i.ToString());
        }
        void func1()
        {
             for(int i =1;i<=5;i++)
            {
                //MessageBox.Show("Function1 writes = " + i);
            }
        }
        void func2()
        {
            for (int i = 10; i > 5; i--)
            {
                //MessageBox.Show("Function2 writes = " + i);
            }
        }

    }
}
