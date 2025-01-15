namespace Library_management_project
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.CurrentPassTB = new System.Windows.Forms.TextBox();
            this.NewPassTB = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(363, 213);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(314, 20);
            this.UserNameTB.TabIndex = 0;
            // 
            // CurrentPassTB
            // 
            this.CurrentPassTB.Location = new System.Drawing.Point(363, 248);
            this.CurrentPassTB.Name = "CurrentPassTB";
            this.CurrentPassTB.Size = new System.Drawing.Size(314, 20);
            this.CurrentPassTB.TabIndex = 1;
            // 
            // NewPassTB
            // 
            this.NewPassTB.Location = new System.Drawing.Point(363, 284);
            this.NewPassTB.Name = "NewPassTB";
            this.NewPassTB.Size = new System.Drawing.Size(314, 20);
            this.NewPassTB.TabIndex = 2;
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Image = global::Library_management_project.Properties.Resources.Group_611;
            this.SaveBtn.Location = new System.Drawing.Point(602, 330);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(289, 22);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(56, 21);
            this.HomeBtn.TabIndex = 4;
            this.HomeBtn.UseVisualStyleBackColor = true;
            // 
            // AboutBtn
            // 
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("AboutBtn.Image")));
            this.AboutBtn.Location = new System.Drawing.Point(363, 21);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(57, 23);
            this.AboutBtn.TabIndex = 5;
            this.AboutBtn.UseVisualStyleBackColor = true;
            // 
            // ContactBtn
            // 
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.Image = ((System.Drawing.Image)(resources.GetObject("ContactBtn.Image")));
            this.ContactBtn.Location = new System.Drawing.Point(433, 21);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(71, 23);
            this.ContactBtn.TabIndex = 8;
            this.ContactBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(519, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(887, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_management_project.Properties.Resources.Frame_19__2_;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ContactBtn);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NewPassTB);
            this.Controls.Add(this.CurrentPassTB);
            this.Controls.Add(this.UserNameTB);
            this.Name = "ChangePass";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.TextBox CurrentPassTB;
        private System.Windows.Forms.TextBox NewPassTB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}