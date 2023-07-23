namespace DataGridViewExport1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExportButton = new System.Windows.Forms.Button();
            this.BindingNavigator1 = new WindowFormsControlsLibrary.CoreBindingNavigator();
            this.toolStripExportButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator1)).BeginInit();
            this.BindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExportButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 59);
            this.panel1.TabIndex = 1;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(34, 18);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(94, 29);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // BindingNavigator1
            // 
            this.BindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripExportButton});
            this.BindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigator1.Name = "BindingNavigator1";
            this.BindingNavigator1.Size = new System.Drawing.Size(1148, 27);
            this.BindingNavigator1.TabIndex = 2;
            this.BindingNavigator1.Text = "coreBindingNavigator1";
            // 
            // toolStripExportButton
            // 
            this.toolStripExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripExportButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExportButton.Image")));
            this.toolStripExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExportButton.Name = "toolStripExportButton";
            this.toolStripExportButton.Size = new System.Drawing.Size(56, 24);
            this.toolStripExportButton.Text = "Export";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BindingNavigator1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export to Excel with SpreadSheetLight";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator1)).EndInit();
            this.BindingNavigator1.ResumeLayout(false);
            this.BindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DataGridView dataGridView1;
    private Panel panel1;
    private Button ExportButton;
    private WindowFormsControlsLibrary.CoreBindingNavigator BindingNavigator1;
    private ToolStripButton toolStripExportButton;
}
