using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexasHold_Em
{
    public partial class f_greetings : Form
    {
        public f_greetings()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //Starts the gamesession
            f_main main = new f_main();
            this.Close();
            main.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            //Throws you back to the start screen
            f_login _Login = new f_login();
            this.Close();
            _Login.Show();
           
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            //Shows you the stats
            f_stats stats = new f_stats();
            this.Hide();
            stats.Show();
        }

        private void btn_htp_Click(object sender, EventArgs e)
        {
            //Guides you to the How to Play manual
            f_htp htp = new f_htp();
            this.Close();
            htp.Show();
        }
    }
}
