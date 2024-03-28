using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purble_Place_Luncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();//This is for STart the timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(4);
            label3.Text = progressBar1.Value.ToString() + "%";//This is for progress bar's prgress in number with % 
            if (progressBar1.Value == 100)
            {
                timer1.Stop();//This is for Stop the timer
                Form2 form2 = new Form2();//Line 32 and 33 for Go to Form 2 
                form2.Show();         //Line 33     
                this.Hide();///This is For hide form1
            }
       } 
    }
}
