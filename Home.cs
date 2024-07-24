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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {

            Dungeons.BaseForm.encroypt_pag();
            

        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            Dungeons.BaseForm.decrypt_pag();
        }
    }
}
