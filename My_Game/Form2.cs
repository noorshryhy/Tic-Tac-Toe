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
    public partial class login_frm : Form
    {
       
      

        public login_frm()
        {   
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            play_frm go = new play_frm();
            go.Show();
            this.Hide();
            if (txt_1.Text != "" && txt_2.Text != "")
            {
                play_frm.inctance.pl1.Text = txt_1.Text;
                play_frm.inctance.pl2.Text = txt_2.Text;
            }

        }
    }
}
