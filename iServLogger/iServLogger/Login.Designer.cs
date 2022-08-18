
namespace iServLogger
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.outline = new SkeetUI.outlineLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skeetButton1 = new SkeetUI.skeetButton();
            this.username = new SkeetFramework.SkeetTextBox();
            this.password = new SkeetFramework.SkeetTextBox();
            this.skeetButton2 = new SkeetUI.skeetButton();
            this.skeetToggle1 = new SkeetFramework.SkeetToggle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(55, 261);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 27);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(55, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 27);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // outline
            // 
            this.outline.AutoSize = true;
            this.outline.BackColor = System.Drawing.Color.Transparent;
            this.outline.Location = new System.Drawing.Point(112, 411);
            this.outline.Name = "outline";
            this.outline.OutlineForeColor = System.Drawing.Color.DarkRed;
            this.outline.OutlineWidth = 1.5F;
            this.outline.Size = new System.Drawing.Size(108, 13);
            this.outline.TabIndex = 12;
            this.outline.Text = "made by shimo#9999";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(90, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 146);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // skeetButton1
            // 
            this.skeetButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skeetButton1.BackgroundImage")));
            this.skeetButton1.ButtonEnabled = true;
            this.skeetButton1.ButtonText = "Login";
            this.skeetButton1.Location = new System.Drawing.Point(95, 365);
            this.skeetButton1.Name = "skeetButton1";
            this.skeetButton1.Size = new System.Drawing.Size(139, 40);
            this.skeetButton1.TabIndex = 8;
            this.skeetButton1.Click += new System.EventHandler(this.skeetButton1_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.username.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.username.FocusOnHover = false;
            this.username.Location = new System.Drawing.Point(95, 228);
            this.username.MaxLength = 32767;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.ReadOnly = false;
            this.username.Size = new System.Drawing.Size(158, 23);
            this.username.TabIndex = 15;
            this.username.Text = "Username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.username.UseSystemPasswordChar = false;
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.password.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.password.FocusOnHover = false;
            this.password.Location = new System.Drawing.Point(95, 265);
            this.password.MaxLength = 32767;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.ReadOnly = false;
            this.password.Size = new System.Drawing.Size(158, 23);
            this.password.TabIndex = 16;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.password.UseSystemPasswordChar = true;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // skeetButton2
            // 
            this.skeetButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skeetButton2.BackgroundImage")));
            this.skeetButton2.ButtonEnabled = true;
            this.skeetButton2.ButtonText = "X";
            this.skeetButton2.Location = new System.Drawing.Point(298, 13);
            this.skeetButton2.Name = "skeetButton2";
            this.skeetButton2.Size = new System.Drawing.Size(25, 25);
            this.skeetButton2.TabIndex = 17;
            this.skeetButton2.Click += new System.EventHandler(this.skeetButton2_Click);
            // 
            // skeetToggle1
            // 
            this.skeetToggle1.BackColor = System.Drawing.Color.Transparent;
            this.skeetToggle1.Checked = false;
            this.skeetToggle1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.skeetToggle1.ColorBottom1 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(161)))), ((int)(((byte)(27)))));
            this.skeetToggle1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.skeetToggle1.ColorTop1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.skeetToggle1.Font = new System.Drawing.Font("Verdana", 7F);
            this.skeetToggle1.Location = new System.Drawing.Point(95, 294);
            this.skeetToggle1.Name = "skeetToggle1";
            this.skeetToggle1.Size = new System.Drawing.Size(96, 16);
            this.skeetToggle1.TabIndex = 18;
            this.skeetToggle1.Text = "Remember me";
            this.skeetToggle1.CheckedChanged += new SkeetFramework.SkeetToggle.CheckedChangedEventHandler(this.skeetToggle1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.skeetToggle1);
            this.Controls.Add(this.skeetButton2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.outline);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.skeetButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private SkeetUI.outlineLabel outline;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SkeetUI.skeetButton skeetButton1;
        private SkeetFramework.SkeetTextBox username;
        private SkeetFramework.SkeetTextBox password;
        private SkeetUI.skeetButton skeetButton2;
        private SkeetFramework.SkeetToggle skeetToggle1;
    }
}