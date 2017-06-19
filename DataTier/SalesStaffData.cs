using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTier
{
    public class SalesStaffData : Data
    {
        /// <summary>
        /// Constructs an new SalesStaffData object.
        /// Establishes a connection to the database
        /// Generates INSERT, UPDATE and DELETE commands
        /// Load the data set with all rows from the SalesStaff table.
        /// </summary>
        /// <param name="connectionString">The connection string to the data source.</param>
        /// <param name="tableName">The name of the table added to the dataset.</param>
        /// <param name="selectQuery">The Select query for the SelectCommand.</param>
        public SalesStaffData(string connectionString, string tableName, string selectQuery) : 
            base(connectionString, tableName, selectQuery) { }
    }
}
