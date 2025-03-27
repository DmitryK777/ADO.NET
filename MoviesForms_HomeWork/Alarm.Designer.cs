namespace MoviesForms_HomeWork
{
	partial class Alarm
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
			this.buttonAlarm = new System.Windows.Forms.Button();
			this.labelAlarm = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonAlarm
			// 
			this.buttonAlarm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonAlarm.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAlarm.Location = new System.Drawing.Point(360, 123);
			this.buttonAlarm.Name = "buttonAlarm";
			this.buttonAlarm.Size = new System.Drawing.Size(207, 71);
			this.buttonAlarm.TabIndex = 1;
			this.buttonAlarm.Text = "OK";
			this.buttonAlarm.UseVisualStyleBackColor = true;
			// 
			// labelAlarm
			// 
			this.labelAlarm.AutoSize = true;
			this.labelAlarm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAlarm.Location = new System.Drawing.Point(12, 33);
			this.labelAlarm.Name = "labelAlarm";
			this.labelAlarm.Size = new System.Drawing.Size(906, 37);
			this.labelAlarm.TabIndex = 2;
			this.labelAlarm.Text = "Ну надо же ведь по человечески вводить имя и фамилию!!!";
			// 
			// Alarm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(933, 216);
			this.Controls.Add(this.labelAlarm);
			this.Controls.Add(this.buttonAlarm);
			this.Name = "Alarm";
			this.Text = "Alarm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonAlarm;
		private System.Windows.Forms.Label labelAlarm;
	}
}