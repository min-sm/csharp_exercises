using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvent2
{
    public partial class frmMouse : Form
    {
        public frmMouse()
        {
            InitializeComponent();
        }
        /* */
        private void frmMouse_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(this.frmMouse_MouseDown);
            this.MouseMove += new MouseEventHandler(this.frmMouse_MouseMove);
            btnOne.MouseMove += new MouseEventHandler(this.btnOne_MouseMove);
        }

        private void btnOne_MouseMove(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            Random r = new Random();
            btnOne.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        private void frmMouse_MouseDown(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        private void frmMouse_MouseMove(object sender, MouseEventArgs e)
        {
            lblMouse.Text = "X, Y = {" + e.X + ", " + e.Y + "}";
        }
        



        /* 
        private void btnOne_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            btnOne.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }
        */
    }
}
