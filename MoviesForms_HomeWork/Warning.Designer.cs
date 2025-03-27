namespace MoviesForms_HomeWork
{
	partial class Warning
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
			this.textBoxWarning = new System.Windows.Forms.TextBox();
			this.buttonWarning = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxWarning
			// 
			this.textBoxWarning.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxWarning.Location = new System.Drawing.Point(71, 66);
			this.textBoxWarning.Name = "textBoxWarning";
			this.textBoxWarning.ReadOnly = true;
			this.textBoxWarning.Size = new System.Drawing.Size(414, 50);
			this.textBoxWarning.TabIndex = 0;
			this.textBoxWarning.Text = "Такой парень уже тут есть!!!";
			// 
			// buttonWarning
			// 
			this.buttonWarning.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonWarning.Location = new System.Drawing.Point(130, 183);
			this.buttonWarning.Name = "buttonWarning";
			this.buttonWarning.Size = new System.Drawing.Size(272, 117);
			this.buttonWarning.TabIndex = 1;
			this.buttonWarning.Text = "OK";
			this.buttonWarning.UseVisualStyleBackColor = true;
			// 
			// Warning
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(551, 383);
			this.Controls.Add(this.buttonWarning);
			this.Controls.Add(this.textBoxWarning);
			this.Name = "Warning";
			this.Text = "Warning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxWarning;
		private System.Windows.Forms.Button buttonWarning;
	}
}