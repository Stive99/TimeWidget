using System;
using System.Windows.Forms;

namespace TimeWidget
{
    public partial class Form1 : Form
    {

        private Int32 tmpX;
        private Int32 tmpY;
        private bool flMove = false;

        public Form1()
        {
            InitializeComponent();

            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");

            timerTime.Enabled = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void вклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void выклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = false;
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("HH:mm:ss");
        }

        private void labelTime_MouseMove(object sender, MouseEventArgs e)
        {
            if (flMove)
            {
                this.Left = this.Left + (Cursor.Position.X - tmpX);
                this.Top = this.Top + (Cursor.Position.Y - tmpY);

                tmpX = Cursor.Position.X;
                tmpY = Cursor.Position.Y;
            }
        }

        private void labelTime_MouseUp(object sender, MouseEventArgs e)
        {
            flMove = false;
        }

        private void labelTime_MouseDown(object sender, MouseEventArgs e)
        {
            tmpX = Cursor.Position.X;
            tmpY = Cursor.Position.Y;
            flMove = true;
        }
    }
}
