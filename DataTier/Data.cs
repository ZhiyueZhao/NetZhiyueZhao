using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DataTier
{
    public abstract class Data
    {
        #region Attributes

        private OleDbConnection _connection;
        private OleDbDataAdapter _adapter;
        private OleDbCommandBuilder _commandBuilder;
        private DataSet _dataSet;
        private string _connectionString;
        private string _tableName;
        private string _selectQuery;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs an new Data object.
        /// </summary>
        /// <param name="connectionString">The connection string to the data source.</param>
        /// <param name="tableName">The name of the table added to the dataset.</param>
        /// <param name="selectQuery">The Select query for the SelectCommand.</param>
        public Data(string connectionString, string tableName, string selectQuery)
        {
            _connectionString = connectionString;
            _tableName = tableName;
            _selectQuery = selectQuery;

            // 1. Establishes a connection to the database
            _connection = new OleDbConnection(_connectionString);

            //open the connection
            _connection.Open();

            // 2.Generates INSERT, UPDATE and DELETE commands
            _adapter = new OleDbDataAdapter(_selectQuery, _connection);

            _commandBuilder = new OleDbCommandBuilder(_adapter);

            // 3 Populates the DataSet
            _dataSet = new DataSet();
            _adapter.Fill(_dataSet, _tableName);

            _adapter.RowUpdated += new OleDbRowUpdatedEventHandler(DataAdapter_RowUpdated);
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// the event handler that to automatic assign the current ID+1 to the new added row
        /// </summary>
        void DataAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // When the update is an Insert (new record)
            if (e.StatementType == StatementType.Insert)
            {
                // Creates a new command
                // @@IDENTITY - a database function that returns the last-inserted identity (autonumber) value
                OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", _connection);

                // Assigns the ID value of the new row in the database to the DataColumn "ID" of the new
                // DataRow in the DataTable
                // ***
                // ExecuteScalar - Executes the command and returns the value of first column of the first row
                // e.Row - reference to the DataRow added to the DataTable
                // e.Row["ID"] - reference to the "ID" DataColumn in the DataRow
                e.Row["ID"] = (int)cmd.ExecuteScalar();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Return the DataTable from the dataset.
        /// </summary>
        /// <returns>The DataTable from the dataset.</returns>
        public DataTable GetAllRows()
        {
            return _dataSet.Tables[this._tableName];
        }


        /// <summary>
        /// Updates the changes made to the dataset to the data source.
        /// </summary>
        public void Update()
        {
            _adapter.Update(_dataSet.Tables[_tableName]);
        }

        /// <summary>
        /// Closes the connection to the database.
        /// </summary>
        public void Close()
        {
            _connection.Close();
        }
        #endregion
    }
}
