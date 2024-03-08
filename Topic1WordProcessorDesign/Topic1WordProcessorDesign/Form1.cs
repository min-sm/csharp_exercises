using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic1WordProcessorDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean click = false;
        Boolean italic = false;
        Boolean strikeThrough = false;
        Boolean underline = false;

        private void cmdBold_Click(object sender, EventArgs e)
        {
            if (!click)
            {
                cmdBold.BackColor = SystemColors.ActiveCaption;
                click = true;
            }
            else
            {
                cmdBold.BackColor = SystemColors.ControlLightLight;
                click = false;
            }
            
        }

        private void cmdItalic_Click(object sender, EventArgs e)
        {
            if (!italic)
            {
                cmdItalic.BackColor = SystemColors.ActiveCaption;
                italic = true;
            }
            else
            {
                cmdItalic.BackColor = SystemColors.ControlLightLight;
                italic = false;
            }
        }

        private void cmdStrikeThrough_Click(object sender, EventArgs e)
        {
            if (!strikeThrough)
            {
                cmdStrikeThrough.BackColor = SystemColors.ActiveCaption;
                strikeThrough = true;
            }
            else
            {
                cmdStrikeThrough.BackColor = SystemColors.ControlLightLight;
                strikeThrough = false;
            }
        }

        private void cmdUnderline_Click(object sender, EventArgs e)
        {
            if (!underline)
            {
                cmdUnderline.BackColor = SystemColors.ActiveCaption;
                underline = true;
            }
            else
            {
                cmdUnderline.BackColor = SystemColors.ControlLightLight;
                underline = false;
            }
        }
    }
}
