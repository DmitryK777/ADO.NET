using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace Academy
{
	public partial class MainForm : Form
	{
		Connector connector;

		Query[] queries = new Query[]
			{
				new Query
					(
						"DISTINCT stud_id, last_name, first_name, middle_name, birth_date, direction_name, group_name", 
						"Students, Groups, Directions",
						"group_id = [group] AND direction = direction_id",
						"stud_id, first_name, last_name, middle_name, birth_date, direction_name, group_name"
					),
				new Query
					(
						"group_id, group_name, COUNT(stud_id) AS students_count, direction_name", 
						"Students, Groups, Directions", 
						"direction = direction_id AND [group] = group_id",
						"group_id, group_name, direction_name"
					),
				new Query
					(
						"direction_id, direction_name, COUNT(DISTINCT group_id) AS groups_count, COUNT(stud_id) AS students_count", 
						"Directions, Groups, Students",
						"direction_id = direction AND group_id = [group]",
						"direction_id, direction_name"
					),
				new Query("*", "Disciplines"),
				new Query("*", "Teachers")
			};
		DataTable table;
		DataGridView[] tables;
		string[] status_messages = new string[]
			{
				"Количество студентов: ",
				"Количество групп: ",
				"Количество направлений: ",
				"Количество дисциплин: ",
				"Количество преподавателей: "
			};

		public MainForm()
		{
			InitializeComponent();
			this.Location = new Point((Screen.PrimaryScreen.Bounds.Width/2) - (this.Width/2), 100);

			tables = new DataGridView[]
			{
				dgvStudents,
				dgvGroups,
				dgvDirections,
				dgvDisciplines,
				dgvTeachers
			};

			connector = new Connector(ConfigurationManager.ConnectionStrings["VPD_311_Import"].ConnectionString);

			dgvStudents.DataSource = connector.Select("*", "Students");
			statusStripCountLabel.Text = $"Количество студентов: {dgvStudents.RowCount - 1}";
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = tabControl.SelectedIndex;
			tables[i].DataSource = connector.Select(queries[i].Columns, queries[i].Tables, queries[i].Condition, queries[i].GroupBy);
			statusStripCountLabel.Text = $"{status_messages[i]} {tables[i].RowCount - 1}";
		}

		private void comboBox_Groups_Directions_MouseClick(object sender, MouseEventArgs e)
		{
			comboBox_Groups_Directions.Items.Clear();
			Choice_Directions_In_Groups();
		}

		private void comboBox_Groups_Directions_SelectedIndexChanged(object sender, EventArgs e)
		{
			string choiced_direction = comboBox_Groups_Directions.Text;

			int i = tabControl.SelectedIndex;
			if (comboBox_Groups_Directions.SelectedIndex != 0)
			{
				comboBox_Groups_Directions.Items.Clear();
				dgvGroups.DataSource = connector.Select(queries[i].Columns, queries[i].Tables, $"{queries[i].Condition} AND direction_name = '{choiced_direction}'", queries[i].GroupBy);
				statusStripCountLabel.Text = $"{status_messages[i]} {tables[i].RowCount - 1}";
			}
			else
			{
				comboBox_Groups_Directions.Items.Clear();
				Choice_Directions_In_Groups();
				tables[i].DataSource = connector.Select(queries[i].Columns, queries[i].Tables, queries[i].Condition, queries[i].GroupBy);
			}
			statusStripCountLabel.Text = $"{status_messages[i]} {tables[i].RowCount - 1}";
		}

		
		private void comboBox_Students_Directions_MouseClick(object sender, MouseEventArgs e)
		{
			comboBox_Students_Directions.Items.Clear();
			Choice_Directions_In_Students();
		}

		private void comboBox_Students_Directions_SelectedIndexChanged(object sender, EventArgs e)
		{
			string choiced_direction = comboBox_Students_Directions.Text;

			int i = tabControl.SelectedIndex;
			if (comboBox_Students_Directions.SelectedIndex != 0)
			{
				comboBox_Students_Directions.Items.Clear();
				dgvStudents.DataSource = connector.Select(queries[i].Columns, queries[i].Tables, $"{queries[i].Condition} AND direction_name = '{choiced_direction}'", queries[i].GroupBy);
				statusStripCountLabel.Text = $"{status_messages[i]} {tables[i].RowCount - 1}";
			}
			else
			{
				comboBox_Students_Directions.Items.Clear();
				Choice_Directions_In_Students();
				tables[i].DataSource = connector.Select(queries[i].Columns, queries[i].Tables, queries[i].Condition, queries[i].GroupBy);
			}
			statusStripCountLabel.Text = $"{status_messages[i]} {tables[i].RowCount - 1}";
		}

		private void comboBox_Students_Groups_MouseClick(object sender, MouseEventArgs e)
		{
			comboBox_Students_Groups.Items.Clear();
			Choice_Groups_In_Students();
		}

		private void comboBox_Students_Groups_SelectedIndexChanged(object sender, EventArgs e)
		{
			string choiced_group = comboBox_Students_Groups.Text;

			int i = tabControl.SelectedIndex;
			if (comboBox_Students_Groups.SelectedIndex != 0)
			{
				comboBox_Students_Groups.Items.Clear();
				dgvStudents.DataSource = connector.Select(queries[i].Columns, queries[i].Tables, $"{queries[i].Condition} AND group_name = '{choiced_group}'", queries[i].GroupBy);
				statusStripCountLabel.Text = $"{status_messages[i]} {tables[i].RowCount - 1}";
			}
			else
			{
				comboBox_Students_Groups.Items.Clear();
				Choice_Groups_In_Students();
				tables[i].DataSource = connector.Select(queries[i].Columns, queries[i].Tables, queries[i].Condition, queries[i].GroupBy);
			}
			statusStripCountLabel.Text = $"{status_messages[i]} {tables[i].RowCount - 1}";
		}

		private void checkBox_Empty_Groups_CheckedChanged(object sender, EventArgs e)
		{
			int i = tabControl.SelectedIndex;
			if (checkBox_Empty_Groups.Checked)
			{
				dgvGroups.DataSource = connector.Select("group_id, group_name", "Groups", "group_id NOT IN (SELECT [group] FROM Students)");
				statusStripCountLabel.Text = $"{status_messages[i]} {tables[i].RowCount - 1}";
			}
			else
			{
				comboBox_Groups_Directions.Items.Clear();
				Choice_Directions_In_Groups();
				tables[i].DataSource = connector.Select(queries[i].Columns, queries[i].Tables, queries[i].Condition, queries[i].GroupBy);
			}
			statusStripCountLabel.Text = $"{status_messages[i]} {tables[i].RowCount - 1}";
		}

		private void checkBox_Empty_Directions_CheckedChanged(object sender, EventArgs e)
		{
			int i = tabControl.SelectedIndex;
			if (checkBox_Empty_Directions.Checked)
			{
				dgvDirections.DataSource = connector.Select("direction_id, direction_name", "Directions", "direction_id NOT IN (SELECT [direction] FROM Groups)");
				statusStripCountLabel.Text = $"{status_messages[i]} {tables[i].RowCount - 1}";
			}
			else
			{
				comboBox_Groups_Directions.Items.Clear();
				Choice_Directions_In_Groups();
				tables[i].DataSource = connector.Select(queries[i].Columns, queries[i].Tables, queries[i].Condition, queries[i].GroupBy);
			}
			statusStripCountLabel.Text = $"{status_messages[i]} {tables[i].RowCount - 1}";
		}

		public void Choice_Directions_In_Groups()
		{
			comboBox_Groups_Directions.Items.Add("Все");
			table = connector.Select("direction_name", "Directions");

			foreach (DataRow row in table.Rows)
			{
				var cells = row.ItemArray;
				foreach (object cell in cells)
				{
					if (cell != null) comboBox_Groups_Directions.Items.Add(cell);
				}
			}
		}

		
		public void Choice_Directions_In_Students()
		{
			comboBox_Students_Directions.Items.Add("Все");
			table = connector.Select("direction_name", "Directions");

			foreach (DataRow row in table.Rows)
			{
				var cells = row.ItemArray;
				foreach (object cell in cells)
				{
					if (cell != null) comboBox_Students_Directions.Items.Add(cell);
				}
			}
		}

		public void Choice_Groups_In_Students()
		{
			comboBox_Students_Groups.Items.Add("Все");
			table = connector.Select("group_name", "Groups");

			foreach (DataRow row in table.Rows)
			{
				var cells = row.ItemArray;
				foreach (object cell in cells)
				{
					if (cell != null) comboBox_Students_Groups.Items.Add(cell);
				}
			}
		}

		
	}
}
