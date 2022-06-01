using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using TimeWidget.Utils;

namespace TimeWidget
{
    public partial class Form1 : Form
    {
        public string hms = "HH:mm:ss";

        public Form1()
        {
            InitializeComponent();

            labelTime.Text = DateTime.Now.ToString(hms);
            timerTime.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("TimeWidgetOldVersion.exe"))
            {
                File.Delete("TimeWidgetOldVersion.exe");
            }

            Util.CheckUpdate();

            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\TimeWidget", true))
            {
                if (key.GetValue("TopMost") != null)
                {
                    bool topMost = key?.GetValue("TopMost")?.ToString() == "True";
                    _ = topMost == true ? TopMost = true : TopMost = false;
                }
                else
                {
                    key.SetValue("TopMost", false);
                }

                if (key.GetValue("TextColor") != null)
                {
                    object textColor = key?.GetValue("TextColor");
                    labelTime.ForeColor = ColorTranslator.FromWin32((int)textColor);
                }
                else
                {
                    key.SetValue("TextColor", ColorTranslator.ToWin32(Color.FromArgb(0, 255, 255, 255)));
                }
                
                if (key.GetValue("BackgroundColor") != null)
                {
                    object bgColor = key?.GetValue("BackgroundColor");
                    BackColor = ColorTranslator.FromWin32((int)bgColor);
                }
                else
                {
                    key.SetValue("BackgroundColor", ColorTranslator.ToWin32(Color.FromArgb(0, 29, 29, 29)));
                }

                if (key.GetValue("RunWithWindows") != null)
                {

                }
                else
                {
                    key.SetValue("RunWithWindows", false);
                }

                if (key.GetValue("Font") != null)
                {
                    object font = key?.GetValue("Font");
                    labelTime.Font = new Font(font.ToString(), labelTime.Font.Size);
                }
                else
                {
                    key.SetValue("Font", labelTime.Font.Name);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString(hms);
        }

        private void labelTime_MouseDown(object sender, MouseEventArgs e)
        {
            labelTime.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Settings"] == null)
            {
                new Settings(this).Show();
            }
            else
            {
                Application.OpenForms["Settings"].Focus();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
