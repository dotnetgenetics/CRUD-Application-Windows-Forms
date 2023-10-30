using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CRUDApplicationWindowsForms.DataAccess
{
   public class DALHelper
   {
      #region Variable Declarations

      private SqlDataAdapter myAdapter;
      private SqlConnection myConn;
      private string connectionString;

      #endregion

      #region Constructor

      public DALHelper()
      {
         connectionString = ConfigurationManager.ConnectionStrings["TestDatabase"].ConnectionString;
         myAdapter = new SqlDataAdapter();
         myConn = new SqlConnection(connectionString);
      }

      #endregion

      private SqlConnection OpenConnection()
      {
         if (myConn.State == ConnectionState.Closed || myConn.State == ConnectionState.Broken)
         {
            myConn.Open();
         }

         return myConn;
      }

      private SqlConnection CloseConnection()
      {
         if (myConn.State == ConnectionState.Open || myConn.State == ConnectionState.Broken)
         {
            myConn.Close();
         }

         return myConn;
      }

      #region Execute Scalar

      public int ExecuteScalar(String _query)
      {
         int id = -1;
         SqlCommand command = myConn.CreateCommand();

         try
         {
            command.Connection = OpenConnection();
            command.CommandText = _query;

            object objId = command.ExecuteScalar();
            if (objId != DBNull.Value && objId != null)
            {
               id = (int)objId;
            }
         }
         catch (Exception ex)
         {
            //throw exception or pass exception to caller
         }
         finally
         {
            CloseConnection();
            command.Dispose();
            myConn.Dispose();
         }

         return id;
      }

      public int ExecuteScalar(String _query, SqlParameter[] sqlParameter)
      {
         int id = -1;
         SqlCommand command = myConn.CreateCommand();

         try
         {
            command.Connection = OpenConnection();
            command.Parameters.AddRange(sqlParameter);
            command.CommandText = _query;

            object objId = command.ExecuteScalar();
            if (objId != DBNull.Value && objId != null)
            {
               id = (int)objId;
            }
         }
         catch (Exception ex)
         {
            //throw exception or pass exception to caller
         }
         finally
         {
            CloseConnection();
            command.Dispose();
            myConn.Dispose();
         }

         return id;
      }

      /// <summary>
      /// Return bool instead of int
      /// </summary>        
      public bool BoolExecuteScalar(String _query, SqlParameter[] sqlParameter)
      {
         bool isExisting = false;
         SqlCommand command = myConn.CreateCommand();

         try
         {
            command.Connection = OpenConnection();
            command.Parameters.AddRange(sqlParameter);
            command.CommandText = _query;

            object objId = command.ExecuteScalar();
            if (objId != DBNull.Value && objId != null)
            {
               isExisting = true;
            }
         }
         catch (Exception ex)
         {
            //throw exception or pass exception to caller
         }
         finally
         {
            CloseConnection();
            command.Dispose();
            myConn.Dispose();
         }

         return isExisting;
      }

      #endregion

      #region Execute Select

      public DataSet ExecuteSelectQuery(String _query)
      {
         DataSet ds = new DataSet();
         SqlCommand command = myConn.CreateCommand();

         try
         {
            command.Connection = OpenConnection();
            command.CommandText = _query;

            myAdapter.SelectCommand = command;
            myAdapter.Fill(ds);
         }
         catch (Exception ex)
         {
            //throw exception or pass exception to caller
         }
         finally
         {
            CloseConnection();
            command.Dispose();
            myConn.Dispose();
         }

         return ds;
      }

      public DataTable ExecuteSelectQueryDataTable(String _query)
      {
         DataTable dt = new DataTable();
         SqlCommand command = myConn.CreateCommand();

         try
         {
            command.Connection = OpenConnection();
            command.CommandText = _query;

            myAdapter.SelectCommand = command;
            myAdapter.Fill(dt);
         }
         catch (Exception ex)
         {
            //throw exception or pass exception to caller
         }
         finally
         {
            CloseConnection();
            command.Dispose();
            myConn.Dispose();
         }

         return dt;
      }

      public DataTable ExecuteSelectQueryDataTable(String _query, SqlParameter[] sqlParameter)
      {
         DataTable dt = new DataTable();
         SqlCommand command = myConn.CreateCommand();

         try
         {
            command.Connection = OpenConnection();
            command.Parameters.AddRange(sqlParameter);
            command.CommandText = _query;

            myAdapter.SelectCommand = command;
            myAdapter.Fill(dt);
         }
         catch (Exception ex)
         {
            //throw exception or pass exception to caller
         }
         finally
         {
            CloseConnection();
            command.Dispose();
            myConn.Dispose();
         }

         return dt;
      }

      public DataSet ExecuteSelectQuery(String _query, SqlParameter[] sqlParameter)
      {
         DataSet ds = new DataSet();
         SqlCommand command = myConn.CreateCommand();

         try
         {
            command.Connection = OpenConnection();
            command.Parameters.AddRange(sqlParameter);
            command.CommandText = _query;

            myAdapter.SelectCommand = command;
            myAdapter.Fill(ds);
         }
         catch (Exception ex)
         {
            //throw exception or pass exception to caller
         }
         finally
         {
            CloseConnection();
            command.Dispose();
            myConn.Dispose();
         }

         return ds;
      }

      #endregion

      #region Execute Non Query

      public void ExecuteNonQuery(string query)
      {
         SqlCommand command = myConn.CreateCommand();

         try
         {
            command.Connection = OpenConnection();
            command.CommandText = query;
            command.CommandTimeout = 0;
            command.ExecuteNonQuery();
         }
         catch (Exception e)
         {
            //throw exception or pass exception to caller
         }
         finally
         {
            CloseConnection();
            command.Dispose();
            myConn.Dispose();
         }
      }

      public void ExecuteNonQuery(string query, SqlParameter[] sqlParameters)
      {
         SqlCommand command = myConn.CreateCommand();

         try
         {
            command.Connection = OpenConnection();
            command.Parameters.AddRange(sqlParameters);
            command.CommandText = query;
            command.CommandTimeout = 0;
            command.ExecuteNonQuery();
         }
         catch (Exception e)
         {
            //throw exception or pass exception to caller
         }
         finally
         {
            CloseConnection();
            command.Dispose();
            myConn.Dispose();
         }
      }

      #endregion
   }
}