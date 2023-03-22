using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Match.Panel_uri
{
    internal class pnlStart:Panel
    {
        Label lblNameGame;

        Button btnStart;

        PictureBox pictureBox1;

        Form1 form;

        public pnlStart(Form1 form1)
        {
            form = form1;
            this.Name = "pnlStart";
            this.Size = new System.Drawing.Size(form.Size.Width, form.Size.Height);
            this.Location = new System.Drawing.Point(0, 0);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;

            Font font = new Font("Microsoft YaHei UI Light", 20);

            //LblNameGame
            lblNameGame = new Label();
            this.Controls.Add(lblNameGame);

            this.lblNameGame.Text = "Memory Match";
            this.lblNameGame.AutoSize = true;
            this.lblNameGame.Font = font;
            this.lblNameGame.Location = new System.Drawing.Point((form.Width - 300) / 2, 5);
            this.lblNameGame.Anchor = AnchorStyles.Top;

            //PictureBox
            pictureBox1 = new PictureBox();
            this.Controls.Add(pictureBox1);

            this.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"/images/cards.png");
            this.pictureBox1.Location = new System.Drawing.Point((form.Width - 330) / 2, 30);
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Anchor = AnchorStyles.Top;

            //Button Start
            btnStart = new Button();
            this.Controls.Add(btnStart);

            this.btnStart.Text = "Start";
            this.btnStart.Location = new System.Drawing.Point((form.Width - 220) / 2, 300);
            this.btnStart.Size = new System.Drawing.Size(130,60);
            this.btnStart.Font = font;
            this.btnStart.Anchor = AnchorStyles.Top;
        }




    }
}
