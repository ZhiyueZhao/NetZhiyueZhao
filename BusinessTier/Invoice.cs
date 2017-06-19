using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    public abstract class Invoice
    {
        #region Property

        /// <summary>
        /// PSTRate Property
        /// </summary>
        public decimal PSTRate { get; private set; }

        /// <summary>
        /// GSTRate Property
        /// </summary>
        public decimal GSTRate { get; private set; }

        /// <summary>
        /// PSTCharged Property
        /// </summary>
        public abstract decimal PSTCharged { get; }

        /// <summary>
        /// GSTCharged Property
        /// </summary>
        public abstract decimal GSTCharged { get; }

        /// <summary>
        /// SubTotal Property
        /// </summary>
        public abstract decimal SubTotal { get; }

        /// <summary>
        /// Total Property
        /// </summary>
        public abstract decimal Total { get; }
        #endregion

        #region Constructor
        /// <summary>
        /// invoice constructor
        /// </summary>
        /// <param name="pstRate"></param>
        /// <param name="gstRate"></param>
        public Invoice(decimal pstRate, decimal gstRate)
        {
            this.PSTRate = pstRate;
            this.GSTRate = gstRate;
        }
        #endregion
    }
}
