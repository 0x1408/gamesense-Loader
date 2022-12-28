using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using SimpleLoader;
using System.Runtime.InteropServices;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
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

        public Form1()
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

        private void Form1_Load(object sender, EventArgs e) { }

        private void checkonline() { }

        private void pictureBox3_Click(object sender, EventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void pictureBox2_Click_1(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void pictureBox4_Click(object sender, EventArgs e) { }

        private void pictureBox5_Click(object sender, EventArgs e) { }

        private void pictureBox6_Click(object sender, EventArgs e) { }

        private async void button2_Click(object sender, EventArgs e)
        {
            Process.Start("steam://rungameid/730");
            await Task.Delay(40000);
            WebClient wb = new WebClient();
            var name = "csgo";
            var target = Process.GetProcessesByName(name).FirstOrDefault();
            {
                string processName = name;
                var processExists = Process.GetProcesses().Any(p => p.ProcessName == processName);
                if (!processExists)
                {
                    MessageBox.Show(
                        "Counter-Strike: Global Offensive not found please open csgo before loader."
                    );
                    Application.Exit();
                }
                else
                {
                    this.Hide();
                    Form5 frm = new Form5();
                    frm.Show();
                }
                if (!processExists)
                {
                    Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) { }

        private void label8_Click_1(object sender, EventArgs e) { }

        private void pictureBox8_Click(object sender, EventArgs e) { }

        private void label7_Click_1(object sender, EventArgs e) { }

        private void label6_Click_1(object sender, EventArgs e) { }

        private void label5_Click_2(object sender, EventArgs e) { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void pictureBox7_Click(object sender, EventArgs e) { }

        private void timer1_Tick_1(object sender, EventArgs e)
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

        private void label9_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form5();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // label5
            this.pictureBox8.Location = new System.Drawing.Point(41, 177);
            this.label5.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(26)))),
                ((int)(((byte)(26)))),
                ((int)(((byte)(26))))
            );
            this.label5.ForeColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(160)))),
                ((int)(((byte)(200)))),
                ((int)(((byte)(70))))
            );
            this.label5.Font = new System.Drawing.Font(
                "Verdana",
                6.25F,
                System.Drawing.FontStyle.Bold
            );
            // lb7
            this.label7.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb6
            this.label6.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb8
            this.label8.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb9
            this.label9.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Verdana", 6.25F);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // label6
            this.pictureBox8.Location = new System.Drawing.Point(41, 192);
            this.label6.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(26)))),
                ((int)(((byte)(26)))),
                ((int)(((byte)(26))))
            );
            this.label6.ForeColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(160)))),
                ((int)(((byte)(200)))),
                ((int)(((byte)(70))))
            );
            this.label6.Font = new System.Drawing.Font(
                "Verdana",
                6.25F,
                System.Drawing.FontStyle.Bold
            );
            // lb7
            this.label7.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb5
            this.label5.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb8
            this.label8.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb9
            this.label9.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Verdana", 6.25F);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // label7
            this.pictureBox8.Location = new System.Drawing.Point(41, 207);
            this.label7.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(26)))),
                ((int)(((byte)(26)))),
                ((int)(((byte)(26))))
            );
            this.label7.ForeColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(160)))),
                ((int)(((byte)(200)))),
                ((int)(((byte)(70))))
            );
            this.label7.Font = new System.Drawing.Font(
                "Verdana",
                6.25F,
                System.Drawing.FontStyle.Bold
            );
            // lb8
            this.label8.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb6
            this.label6.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb5
            this.label5.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb9
            this.label9.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Verdana", 6.25F);
        }

        private void pictureBox8_Click_1(object sender, EventArgs e) { }

        private void label9_Click_1(object sender, EventArgs e)
        {
            this.pictureBox8.Location = new System.Drawing.Point(41, 222);
            this.label9.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(26)))),
                ((int)(((byte)(26)))),
                ((int)(((byte)(26))))
            );
            this.label9.ForeColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(160)))),
                ((int)(((byte)(200)))),
                ((int)(((byte)(70))))
            );
            this.label9.Font = new System.Drawing.Font(
                "Verdana",
                6.25F,
                System.Drawing.FontStyle.Bold
            );
            // lb7
            this.label7.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb6
            this.label6.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb5
            this.label5.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb8
            this.label8.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Verdana", 6.25F);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // label8
            this.pictureBox8.Location = new System.Drawing.Point(41, 238);
            this.label8.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(26)))),
                ((int)(((byte)(26)))),
                ((int)(((byte)(26))))
            );
            this.label8.ForeColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(160)))),
                ((int)(((byte)(200)))),
                ((int)(((byte)(70))))
            );
            this.label8.Font = new System.Drawing.Font(
                "Verdana",
                6.25F,
                System.Drawing.FontStyle.Bold
            );
            // lb7
            this.label7.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb6
            this.label6.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb5
            this.label5.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Verdana", 6.25F);
            // lb9
            this.label9.BackColor = System.Drawing.Color.FromArgb(
                ((int)(((byte)(35)))),
                ((int)(((byte)(35)))),
                ((int)(((byte)(35))))
            );
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Verdana", 6.25F);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        int mouseX = 0,
            mouseY = 0;
        bool mouseDown;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
