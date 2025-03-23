﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

using System.Data.SqlClient; // ADO.NET classes

namespace ADO.NET
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello ADO");

			const int PADDING = 33;

			const string CONNECTION_STRING = 
				"Data Source = (localdb)\\MSSQLLocalDB;" + 
				"Initial Catalog = Movies_VPD_311;" +
				"Integrated Security = True;" +
				"Connect Timeout = 30; Encrypt = False;" +
				"TrustServerCertificate = False;" +
				"ApplicationIntent = ReadWrite;" +
				"MultiSubnetFailover = False";
			Console.WriteLine(CONNECTION_STRING);

			// 1) Создаём подключение к базе
			SqlConnection connection = new SqlConnection(CONNECTION_STRING);

			// 2) Создаём команду которую хотим выполнить на Сервере
			//string cmd = "SELECT * FROM Directors";
			string cmd = "SELECT * FROM Movies";
			SqlCommand command = new SqlCommand(cmd, connection);

			// 3) Получаем результаты запроса с Сервера
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			// 4) Обрабатываем результаты запроса
			if(reader.HasRows)
			{
				for(int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader.GetName(i).ToString().PadRight(PADDING));
				Console.WriteLine();

				while(reader.Read())
				{
					//Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader[i].ToString().PadRight(PADDING));
					}
					Console.WriteLine();
				} 
			}

			// 5) Закрываем поток и соединение с сервером
			reader.Close();
			connection.Close();
		}
	}
}
