using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    public class ServiceInvoice : Invoice
    {
        #region Property
        /// <summary>
        /// LabourCost Property
        /// </summary>
        public decimal LabourCost { get; private set; }

        /// <summary>
        /// PartsCost Property
        /// </summary>
        public decimal PartsCost { get; private set; }

        /// <summary>
        /// MaterialsCost Property
        /// </summary>
        public decimal MaterialsCost { get; private set; }

        /// <summary>
        /// override PSTCharged Property
        /// </summary>
        public override decimal PSTCharged 
        {
            get
            {
                return (this.PartsCost + this.MaterialsCost) * base.PSTRate;
            }
        }

        /// <summary>
        /// override GSTCharged Property
        /// </summary>
        public override decimal GSTCharged 
        {
            get
            {
                return (this.PartsCost + this.MaterialsCost + this.LabourCost) * base.GSTRate;
            }
        }

        /// <summary>
        /// override SubTotal Property
        /// </summary>
        public override decimal SubTotal 
        {
            get
            {
                return this.LabourCost + this.PartsCost + this.MaterialsCost;
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

        #region Method
        /// <summary>
        /// according to the costType input, calculate the related cost
        /// </summary>
        /// <param name="costType"></param>
        /// <param name="cost"></param>
        public void AddCost(CostType costType, decimal cost)
        {
            switch (costType)
            {
                case CostType.Labour:
                    this.LabourCost = this.LabourCost + cost;
                    break;
                case CostType.Part:
                    this.PartsCost = this.PartsCost + cost;
                    break;
                default:
                    this.MaterialsCost = this.MaterialsCost + cost;
                    break;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// inherent the base constructor
        /// </summary>
        /// <param name="pstRate"></param>
        /// <param name="gstRate"></param>
        public ServiceInvoice(decimal pstRate, decimal gstRate) : base(pstRate, gstRate) { }
        #endregion
    }
}
