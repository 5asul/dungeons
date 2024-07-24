using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;
using WindowsFormsApplication48;
using System.Data.Entity;

namespace Dungeons
{
    
    public partial class Encryption : Form
    {

        public Encryption()
        {
            InitializeComponent();
        }
        dungeonsEntities1 dun;
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {

            
            en_file en_File = new en_file();
            try
            {
                string checku = "";

                var records = dun.accounts.Select(x => new
                {
                    username = x.username,
                    id = x.id
                });
                foreach (var record in records)
                {

                    if (record.username.Equals(checkID.Username) && record.id.Equals(checkID.Code))
                    {
                        checku = "equal";

                    }
                }

                if (checku == "equal")
                {

                    DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO ENCRYPT THIS FILE", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        string fname = txt_file_Name_Destroy.Text;
                        checkID.filename = fname;
                        en_File.account_id = checkID.Code;
                        en_File.file_name = fname;

                        dun.en_file.Add(en_File);
                        dun.SaveChanges();
                        encryptfile efile = new encryptfile("1234567891234567");
                        efile.encrypt(txt_file_Name_Destroy.Text);

                        MessageBox.Show("The file has been Encrypted Successfully");
                        txt_file_Name_Destroy.Text = "";
                    }

                    
                }

                else
                {
                    MessageBox.Show("this username is not registred in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txt_file_Name_Destroy.Text = "";
            }

            

        }

        private void btn_Destroy_Click(object sender, EventArgs e)
        {
            try
            {
                string checku = "";

                var records = dun.accounts.Select(x => new
                {
                    username = x.username,
                    id = x.id
                });
                foreach (var record in records)
                {

                    if (record.username.Equals(checkID.Username) && record.id.Equals(checkID.Code))
                    {
                        checku = "equal";

                    }
                }
                if (checku == "equal")
                {
                    DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO DESTROY THIS FILE", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        encryptfile efile = new encryptfile("1234567891234567");
                        efile.destroy(txt_file_Name_Destroy.Text);

                        MessageBox.Show("The file has been Destroyed Successfully");
                        txt_file_Name_Destroy.Text = "";
                    }
                    
                }
                else
                {
                    MessageBox.Show("this username is not registred in the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txt_file_Name_Destroy.Text = "";
            }

        }

        private void btn_open_files_Destroy_Click(object sender, EventArgs e)
        {
            dun = new dungeonsEntities1();
            OpenFileDialog openfile = new OpenFileDialog();
            checkID check = new checkID();
            check.ShowDialog();
            
            if (openfile.ShowDialog() == DialogResult.OK)
            {
              
                
                try
                {
                    
                    txt_file_Name_Destroy.Text = openfile.FileName;

                    string fName = txt_file_Name_Destroy.Text;
                    
                }
                catch
                {
                    MessageBox.Show("make sure that the code is correct", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }




        }
    }
}
