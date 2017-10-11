using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms5
{
    public partial class RGB : Form
    {
        BestOil bestOil = new BestOil();
        public RGB()
        {
            InitializeComponent();
        }
        public void ColorArgb()
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
            bestOil.BackColor = Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value);
            bestOil.Show();
        }
    }
}
}
