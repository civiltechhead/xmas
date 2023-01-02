using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // tree parameters: SIZE = 402,464
            top_p1.Parent = tree;
            top_p1.Location = new Point(126,0);
            top_p1.BackColor = Color.Transparent;

            first_row_p1.Parent = tree;
            first_row_p1.Location = new Point(65,100);

            first_row_p2.Parent = tree;
            first_row_p2.Location = new Point(126,110);

            first_row_p3.Parent = tree;
            first_row_p3.Location = new Point(187,100);

            second_row_p1.Parent = tree;
            second_row_p1.Location = new Point(35,160);

            second_row_p2.Parent = tree;
            second_row_p2.Location = new Point(126,185);

            second_row_p3.Parent = tree;
            second_row_p3.Location = new Point(217,160);

            third_row_p1.Parent = tree;
            third_row_p1.Location = new Point(15,230);

            third_row_p2.Parent = tree;
            third_row_p2.Location = new Point(126,240);

            third_row_p3.Parent = tree;
            third_row_p3.Location = new Point(237,230);

            last_row_p1.Parent = tree;
            last_row_p1.Location = new Point(0,290);

            last_row_p2.Parent = tree;
            last_row_p2.Location = new Point(126,320);

            last_row_p3.Parent = tree;
            last_row_p3.Location = new Point(252,290);
        }

        private void top_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(top_1.SelectedIndex == 0)
            {
                top_p1.Image = null;
            }
            else if(top_1.SelectedIndex == 1)
            {
                top_p1.Image = Properties.Resources.star_transparent; 
            }
            else if(top_1.SelectedIndex == 2)
            {
                top_p1.Image = Properties.Resources.pstar_transparent;
            }
        }

        private void first_row_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Items: (0) Blue ball (1) Kirby (2) Some kid (3) Minecraft block (4) Fortnite

            if (first_row_1.SelectedIndex == 0)
            {
                first_row_p1.Image = null;
            }
            else if (first_row_1.SelectedIndex == 1)
            {
                first_row_p1.Image = Properties.Resources.bb_t;
            }
            else if (first_row_1.SelectedIndex == 2)
            {
                first_row_p1.Image = Properties.Resources.kirby_t;
            }
            else if (first_row_1.SelectedIndex == 3)
            {
                first_row_p1.Image = Properties.Resources.dude_t;
            }
            else if (first_row_1.SelectedIndex == 4)
            {
                first_row_p1.Image = Properties.Resources.mc_t;
            }
            else if (first_row_1.SelectedIndex == 5)
            {
                first_row_p1.Image = Properties.Resources.why;
            }
        }

        private void first_row_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (first_row_2.SelectedIndex == 0)
            {
                first_row_p2.Image = null;
            }
            else if (first_row_2.SelectedIndex == 1)
            {
                first_row_p2.Image = Properties.Resources.bb_t;
            }
            else if (first_row_2.SelectedIndex == 2)
            {
                first_row_p2.Image = Properties.Resources.kirby_t;
            }
            else if (first_row_2.SelectedIndex == 3)
            {
                first_row_p2.Image = Properties.Resources.dude_t;
            }
            else if (first_row_2.SelectedIndex == 4)
            {
                first_row_p2.Image = Properties.Resources.mc_t;
            }
            else if (first_row_2.SelectedIndex == 5)
            {
                first_row_p2.Image = Properties.Resources.why;
            }
        }

        private void first_row_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (first_row_3.SelectedIndex == 0)
            {
                first_row_p3.Image = null;
            }
            else if (first_row_3.SelectedIndex == 1)
            {
                first_row_p3.Image = Properties.Resources.bb_t;
            }
            else if (first_row_3.SelectedIndex == 2)
            {
                first_row_p3.Image = Properties.Resources.kirby_t;
            }
            else if (first_row_3.SelectedIndex == 3)
            {
                first_row_p3.Image = Properties.Resources.dude_t;
            }
            else if (first_row_3.SelectedIndex == 4)
            {
                first_row_p3.Image = Properties.Resources.mc_t;
            }
            else if (first_row_3.SelectedIndex == 5)
            {
                first_row_p3.Image = Properties.Resources.why;
            }
        }

        private void second_row_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (second_row_1.SelectedIndex == 0)
            {
                second_row_p1.Image = null;
            }
            else if (second_row_1.SelectedIndex == 1)
            {
                second_row_p1.Image = Properties.Resources.bb_t;
            }
            else if (second_row_1.SelectedIndex == 2)
            {
                second_row_p1.Image = Properties.Resources.kirby_t;
            }
            else if (second_row_1.SelectedIndex == 3)
            {
                second_row_p1.Image = Properties.Resources.dude_t;
            }
            else if (second_row_1.SelectedIndex == 4)
            {
                second_row_p1.Image = Properties.Resources.mc_t;
            }
            else if (second_row_1.SelectedIndex == 5)
            {
                second_row_p1.Image = Properties.Resources.why;
            }
        }

        private void second_row_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (second_row_2.SelectedIndex == 0)
            {
                second_row_p2.Image = null;
            }
            else if (second_row_2.SelectedIndex == 1)
            {
                second_row_p2.Image = Properties.Resources.bb_t;
            }
            else if (second_row_2.SelectedIndex == 2)
            {
                second_row_p2.Image = Properties.Resources.kirby_t;
            }
            else if (second_row_2.SelectedIndex == 3)
            {
                second_row_p2.Image = Properties.Resources.dude_t;
            }
            else if (second_row_2.SelectedIndex == 4)
            {
                second_row_p2.Image = Properties.Resources.mc_t;
            }
            else if (second_row_2.SelectedIndex == 5)
            {
                second_row_p2.Image = Properties.Resources.why;
            }
        }

        private void second_row_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (second_row_3.SelectedIndex == 0)
            {
                second_row_p3.Image = null;
            }
            else if (second_row_3.SelectedIndex == 1)
            {
                second_row_p3.Image = Properties.Resources.bb_t;
            }
            else if (second_row_3.SelectedIndex == 2)
            {
                second_row_p3.Image = Properties.Resources.kirby_t;
            }
            else if (second_row_3.SelectedIndex == 3)
            {
                second_row_p3.Image = Properties.Resources.dude_t;
            }
            else if (second_row_3.SelectedIndex == 4)
            {
                second_row_p3.Image = Properties.Resources.mc_t;
            }
            else if (second_row_3.SelectedIndex == 5)
            {
                second_row_p3.Image = Properties.Resources.why;
            }
        }

        private void third_row_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (third_row_1.SelectedIndex == 0)
            {
                third_row_p1.Image = null;
            }
            else if (third_row_1.SelectedIndex == 1)
            {
                third_row_p1.Image = Properties.Resources.bb_t;
            }
            else if (third_row_1.SelectedIndex == 2)
            {
                third_row_p1.Image = Properties.Resources.kirby_t;
            }
            else if (third_row_1.SelectedIndex == 3)
            {
                third_row_p1.Image = Properties.Resources.dude_t;
            }
            else if (third_row_1.SelectedIndex == 4)
            {
                third_row_p1.Image = Properties.Resources.mc_t;
            }
            else if (third_row_1.SelectedIndex == 5)
            {
                third_row_p1.Image = Properties.Resources.why;
            }
        }

        private void third_row_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (third_row_2.SelectedIndex == 0)
            {
                third_row_p2.Image = null;
            }
            else if (third_row_2.SelectedIndex == 1)
            {
                third_row_p2.Image = Properties.Resources.bb_t;
            }
            else if (third_row_2.SelectedIndex == 2)
            {
                third_row_p2.Image = Properties.Resources.kirby_t;
            }
            else if (third_row_2.SelectedIndex == 3)
            {
                third_row_p2.Image = Properties.Resources.dude_t;
            }
            else if (third_row_2.SelectedIndex == 4)
            {
                third_row_p2.Image = Properties.Resources.mc_t;
            }
            else if (third_row_2.SelectedIndex == 5)
            {
                third_row_p2.Image = Properties.Resources.why;
            }
        }

        private void third_row_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (third_row_3.SelectedIndex == 0)
            {
                third_row_p3.Image = null;
            }
            else if (third_row_3.SelectedIndex == 1)
            {
                third_row_p3.Image = Properties.Resources.bb_t;
            }
            else if (third_row_3.SelectedIndex == 2)
            {
                third_row_p3.Image = Properties.Resources.kirby_t;
            }
            else if (third_row_3.SelectedIndex == 3)
            {
                third_row_p3.Image = Properties.Resources.dude_t;
            }
            else if (third_row_3.SelectedIndex == 4)
            {
                third_row_p3.Image = Properties.Resources.mc_t;
            }
            else if (third_row_3.SelectedIndex == 5)
            {
                third_row_p3.Image = Properties.Resources.why;
            }
        }

        private void last_row_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (last_row_1.SelectedIndex == 0)
            {
                last_row_p1.Image = null;
            }
            else if (last_row_1.SelectedIndex == 1)
            {
                last_row_p1.Image = Properties.Resources.bb_t;
            }
            else if (last_row_1.SelectedIndex == 2)
            {
                last_row_p1.Image = Properties.Resources.kirby_t;
            }
            else if (last_row_1.SelectedIndex == 3)
            {
                last_row_p1.Image = Properties.Resources.dude_t;
            }
            else if (last_row_1.SelectedIndex == 4)
            {
                last_row_p1.Image = Properties.Resources.mc_t;
            }
            else if (last_row_1.SelectedIndex == 5)
            {
                last_row_p1.Image = Properties.Resources.why;
            }
        }

        private void last_row_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (last_row_2.SelectedIndex == 0)
            {
                last_row_p2.Image = null;
            }
            else if (last_row_2.SelectedIndex == 1)
            {
                last_row_p2.Image = Properties.Resources.bb_t;
            }
            else if (last_row_2.SelectedIndex == 2)
            {
                last_row_p2.Image = Properties.Resources.kirby_t;
            }
            else if (last_row_2.SelectedIndex == 3)
            {
                last_row_p2.Image = Properties.Resources.dude_t;
            }
            else if (last_row_2.SelectedIndex == 4)
            {
                last_row_p2.Image = Properties.Resources.mc_t;
            }
            else if (last_row_2.SelectedIndex == 5)
            {
                last_row_p2.Image = Properties.Resources.why;
            }
        }

        private void last_row_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (last_row_3.SelectedIndex == 0)
            {
                last_row_p3.Image = null;
            }
            else if (last_row_3.SelectedIndex == 1)
            {
                last_row_p3.Image = Properties.Resources.bb_t;
            }
            else if (last_row_3.SelectedIndex == 2)
            {
                last_row_p3.Image = Properties.Resources.kirby_t;
            }
            else if (last_row_3.SelectedIndex == 3)
            {
                last_row_p3.Image = Properties.Resources.dude_t;
            }
            else if (last_row_3.SelectedIndex == 4)
            {
                last_row_p3.Image = Properties.Resources.mc_t;
            }
            else if (last_row_3.SelectedIndex == 5)
            {
                last_row_p3.Image = Properties.Resources.why;
            }
        }
    }
}
