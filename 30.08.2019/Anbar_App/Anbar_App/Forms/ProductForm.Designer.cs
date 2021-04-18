namespace Anbar_App.Forms
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.PrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrProDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrExpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblexpDate = new System.Windows.Forms.Label();
            this.lblprodate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.operatinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtexpDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtproDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSave.Location = new System.Drawing.Point(-105, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrName,
            this.PrPrice,
            this.PrProDate,
            this.PrExpdate,
            this.PrQuantity,
            this.PrCategory,
            this.PrCompany});
            this.dgvProduct.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvProduct.Location = new System.Drawing.Point(224, 58);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "1";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.RowHeadersWidth = 40;
            this.dgvProduct.Size = new System.Drawing.Size(739, 352);
            this.dgvProduct.TabIndex = 34;
            this.dgvProduct.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProduct_RowHeaderMouseDoubleClick);
            // 
            // PrName
            // 
            this.PrName.HeaderText = "Name";
            this.PrName.Name = "PrName";
            this.PrName.ReadOnly = true;
            // 
            // PrPrice
            // 
            this.PrPrice.HeaderText = "Price";
            this.PrPrice.Name = "PrPrice";
            this.PrPrice.ReadOnly = true;
            // 
            // PrProDate
            // 
            this.PrProDate.HeaderText = "Production Date";
            this.PrProDate.Name = "PrProDate";
            this.PrProDate.ReadOnly = true;
            // 
            // PrExpdate
            // 
            this.PrExpdate.HeaderText = "Expiration Date";
            this.PrExpdate.Name = "PrExpdate";
            this.PrExpdate.ReadOnly = true;
            // 
            // PrQuantity
            // 
            this.PrQuantity.HeaderText = "Quantity";
            this.PrQuantity.Name = "PrQuantity";
            this.PrQuantity.ReadOnly = true;
            // 
            // PrCategory
            // 
            this.PrCategory.HeaderText = "Category";
            this.PrCategory.Name = "PrCategory";
            this.PrCategory.ReadOnly = true;
            // 
            // PrCompany
            // 
            this.PrCompany.HeaderText = "Company";
            this.PrCompany.Name = "PrCompany";
            this.PrCompany.ReadOnly = true;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCompany.Location = new System.Drawing.Point(-128, 335);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 37;
            this.lblCompany.Text = "Company";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCategory.Location = new System.Drawing.Point(-128, 294);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 36;
            this.lblCategory.Text = "Category";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblQuantity.Location = new System.Drawing.Point(-128, 256);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 35;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblexpDate
            // 
            this.lblexpDate.AutoSize = true;
            this.lblexpDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblexpDate.Location = new System.Drawing.Point(-128, 181);
            this.lblexpDate.Name = "lblexpDate";
            this.lblexpDate.Size = new System.Drawing.Size(79, 13);
            this.lblexpDate.TabIndex = 29;
            this.lblexpDate.Text = "Expiration Date";
            // 
            // lblprodate
            // 
            this.lblprodate.AutoSize = true;
            this.lblprodate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblprodate.Location = new System.Drawing.Point(-128, 146);
            this.lblprodate.Name = "lblprodate";
            this.lblprodate.Size = new System.Drawing.Size(84, 13);
            this.lblprodate.TabIndex = 26;
            this.lblprodate.Text = "Production Date";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPrice.Location = new System.Drawing.Point(-128, 107);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 13);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Price ($)";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblName.Location = new System.Drawing.Point(-128, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatinToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.Size = new System.Drawing.Size(975, 24);
            this.menuStrip2.TabIndex = 38;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // operatinToolStripMenuItem
            // 
            this.operatinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.categoryToolStripMenuItem});
            this.operatinToolStripMenuItem.Name = "operatinToolStripMenuItem";
            this.operatinToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.operatinToolStripMenuItem.Text = "Operation";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click_1);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click_1);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Location = new System.Drawing.Point(127, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(18, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(15, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Company";
            // 
            // cbxCompany
            // 
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(103, 331);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(104, 21);
            this.cbxCompany.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(15, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(104, 282);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(103, 21);
            this.cbxCategory.TabIndex = 49;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(104, 237);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(103, 20);
            this.txtQuantity.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(15, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Quantity";
            // 
            // txtexpDate
            // 
            this.txtexpDate.Location = new System.Drawing.Point(104, 192);
            this.txtexpDate.Name = "txtexpDate";
            this.txtexpDate.Size = new System.Drawing.Size(104, 20);
            this.txtexpDate.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(15, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Expiration Date";
            // 
            // txtproDate
            // 
            this.txtproDate.AccessibleName = "";
            this.txtproDate.Location = new System.Drawing.Point(105, 148);
            this.txtproDate.Name = "txtproDate";
            this.txtproDate.Size = new System.Drawing.Size(104, 20);
            this.txtproDate.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(15, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Production Date";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(105, 102);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(104, 20);
            this.txtPrice.TabIndex = 43;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(104, 20);
            this.txtName.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(15, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Price ($)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(15, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 421);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtexpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtproDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblexpDate);
            this.Controls.Add(this.lblprodate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip2);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblexpDate;
        private System.Windows.Forms.Label lblprodate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem operatinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrProDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrExpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrCompany;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtexpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtproDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}