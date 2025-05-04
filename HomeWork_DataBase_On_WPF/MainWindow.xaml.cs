using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


using System.Data.SqlClient;
using System.Configuration;


namespace HomeWork_DataBase_On_WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Cache cache;
		String CONNECTION_STRING = "";
		public MainWindow()
		{
			InitializeComponent();

			AllocConsole();


			/*
			// 1) Создаём DataSet

			cache = new Cache(ConfigurationManager.ConnectionStrings["VPD_311_Import"].ConnectionString);
			

			//set = new DataSet("GroupsRelatedData");

			cache.AddTable("Directions", "direction_id,direction_name");
			cache.AddTable("Groups", "group_id,group_name,direction");
			cache.AddRelation("GroupsDirections", "Groups,direction", "Directions,direction_id");
			cache.PrintGroups();
			//cache.Print("Groups");
			//LoadGroupsRelatedData();

			Console.WriteLine(cache.HasParents("Directions"));
			Console.WriteLine(cache.HasParents("Groups"));

			cbDirections.DataSource = cache.Set.Tables["Directions"];
			//cbDirections.DataContext = cache.Set.Tables["Directions"];
			cbDirections.ValueMember = "direction_id";
			cbDirections.DisplayMember = "direction_name";

			cbGroups.DataSource = cache.Set.Tables["Groups"];
			//cbGroups.DataContext = cache.Set.Tables["Groups"];
			cbGroups.ValueMember = "group_id";
			cbGroups.DisplayMember = "group_name";
			*/

		}

		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();

		private void cbDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			object selectedValue = (sender as ComboBox).SelectedValue;
			string filter = $"direction = {selectedValue.ToString()}";
			Console.WriteLine(filter);
			cache.Set.Tables["Groups"].DefaultView.RowFilter = filter;
		}
	}
}
