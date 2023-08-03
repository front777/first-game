using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameWithLetters;

namespace GameWithLetters
{
    public partial class Form2 : Form
    {
      
        public static int SetTimeOut;
        
        public Form2()
        {
            InitializeComponent();
        }

        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 25;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();

           
             Form1.t.Enabled = true;
            Form1.t.Start();
            this.Close();
            SetTimeOut = trackBar1.Value;

        }
    }
}
