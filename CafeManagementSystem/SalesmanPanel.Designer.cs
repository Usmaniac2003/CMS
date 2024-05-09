namespace CafeManagementSystem
    {
    partial class SalesmanPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesmanPanel));
            this.menuItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafe1DataSet8 = new CafeManagementSystem.cafe1DataSet8();
            this.SalesIcons = new System.Windows.Forms.ImageList(this.components);
            this.cafe1DataSet = new CafeManagementSystem.cafe1DataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new CafeManagementSystem.cafe1DataSetTableAdapters.EmployeesTableAdapter();
            this.menuItemsTableAdapter = new CafeManagementSystem.cafe1DataSet8TableAdapters.MenuItemsTableAdapter();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton16 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Salespanel = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.materialCard9.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuItemsBindingSource
            // 
            this.menuItemsBindingSource.DataMember = "MenuItems";
            this.menuItemsBindingSource.DataSource = this.cafe1DataSet8;
            // 
            // cafe1DataSet8
            // 
            this.cafe1DataSet8.DataSetName = "cafe1DataSet8";
            this.cafe1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesIcons
            // 
            this.SalesIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SalesIcons.ImageStream")));
            this.SalesIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.SalesIcons.Images.SetKeyName(0, "icons8-analysis-50.png");
            this.SalesIcons.Images.SetKeyName(1, "icons8-billing-80.png");
            this.SalesIcons.Images.SetKeyName(2, "icons8-point-of-sale-68.png");
            this.SalesIcons.Images.SetKeyName(3, "icons8-restaurant-table-50.png");
            this.SalesIcons.Images.SetKeyName(4, "icons8-bell-curve-48.png");
            // 
            // cafe1DataSet
            // 
            this.cafe1DataSet.DataSetName = "cafe1DataSet";
            this.cafe1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.cafe1DataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // menuItemsTableAdapter
            // 
            this.menuItemsTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.materialButton7);
            this.tabPage7.Controls.Add(this.dataGridView6);
            this.tabPage7.ImageKey = "mysales.png";
            this.tabPage7.Location = new System.Drawing.Point(4, 37);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1319, 862);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "MySales";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton7.Depth = 0;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(15, 503);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton7.Size = new System.Drawing.Size(86, 36);
            this.materialButton7.TabIndex = 2;
            this.materialButton7.Text = "Analyze";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(15, 20);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(789, 465);
            this.dataGridView6.TabIndex = 1;
            this.dataGridView6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellContentClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.materialCard9);
            this.tabPage6.ImageKey = "logout.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 37);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1319, 862);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "logout";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // materialCard9
            // 
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Controls.Add(this.materialTextBox6);
            this.materialCard9.Controls.Add(this.materialTextBox5);
            this.materialCard9.Controls.Add(this.materialLabel27);
            this.materialCard9.Controls.Add(this.materialLabel28);
            this.materialCard9.Controls.Add(this.materialButton16);
            this.materialCard9.Depth = 0;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(294, 104);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(539, 322);
            this.materialCard9.TabIndex = 6;
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.AnimateReadOnly = false;
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox6.LeadingIcon = null;
            this.materialTextBox6.Location = new System.Drawing.Point(77, 132);
            this.materialTextBox6.MaxLength = 50;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.ReadOnly = true;
            this.materialTextBox6.Size = new System.Drawing.Size(372, 50);
            this.materialTextBox6.TabIndex = 4;
            this.materialTextBox6.Text = "";
            this.materialTextBox6.TrailingIcon = null;
            // 
            // materialTextBox5
            // 
            this.materialTextBox5.AnimateReadOnly = false;
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox5.LeadingIcon = null;
            this.materialTextBox5.Location = new System.Drawing.Point(77, 49);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.ReadOnly = true;
            this.materialTextBox5.Size = new System.Drawing.Size(372, 50);
            this.materialTextBox5.TabIndex = 3;
            this.materialTextBox5.Text = "";
            this.materialTextBox5.TrailingIcon = null;
            // 
            // materialLabel27
            // 
            this.materialLabel27.AutoSize = true;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.Enabled = false;
            this.materialLabel27.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel27.Location = new System.Drawing.Point(15, 65);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Size = new System.Drawing.Size(43, 19);
            this.materialLabel27.TabIndex = 0;
            this.materialLabel27.Text = "Name";
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel28.Location = new System.Drawing.Point(17, 153);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(41, 19);
            this.materialLabel28.TabIndex = 1;
            this.materialLabel28.Text = "Email";
            // 
            // materialButton16
            // 
            this.materialButton16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton16.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton16.Depth = 0;
            this.materialButton16.HighEmphasis = true;
            this.materialButton16.Icon = null;
            this.materialButton16.Location = new System.Drawing.Point(226, 250);
            this.materialButton16.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton16.Name = "materialButton16";
            this.materialButton16.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton16.Size = new System.Drawing.Size(78, 36);
            this.materialButton16.TabIndex = 2;
            this.materialButton16.Text = "Logout";
            this.materialButton16.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton16.UseAccentColor = false;
            this.materialButton16.UseVisualStyleBackColor = true;
            this.materialButton16.Click += new System.EventHandler(this.materialButton16_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialButton5);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.ImageKey = "pending.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 37);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1319, 862);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Pending Orders";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(24, 483);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(190, 36);
            this.materialButton5.TabIndex = 1;
            this.materialButton5.Text = "Show Pending Orders";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click_1);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(24, 33);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(930, 424);
            this.dataGridView5.TabIndex = 0;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialCard3);
            this.tabPage2.ImageKey = "billing.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1319, 862);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Billing ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialMultiLineTextBox1);
            this.materialCard3.Controls.Add(this.materialButton6);
            this.materialCard3.Controls.Add(this.materialTextBox4);
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(58, 31);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(1186, 744);
            this.materialCard3.TabIndex = 1;
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(16, 176);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(619, 448);
            this.materialMultiLineTextBox1.TabIndex = 3;
            this.materialMultiLineTextBox1.Text = "";
            this.materialMultiLineTextBox1.TextChanged += new System.EventHandler(this.materialMultiLineTextBox1_TextChanged);
            // 
            // materialButton6
            // 
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(16, 119);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(82, 36);
            this.materialButton6.TabIndex = 2;
            this.materialButton6.Text = "Get Bill";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            this.materialButton6.Click += new System.EventHandler(this.materialButton6_Click);
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.AnimateReadOnly = false;
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox4.LeadingIcon = null;
            this.materialTextBox4.Location = new System.Drawing.Point(18, 60);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(323, 50);
            this.materialTextBox4.TabIndex = 1;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.TrailingIcon = null;
            this.materialTextBox4.TextChanged += new System.EventHandler(this.materialTextBox4_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(18, 27);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(80, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "customerId";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.Salespanel;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1327, 903);
            this.materialTabControl1.TabIndex = 2;
            // 
            // Salespanel
            // 
            this.Salespanel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Salespanel.ImageStream")));
            this.Salespanel.TransparentColor = System.Drawing.Color.Transparent;
            this.Salespanel.Images.SetKeyName(0, "add.png");
            this.Salespanel.Images.SetKeyName(1, "analytics.png");
            this.Salespanel.Images.SetKeyName(2, "billing.png");
            this.Salespanel.Images.SetKeyName(3, "diagrams.png");
            this.Salespanel.Images.SetKeyName(4, "edit.png");
            this.Salespanel.Images.SetKeyName(5, "employee.png");
            this.Salespanel.Images.SetKeyName(6, "inventory.png");
            this.Salespanel.Images.SetKeyName(7, "items.png");
            this.Salespanel.Images.SetKeyName(8, "login.png");
            this.Salespanel.Images.SetKeyName(9, "logout.png");
            this.Salespanel.Images.SetKeyName(10, "mysales.png");
            this.Salespanel.Images.SetKeyName(11, "orderfood.png");
            this.Salespanel.Images.SetKeyName(12, "orderhistory.png");
            this.Salespanel.Images.SetKeyName(13, "pending.png");
            this.Salespanel.Images.SetKeyName(14, "promotion.png");
            this.Salespanel.Images.SetKeyName(15, "query.png");
            this.Salespanel.Images.SetKeyName(16, "register.png");
            this.Salespanel.Images.SetKeyName(17, "remove.png");
            this.Salespanel.Images.SetKeyName(18, "reserve table.png");
            this.Salespanel.Images.SetKeyName(19, "sales.png");
            this.Salespanel.Images.SetKeyName(20, "search.png");
            this.Salespanel.Images.SetKeyName(21, "view.png");
            // 
            // SalesmanPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 970);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesmanPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesmanPanel";
            this.Load += new System.EventHandler(this.SalesmanPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.materialCard9.ResumeLayout(false);
            this.materialCard9.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private cafe1DataSet cafe1DataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private cafe1DataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.ImageList SalesIcons;
        private cafe1DataSet8 cafe1DataSet8;
        private System.Windows.Forms.BindingSource menuItemsBindingSource;
        private cafe1DataSet8TableAdapters.MenuItemsTableAdapter menuItemsTableAdapter;
        private System.Windows.Forms.TabPage tabPage7;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel27;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private MaterialSkin.Controls.MaterialButton materialButton16;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.ImageList Salespanel;
    }
    }