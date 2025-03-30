using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace MoviesForms_HomeWork
{
	internal class Connector
	{
		readonly string CONNECTION_STRING;
		readonly SqlConnection connection;

		static public int NUM_FILMS;
		static readonly int PADDING = 70;

		public Connector() : this(ConfigurationManager.ConnectionStrings["Movies_VPD_311"].ConnectionString) { }

		public Connector(string connectionString)
		{
			this.CONNECTION_STRING = connectionString;
			this.connection = new SqlConnection(CONNECTION_STRING);
		}

		public string Select(string fields, string tables, string condition = "")
		{
			NUM_FILMS = 0;
			string info = "";
			string cmd = $"SELECT {fields} FROM {tables}";
			if (condition != "") cmd += $" WHERE {condition}";

			SqlCommand command = new SqlCommand(cmd, connection);

			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			if (reader.HasRows)
			{
				info += Border(reader.FieldCount);
				

				for (int i = 0; i < reader.FieldCount; i++) info += (reader.GetName(i).ToString().PadRight(PADDING));
				info += Environment.NewLine;

				info += Border(reader.FieldCount);
				

				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						info += reader[i].ToString().PadRight(PADDING);
						NUM_FILMS++;
					}
					info += Environment.NewLine;
				}

			}
			info += Border(reader.FieldCount);
			

			reader.Close();
			connection.Close();

			return info;
		}

		public void InsertDirector(string first_name, string last_name)
		{
			string check = $"SELECT director_id FROM Directors WHERE last_name = N'{last_name}' AND first_name = N'{first_name}'";
			SqlCommand check_query = new SqlCommand(check, connection);

			connection.Open();
			SqlDataReader reader = check_query.ExecuteReader();

			if (reader.HasRows)
			{
				new Warning().ShowDialog();
			}
			connection.Close();


			string query = $"INSERT Directors(first_name, last_name) VALUES(N'{first_name}', N'{last_name}')";
			string condition = $"last_name = N'{last_name}' AND first_name = N'{first_name}'";
			string cmd = $"IF NOT EXISTS (SELECT director_id FROM Directors WHERE {condition}) BEGIN {query} END";
			SqlCommand command = new SqlCommand(cmd, connection);

			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}

		public string Border(int fields_count, string symbol = "-")
		{
			string border = "";

			for (int i = 0; i < fields_count-1; i++)
			{
				for (int j = 0; j < PADDING; j++)
				{
					border += symbol;
				}
			}
			border += Environment.NewLine;

			return border;
		}
	}
}
