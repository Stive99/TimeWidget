using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TimeWidget.Utils
{
    public class Util
    {
        static readonly string version = Application.ProductVersion;
        private static readonly WebClient wc = new WebClient();
        public static string UrlVersion = "https://raw.githubusercontent.com/Stive99/TimeWidget/master/Properties/AssemblyInfo.cs";
        private static readonly string VersionUpdateUrl = wc.DownloadString(UrlVersion);
        public static string VersionUpdate = Regex.Match(VersionUpdateUrl, @"\[assembly\: AssemblyFileVersion\(""(\d+\.\d+\.\d+\.\d+)""\)\]").Groups[1].Value;
        public static string UrlDownload = $"https://github.com/Stive99/TimeWidget/releases/download/{VersionUpdate}/TimeWidget.exe";

        public static void CheckUpdate()
        {
            try
            {
                if (String.Compare(VersionUpdate, version) == 0)
                {
                    // MessageBox.Show("У вас установлена последняя версия программы!", "Обновления не найдены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Текущая версия программы " + version + "\nНовое обновление доступно " + VersionUpdate + "\n\nТребуется обновление.\nОбновить программу до актуальной версии?", "Найдено новое обновление!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DownloadUpdate();
                    }
                }
            }
            catch
            {
                // MessageBox.Show("Отсутствует подключение к интернету!", "Проверте подключение!");
            }
        }

        public static void DownloadUpdate()
        {
            File.Move("TimeWidget.exe", "TimeWidgetOldVersion.exe");

            using (WebClient wc = new WebClient())
            {
                string fileName = Path.Combine(Environment.CurrentDirectory, "TimeWidget.exe");
                wc.DownloadFileAsync(new Uri(UrlDownload), fileName);

                wc.DownloadFileCompleted += (s, e) =>
                {
                    if (e.Error != null)
                    {
                        MessageBox.Show("Ошибка загрузки файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Process.Start(fileName);
                        Application.Exit();
                    }
                };
            }
        }

        public static void SetApplicationOnLeftTop(Form1 form1)
        {
            /*var monitors = Screen.AllScreens;
            foreach (var monitor in monitors)
            {
                if (monitor.DeviceName == form1.Monitor)
                {
                    form1.Location = new Point(monitor.Bounds.X, monitor.Bounds.Y);
                }
            }*/

            Screen.AllScreens.ToList().ForEach(x =>
            {
                if (x.Primary)
                {
                    form1.Location = new Point(x.Bounds.X, x.Bounds.Y);
                }
            });
        }
    }
}
