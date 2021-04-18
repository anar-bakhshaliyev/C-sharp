namespace StudentRegistration.Forms
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.roomToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roomToolStripMenuItem.Text = "Room";
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AllowUserToResizeRows = false;
            this.dgvCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CFirstname,
            this.CLastname,
            this.CEmail,
            this.Groupname,
            this.Classname});
            this.dgvCourses.Location = new System.Drawing.Point(12, 118);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.Size = new System.Drawing.Size(762, 290);
            this.dgvCourses.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // CFirstname
            // 
            this.CFirstname.HeaderText = "Firstname";
            this.CFirstname.Name = "CFirstname";
            this.CFirstname.ReadOnly = true;
            // 
            // CLastname
            // 
            this.CLastname.HeaderText = "Lastname";
            this.CLastname.Name = "CLastname";
            this.CLastname.ReadOnly = true;
            // 
            // CEmail
            // 
            this.CEmail.HeaderText = "Email";
            this.CEmail.Name = "CEmail";
            this.CEmail.ReadOnly = true;
            // 
            // Groupname
            // 
            this.Groupname.HeaderText = "Group name";
            this.Groupname.Name = "Groupname";
            this.Groupname.ReadOnly = true;
            // 
            // Classname
            // 
            this.Classname.HeaderText = "Class Name";
            this.Classname.Name = "Classname";
            this.Classname.ReadOnly = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 420);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groupname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classname;
    }
}