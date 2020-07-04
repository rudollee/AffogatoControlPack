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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2");
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("4");
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("5");
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("6");
			this.listViewEx1 = new AffogatoControlPack.ListViewEx();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.comboBoxEx1 = new AffogatoControlPack.ComboBoxEx();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CodeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
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
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.CodeName});
			this.dataGridView1.Location = new System.Drawing.Point(403, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(385, 425);
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
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.listViewEx1);
			this.Controls.Add(this.comboBoxEx1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
	}
}

