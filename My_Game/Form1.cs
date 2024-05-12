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
    public partial class Main_frm : Form
    {
        public Main_frm()
        {
            InitializeComponent();
        }

        private void EX_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            login_frm f = new login_frm();
            f.Show();
            this.Hide();
        }

        private void Main_frm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
