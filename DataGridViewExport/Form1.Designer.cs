
namespace DataGridViewExport
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.UpdateFirstNameTextBox = new System.Windows.Forms.Button();
            this.FindAndUpdateButton = new System.Windows.Forms.Button();
            this.FindByFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FindByIdButton = new System.Windows.Forms.Button();
            this.NumericUpDownIdentifier = new System.Windows.Forms.NumericUpDown();
            this.coreBindingNavigator1 = new WindowFormsControlsLibrary.CoreBindingNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownIdentifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreBindingNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.FirstNameColumn,
            this.LastColumn,
            this.PhoneColumn,
            this.EmailColumn,
            this.BirthDateColumn});
            this.dataGridView1.Location = new System.Drawing.Point(14, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(807, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            this.IdColumn.Width = 125;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.DataPropertyName = "FirstName";
            this.FirstNameColumn.HeaderText = "First";
            this.FirstNameColumn.MinimumWidth = 6;
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.Width = 125;
            // 
            // LastColumn
            // 
            this.LastColumn.DataPropertyName = "LastName";
            this.LastColumn.HeaderText = "Last";
            this.LastColumn.MinimumWidth = 6;
            this.LastColumn.Name = "LastColumn";
            this.LastColumn.Width = 125;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.DataPropertyName = "Phone";
            this.PhoneColumn.HeaderText = "Phone";
            this.PhoneColumn.MinimumWidth = 6;
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.Width = 125;
            // 
            // EmailColumn
            // 
            this.EmailColumn.DataPropertyName = "Email";
            this.EmailColumn.HeaderText = "Mail";
            this.EmailColumn.MinimumWidth = 6;
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.Width = 125;
            // 
            // BirthDateColumn
            // 
            this.BirthDateColumn.DataPropertyName = "BirthDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.BirthDateColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.BirthDateColumn.HeaderText = "Birth";
            this.BirthDateColumn.MinimumWidth = 6;
            this.BirthDateColumn.Name = "BirthDateColumn";
            this.BirthDateColumn.Width = 125;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(14, 506);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(86, 31);
            this.ExportButton.TabIndex = 1;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current id";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(94, 554);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(33, 20);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "000";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(434, 546);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(162, 27);
            this.FirstNameTextBox.TabIndex = 4;
            // 
            // UpdateFirstNameTextBox
            // 
            this.UpdateFirstNameTextBox.Location = new System.Drawing.Point(602, 545);
            this.UpdateFirstNameTextBox.Name = "UpdateFirstNameTextBox";
            this.UpdateFirstNameTextBox.Size = new System.Drawing.Size(156, 29);
            this.UpdateFirstNameTextBox.TabIndex = 5;
            this.UpdateFirstNameTextBox.Text = "Update current row";
            this.UpdateFirstNameTextBox.UseVisualStyleBackColor = true;
            this.UpdateFirstNameTextBox.Click += new System.EventHandler(this.UpdateFirstNameTextBox_Click);
            // 
            // FindAndUpdateButton
            // 
            this.FindAndUpdateButton.Location = new System.Drawing.Point(602, 594);
            this.FindAndUpdateButton.Name = "FindAndUpdateButton";
            this.FindAndUpdateButton.Size = new System.Drawing.Size(156, 29);
            this.FindAndUpdateButton.TabIndex = 6;
            this.FindAndUpdateButton.Text = "Find/Update";
            this.FindAndUpdateButton.UseVisualStyleBackColor = true;
            this.FindAndUpdateButton.Click += new System.EventHandler(this.FindAndUpdateButton_Click);
            // 
            // FindByFirstNameTextBox
            // 
            this.FindByFirstNameTextBox.Location = new System.Drawing.Point(434, 594);
            this.FindByFirstNameTextBox.Name = "FindByFirstNameTextBox";
            this.FindByFirstNameTextBox.Size = new System.Drawing.Size(162, 27);
            this.FindByFirstNameTextBox.TabIndex = 7;
            // 
            // FindByIdButton
            // 
            this.FindByIdButton.Location = new System.Drawing.Point(602, 510);
            this.FindByIdButton.Name = "FindByIdButton";
            this.FindByIdButton.Size = new System.Drawing.Size(156, 29);
            this.FindByIdButton.TabIndex = 8;
            this.FindByIdButton.Text = "Find by id";
            this.FindByIdButton.UseVisualStyleBackColor = true;
            this.FindByIdButton.Click += new System.EventHandler(this.FindByIdButton_Click);
            // 
            // NumericUpDownIdentifier
            // 
            this.NumericUpDownIdentifier.Location = new System.Drawing.Point(434, 510);
            this.NumericUpDownIdentifier.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumericUpDownIdentifier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownIdentifier.Name = "NumericUpDownIdentifier";
            this.NumericUpDownIdentifier.Size = new System.Drawing.Size(162, 27);
            this.NumericUpDownIdentifier.TabIndex = 9;
            this.NumericUpDownIdentifier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // coreBindingNavigator1
            // 
            this.coreBindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.coreBindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.coreBindingNavigator1.Name = "coreBindingNavigator1";
            this.coreBindingNavigator1.Size = new System.Drawing.Size(834, 27);
            this.coreBindingNavigator1.TabIndex = 10;
            this.coreBindingNavigator1.Text = "coreBindingNavigator1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 642);
            this.Controls.Add(this.coreBindingNavigator1);
            this.Controls.Add(this.NumericUpDownIdentifier);
            this.Controls.Add(this.FindByIdButton);
            this.Controls.Add(this.FindByFirstNameTextBox);
            this.Controls.Add(this.FindAndUpdateButton);
            this.Controls.Add(this.UpdateFirstNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export to file";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownIdentifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreBindingNavigator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDateColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Button UpdateFirstNameTextBox;
        private System.Windows.Forms.Button FindAndUpdateButton;
        private System.Windows.Forms.TextBox FindByFirstNameTextBox;
        private System.Windows.Forms.Button FindByIdButton;
        private System.Windows.Forms.NumericUpDown NumericUpDownIdentifier;
        private WindowFormsControlsLibrary.CoreBindingNavigator coreBindingNavigator1;
    }
}

