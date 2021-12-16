using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            InitializeComponent();
        }
        private async void buttonMove(object sender, EventArgs e) 
        {
            int i = Convert.ToInt32(sender.ToString().Substring(35)) - 1;
            
            for (int p = 0; p < 10; p++) 
            {
                myBtn[p].Name = i.ToString();
            }     
                            
            for (int count = 0; count < 10; count++)
            {
                myBtn[count].Click -= buttonMove;
                myBtn[count].Click += buttonChangeNumber;
            }

            while (true ) { 
                for (int j = 0; j < 20; j++)
                {
                    await Task.Delay(5);
                    myBtn[i].Location = new Point(myBtn[i].Location.X, myBtn[i].Location.Y - 1);
                }
                for (int k = 0; k < 20; k++)
                {
                    await Task.Delay(5);
                    myBtn[i].Location = new Point(myBtn[i].Location.X, myBtn[i].Location.Y + 1);
                }
            }
        }

        private void buttonChangeNumber(object sender, EventArgs e) {
            int i = Convert.ToInt32(sender.ToString().Substring(35)) - 1;
            Random rnd = new Random();
            int rndValue = rnd.Next(1, 10);
            myBtn[Convert.ToInt32(myBtn[i].Name)].Text = rndValue.ToString();
        }
    }
}
