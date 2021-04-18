namespace Anbar_App.Forms
{
    partial class CompanyForm
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
            this.btnComDelete = new System.Windows.Forms.Button();
            this.btnComSave = new System.Windows.Forms.Button();
            this.dgvCompany = new System.Windows.Forms.DataGridView();
            this.txtComPhone = new System.Windows.Forms.TextBox();
            this.lblComAdress = new System.Windows.Forms.Label();
            this.txtComAdress = new System.Windows.Forms.TextBox();
            this.lblComPhone = new System.Windows.Forms.Label();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.lblComName = new System.Windows.Forms.Label();
            this.ComName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComDelete
            // 
            this.btnComDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComDelete.Enabled = false;
            this.btnComDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnComDelete.Location = new System.Drawing.Point(19, 152);
            this.btnComDelete.Name = "btnComDelete";
            this.btnComDelete.Size = new System.Drawing.Size(75, 23);
            this.btnComDelete.TabIndex = 14;
            this.btnComDelete.Text = "Delete";
            this.btnComDelete.UseVisualStyleBackColor = true;
            this.btnComDelete.Click += new System.EventHandler(this.BtnComDelete_Click);
            // 
            // btnComSave
            // 
            this.btnComSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComSave.Location = new System.Drawing.Point(119, 152);
            this.btnComSave.Name = "btnComSave";
            this.btnComSave.Size = new System.Drawing.Size(75, 23);
            this.btnComSave.TabIndex = 12;
            this.btnComSave.Text = "Save";
            this.btnComSave.UseVisualStyleBackColor = true;
            this.btnComSave.Click += new System.EventHandler(this.BtnComSave_Click);
            // 
            // dgvCompany
            // 
            this.dgvCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComName,
            this.ComPhone,
            this.ComAdress});
            this.dgvCompany.Location = new System.Drawing.Point(215, 12);
            this.dgvCompany.MultiSelect = false;
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.Size = new System.Drawing.Size(568, 171);
            this.dgvCompany.TabIndex = 15;
            this.dgvCompany.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCompany_RowHeaderMouseDoubleClick);
            // 
            // txtComPhone
            // 
            this.txtComPhone.Location = new System.Drawing.Point(95, 52);
            this.txtComPhone.Name = "txtComPhone";
            this.txtComPhone.Size = new System.Drawing.Size(100, 20);
            this.txtComPhone.TabIndex = 9;
            // 
            // lblComAdress
            // 
            this.lblComAdress.AutoSize = true;
            this.lblComAdress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblComAdress.Location = new System.Drawing.Point(16, 100);
            this.lblComAdress.Name = "lblComAdress";
            this.lblComAdress.Size = new System.Drawing.Size(39, 13);
            this.lblComAdress.TabIndex = 13;
            this.lblComAdress.Text = "Adress";
            // 
            // txtComAdress
            // 
            this.txtComAdress.Location = new System.Drawing.Point(95, 93);
            this.txtComAdress.Name = "txtComAdress";
            this.txtComAdress.Size = new System.Drawing.Size(100, 20);
            this.txtComAdress.TabIndex = 11;
            // 
            // lblComPhone
            // 
            this.lblComPhone.AutoSize = true;
            this.lblComPhone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblComPhone.Location = new System.Drawing.Point(16, 59);
            this.lblComPhone.Name = "lblComPhone";
            this.lblComPhone.Size = new System.Drawing.Size(38, 13);
            this.lblComPhone.TabIndex = 10;
            this.lblComPhone.Text = "Phone";
            // 
            // txtComName
            // 
            this.txtComName.Location = new System.Drawing.Point(95, 12);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(100, 20);
            this.txtComName.TabIndex = 8;
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblComName.Location = new System.Drawing.Point(16, 19);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(35, 13);
            this.lblComName.TabIndex = 7;
            this.lblComName.Text = "Name";
            // 
            // ComName
            // 
            this.ComName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComName.HeaderText = "Name";
            this.ComName.Name = "ComName";
            this.ComName.ReadOnly = true;
            // 
            // ComPhone
            // 
            this.ComPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComPhone.HeaderText = "Phone";
            this.ComPhone.Name = "ComPhone";
            this.ComPhone.ReadOnly = true;
            // 
            // ComAdress
            // 
            this.ComAdress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComAdress.HeaderText = "Adress";
            this.ComAdress.Name = "ComAdress";
            this.ComAdress.ReadOnly = true;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 195);
            this.Controls.Add(this.btnComDelete);
            this.Controls.Add(this.btnComSave);
            this.Controls.Add(this.dgvCompany);
            this.Controls.Add(this.txtComPhone);
            this.Controls.Add(this.lblComAdress);
            this.Controls.Add(this.txtComAdress);
            this.Controls.Add(this.lblComPhone);
            this.Controls.Add(this.txtComName);
            this.Controls.Add(this.lblComName);
            this.Name = "CompanyForm";
            this.Text = "CompanyForm";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComDelete;
        private System.Windows.Forms.Button btnComSave;
        private System.Windows.Forms.DataGridView dgvCompany;
        private System.Windows.Forms.TextBox txtComPhone;
        private System.Windows.Forms.Label lblComAdress;
        private System.Windows.Forms.TextBox txtComAdress;
        private System.Windows.Forms.Label lblComPhone;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComAdress;
    }
}