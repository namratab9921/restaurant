namespace restaurant
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butclose3 = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.butlogin = new System.Windows.Forms.Button();
            this.labpass = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.labuser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(131, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(531, 70);
            this.label3.TabIndex = 10;
            this.label3.Text = "HOTEL SHIVNERI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.butclose3);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.butlogin);
            this.panel1.Controls.Add(this.labpass);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.labuser);
            this.panel1.Location = new System.Drawing.Point(66, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 367);
            this.panel1.TabIndex = 9;
            this.panel1.TabStop = true;
            // 
            // butclose3
            // 
            this.butclose3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butclose3.Cursor = System.Windows.Forms.Cursors.Default;
            this.butclose3.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butclose3.Location = new System.Drawing.Point(353, 256);
            this.butclose3.Name = "butclose3";
            this.butclose3.Size = new System.Drawing.Size(162, 47);
            this.butclose3.TabIndex = 4;
            this.butclose3.Text = "CLOSE";
            this.butclose3.UseVisualStyleBackColor = false;
            this.butclose3.Click += new System.EventHandler(this.butclose3_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(326, 72);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(258, 22);
            this.txtuser.TabIndex = 1;
            // 
            // butlogin
            // 
            this.butlogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butlogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.butlogin.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlogin.Location = new System.Drawing.Point(142, 256);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(162, 47);
            this.butlogin.TabIndex = 3;
            this.butlogin.Text = "LOGIN";
            this.butlogin.UseVisualStyleBackColor = false;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // labpass
            // 
            this.labpass.AutoSize = true;
            this.labpass.BackColor = System.Drawing.Color.Transparent;
            this.labpass.Font = new System.Drawing.Font("High Tower Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labpass.Location = new System.Drawing.Point(100, 177);
            this.labpass.Name = "labpass";
            this.labpass.Size = new System.Drawing.Size(186, 32);
            this.labpass.TabIndex = 2;
            this.labpass.Text = "PASSWORD";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(326, 177);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(258, 22);
            this.txtpass.TabIndex = 2;
            // 
            // labuser
            // 
            this.labuser.AutoSize = true;
            this.labuser.BackColor = System.Drawing.Color.Transparent;
            this.labuser.Font = new System.Drawing.Font("High Tower Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labuser.Location = new System.Drawing.Point(100, 63);
            this.labuser.Name = "labuser";
            this.labuser.Size = new System.Drawing.Size(189, 32);
            this.labuser.TabIndex = 1;
            this.labuser.Text = "USERNAME";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(798, 536);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butclose3;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button butlogin;
        private System.Windows.Forms.Label labpass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label labuser;
    }
}

