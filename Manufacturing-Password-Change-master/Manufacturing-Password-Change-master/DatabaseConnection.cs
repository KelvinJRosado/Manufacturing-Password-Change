using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Manufacturing_Password_Change_master

{
	class DatabaseConnection
	{
		private SqlConnection connection;

		public DatabaseConnection()
		{
			connection = new SqlConnection("Data Source=on-campus-navigation.caqb3uzoiuo3.us-east-1.rds.amazonaws.com,1433;"
				+ "user id=Android; password=password;"
				+ "database=Manufacturing");

			PrintQueryResult(SelectQuery("SELECT * FROM Employee;"));

		}

		//Executes a select query and returns a list filled with arrays of columns
		public List<String[]> SelectQuery(String query)
		{

			SqlCommand command = new SqlCommand(query, connection);

			try
			{
				//Open database connection
				connection.Open();
				List<String[]> result = new List<String[]>();

				//Execute the query and populate list with results
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					String[] columns = new String[reader.VisibleFieldCount];
					for(int i = 0; i < reader.VisibleFieldCount; i++)
					{
						columns[i] = reader[i].ToString();
					}
					result.Add(columns);
				}

				return result;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
				return null;
			}
		}

		//Prints the result of a query to the console; Debug Only
		public void PrintQueryResult(List<String[]> result)
		{
			foreach (String[] row in result)
			{

				String ss = "";
				for (int i = 0; i < row.Length; i++)
				{
					ss += row[i] + " |" + "\t";
				}
				ss = ss.Substring(0, ss.Length - 1);
				Console.WriteLine(ss);
			}
		}

	}
}
