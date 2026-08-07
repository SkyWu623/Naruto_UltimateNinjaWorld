namespace Naruto_UltimateNinjaWorld.MainUC
{
    partial class recruitUC
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
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.recruitlabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Showpanel = new System.Windows.Forms.Panel();
            this.Leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Leftpanel
            // 
            this.Leftpanel.Controls.Add(this.recruitlabel);
            this.Leftpanel.Controls.Add(this.button3);
            this.Leftpanel.Controls.Add(this.button2);
            this.Leftpanel.Controls.Add(this.button1);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(425, 878);
            this.Leftpanel.TabIndex = 0;
            // 
            // recruitlabel
            // 
            this.recruitlabel.AutoSize = true;
            this.recruitlabel.Font = new System.Drawing.Font("Broadway", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recruitlabel.Location = new System.Drawing.Point(59, 22);
            this.recruitlabel.Name = "recruitlabel";
            this.recruitlabel.Size = new System.Drawing.Size(149, 68);
            this.recruitlabel.TabIndex = 3;
            this.recruitlabel.Text = "招募";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 317);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(369, 91);
            this.button3.TabIndex = 2;
            this.button3.Text = "祈願招募";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 216);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 91);
            this.button2.TabIndex = 1;
            this.button2.Text = "限定招募";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "高級招募";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.ForeColor = System.Drawing.Color.Red;
            this.Exitbutton.Location = new System.Drawing.Point(1446, 0);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(80, 74);
            this.Exitbutton.TabIndex = 1;
            this.Exitbutton.Text = "❌";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Showpanel
            // 
            this.Showpanel.Location = new System.Drawing.Point(459, 80);
            this.Showpanel.Name = "Showpanel";
            this.Showpanel.Size = new System.Drawing.Size(1064, 798);
            this.Showpanel.TabIndex = 4;
            // 
            // recruitUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Showpanel);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Leftpanel);
            this.Font = new System.Drawing.Font("Arial", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "recruitUC";
            this.Size = new System.Drawing.Size(1526, 878);
            this.Leftpanel.ResumeLayout(false);
            this.Leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Label recruitlabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Panel Showpanel;
    }
}
