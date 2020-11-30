using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_Practice_02
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();

        }

        int click = 1;
        private void label53_Click(object sender, EventArgs e)
        {

            Label b = (Label)sender;
            if (click == Convert.ToInt32(b.Text) && click != 52)
            {
                if (click == 51)
                {
                    label55.Text = "Вы нашли все цифры!";
                    label56.Text = "";
                    timer1.Stop();
                }
                click++;
                label56.Text = Convert.ToString(click);
            }

        }
    }
}
