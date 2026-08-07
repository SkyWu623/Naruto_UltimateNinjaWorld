namespace Naruto_UltimateNinjaWorld.MainUC
{
    partial class LoginUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUC));
            this.Fillpicture = new System.Windows.Forms.PictureBox();
            this.Jumpbutton = new System.Windows.Forms.Button();
            this.AccountTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Messagelabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Fillpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Fillpicture
            // 
            this.Fillpicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fillpicture.Image = ((System.Drawing.Image)(resources.GetObject("Fillpicture.Image")));
            this.Fillpicture.Location = new System.Drawing.Point(0, 0);
            this.Fillpicture.Name = "Fillpicture";
            this.Fillpicture.Size = new System.Drawing.Size(1796, 897);
            this.Fillpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fillpicture.TabIndex = 0;
            this.Fillpicture.TabStop = false;
            // 
            // Jumpbutton
            // 
            this.Jumpbutton.Location = new System.Drawing.Point(623, 662);
            this.Jumpbutton.Name = "Jumpbutton";
            this.Jumpbutton.Size = new System.Drawing.Size(485, 86);
            this.Jumpbutton.TabIndex = 1;
            this.Jumpbutton.Text = "直接登入";
            this.Jumpbutton.UseVisualStyleBackColor = true;
            this.Jumpbutton.Click += new System.EventHandler(this.Jumpbutton_Click);
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.Location = new System.Drawing.Point(623, 247);
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Size = new System.Drawing.Size(485, 53);
            this.AccountTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(623, 398);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(485, 53);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(623, 520);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(485, 86);
            this.Loginbutton.TabIndex = 4;
            this.Loginbutton.Text = "密碼登入";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // Messagelabel
            // 
            this.Messagelabel.AutoSize = true;
            this.Messagelabel.BackColor = System.Drawing.Color.Black;
            this.Messagelabel.ForeColor = System.Drawing.Color.White;
            this.Messagelabel.Location = new System.Drawing.Point(735, 751);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(0, 45);
            this.Messagelabel.TabIndex = 5;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 852);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1796, 30);
            this.progressBar.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Messagelabel);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.AccountTextBox);
            this.Controls.Add(this.Jumpbutton);
            this.Controls.Add(this.Fillpicture);
            this.Font = new System.Drawing.Font("Arial", 20F);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(1796, 897);
            ((System.ComponentModel.ISupportInitialize)(this.Fillpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fillpicture;
        private System.Windows.Forms.Button Jumpbutton;
        private System.Windows.Forms.MaskedTextBox AccountTextBox;
        private System.Windows.Forms.MaskedTextBox PasswordTextBox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label Messagelabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}
