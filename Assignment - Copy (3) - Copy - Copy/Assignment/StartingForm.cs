using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
            this.Shown += StartingForm_Shown;
        }

        private void StartingForm_Shown(object sender, EventArgs e)
        {
            LoginForm lgFrm = new LoginForm(this);
            lgFrm.Show();
            this.Hide();
        }
    }
}
