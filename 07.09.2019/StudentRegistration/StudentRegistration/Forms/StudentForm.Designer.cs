namespace StudentRegistration.Forms
{
    partial class StudentForm
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxGroup = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentLastname,
            this.StudentFirstname,
            this.GroupName});
            this.dgvStudent.Location = new System.Drawing.Point(230, 11);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 62;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.Size = new System.Drawing.Size(558, 338);
            this.dgvStudent.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 318);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cbxGroup
            // 
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.Location = new System.Drawing.Point(25, 216);
            this.cbxGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(187, 21);
            this.cbxGroup.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(25, 153);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(25, 91);
            this.txtLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(187, 20);
            this.txtLname.TabIndex = 7;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(25, 33);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(187, 20);
            this.txtFname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Group Name";
            // 
            // StudentId
            // 
            this.StudentId.HeaderText = "Id";
            this.StudentId.Name = "StudentId";
            this.StudentId.Visible = false;
            // 
            // StudentLastname
            // 
            this.StudentLastname.HeaderText = "Lastname";
            this.StudentLastname.Name = "StudentLastname";
            // 
            // StudentFirstname
            // 
            this.StudentFirstname.HeaderText = "Firstname";
            this.StudentFirstname.Name = "StudentFirstname";
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Group Name";
            this.GroupName.Name = "GroupName";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxGroup);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxGroup;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
    }
}