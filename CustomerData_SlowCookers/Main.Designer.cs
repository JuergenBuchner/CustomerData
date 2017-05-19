namespace CustomerData_SlowCookers
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItemChooseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxFilterBy = new System.Windows.Forms.TextBox();
            this.cBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.btnShowFilteredList = new System.Windows.Forms.Button();
            this.dataGViewFiltered = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewFiltered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItemChooseFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItemChooseFile
            // 
            this.dataToolStripMenuItemChooseFile.Name = "dataToolStripMenuItemChooseFile";
            this.dataToolStripMenuItemChooseFile.Size = new System.Drawing.Size(80, 20);
            this.dataToolStripMenuItemChooseFile.Text = "Choose File";
            this.dataToolStripMenuItemChooseFile.Click += new System.EventHandler(this.dataToolStripMenuItemChooseFile_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(662, 27);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(118, 36);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(662, 69);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(118, 36);
            this.btnEditCustomer.TabIndex = 2;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter by:";
            // 
            // txtBxFilterBy
            // 
            this.txtBxFilterBy.Location = new System.Drawing.Point(55, 332);
            this.txtBxFilterBy.Name = "txtBxFilterBy";
            this.txtBxFilterBy.Size = new System.Drawing.Size(172, 20);
            this.txtBxFilterBy.TabIndex = 4;
            // 
            // cBoxFilterBy
            // 
            this.cBoxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFilterBy.FormattingEnabled = true;
            this.cBoxFilterBy.Location = new System.Drawing.Point(233, 332);
            this.cBoxFilterBy.Name = "cBoxFilterBy";
            this.cBoxFilterBy.Size = new System.Drawing.Size(78, 21);
            this.cBoxFilterBy.TabIndex = 5;
            // 
            // btnShowFilteredList
            // 
            this.btnShowFilteredList.Location = new System.Drawing.Point(317, 330);
            this.btnShowFilteredList.Name = "btnShowFilteredList";
            this.btnShowFilteredList.Size = new System.Drawing.Size(116, 23);
            this.btnShowFilteredList.TabIndex = 6;
            this.btnShowFilteredList.Text = "Show List";
            this.btnShowFilteredList.UseVisualStyleBackColor = true;
            this.btnShowFilteredList.Click += new System.EventHandler(this.btnShowFilteredList_Click);
            // 
            // dataGViewFiltered
            // 
            this.dataGViewFiltered.AllowUserToOrderColumns = true;
            this.dataGViewFiltered.AllowUserToResizeColumns = false;
            this.dataGViewFiltered.AllowUserToResizeRows = false;
            this.dataGViewFiltered.AutoGenerateColumns = false;
            this.dataGViewFiltered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGViewFiltered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn});
            this.dataGViewFiltered.DataSource = this.customerBindingSource1;
            this.dataGViewFiltered.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGViewFiltered.Location = new System.Drawing.Point(12, 27);
            this.dataGViewFiltered.MultiSelect = false;
            this.dataGViewFiltered.Name = "dataGViewFiltered";
            this.dataGViewFiltered.RowHeadersVisible = false;
            this.dataGViewFiltered.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGViewFiltered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGViewFiltered.Size = new System.Drawing.Size(644, 297);
            this.dataGViewFiltered.TabIndex = 7;
            this.dataGViewFiltered.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGViewFiltered_ColumnHeaderMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "eMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "eMail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(CustomerData_SlowCookers.Customer);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(CustomerData_SlowCookers.Customer);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 360);
            this.Controls.Add(this.dataGViewFiltered);
            this.Controls.Add(this.btnShowFilteredList);
            this.Controls.Add(this.cBoxFilterBy);
            this.Controls.Add(this.txtBxFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(802, 399);
            this.MinimumSize = new System.Drawing.Size(802, 399);
            this.Name = "Main";
            this.Text = "Customer Data";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewFiltered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItemChooseFile;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxFilterBy;
        private System.Windows.Forms.ComboBox cBoxFilterBy;
        private System.Windows.Forms.Button btnShowFilteredList;
        private System.Windows.Forms.DataGridView dataGViewFiltered;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
    }
}

