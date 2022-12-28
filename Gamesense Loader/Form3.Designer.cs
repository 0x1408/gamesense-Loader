
namespace SimpleLoader
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.next = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.InfoText;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next.Location = new System.Drawing.Point(79, 154);
            this.next.Margin = new System.Windows.Forms.Padding(2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(137, 25);
            this.next.TabIndex = 17;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click_1);
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.SystemColors.InfoText;
            this.load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("load.BackgroundImage")));
            this.load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load.Cursor = System.Windows.Forms.Cursors.Default;
            this.load.FlatAppearance.BorderSize = 0;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.load.Location = new System.Drawing.Point(79, 121);
            this.load.Margin = new System.Windows.Forms.Padding(2);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(137, 25);
            this.load.TabIndex = 16;
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Gainsboro;
            this.password.Location = new System.Drawing.Point(68, 72);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(159, 19);
            this.password.TabIndex = 11;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            this.password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.password_MouseDown);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Gainsboro;
            this.username.Location = new System.Drawing.Point(68, 35);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(159, 19);
            this.username.TabIndex = 11;
            this.username.Tag = "";
            this.username.TextChanged += new System.EventHandler(this.login_TextChanged);
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            this.username.MouseDown += new System.Windows.Forms.MouseEventHandler(this.username_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 207);
            this.panel1.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(298, 207);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 210);
            this.Controls.Add(this.next);
            this.Controls.Add(this.load);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gamesense";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}