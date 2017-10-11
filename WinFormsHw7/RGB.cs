using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHw7
{
    public partial class RGB : Form
    {
        RGBTwo rgb = new RGBTwo();
        public RGB()
        {
            InitializeComponent();
            
        }
        public void ColorArgb ()
        {
            byte red;
            byte green;
            byte blue;
        }
        private void TrackBarR_Scroll(object sender, EventArgs e)
        {
        }

        private void TrackBarG_Scroll(object sender, EventArgs e)
        {
        }

        private void TrackBarB_Scroll(object sender, EventArgs e)
        {
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            rgb.BackColor = Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value);
            rgb.Show();
        }
    }
}
