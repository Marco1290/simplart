namespace simplart
{
    partial class fv_signup
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
            System.Windows.Forms.Button btn_signup;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fv_signup));
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.nud_age = new System.Windows.Forms.NumericUpDown();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lkl_return = new System.Windows.Forms.LinkLabel();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            btn_signup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_age)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_signup
            // 
            btn_signup.BackColor = System.Drawing.Color.SlateGray;
            btn_signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_signup.Location = new System.Drawing.Point(308, 372);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new System.Drawing.Size(148, 27);
            btn_signup.TabIndex = 12;
            btn_signup.Text = "S\'inscrire";
            btn_signup.UseVisualStyleBackColor = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(305, 226);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(71, 13);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Mot de passe";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(305, 184);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(84, 13);
            this.lbl_username.TabIndex = 10;
            this.lbl_username.Text = "Nom d\'utilisateur";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(308, 242);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(148, 20);
            this.txt_password.TabIndex = 8;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(308, 200);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(148, 20);
            this.txt_username.TabIndex = 7;
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::simplart.Properties.Resources.logo;
            this.pic_logo.Location = new System.Drawing.Point(308, 12);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(148, 119);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 9;
            this.pic_logo.TabStop = false;
            // 
            // nud_age
            // 
            this.nud_age.Location = new System.Drawing.Point(308, 287);
            this.nud_age.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_age.Name = "nud_age";
            this.nud_age.Size = new System.Drawing.Size(148, 20);
            this.nud_age.TabIndex = 13;
            this.nud_age.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(305, 271);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(26, 13);
            this.lbl_age.TabIndex = 14;
            this.lbl_age.Text = "Âge";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(305, 136);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(308, 152);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(148, 20);
            this.txt_email.TabIndex = 15;
            // 
            // lkl_return
            // 
            this.lkl_return.AutoSize = true;
            this.lkl_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkl_return.Location = new System.Drawing.Point(351, 402);
            this.lkl_return.Name = "lkl_return";
            this.lkl_return.Size = new System.Drawing.Size(58, 20);
            this.lkl_return.TabIndex = 17;
            this.lkl_return.TabStop = true;
            this.lkl_return.Text = "Retour";
            this.lkl_return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lkl_return.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbo_type
            // 
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Items.AddRange(new object[] {
            "Client",
            "Artiste"});
            this.cbo_type.Location = new System.Drawing.Point(308, 336);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(148, 21);
            this.cbo_type.TabIndex = 19;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(305, 320);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(86, 13);
            this.lbl_type.TabIndex = 20;
            this.lbl_type.Text = "Type d\'utilisateur";
            // 
            // fv_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.cbo_type);
            this.Controls.Add(this.lkl_return);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.nud_age);
            this.Controls.Add(btn_signup);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fv_signup";
            this.Text = "Inscription";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.NumericUpDown nud_age;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.LinkLabel lkl_return;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.Label lbl_type;
    }
}