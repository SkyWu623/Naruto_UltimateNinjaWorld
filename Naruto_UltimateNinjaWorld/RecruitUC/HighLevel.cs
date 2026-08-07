using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naruto_UltimateNinjaWorld.RecruitUC
{
    public partial class HighLevel : UserControl
    {
        public HighLevel()
        {
            InitializeComponent();
        }

        private void oncebutton_Click(object sender, EventArgs e)
        {
            GiftForm giftForm = new GiftForm(1);
            giftForm.ShowDialog();
        }
        private void tenTimebutton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("是否消耗忍界10招集卷招募?", "提示", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == MessageBox.Show("是否消耗忍界10招集卷招募?", "提示", MessageBoxButtons.YesNo))
            {
                GiftForm giftForm = new GiftForm(10);
                giftForm.ShowDialog();
            }
            else
            {

            }
        }

    }
}
