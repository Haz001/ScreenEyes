namespace ScreenEyes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.working_btn = new System.Windows.Forms.Button();
            this.break_btn = new System.Windows.Forms.Button();
            this.settings_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.second = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // working_btn
            // 
            this.working_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.working_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.working_btn.Location = new System.Drawing.Point(123, 0);
            this.working_btn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.working_btn.Name = "working_btn";
            this.working_btn.Size = new System.Drawing.Size(75, 25);
            this.working_btn.TabIndex = 0;
            this.working_btn.Text = "Working";
            this.working_btn.UseVisualStyleBackColor = false;
            // 
            // break_btn
            // 
            this.break_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.break_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.break_btn.Location = new System.Drawing.Point(198, 0);
            this.break_btn.Name = "break_btn";
            this.break_btn.Size = new System.Drawing.Size(75, 25);
            this.break_btn.TabIndex = 0;
            this.break_btn.Text = "Break";
            this.break_btn.UseVisualStyleBackColor = false;
            this.break_btn.Click += new System.EventHandler(this.break_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_btn.Location = new System.Drawing.Point(273, 0);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(75, 25);
            this.settings_btn.TabIndex = 0;
            this.settings_btn.Text = "Settings";
            this.settings_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "0min / 60min";
            // 
            // user_notify
            // 
            this.user_notify.Icon = ((System.Drawing.Icon)(resources.GetObject("user_notify.Icon")));
            this.user_notify.Text = "notifyIcon1";
            this.user_notify.Visible = true;
            // 
            // second
            // 
            this.second.Enabled = true;
            this.second.Interval = 1000;
            this.second.Tick += new System.EventHandler(this.second_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(348, 25);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.break_btn);
            this.Controls.Add(this.working_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button working_btn;
        private System.Windows.Forms.Button break_btn;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon user_notify;
        private System.Windows.Forms.Timer second;
    }
}

