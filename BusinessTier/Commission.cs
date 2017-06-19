using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    public static class Commission
    {
            //the commission rate used for a sales staff member who has less than 10 years of employment with the company.
        private const decimal JUNIOR_RATE = .02m,
            //the commission rate used for a sales staff member who has 10 - 14 years of employment with the company.
                              SENIOR_RATE = .05m,
            //the commission rate used for a sales staff member who has 15 or more years with the company.
                              EXECUTIVE_RATE = .1m,
            //the rate used to calculate commission for options added on to the sale of the vehicle.
                              OPTIONS_COMMISSION_RATE = .02m;

        /// <summary>
        /// Calculates a sales staff’s total commission earned by the sale’s staff member for the sale of a vehicle
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="purchasePrice"></param>
        /// <param name="optionsPrice"></param>
        /// <returns></returns>
        public static decimal GetCommission(DateTime startTime, decimal purchasePrice, decimal optionsPrice = 0)
        {
            decimal commissionRate = 0;
            commissionRate = ((DateTime.Now.Year - startTime.Year) < 10 ?
            JUNIOR_RATE : ((DateTime.Now.Year - startTime.Year) >= 15 ? EXECUTIVE_RATE : SENIOR_RATE));

            return (purchasePrice * commissionRate + optionsPrice * OPTIONS_COMMISSION_RATE);
        }
    }
}
