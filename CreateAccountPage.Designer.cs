namespace Library_management_project
{
    partial class CreateAccountPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountPage));
            this.HomeBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GiveUserName = new System.Windows.Forms.TextBox();
            this.GivePassword = new System.Windows.Forms.TextBox();
            this.CreateNewAccBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CreateAccAs = new System.Windows.Forms.Label();
            this.GiveRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(293, 24);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(56, 21);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.UseVisualStyleBackColor = true;
            // 
            // AboutBtn
            // 
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("AboutBtn.Image")));
            this.AboutBtn.Location = new System.Drawing.Point(368, 24);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(57, 23);
            this.AboutBtn.TabIndex = 3;
            this.AboutBtn.UseVisualStyleBackColor = true;
            // 
            // ContactBtn
            // 
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.Image = ((System.Drawing.Image)(resources.GetObject("ContactBtn.Image")));
            this.ContactBtn.Location = new System.Drawing.Point(440, 24);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(71, 23);
            this.ContactBtn.TabIndex = 7;
            this.ContactBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(522, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GiveUserName
            // 
            this.GiveUserName.Location = new System.Drawing.Point(425, 225);
            this.GiveUserName.Name = "GiveUserName";
            this.GiveUserName.Size = new System.Drawing.Size(296, 20);
            this.GiveUserName.TabIndex = 9;
            // 
            // GivePassword
            // 
            this.GivePassword.Location = new System.Drawing.Point(425, 264);
            this.GivePassword.Name = "GivePassword";
            this.GivePassword.Size = new System.Drawing.Size(296, 20);
            this.GivePassword.TabIndex = 10;
            // 
            // CreateNewAccBtn
            // 
            this.CreateNewAccBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateNewAccBtn.FlatAppearance.BorderSize = 0;
            this.CreateNewAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewAccBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CreateNewAccBtn.Image = global::Library_management_project.Properties.Resources.Create_account;
            this.CreateNewAccBtn.Location = new System.Drawing.Point(544, 381);
            this.CreateNewAccBtn.Name = "CreateNewAccBtn";
            this.CreateNewAccBtn.Size = new System.Drawing.Size(177, 22);
            this.CreateNewAccBtn.TabIndex = 11;
            this.CreateNewAccBtn.UseVisualStyleBackColor = false;
            this.CreateNewAccBtn.Click += new System.EventHandler(this.CreateNewAccBtn_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(880, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CreateAccAs
            // 
            this.CreateAccAs.AutoSize = true;
            this.CreateAccAs.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccAs.Location = new System.Drawing.Point(218, 302);
            this.CreateAccAs.Name = "CreateAccAs";
            this.CreateAccAs.Size = new System.Drawing.Size(179, 23);
            this.CreateAccAs.TabIndex = 13;
            this.CreateAccAs.Text = "Create Acc As";
            // 
            // GiveRole
            // 
            this.GiveRole.FormattingEnabled = true;
            this.GiveRole.Items.AddRange(new object[] {
            "Admin",
            "Librarian ",
            "Member"});
            this.GiveRole.Location = new System.Drawing.Point(425, 303);
            this.GiveRole.Name = "GiveRole";
            this.GiveRole.Size = new System.Drawing.Size(296, 21);
            this.GiveRole.TabIndex = 14;
            // 
            // CreateAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_management_project.Properties.Resources.CreateAccountBG;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.GiveRole);
            this.Controls.Add(this.CreateAccAs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateNewAccBtn);
            this.Controls.Add(this.GivePassword);
            this.Controls.Add(this.GiveUserName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ContactBtn);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.HomeBtn);
            this.Name = "CreateAccountPage";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox GiveUserName;
        private System.Windows.Forms.TextBox GivePassword;
        private System.Windows.Forms.Button CreateNewAccBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label CreateAccAs;
        private System.Windows.Forms.ComboBox GiveRole;
    }
}