using BusinessTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestZhiyueZhao
{
    
    
    /// <summary>
    ///This is a test class for SalesQuoteTest and is intended
    ///to contain all SalesQuoteTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SalesQuoteTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for SalesQuote Constructor
        ///</summary>
        [TestMethod()]
        public void SalesQuoteConstructorTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.ComputerNavigation; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom; // TODO: Initialize to an appropriate value

            SalesQuote_Accessor target = new SalesQuote_Accessor(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

            Assert.AreEqual(target._vehicleSalePrice, vehicleSalePrice);
            Assert.AreEqual(target._tradeInValue, tradeInValue);
            Assert.AreEqual(target._salesTaxRate, salesTaxRate);
            Assert.AreEqual(target._accessoriesChosen, accessoriesChosen);
            Assert.AreEqual(target._exteriorFinishChosen, exteriorFinishChosen);
        }



        /// <summary>
        ///A test for AccessoryCost
        ///</summary>
        [TestMethod()]
        public void AccessoryCostNoneTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.None; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.AccessoryCost;

            Assert.AreEqual(Accessory.NONE, actual);
        }

        /// <summary>
        ///A test for AccessoryCost
        ///</summary>
        [TestMethod()]
        public void AccessoryCostStereSystemTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.StereSystem; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.AccessoryCost;

            Assert.AreEqual(Accessory.STEREO_SYSTEM, actual);
        }

        /// <summary>
        ///A test for AccessoryCost
        ///</summary>
        [TestMethod()]
        public void AccessoryCostLeatherInteriorTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.LeatherInterior; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.AccessoryCost;

            Assert.AreEqual(Accessory.LEATHER_INTERIOR, actual);
        }

        /// <summary>
        ///A test for AccessoryCost
        ///</summary>
        [TestMethod()]
        public void AccessoryCostStereoAndLeatherTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.StereoAndLeather; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.AccessoryCost;

            Assert.AreEqual(Accessory.STEREO_SYSTEM + Accessory.LEATHER_INTERIOR, actual);
        }

        /// <summary>
        ///A test for AccessoryCost
        ///</summary>
        [TestMethod()]
        public void AccessoryCostComputerNavigationTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.ComputerNavigation; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.AccessoryCost;

            Assert.AreEqual(Accessory.COMPUTER_NAVIGATION, actual);
        }

        /// <summary>
        ///A test for AccessoryCost
        ///</summary>
        [TestMethod()]
        public void AccessoryCostStereoAndNavigationTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.StereoAndNavigation; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.AccessoryCost;

            Assert.AreEqual(Accessory.STEREO_SYSTEM + Accessory.COMPUTER_NAVIGATION, actual);
        }

        /// <summary>
        ///A test for AccessoryCost
        ///</summary>
        [TestMethod()]
        public void AccessoryCostLeatherAndNavigationTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.LeatherAndNavigation; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.AccessoryCost;

            Assert.AreEqual(Accessory.LEATHER_INTERIOR + Accessory.COMPUTER_NAVIGATION, actual);
        }

        /// <summary>
        ///A test for AccessoryCost
        ///</summary>
        [TestMethod()]
        public void AccessoryCostAllTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.All; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.AccessoryCost;

            Assert.AreEqual(Accessory.STEREO_SYSTEM + Accessory.LEATHER_INTERIOR + Accessory.COMPUTER_NAVIGATION, actual);
        }



        /// <summary>
        ///A test for FinishCost
        ///</summary>
        [TestMethod()]
        public void FinishCostNoneTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.All; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.FinishCost;

            Assert.AreEqual(Finish.NONE, actual);
        }

        /// <summary>
        ///A test for FinishCost
        ///</summary>
        [TestMethod()]
        public void FinishCostStandardTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.All; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.FinishCost;

            Assert.AreEqual(Finish.STANDARD, actual);
        }

        /// <summary>
        ///A test for FinishCost
        ///</summary>
        [TestMethod()]
        public void FinishCostPearlizedTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.All; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.FinishCost;

            Assert.AreEqual(Finish.PEARLIZED, actual);
        }

        /// <summary>
        ///A test for FinishCost
        ///</summary>
        [TestMethod()]
        public void FinishCostCustomTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.All; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.FinishCost;

            Assert.AreEqual(Finish.CUSTOM, actual);
        }

        /// <summary>
        ///A test for SubTotal
        ///</summary>
        [TestMethod()]
        public void SubTotalTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.None; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.SubTotal;
            Assert.AreEqual(vehicleSalePrice + Accessory.NONE + Finish.NONE, actual);
        }

        /// <summary>
        ///A test for SalesTax
        ///</summary>
        [TestMethod()]
        public void SalesTaxTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.None; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal expected = target.SubTotal * salesTaxRate;

            Decimal actual;
            actual = target.SalesTax;
            Assert.AreEqual(expected, actual);
        }



        /// <summary>
        ///A test for Total
        ///</summary>
        [TestMethod()]
        public void TotalTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.None; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None; // TODO: Initialize to an appropriate value

            SalesQuote target = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value

            Decimal actual;
            actual = target.Total;
            Assert.AreEqual(target.SalesTax + target.SubTotal, actual);
        }

        /// <summary>
        ///A test for AmountDue
        ///</summary>
        [TestMethod()]
        public void AmountDueTest()
        {
            Decimal vehicleSalePrice = 13456.12m; // TODO: Initialize to an appropriate value
            Decimal tradeInValue = 10123.23m; // TODO: Initialize to an appropriate value
            Decimal salesTaxRate = .13m; // TODO: Initialize to an appropriate value
            Accessories accessoriesChosen = Accessories.None; // TODO: Initialize to an appropriate value
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None; // TODO: Initialize to an appropriate value

            SalesQuote_Accessor target = new SalesQuote_Accessor(vehicleSalePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen); // TODO: Initialize to an appropriate value
            
            Decimal actual;
            actual = target.AmountDue;

            Assert.AreEqual(target.Total - target._tradeInValue, actual);
        }
    }
}
