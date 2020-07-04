namespace AffogatoControlPackTest
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2");
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("4");
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("5");
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("6");
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CodeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.exampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.listViewEx1 = new AffogatoControlPack.ListViewEx();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.comboBoxEx1 = new AffogatoControlPack.ComboBoxEx();
			this.example2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.CodeName});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
			this.dataGridView1.Location = new System.Drawing.Point(415, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(385, 428);
			this.dataGridView1.TabIndex = 2;
			// 
			// Code
			// 
			this.Code.DataPropertyName = "Code";
			this.Code.HeaderText = "Code";
			this.Code.Name = "Code";
			this.Code.ReadOnly = true;
			// 
			// CodeName
			// 
			this.CodeName.DataPropertyName = "CodeName";
			this.CodeName.HeaderText = "CodeName";
			this.CodeName.Name = "CodeName";
			this.CodeName.ReadOnly = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(1);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exampleToolStripMenuItem,
            this.example2ToolStripMenuItem});
			this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Margin = new System.Windows.Forms.Padding(0, -1, 0, -1);
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(54, 24);
			this.toolStripSplitButton1.Text = "Menu";
			// 
			// exampleToolStripMenuItem
			// 
			this.exampleToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
			this.exampleToolStripMenuItem.Name = "exampleToolStripMenuItem";
			this.exampleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
			this.exampleToolStripMenuItem.Size = new System.Drawing.Size(180, 20);
			this.exampleToolStripMenuItem.Text = "Example";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel1.Text = "Status";
			// 
			// listViewEx1
			// 
			this.listViewEx1.BackColor = System.Drawing.Color.Black;
			this.listViewEx1.BackColorItemSelected = System.Drawing.Color.Gray;
			this.listViewEx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listViewEx1.ForeColor = System.Drawing.Color.DarkGray;
			this.listViewEx1.ForeColorItemSelected = System.Drawing.Color.Thistle;
			this.listViewEx1.FullRowSelect = true;
			this.listViewEx1.GridColor = System.Drawing.Color.DarkMagenta;
			this.listViewEx1.GridLines = true;
			this.listViewEx1.HideSelection = false;
			this.listViewEx1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
			this.listViewEx1.Location = new System.Drawing.Point(62, 153);
			this.listViewEx1.MultiSelect = false;
			this.listViewEx1.Name = "listViewEx1";
			this.listViewEx1.OwnerDraw = true;
			this.listViewEx1.Size = new System.Drawing.Size(238, 168);
			this.listViewEx1.TabIndex = 1;
			this.listViewEx1.UseCompatibleStateImageBehavior = false;
			this.listViewEx1.View = System.Windows.Forms.View.Details;
			// 
			// comboBoxEx1
			// 
			this.comboBoxEx1.BorderColor = System.Drawing.Color.Gray;
			this.comboBoxEx1.FormattingEnabled = true;
			this.comboBoxEx1.Location = new System.Drawing.Point(74, 97);
			this.comboBoxEx1.Name = "comboBoxEx1";
			this.comboBoxEx1.Size = new System.Drawing.Size(121, 21);
			this.comboBoxEx1.TabIndex = 0;
			// 
			// example2ToolStripMenuItem
			// 
			this.example2ToolStripMenuItem.Name = "example2ToolStripMenuItem";
			this.example2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.example2ToolStripMenuItem.Text = "Example 2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.listViewEx1);
			this.Controls.Add(this.comboBoxEx1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private AffogatoControlPack.ComboBoxEx comboBoxEx1;
        private AffogatoControlPack.ListViewEx listViewEx1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeName;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.ToolStripMenuItem exampleToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripMenuItem example2ToolStripMenuItem;
	}
}

