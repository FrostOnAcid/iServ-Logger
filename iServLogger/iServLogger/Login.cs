using System;
using SkeetUI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iServLogger.Properties;
using DiscordRPC;

namespace iServLogger
{
    public partial class Login : skeetForm
    {
        public static DiscordRpcClient client;
        public Login()
        {
            UpdateRPC();
            InitializeComponent();

            void UpdateRPC()
            {
                client = new DiscordRpcClient("INSERT RPC KEY HERE");
                client.Initialize();
                client.SetPresence(new RichPresence()
                {
                    Details = "❄️made by shimo#9999❄",
                    

                    Assets = new Assets()
                    {
                        LargeImageKey = "iservloggerico",
                        LargeImageText = "iServ Logger"
                    }
                });
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void user2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(Settings.Default.AppRemember)
            {
                username.Text = Settings.Default.AppUser;
                password.Text = Settings.Default.AppPass;
                skeetToggle1.Checked = true;
            }
        }

        private void skeetButton1_Click(object sender, EventArgs e)
        {

            //Put code here of what you want to do after successful login
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            new Home().Show();
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = null;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = null;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
            }
        }

        private void skeetButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void skeetToggle1_CheckedChanged(object sender)
        {
            if(skeetToggle1.Checked)
            {
                Settings.Default.AppRemember = true;
                Settings.Default.AppUser = username.Text;
                Settings.Default.AppPass = password.Text;
                Settings.Default.Save();
            }
        }
    }
}

