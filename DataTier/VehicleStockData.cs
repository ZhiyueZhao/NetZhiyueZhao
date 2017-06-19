using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataTier
{
    public class VehicleStockData : Data
    {
        /// <summary>
        /// Constructs an new VehicleStockData object.
        /// </summary>
        /// <param name="connectionString">The connection string to the data source.</param>
        /// <param name="tableName">The name of the table added to the dataset.</param>
        /// <param name="selectQuery">The Select query for the SelectCommand.</param>
        public VehicleStockData(string connectionString, string tableName, string selectQuery) : base(connectionString, tableName, selectQuery) { }

        /// <summary>
        /// Check if there is a row contains the specified stock number
        /// </summary>
        /// <param name="stockNumber">the specified stock number</param>
        /// <returns>true if contains/ false if no</returns>
        public bool IsDuplicateStockNumber(string stockNumber)
        {
            bool isContainStockNumber = false;

            foreach (DataRow row in base.GetAllRows().Rows)
            {
                if (row["StockNumber"].ToString() == stockNumber)
                {
                    isContainStockNumber = true;
                }
            }

            return isContainStockNumber;
        }
    }
}
