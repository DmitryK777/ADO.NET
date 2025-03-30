using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Academy
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

			if(reader.HasRows)
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
					for (int i = 0;i < reader.FieldCount; i++)
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


		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();

		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();

	}
}
