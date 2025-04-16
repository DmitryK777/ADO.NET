namespace AcademyDataSet
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
			this.labelGroups = new System.Windows.Forms.Label();
			this.comboBoxGroups = new System.Windows.Forms.ComboBox();
			this.labelDirections = new System.Windows.Forms.Label();
			this.comboBoxDirections = new System.Windows.Forms.ComboBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// labelGroups
			// 
			this.labelGroups.AutoSize = true;
			this.labelGroups.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelGroups.Location = new System.Drawing.Point(12, 30);
			this.labelGroups.Name = "labelGroups";
			this.labelGroups.Size = new System.Drawing.Size(55, 20);
			this.labelGroups.TabIndex = 0;
			this.labelGroups.Text = "Groups";
			// 
			// comboBoxGroups
			// 
			this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGroups.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxGroups.FormattingEnabled = true;
			this.comboBoxGroups.Location = new System.Drawing.Point(73, 27);
			this.comboBoxGroups.Name = "comboBoxGroups";
			this.comboBoxGroups.Size = new System.Drawing.Size(228, 26);
			this.comboBoxGroups.TabIndex = 1;
			// 
			// labelDirections
			// 
			this.labelDirections.AutoSize = true;
			this.labelDirections.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDirections.Location = new System.Drawing.Point(403, 30);
			this.labelDirections.Name = "labelDirections";
			this.labelDirections.Size = new System.Drawing.Size(72, 20);
			this.labelDirections.TabIndex = 2;
			this.labelDirections.Text = "Directions";
			// 
			// comboBoxDirections
			// 
			this.comboBoxDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDirections.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxDirections.FormattingEnabled = true;
			this.comboBoxDirections.Location = new System.Drawing.Point(481, 28);
			this.comboBoxDirections.Name = "comboBoxDirections";
			this.comboBoxDirections.Size = new System.Drawing.Size(312, 26);
			this.comboBoxDirections.TabIndex = 3;
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 71);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(781, 367);
			this.dataGridView.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.comboBoxDirections);
			this.Controls.Add(this.labelDirections);
			this.Controls.Add(this.comboBoxGroups);
			this.Controls.Add(this.labelGroups);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "DataSet";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelGroups;
		private System.Windows.Forms.ComboBox comboBoxGroups;
		private System.Windows.Forms.Label labelDirections;
		private System.Windows.Forms.ComboBox comboBoxDirections;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}

