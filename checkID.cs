using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeons
{
    public partial class checkID : Form
    {
        public static int Code;
        public static string Username;
        public static string filename;
        public checkID()
        {
            InitializeComponent();
        }
       
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ;
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Code=Convert.ToInt32(txt_code.Text);
            Username=Convert.ToString(txt_username.Text);
            this.Hide();
        }
    }
}
