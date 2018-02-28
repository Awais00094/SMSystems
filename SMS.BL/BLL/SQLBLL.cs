using SMS.BL.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BL.BLL
{
    public class SQLBLL
    {
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;

        private void OpenConnection()
        {
            try
            {
                string connectionString = "data source=.;initial catalog=SMS;user id=sa;password=Pakistan1947;";

                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CloseConnection()
        {
            try
            {
                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InitializeCommand()
        {
            try
            {
                OpenConnection();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DisposeCommand()
        {
            try
            {
                CloseConnection();
                command.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ConvertEmptyValuesToDBNull(Hashtable values)
        {
            List<object> keysToDbNull = new List<object>();

            foreach (DictionaryEntry entry in values)
            {
                if (entry.Value == null || (entry.Value is String && String.IsNullOrEmpty((String)entry.Value)))
                {
                    keysToDbNull.Add(entry.Key);
                }
            }

            foreach (object key in keysToDbNull)
            {
                values[key] = DBNull.Value;
            }
        }

        public SMSError RunCommand(Hashtable inputParameters,
                                                string inputDataTableName,
                                                DataTable inputDataTable,
                                                Hashtable outputParameters,
                                                string commandText)
        {
            Hashtable OutputResults = new Hashtable();

            try
            {
                InitializeCommand();

                ConvertEmptyValuesToDBNull(inputParameters);
                ConvertEmptyValuesToDBNull(outputParameters);

                foreach (DictionaryEntry entry in inputParameters)
                {
                    command.Parameters.AddWithValue(entry.Key.ToString(), entry.Value);
                }

                if (inputDataTableName != string.Empty)
                    command.Parameters.AddWithValue("@" + inputDataTableName, inputDataTable);

                foreach (DictionaryEntry entry in outputParameters)
                {
                    command.Parameters.AddWithValue(entry.Key.ToString(), entry.Value);
                    command.Parameters[entry.Key.ToString()].Direction = ParameterDirection.InputOutput;
                }

                command.CommandText = commandText;
                command.ExecuteNonQuery();

                foreach (DictionaryEntry entry in outputParameters)
                {
                    OutputResults.Add(entry.Key.ToString(), command.Parameters[entry.Key.ToString()].Value.ToString());
                }
                DisposeCommand();
                return SMSError.SUCCESS;

            }
            catch (Exception ex) { throw ex; }
        }

        public DataSet GetDataSet(Hashtable inputParameters, string commandText)
        {
            try
            {
                InitializeCommand();
                ConvertEmptyValuesToDBNull(inputParameters);

                foreach (DictionaryEntry entry in inputParameters)
                    command.Parameters.AddWithValue(entry.Key.ToString(), entry.Value);

                command.CommandText = commandText;
                dataAdapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds);
                DisposeCommand();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SMSError RunCommand(string inputDataTableName, DataTable inputDataTable, string commandText)
        {
            try
            {
                InitializeCommand();

                command.Parameters.AddWithValue("@" + inputDataTableName, inputDataTable);
                command.CommandText = commandText;
                command.ExecuteNonQuery();
                DisposeCommand();

                return SMSError.SUCCESS;
            }
            catch (Exception ex) { throw ex; }
        }

        public SMSError RunCommand(Hashtable inputParameters, string commandText)
        {
            try
            {
                InitializeCommand();
                ConvertEmptyValuesToDBNull(inputParameters);

                foreach (DictionaryEntry entry in inputParameters)
                    command.Parameters.AddWithValue(entry.Key.ToString(), entry.Value);

                command.CommandText = commandText;
                command.ExecuteNonQuery();
                DisposeCommand();

                return SMSError.SUCCESS;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}