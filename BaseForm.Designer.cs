namespace Dungeons
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse();
            this.Panel_Home = new System.Windows.Forms.Panel();
            this.lab_Encrypt = new System.Windows.Forms.Label();
            this.lab_Decrypt = new System.Windows.Forms.Label();
            this.lab_About_us = new System.Windows.Forms.Label();
            this.lab_home = new System.Windows.Forms.Label();
            this.line_home = new System.Windows.Forms.Panel();
            this.line_encrypt = new System.Windows.Forms.Panel();
            this.line_decrypt = new System.Windows.Forms.Panel();
            this.line_about_us = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Panel_Home
            // 
            this.Panel_Home.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Home.Location = new System.Drawing.Point(0, 133);
            this.Panel_Home.Name = "Panel_Home";
            this.Panel_Home.Size = new System.Drawing.Size(1057, 469);
            this.Panel_Home.TabIndex = 2;
            // 
            // lab_Encrypt
            // 
            this.lab_Encrypt.AutoSize = true;
            this.lab_Encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_Encrypt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Encrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(207)))));
            this.lab_Encrypt.Location = new System.Drawing.Point(593, 28);
            this.lab_Encrypt.Name = "lab_Encrypt";
            this.lab_Encrypt.Size = new System.Drawing.Size(63, 18);
            this.lab_Encrypt.TabIndex = 3;
            this.lab_Encrypt.Text = "Encrypt";
            this.lab_Encrypt.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_Decrypt
            // 
            this.lab_Decrypt.AutoSize = true;
            this.lab_Decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_Decrypt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Decrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(207)))));
            this.lab_Decrypt.Location = new System.Drawing.Point(691, 28);
            this.lab_Decrypt.Name = "lab_Decrypt";
            this.lab_Decrypt.Size = new System.Drawing.Size(67, 18);
            this.lab_Decrypt.TabIndex = 4;
            this.lab_Decrypt.Text = "Decrypt";
            this.lab_Decrypt.Click += new System.EventHandler(this.label2_Click);
            // 
            // lab_About_us
            // 
            this.lab_About_us.AutoSize = true;
            this.lab_About_us.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_About_us.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_About_us.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(207)))));
            this.lab_About_us.Location = new System.Drawing.Point(794, 28);
            this.lab_About_us.Name = "lab_About_us";
            this.lab_About_us.Size = new System.Drawing.Size(71, 18);
            this.lab_About_us.TabIndex = 5;
            this.lab_About_us.Text = "About us";
            this.lab_About_us.Click += new System.EventHandler(this.label3_Click);
            // 
            // lab_home
            // 
            this.lab_home.AutoSize = true;
            this.lab_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_home.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(207)))));
            this.lab_home.Location = new System.Drawing.Point(507, 28);
            this.lab_home.Name = "lab_home";
            this.lab_home.Size = new System.Drawing.Size(52, 18);
            this.lab_home.TabIndex = 6;
            this.lab_home.Text = "Home";
            this.lab_home.Click += new System.EventHandler(this.lab_home_Click);
            // 
            // line_home
            // 
            this.line_home.BackColor = System.Drawing.Color.Navy;
            this.line_home.Location = new System.Drawing.Point(507, 58);
            this.line_home.Name = "line_home";
            this.line_home.Size = new System.Drawing.Size(57, 3);
            this.line_home.TabIndex = 7;
            this.line_home.Visible = false;
            // 
            // line_encrypt
            // 
            this.line_encrypt.BackColor = System.Drawing.Color.Navy;
            this.line_encrypt.Location = new System.Drawing.Point(597, 58);
            this.line_encrypt.Name = "line_encrypt";
            this.line_encrypt.Size = new System.Drawing.Size(66, 3);
            this.line_encrypt.TabIndex = 8;
            this.line_encrypt.Visible = false;
            // 
            // line_decrypt
            // 
            this.line_decrypt.BackColor = System.Drawing.Color.Navy;
            this.line_decrypt.Location = new System.Drawing.Point(695, 58);
            this.line_decrypt.Name = "line_decrypt";
            this.line_decrypt.Size = new System.Drawing.Size(71, 3);
            this.line_decrypt.TabIndex = 9;
            this.line_decrypt.Visible = false;
            // 
            // line_about_us
            // 
            this.line_about_us.BackColor = System.Drawing.Color.Navy;
            this.line_about_us.Location = new System.Drawing.Point(798, 58);
            this.line_about_us.Name = "line_about_us";
            this.line_about_us.Size = new System.Drawing.Size(75, 3);
            this.line_about_us.TabIndex = 10;
            this.line_about_us.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Dungeons.Properties.Resources.backblue;
            this.pictureBox4.Image = global::Dungeons.Properties.Resources.cross1;
            this.pictureBox4.Location = new System.Drawing.Point(1019, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Dungeons.Properties.Resources.IMG_20230325_065640_662;
            this.pictureBox3.Location = new System.Drawing.Point(137, -40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(264, 142);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dungeons.Properties.Resources.f33b18962c1ea0658b95b2dc6997e5ae__1_;
            this.pictureBox2.Location = new System.Drawing.Point(806, -32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(418, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dungeons.Properties.Resources.f33b18962c1ea0658b95b2dc6997e51ae;
            this.pictureBox1.Location = new System.Drawing.Point(-162, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 602);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.line_about_us);
            this.Controls.Add(this.line_decrypt);
            this.Controls.Add(this.line_encrypt);
            this.Controls.Add(this.line_home);
            this.Controls.Add(this.lab_home);
            this.Controls.Add(this.lab_About_us);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lab_Decrypt);
            this.Controls.Add(this.lab_Encrypt);
            this.Controls.Add(this.Panel_Home);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Panel_Home;
        private System.Windows.Forms.Label lab_Decrypt;
        private System.Windows.Forms.Label lab_Encrypt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lab_About_us;
        private System.Windows.Forms.Label lab_home;
        private System.Windows.Forms.Panel line_about_us;
        private System.Windows.Forms.Panel line_decrypt;
        private System.Windows.Forms.Panel line_encrypt;
        private System.Windows.Forms.Panel line_home;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

