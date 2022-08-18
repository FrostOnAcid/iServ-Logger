using System;
using SkeetUI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iServLogger.Properties;
using System.Threading;

namespace iServLogger
{
    public partial class Home : skeetForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.Default.ServRemember)
            {
                userlabel.Text = Settings.Default.ServUser;
                passlabel.Text = Settings.Default.ServPass;
                skeetToggle1.Checked = true;
            }
        }

        private void skeetButton_Click(object sender, EventArgs e)
        {
            int whileschleife = 1;



            while (whileschleife == 1)
            {
                string StartuhrzeitUhrzeit = DateTime.Now.ToString();



                if (StartuhrzeitUhrzeit == timeBoxStart.Text)
                {

                    whileschleife++;

                    string userInput;
                    userInput = userlabel.Text;

                    string passInput;
                    passInput = passlabel.Text;

                    string conferenceInput;
                    conferenceInput = conference1.Text;

                    string schoolURL;
                    schoolURL = schoolTextBox.Text;


                    IWebDriver ChromeDriver = new ChromeDriver();

                    //Locating iServ
                    ChromeDriver.Navigate().GoToUrl(schoolURL);

                    //Login user to iServ

                    //Locate Input Fields
                    IWebElement user = ChromeDriver.FindElement(By.CssSelector("input.form-control"));

                    IWebElement pass = ChromeDriver.FindElement(By.Name("_password"));

                    //Make sure both fields are clean
                    user.Clear();
                    pass.Clear();

                    //Enter Login credentials!
                    user.SendKeys(userInput);
                    pass.SendKeys(passInput);

                    //Login
                    IWebElement LoginBtn = ChromeDriver.FindElement(By.ClassName("col-xs-6"));
                    LoginBtn.Click();
                    Thread.Sleep(2000);

                    //Open Conferences
                    ChromeDriver.Navigate().GoToUrl(conferenceInput);
                    Thread.Sleep(3000);

                    IWebElement ListenOnly = ChromeDriver.FindElement(By.XPath("//button[@aria-label='Nur zuhören']"));
                    ListenOnly.Click();
                    Thread.Sleep(10000);

                    //Open Chat
                    IWebElement ChatBtn = ChromeDriver.FindElement(By.ClassName("chatName--ZA4lI2"));
                    ChatBtn.Click();
                    Thread.Sleep(3000);

                    //Send Custom User Message
                    IWebElement custommsg = ChromeDriver.FindElement(By.Id("message-input"));
                    custommsg.Clear();
                    custommsg.SendKeys(CustomMsg.Text);

                    //Send
                    IWebElement SendMessage = ChromeDriver.FindElement(By.XPath("//button[@aria-label='Nachricht senden']"));
                    SendMessage.Click();

                    //Thread.Sleep(d);

                    whileschleife++;
                    while (whileschleife == 3)
                    {
                        string EndUhrzeit = DateTime.Now.ToString();
                        if (EndUhrzeit == timeBoxEnd.Text)
                        {
                            whileschleife++;
                            ChromeDriver.Close();
                        }
                    }
                }

            }

        }

        private void userlabel_Enter(object sender, EventArgs e)
        {
            if (userlabel.Text == "Username")
            {
                userlabel.Text = null;
            }
        }

        private void userlabel_Leave(object sender, EventArgs e)
        {
            if (userlabel.Text == "")
            {
                userlabel.Text = "Username";
            }
        }

        private void passlabel_Enter(object sender, EventArgs e)
        {
            if (passlabel.Text == "Password")
            {
                passlabel.Text = null;
            }
        }

        private void passlabel_Leave(object sender, EventArgs e)
        {
            if (passlabel.Text == "")
            {
                passlabel.Text = "Password";
            }
        }

        private void skeetButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void conference1_Enter(object sender, EventArgs e)
        {
            if (conference1.Text == "Conference URL")
            {
                conference1.Text = null;
            }
        }

        private void conference1_Leave(object sender, EventArgs e)
        {
            if (conference1.Text == "")
            {
                conference1.Text = "Conference URL";
            }
        }

        private void skeetToggle1_CheckedChanged(object sender)
        {
            if (skeetToggle1.Checked)
            {
                Settings.Default.ServRemember = true;
                Settings.Default.ServUser = userlabel.Text;
                Settings.Default.ServPass = passlabel.Text;
                Settings.Default.Save();
            }
        }

        private void CustomMsg_Leave(object sender, EventArgs e)
        {
            if (CustomMsg.Text == "")
            {
                CustomMsg.Text = "Custom Message";
            }
        }

        private void CustomMsg_Enter(object sender, EventArgs e)
        {
            if (CustomMsg.Text == "Custom Message")
            {
                CustomMsg.Text = null;
            }
        }

        private void JoinTimer_Tick(object sender, EventArgs e)
        {

        }

        private void timeBox_Enter(object sender, EventArgs e)
        {
            if (conference1.Text == "Conference Start")
            {
                conference1.Text = null;
            }
            MessageBox.Show("Please enter when the iServ Logger should join your Conference! Format: DD:MM:YY HH:MM:SS");
        }

        private void timeBoxStart_Leave(object sender, EventArgs e)
        {
            if (conference1.Text == "")
            {
                conference1.Text = "Conference Start";
            }
        }

        private void timeBoxEnd_Enter(object sender, EventArgs e)
        {
            if (conference1.Text == "End Time")
            {
                conference1.Text = null;
            }
            MessageBox.Show("Please enter when the iServ Logger should leave your Conference! Format: DD:MM:YY HH:MM:SS");
        }

        private void timeBoxEnd_Leave(object sender, EventArgs e)
        {
            if (conference1.Text == "")
            {
                conference1.Text = "Conference End";
            }
        }

        private void timeBoxEnd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
