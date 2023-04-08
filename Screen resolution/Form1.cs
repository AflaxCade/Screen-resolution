using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_resolution
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int height = Screen.PrimaryScreen.Bounds.Height;

            int width = Screen.PrimaryScreen.Bounds.Width;

            lblDisplay.Text = width + " x " + height;

            lblWidth.Text = "Screen Width: " + width + " pixels";

            lblHeight.Text = "Screen Height: " + height + " pixels";
        }
    }
}
