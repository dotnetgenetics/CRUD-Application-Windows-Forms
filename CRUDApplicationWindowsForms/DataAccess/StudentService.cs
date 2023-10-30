using CRUDApplicationWindowsForms.Model;
using System.Data;
using System.Data.SqlClient;

namespace CRUDApplicationWindowsForms.DataAccess
{
   public class StudentService
   {
      //members
      private DALHelper helper;
      private DataTable dtStudent;
      private SqlParameter[] parameter;
      private string query;

      /// <summary>
      /// Save student record
      /// </summary>
      /// <param name="student"></param>
      public void SaveStudent(Student student)
      {
         helper = new DALHelper();
         query = "Insert Into Students(Name,Age,Address,Contact) "
         + " Values (@Name,@Age, @Address,@Contact)";
         parameter = new SqlParameter[4];
         parameter[0] = new SqlParameter("@Name", SqlDbType.VarChar) { Value = student.Name };
         parameter[1] = new SqlParameter("@Age", SqlDbType.Int) { Value = student.Age };
         parameter[2] = new SqlParameter("@Address", SqlDbType.VarChar) { Value = student.Address };
         parameter[3] = new SqlParameter("@Contact", SqlDbType.VarChar) { Value = student.Contact };
         helper.ExecuteNonQuery(query, parameter);
      }

      /// <summary>
      /// Edit Student Record
      /// </summary>
      /// <param name="student"></param>
      public void UpdateStudent(Student student)
      {
         helper = new DALHelper();
         query = "Update Students set Name=@Name,Age=@Age,Address=@Address,Contact=@Contact Where ID=@ID";
         parameter = new SqlParameter[5];
         parameter[0] = new SqlParameter("@Name", SqlDbType.VarChar) { Value = student.Name };
         parameter[1] = new SqlParameter("@Age", SqlDbType.Int) { Value = student.Age };
         parameter[2] = new SqlParameter("@Address", SqlDbType.VarChar) { Value = student.Address };
         parameter[3] = new SqlParameter("@Contact", SqlDbType.VarChar) { Value = student.Contact };
         parameter[4] = new SqlParameter("@ID", SqlDbType.Int) { Value = student.ID };
         helper.ExecuteNonQuery(query, parameter);
      }

      /// <summary>
      /// Delete Student Record
      /// </summary>
      /// <param name="student"></param>
      public void DeleteStudent(Student student)
      {
         helper = new DALHelper();
         query = "DELETE FROM Students WHERE ID=@id";
         parameter = new SqlParameter[1];
         parameter[0] = new SqlParameter("@id", SqlDbType.Int) { Value = student.ID };
         helper.ExecuteNonQuery(query, parameter);
      }

      /// <summary>
      /// Fetch current record
      /// </summary>
      /// <returns></returns>
      public DataTable Fetch()
      {
         helper = new DALHelper();
         dtStudent = new DataTable();
         query = "Select * from Students";
         dtStudent = helper.ExecuteSelectQueryDataTable(query);
         return dtStudent;
      }

      //TODO: Add method with FetchList()
      //wherein the return type is type list
   }
}
