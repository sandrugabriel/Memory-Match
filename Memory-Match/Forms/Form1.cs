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
        public int score=0;

        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(new pnlStart(this,score));

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
