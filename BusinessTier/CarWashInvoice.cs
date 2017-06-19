using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    public class CarWashInvoice : Invoice
    {
        #region Property
        public decimal PackageCost { get; private set; }

        public decimal FragranceCost { get; private set; }

        /// <summary>
        /// override PSTCharged Property
        /// </summary>
        public override decimal PSTCharged
        {
            get
            {
                return (this.PackageCost + this.FragranceCost) * base.PSTRate;
            }
        }

        /// <summary>
        /// override GSTCharged Property
        /// </summary>
        public override decimal GSTCharged
        {
            get
            {
                return (this.PackageCost + this.FragranceCost) * base.GSTRate;
            }
        }

        /// <summary>
        /// override SubTotal Property
        /// </summary>
        public override decimal SubTotal
        {
            get
            {
                return this.PackageCost + this.FragranceCost;
            }
        }

        /// <summary>
        /// override Total Property
        /// </summary>
        public override decimal Total
        {
            get
            {
                return this.SubTotal + this.PSTCharged + this.GSTCharged;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// a Constructor requires two parameters
        /// </summary>
        /// <param name="pstRate">a decimal value PST</param>
        /// <param name="gstRate">a decimal value GST</param>
        public CarWashInvoice(decimal pstRate, decimal gstRate) : base(pstRate, gstRate) { }

        /// <summary>
        /// a Constructor requires four parameters
        /// </summary>
        /// <param name="pstRate">a decimal value PST</param>
        /// <param name="gstRate">a decimal value GST</param>
        /// <param name="packageCost">a decimal value of package select cost</param>
        /// <param name="fragranceCost">a decimal value of fragrance select cost</param>
        public CarWashInvoice(decimal pstRate, decimal gstRate, decimal packageCost, decimal fragranceCost) : this(pstRate, gstRate) 
        {
            this.PackageCost = packageCost;
            this.FragranceCost = fragranceCost;
        }
        #endregion
    }
}
