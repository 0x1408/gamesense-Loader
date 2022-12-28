using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;

namespace SimpleLoader
{
    public partial class Form3 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public string question,
            info;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Form3()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            Random rnd = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            this.Text = new string(
                Enumerable
                    .Repeat(chars, rnd.Next(10, 20))
                    .Select(s => s[rnd.Next(s.Length)])
                    .ToArray()
            );
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "admin")
            {
                this.Hide();
                var form3 = new Form1();
                form3.Closed += (s, args) => this.Close();
                form3.Show();
            }
            else
            {
                this.Hide();
                Form3 frm = new Form3();
                frm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void next_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void next_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void login_TextChanged(object sender, EventArgs e) { }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // Steam check
            Process[] steam = Process.GetProcessesByName("steam");
            if (steam.Length != 0)
            {
                foreach (var process in Process.GetProcessesByName("steam"))
                {
                    process.Kill();
                }
            }
            ServicePointManager.SecurityProtocol =
                SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] ida64 = Process.GetProcessesByName("ida64");
            Process[] ida32 = Process.GetProcessesByName("ida32");
            Process[] ollydbg = Process.GetProcessesByName("ollydbg");
            Process[] ollydbg64 = Process.GetProcessesByName("ollydbg64");
            Process[] loaddll = Process.GetProcessesByName("loaddll");
            Process[] httpdebugger = Process.GetProcessesByName("httpdebugger");
            Process[] windowrenamer = Process.GetProcessesByName("windowrenamer");
            Process[] processhacker = Process.GetProcessesByName("processhacker");
            Process[] processhacker2 = Process.GetProcessesByName("Process Hacker");
            Process[] processhacker3 = Process.GetProcessesByName("ProcessHacker");
            Process[] HxD = Process.GetProcessesByName("HxD");
            Process[] parsecd = Process.GetProcessesByName("parsecd");
            Process[] ida = Process.GetProcessesByName("ida");
            Process[] dnSpy = Process.GetProcessesByName("dnSpy");
            Process[] x64dbg = Process.GetProcessesByName("x64dbg");
            Process[] x32dbg = Process.GetProcessesByName("x32dbg");
            if (
                ida64.Length != 0
                || ida32.Length != 0
                || ollydbg.Length != 0
                || ollydbg64.Length != 0
                || loaddll.Length != 0
                || httpdebugger.Length != 0
                || windowrenamer.Length != 0
                || processhacker.Length != 0
                || processhacker2.Length != 0
                || processhacker3.Length != 0
                || HxD.Length != 0
                || ida.Length != 0
                || parsecd.Length != 0
                || dnSpy.Length != 0
            )
            {
                Application.Exit();
            }
        }

        private void username_MouseDown(object sender, MouseEventArgs e) { }

        private void password_MouseDown(object sender, MouseEventArgs e) { }

        private void username_Enter(object sender, EventArgs e) { }

        private void username_Leave(object sender, EventArgs e) { }

        private void password_Enter(object sender, EventArgs e) { }

        int mouseX = 0,
            mouseY = 0;
        bool mouseDown;

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void password_Leave(object sender, EventArgs e) { }
    }
}

