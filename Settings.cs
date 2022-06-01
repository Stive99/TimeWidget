using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TimeWidget.Utils;

namespace TimeWidget
{
    public partial class Settings : Form
    {
        readonly Form1 form1;

        public Settings(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();

            colorDialog1.FullOpen = true;

            comboBox1.Text = "24 часовой";
            comboBoxFonts.Text = form1.labelTime.Font.Name;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            label1.Text = $"BZH Studio © 2020 - {DateTime.Now.Year}";

            BackColor = Color.FromArgb(255, 29, 29, 29);

            IEnumerable<Label> labels = Controls.OfType<Label>().Where(x => x.Name.StartsWith("label"));
            foreach (var label in labels)
            {
                label.BackColor = Color.FromArgb(255, 29, 29, 29);
                label.ForeColor = Color.FromArgb(0, 255, 255, 255);
            }

            IEnumerable<Button> buttons = Controls.OfType<Button>().Where(x => x.Name.StartsWith("button"));
            foreach (var button in buttons)
            {
                button.BackColor = Color.FromArgb(255, 29, 29, 29);
                button.ForeColor = Color.FromArgb(0, 255, 255, 255);
            }

            IEnumerable<ComboBox> comboBoxes = Controls.OfType<ComboBox>().Where(x => x.Name.StartsWith("comboBox"));
            foreach (var comboBox in comboBoxes)
            {
                comboBox.BackColor = Color.FromArgb(255, 29, 29, 29);
                comboBox.ForeColor = Color.FromArgb(0, 255, 255, 255);
            }

            IEnumerable<CheckBox> checkBoxes = Controls.OfType<CheckBox>().Where(x => x.Name.StartsWith("checkBox"));
            foreach (var checkBox in checkBoxes)
            {
                checkBox.BackColor = Color.FromArgb(255, 29, 29, 29);
                checkBox.ForeColor = Color.FromArgb(0, 255, 255, 255);
            }

            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\TimeWidget", true))
            {
                bool topMost = key?.GetValue("TopMost")?.ToString() == "True";
                if (topMost)
                {
                    checkBoxTopMost.Checked = true;
                }
                else
                {
                    checkBoxTopMost.Checked = false;
                }

                bool runWithWindows = key?.GetValue("RunWithWindows")?.ToString() == "True";
                if (runWithWindows)
                {
                    checkBoxRunWithWindows.Checked = true;
                }
                else
                {
                    checkBoxRunWithWindows.Checked = false;
                }
            }

            foreach (FontFamily font in FontFamily.Families)
            {
                comboBoxFonts.Items.Add(font.Name.ToString());
            }
        }

        private void checkBoxTopMost_CheckedChanged(object sender, EventArgs e)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\TimeWidget", true))
            {
                if (checkBoxTopMost.Checked)
                {
                    form1.TopMost = true;
                    key.SetValue("TopMost", true);
                }
                else
                {
                    form1.TopMost = false;
                    key.SetValue("TopMost", false);
                }
            }
        }

        private void ButtonWidgetColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;

            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\TimeWidget", true))
            {
                key.SetValue("BackgroundColor", ColorTranslator.ToWin32(Color.FromArgb(colorDialog1.Color.ToArgb())));
                form1.BackColor = colorDialog1.Color;
                form1.labelTime.BackColor = colorDialog1.Color;
            }
        }

        private void ButtonTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;

            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\TimeWidget", true))
            {
                var textColor = key?.GetValue("TextColor");
                form1.labelTime.ForeColor = ColorTranslator.FromWin32((int)textColor);

                key.SetValue("TextColor", ColorTranslator.ToWin32(Color.FromArgb(colorDialog1.Color.A, colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B)));
                form1.labelTime.ForeColor = colorDialog1.Color;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // object selectedItem = comboBox1.SelectedItem;
            // form1.hms = selectedItem.ToString();
            string standartTime = "HH:mm:ss";
            string twelveTime = "hh:mm:ss";
            string NotSecTime12 = "hh:mm";
            string NotSecTime24 = "HH:mm";

            if (comboBox1.SelectedItem.ToString() == "24 часовой")
            {
                form1.hms = standartTime;
            }
            else if (comboBox1.SelectedItem.ToString() == "12 часовой")
            {
                form1.hms = twelveTime;
            }
            else if (comboBox1.SelectedItem.ToString() == "Без секунд (12)")
            {
                form1.hms = NotSecTime12;
            }
            else if (comboBox1.SelectedItem.ToString() == "Без секунд (24)")
            {
                form1.hms = NotSecTime24;
            }
        }

        private void comboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\TimeWidget", true))
            {
                key.SetValue("Font", comboBoxFonts.Text);
                form1.labelTime.Font = new Font(comboBoxFonts.Text, form1.labelTime.Font.Size);
            }
        }

        private void checkBoxRunWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\TimeWidget", true))
            {
                using (RegistryKey keyrun = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (checkBoxRunWithWindows.Checked)
                    {
                        key.SetValue("RunWithWindows", true);
                        keyrun.SetValue("TimeWidget", Application.ExecutablePath);
                    }
                    else
                    {
                        key.SetValue("RunWithWindows", false);
                        keyrun.DeleteValue("TimeWidget", false);
                    }
                }
            }
        }
    }
}
