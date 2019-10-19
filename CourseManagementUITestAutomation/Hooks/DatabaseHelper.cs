using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace CourseManagementUITestAutomation.Hooks
{
    public class DatabaseHelper
    {
        //string connectionString = "Data Source=KOLADETIAMI19E6\\SQLEXPRESS;Initial Catalog=CourseManagementSystem.Models.SchoolContext;Integrated Security=True;MultipleActiveResultSets=True";
        string connectionString = ConfigurationManager.AppSettings["connectionString"];

        public void PopulatePersonTableWithStudentRecord()
        {
            string query = @"insert into Person(LastName, FirstName, EnrollmentDate, Discriminator)
                            values('WayneTest11', 'RooneyTest11', getdate(), 'Student');";
            
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
            string query = @"delete from Person where LastName like 'Wayne%'  and  FirstName like 'Rooney%';";
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
