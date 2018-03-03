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
            this.PanelSideBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewApplication = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnMeritList = new System.Windows.Forms.Button();
            this.btnExitWindow = new System.Windows.Forms.PictureBox();
            this.PanelHeader.SuspendLayout();
            this.PanelSideBar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitWindow)).BeginInit();
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
            this.PanelSideBar.Size = new System.Drawing.Size(146, 424);
            this.PanelSideBar.TabIndex = 1;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1027, 493);
            this.Controls.Add(this.PanelSideBar);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelSideBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitWindow)).EndInit();
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
    }
}