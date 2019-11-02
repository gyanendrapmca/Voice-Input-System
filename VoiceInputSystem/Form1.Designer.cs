namespace VoiceInputSystem
{
    partial class vcInputSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vcInputSystem));
            this.enbleBtn = new System.Windows.Forms.Button();
            this.dsbleBtn = new System.Windows.Forms.Button();
            this.viewCmd = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.listCmd = new System.Windows.Forms.ListBox();
            this.hideAllCmd = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.TextBox();
            this.msg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enbleBtn
            // 
            this.enbleBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.enbleBtn.Location = new System.Drawing.Point(12, 12);
            this.enbleBtn.Name = "enbleBtn";
            this.enbleBtn.Size = new System.Drawing.Size(234, 56);
            this.enbleBtn.TabIndex = 0;
            this.enbleBtn.Text = "ENABLE VOICE";
            this.enbleBtn.UseVisualStyleBackColor = true;
            this.enbleBtn.Click += new System.EventHandler(this.enbleBtn_Click);
            // 
            // dsbleBtn
            // 
            this.dsbleBtn.Enabled = false;
            this.dsbleBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.dsbleBtn.Location = new System.Drawing.Point(283, 12);
            this.dsbleBtn.Name = "dsbleBtn";
            this.dsbleBtn.Size = new System.Drawing.Size(234, 56);
            this.dsbleBtn.TabIndex = 1;
            this.dsbleBtn.Text = "DISABLE VOICE";
            this.dsbleBtn.UseVisualStyleBackColor = true;
            this.dsbleBtn.Click += new System.EventHandler(this.dsbleBtn_Click);
            // 
            // viewCmd
            // 
            this.viewCmd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCmd.Location = new System.Drawing.Point(554, 12);
            this.viewCmd.Name = "viewCmd";
            this.viewCmd.Size = new System.Drawing.Size(234, 56);
            this.viewCmd.TabIndex = 2;
            this.viewCmd.Text = "VIEW ALL COMMANDS";
            this.viewCmd.UseVisualStyleBackColor = true;
            this.viewCmd.Click += new System.EventHandler(this.viewCmd_Click);
            // 
            // output
            // 
            this.output.Enabled = false;
            this.output.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(12, 340);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(776, 88);
            this.output.TabIndex = 3;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.output.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listCmd
            // 
            this.listCmd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCmd.FormattingEnabled = true;
            this.listCmd.HorizontalExtent = 1;
            this.listCmd.ItemHeight = 15;
            this.listCmd.Items.AddRange(new object[] {
            "Hello",
            "Word",
            "Excel",
            "Powerpoint",
            "Close",
            "Notepad",
            "Wordpad",
            "Calculator",
            "Command",
            "Paint",
            "View",
            "Date",
            "Time",
            "Google"});
            this.listCmd.Location = new System.Drawing.Point(283, 83);
            this.listCmd.Name = "listCmd";
            this.listCmd.Size = new System.Drawing.Size(234, 244);
            this.listCmd.TabIndex = 4;
            this.listCmd.Visible = false;
            // 
            // hideAllCmd
            // 
            this.hideAllCmd.Enabled = false;
            this.hideAllCmd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideAllCmd.Location = new System.Drawing.Point(12, 83);
            this.hideAllCmd.Name = "hideAllCmd";
            this.hideAllCmd.Size = new System.Drawing.Size(234, 56);
            this.hideAllCmd.TabIndex = 5;
            this.hideAllCmd.Text = "HIDE ALL COMMANDS";
            this.hideAllCmd.UseVisualStyleBackColor = true;
            this.hideAllCmd.Click += new System.EventHandler(this.hideAllCmd_Click);
            // 
            // time
            // 
            this.time.Enabled = false;
            this.time.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(12, 216);
            this.time.Multiline = true;
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(233, 111);
            this.time.TabIndex = 6;
            // 
            // msg
            // 
            this.msg.Enabled = false;
            this.msg.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.Location = new System.Drawing.Point(554, 83);
            this.msg.Multiline = true;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(234, 244);
            this.msg.TabIndex = 7;
            this.msg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vcInputSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.time);
            this.Controls.Add(this.hideAllCmd);
            this.Controls.Add(this.listCmd);
            this.Controls.Add(this.output);
            this.Controls.Add(this.viewCmd);
            this.Controls.Add(this.dsbleBtn);
            this.Controls.Add(this.enbleBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vcInputSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VOICE INPUT SYSTEM";
            this.Load += new System.EventHandler(this.vcInputSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enbleBtn;
        private System.Windows.Forms.Button dsbleBtn;
        private System.Windows.Forms.Button viewCmd;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.ListBox listCmd;
        private System.Windows.Forms.Button hideAllCmd;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox msg;
    }
}

