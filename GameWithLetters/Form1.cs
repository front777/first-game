using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWithLetters
{
    
    public partial class Form1 : Form
    {
       public static Timer t = new Timer();
        List<Button> listtt;
       
        List<int> intList = new List<int>();
        List<int> intList2 = new List<int>();
        public Form1()
        {
            InitializeComponent();
            createBtns();
            
           
            

            t.Enabled = true;


        }
        
    
       void t_Tick(object sender, EventArgs e)
        {
            string f = trackBar1.Value.ToString();
            string s = "000";
            string sum = f + s;
            int sumAll = Convert.ToInt32(sum);
            t.Interval = sumAll;
            
            if (trackBar1.Value > 0)
            {
                
                t.Start();
                progressBar1.Increment(49);
          
            }
            else
            {
              
                
                t.Stop();
               

                MessageBox.Show("please enter seconds");
            }
          if(progressBar1.Value == progressBar1.Maximum)
            {
               
                t.Stop();
                progressBar1.Value = 0;
              
                

                    if (String.Join(" ", intList) == String.Join(" ", intList2))
                    {
                        MessageBox.Show("You win");
                    this.Close();
                   
                    }
                    else
                    {
                        MessageBox.Show("lox");
                    this.Close();
                    }
                    
                    foreach (Button button in listtt)
                    {
                        button.Text = " ";
                        button.BackColor = Color.White;
                        
                }
                
                    
            
            }
          
            
        }
      
        public void createBtns()
        {
           listtt = new List<Button>();
            
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    var btn = new Button()
                    {
                        Width = 60,
                        Height = 60,
                        Location = new Point(i * 70, j * 75),
                        BackColor = Color.White
                        
                    };
                    btn.Click += ClicksBtn;
                    listtt.Add(btn);
                    panel1.Controls.Add(btn);
                    
                }
                

            }
          
        }
        void ClicksBtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text + Environment.NewLine;
            int sum = Int16.Parse(btn.Text);
            btn.BackColor = Color.DarkBlue;
            btn.ForeColor = Color.White;
            intList.Add(sum);
            intList2.Add(sum);
            intList.Sort();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            foreach (Button btn2 in listtt)
            {
                btn2.Text = rnd.Next(0, 100).ToString();
                

            }
           

        }

       

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Maximum = 25;
            label1.Text = trackBar1.Value.ToString() ;   

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                MessageBox.Show("cunning");
                this.Close();
            }
            else
            {
                t.Tick += new EventHandler(t_Tick);

                progressBar1.Maximum = 100;
            }
           
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        }
       

    
}
