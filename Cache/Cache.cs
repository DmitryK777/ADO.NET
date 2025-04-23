﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Timers;

using System.Data.SqlClient;



namespace CacheLibrary
{
	public class Cache
	{
		readonly string CONNECTION_STRING = "";
		SqlConnection connection = null;
		DataSet set = null; // Набор таблиц



		public DataSet Set { get => set; }

		public Cache(string connection_string)
		{
			//CONNECTION_STRING = ConfigurationManager.ConnectionStrings["VPD_311_Import"].ConnectionString;
			CONNECTION_STRING = connection_string;
			connection = new SqlConnection(CONNECTION_STRING);

			// 1) Создаём DataSet
			set = new DataSet();

			Console.WriteLine(CONNECTION_STRING);

		}

		public void AddTable(string table, string columns)
		{
			// 2.1) Добавляем поля таблицу в DataSet
			set.Tables.Add(table);

			// 2.2) Добавляем поля (столбики) в таблицу
			string[] a_columns = columns.Split(',');
			for (int i = 0; i < a_columns.Length; i++)
			{
				set.Tables[table].Columns.Add(a_columns[i]);
			}

			// 2.3) Определяем какое поле будет первичным ключом
			set.Tables[table].PrimaryKey =
				new DataColumn[] { set.Tables[table].Columns[0] };

			string cmd = $"SELECT {columns} FROM {table}";
			SqlDataAdapter adapter = new SqlDataAdapter(cmd, connection);
			adapter.Fill(set.Tables[table]);
			Print(table);
		}

		

		public void AddRelation(string relation_name, string child, string parent)
		{
			set.Relations.Add
				(
					relation_name,
					set.Tables[parent.Split(',')[0]].Columns[parent.Split(',')[1]],
					set.Tables[child.Split(',')[0]].Columns[child.Split(',')[1]]
				);
		}

		/*
		void LoadGroupsRelatedData()
		{
			

			// 2) Добавляем таблицы в DataSet
			const string dsTable_Directions = "Directions";
			const string dst_col_direction_id = "direction_id";
			const string dst_col_direction_name = "direction_name";
			// 2.1) Добавляем поля таблицу в DataSet
			set.Tables.Add(dsTable_Directions);

			// 2.2) Добавляем поля (столбики) в таблицу
			set.Tables[dsTable_Directions].Columns.Add(dst_col_direction_id, typeof(byte));
			set.Tables[dsTable_Directions].Columns.Add(dst_col_direction_name, typeof(string));

			// 2.3) Определяем какое поле будет первичным ключом
			set.Tables[dsTable_Directions].PrimaryKey =
				new DataColumn[] { set.Tables[dsTable_Directions].Columns[dst_col_direction_id] };


			// 2.4) Следующая таблица
			const string dsTable_Groups = "Groups";
			const string dst_Groups_col_group_id = "group_id";
			const string dst_Groups_col_group_name = "group_name";
			const string dst_Groups_col_group_direction = "direction";
			set.Tables.Add(dsTable_Groups);
			set.Tables[dsTable_Groups].Columns.Add(dst_Groups_col_group_id, typeof(int));
			set.Tables[dsTable_Groups].Columns.Add(dst_Groups_col_group_name, typeof(string));
			set.Tables[dsTable_Groups].Columns.Add(dst_Groups_col_group_direction, typeof(byte));
			set.Tables[dsTable_Groups].PrimaryKey =
				new DataColumn[] { set.Tables[dsTable_Groups].Columns[0] };

			// 3) Строим связи между таблицами
			set.Relations.Add
				(
					"GroupsDirections",
					set.Tables[dsTable_Directions].Columns[dst_col_direction_id], // Первичный ключ
					set.Tables[dsTable_Groups].Columns[dst_Groups_col_group_direction] // Внешний ключ
				);

			// 4) Загрузка данных в DataSet
			string directionsCmd = "SELECT * FROM Directions";
			string groupsCmd = "SELECT * FROM Groups";

			SqlDataAdapter directionsAdapter = new SqlDataAdapter(directionsCmd, connection);
			SqlDataAdapter groupsAdapter = new SqlDataAdapter(groupsCmd, connection);

			directionsAdapter.Fill(set.Tables[dsTable_Directions]);
			groupsAdapter.Fill(set.Tables[dsTable_Groups]);

			Print("Directions");
			Print("Groups");

		}
		*/

		public void Print(string table)
		{


			Console.WriteLine("\n====================================================================\n");
			for (int i = 0; i < set.Tables[table].Columns.Count; i++)
				Console.Write(set.Tables[table].Columns[i].Caption + "\t");
			Console.WriteLine("\n--------------------------------------------------------------------\n");

			int number_of_parents = set.Tables[table].ParentRelations.Count;
			for (int i = 0; i < number_of_parents; i++)
			{
				Console.WriteLine(set.Tables[table].ParentRelations[i].ToString());
			}
			Console.WriteLine(set.Tables[table].ParentRelations.Contains("GroupsDirections"));
			for (int i = 0; i < set.Tables[table].Rows.Count; i++)
			{
				//Console.Write(GroupsRelatedData.Tables[table].Rows[i]+ ":\t");
				for (int j = 0; j < set.Tables[table].Columns.Count; j++)
				{

					if
						(
							HasParents(table) &&
							set.Tables[table].ParentRelations[0].ChildColumns.Contains(set.Tables[table].Columns[j])
						)
					{
						string parent_relation_name = !HasParents(table) ? "" :
						$"{set.Tables[table].TableName}{set.Tables[table].Columns[j].ColumnName}s";
						Console.WriteLine
							(
								//set.Tables[table].ParentRelations[0].ParentColumns[$"{set.Tables[table].Columns[j].ColumnName}_name"]
								set.Tables[table].Rows[i].GetParentRow(parent_relation_name)[$"{set.Tables[table].Columns[j].ColumnName}_name"]
							);
					}
					else
						Console.Write(set.Tables[table].Rows[i][j] + "\t\t");

					/*
					string parent_relation_name = !HasParents(table) ? "" :
						$"{set.Tables[table].TableName}{set.Tables[table].Columns[j].ColumnName}s";

					if (set.Tables[table].ParentRelations.Contains(parent_relation_name) && )
						Console.WriteLine
							(
								set.
								Tables[table].
								Rows[i].
								GetParentRow(parent_relation_name)[$"{set.Tables[table].Columns[i].ColumnName}_name"]
							);
					else 
					*/



				}
				Console.WriteLine();
			}
			Console.WriteLine("\n====================================================================\n");
		}

		public bool HasParents(string table)
		{
			return set.Tables[table].ParentRelations.Count > 0;
		}

		public void PrintGroups()
		{
			Console.WriteLine("\n====================================================================\n");
			string table = "Groups";
			for (int i = 0; i < set.Tables[table].Columns.Count; i++)
				Console.Write(set.Tables[table].Columns[i].Caption + "\t");
			Console.Write("\tdirection_name");
			Console.WriteLine("\n--------------------------------------------------------------------\n");
			for (int i = 0; i < set.Tables[table].Rows.Count; i++)
			{
				for (int j = 0; j < set.Tables[table].Columns.Count; j++)
				{
					Console.Write(set.Tables[table].Rows[i][j] + "\t\t");

				}
				Console.Write(set.Tables[table].Rows[i].GetParentRow("GroupsDirections")["direction_name"]);
				Console.WriteLine();
			}
			Console.WriteLine("\n====================================================================\n");
		}
	}
}

