using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManualMapInjection.Injection;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SimpleLoader
{
    public partial class Form2 : Form
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

        public Form2()
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

        private void label4_Click(object sender, EventArgs e) { }

        private void label4_Click_1(object sender, EventArgs e) { }

        private void Form2_Load(object sender, EventArgs e) { }

        int r = 219;
        int g = 219;
        int b = 219;
        bool inv = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (r == 15 && g == 15 && b == 15)
            {
                inv = false;
            }
            if (r == 219 && g == 219 && b == 219)
            {
                inv = true;
            }
            if (inv)
            {
                r--;
                g--;
                b--;
                label4.ForeColor = Color.FromArgb(r, g, b);
                r--;
                g--;
                b--;
                label4.ForeColor = Color.FromArgb(r, g, b);
            }
            else
            {
                r++;
                g++;
                b++;
                label4.ForeColor = Color.FromArgb(r, g, b);
                r++;
                g++;
                b++;
                label4.ForeColor = Color.FromArgb(r, g, b);
            }
        }

        private void label4_Click_2(object sender, EventArgs e) { }

        private void label4_MouseMove(object sender, MouseEventArgs e) { }

        private void next_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string mainpath = "C:\\Windows\\mogelmodul.dll";
            wb.DownloadFile(
                "",
                mainpath
            );
            await Task.Delay(15000);
            var name = "csgo";
            var target = Process.GetProcessesByName(name).FirstOrDefault();
            var path = mainpath;
            var file = File.ReadAllBytes(path);

            var injector = new ManualMapInjector(target) { AsyncInjection = true };
            label4.Text = $"FAIL CANT INJECT{injector.Inject(file).ToInt64():x8}";

            if (!File.Exists(path))
            {
                MessageBox.Show("Error: DLL not found");
                Application.Exit();
                return;
            }

            if (System.IO.File.Exists(mainpath))
            {
                System.IO.File.Delete(mainpath);
                Application.Exit();
            }
        }
    }
}
