using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.Data.SqlClient;
using System.Configuration;
using System.Net.Http.Headers;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace AcademyDataSet
{
	public partial class MainForm : Form
	{
		Connector connector;
		Cache cache = null;

		public MainForm()
		{
			InitializeComponent();
			this.Location = new Point
				(
					(Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2), 
					(Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2) - 400
				);

			cache = new Cache();

			cache.AddTable("Directions", "direction_id,direction_name");
			cache.AddTable("Groups", "group_id,group_name,direction");
			cache.AddRelation("GroupsDirections", "Groups,direction", "Directions,direction_id");
			cache.PrintGroups();
			cache.PrintTable("Groups");

			AddItemsInComboBox(comboBoxGroups, "Groups", "group_name");
			AddItemsInComboBox(comboBoxDirections, "Directions", "direction_name");

			connector = new Connector(ConfigurationManager.ConnectionStrings["VPD_311_Import"].ConnectionString);
			//dataGridView.DataSource = connector.Select("*", "Groups");
			dataGridView.DataSource = connector.Select
				(
					"group_id, group_name, COUNT(stud_id) AS N'Количество студентов', direction_name",
					"Groups JOIN Students ON (group_id = [group]) \r\nJOIN Directions ON (direction = direction_id)\r\nGROUP BY group_id, group_name, direction_name"
				);
		}

		void AddItemsInComboBox(System.Windows.Forms.ComboBox comboBox, string table, string column)
		{

			comboBox.Items.Add("Все");
			for (int i = 0; i < cache.set.Tables[table].Rows.Count; i++)
			{
				comboBox.Items.Add(cache.set.Tables[table].Rows[i][column]);
			}
		}
	}
}
