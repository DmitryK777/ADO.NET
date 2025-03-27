namespace MoviesForms_HomeWork
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
			this.labelFilms = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.labelCountOfFilms = new System.Windows.Forms.Label();
			this.labelDirectors = new System.Windows.Forms.Label();
			this.labelAddDirector = new System.Windows.Forms.Label();
			this.textBoxDirectorFirstName = new System.Windows.Forms.TextBox();
			this.textBoxDirectorLastName = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonСancel = new System.Windows.Forms.Button();
			this.textBoxFilms = new System.Windows.Forms.TextBox();
			this.textBoxDirectors = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelFilms
			// 
			this.labelFilms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelFilms.AutoSize = true;
			this.labelFilms.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelFilms.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFilms.Location = new System.Drawing.Point(15, 15);
			this.labelFilms.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelFilms.Name = "labelFilms";
			this.labelFilms.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelFilms.Size = new System.Drawing.Size(109, 28);
			this.labelFilms.TabIndex = 0;
			this.labelFilms.Text = "Фильмы:";
			this.labelFilms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(169, 200);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(38, 22);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelCountOfFilms
			// 
			this.labelCountOfFilms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelCountOfFilms.AutoSize = true;
			this.labelCountOfFilms.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCountOfFilms.Location = new System.Drawing.Point(17, 205);
			this.labelCountOfFilms.Name = "labelCountOfFilms";
			this.labelCountOfFilms.Size = new System.Drawing.Size(146, 15);
			this.labelCountOfFilms.TabIndex = 4;
			this.labelCountOfFilms.Text = "Всего фильмов в списке:";
			this.labelCountOfFilms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelDirectors
			// 
			this.labelDirectors.AutoSize = true;
			this.labelDirectors.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelDirectors.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDirectors.Location = new System.Drawing.Point(15, 259);
			this.labelDirectors.Name = "labelDirectors";
			this.labelDirectors.Size = new System.Drawing.Size(228, 28);
			this.labelDirectors.TabIndex = 5;
			this.labelDirectors.Text = "Список режиссёров:";
			// 
			// labelAddDirector
			// 
			this.labelAddDirector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelAddDirector.AutoSize = true;
			this.labelAddDirector.BackColor = System.Drawing.SystemColors.Info;
			this.labelAddDirector.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAddDirector.Location = new System.Drawing.Point(15, 556);
			this.labelAddDirector.Name = "labelAddDirector";
			this.labelAddDirector.Size = new System.Drawing.Size(246, 28);
			this.labelAddDirector.TabIndex = 7;
			this.labelAddDirector.Text = "Добавить режиссёра:";
			this.labelAddDirector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxDirectorFirstName
			// 
			this.textBoxDirectorFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxDirectorFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDirectorFirstName.Location = new System.Drawing.Point(13, 593);
			this.textBoxDirectorFirstName.Name = "textBoxDirectorFirstName";
			this.textBoxDirectorFirstName.Size = new System.Drawing.Size(278, 26);
			this.textBoxDirectorFirstName.TabIndex = 8;
			this.textBoxDirectorFirstName.Text = "Имя";
			// 
			// textBoxDirectorLastName
			// 
			this.textBoxDirectorLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxDirectorLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDirectorLastName.Location = new System.Drawing.Point(297, 593);
			this.textBoxDirectorLastName.Name = "textBoxDirectorLastName";
			this.textBoxDirectorLastName.Size = new System.Drawing.Size(277, 26);
			this.textBoxDirectorLastName.TabIndex = 9;
			this.textBoxDirectorLastName.Text = "Фамилия";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonAdd.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAdd.Location = new System.Drawing.Point(580, 587);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(127, 37);
			this.buttonAdd.TabIndex = 10;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonСancel
			// 
			this.buttonСancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonСancel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonСancel.Location = new System.Drawing.Point(954, 586);
			this.buttonСancel.Name = "buttonСancel";
			this.buttonСancel.Size = new System.Drawing.Size(153, 36);
			this.buttonСancel.TabIndex = 11;
			this.buttonСancel.Text = "Выйти";
			this.buttonСancel.UseVisualStyleBackColor = true;
			this.buttonСancel.Click += new System.EventHandler(this.buttonСancel_Click);
			// 
			// textBoxFilms
			// 
			this.textBoxFilms.AcceptsReturn = true;
			this.textBoxFilms.AcceptsTab = true;
			this.textBoxFilms.AllowDrop = true;
			this.textBoxFilms.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxFilms.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxFilms.Location = new System.Drawing.Point(13, 46);
			this.textBoxFilms.Multiline = true;
			this.textBoxFilms.Name = "textBoxFilms";
			this.textBoxFilms.ReadOnly = true;
			this.textBoxFilms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxFilms.Size = new System.Drawing.Size(1094, 187);
			this.textBoxFilms.TabIndex = 12;
			// 
			// textBoxDirectors
			// 
			this.textBoxDirectors.AcceptsReturn = true;
			this.textBoxDirectors.AcceptsTab = true;
			this.textBoxDirectors.AllowDrop = true;
			this.textBoxDirectors.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxDirectors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDirectors.Location = new System.Drawing.Point(13, 291);
			this.textBoxDirectors.Multiline = true;
			this.textBoxDirectors.Name = "textBoxDirectors";
			this.textBoxDirectors.ReadOnly = true;
			this.textBoxDirectors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxDirectors.Size = new System.Drawing.Size(1094, 225);
			this.textBoxDirectors.TabIndex = 13;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1119, 634);
			this.Controls.Add(this.textBoxDirectors);
			this.Controls.Add(this.textBoxFilms);
			this.Controls.Add(this.buttonСancel);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxDirectorLastName);
			this.Controls.Add(this.textBoxDirectorFirstName);
			this.Controls.Add(this.labelAddDirector);
			this.Controls.Add(this.labelDirectors);
			this.Controls.Add(this.labelCountOfFilms);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.labelFilms);
			this.Name = "MainForm";
			this.Text = "Фильмы и режиссёры";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelFilms;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelCountOfFilms;
		private System.Windows.Forms.Label labelDirectors;
		private System.Windows.Forms.Label labelAddDirector;
		private System.Windows.Forms.TextBox textBoxDirectorFirstName;
		private System.Windows.Forms.TextBox textBoxDirectorLastName;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonСancel;
		private System.Windows.Forms.TextBox textBoxFilms;
		private System.Windows.Forms.TextBox textBoxDirectors;
	}
}

