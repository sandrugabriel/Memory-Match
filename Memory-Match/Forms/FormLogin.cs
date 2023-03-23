using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Match.Forms
{
    public partial class FormLogin : Form
    {

        Button btnLogin;
        Button btnSignUp;

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

            //Button SignUp
            btnSignUp = new Button();
            this.Controls.Add(btnSignUp);

            this.btnSignUp.Location = new System.Drawing.Point(110,275);
            this.btnSignUp.Size = new System.Drawing.Size(135,60);
            this.btnSignUp.Font = font;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new EventHandler(btnSignUp_Click);


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {



        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {



        }

    }
}
