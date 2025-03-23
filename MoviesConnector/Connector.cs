using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MoviesConnector
{
	internal class Connector
	{
		readonly string CONNECTION_STRING;
		readonly SqlConnection connection;
		static readonly int PADDING = 33;

		public Connector(string connection_string)
		{
			this.CONNECTION_STRING = connection_string;
			this.connection = new SqlConnection(CONNECTION_STRING);
			Console.WriteLine(CONNECTION_STRING);
		}

		public void Select(string cmd)
		{
			Console.WriteLine("--------------------------------------------------");
			// 1) Создаём подключение к базе
			//SqlConnection connection = new SqlConnection(CONNECTION_STRING);

			// 2) Создаём команду которую хотим выполнить на Сервере
			//string cmd = "SELECT * FROM Directors";
			//string cmd = "SELECT * FROM Movies";
			SqlCommand command = new SqlCommand(cmd, connection);

			// 3) Получаем результаты запроса с Сервера
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			// 4) Обрабатываем результаты запроса
			if (reader.HasRows)
			{
				
				Border(reader.FieldCount);
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader.GetName(i).ToString().PadRight(PADDING));
				Console.WriteLine();
				Border(reader.FieldCount);

				while (reader.Read())
				{
					//Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader[i].ToString().PadRight(PADDING));
					}
					Console.WriteLine();
				}
			}
			Border(reader.FieldCount);

			// 5) Закрываем поток и соединение с сервером
			reader.Close();
			connection.Close();
			Console.WriteLine("--------------------------------------------------");
			Console.WriteLine();
		}

		void Border(int fields_count, string symbol = "-")
		{
			for (int i = 0; i < fields_count; i++)
			{
				for(int j = 0; j < PADDING; j++)
				{
					Console.Write(symbol);
				}
			}
			Console.WriteLine();
		}
	}
}
