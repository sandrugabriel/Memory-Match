using Memory_Match.Panel_uri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Memory_Match.Forms
{
    public partial class FormLogin : Form
    {

        Button btnLogin;
        Button btnSignUp;

        PictureBox pictureBox1;

        public FormLogin()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.SystemColors.ActiveCaption;

            //Button Login
            btnLogin = new Button();
            this.Controls.Add(btnLogin);

            Font font = new Font("Microsoft YaHei UI Light", 22);

            this.btnLogin.Location = new System.Drawing.Point(110, 175);
            this.btnLogin.Size = new System.Drawing.Size(135,60);
            this.btnLogin.Font = font;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new EventHandler(btnLogin_Click);
            this.btnLogin.SendToBack();

            //Button SignUp
            btnSignUp = new Button();
            this.Controls.Add(btnSignUp);

            this.btnSignUp.Location = new System.Drawing.Point(110,275);
            this.btnSignUp.Size = new System.Drawing.Size(135,60);
            this.btnSignUp.Font = font;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new EventHandler(btnSignUp_Click);
            this.btnSignUp.SendToBack();

            //Picture
            pictureBox1 = new PictureBox();
            this.Controls.Add(pictureBox1);

            this.pictureBox1.Location = new System.Drawing.Point(92, 4);
            this.pictureBox1.Size = new System.Drawing.Size(170, 151);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"/images/cards.png");

        }

        public void removepnl(string pnl)
        {
            Control control = null;

            foreach (Control ctl in this.Controls)
            {

                if(ctl.Name == pnl)
                {
                    control = ctl;
                }

                
            }


            this.Controls.Remove(control);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            this.Controls.Add(new pnlLogin(this));
            this.btnLogin.Visible = false;
            this.btnSignUp.Visible = false;
            this.pictureBox1.Visible = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Controls.Add(new pnlSignUp(this));
            this.btnLogin.Visible = false;
            this.btnSignUp.Visible = false;
            this.pictureBox1.Visible = false;


        }

    }
}
