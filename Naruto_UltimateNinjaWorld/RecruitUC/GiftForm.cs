using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naruto_UltimateNinjaWorld.RecruitUC
{
    public partial class GiftForm : Form
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_CAPTION_COLOR = 35;      // 標題列背景色 (Win11 / Win10 新版支援)
        private const int DWMWA_TEXT_COLOR = 36;         // 標題列文字顏色
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20; // 深色模式標題列

        // --- 十抽相關變數 ---
        private Random random = new Random();
        private List<string> gachaResults = new List<string>(); // 存放十連抽的圖片檔名
        private PictureBox[] cardBoxes;                        // 10個 PictureBox 控制項
        private Timer timerGacha;                              // 控制逐一顯示的計時器
        private int currentCardIndex = 0;                      // 當前顯示到第幾張 (0~9)

        private int cardCount = 0;
        public GiftForm(int count)
        {
            InitializeComponent();

            this.cardCount = count;
            int darkMode = 1;
            DwmSetWindowAttribute(this.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref darkMode, sizeof(int));

            // 自訂標題列背景顏色 (BGRColor)
            int captionColor = ColorTranslator.ToWin32(Color.FromArgb(240, 116, 4));
            DwmSetWindowAttribute(this.Handle, DWMWA_CAPTION_COLOR, ref captionColor, sizeof(int));

            // 自訂標題列文字顏色
            int textColor = ColorTranslator.ToWin32(Color.Yellow);
            DwmSetWindowAttribute(this.Handle, DWMWA_TEXT_COLOR, ref textColor, sizeof(int));

            // 初始化 Timer 設定
            timerGacha = new Timer();
            timerGacha.Interval = 500; // 每 0.5 秒顯示一張卡片
            timerGacha.Tick += TimerGacha_Tick;
        }

        private void GiftForm_Load(object sender, EventArgs e)
        {
            // 將表單上的 10 個 PictureBox 放進陣列
            cardBoxes = new PictureBox[] {
                picCard1, picCard2, picCard3, picCard4, picCard5,
                picCard6, picCard7, picCard8, picCard9, picCard10
            };

            // 設定每個 PictureBox 的顯示模式為 Zoom（自動縮放不變形）
            for (int i = 0; i < cardBoxes.Length; i++)
            {
                if (cardBoxes[i] != null)
                {
                    cardBoxes[i].SizeMode = PictureBoxSizeMode.Zoom;

                    // 如果 index 小於抽卡數，顯示框框；否則隱藏
                    if (i < cardCount)
                    {
                        cardBoxes[i].Visible = true;
                    }
                    else
                    {
                        cardBoxes[i].Visible = false; // 單抽時，第 2~10 個 PictureBox 會被隱藏
                    }
                }
            }
            // 開啟視窗時自動開始十抽
            StartGacha();
        }

        // --- 開始十連抽流程 ---
        public void StartGacha()
        {
            // 1. 清空舊圖片與記憶體
            gachaResults.Clear();
            foreach (var box in cardBoxes)
            {
                if (box != null && box.Image != null)
                {
                    box.Image.Dispose();
                    box.Image = null;
                }
            }

            // 2. 從資料庫撈取卡池
            string[] cardPool;
            using (var db = new Entities1())
            {
                cardPool = db.RoleTables.Select(c => c.Name).ToArray();
            }

            if (cardPool.Length == 0)
            {
                MessageBox.Show("卡池內無角色資料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. 根據 gachaCount 產生 1 或 10 張卡片檔名
            for (int i = 0; i < cardCount; i++)
            {
                int index = random.Next(cardPool.Length);
                gachaResults.Add(cardPool[index]);
            }

            // 4. 重設定數器並啟動 Timer
            currentCardIndex = 0;
            timerGacha.Start();
        }

        // --- Timer 逐一放上圖片 ---
        private void TimerGacha_Tick(object sender, EventArgs e)
        {
            // 條件改為 currentCardIndex < gachaCount (單抽跑 1 次，十抽跑 10 次)
            if (currentCardIndex < cardCount)
            {
                string fileName = gachaResults[currentCardIndex];
                string path = Path.Combine(Application.StartupPath, "pics", "people", fileName + ".png");

                if (File.Exists(path))
                {
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        using (Image tempImg = Image.FromStream(fs))
                        {
                            cardBoxes[currentCardIndex].Image = new Bitmap(tempImg);
                        }
                    }
                }

                currentCardIndex++;
            }
            else
            {
                // 抽卡顯示完成，停止計時器
                timerGacha.Stop();
                //這裡呼叫資料庫
                SaveResultsToDatabase(gachaResults);
            }
        }
        // 將抽卡結果存入資料庫
        private void SaveResultsToDatabase(List<string> drawnCardNames)
        {
            using (var db = new Entities1())
            {
                var rolesInDb = db.RoleTables
                                  .Where(r => drawnCardNames.Contains(r.Name))
                                  .ToList();

                foreach (var cardName in drawnCardNames)
                {
                    var role = rolesInDb.FirstOrDefault(r => r.Name == cardName);

                    if (role != null)
                    {
                        if (role.have == false) // 假設你的欄位名稱是 have
                        {
                            // 第一次抽到：解鎖角色
                            role.have = true;
                        }
                        else
                        {
                            // 重複抽到：固定增加 10 個碎片
                            // (請確保你的 RoleTable 有 shard 或 count 類似的碎片欄位)
                            
                        }
                    }
                }
                db.SaveChanges();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            GiftForm giftForm = new GiftForm(10);
            giftForm.Show();
            //this.Close();
        }
    }
}