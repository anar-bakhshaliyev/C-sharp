namespace StudentRegistration.Forms
{
    partial class GroupForm
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
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.btnGroupDelete = new System.Windows.Forms.Button();
            this.btnGroupEdit = new System.Windows.Forms.Button();
            this.btnGroupSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxClassroomName = new System.Windows.Forms.ComboBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGroup
            // 
            this.dgvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GroupName,
            this.GroupClassroom});
            this.dgvGroup.Location = new System.Drawing.Point(239, 11);
            this.dgvGroup.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowHeadersWidth = 62;
            this.dgvGroup.RowTemplate.Height = 28;
            this.dgvGroup.Size = new System.Drawing.Size(377, 265);
            this.dgvGroup.TabIndex = 15;
            // 
            // btnGroupDelete
            // 
            this.btnGroupDelete.Location = new System.Drawing.Point(12, 246);
            this.btnGroupDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnGroupDelete.Name = "btnGroupDelete";
            this.btnGroupDelete.Size = new System.Drawing.Size(92, 30);
            this.btnGroupDelete.TabIndex = 14;
            this.btnGroupDelete.Text = "Delete";
            this.btnGroupDelete.UseVisualStyleBackColor = true;
            // 
            // btnGroupEdit
            // 
            this.btnGroupEdit.Location = new System.Drawing.Point(124, 246);
            this.btnGroupEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnGroupEdit.Name = "btnGroupEdit";
            this.btnGroupEdit.Size = new System.Drawing.Size(92, 30);
            this.btnGroupEdit.TabIndex = 13;
            this.btnGroupEdit.Text = "Update";
            this.btnGroupEdit.UseVisualStyleBackColor = true;
            // 
            // btnGroupSave
            // 
            this.btnGroupSave.Location = new System.Drawing.Point(12, 200);
            this.btnGroupSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnGroupSave.Name = "btnGroupSave";
            this.btnGroupSave.Size = new System.Drawing.Size(201, 28);
            this.btnGroupSave.TabIndex = 12;
            this.btnGroupSave.Text = "Save";
            this.btnGroupSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Classroom Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Group Name";
            // 
            // cbxClassroomName
            // 
            this.cbxClassroomName.FormattingEnabled = true;
            this.cbxClassroomName.Location = new System.Drawing.Point(14, 78);
            this.cbxClassroomName.Margin = new System.Windows.Forms.Padding(2);
            this.cbxClassroomName.Name = "cbxClassroomName";
            this.cbxClassroomName.Size = new System.Drawing.Size(202, 21);
            this.cbxClassroomName.TabIndex = 9;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(14, 26);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(2);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(202, 20);
            this.txtGroupName.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Name";
            this.GroupName.MinimumWidth = 8;
            this.GroupName.Name = "GroupName";
            // 
            // GroupClassroom
            // 
            this.GroupClassroom.HeaderText = "Classroom";
            this.GroupClassroom.MinimumWidth = 8;
            this.GroupClassroom.Name = "GroupClassroom";
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 287);
            this.Controls.Add(this.dgvGroup);
            this.Controls.Add(this.btnGroupDelete);
            this.Controls.Add(this.btnGroupEdit);
            this.Controls.Add(this.btnGroupSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxClassroomName);
            this.Controls.Add(this.txtGroupName);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.Button btnGroupDelete;
        private System.Windows.Forms.Button btnGroupEdit;
        private System.Windows.Forms.Button btnGroupSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxClassroomName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupClassroom;
    }
}