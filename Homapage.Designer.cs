namespace Library_management_project
{
    partial class Homapage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homapage));
            this.HomeBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ExploreBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(289, 23);
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
            this.AboutBtn.Location = new System.Drawing.Point(368, 23);
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
            this.ContactBtn.Location = new System.Drawing.Point(440, 23);
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
            this.button1.Location = new System.Drawing.Point(522, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExploreBtn
            // 
            this.ExploreBtn.FlatAppearance.BorderSize = 0;
            this.ExploreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExploreBtn.Image = global::Library_management_project.Properties.Resources.Explore;
            this.ExploreBtn.Location = new System.Drawing.Point(63, 344);
            this.ExploreBtn.Name = "ExploreBtn";
            this.ExploreBtn.Size = new System.Drawing.Size(251, 57);
            this.ExploreBtn.TabIndex = 9;
            this.ExploreBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(880, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Homapage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_management_project.Properties.Resources.HomePageBG;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ExploreBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ContactBtn);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.HomeBtn);
            this.Name = "Homapage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExploreBtn;
        private System.Windows.Forms.Button button3;
    }
}