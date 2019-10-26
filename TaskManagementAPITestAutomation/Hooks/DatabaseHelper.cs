using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementAPITestAutomation.Hooks
{
    public class DatabaseHelper
    {
        string connectionString = ConfigurationManager.AppSettings["connectionString"];

        public void PopulateProjectsTableWithRecord()
        {
            string query = @"insert into Projects([Name]) values('Performance Testing');";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void PopulateProjectsTableWithMultipleRecords()
        {
            string firstQuery = @"insert into Projects([Name]) values('Performance Testing');";
            string secondQuery = @"insert into Projects([Name]) values('Geography');";
            string thirdQuery = @"insert into Projects([Name]) values('Mobile Testing');";
            string fourthQuery = @"insert into Projects([Name]) values('Computer Science');";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = firstQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = secondQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = thirdQuery;
                    command.ExecuteNonQuery();

                    command.CommandText = fourthQuery;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ClearProjectsTable()
        {
            string query = @"delete from Projects;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public int SelectAProjectRecord()
        {
            string sqlQuery = "Select Id from Projects;";
            int id = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    id = (Int32)(command.ExecuteScalar());
                }
            }
            return id;
         }
    }    
}
