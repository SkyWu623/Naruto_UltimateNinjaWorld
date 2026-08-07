namespace Naruto_UltimateNinjaWorld.RecruitUC
{
    partial class HighLevel
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighLevel));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.oncebutton = new System.Windows.Forms.Button();
            this.tenTimebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1064, 649);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // oncebutton
            // 
            this.oncebutton.Location = new System.Drawing.Point(146, 655);
            this.oncebutton.Name = "oncebutton";
            this.oncebutton.Size = new System.Drawing.Size(214, 68);
            this.oncebutton.TabIndex = 1;
            this.oncebutton.Text = "一抽";
            this.oncebutton.UseVisualStyleBackColor = true;
            this.oncebutton.Click += new System.EventHandler(this.oncebutton_Click);
            // 
            // tenTimebutton
            // 
            this.tenTimebutton.Location = new System.Drawing.Point(519, 655);
            this.tenTimebutton.Name = "tenTimebutton";
            this.tenTimebutton.Size = new System.Drawing.Size(214, 68);
            this.tenTimebutton.TabIndex = 2;
            this.tenTimebutton.Text = "十抽";
            this.tenTimebutton.UseVisualStyleBackColor = true;
            this.tenTimebutton.Click += new System.EventHandler(this.tenTimebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 737);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "活動時間:   7月31日0點 - 8月31日0點";
            // 
            // HighLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tenTimebutton);
            this.Controls.Add(this.oncebutton);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Arial", 20F);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "HighLevel";
            this.Size = new System.Drawing.Size(1064, 798);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button oncebutton;
        private System.Windows.Forms.Button tenTimebutton;
        private System.Windows.Forms.Label label1;
    }
}
