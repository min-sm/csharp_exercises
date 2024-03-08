using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopicTwoTaskTwo
{
    public partial class frmRunAway : Form
    {
        public frmRunAway()
        {
            InitializeComponent();
        }

        private void frmRunAway_Load(object sender, EventArgs e)
        {
            cmdRunAway.MouseMove += new MouseEventHandler(this.cmdRunAway_MouseMove);
            lblOne.MouseMove += new MouseEventHandler(this.lblOne_MouseMove);
            // this.MouseDoubleClick += new MouseEventHandler(this.frmRunAway_DoubleClick);
            this.MouseDown += new MouseEventHandler(this.frmRunAway_MouseDown);
            this.MouseWheel += new MouseEventHandler(this.frmRunAway_MouseWheel);
        }

        private void frmRunAway_MouseWheel(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            /*
            int sizeWidth, sizeHeight;
            sizeWidth = lblOne.Size.Width;
            sizeHeight = lblOne.Size.Height;
            sizeWidth += e.Delta;
            sizeHeight += e.Delta;
            lblOne.Size = new Size(sizeWidth, sizeHeight);
            // lblOne.Size = new Size(500, 500);
            */
            if (e.Delta > 0) // Mouse wheel scrolling up
            {
                lblOne.Font = new System.Drawing.Font(lblOne.Font.FontFamily, lblOne.Font.Size + 2);
            }
            else // Mouse wheel scrolling down
            {
                lblOne.Font = new System.Drawing.Font(lblOne.Font.FontFamily, lblOne.Font.Size - 2);
            }
        }

        private void frmRunAway_MouseDown(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            if (e.Clicks == 2)
            {
                lblOne.ForeColor = Color.Black;
            }
        }

        /*
        private void frmRunAway_DoubleClick(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            lblOne.ForeColor = Color.Black;
        }
        */

        private void lblOne_MouseMove(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            Random r = new Random();

            lblOne.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            /*
            Random r1 = new Random();
            lblOne.BackColor = Color.FromArgb(r1.Next(0, 256), r1.Next(0, 256), r1.Next(0, 256));
            */
        }

        private void cmdRunAway_MouseMove(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            // cmdRunAway.Location = new Point(e.X, e.Y);
            Random r = new Random();
            cmdRunAway.Location = new Point(r.Next(750), r.Next(480));
        }

        private void cmdYes_Click(object sender, EventArgs e)
        {
            lblAns.Visible = true;
        }
    }
}
