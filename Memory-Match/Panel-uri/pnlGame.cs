using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Match.Panel_uri
{
    internal class pnlGame:Panel
    {

        Label lblTime;

        Form1 form;

        Timer timer;

        Timer timer1;

        PictureBox pct1;
        PictureBox pct1_1;
        PictureBox pct2;
        PictureBox pct2_1;
        PictureBox pct3;
        PictureBox pct3_1;
        PictureBox pct4;
        PictureBox pct4_1;
        PictureBox pct5;
        PictureBox pct5_1;
        PictureBox pct6;
        PictureBox pct6_1;

        private int counter;

        private Random random;

        private List<string> list;


        private int a;
        private int b;
        private int c;
        private int d;
        private int f;
        private int g;

        Button btnExit;
        Button btnRestart;

        public pnlGame(Form1 form1) { 
        
            form = form1;
            list = new List<string>();
            this.Name = "pnlGame";
            this.Size = new System.Drawing.Size(form.Size.Width, form.Size.Height);
            this.Location = new System.Drawing.Point(0, 0);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.form.MinimumSize = new System.Drawing.Size(659, 465);

            Font font = new Font("Microsoft YaHei UI Light", 20);

            //Label Time
            lblTime = new Label();
            this.Controls.Add(lblTime);

            counter = 61;

            this.lblTime.Location = new System.Drawing.Point(1200,10);
            this.lblTime.AutoSize = true;
            this.lblTime.Font = font;

            //Timer
            timer = new Timer();
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 500;

            //Timer1
            timer1 = new Timer();
            timer1.Enabled = false;
            timer1.Tick += new EventHandler(timer1_Tick);
          
            //Button Exit
            btnExit = new Button();
            this.Controls.Add(btnExit);

            this.btnExit.Location = new System.Drawing.Point(1280, 400);
            this.btnExit.Font = font;
            this.btnExit.Text = "Exit";
            this.btnExit.Size = new System.Drawing.Size(130,60);
            this.btnExit.Click += new EventHandler(btnExit_Click);

            //Button Restart
            btnRestart = new Button();
            this.Controls.Add(btnRestart);

            this.btnRestart.Location = new System.Drawing.Point(1280, 300);
            this.btnRestart.Font = font;
            this.btnRestart.Text = "Restart";
            this.btnRestart.Size = new System.Drawing.Size(130, 60);
            this.btnRestart.Click += new EventHandler(btnRestart_Click);

            //PictureBox 
            pct1 = new PictureBox();
            pct1_1 = new PictureBox();
            pct2 = new PictureBox();
            pct2_1 = new PictureBox();
            pct3 = new PictureBox();
            pct3_1 = new PictureBox();
            pct4 = new PictureBox();
            pct4_1 = new PictureBox();
            pct5 = new PictureBox();
            pct5_1 = new PictureBox();
            pct6 = new PictureBox();
            pct6_1 = new PictureBox();
            this.Controls.Add(pct1);
            this.Controls.Add(pct2);
            this.Controls.Add(pct3);
            this.Controls.Add(pct4);
            this.Controls.Add(pct5);
            this.Controls.Add(pct6);
            this.Controls.Add(pct1_1);
            this.Controls.Add(pct2_1);
            this.Controls.Add(pct3_1);
            this.Controls.Add(pct4_1);
            this.Controls.Add(pct5_1);
            this.Controls.Add(pct6_1);

            int a = 200;

            this.pct1.Location = new System.Drawing.Point(180, 109);
            this.pct1.Size = new System.Drawing.Size(133, 178);
            this.pct1.Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
            this.pct1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct1.Click += new EventHandler(pct1_Click);
          
            this.pct1_1.Location = new System.Drawing.Point(180 + a, 109);
            this.pct1_1.Size = new System.Drawing.Size(133, 178);
            this.pct1_1.Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
            this.pct1_1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct1_1.Click += new EventHandler(pct1_1_Click);

            this.pct2.Location = new System.Drawing.Point(180 + a * 2, 109);
            this.pct2.Size = new System.Drawing.Size(133, 178);
            this.pct2.Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
            this.pct2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct2.Click += new EventHandler(pct2_Click);

            this.pct2_1.Location = new System.Drawing.Point(180 + a * 3, 109);
            this.pct2_1.Size = new System.Drawing.Size(133, 178);
            this.pct2_1.Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
            this.pct2_1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct2_1.Click += new EventHandler(pct2_1_Click);


            this.pct3.Location = new System.Drawing.Point(180, 309);
            this.pct3.Size = new System.Drawing.Size(133, 178);
            this.pct3.Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
            this.pct3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct3.Click += new EventHandler(pct3_Click);

            this.pct3_1.Location = new System.Drawing.Point(180 + a, 309);
            this.pct3_1.Size = new System.Drawing.Size(133, 178);
            this.pct3_1.Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
            this.pct3_1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct3_1.Click += new EventHandler(pct3_1_Click);

            this.pct4.Location = new System.Drawing.Point(180 + a * 2, 309);
            this.pct4.Size = new System.Drawing.Size(133, 178);
            this.pct4.Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
            this.pct4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct4.Click += new EventHandler(pct4_Click);

            this.pct4_1.Location = new System.Drawing.Point(180 + a * 3, 309);
            this.pct4_1.Size = new System.Drawing.Size(133, 178);
            this.pct4_1.Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
            this.pct4_1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct4_1.Click += new EventHandler(pct4_1_Click);


            this.pct5.Location = new System.Drawing.Point(180, 509);
            this.pct5.Size = new System.Drawing.Size(133, 178);
            this.pct5.Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
            this.pct5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct5.Click += new EventHandler(pct5_Click);

            this.pct5_1.Location = new System.Drawing.Point(180 + a, 509);
            this.pct5_1.Size = new System.Drawing.Size(133, 178);
            this.pct5_1.Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
            this.pct5_1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct5_1.Click += new EventHandler(pct5_1_Click);

            this.pct6.Location = new System.Drawing.Point(180 + a * 2, 509);
            this.pct6.Size = new System.Drawing.Size(133, 178);
            this.pct6.Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
            this.pct6.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct6.Click += new EventHandler(pct6_Click);

            this.pct6_1.Location = new System.Drawing.Point(180 + a * 3, 509);
            this.pct6_1.Size = new System.Drawing.Size(133, 178);
            this.pct6_1.Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
            this.pct6_1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct6_1.Click += new EventHandler(pct6_1_Click);

            list.Add("2romb.png");
            list.Add("6romb.png");
            list.Add("7negru.png");
            list.Add("9romb.png");
            list.Add("Arosu.png");
            list.Add("Atrefla.png");

            random = new Random();
            int[] v = { 0, 1, 2, 3, 4, 5 };
           // v = rand(v, random);

            a = random.Next(0,v.Length);
            b = random.Next(0, v.Length);
            c = random.Next(0, v.Length);
            d = random.Next(0, v.Length);
            f = random.Next(0, v.Length);
            g = random.Next(0, v.Length);


            l.Add(pct1);
            l.Add(pct1_1);
            l.Add(pct2);
            l.Add(pct2_1);
            l.Add(pct3);
            l.Add(pct3_1);
            l.Add(pct4);
            l.Add(pct4_1);
            l.Add(pct5);
            l.Add(pct5_1);
            l.Add(pct6);
            l.Add(pct6_1);

          //  l[0].Image = Image.FromFile(Application.StartupPath + @"/images/7negru.png");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

             this.form.Close();

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

            this.form.removePnl("pnlGame");
            this.form.Controls.Add(new pnlGame(form));

        }


        private List<PictureBox> l = new List<PictureBox>();

        private int ct=0;

        private void timer_Tick(object sender, EventArgs e)
        {

            counter--; 
            this.lblTime.Text = "Time: " + counter.ToString() + " secunde";

            if (counter == 0)
            {
                timer.Enabled = false;
                string a = "Timpul s-a terminat!";
                MessageBox.Show(a, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

           // selectpic[0] = pct1;
           // selectpic[1] = pct5;

            if (ct == 2)
            {

                verif();
                ct = 0;
               
            }

            if (ct >= 3)
            {
                timer1.Enabled = false;
                for(int i = 0; i < l.Count; i++)
                {

                    l[i].Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");

                }
                ct = 0;
            }

            if (final())
            { 
                timer.Enabled = false;
                MessageBox.Show("Ai castigat!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.score++;
                this.form.removePnl("pnlGame");
                this.form.Controls.Add(new pnlStart(form, form.score));
                 
               
                
            }

           
        }

        PictureBox[] selectpic = new PictureBox[2];


        private void timer1_Tick(object sender, EventArgs e)
        {
     
            selectpic[0].Left += 650;
            selectpic[1].Left += 650;

            if (selectpic[0].Location.X > 1500 && selectpic[1].Location.X > 1500)
            {
                timer1.Enabled = false;
            }

        }

        private bool final()
        {

            for (int i = 0; i < l.Count; i++)
            {
                if (!l[i].Name.Equals("done"))
                {
                    return false;
                }

            }

            return true;
        }

        private void verif()
        {
            if (selectpic[0] != null && selectpic[1] != null)
            {
               
                if (selectpic[0].Name == selectpic[1].Name)
                {
                    timer1.Enabled = true;
                    selectpic[0].Name = "done";
                    selectpic[1].Name = "done";

                }
                else
                {

                    selectpic[0].Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
                    selectpic[1].Image = Image.FromFile(Application.StartupPath + @"/images/backCards.png");
                   
                }
            }
            

        }

        private void pct1_Click(object sender, EventArgs e)
        {
            if (ct <= 2)
            {
                pct1.Name = list[a];
                pct1.Image = Image.FromFile(Application.StartupPath + @"/images/" + list[a]);

                selectpic[ct] = pct1;
                ct++;
            }
           
           
        }

        private void pct1_1_Click(object sender, EventArgs e)
        {
            if (ct <= 2)
            {
                pct1_1.Name = list[b];
                pct1_1.Image = Image.FromFile(Application.StartupPath + @"/images/" + list[b]);
                selectpic[ct] = pct1_1;
                ct++;
            }
            
            

        }

        private void pct2_Click(object sender, EventArgs e)
        {
            if (ct <= 2)
            {
                pct2.Name = list[f];
                pct2.Image = Image.FromFile(Application.StartupPath + @"/images/" + list[f]);
                selectpic[ct] = pct2;
                ct++;
            }
           
           

        }

        private void pct2_1_Click(object sender, EventArgs e)
        {
            if (ct <= 2)
            {
                pct2_1.Name = list[d];
                pct2_1.Image = Image.FromFile(Application.StartupPath + @"/images/" + list[d]);
                selectpic[ct] = pct2_1;
                ct++;

            }
           
        }

        private void pct3_Click(object sender, EventArgs e)
        {
            if (ct <= 2)
            {
                pct3.Name = list[f];
                pct3.Image = Image.FromFile(Application.StartupPath + @"/images/" + list[f]);
                selectpic[ct] = pct3;
                ct++;
            }
           

        }

        private void pct3_1_Click(object sender, EventArgs e)
        {
            if (ct <= 2)
            {
                pct3_1.Name = list[b];
                pct3_1.Image = Image.FromFile(Application.StartupPath + @"/images/" + list[b]);
                selectpic[ct] = pct3_1;
                ct++;
            }
            

        }

        private void pct4_Click(object sender, EventArgs e)
        {
            if (ct <= 2)
            {
                pct4.Name = list[c];
                pct4.Image = Image.FromFile(Application.StartupPath + @"/images/" + list[c]);
                selectpic[ct] = pct4;
                ct++;
            }
            

        }

        private void pct4_1_Click(object sender, EventArgs e)
        {
            if (ct <= 2)
            {
                pct4_1.Name = list[g];
                pct4_1.Image = Image.FromFile(Application.StartupPath + @"/images/" + list[g]);
                selectpic[ct] = pct4_1;
                ct++;
            }
         

        }

        private void pct5_Click(object sender, EventArgs e)
        {
            if (ct <= 2)
            {
                pct5.Name = list[a];
                pct5.Image = Image.FromFile(Application.StartupPath + @"/images/" + list[a]);

                selectpic[ct] = pct5;
                ct++;
            }
            
           
        }

        private void pct5_1_Click(object sender, EventArgs e)
        {
            if (ct <= 2)
            {
                pct5_1.Name = list[d];
                pct5_1.Image = Image.FromFile(Application.StartupPath + @"/images/" + list[d]);
                selectpic[ct] = pct5_1;
                ct++;
            }
           

        }

        private void pct6_Click(object sender, EventArgs e)
        {
            if (ct <= 2)
            {
                pct6.Name = list[c];
                pct6.Image = Image.FromFile(Application.StartupPath + @"/images/" + list[c]);
                selectpic[ct] = pct6;
                ct++;
            }
           

        }

        private void pct6_1_Click(object sender, EventArgs e)
        {
            if (ct <= 2)
            {
                pct6_1.Name = list[g];
                pct6_1.Image = Image.FromFile(Application.StartupPath + @"/images/" + list[g]);
                selectpic[ct] = pct6_1;
                ct++;

            }
            
        }
    }
}
