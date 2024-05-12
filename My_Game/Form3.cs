using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Game
{
    public partial class play_frm : Form
    {
        bool turn = true;
        bool draw = true;
        public static play_frm inctance;
        public Label pl1;
        public Label pl2;
        public play_frm()
        
        {
            
            InitializeComponent();
            inctance = this;
            pl1 = pl1_lbl;
            pl2 = pl2_lbl;
   
        }
     
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void play_frm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pl2_lbl_Click(object sender, EventArgs e)
        {

        }
        public void turn_b(Button a)
        {
            if (turn)
                a.Text = "X";
            else
                a.Text = "O";
            turn = !turn;
            a.Enabled = false;

        }
        public void win()
        {
            bool end = false;
            if (a1.Text == a2.Text && a1.Text == a3.Text && a1.Text != "")//1
            {
                end = true;
                draw = false;
            }
            if (b1.Text == b2.Text && b1.Text==b3.Text && !b1.Enabled)//2
            {

                end = true;
                draw = false;
            }
            if (c1.Text == c2.Text && c1.Text == c3.Text && c1.Text != "")//3
            {

                end = true;
                draw = false;
            }
            if (a1.Text == b1.Text && a1.Text == c1.Text && a1.Text != "")//4
            {

                end = true;
                draw = false;
            }
            if (a2.Text == b2.Text && a2.Text == c2.Text && a2.Text != "")//5
            {

                end = true;
                draw = false;

            }
            if (a3.Text == b3.Text && a3.Text == c3.Text && a3.Text != "")//6
            {
                end = true;
                    draw = false;
            }
            if (a1.Text == b2.Text && a1.Text == c3.Text && a1.Text != "")//7
            {
                end = true;
                draw = false;
            }
            if (a3.Text == b2.Text && a3.Text == c1.Text && a3.Text != "")//8
            {
                end = true;
                draw = false;
            }
            if (draw)
            {
                    if (!a1.Enabled && !a2.Enabled && !a3.Enabled && !b1.Enabled &&
                     !b2.Enabled && !b3.Enabled && !c1.Enabled && !c2.Enabled &&
                     !c3.Enabled)
                { 
                        MessageBox.Show("TA333DOOOOOOOOOOL");
                    enabl();
                    turn = true;
                }
                
            }
            if (end)
            {
                string s;
                if (turn)
                {
                    int a = Convert.ToInt32(scr_x.Text);        
                    a++;
                    scr_x.Text = a.ToString();
                    s = pl2_lbl.Text;
                    enabl();
                    MessageBox.Show(s + " win ");
                    draw = true;
                    

                }
                else
                {
                    int a = Convert.ToInt32(scr_o.Text);
                    a++;
                    scr_o.Text = a.ToString();
                    s = pl1_lbl.Text;
                    enabl();
                    MessageBox.Show(s + " win ");
                    draw = true;
                }
                turn = true;
               
            }
        }
        private void enabl()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { };
            }
        }


        private void btn_go(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            turn_b(b);
            b.Show();  
            win();

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Main_frm back = new Main_frm();
            back.Show();
            this.Hide();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           // Button b = (Button)sender;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { };
            }
            turn = true;

        }

        private void Pl1_lbl_Click(object sender, EventArgs e)
        {
           
        }

        private void turn_lbl_Click(object sender, EventArgs e)
        {
           
        }
    }
}
