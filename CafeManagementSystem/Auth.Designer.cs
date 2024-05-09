namespace CafeManagementSystem
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.username_login = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.password_login = new MaterialSkin.Controls.MaterialTextBox();
            this.login = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.username_register = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.email = new MaterialSkin.Controls.MaterialTextBox();
            this.contact = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.password_register = new MaterialSkin.Controls.MaterialTextBox();
            this.register = new MaterialSkin.Controls.MaterialButton();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList3;
            this.materialTabControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1327, 904);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.ImageKey = "login.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1319, 875);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.username_login);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.password_login);
            this.materialCard1.Controls.Add(this.login);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(719, 239);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard1.Size = new System.Drawing.Size(600, 489);
            this.materialCard1.TabIndex = 0;
            // 
            // username_login
            // 
            this.username_login.AnimateReadOnly = false;
            this.username_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_login.Depth = 0;
            this.username_login.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.username_login.LeadingIcon = null;
            this.username_login.Location = new System.Drawing.Point(19, 80);
            this.username_login.Margin = new System.Windows.Forms.Padding(4);
            this.username_login.MaxLength = 50;
            this.username_login.MouseState = MaterialSkin.MouseState.OUT;
            this.username_login.Multiline = false;
            this.username_login.Name = "username_login";
            this.username_login.Size = new System.Drawing.Size(563, 50);
            this.username_login.TabIndex = 6;
            this.username_login.Text = "";
            this.username_login.TrailingIcon = null;
            this.username_login.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged_1);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(23, 214);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(23, 40);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Name";
            // 
            // password_login
            // 
            this.password_login.AnimateReadOnly = false;
            this.password_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_login.Depth = 0;
            this.password_login.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.password_login.LeadingIcon = null;
            this.password_login.Location = new System.Drawing.Point(23, 251);
            this.password_login.Margin = new System.Windows.Forms.Padding(4);
            this.password_login.MaxLength = 50;
            this.password_login.MouseState = MaterialSkin.MouseState.OUT;
            this.password_login.Multiline = false;
            this.password_login.Name = "password_login";
            this.password_login.Password = true;
            this.password_login.Size = new System.Drawing.Size(563, 50);
            this.password_login.TabIndex = 2;
            this.password_login.Text = "";
            this.password_login.TrailingIcon = null;
            // 
            // login
            // 
            this.login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.login.Depth = 0;
            this.login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.login.HighEmphasis = true;
            this.login.Icon = null;
            this.login.Location = new System.Drawing.Point(19, 436);
            this.login.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.login.MouseState = MaterialSkin.MouseState.HOVER;
            this.login.Name = "login";
            this.login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.login.Size = new System.Drawing.Size(562, 36);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.login.UseAccentColor = false;
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.ImageKey = "register.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1319, 875);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sign up";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel8);
            this.materialCard2.Controls.Add(this.username_register);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.email);
            this.materialCard2.Controls.Add(this.contact);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Controls.Add(this.password_register);
            this.materialCard2.Controls.Add(this.register);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(372, 150);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard2.Size = new System.Drawing.Size(630, 592);
            this.materialCard2.TabIndex = 1;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(28, 250);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(56, 19);
            this.materialLabel8.TabIndex = 17;
            this.materialLabel8.Text = "Contact";
            // 
            // username_register
            // 
            this.username_register.AnimateReadOnly = false;
            this.username_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_register.Depth = 0;
            this.username_register.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.username_register.LeadingIcon = null;
            this.username_register.Location = new System.Drawing.Point(19, 55);
            this.username_register.Margin = new System.Windows.Forms.Padding(4);
            this.username_register.MaxLength = 50;
            this.username_register.MouseState = MaterialSkin.MouseState.OUT;
            this.username_register.Multiline = false;
            this.username_register.Name = "username_register";
            this.username_register.Size = new System.Drawing.Size(545, 50);
            this.username_register.TabIndex = 14;
            this.username_register.Text = "";
            this.username_register.TrailingIcon = null;
            this.username_register.TextChanged += new System.EventHandler(this.materialTextBox3_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(23, 137);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(41, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Email";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(23, 17);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(43, 19);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Name";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // email
            // 
            this.email.AnimateReadOnly = false;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Depth = 0;
            this.email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.email.LeadingIcon = null;
            this.email.Location = new System.Drawing.Point(19, 176);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.MaxLength = 50;
            this.email.MouseState = MaterialSkin.MouseState.OUT;
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(545, 50);
            this.email.TabIndex = 11;
            this.email.Text = "";
            this.email.TrailingIcon = null;
            // 
            // contact
            // 
            this.contact.AnimateReadOnly = false;
            this.contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contact.Depth = 0;
            this.contact.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contact.LeadingIcon = null;
            this.contact.Location = new System.Drawing.Point(19, 287);
            this.contact.Margin = new System.Windows.Forms.Padding(4);
            this.contact.MaxLength = 50;
            this.contact.MouseState = MaterialSkin.MouseState.OUT;
            this.contact.Multiline = false;
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(545, 50);
            this.contact.TabIndex = 10;
            this.contact.Text = "";
            this.contact.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(19, 367);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(71, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Password";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(19, 260);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(1, 0);
            this.materialLabel6.TabIndex = 8;
            // 
            // password_register
            // 
            this.password_register.AnimateReadOnly = false;
            this.password_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_register.Depth = 0;
            this.password_register.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.password_register.LeadingIcon = null;
            this.password_register.Location = new System.Drawing.Point(19, 405);
            this.password_register.Margin = new System.Windows.Forms.Padding(4);
            this.password_register.MaxLength = 50;
            this.password_register.MouseState = MaterialSkin.MouseState.OUT;
            this.password_register.Multiline = false;
            this.password_register.Name = "password_register";
            this.password_register.Password = true;
            this.password_register.Size = new System.Drawing.Size(545, 50);
            this.password_register.TabIndex = 7;
            this.password_register.Text = "";
            this.password_register.TrailingIcon = null;
            // 
            // register
            // 
            this.register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.register.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.register.Depth = 0;
            this.register.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.register.HighEmphasis = true;
            this.register.Icon = null;
            this.register.Location = new System.Drawing.Point(19, 539);
            this.register.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.register.MouseState = MaterialSkin.MouseState.HOVER;
            this.register.Name = "register";
            this.register.NoAccentTextColor = System.Drawing.Color.Empty;
            this.register.Size = new System.Drawing.Size(592, 36);
            this.register.TabIndex = 0;
            this.register.Text = "Register";
            this.register.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.register.UseAccentColor = false;
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "add.png");
            this.imageList3.Images.SetKeyName(1, "analytics.png");
            this.imageList3.Images.SetKeyName(2, "diagrams.png");
            this.imageList3.Images.SetKeyName(3, "edit.png");
            this.imageList3.Images.SetKeyName(4, "employee.png");
            this.imageList3.Images.SetKeyName(5, "inventory.png");
            this.imageList3.Images.SetKeyName(6, "items.png");
            this.imageList3.Images.SetKeyName(7, "login.png");
            this.imageList3.Images.SetKeyName(8, "logout.png");
            this.imageList3.Images.SetKeyName(9, "query.png");
            this.imageList3.Images.SetKeyName(10, "register.png");
            this.imageList3.Images.SetKeyName(11, "remove.png");
            this.imageList3.Images.SetKeyName(12, "sales.png");
            this.imageList3.Images.SetKeyName(13, "search.png");
            this.imageList3.Images.SetKeyName(14, "view.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-join-64.png");
            this.imageList1.Images.SetKeyName(1, "icons8-login.gif");
            this.imageList1.Images.SetKeyName(2, "icons8-sign-up-80.png");
            this.imageList1.Images.SetKeyName(3, "icons8-login-64.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 970);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerHighlightWithAccent = false;
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Auth";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Sizable = false;
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox password_login;
        private MaterialSkin.Controls.MaterialButton login;
        private MaterialSkin.Controls.MaterialTextBox username_login;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox contact;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox password_register;
        private MaterialSkin.Controls.MaterialTextBox username_register;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox email;
        private MaterialSkin.Controls.MaterialButton register;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList2;
    }
}

