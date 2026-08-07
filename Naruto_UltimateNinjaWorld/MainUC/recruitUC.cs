using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Naruto_UltimateNinjaWorld.RecruitUC;
namespace Naruto_UltimateNinjaWorld.MainUC
{
    public partial class recruitUC : UserControl
    {
        public recruitUC()
        {
            InitializeComponent();
            ChangeUC(new HighLevel());

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Form1.Instance.ShowUC(new MainUC());
        }
        public void ChangeUC(UserControl userControl)
        {
            Showpanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            Showpanel.Controls.Add(userControl);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeUC(new HighLevel());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeUC(new LimitedTimeOffer());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此活動暫勿開放");
        }
    }
}
