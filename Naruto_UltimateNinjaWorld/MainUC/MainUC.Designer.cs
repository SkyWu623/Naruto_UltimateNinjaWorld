namespace Naruto_UltimateNinjaWorld.MainUC
{
    partial class MainUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUC));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recruitpictureBox = new System.Windows.Forms.PictureBox();
            this.fiterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recruitpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1526, 878);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // recruitpictureBox
            // 
            this.recruitpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("recruitpictureBox.Image")));
            this.recruitpictureBox.Location = new System.Drawing.Point(611, 501);
            this.recruitpictureBox.Name = "recruitpictureBox";
            this.recruitpictureBox.Size = new System.Drawing.Size(310, 220);
            this.recruitpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recruitpictureBox.TabIndex = 1;
            this.recruitpictureBox.TabStop = false;
            this.recruitpictureBox.Click += new System.EventHandler(this.recruitpictureBox_Click);
            // 
            // fiterButton
            // 
            this.fiterButton.BackColor = System.Drawing.Color.Black;
            this.fiterButton.Font = new System.Drawing.Font("Arial Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiterButton.ForeColor = System.Drawing.Color.Red;
            this.fiterButton.Location = new System.Drawing.Point(1358, 762);
            this.fiterButton.Name = "fiterButton";
            this.fiterButton.Size = new System.Drawing.Size(165, 113);
            this.fiterButton.TabIndex = 2;
            this.fiterButton.Text = "出征";
            this.fiterButton.UseVisualStyleBackColor = false;
            this.fiterButton.Click += new System.EventHandler(this.fiterButton_Click);
            // 
            // MainUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fiterButton);
            this.Controls.Add(this.recruitpictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 20F);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainUC";
            this.Size = new System.Drawing.Size(1526, 878);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recruitpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox recruitpictureBox;
        private System.Windows.Forms.Button fiterButton;
    }
}
