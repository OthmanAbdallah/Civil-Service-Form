namespace Visual_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PnlFamily = new System.Windows.Forms.Panel();
            this.Lbl_numberofchildren = new System.Windows.Forms.Label();
            this.Nmc_NumberChildren = new System.Windows.Forms.NumericUpDown();
            this.RadBtn_Unmarried = new System.Windows.Forms.RadioButton();
            this.RadBtn_Married = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Date_Birthday = new System.Windows.Forms.DateTimePicker();
            this.TxtBox_MName = new System.Windows.Forms.TextBox();
            this.TxtBox_FName = new System.Windows.Forms.TextBox();
            this.Pnl_Gender = new System.Windows.Forms.Panel();
            this.RadBtn_Gender_Male = new System.Windows.Forms.RadioButton();
            this.RadBtn_Gender_Female = new System.Windows.Forms.RadioButton();
            this.TxtBox_LName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Pnl_Master = new System.Windows.Forms.Panel();
            this.Cmb_Grade_Master = new System.Windows.Forms.ComboBox();
            this.Cmb_University_Master = new System.Windows.Forms.ComboBox();
            this.Cmb_Field_Master = new System.Windows.Forms.ComboBox();
            this.Pnl_Bach = new System.Windows.Forms.Panel();
            this.Cmb_Grade_Bach = new System.Windows.Forms.ComboBox();
            this.Cmb_University_Bach = new System.Windows.Forms.ComboBox();
            this.Cmb_Field_Bach = new System.Windows.Forms.ComboBox();
            this.Chk_Master = new System.Windows.Forms.CheckBox();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.Pnl_Associate = new System.Windows.Forms.Panel();
            this.Cmb_Grade_Associate = new System.Windows.Forms.ComboBox();
            this.Cmb_University_Associate = new System.Windows.Forms.ComboBox();
            this.Cmb_Field_Associate = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_Experience = new System.Windows.Forms.TextBox();
            this.Chk_Bach = new System.Windows.Forms.CheckBox();
            this.Chk_Associate = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PnlFamily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nmc_NumberChildren)).BeginInit();
            this.Pnl_Gender.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Pnl_Master.SuspendLayout();
            this.Pnl_Bach.SuspendLayout();
            this.Pnl_Associate.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(981, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDatabaseToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exportDatabaseToolStripMenuItem
            // 
            this.exportDatabaseToolStripMenuItem.Name = "exportDatabaseToolStripMenuItem";
            this.exportDatabaseToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.exportDatabaseToolStripMenuItem.Text = "&Export Database";
            this.exportDatabaseToolStripMenuItem.Click += new System.EventHandler(this.exportDatabaseToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(199, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.PnlFamily);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Date_Birthday);
            this.panel1.Controls.Add(this.TxtBox_MName);
            this.panel1.Controls.Add(this.TxtBox_FName);
            this.panel1.Controls.Add(this.Pnl_Gender);
            this.panel1.Controls.Add(this.TxtBox_LName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_Phone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txt_Address);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_Email);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 353);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 258);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Birthday:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "Marital Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Gender:";
            // 
            // PnlFamily
            // 
            this.PnlFamily.Controls.Add(this.Lbl_numberofchildren);
            this.PnlFamily.Controls.Add(this.Nmc_NumberChildren);
            this.PnlFamily.Controls.Add(this.RadBtn_Unmarried);
            this.PnlFamily.Controls.Add(this.RadBtn_Married);
            this.PnlFamily.Location = new System.Drawing.Point(195, 98);
            this.PnlFamily.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlFamily.Name = "PnlFamily";
            this.PnlFamily.Size = new System.Drawing.Size(245, 71);
            this.PnlFamily.TabIndex = 31;
            // 
            // Lbl_numberofchildren
            // 
            this.Lbl_numberofchildren.AutoSize = true;
            this.Lbl_numberofchildren.Location = new System.Drawing.Point(104, 12);
            this.Lbl_numberofchildren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_numberofchildren.Name = "Lbl_numberofchildren";
            this.Lbl_numberofchildren.Size = new System.Drawing.Size(124, 16);
            this.Lbl_numberofchildren.TabIndex = 29;
            this.Lbl_numberofchildren.Text = "Number of Children:";
            this.Lbl_numberofchildren.Visible = false;
            // 
            // Nmc_NumberChildren
            // 
            this.Nmc_NumberChildren.Location = new System.Drawing.Point(107, 37);
            this.Nmc_NumberChildren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nmc_NumberChildren.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Nmc_NumberChildren.Name = "Nmc_NumberChildren";
            this.Nmc_NumberChildren.Size = new System.Drawing.Size(65, 22);
            this.Nmc_NumberChildren.TabIndex = 28;
            this.Nmc_NumberChildren.Visible = false;
            this.Nmc_NumberChildren.ValueChanged += new System.EventHandler(this.Nmc_NumberChildren_ValueChanged);
            // 
            // RadBtn_Unmarried
            // 
            this.RadBtn_Unmarried.AutoSize = true;
            this.RadBtn_Unmarried.Checked = true;
            this.RadBtn_Unmarried.Location = new System.Drawing.Point(8, 10);
            this.RadBtn_Unmarried.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadBtn_Unmarried.Name = "RadBtn_Unmarried";
            this.RadBtn_Unmarried.Size = new System.Drawing.Size(91, 20);
            this.RadBtn_Unmarried.TabIndex = 0;
            this.RadBtn_Unmarried.TabStop = true;
            this.RadBtn_Unmarried.Text = "Unmarried";
            this.RadBtn_Unmarried.UseVisualStyleBackColor = true;
            this.RadBtn_Unmarried.CheckedChanged += new System.EventHandler(this.RadBtn_Unmarried_CheckedChanged_1);
            // 
            // RadBtn_Married
            // 
            this.RadBtn_Married.AutoSize = true;
            this.RadBtn_Married.Location = new System.Drawing.Point(8, 39);
            this.RadBtn_Married.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadBtn_Married.Name = "RadBtn_Married";
            this.RadBtn_Married.Size = new System.Drawing.Size(74, 20);
            this.RadBtn_Married.TabIndex = 1;
            this.RadBtn_Married.Text = "Married";
            this.RadBtn_Married.UseVisualStyleBackColor = true;
            this.RadBtn_Married.CheckedChanged += new System.EventHandler(this.RadBtn_Married_CheckedChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 290);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Email:";
            // 
            // Date_Birthday
            // 
            this.Date_Birthday.CustomFormat = "dd-mm-yyyy";
            this.Date_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Birthday.Location = new System.Drawing.Point(131, 254);
            this.Date_Birthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Date_Birthday.MaxDate = new System.DateTime(2005, 12, 30, 0, 0, 0, 0);
            this.Date_Birthday.Name = "Date_Birthday";
            this.Date_Birthday.Size = new System.Drawing.Size(117, 22);
            this.Date_Birthday.TabIndex = 32;
            this.Date_Birthday.Value = new System.DateTime(2005, 12, 30, 0, 0, 0, 0);
            // 
            // TxtBox_MName
            // 
            this.TxtBox_MName.Location = new System.Drawing.Point(167, 39);
            this.TxtBox_MName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBox_MName.Name = "TxtBox_MName";
            this.TxtBox_MName.Size = new System.Drawing.Size(132, 22);
            this.TxtBox_MName.TabIndex = 34;
            this.TxtBox_MName.TextChanged += new System.EventHandler(this.TxtBox_MName_TextChanged);
            // 
            // TxtBox_FName
            // 
            this.TxtBox_FName.Location = new System.Drawing.Point(25, 39);
            this.TxtBox_FName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBox_FName.Name = "TxtBox_FName";
            this.TxtBox_FName.Size = new System.Drawing.Size(132, 22);
            this.TxtBox_FName.TabIndex = 33;
            this.TxtBox_FName.TextChanged += new System.EventHandler(this.TxtBox_FName_TextChanged);
            // 
            // Pnl_Gender
            // 
            this.Pnl_Gender.Controls.Add(this.RadBtn_Gender_Male);
            this.Pnl_Gender.Controls.Add(this.RadBtn_Gender_Female);
            this.Pnl_Gender.Location = new System.Drawing.Point(25, 95);
            this.Pnl_Gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pnl_Gender.Name = "Pnl_Gender";
            this.Pnl_Gender.Size = new System.Drawing.Size(161, 76);
            this.Pnl_Gender.TabIndex = 30;
            // 
            // RadBtn_Gender_Male
            // 
            this.RadBtn_Gender_Male.AutoSize = true;
            this.RadBtn_Gender_Male.Checked = true;
            this.RadBtn_Gender_Male.Location = new System.Drawing.Point(19, 14);
            this.RadBtn_Gender_Male.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadBtn_Gender_Male.Name = "RadBtn_Gender_Male";
            this.RadBtn_Gender_Male.Size = new System.Drawing.Size(58, 20);
            this.RadBtn_Gender_Male.TabIndex = 0;
            this.RadBtn_Gender_Male.TabStop = true;
            this.RadBtn_Gender_Male.Text = "Male";
            this.RadBtn_Gender_Male.UseVisualStyleBackColor = true;
            // 
            // RadBtn_Gender_Female
            // 
            this.RadBtn_Gender_Female.AutoSize = true;
            this.RadBtn_Gender_Female.Location = new System.Drawing.Point(19, 43);
            this.RadBtn_Gender_Female.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadBtn_Gender_Female.Name = "RadBtn_Gender_Female";
            this.RadBtn_Gender_Female.Size = new System.Drawing.Size(74, 20);
            this.RadBtn_Gender_Female.TabIndex = 1;
            this.RadBtn_Gender_Female.Text = "Female";
            this.RadBtn_Gender_Female.UseVisualStyleBackColor = true;
            // 
            // TxtBox_LName
            // 
            this.TxtBox_LName.Location = new System.Drawing.Point(308, 39);
            this.TxtBox_LName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBox_LName.Name = "TxtBox_LName";
            this.TxtBox_LName.Size = new System.Drawing.Size(132, 22);
            this.TxtBox_LName.TabIndex = 35;
            this.TxtBox_LName.TextChanged += new System.EventHandler(this.TxtBox_LName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "First Name:";
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.Location = new System.Drawing.Point(131, 222);
            this.Txt_Phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Size = new System.Drawing.Size(224, 22);
            this.Txt_Phone.TabIndex = 41;
            this.Txt_Phone.TextChanged += new System.EventHandler(this.Txt_Phone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Middle Name:";
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(131, 287);
            this.Txt_Address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Address.Multiline = true;
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(224, 48);
            this.Txt_Address.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Last Name:";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(131, 188);
            this.Txt_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(224, 22);
            this.Txt_Email.TabIndex = 39;
            this.Txt_Email.TextChanged += new System.EventHandler(this.Txt_Email_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 170);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 422);
            this.panel2.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Personal Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(508, 170);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 422);
            this.panel3.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Experience and Education";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.Pnl_Master);
            this.panel4.Controls.Add(this.Pnl_Bach);
            this.panel4.Controls.Add(this.Chk_Master);
            this.panel4.Controls.Add(this.BTN_Submit);
            this.panel4.Controls.Add(this.Pnl_Associate);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.Txt_Experience);
            this.panel4.Controls.Add(this.Chk_Bach);
            this.panel4.Controls.Add(this.Chk_Associate);
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 353);
            this.panel4.TabIndex = 27;
            // 
            // Pnl_Master
            // 
            this.Pnl_Master.Controls.Add(this.Cmb_Grade_Master);
            this.Pnl_Master.Controls.Add(this.Cmb_University_Master);
            this.Pnl_Master.Controls.Add(this.Cmb_Field_Master);
            this.Pnl_Master.Location = new System.Drawing.Point(297, 186);
            this.Pnl_Master.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pnl_Master.Name = "Pnl_Master";
            this.Pnl_Master.Size = new System.Drawing.Size(132, 123);
            this.Pnl_Master.TabIndex = 44;
            this.Pnl_Master.Visible = false;
            // 
            // Cmb_Grade_Master
            // 
            this.Cmb_Grade_Master.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cmb_Grade_Master.FormattingEnabled = true;
            this.Cmb_Grade_Master.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Pass",
            "Very Good"});
            this.Cmb_Grade_Master.Location = new System.Drawing.Point(4, 82);
            this.Cmb_Grade_Master.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_Grade_Master.Name = "Cmb_Grade_Master";
            this.Cmb_Grade_Master.Size = new System.Drawing.Size(119, 24);
            this.Cmb_Grade_Master.TabIndex = 39;
            this.Cmb_Grade_Master.Text = "Grade";
            // 
            // Cmb_University_Master
            // 
            this.Cmb_University_Master.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cmb_University_Master.FormattingEnabled = true;
            this.Cmb_University_Master.Items.AddRange(new object[] {
            "Al-Ahliyya Amman",
            "Al-Isra University",
            "Al-Zaytoonah ",
            "Applied Science",
            "German-Jordanian ",
            "Hussien Technical",
            "Luminus ",
            "Middle East ",
            "Petra ",
            "Philadelphia ",
            "University of Jordan"});
            this.Cmb_University_Master.Location = new System.Drawing.Point(4, 49);
            this.Cmb_University_Master.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_University_Master.Name = "Cmb_University_Master";
            this.Cmb_University_Master.Size = new System.Drawing.Size(119, 24);
            this.Cmb_University_Master.Sorted = true;
            this.Cmb_University_Master.TabIndex = 3;
            this.Cmb_University_Master.Text = "None";
            // 
            // Cmb_Field_Master
            // 
            this.Cmb_Field_Master.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cmb_Field_Master.FormattingEnabled = true;
            this.Cmb_Field_Master.Items.AddRange(new object[] {
            "Accounting\t",
            "Biological Sciences\t",
            "Business Economics\t",
            "Business Management\t",
            "Chemistry\t",
            "Finance\t",
            "Geology\t",
            "Management Information Systems",
            "Marketing\t",
            "Mathematics\t",
            "Medical Analysis",
            "Physics\t",
            "Public Administration\t"});
            this.Cmb_Field_Master.Location = new System.Drawing.Point(4, 16);
            this.Cmb_Field_Master.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_Field_Master.Name = "Cmb_Field_Master";
            this.Cmb_Field_Master.Size = new System.Drawing.Size(119, 24);
            this.Cmb_Field_Master.Sorted = true;
            this.Cmb_Field_Master.TabIndex = 36;
            this.Cmb_Field_Master.Text = "Major";
            // 
            // Pnl_Bach
            // 
            this.Pnl_Bach.Controls.Add(this.Cmb_Grade_Bach);
            this.Pnl_Bach.Controls.Add(this.Cmb_University_Bach);
            this.Pnl_Bach.Controls.Add(this.Cmb_Field_Bach);
            this.Pnl_Bach.Location = new System.Drawing.Point(161, 186);
            this.Pnl_Bach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pnl_Bach.Name = "Pnl_Bach";
            this.Pnl_Bach.Size = new System.Drawing.Size(132, 123);
            this.Pnl_Bach.TabIndex = 50;
            this.Pnl_Bach.Visible = false;
            // 
            // Cmb_Grade_Bach
            // 
            this.Cmb_Grade_Bach.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cmb_Grade_Bach.FormattingEnabled = true;
            this.Cmb_Grade_Bach.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Pass",
            "Very Good"});
            this.Cmb_Grade_Bach.Location = new System.Drawing.Point(4, 82);
            this.Cmb_Grade_Bach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_Grade_Bach.Name = "Cmb_Grade_Bach";
            this.Cmb_Grade_Bach.Size = new System.Drawing.Size(119, 24);
            this.Cmb_Grade_Bach.TabIndex = 39;
            this.Cmb_Grade_Bach.Text = "Grade";
            // 
            // Cmb_University_Bach
            // 
            this.Cmb_University_Bach.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cmb_University_Bach.FormattingEnabled = true;
            this.Cmb_University_Bach.Items.AddRange(new object[] {
            "Al-Ahliyya Amman",
            "Al-Isra University",
            "Al-Zaytoonah ",
            "Applied Science",
            "German-Jordanian ",
            "Hussien Technical",
            "Luminus ",
            "Middle East ",
            "Petra ",
            "Philadelphia ",
            "University of Jordan"});
            this.Cmb_University_Bach.Location = new System.Drawing.Point(4, 49);
            this.Cmb_University_Bach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_University_Bach.Name = "Cmb_University_Bach";
            this.Cmb_University_Bach.Size = new System.Drawing.Size(119, 24);
            this.Cmb_University_Bach.Sorted = true;
            this.Cmb_University_Bach.TabIndex = 3;
            this.Cmb_University_Bach.Text = "None";
            // 
            // Cmb_Field_Bach
            // 
            this.Cmb_Field_Bach.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cmb_Field_Bach.FormattingEnabled = true;
            this.Cmb_Field_Bach.Items.AddRange(new object[] {
            "Accounting\t",
            "Biological Sciences\t",
            "Business Economics\t",
            "Business Management\t",
            "Chemistry\t",
            "Finance\t",
            "Geology\t",
            "Management Information Systems",
            "Marketing\t",
            "Mathematics\t",
            "Medical Analysis",
            "Physics\t",
            "Public Administration\t"});
            this.Cmb_Field_Bach.Location = new System.Drawing.Point(4, 16);
            this.Cmb_Field_Bach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_Field_Bach.Name = "Cmb_Field_Bach";
            this.Cmb_Field_Bach.Size = new System.Drawing.Size(119, 24);
            this.Cmb_Field_Bach.Sorted = true;
            this.Cmb_Field_Bach.TabIndex = 36;
            this.Cmb_Field_Bach.Text = "Major";
            // 
            // Chk_Master
            // 
            this.Chk_Master.AutoSize = true;
            this.Chk_Master.Location = new System.Drawing.Point(297, 162);
            this.Chk_Master.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Chk_Master.Name = "Chk_Master";
            this.Chk_Master.Size = new System.Drawing.Size(70, 20);
            this.Chk_Master.TabIndex = 33;
            this.Chk_Master.Text = "Master";
            this.Chk_Master.UseVisualStyleBackColor = true;
            this.Chk_Master.CheckedChanged += new System.EventHandler(this.Chk_Master_CheckedChanged);
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Location = new System.Drawing.Point(24, 321);
            this.BTN_Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(233, 28);
            this.BTN_Submit.TabIndex = 26;
            this.BTN_Submit.Text = "Submit Application";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // Pnl_Associate
            // 
            this.Pnl_Associate.Controls.Add(this.Cmb_Grade_Associate);
            this.Pnl_Associate.Controls.Add(this.Cmb_University_Associate);
            this.Pnl_Associate.Controls.Add(this.Cmb_Field_Associate);
            this.Pnl_Associate.Location = new System.Drawing.Point(24, 186);
            this.Pnl_Associate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pnl_Associate.Name = "Pnl_Associate";
            this.Pnl_Associate.Size = new System.Drawing.Size(132, 123);
            this.Pnl_Associate.TabIndex = 49;
            this.Pnl_Associate.Visible = false;
            // 
            // Cmb_Grade_Associate
            // 
            this.Cmb_Grade_Associate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cmb_Grade_Associate.FormattingEnabled = true;
            this.Cmb_Grade_Associate.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Pass",
            "Very Good"});
            this.Cmb_Grade_Associate.Location = new System.Drawing.Point(4, 82);
            this.Cmb_Grade_Associate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_Grade_Associate.Name = "Cmb_Grade_Associate";
            this.Cmb_Grade_Associate.Size = new System.Drawing.Size(119, 24);
            this.Cmb_Grade_Associate.TabIndex = 39;
            this.Cmb_Grade_Associate.Text = "Grade";
            // 
            // Cmb_University_Associate
            // 
            this.Cmb_University_Associate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cmb_University_Associate.FormattingEnabled = true;
            this.Cmb_University_Associate.Items.AddRange(new object[] {
            "Al-Ahliyya Amman",
            "Al-Isra University",
            "Al-Zaytoonah ",
            "Applied Science",
            "German-Jordanian ",
            "Hussien Technical",
            "Luminus ",
            "Middle East ",
            "Petra ",
            "Philadelphia ",
            "University of Jordan"});
            this.Cmb_University_Associate.Location = new System.Drawing.Point(4, 49);
            this.Cmb_University_Associate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_University_Associate.Name = "Cmb_University_Associate";
            this.Cmb_University_Associate.Size = new System.Drawing.Size(119, 24);
            this.Cmb_University_Associate.Sorted = true;
            this.Cmb_University_Associate.TabIndex = 3;
            this.Cmb_University_Associate.Text = "None";
            this.Cmb_University_Associate.SelectedIndexChanged += new System.EventHandler(this.Cmb_University_Associate_SelectedIndexChanged);
            // 
            // Cmb_Field_Associate
            // 
            this.Cmb_Field_Associate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cmb_Field_Associate.FormattingEnabled = true;
            this.Cmb_Field_Associate.Items.AddRange(new object[] {
            "Accounting\t",
            "Biological Sciences\t",
            "Business Economics\t",
            "Business Management\t",
            "Chemistry\t",
            "Finance\t",
            "Geology\t",
            "Management Information Systems",
            "Marketing\t",
            "Mathematics\t",
            "Medical Analysis",
            "Physics\t",
            "Public Administration\t"});
            this.Cmb_Field_Associate.Location = new System.Drawing.Point(4, 16);
            this.Cmb_Field_Associate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_Field_Associate.Name = "Cmb_Field_Associate";
            this.Cmb_Field_Associate.Size = new System.Drawing.Size(119, 24);
            this.Cmb_Field_Associate.Sorted = true;
            this.Cmb_Field_Associate.TabIndex = 36;
            this.Cmb_Field_Associate.Text = "Major";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 135);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 16);
            this.label14.TabIndex = 48;
            this.label14.Text = "College Degrees:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 47;
            this.label13.Text = "Experience:";
            // 
            // Txt_Experience
            // 
            this.Txt_Experience.Location = new System.Drawing.Point(24, 39);
            this.Txt_Experience.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Experience.Multiline = true;
            this.Txt_Experience.Name = "Txt_Experience";
            this.Txt_Experience.Size = new System.Drawing.Size(327, 77);
            this.Txt_Experience.TabIndex = 46;
            // 
            // Chk_Bach
            // 
            this.Chk_Bach.AutoSize = true;
            this.Chk_Bach.Location = new System.Drawing.Point(161, 162);
            this.Chk_Bach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Chk_Bach.Name = "Chk_Bach";
            this.Chk_Bach.Size = new System.Drawing.Size(83, 20);
            this.Chk_Bach.TabIndex = 45;
            this.Chk_Bach.Text = "Bachelor";
            this.Chk_Bach.UseVisualStyleBackColor = true;
            this.Chk_Bach.CheckedChanged += new System.EventHandler(this.Chk_Bach_CheckedChanged_1);
            // 
            // Chk_Associate
            // 
            this.Chk_Associate.AutoSize = true;
            this.Chk_Associate.Location = new System.Drawing.Point(24, 162);
            this.Chk_Associate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Chk_Associate.Name = "Chk_Associate";
            this.Chk_Associate.Size = new System.Drawing.Size(89, 20);
            this.Chk_Associate.TabIndex = 44;
            this.Chk_Associate.Text = "Associate";
            this.Chk_Associate.UseVisualStyleBackColor = true;
            this.Chk_Associate.CheckedChanged += new System.EventHandler(this.Chk_Associate_CheckedChanged_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(0, 31);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(984, 124);
            this.panel5.TabIndex = 31;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Visual_Project.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(37, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Visual_Project.Properties.Resources.HK1;
            this.pictureBox1.Location = new System.Drawing.Point(848, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 622);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Application Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlFamily.ResumeLayout(false);
            this.PnlFamily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nmc_NumberChildren)).EndInit();
            this.Pnl_Gender.ResumeLayout(false);
            this.Pnl_Gender.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Pnl_Master.ResumeLayout(false);
            this.Pnl_Bach.ResumeLayout(false);
            this.Pnl_Associate.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel PnlFamily;
        private System.Windows.Forms.Label Lbl_numberofchildren;
        private System.Windows.Forms.NumericUpDown Nmc_NumberChildren;
        private System.Windows.Forms.RadioButton RadBtn_Unmarried;
        private System.Windows.Forms.RadioButton RadBtn_Married;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Date_Birthday;
        private System.Windows.Forms.TextBox TxtBox_MName;
        private System.Windows.Forms.TextBox TxtBox_FName;
        private System.Windows.Forms.Panel Pnl_Gender;
        private System.Windows.Forms.RadioButton RadBtn_Gender_Male;
        private System.Windows.Forms.RadioButton RadBtn_Gender_Female;
        private System.Windows.Forms.TextBox TxtBox_LName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel Pnl_Bach;
        private System.Windows.Forms.ComboBox Cmb_Grade_Bach;
        private System.Windows.Forms.ComboBox Cmb_University_Bach;
        private System.Windows.Forms.ComboBox Cmb_Field_Bach;
        private System.Windows.Forms.Panel Pnl_Associate;
        private System.Windows.Forms.ComboBox Cmb_Grade_Associate;
        private System.Windows.Forms.ComboBox Cmb_University_Associate;
        private System.Windows.Forms.ComboBox Cmb_Field_Associate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_Experience;
        private System.Windows.Forms.CheckBox Chk_Bach;
        private System.Windows.Forms.CheckBox Chk_Associate;
        private System.Windows.Forms.CheckBox Chk_Master;
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.Panel Pnl_Master;
        private System.Windows.Forms.ComboBox Cmb_Field_Master;
        private System.Windows.Forms.ComboBox Cmb_University_Master;
        private System.Windows.Forms.ComboBox Cmb_Grade_Master;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}