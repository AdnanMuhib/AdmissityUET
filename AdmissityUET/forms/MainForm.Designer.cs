namespace AdmissityUET.forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.btnExitWindow = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelSideBar = new System.Windows.Forms.Panel();
            this.btnMeritList = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnNewApplication = new System.Windows.Forms.Button();
            this.personalInfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMoveToEduPanel = new System.Windows.Forms.Button();
            this.educationalInfoPanel = new System.Windows.Forms.Panel();
            this.btnMoveToPrefListPanel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBackToPersonalInfoPanel = new System.Windows.Forms.Button();
            this.numMatricMarks = new System.Windows.Forms.NumericUpDown();
            this.numFSCMarks = new System.Windows.Forms.NumericUpDown();
            this.numEcatMarks = new System.Windows.Forms.NumericUpDown();
            this.numGatMarks = new System.Windows.Forms.NumericUpDown();
            this.panelPreferenceList = new System.Windows.Forms.Panel();
            this.btnBackToEducationalInfo = new System.Windows.Forms.Button();
            this.btnSubmitApplication = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dropDownDepartment = new System.Windows.Forms.ComboBox();
            this.btnAddPreference = new System.Windows.Forms.Button();
            this.dataGridPreferences = new System.Windows.Forms.DataGridView();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitWindow)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelSideBar.SuspendLayout();
            this.personalInfoPanel.SuspendLayout();
            this.educationalInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatricMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFSCMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEcatMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGatMarks)).BeginInit();
            this.panelPreferenceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreferences)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.Purple;
            this.PanelHeader.Controls.Add(this.btnExitWindow);
            this.PanelHeader.Controls.Add(this.label3);
            this.PanelHeader.Controls.Add(this.panel3);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1027, 69);
            this.PanelHeader.TabIndex = 0;
            // 
            // btnExitWindow
            // 
            this.btnExitWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnExitWindow.Image")));
            this.btnExitWindow.Location = new System.Drawing.Point(920, 0);
            this.btnExitWindow.Name = "btnExitWindow";
            this.btnExitWindow.Size = new System.Drawing.Size(107, 69);
            this.btnExitWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExitWindow.TabIndex = 9;
            this.btnExitWindow.TabStop = false;
            this.btnExitWindow.Click += new System.EventHandler(this.btnExitWindow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(292, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "UET ADMISSION CONTROL SYSTEM";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 69);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelSideBar
            // 
            this.PanelSideBar.BackColor = System.Drawing.Color.Purple;
            this.PanelSideBar.Controls.Add(this.btnMeritList);
            this.PanelSideBar.Controls.Add(this.btnDepartments);
            this.PanelSideBar.Controls.Add(this.btnNewApplication);
            this.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PanelSideBar.Location = new System.Drawing.Point(0, 69);
            this.PanelSideBar.Name = "PanelSideBar";
            this.PanelSideBar.Size = new System.Drawing.Size(146, 530);
            this.PanelSideBar.TabIndex = 1;
            // 
            // btnMeritList
            // 
            this.btnMeritList.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnMeritList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMeritList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMeritList.FlatAppearance.BorderSize = 2;
            this.btnMeritList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMeritList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnMeritList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeritList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMeritList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMeritList.Location = new System.Drawing.Point(0, 96);
            this.btnMeritList.Name = "btnMeritList";
            this.btnMeritList.Size = new System.Drawing.Size(146, 48);
            this.btnMeritList.TabIndex = 2;
            this.btnMeritList.Text = "Merit List";
            this.btnMeritList.UseVisualStyleBackColor = false;
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnDepartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartments.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDepartments.FlatAppearance.BorderSize = 2;
            this.btnDepartments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDepartments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDepartments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDepartments.Location = new System.Drawing.Point(0, 48);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(146, 48);
            this.btnDepartments.TabIndex = 1;
            this.btnDepartments.Text = "Departments";
            this.btnDepartments.UseVisualStyleBackColor = false;
            // 
            // btnNewApplication
            // 
            this.btnNewApplication.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnNewApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewApplication.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewApplication.FlatAppearance.BorderSize = 2;
            this.btnNewApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNewApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnNewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNewApplication.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewApplication.Location = new System.Drawing.Point(0, 0);
            this.btnNewApplication.Name = "btnNewApplication";
            this.btnNewApplication.Size = new System.Drawing.Size(146, 48);
            this.btnNewApplication.TabIndex = 0;
            this.btnNewApplication.Text = "New Application";
            this.btnNewApplication.UseVisualStyleBackColor = false;
            this.btnNewApplication.Click += new System.EventHandler(this.btnNewApplication_Click);
            // 
            // personalInfoPanel
            // 
            this.personalInfoPanel.Controls.Add(this.btnMoveToEduPanel);
            this.personalInfoPanel.Controls.Add(this.txtIDCard);
            this.personalInfoPanel.Controls.Add(this.label8);
            this.personalInfoPanel.Controls.Add(this.txtPhoneNumber);
            this.personalInfoPanel.Controls.Add(this.label7);
            this.personalInfoPanel.Controls.Add(this.txtEmail);
            this.personalInfoPanel.Controls.Add(this.label6);
            this.personalInfoPanel.Controls.Add(this.txtFatherName);
            this.personalInfoPanel.Controls.Add(this.label5);
            this.personalInfoPanel.Controls.Add(this.txtName);
            this.personalInfoPanel.Controls.Add(this.label4);
            this.personalInfoPanel.Controls.Add(this.label1);
            this.personalInfoPanel.Location = new System.Drawing.Point(152, 75);
            this.personalInfoPanel.Name = "personalInfoPanel";
            this.personalInfoPanel.Size = new System.Drawing.Size(569, 269);
            this.personalInfoPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.Location = new System.Drawing.Point(29, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Student Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtName.Location = new System.Drawing.Point(167, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 24);
            this.txtName.TabIndex = 2;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtFatherName.Location = new System.Drawing.Point(167, 70);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(400, 24);
            this.txtFatherName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F);
            this.label5.Location = new System.Drawing.Point(29, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Father Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtEmail.Location = new System.Drawing.Point(167, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 24);
            this.txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F);
            this.label6.Location = new System.Drawing.Point(29, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(167, 131);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(400, 24);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F);
            this.label7.Location = new System.Drawing.Point(29, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone Number";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtIDCard.Location = new System.Drawing.Point(167, 162);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(400, 24);
            this.txtIDCard.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F);
            this.label8.Location = new System.Drawing.Point(29, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID Card/B-Form";
            // 
            // btnMoveToEduPanel
            // 
            this.btnMoveToEduPanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMoveToEduPanel.FlatAppearance.BorderSize = 2;
            this.btnMoveToEduPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveToEduPanel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToEduPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveToEduPanel.Image")));
            this.btnMoveToEduPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoveToEduPanel.Location = new System.Drawing.Point(444, 208);
            this.btnMoveToEduPanel.Name = "btnMoveToEduPanel";
            this.btnMoveToEduPanel.Size = new System.Drawing.Size(122, 45);
            this.btnMoveToEduPanel.TabIndex = 11;
            this.btnMoveToEduPanel.Text = "NEXT";
            this.btnMoveToEduPanel.UseVisualStyleBackColor = true;
            this.btnMoveToEduPanel.Click += new System.EventHandler(this.btnMoveToEduPanel_Click);
            // 
            // educationalInfoPanel
            // 
            this.educationalInfoPanel.Controls.Add(this.numGatMarks);
            this.educationalInfoPanel.Controls.Add(this.numEcatMarks);
            this.educationalInfoPanel.Controls.Add(this.numFSCMarks);
            this.educationalInfoPanel.Controls.Add(this.numMatricMarks);
            this.educationalInfoPanel.Controls.Add(this.btnBackToPersonalInfoPanel);
            this.educationalInfoPanel.Controls.Add(this.btnMoveToPrefListPanel);
            this.educationalInfoPanel.Controls.Add(this.label10);
            this.educationalInfoPanel.Controls.Add(this.label11);
            this.educationalInfoPanel.Controls.Add(this.label12);
            this.educationalInfoPanel.Controls.Add(this.label13);
            this.educationalInfoPanel.Controls.Add(this.label14);
            this.educationalInfoPanel.Location = new System.Drawing.Point(152, 75);
            this.educationalInfoPanel.Name = "educationalInfoPanel";
            this.educationalInfoPanel.Size = new System.Drawing.Size(569, 269);
            this.educationalInfoPanel.TabIndex = 12;
            // 
            // btnMoveToPrefListPanel
            // 
            this.btnMoveToPrefListPanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMoveToPrefListPanel.FlatAppearance.BorderSize = 2;
            this.btnMoveToPrefListPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveToPrefListPanel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToPrefListPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveToPrefListPanel.Image")));
            this.btnMoveToPrefListPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoveToPrefListPanel.Location = new System.Drawing.Point(440, 208);
            this.btnMoveToPrefListPanel.Name = "btnMoveToPrefListPanel";
            this.btnMoveToPrefListPanel.Size = new System.Drawing.Size(122, 45);
            this.btnMoveToPrefListPanel.TabIndex = 11;
            this.btnMoveToPrefListPanel.Text = "NEXT";
            this.btnMoveToPrefListPanel.UseVisualStyleBackColor = true;
            this.btnMoveToPrefListPanel.Click += new System.EventHandler(this.btnMoveToPrefListPanel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10F);
            this.label10.Location = new System.Drawing.Point(29, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "GAT (optional)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10F);
            this.label11.Location = new System.Drawing.Point(29, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ecat Marks*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 10F);
            this.label12.Location = new System.Drawing.Point(29, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "FSC Marks*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 10F);
            this.label13.Location = new System.Drawing.Point(29, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Matric Marks*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(241, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Educational Information";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBackToPersonalInfoPanel
            // 
            this.btnBackToPersonalInfoPanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBackToPersonalInfoPanel.FlatAppearance.BorderSize = 2;
            this.btnBackToPersonalInfoPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToPersonalInfoPanel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToPersonalInfoPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToPersonalInfoPanel.Image")));
            this.btnBackToPersonalInfoPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToPersonalInfoPanel.Location = new System.Drawing.Point(291, 208);
            this.btnBackToPersonalInfoPanel.Name = "btnBackToPersonalInfoPanel";
            this.btnBackToPersonalInfoPanel.Size = new System.Drawing.Size(122, 45);
            this.btnBackToPersonalInfoPanel.TabIndex = 12;
            this.btnBackToPersonalInfoPanel.Text = "BACK";
            this.btnBackToPersonalInfoPanel.UseVisualStyleBackColor = true;
            this.btnBackToPersonalInfoPanel.Click += new System.EventHandler(this.button2_Click);
            // 
            // numMatricMarks
            // 
            this.numMatricMarks.Font = new System.Drawing.Font("Verdana", 12F);
            this.numMatricMarks.Location = new System.Drawing.Point(379, 38);
            this.numMatricMarks.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.numMatricMarks.Name = "numMatricMarks";
            this.numMatricMarks.Size = new System.Drawing.Size(120, 27);
            this.numMatricMarks.TabIndex = 13;
            // 
            // numFSCMarks
            // 
            this.numFSCMarks.Font = new System.Drawing.Font("Verdana", 12F);
            this.numFSCMarks.Location = new System.Drawing.Point(379, 69);
            this.numFSCMarks.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.numFSCMarks.Name = "numFSCMarks";
            this.numFSCMarks.Size = new System.Drawing.Size(120, 27);
            this.numFSCMarks.TabIndex = 14;
            // 
            // numEcatMarks
            // 
            this.numEcatMarks.Font = new System.Drawing.Font("Verdana", 12F);
            this.numEcatMarks.Location = new System.Drawing.Point(379, 100);
            this.numEcatMarks.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numEcatMarks.Name = "numEcatMarks";
            this.numEcatMarks.Size = new System.Drawing.Size(120, 27);
            this.numEcatMarks.TabIndex = 15;
            // 
            // numGatMarks
            // 
            this.numGatMarks.Font = new System.Drawing.Font("Verdana", 12F);
            this.numGatMarks.Location = new System.Drawing.Point(379, 130);
            this.numGatMarks.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.numGatMarks.Name = "numGatMarks";
            this.numGatMarks.Size = new System.Drawing.Size(120, 27);
            this.numGatMarks.TabIndex = 16;
            // 
            // panelPreferenceList
            // 
            this.panelPreferenceList.Controls.Add(this.dataGridPreferences);
            this.panelPreferenceList.Controls.Add(this.btnAddPreference);
            this.panelPreferenceList.Controls.Add(this.dropDownDepartment);
            this.panelPreferenceList.Controls.Add(this.label2);
            this.panelPreferenceList.Controls.Add(this.btnBackToEducationalInfo);
            this.panelPreferenceList.Controls.Add(this.btnSubmitApplication);
            this.panelPreferenceList.Controls.Add(this.label18);
            this.panelPreferenceList.Location = new System.Drawing.Point(152, 75);
            this.panelPreferenceList.Name = "panelPreferenceList";
            this.panelPreferenceList.Size = new System.Drawing.Size(569, 269);
            this.panelPreferenceList.TabIndex = 17;
            // 
            // btnBackToEducationalInfo
            // 
            this.btnBackToEducationalInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBackToEducationalInfo.FlatAppearance.BorderSize = 2;
            this.btnBackToEducationalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToEducationalInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToEducationalInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToEducationalInfo.Image")));
            this.btnBackToEducationalInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToEducationalInfo.Location = new System.Drawing.Point(291, 208);
            this.btnBackToEducationalInfo.Name = "btnBackToEducationalInfo";
            this.btnBackToEducationalInfo.Size = new System.Drawing.Size(122, 45);
            this.btnBackToEducationalInfo.TabIndex = 12;
            this.btnBackToEducationalInfo.Text = "BACK";
            this.btnBackToEducationalInfo.UseVisualStyleBackColor = true;
            this.btnBackToEducationalInfo.Click += new System.EventHandler(this.btnBackToEducationalInfo_Click);
            // 
            // btnSubmitApplication
            // 
            this.btnSubmitApplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSubmitApplication.FlatAppearance.BorderSize = 2;
            this.btnSubmitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitApplication.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitApplication.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmitApplication.Image")));
            this.btnSubmitApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitApplication.Location = new System.Drawing.Point(440, 208);
            this.btnSubmitApplication.Name = "btnSubmitApplication";
            this.btnSubmitApplication.Size = new System.Drawing.Size(122, 45);
            this.btnSubmitApplication.TabIndex = 11;
            this.btnSubmitApplication.Text = "    SUBMIT";
            this.btnSubmitApplication.UseVisualStyleBackColor = true;
            this.btnSubmitApplication.Click += new System.EventHandler(this.btnSubmitApplication_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 23);
            this.label18.TabIndex = 0;
            this.label18.Text = "Preference List";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Choose Department";
            // 
            // dropDownDepartment
            // 
            this.dropDownDepartment.Font = new System.Drawing.Font("Verdana", 12F);
            this.dropDownDepartment.FormattingEnabled = true;
            this.dropDownDepartment.Location = new System.Drawing.Point(224, 42);
            this.dropDownDepartment.MaxDropDownItems = 30;
            this.dropDownDepartment.Name = "dropDownDepartment";
            this.dropDownDepartment.Size = new System.Drawing.Size(188, 26);
            this.dropDownDepartment.TabIndex = 14;
            // 
            // btnAddPreference
            // 
            this.btnAddPreference.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddPreference.FlatAppearance.BorderSize = 2;
            this.btnAddPreference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPreference.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnAddPreference.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPreference.Image")));
            this.btnAddPreference.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPreference.Location = new System.Drawing.Point(428, 40);
            this.btnAddPreference.Name = "btnAddPreference";
            this.btnAddPreference.Size = new System.Drawing.Size(122, 30);
            this.btnAddPreference.TabIndex = 15;
            this.btnAddPreference.Text = "ADD";
            this.btnAddPreference.UseVisualStyleBackColor = true;
            this.btnAddPreference.Click += new System.EventHandler(this.btnAddPreference_Click);
            // 
            // dataGridPreferences
            // 
            this.dataGridPreferences.AllowUserToDeleteRows = false;
            this.dataGridPreferences.AllowUserToResizeColumns = false;
            this.dataGridPreferences.AllowUserToResizeRows = false;
            this.dataGridPreferences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPreferences.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGridPreferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPreferences.GridColor = System.Drawing.Color.OrangeRed;
            this.dataGridPreferences.Location = new System.Drawing.Point(35, 76);
            this.dataGridPreferences.Name = "dataGridPreferences";
            this.dataGridPreferences.ReadOnly = true;
            this.dataGridPreferences.RowHeadersVisible = false;
            this.dataGridPreferences.Size = new System.Drawing.Size(515, 111);
            this.dataGridPreferences.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1027, 599);
            this.Controls.Add(this.PanelSideBar);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.panelPreferenceList);
            this.Controls.Add(this.educationalInfoPanel);
            this.Controls.Add(this.personalInfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitWindow)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelSideBar.ResumeLayout(false);
            this.personalInfoPanel.ResumeLayout(false);
            this.personalInfoPanel.PerformLayout();
            this.educationalInfoPanel.ResumeLayout(false);
            this.educationalInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatricMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFSCMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEcatMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGatMarks)).EndInit();
            this.panelPreferenceList.ResumeLayout(false);
            this.panelPreferenceList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreferences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelSideBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMeritList;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnNewApplication;
        private System.Windows.Forms.PictureBox btnExitWindow;
        private System.Windows.Forms.Panel personalInfoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMoveToEduPanel;
        private System.Windows.Forms.Panel educationalInfoPanel;
        private System.Windows.Forms.Button btnBackToPersonalInfoPanel;
        private System.Windows.Forms.Button btnMoveToPrefListPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numGatMarks;
        private System.Windows.Forms.NumericUpDown numEcatMarks;
        private System.Windows.Forms.NumericUpDown numFSCMarks;
        private System.Windows.Forms.NumericUpDown numMatricMarks;
        private System.Windows.Forms.Panel panelPreferenceList;
        private System.Windows.Forms.Button btnBackToEducationalInfo;
        private System.Windows.Forms.Button btnSubmitApplication;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnAddPreference;
        private System.Windows.Forms.ComboBox dropDownDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridPreferences;
    }
}