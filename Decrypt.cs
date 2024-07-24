using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApplication48;


namespace Dungeons
{
    public partial class Decrypt : Form
    {
        
        public Decrypt()
        {
            InitializeComponent();
           
        }
        dungeonsEntities1 dun = new dungeonsEntities1();

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            int id = checkID.Code;
            string fileName = checkID.filename;
            string check = "";
            var records = dun.en_file.Select(x => new
            {
                fName = x.file_name,
                accountId = x.account_id
            });
            foreach (var record in records)
            {
                if (record.accountId == id && record.fName == fileName)
                {

                    check = "equal";
                }


            }

            if (check != "equal")
            {
               MessageBox.Show("you can't decript this file","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("ARE YOU SURE YOU WANT TO RESTORE THIS FILE", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {

                        encryptfile ef = new encryptfile("1234567891234567");
                        ef.decrypt(txt_file_Name_Decrypt.Text);

                        MessageBox.Show("The file has been Restored Successfully");
                        txt_file_Name_Decrypt.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        txt_file_Name_Decrypt.Text = "";
                    }

                }
            }
           
        }

        private void btn_open_files_Decrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                txt_file_Name_Decrypt.Text = openfile.FileName;
            }
        }
    }
}
