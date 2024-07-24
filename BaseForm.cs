using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication48;

namespace Dungeons
{
    
    public partial class BaseForm : Form
    {
        
        
        public static BaseForm n;

       
        public BaseForm()
        {

            n = this;

            InitializeComponent();

            



            this.Panel_Home.Controls.Clear();
            Home my_shop_Load = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_home.ForeColor = Color.Navy;
            lab_Encrypt.ForeColor = Color.FromArgb(23, 141, 207);
            lab_Decrypt.ForeColor = Color.FromArgb(23, 141, 207);
            lab_About_us.ForeColor = Color.FromArgb(23, 141, 207);

            line_home.Visible = true;
            line_encrypt.Visible = false;
            line_decrypt.Visible = false;
            line_about_us.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            this.Panel_Home.Controls.Clear();
            Encryption my_shop_Load = new Encryption() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_home.ForeColor = Color.FromArgb(23, 141, 207);
            lab_Encrypt.ForeColor = Color.Navy;
            lab_Decrypt.ForeColor = Color.FromArgb(23, 141, 207);
            lab_About_us.ForeColor = Color.FromArgb(23, 141, 207);

            line_home.Visible = false;
            line_encrypt.Visible = true;
            line_decrypt.Visible = false;
            line_about_us.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Panel_Home.Controls.Clear();
            Decrypt my_shop_Load = new Decrypt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_home.ForeColor = Color.FromArgb(23, 141, 207);
            lab_Encrypt.ForeColor = Color.FromArgb(23, 141, 207);
            lab_Decrypt.ForeColor = Color.Navy;
            lab_About_us.ForeColor = Color.FromArgb(23, 141, 207);

            line_home.Visible = false;
            line_encrypt.Visible = false;
            line_decrypt.Visible = true;
            line_about_us.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Panel_Home.Controls.Clear();
            About_us my_shop_Load = new About_us() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_home.ForeColor = Color.FromArgb(23, 141, 207);
            lab_Encrypt.ForeColor = Color.FromArgb(23, 141, 207);
            lab_Decrypt.ForeColor = Color.FromArgb(23, 141, 207);
            lab_About_us.ForeColor = Color.Navy;

            line_home.Visible = false;
            line_encrypt.Visible = false;
            line_decrypt.Visible = false;
            line_about_us.Visible = true;
        }

        private void lab_home_Click(object sender, EventArgs e)
        {
            this.Panel_Home.Controls.Clear();
            Home my_shop_Load = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_home.ForeColor = Color.Navy;
            lab_Encrypt.ForeColor = Color.FromArgb(23, 141, 207);
            lab_Decrypt.ForeColor = Color.FromArgb(23, 141, 207);
            lab_About_us.ForeColor = Color.FromArgb(23, 141, 207);

            line_home.Visible = true;
            line_encrypt.Visible = false;
            line_decrypt.Visible = false;
            line_about_us.Visible = false;


        }

        public static void encroypt_pag()
        {



            
            n.Panel_Home.Controls.Clear();
            Encryption my_shop_Load = new Encryption() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            n.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            n.lab_home.ForeColor = Color.FromArgb(23, 141, 207);
            n.lab_Encrypt.ForeColor = Color.Navy;
            n.lab_Decrypt.ForeColor = Color.FromArgb(23, 141, 207);
            n.lab_About_us.ForeColor = Color.FromArgb(23, 141, 207);

            n.line_home.Visible = false;
            n.line_encrypt.Visible = true;
            n.line_decrypt.Visible = false;
            n.line_about_us.Visible = false;

        }

        public static void decrypt_pag()
        {

            
            
            

            n.Panel_Home.Controls.Clear();
            Decrypt my_shop_Load = new Decrypt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            n.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            n.lab_home.ForeColor = Color.FromArgb(23, 141, 207);
            n.lab_Encrypt.ForeColor = Color.FromArgb(23, 141, 207);
            n.lab_Decrypt.ForeColor = Color.Navy;
            n.lab_About_us.ForeColor = Color.FromArgb(23, 141, 207);

            n.line_home.Visible = false;
            n.line_encrypt.Visible = false;
            n.line_decrypt.Visible = true;
            n.line_about_us.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Panel_Home.Controls.Clear();
            Home my_shop_Load = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_home.ForeColor = Color.Navy;
            lab_Encrypt.ForeColor = Color.FromArgb(23, 141, 207);
            lab_Decrypt.ForeColor = Color.FromArgb(23, 141, 207);
            lab_About_us.ForeColor = Color.FromArgb(23, 141, 207);

            line_home.Visible = true;
            line_encrypt.Visible = false;
            line_decrypt.Visible = false;
            line_about_us.Visible = false;

        }
    }
}
