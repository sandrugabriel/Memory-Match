using Memory_Match.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Match.Panel_uri
{
    internal class pnlLogin:Panel
    {

        PictureBox pictureBox;

        PictureBox pctName;
        TextBox txtName;

        PictureBox pctPass;
        TextBox txtPassword;

        FormLogin form;

        Button btnLog;

        LinkLabel linkLabel;

        public pnlLogin(FormLogin form1) {

            form = form1;
            this.form.Size = new System.Drawing.Size(461, 580);
            this.Name = "pnlLogin";
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Size = new System.Drawing.Size(form.Size.Width,form.Size.Height);
            this.BringToFront();

            Font font = new Font("Microsoft YaHei UI Light",20);
            Font font1 = new Font("Microsoft YaHei UI Light", 24);
            Font font2 = new Font("Microsoft YaHei UI Light", 18);
            //Picture

            pictureBox = new PictureBox();
            this.Controls.Add(pictureBox);

            this.pictureBox.Location = new System.Drawing.Point(90, 23);
            this.pictureBox.Size = new System.Drawing.Size(246, 117);
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox.Image = Image.FromFile(Application.StartupPath + @"/images/login.png");

            //Name
            pctName = new PictureBox();
            this.Controls.Add(pctName);
            this.pctName.Location = new System.Drawing.Point(35,179);
            this.pctName.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctName.Size = new System.Drawing.Size(75, 75);
            this.pctName.Image = Image.FromFile(Application.StartupPath+@"/images/user.png");

            txtName = new TextBox();
            this.Controls.Add(txtName);
            this.txtName.Location = new System.Drawing.Point(150, 200);
            this.txtName.Font = font2;
            this.txtName.Size = new System.Drawing.Size(190,10);

            //Password
            pctPass = new PictureBox();
            this.Controls.Add(pctPass);
            this.pctPass.Location = new System.Drawing.Point(35,279);
            this.pctPass.Size = new System.Drawing.Size(75, 75);
            this.pctPass.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctPass.Image = Image.FromFile(Application.StartupPath+@"/images/locked.png");

            txtPassword = new TextBox();    
            this.Controls.Add(txtPassword);
            this.txtPassword.Location = new System.Drawing.Point(150,300);
            this.txtPassword.Font = font2;
            this.txtPassword.Size = new System.Drawing.Size(190, 10);
            this.txtPassword.UseSystemPasswordChar = true;

            //Button Login
            btnLog = new Button();
            this.Controls.Add(btnLog);

            this.btnLog.Location = new System.Drawing.Point(155,390);
            this.btnLog.Text = "Login";
            this.btnLog.Font = font;
            this.btnLog.Size = new System.Drawing.Size(130,60);
            this.btnLog.Click += new EventHandler(btnLog_Click);

            //Link
            linkLabel = new LinkLabel();
            this.Controls.Add(linkLabel);

            this.linkLabel.Location = new System.Drawing.Point(340,500);
            this.linkLabel.Text = "Sing Up";
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = font2;
            this.linkLabel.Click += new EventHandler(linkLabel_Click);



        }

        private void linkLabel_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlLogin");


        }

        private void btnLog_Click(object sender, EventArgs e)
        {



        }

    }
}
