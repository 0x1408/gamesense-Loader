
namespace SimpleLoader
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label4 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.25F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(111, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "Preparing ...";
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.InfoText;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.SystemColors.InfoText;
            this.next.Location = new System.Drawing.Point(82, 153);
            this.next.Margin = new System.Windows.Forms.Padding(2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(137, 25);
            this.next.TabIndex = 33;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 210);
            this.Controls.Add(this.next);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gamesense";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Timer timer1;
    }
}