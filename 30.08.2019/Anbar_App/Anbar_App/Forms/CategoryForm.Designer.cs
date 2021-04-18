namespace Anbar_App.Forms
{
    partial class CategoryForm
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
            this.listCategory = new System.Windows.Forms.ListBox();
            this.btnCatSave = new System.Windows.Forms.Button();
            this.btnCatDelete = new System.Windows.Forms.Button();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lblCatname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listCategory
            // 
            this.listCategory.FormattingEnabled = true;
            this.listCategory.Location = new System.Drawing.Point(21, 139);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(265, 290);
            this.listCategory.TabIndex = 9;
            this.listCategory.DoubleClick += new System.EventHandler(this.ListCategory_DoubleClick);
            // 
            // btnCatSave
            // 
            this.btnCatSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCatSave.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCatSave.Location = new System.Drawing.Point(170, 73);
            this.btnCatSave.Name = "btnCatSave";
            this.btnCatSave.Size = new System.Drawing.Size(117, 34);
            this.btnCatSave.TabIndex = 7;
            this.btnCatSave.Text = "Save";
            this.btnCatSave.UseVisualStyleBackColor = true;
            this.btnCatSave.Click += new System.EventHandler(this.BtnCatSave_Click);
            // 
            // btnCatDelete
            // 
            this.btnCatDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatDelete.Enabled = false;
            this.btnCatDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCatDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCatDelete.Location = new System.Drawing.Point(24, 73);
            this.btnCatDelete.Name = "btnCatDelete";
            this.btnCatDelete.Size = new System.Drawing.Size(106, 34);
            this.btnCatDelete.TabIndex = 8;
            this.btnCatDelete.Text = "Delete";
            this.btnCatDelete.UseVisualStyleBackColor = true;
            this.btnCatDelete.Click += new System.EventHandler(this.BtnCatDelete_Click);
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(107, 23);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(180, 20);
            this.txtCatName.TabIndex = 6;
            // 
            // lblCatname
            // 
            this.lblCatname.AutoSize = true;
            this.lblCatname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatname.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCatname.Location = new System.Drawing.Point(21, 23);
            this.lblCatname.Name = "lblCatname";
            this.lblCatname.Size = new System.Drawing.Size(45, 15);
            this.lblCatname.TabIndex = 5;
            this.lblCatname.Text = "Name";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.listCategory);
            this.Controls.Add(this.btnCatSave);
            this.Controls.Add(this.btnCatDelete);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.lblCatname);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCategory;
        private System.Windows.Forms.Button btnCatSave;
        private System.Windows.Forms.Button btnCatDelete;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label lblCatname;
    }
}