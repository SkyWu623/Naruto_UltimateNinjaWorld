using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naruto_UltimateNinjaWorld.MainUC
{
    public partial class LoginUC : UserControl
    {
        // 避免資料庫被重複載入
        private bool _dbLoadStarted = false;

        // 資料庫是否載入完成
        private bool _dbLoaded = false;

        // 進度條是否完成
        private bool _progressCompleted = false;

        // 用來保存從資料庫載入出來的玩家資料
        private List<PlayerTable> _players = new List<PlayerTable>();

        public LoginUC()
        {
            InitializeComponent();
            progressBar.Maximum = 100;
            progressBar.Value = 0;

            Jumpbutton.Enabled = false;

            // 建議等 UserControl Load 完成後再啟動 Timer
            this.Load += LoginUC_Load;
        }

        private void LoginUC_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum)
            {
                progressBar.Value += 1;
            }

            // 修正原本條件漏掉 29、30、69、70 的問題
            if (progressBar.Value >= 70 && progressBar.Value < 100)
            {
                Messagelabel.Text = "正在加載模組，請稍後...";
            }
            else if (progressBar.Value >= 30 && progressBar.Value < 70)
            {
                Messagelabel.Text = "正在檢查更新中，請稍後...";
            }
            else if (progressBar.Value >= 0 && progressBar.Value < 30)
            {
                Messagelabel.Text = "正在初始化遊戲，請稍後...";
            }

            // 在這裡開始載入資料庫，只允許啟動一次
            if (!_dbLoadStarted && progressBar.Value >= 5)
            {
                _dbLoadStarted = true;

                // 開始非同步載入資料庫
                await LoadDatabaseAsync();
            }

            if (progressBar.Value >= progressBar.Maximum)
            {
                _progressCompleted = true;
                timer.Stop();

                TryEnableJumpButton();
            }
        }

        private async Task LoadDatabaseAsync()
        {
            try
            {
                // 把資料庫查詢放到背景執行緒，避免卡住 UI
                await Task.Run(() =>
                {
                    using (var db = new Entities1())
                    {
                        // 這裡就是真正開始載入資料庫
                        _players = db.PlayerTables.ToList();
                        
                    }
                });

                _dbLoaded = true;

                TryEnableJumpButton();
            }
            catch (Exception ex)
            {
                timer.Stop();

                Messagelabel.Text = "資料庫載入失敗";
                MessageBox.Show("資料庫載入失敗：" + ex.Message);
            }
        }

        private void TryEnableJumpButton()
        {
            // 必須進度條完成，而且資料庫也載入完成，才允許進入
            if (_progressCompleted && _dbLoaded)
            {
                Jumpbutton.Enabled = true;
                Messagelabel.Text = "載入完成";
            }
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (!_dbLoaded)
            {
                MessageBox.Show("資料庫尚未載入完成，請稍後。");
                return;
            }

            var account = _players.FirstOrDefault(x =>
                x.Email == AccountTextBox.Text &&
                x.Password == PasswordTextBox.Text);

            if (account != null)
            {
                Form1.Player = account;
                MessageBox.Show($"登入成功，歡迎 {account.Nickname1} 進入遊戲！");
                Form1.Instance.ShowUC(new MainUC());
            }
            else
            {
                MessageBox.Show("登入失敗，請檢查帳號或密碼是否正確。");
            }
        }

        private void Jumpbutton_Click(object sender, EventArgs e)
        {
            if (!_dbLoaded)
            {
                MessageBox.Show("資料庫尚未載入完成，請稍後。");
                return;
            }

            var account = _players.FirstOrDefault();

            if (account != null)
            {
                Form1.Player = account;

                MessageBox.Show($"登入成功，歡迎 {account.Nickname1} 進入遊戲！");
                Form1.Instance.ShowUC(new MainUC());

            }
            else
            {
                MessageBox.Show("登入失敗，請檢查是否正確更新。");
            }
        }
    }
}