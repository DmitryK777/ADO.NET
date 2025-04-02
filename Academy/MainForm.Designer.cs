namespace Academy
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusStripCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.comboBox_Students_Groups = new System.Windows.Forms.ComboBox();
			this.comboBox_Students_Directions = new System.Windows.Forms.ComboBox();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.comboBox_Groups_Directions = new System.Windows.Forms.ComboBox();
			this.dgvGroups = new System.Windows.Forms.DataGridView();
			this.tabPageDirections = new System.Windows.Forms.TabPage();
			this.dgvDirections = new System.Windows.Forms.DataGridView();
			this.tabPageDisciplines = new System.Windows.Forms.TabPage();
			this.dgvDisciplines = new System.Windows.Forms.DataGridView();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.checkBox_Empty_Groups = new System.Windows.Forms.CheckBox();
			this.checkBox_Empty_Directions = new System.Windows.Forms.CheckBox();
			this.statusStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
			this.tabPageDirections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).BeginInit();
			this.tabPageDisciplines.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
			this.tabPageTeachers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripCountLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 428);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(800, 22);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip1";
			// 
			// statusStripCountLabel
			// 
			this.statusStripCountLabel.Name = "statusStripCountLabel";
			this.statusStripCountLabel.Size = new System.Drawing.Size(123, 17);
			this.statusStripCountLabel.Text = "statusStripCountLabel";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageStudents);
			this.tabControl.Controls.Add(this.tabPageGroups);
			this.tabControl.Controls.Add(this.tabPageDirections);
			this.tabControl.Controls.Add(this.tabPageDisciplines);
			this.tabControl.Controls.Add(this.tabPageTeachers);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(800, 428);
			this.tabControl.TabIndex = 1;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.BackColor = System.Drawing.Color.Azure;
			this.tabPageStudents.Controls.Add(this.comboBox_Students_Groups);
			this.tabPageStudents.Controls.Add(this.comboBox_Students_Directions);
			this.tabPageStudents.Controls.Add(this.dgvStudents);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(792, 402);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Students";
			// 
			// comboBox_Students_Groups
			// 
			this.comboBox_Students_Groups.FormattingEnabled = true;
			this.comboBox_Students_Groups.Location = new System.Drawing.Point(224, 7);
			this.comboBox_Students_Groups.Name = "comboBox_Students_Groups";
			this.comboBox_Students_Groups.Size = new System.Drawing.Size(202, 21);
			this.comboBox_Students_Groups.TabIndex = 2;
			this.comboBox_Students_Groups.Text = "Groups";
			this.comboBox_Students_Groups.SelectedIndexChanged += new System.EventHandler(this.comboBox_Students_Groups_SelectedIndexChanged);
			this.comboBox_Students_Groups.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_Students_Groups_MouseClick);
			// 
			// comboBox_Students_Directions
			// 
			this.comboBox_Students_Directions.FormattingEnabled = true;
			this.comboBox_Students_Directions.Location = new System.Drawing.Point(9, 7);
			this.comboBox_Students_Directions.Name = "comboBox_Students_Directions";
			this.comboBox_Students_Directions.Size = new System.Drawing.Size(208, 21);
			this.comboBox_Students_Directions.TabIndex = 1;
			this.comboBox_Students_Directions.Text = "Directions";
			this.comboBox_Students_Directions.SelectedIndexChanged += new System.EventHandler(this.comboBox_Students_Directions_SelectedIndexChanged);
			this.comboBox_Students_Directions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_Students_Directions_MouseClick);
			// 
			// dgvStudents
			// 
			this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(6, 41);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.Size = new System.Drawing.Size(780, 355);
			this.dgvStudents.TabIndex = 0;
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.BackColor = System.Drawing.Color.Azure;
			this.tabPageGroups.Controls.Add(this.checkBox_Empty_Groups);
			this.tabPageGroups.Controls.Add(this.comboBox_Groups_Directions);
			this.tabPageGroups.Controls.Add(this.dgvGroups);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(792, 402);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			// 
			// comboBox_Groups_Directions
			// 
			this.comboBox_Groups_Directions.Cursor = System.Windows.Forms.Cursors.Hand;
			this.comboBox_Groups_Directions.FormattingEnabled = true;
			this.comboBox_Groups_Directions.Location = new System.Drawing.Point(9, 7);
			this.comboBox_Groups_Directions.Name = "comboBox_Groups_Directions";
			this.comboBox_Groups_Directions.Size = new System.Drawing.Size(214, 21);
			this.comboBox_Groups_Directions.TabIndex = 1;
			this.comboBox_Groups_Directions.Text = "Directions";
			this.comboBox_Groups_Directions.SelectedIndexChanged += new System.EventHandler(this.comboBox_Groups_Directions_SelectedIndexChanged);
			this.comboBox_Groups_Directions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_Groups_Directions_MouseClick);
			// 
			// dgvGroups
			// 
			this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvGroups.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroups.Location = new System.Drawing.Point(6, 40);
			this.dgvGroups.Name = "dgvGroups";
			this.dgvGroups.Size = new System.Drawing.Size(780, 356);
			this.dgvGroups.TabIndex = 0;
			// 
			// tabPageDirections
			// 
			this.tabPageDirections.BackColor = System.Drawing.Color.Azure;
			this.tabPageDirections.Controls.Add(this.checkBox_Empty_Directions);
			this.tabPageDirections.Controls.Add(this.dgvDirections);
			this.tabPageDirections.Location = new System.Drawing.Point(4, 22);
			this.tabPageDirections.Name = "tabPageDirections";
			this.tabPageDirections.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDirections.Size = new System.Drawing.Size(792, 402);
			this.tabPageDirections.TabIndex = 2;
			this.tabPageDirections.Text = "Directions";
			// 
			// dgvDirections
			// 
			this.dgvDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDirections.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dgvDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDirections.Location = new System.Drawing.Point(6, 38);
			this.dgvDirections.Name = "dgvDirections";
			this.dgvDirections.Size = new System.Drawing.Size(780, 358);
			this.dgvDirections.TabIndex = 0;
			// 
			// tabPageDisciplines
			// 
			this.tabPageDisciplines.BackColor = System.Drawing.Color.Azure;
			this.tabPageDisciplines.Controls.Add(this.dgvDisciplines);
			this.tabPageDisciplines.Location = new System.Drawing.Point(4, 22);
			this.tabPageDisciplines.Name = "tabPageDisciplines";
			this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisciplines.Size = new System.Drawing.Size(792, 402);
			this.tabPageDisciplines.TabIndex = 3;
			this.tabPageDisciplines.Text = "Disciplines";
			// 
			// dgvDisciplines
			// 
			this.dgvDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDisciplines.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dgvDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisciplines.Location = new System.Drawing.Point(6, 39);
			this.dgvDisciplines.Name = "dgvDisciplines";
			this.dgvDisciplines.Size = new System.Drawing.Size(780, 357);
			this.dgvDisciplines.TabIndex = 0;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.BackColor = System.Drawing.Color.Azure;
			this.tabPageTeachers.Controls.Add(this.dgvTeachers);
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeachers.Size = new System.Drawing.Size(792, 402);
			this.tabPageTeachers.TabIndex = 4;
			this.tabPageTeachers.Text = "Teachers";
			// 
			// dgvTeachers
			// 
			this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTeachers.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTeachers.Location = new System.Drawing.Point(6, 39);
			this.dgvTeachers.Name = "dgvTeachers";
			this.dgvTeachers.Size = new System.Drawing.Size(780, 360);
			this.dgvTeachers.TabIndex = 0;
			// 
			// checkBox_Empty_Groups
			// 
			this.checkBox_Empty_Groups.AutoSize = true;
			this.checkBox_Empty_Groups.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox_Empty_Groups.Location = new System.Drawing.Point(295, 7);
			this.checkBox_Empty_Groups.Name = "checkBox_Empty_Groups";
			this.checkBox_Empty_Groups.Size = new System.Drawing.Size(202, 24);
			this.checkBox_Empty_Groups.TabIndex = 3;
			this.checkBox_Empty_Groups.Text = "Показать пустые группы";
			this.checkBox_Empty_Groups.UseVisualStyleBackColor = true;
			this.checkBox_Empty_Groups.CheckedChanged += new System.EventHandler(this.checkBox_Empty_Groups_CheckedChanged);
			// 
			// checkBox_Empty_Directions
			// 
			this.checkBox_Empty_Directions.AutoSize = true;
			this.checkBox_Empty_Directions.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox_Empty_Directions.Location = new System.Drawing.Point(250, 7);
			this.checkBox_Empty_Directions.Name = "checkBox_Empty_Directions";
			this.checkBox_Empty_Directions.Size = new System.Drawing.Size(283, 22);
			this.checkBox_Empty_Directions.TabIndex = 1;
			this.checkBox_Empty_Directions.Text = "Показать пустые направления";
			this.checkBox_Empty_Directions.UseVisualStyleBackColor = true;
			this.checkBox_Empty_Directions.CheckedChanged += new System.EventHandler(this.checkBox_Empty_Directions_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Academy VPD_311";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.tabPageGroups.ResumeLayout(false);
			this.tabPageGroups.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
			this.tabPageDirections.ResumeLayout(false);
			this.tabPageDirections.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).EndInit();
			this.tabPageDisciplines.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
			this.tabPageTeachers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageDirections;
		private System.Windows.Forms.TabPage tabPageDisciplines;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.DataGridView dgvGroups;
		private System.Windows.Forms.DataGridView dgvDirections;
		private System.Windows.Forms.DataGridView dgvDisciplines;
		private System.Windows.Forms.DataGridView dgvTeachers;
		private System.Windows.Forms.ToolStripStatusLabel statusStripCountLabel;
		private System.Windows.Forms.ComboBox comboBox_Groups_Directions;
		private System.Windows.Forms.ComboBox comboBox_Students_Groups;
		private System.Windows.Forms.ComboBox comboBox_Students_Directions;
		private System.Windows.Forms.CheckBox checkBox_Empty_Groups;
		private System.Windows.Forms.CheckBox checkBox_Empty_Directions;
	}
}

