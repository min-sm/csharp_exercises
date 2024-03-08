using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Topic5TasksTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Assuming you have an array of strings to populate the ComboBox
        string[] genreData = { "Option 1", "Option 2", "Option 3" };

        // Populating the ComboBox with the array 

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBxGenre.DataSource = genreData;
        }
    }
}
