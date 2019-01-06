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
            this.working_btn.Location = new System.Drawing.Point(12, 12);
            this.working_btn.Name = "working_btn";
            this.working_btn.Size = new System.Drawing.Size(75, 23);
            this.working_btn.TabIndex = 0;
            this.working_btn.Text = "Working";
            this.working_btn.UseVisualStyleBackColor = true;
            // 
            // break_btn
            // 
            this.break_btn.Location = new System.Drawing.Point(13, 41);
            this.break_btn.Name = "break_btn";
            this.break_btn.Size = new System.Drawing.Size(75, 23);
            this.break_btn.TabIndex = 0;
            this.break_btn.Text = "break_btn";
            this.break_btn.UseVisualStyleBackColor = true;
            // 
            // settings_btn
            // 
            this.settings_btn.Location = new System.Drawing.Point(12, 70);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(75, 23);
            this.settings_btn.TabIndex = 0;
            this.settings_btn.Text = "Settings";
            this.settings_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
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
            this.ClientSize = new System.Drawing.Size(100, 120);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.break_btn);
            this.Controls.Add(this.working_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
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

