using System;
using System.Data.SQLite;

namespace SQLiteDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Database databaseObject = new Database();

			// INSERT INTO DATABASE

			string query = "INSERT INTO users (`username`, `password`, `company`, `email`, `role`, `client_code`) VALUES (@v1, @v2, @v3, @v4, @v5, @v6)";
			SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
			databaseObject.OpenConnection();
			myCommand.Parameters.AddWithValue("@v1", "Vardas");
			myCommand.Parameters.AddWithValue("@v2", "123-pdY");
			myCommand.Parameters.AddWithValue("@v3", "Salda");
			myCommand.Parameters.AddWithValue("@v4", "vardas@salda.lt");
			myCommand.Parameters.AddWithValue("@v5", 1);
			myCommand.Parameters.AddWithValue("@v6", "TP4");
			var result = myCommand.ExecuteNonQuery();
			databaseObject.CloseConection();
			
			Console.WriteLine("Rows Added : {0}", result);
			Console.ReadKey();
		}
	}
}