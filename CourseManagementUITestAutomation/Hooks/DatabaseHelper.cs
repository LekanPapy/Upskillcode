using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementUITestAutomation.Hooks
{
    public class DatabaseHelper
    {
        string connectionString = "Data Source=KOLADETIAMI19E6\\SQLEXPRESS;Initial Catalog=CourseManagementSystem.Models.SchoolContext;Integrated Security=True;MultipleActiveResultSets=True";

        public void PopulatePersonTableWithStudentRecord()
        {
            string query = @"insert into Student(FirstName, LastName, City)
                             values('Olayinka', 'Lisa', 'London')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ClearStudentRecordInPersonTable()
        {
            string query = @"delete from Person where LastName = 'Wayne' and  FirstName = 'Rooney';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
