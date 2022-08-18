
namespace iServLogger
{
    partial class Home
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.skeetButton1 = new SkeetUI.skeetButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skeetButton2 = new SkeetUI.skeetButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.JoinTimer = new System.Windows.Forms.Timer(this.components);
            this.CustomMsg = new SkeetFramework.SkeetTextBox();
            this.skeetToggle1 = new SkeetFramework.SkeetToggle();
            this.outlineLabel1 = new SkeetFramework.outlineLabel();
            this.passlabel = new SkeetFramework.SkeetTextBox();
            this.userlabel = new SkeetFramework.SkeetTextBox();
            this.conference1 = new SkeetFramework.SkeetTextBox();
            this.outlineLabel2 = new SkeetFramework.outlineLabel();
            this.timeBoxEnd = new SkeetFramework.SkeetTextBox();
            this.timeBoxStart = new SkeetFramework.SkeetTextBox();
            this.schoolTextBox = new SkeetFramework.SkeetTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // skeetButton1
            // 
            this.skeetButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skeetButton1.BackgroundImage")));
            this.skeetButton1.ButtonEnabled = true;
            this.skeetButton1.ButtonText = "Start";
            this.skeetButton1.Location = new System.Drawing.Point(169, 420);
            this.skeetButton1.Name = "skeetButton1";
            this.skeetButton1.Size = new System.Drawing.Size(139, 40);
            this.skeetButton1.TabIndex = 4;
            this.skeetButton1.Click += new System.EventHandler(this.skeetButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(161, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 128);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // skeetButton2
            // 
            this.skeetButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skeetButton2.BackgroundImage")));
            this.skeetButton2.ButtonEnabled = true;
            this.skeetButton2.ButtonText = "X";
            this.skeetButton2.Location = new System.Drawing.Point(429, 21);
            this.skeetButton2.Name = "skeetButton2";
            this.skeetButton2.Size = new System.Drawing.Size(25, 25);
            this.skeetButton2.TabIndex = 18;
            this.skeetButton2.Click += new System.EventHandler(this.skeetButton2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(146, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 27);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(146, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 27);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // JoinTimer
            // 
            this.JoinTimer.Tick += new System.EventHandler(this.JoinTimer_Tick);
            // 
            // CustomMsg
            // 
            this.CustomMsg.BackColor = System.Drawing.Color.Transparent;
            this.CustomMsg.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CustomMsg.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.CustomMsg.FocusOnHover = false;
            this.CustomMsg.Location = new System.Drawing.Point(124, 391);
            this.CustomMsg.MaxLength = 32767;
            this.CustomMsg.Multiline = false;
            this.CustomMsg.Name = "CustomMsg";
            this.CustomMsg.ReadOnly = false;
            this.CustomMsg.Size = new System.Drawing.Size(228, 23);
            this.CustomMsg.TabIndex = 22;
            this.CustomMsg.Text = "Custom Message";
            this.CustomMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomMsg.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CustomMsg.UseSystemPasswordChar = false;
            this.CustomMsg.Enter += new System.EventHandler(this.CustomMsg_Enter);
            this.CustomMsg.Leave += new System.EventHandler(this.CustomMsg_Leave);
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
            this.skeetToggle1.Location = new System.Drawing.Point(195, 253);
            this.skeetToggle1.Name = "skeetToggle1";
            this.skeetToggle1.Size = new System.Drawing.Size(96, 16);
            this.skeetToggle1.TabIndex = 21;
            this.skeetToggle1.Text = "Remember me";
            this.skeetToggle1.CheckedChanged += new SkeetFramework.SkeetToggle.CheckedChangedEventHandler(this.skeetToggle1_CheckedChanged);
            // 
            // outlineLabel1
            // 
            this.outlineLabel1.AutoSize = true;
            this.outlineLabel1.BackColor = System.Drawing.Color.Transparent;
            this.outlineLabel1.Location = new System.Drawing.Point(184, 472);
            this.outlineLabel1.Name = "outlineLabel1";
            this.outlineLabel1.OutlineForeColor = System.Drawing.Color.DarkRed;
            this.outlineLabel1.OutlineWidth = 1.5F;
            this.outlineLabel1.Size = new System.Drawing.Size(108, 13);
            this.outlineLabel1.TabIndex = 11;
            this.outlineLabel1.Text = "made by shimo#9999";
            // 
            // passlabel
            // 
            this.passlabel.BackColor = System.Drawing.Color.Transparent;
            this.passlabel.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.passlabel.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.passlabel.FocusOnHover = false;
            this.passlabel.Location = new System.Drawing.Point(182, 224);
            this.passlabel.MaxLength = 32767;
            this.passlabel.Multiline = false;
            this.passlabel.Name = "passlabel";
            this.passlabel.ReadOnly = false;
            this.passlabel.Size = new System.Drawing.Size(122, 23);
            this.passlabel.TabIndex = 10;
            this.passlabel.Text = "Password";
            this.passlabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passlabel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passlabel.UseSystemPasswordChar = true;
            this.passlabel.Enter += new System.EventHandler(this.passlabel_Enter);
            this.passlabel.Leave += new System.EventHandler(this.passlabel_Leave);
            // 
            // userlabel
            // 
            this.userlabel.BackColor = System.Drawing.Color.Transparent;
            this.userlabel.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.userlabel.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.userlabel.FocusOnHover = false;
            this.userlabel.Location = new System.Drawing.Point(182, 186);
            this.userlabel.MaxLength = 32767;
            this.userlabel.Multiline = false;
            this.userlabel.Name = "userlabel";
            this.userlabel.ReadOnly = false;
            this.userlabel.Size = new System.Drawing.Size(122, 23);
            this.userlabel.TabIndex = 8;
            this.userlabel.Text = "Username";
            this.userlabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userlabel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userlabel.UseSystemPasswordChar = false;
            this.userlabel.Enter += new System.EventHandler(this.userlabel_Enter);
            this.userlabel.Leave += new System.EventHandler(this.userlabel_Leave);
            // 
            // conference1
            // 
            this.conference1.BackColor = System.Drawing.Color.Transparent;
            this.conference1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.conference1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.conference1.FocusOnHover = false;
            this.conference1.Location = new System.Drawing.Point(81, 362);
            this.conference1.MaxLength = 32767;
            this.conference1.Multiline = false;
            this.conference1.Name = "conference1";
            this.conference1.ReadOnly = false;
            this.conference1.Size = new System.Drawing.Size(314, 23);
            this.conference1.TabIndex = 7;
            this.conference1.Text = "Conference URL";
            this.conference1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.conference1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.conference1.UseSystemPasswordChar = false;
            this.conference1.Enter += new System.EventHandler(this.conference1_Enter);
            this.conference1.Leave += new System.EventHandler(this.conference1_Leave);
            // 
            // outlineLabel2
            // 
            this.outlineLabel2.AutoSize = true;
            this.outlineLabel2.BackColor = System.Drawing.Color.Transparent;
            this.outlineLabel2.Location = new System.Drawing.Point(234, 322);
            this.outlineLabel2.Name = "outlineLabel2";
            this.outlineLabel2.OutlineForeColor = System.Drawing.Color.White;
            this.outlineLabel2.OutlineWidth = 1.5F;
            this.outlineLabel2.Size = new System.Drawing.Size(13, 13);
            this.outlineLabel2.TabIndex = 24;
            this.outlineLabel2.Text = "--";
            // 
            // timeBoxEnd
            // 
            this.timeBoxEnd.BackColor = System.Drawing.Color.Transparent;
            this.timeBoxEnd.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.timeBoxEnd.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.timeBoxEnd.FocusOnHover = false;
            this.timeBoxEnd.Location = new System.Drawing.Point(266, 317);
            this.timeBoxEnd.MaxLength = 32767;
            this.timeBoxEnd.Multiline = false;
            this.timeBoxEnd.Name = "timeBoxEnd";
            this.timeBoxEnd.ReadOnly = false;
            this.timeBoxEnd.Size = new System.Drawing.Size(109, 23);
            this.timeBoxEnd.TabIndex = 25;
            this.timeBoxEnd.Text = "Conference End";
            this.timeBoxEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.timeBoxEnd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.timeBoxEnd.UseSystemPasswordChar = false;
            this.timeBoxEnd.Enter += new System.EventHandler(this.timeBoxEnd_Enter);
            this.timeBoxEnd.Leave += new System.EventHandler(this.timeBoxEnd_Leave);
            // 
            // timeBoxStart
            // 
            this.timeBoxStart.BackColor = System.Drawing.Color.Transparent;
            this.timeBoxStart.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.timeBoxStart.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.timeBoxStart.FocusOnHover = false;
            this.timeBoxStart.Location = new System.Drawing.Point(103, 317);
            this.timeBoxStart.MaxLength = 32767;
            this.timeBoxStart.Multiline = false;
            this.timeBoxStart.Name = "timeBoxStart";
            this.timeBoxStart.ReadOnly = false;
            this.timeBoxStart.Size = new System.Drawing.Size(109, 23);
            this.timeBoxStart.TabIndex = 23;
            this.timeBoxStart.Text = "Conference Start";
            this.timeBoxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.timeBoxStart.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.timeBoxStart.UseSystemPasswordChar = false;
            this.timeBoxStart.Enter += new System.EventHandler(this.timeBox_Enter);
            this.timeBoxStart.Leave += new System.EventHandler(this.timeBoxStart_Leave);
            // 
            // schoolTextBox
            // 
            this.schoolTextBox.BackColor = System.Drawing.Color.Transparent;
            this.schoolTextBox.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.schoolTextBox.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.schoolTextBox.FocusOnHover = false;
            this.schoolTextBox.Location = new System.Drawing.Point(81, 275);
            this.schoolTextBox.MaxLength = 32767;
            this.schoolTextBox.Multiline = false;
            this.schoolTextBox.Name = "schoolTextBox";
            this.schoolTextBox.ReadOnly = false;
            this.schoolTextBox.Size = new System.Drawing.Size(314, 23);
            this.schoolTextBox.TabIndex = 26;
            this.schoolTextBox.Text = "Enter iServ School URL";
            this.schoolTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.schoolTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.schoolTextBox.UseSystemPasswordChar = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 512);
            this.Controls.Add(this.schoolTextBox);
            this.Controls.Add(this.timeBoxEnd);
            this.Controls.Add(this.outlineLabel2);
            this.Controls.Add(this.timeBoxStart);
            this.Controls.Add(this.CustomMsg);
            this.Controls.Add(this.skeetToggle1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.skeetButton2);
            this.Controls.Add(this.outlineLabel1);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.conference1);
            this.Controls.Add(this.skeetButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SkeetUI.skeetButton skeetButton1;
        private SkeetFramework.SkeetTextBox conference1;
        private SkeetFramework.SkeetTextBox userlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SkeetFramework.SkeetTextBox passlabel;
        private SkeetFramework.outlineLabel outlineLabel1;
        private SkeetUI.skeetButton skeetButton2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private SkeetFramework.SkeetToggle skeetToggle1;
        private SkeetFramework.SkeetTextBox CustomMsg;
        private System.Windows.Forms.Timer JoinTimer;
        private SkeetFramework.outlineLabel outlineLabel2;
        private SkeetFramework.SkeetTextBox timeBoxEnd;
        private SkeetFramework.SkeetTextBox timeBoxStart;
        private SkeetFramework.SkeetTextBox schoolTextBox;
    }
}

