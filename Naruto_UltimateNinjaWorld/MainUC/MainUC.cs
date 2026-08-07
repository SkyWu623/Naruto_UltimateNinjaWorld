using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naruto_UltimateNinjaWorld.MainUC
{
    public partial class MainUC : UserControl
    {
        public MainUC()
        {
            InitializeComponent();
        }

        private void recruitpictureBox_Click(object sender, EventArgs e)
        {
            Form1.Instance.ShowUC(new recruitUC());
        }

        private void fiterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
