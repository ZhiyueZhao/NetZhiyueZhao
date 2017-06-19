using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    /// <summary>
    /// This class contains functionality that specifically supports the business process of determining a vehicle sales quote for the RRC Automotive Group.
    /// </summary>
    public class SalesQuote
    {
        #region Fields
        //selling price of the vehicle being sold
        private decimal _vehicleSalePrice,
        //amount offered to the customer for the trade in of their vehicle.
                        _tradeInValue,
        //the tax rate applied to the sale of a vehicle
                        _salesTaxRate;
        //the value of the chosen accessories
        private Accessories _accessoriesChosen;
        //the value of the chose exterior finish
        private ExteriorFinish _exteriorFinishChosen;
        #endregion

        #region Properties
        /// <summary>
        /// read-only property returns the cost of accessories chosen.
        /// </summary>
        public decimal AccessoryCost
        {
            get
            {
                //the cost of accessories
                decimal _accessoriesCost;
                //according to the value of _accessoriesChosen, set the cost of accessories
                switch (_accessoriesChosen)
                {
                    case Accessories.None:
                        _accessoriesCost = Accessory.NONE;
                        break;
                    case Accessories.StereSystem:
                        _accessoriesCost = Accessory.STEREO_SYSTEM;
                        break;
                    case Accessories.LeatherInterior:
                        _accessoriesCost = Accessory.LEATHER_INTERIOR;
                        break;
                    case Accessories.StereoAndLeather:
                        _accessoriesCost = Accessory.STEREO_SYSTEM + Accessory.LEATHER_INTERIOR;
                        break;
                    case Accessories.ComputerNavigation:
                        _accessoriesCost = Accessory.COMPUTER_NAVIGATION;
                        break;
                    case Accessories.StereoAndNavigation:
                        _accessoriesCost = Accessory.STEREO_SYSTEM + Accessory.COMPUTER_NAVIGATION;
                        break;
                    case Accessories.LeatherAndNavigation:
                        _accessoriesCost = Accessory.LEATHER_INTERIOR + Accessory.COMPUTER_NAVIGATION;
                        break;
                    default:
                        _accessoriesCost = Accessory.STEREO_SYSTEM + Accessory.LEATHER_INTERIOR + Accessory.COMPUTER_NAVIGATION;
                        break;
                }
                //return the cost of accessories
                return _accessoriesCost;
            }
        }

        /// <summary>
        /// read-only property returns the cost of the exterior finish chosen.
        /// </summary>
        public decimal FinishCost
        {
            get
            {
                //cost of the exterior finish chosen
                decimal _finishCost;

                //according to the value of _exteriorFinishChosen, set the cost of the exterior finish chosen
                switch (_exteriorFinishChosen)
                {
                    case ExteriorFinish.None:
                        _finishCost = Finish.NONE;
                        break;
                    case ExteriorFinish.Standard:
                        _finishCost = Finish.STANDARD;
                        break;
                    case ExteriorFinish.Pearlized:
                        _finishCost = Finish.PEARLIZED;
                        break;
                    default:
                        _finishCost = Finish.CUSTOM;
                        break;
                }
                //return the cost of the exterior finish chosen
                return _finishCost;
            }
        }

        /// <summary>
        /// read-only property returns the sum of the vehicle’s sale price and the Accessory and Finish Cost.
        /// </summary>
        public decimal SubTotal
        {
            get
            {
                //returns the sum of the vehicle’s sale price and the Accessory and Finish Cost.
                return _vehicleSalePrice + AccessoryCost + FinishCost;
            }
        }

        /// <summary>
        /// read-only property returns the amount of tax to charge based on the subtotal.
        /// </summary>
        public decimal SalesTax
        {
            get
            {
                //returns the amount of tax to charge based on the subtotal.
                return _salesTaxRate * SubTotal;
            }
        }

        /// <summary>
        /// read-only property returns the sum of the subtotal and taxes.
        /// </summary>
        public decimal Total
        {
            get
            {
                //returns the sum of the subtotal and taxes.
                return SalesTax + SubTotal;
            }
        }

        /// <summary>
        /// read-only property returns the result of subtracting the trade-in value from the total.
        /// </summary>
        public decimal AmountDue
        {
            get
            {
                //returns the result of subtracting the trade-in value from the total.
                return Total - _tradeInValue;
            }
        }
        #endregion

        #region constractor
        /// <summary>
        /// the constractor of the whole class
        /// </summary>
        /// <param name="vehicleSalePrice">selling price of the vehicle being sold.</param>
        /// <param name="tradeInValue">amount offered to the customer for the trade in of their vehicle.</param>
        /// <param name="salesTaxRate">tax rate applied to the sale of a vehicle.</param>
        /// <param name="accessoriesChosen">the value of the chosen accessories</param>
        /// <param name="exteriorFinishChosen">the value of the chose exterior finish</param>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInValue, decimal salesTaxRate, Accessories accessoriesChosen, ExteriorFinish exteriorFinishChosen)
        {
            //set each value
            _vehicleSalePrice = vehicleSalePrice;
            _tradeInValue = tradeInValue;
            _salesTaxRate = salesTaxRate;
            _accessoriesChosen = accessoriesChosen;
            _exteriorFinishChosen = exteriorFinishChosen;
        }
        #endregion
    }
}
