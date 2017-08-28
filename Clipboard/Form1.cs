using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace clipboard1
{
    public partial class window : Form
    {
        private int cpCount;
        private List<string> data = new List<string>();
        Timer UpdateTimer = new Timer()
        {
            Interval = 500,
        };

        public window()
        {
            InitializeComponent();
            cpCount = Properties.Settings.Default.cpCount;
            UpdateTimer.Tick += UpdateTimer_Tick;
            UpdateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimer.Stop();
            string clip = Clipboard.GetText();

            if (!data.Contains(clip))
            {
                data.Add(clip);
            }

            UpdateTimer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int i=2;
            if(int.TryParse(eCount.Text, out i))
            {
                if ((i > 2) && (i < 15))
                {
                    cpCount = i;
                }
            }
            Hide();
            ShowInTaskbar = false;
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void window_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            btnClose_Click(null, null);           
        }

        private void window_Paint(object sender, PaintEventArgs e)
        {
            eCount.Text = cpCount.ToString();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
        }

        private void window_Load(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
        }

        [DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern bool SetForegroundWindow(HandleRef hWnd);

        private void notifyIcon1_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip2.Items.Clear();
                foreach (var item in data)
                {
                    contextMenuStrip2.Items.Add(item, null, (s, ev) => { Clipboard.SetText(item); });
                }

                SetForegroundWindow(new HandleRef(this, this.Handle));
                int x = MousePosition.X - 10;
                int y = MousePosition.Y - 40;
                contextMenuStrip2.Show(x, y);

            }
        }
    }
}
