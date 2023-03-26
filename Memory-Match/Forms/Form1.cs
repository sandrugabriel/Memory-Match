using Memory_Match.Controllers;
using Memory_Match.Forms;
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
using System.Xml.Linq;

namespace Memory_Match
{
    public partial class Form1 : Form
    {

        ControllerClients controllerClients;

        public int score;

        public int id;

        public Form1(int score1, int id1)
        {
            InitializeComponent();
            id = id1;

            score = score1;
            controllerClients = new ControllerClients();
            
            this.Controls.Add(new pnlStart(this,score,id1));



        }

        public void removePnl(string pnl)
        {

            Control control = null;

            foreach (Control cot in this.Controls)
            {

                if (cot.Name.Equals(pnl))
                {
                    control = cot;
                }


            }
            this.Controls.Remove(control);

        }

    }
}
