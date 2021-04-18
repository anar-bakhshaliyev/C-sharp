namespace Anbar_App.Forms
{
    partial class EmployeeForm
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            this.btnEmpSave = new System.Windows.Forms.Button();
            this.txtEmpPos = new System.Windows.Forms.TextBox();
            this.lblEmpPos = new System.Windows.Forms.Label();
            this.txtEmpLname = new System.Windows.Forms.TextBox();
            this.lblEmpLname = new System.Windows.Forms.Label();
            this.txtEmpFname = new System.Windows.Forms.TextBox();
            this.lblEmpFName = new System.Windows.Forms.Label();
            this.EmpFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpFname,
            this.EmpLname,
            this.EmpPos});
            this.dgvEmployee.Location = new System.Drawing.Point(244, 10);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(537, 143);
            this.dgvEmployee.TabIndex = 15;
            this.dgvEmployee.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEmployee_RowHeaderMouseDoubleClick);
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpDelete.Enabled = false;
            this.btnEmpDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEmpDelete.Location = new System.Drawing.Point(35, 132);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(75, 23);
            this.btnEmpDelete.TabIndex = 14;
            this.btnEmpDelete.Text = "Delete";
            this.btnEmpDelete.UseVisualStyleBackColor = true;
            this.btnEmpDelete.Click += new System.EventHandler(this.BtnEmpDelete_Click);
            // 
            // btnEmpSave
            // 
            this.btnEmpSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpSave.Location = new System.Drawing.Point(116, 132);
            this.btnEmpSave.Name = "btnEmpSave";
            this.btnEmpSave.Size = new System.Drawing.Size(75, 23);
            this.btnEmpSave.TabIndex = 12;
            this.btnEmpSave.Text = "Save";
            this.btnEmpSave.UseVisualStyleBackColor = true;
            this.btnEmpSave.Click += new System.EventHandler(this.BtnEmpSave_Click);
            // 
            // txtEmpPos
            // 
            this.txtEmpPos.Location = new System.Drawing.Point(91, 86);
            this.txtEmpPos.Name = "txtEmpPos";
            this.txtEmpPos.Size = new System.Drawing.Size(100, 20);
            this.txtEmpPos.TabIndex = 11;
            // 
            // lblEmpPos
            // 
            this.lblEmpPos.AutoSize = true;
            this.lblEmpPos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmpPos.Location = new System.Drawing.Point(33, 93);
            this.lblEmpPos.Name = "lblEmpPos";
            this.lblEmpPos.Size = new System.Drawing.Size(44, 13);
            this.lblEmpPos.TabIndex = 13;
            this.lblEmpPos.Text = "Position";
            // 
            // txtEmpLname
            // 
            this.txtEmpLname.Location = new System.Drawing.Point(91, 47);
            this.txtEmpLname.Name = "txtEmpLname";
            this.txtEmpLname.Size = new System.Drawing.Size(100, 20);
            this.txtEmpLname.TabIndex = 9;
            // 
            // lblEmpLname
            // 
            this.lblEmpLname.AutoSize = true;
            this.lblEmpLname.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmpLname.Location = new System.Drawing.Point(33, 54);
            this.lblEmpLname.Name = "lblEmpLname";
            this.lblEmpLname.Size = new System.Drawing.Size(53, 13);
            this.lblEmpLname.TabIndex = 10;
            this.lblEmpLname.Text = "Lastname";
            // 
            // txtEmpFname
            // 
            this.txtEmpFname.Location = new System.Drawing.Point(91, 10);
            this.txtEmpFname.Name = "txtEmpFname";
            this.txtEmpFname.Size = new System.Drawing.Size(100, 20);
            this.txtEmpFname.TabIndex = 8;
            // 
            // lblEmpFName
            // 
            this.lblEmpFName.AutoSize = true;
            this.lblEmpFName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmpFName.Location = new System.Drawing.Point(33, 17);
            this.lblEmpFName.Name = "lblEmpFName";
            this.lblEmpFName.Size = new System.Drawing.Size(52, 13);
            this.lblEmpFName.TabIndex = 7;
            this.lblEmpFName.Text = "Firstname";
            // 
            // EmpFname
            // 
            this.EmpFname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpFname.HeaderText = "Firstname";
            this.EmpFname.Name = "EmpFname";
            this.EmpFname.ReadOnly = true;
            // 
            // EmpLname
            // 
            this.EmpLname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpLname.HeaderText = "Lastname";
            this.EmpLname.Name = "EmpLname";
            this.EmpLname.ReadOnly = true;
            // 
            // EmpPos
            // 
            this.EmpPos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpPos.HeaderText = "Position";
            this.EmpPos.Name = "EmpPos";
            this.EmpPos.ReadOnly = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 168);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnEmpDelete);
            this.Controls.Add(this.btnEmpSave);
            this.Controls.Add(this.txtEmpPos);
            this.Controls.Add(this.lblEmpPos);
            this.Controls.Add(this.txtEmpLname);
            this.Controls.Add(this.lblEmpLname);
            this.Controls.Add(this.txtEmpFname);
            this.Controls.Add(this.lblEmpFName);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnEmpDelete;
        private System.Windows.Forms.Button btnEmpSave;
        private System.Windows.Forms.TextBox txtEmpPos;
        private System.Windows.Forms.Label lblEmpPos;
        private System.Windows.Forms.TextBox txtEmpLname;
        private System.Windows.Forms.Label lblEmpLname;
        private System.Windows.Forms.TextBox txtEmpFname;
        private System.Windows.Forms.Label lblEmpFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPos;
    }
}