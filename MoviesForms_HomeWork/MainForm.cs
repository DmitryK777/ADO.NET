using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesForms_HomeWork
{
	public partial class MainForm : Form
	{
		Connector connector = new Connector();

		public MainForm()
		{
			InitializeComponent();

			textBoxFilms.Text = connector.Select("*", "Movies");
			textBoxDirectors.Text = connector.Select("*", "Directors");
		}

		

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (textBoxDirectorFirstName.Text != "Имя" && 
				textBoxDirectorFirstName.Text !="" && 
				textBoxDirectorLastName.Text != "Фамилия" && 
				textBoxDirectorLastName.Text != "")
			{
				
				connector.InsertDirector
					(textBoxDirectorFirstName.Text.ToString().Trim(), textBoxDirectorLastName.Text.ToString().Trim());
				textBoxDirectors.Text = connector.Select("*", "Directors");
			}
			else
			{
				new Alarm().ShowDialog();
			}
		}

		private void buttonСancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
