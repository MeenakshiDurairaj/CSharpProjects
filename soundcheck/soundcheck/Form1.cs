using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soundcheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //SpeechRecognizer speechRecognizer = new SpeechRecognizer();
            listView1.View = View.Details;
            listView1.Columns.Add("Songs");
            listView1.Items.Add(soundcheck.Resource1.Neethanae_Neethane_MassTamilan_com.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = soundcheck.Resource1.Neethanae_Neethane_MassTamilan_com;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = soundcheck.Resource1.Neethanae_Neethane_MassTamilan_com;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Stop();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Command invoked: Open");
        }
    }
}
