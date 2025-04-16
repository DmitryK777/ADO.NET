using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AcademyDataSet
{
	internal class Connector
	{
		readonly string CONNECTION_STRING;
		SqlConnection connection;

		public Connector(string connectionString)
		{
			CONNECTION_STRING = connectionString;
			connection = new SqlConnection(CONNECTION_STRING);
			//AllocConsole();
			//Console.WriteLine(CONNECTION_STRING);
		}

		public DataTable Select(string columns, string tables, string condition = "", string group_by = "")
		{
			DataTable table = null;
			string cmd = $"Select {columns} FROM {tables}";
			if (condition != "") cmd += $" WHERE {condition}";
			if (group_by != "") cmd += $" GROUP BY {group_by}";

			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();

			SqlDataReader reader = command.ExecuteReader();

			if (reader.HasRows)
			{
				//1) Создаём таблицу
				table = new DataTable();

				//2) Добавляем столбики в таблицу
				for (int i = 0; i < reader.FieldCount; i++)
				{
					table.Columns.Add(reader.GetName(i));
				}

				// 3) Добавляем строки в таблицу
				while (reader.Read())
				{
					//4) Строка создаётся через нашу таблицу
					DataRow row = table.NewRow();
					//5) Pfuhe;frtv lfyyst d cnhjre
					for (int i = 0; i < reader.FieldCount; i++)
					{
						row[i] = reader[i];
					}

					//6) Добавляем строку в таблицу
					table.Rows.Add(row);
				}
			}

			reader.Close();
			connection.Close();

			return table;
		}

		public Dictionary<string, int> GetDictionary(string table)
		{
			Dictionary<string, int> dictionary = null;
			string id_column = table.ToLower().Remove(table.Length - 1) + "_id";
			string name_column = table.ToLower().Remove(table.Length - 1, 1) + "_name";
			string cmd = $"SELECT {name_column}, {id_column} FROM {table}";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				dictionary = new Dictionary<string, int>();
				while (reader.Read())
				{
					dictionary[reader[0].ToString()] = Convert.ToInt32(reader[1]);
				}
			}

			reader.Close();
			connection.Close();

			return dictionary;
		}

		
	}
}
