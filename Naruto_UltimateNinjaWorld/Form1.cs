using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Naruto_UltimateNinjaWorld.MainUC;
namespace Naruto_UltimateNinjaWorld
{
    public partial class Form1 : Form
    {
        public static Form1 Instance { get; set; }
        public static PlayerTable Player { get; set; }
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            timer_Tick(null, null);
            timer.Start();
            ShowUC(new LoginUC());
        }
        public void ShowUC(UserControl uc)
        {
            showpanel.Controls.Clear();
            showpanel.Controls.Add(uc);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Timelabel.Text = $"日期 : {DateTime.Now:yyyy-MM-dd}時間 : {DateTime.Now:HH:mm:ss}";
        }
    }
}
