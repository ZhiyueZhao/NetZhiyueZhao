using NETZhiyueZhao;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TestZhiyueZhao
{
    
    
    /// <summary>
    ///This is a test class for frmQuoteTest and is intended
    ///to contain all frmQuoteTest Unit Tests
    ///</summary>
    [TestClass()]
    public class frmQuoteTest
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
        ///A test for frmQuote Constructor
        ///</summary>
        [TestMethod()]
        public void frmQuoteConstructorTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor();
            clearTest(target);
        }

        private static void clearTest(frmQuote_Accessor target)
        {
            Assert.AreEqual(string.Empty, target.txtVehicleSalePrice.Text);
            Assert.AreEqual("0", target.txtTradeInAllowance.Text);

            Assert.IsTrue(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsFalse(target.radCustomizedDetailing.Checked);

            Assert.IsFalse(target.chkStereoSystem.Checked);
            Assert.IsFalse(target.chkLeatherInterior.Checked);
            Assert.IsFalse(target.chkComputerNavigation.Checked);

            Assert.AreEqual(string.Empty, target.lblVehicleSalePrice.Text);
            Assert.AreEqual(string.Empty, target.lblOptions.Text);
            Assert.AreEqual(string.Empty, target.lblSubtotal.Text);
            Assert.AreEqual("Sales Tax(13%):", target.lblSalesTaxText.Text);
            Assert.AreEqual(string.Empty, target.lblSalesTax.Text);
            Assert.AreEqual(string.Empty, target.lblTotal.Text);
            Assert.AreEqual(string.Empty, target.lblTradeInAllowance.Text);
            Assert.AreEqual(string.Empty, target.lblAmountDue.Text);

            Assert.AreEqual(string.Empty, target.lblNoOfYear.Text);
            Assert.AreEqual(string.Empty, target.lblInterestRate.Text);
            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);

            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
        }


        /// <summary>
        ///A test for txtVehicleSalePrice_Validating
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void txtVehicleSalePrice_ValidatingTestNotNumeric()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = target.txtVehicleSalePrice; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value

            target.txtVehicleSalePrice.Text = "Not a Numeric value.";
            target.txtVehicleSalePrice_Validating(sender, e);
            Assert.AreEqual("Please enter a numeric value.", target.errorProvider.GetError(target.txtVehicleSalePrice));
            //Assert.AreEqual(target.txtVehicleSalePrice.Text, target.txtVehicleSalePrice.SelectedText);
        }

        /// <summary>
        ///A test for txtVehicleSalePrice_Validating
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void txtVehicleSalePrice_ValidatingTestNoGreaterThanZero()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = target.txtVehicleSalePrice; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value

            target.txtVehicleSalePrice.Text = "0";
            target.txtVehicleSalePrice_Validating(sender, e);
            Assert.AreEqual("Please enter a value greater than zero.", target.errorProvider.GetError(target.txtVehicleSalePrice));
        }

        /// <summary>
        ///A test for txtVehicleSalePrice_Validating
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void txtVehicleSalePrice_ValidatingTestValidInput()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = target.txtVehicleSalePrice; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value

            target.txtVehicleSalePrice.Text = "999";
            target.txtVehicleSalePrice_Validating(sender, e);
            Assert.AreEqual(string.Empty, target.errorProvider.GetError(target.txtVehicleSalePrice));
        }


        /// <summary>
        ///A test for txtVehicleSalePrice_Validated
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void txtVehicleSalePrice_ValidatedTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value

            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.errorProvider.SetError(target.txtVehicleSalePrice, "Show the error");
            target.txtVehicleSalePrice_Validated(sender, e);
            Assert.AreEqual(string.Empty, target.errorProvider.GetError(target.txtVehicleSalePrice));
        }


        /// <summary>
        ///A test for txtTradeInAllowance_Validating
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void txtTradeInAllowance_ValidatingTestNotNumeric()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value

            object sender = target.txtTradeInAllowance; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value

            target.txtTradeInAllowance.Text = "Not a Numeric Value";
            target.txtTradeInAllowance_Validating(sender, e);
            Assert.AreEqual("Please enter a numeric value.", target.errorProvider.GetError(target.txtTradeInAllowance));
            //Assert.AreEqual("Not a Numeric Value", target.txtTradeInAllowance.SelectedText);
        }

        /// <summary>
        ///A test for txtTradeInAllowance_Validating
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void txtTradeInAllowance_ValidatingTestLessThanZero()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value

            object sender = target.txtTradeInAllowance; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value

            target.txtTradeInAllowance.Text = "-1";
            target.txtTradeInAllowance_Validating(sender, e);
            Assert.AreEqual("Please enter a value greater than or equal to zero.", target.errorProvider.GetError(target.txtTradeInAllowance));
        }

        /// <summary>
        ///A test for txtTradeInAllowance_Validating
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void txtTradeInAllowance_ValidatingTestValidInput()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value

            object sender = target.txtTradeInAllowance; // TODO: Initialize to an appropriate value
            CancelEventArgs e = new CancelEventArgs(); // TODO: Initialize to an appropriate value

            target.txtTradeInAllowance.Text = "0";
            target.txtTradeInAllowance_Validating(sender, e);
            Assert.AreEqual(string.Empty, target.errorProvider.GetError(target.txtTradeInAllowance));
        }



        /// <summary>
        ///A test for txtTradeInAllowance_Validated
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void txtTradeInAllowance_ValidatedTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value

            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.errorProvider.SetError(target.txtTradeInAllowance, "Show this error!");
            target.txtTradeInAllowance_Validated(sender, e);

            Assert.AreEqual(string.Empty, target.errorProvider.GetError(target.txtTradeInAllowance));
        }

        /// <summary>
        ///A test for updateMonthlyPayment
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void updateMonthlyPaymentTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            target.lblAmountDue.Text = "$5,024.57";
            target.hsbNoOfYear.Value = 3;
            target.hsbInterestRate.Value = 500;

            target.updateMonthlyPayment();

            Assert.AreEqual("$150.59", target.lblMonthlyPayment.Text);
        }

        /// <summary>
        ///A test for UpdateSummaryFinance
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void UpdateSummaryFinanceTest_AmountDuePositive()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "12345";
            target.chkStereoSystem.Checked = true;
            target.chkLeatherInterior.Checked = true;
            target.chkComputerNavigation.Checked = true;
            target.hsbInterestRate.Value = 500;
            target.hsbNoOfYear.Value = 3;

            target.UpdateSummaryFinance();
            
            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("3,030.30", target.lblOptions.Text);
            Assert.AreEqual("$15,371.30", target.lblSubtotal.Text);
            Assert.AreEqual("1,998.27", target.lblSalesTax.Text);
            Assert.AreEqual("$17,369.57", target.lblTotal.Text);
            Assert.AreEqual("-12,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$5,024.57", target.lblAmountDue.Text);

            Assert.AreEqual("$150.59", target.lblMonthlyPayment.Text);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
        }

        /// <summary>
        ///A test for UpdateSummaryFinance
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void UpdateSummaryFinanceTest_AmountDueNegative()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "16345";
            target.hsbInterestRate.Value = 500;
            target.hsbNoOfYear.Value = 3;

            target.UpdateSummaryFinance();

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("0.00", target.lblOptions.Text);
            Assert.AreEqual("$12,341.00", target.lblSubtotal.Text);
            Assert.AreEqual("1,604.33", target.lblSalesTax.Text);
            Assert.AreEqual("$13,945.33", target.lblTotal.Text);
            Assert.AreEqual("-16,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("-$2,399.67", target.lblAmountDue.Text);

            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);
        }

        /// <summary>
        ///A test for UpdateSummaryFinance
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void UpdateSummaryFinanceTest_AmountDueZero()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            target.txtVehicleSalePrice.Text = "113456";
            target.txtTradeInAllowance.Text = "128205.28";
            target.hsbInterestRate.Value = 500;
            target.hsbNoOfYear.Value = 3;

            target.UpdateSummaryFinance();

            Assert.AreEqual("$113,456.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("0.00", target.lblOptions.Text);
            Assert.AreEqual("$113,456.00", target.lblSubtotal.Text);
            Assert.AreEqual("14,749.28", target.lblSalesTax.Text);
            Assert.AreEqual("$128,205.28", target.lblTotal.Text);
            Assert.AreEqual("-128,205.28", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$0.00", target.lblAmountDue.Text);

            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);
        }

        /// <summary>
        ///A test for textBox_GotFocus
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void textBox_GotFocusTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "12345";
            object sender = target.txtVehicleSalePrice; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.textBox_GotFocus(sender, e);
            Assert.AreEqual("12341", target.txtVehicleSalePrice.SelectedText);

            sender = target.txtTradeInAllowance;

            target.textBox_GotFocus(sender, e);
            Assert.AreEqual("12345", target.txtTradeInAllowance.SelectedText);
        }

        /// <summary>
        ///A test for clearSummary
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void clearSummaryTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            target.lblVehicleSalePrice.Text = "$12,341.00";
            target.lblOptions.Text = "3,030.30";
            target.lblSubtotal.Text = "$15,371.30";
            target.lblSalesTax.Text = "1,998.27";
            target.lblTotal.Text = "$17,369.57";
            target.lblTradeInAllowance.Text = "-12,345.00";
            target.lblAmountDue.Text = "$5024.57";

            target.hsbInterestRate.Value = 525;
            target.hsbNoOfYear.Value = 6;
            target.lblNoOfYear.Text = "6";
            target.lblInterestRate.Text = "5.25%";
            target.lblMonthlyPayment.Text = "$81.50";

            target.clearSummary();

            Assert.AreEqual(string.Empty, target.lblVehicleSalePrice.Text);
            Assert.AreEqual(string.Empty, target.lblOptions.Text);
            Assert.AreEqual(string.Empty, target.lblSubtotal.Text);
            Assert.AreEqual(string.Empty, target.lblSalesTax.Text);
            Assert.AreEqual(string.Empty, target.lblTotal.Text);
            Assert.AreEqual(string.Empty, target.lblTradeInAllowance.Text);
            Assert.AreEqual(string.Empty, target.lblAmountDue.Text);

            Assert.AreEqual("6", target.lblNoOfYear.Text);
            Assert.AreEqual("5.25%", target.lblInterestRate.Text);
            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);
            Assert.AreEqual(6, target.hsbNoOfYear.Value);
            Assert.AreEqual(525, target.hsbInterestRate.Value);
        }

        /// <summary>
        ///A test for clearFinance
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void clearFinanceTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            target.lblVehicleSalePrice.Text = "$12,341.00";
            target.lblOptions.Text = "3,030.30";
            target.lblSubtotal.Text = "$15,371.30";
            target.lblSalesTax.Text = "1,998.27";
            target.lblTotal.Text = "$17,369.57";
            target.lblTradeInAllowance.Text = "-12,345.00";
            target.lblAmountDue.Text = "$5,024.57";
            target.hsbInterestRate.Value = 525;
            target.hsbNoOfYear.Value = 6;
            target.lblInterestRate.Text = "5.25%";
            target.lblNoOfYear.Text = "6";
            target.lblMonthlyPayment.Text = "$81.50";

            target.clearFinance();

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("3,030.30", target.lblOptions.Text);
            Assert.AreEqual("$15,371.30", target.lblSubtotal.Text);
            Assert.AreEqual("1,998.27", target.lblSalesTax.Text);
            Assert.AreEqual("$17,369.57", target.lblTotal.Text);
            Assert.AreEqual("-12,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$5,024.57", target.lblAmountDue.Text);

            Assert.AreEqual(string.Empty, target.lblNoOfYear.Text);
            Assert.AreEqual(string.Empty, target.lblInterestRate.Text);
            Assert.AreEqual("$81.50", target.lblMonthlyPayment.Text);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
        }



        /// <summary>
        ///A test for clearForm
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void clearFormTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value

            target.errorProvider.SetError(target.txtVehicleSalePrice, "Show the error VehicleSalePrice");

            target.errorProvider.SetError(target.txtTradeInAllowance, "Show the error TradeInAllowance");

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "12345";

            target.chkStereoSystem.Checked = true;
            target.chkLeatherInterior.Checked = true;
            target.chkComputerNavigation.Checked = true;

            target.radStandard.Checked = true;

            target.lblVehicleSalePrice.Text = "$12,341.00";
            target.lblOptions.Text = "3,030.30";
            target.lblSubtotal.Text = "$15,371.30";
            target.lblSalesTax.Text = "1,998.27";
            target.lblTotal.Text = "$17,369.57";
            target.lblTradeInAllowance.Text = "-12,345.00";
            target.lblAmountDue.Text = "$5,024.57";
            target.hsbInterestRate.Value = 525;
            target.hsbNoOfYear.Value = 6;
            target.lblInterestRate.Text = "5.25%";
            target.lblNoOfYear.Text = "6";
            target.lblMonthlyPayment.Text = "$81.50";

            target.clearForm();

            Assert.AreEqual(string.Empty, target.errorProvider.GetError(target.txtVehicleSalePrice));
            Assert.AreEqual(string.Empty, target.errorProvider.GetError(target.txtTradeInAllowance));

            Assert.AreEqual(string.Empty, target.txtVehicleSalePrice.Text);
            Assert.AreEqual("0", target.txtTradeInAllowance.Text);
            Assert.AreEqual(string.Empty, target.lblVehicleSalePrice.Text);
            Assert.AreEqual(string.Empty, target.lblOptions.Text);
            Assert.AreEqual(string.Empty, target.lblSubtotal.Text);
            Assert.AreEqual(string.Empty, target.lblSalesTax.Text);
            Assert.AreEqual(string.Empty, target.lblTotal.Text);
            Assert.AreEqual(string.Empty, target.lblTradeInAllowance.Text);
            Assert.AreEqual(string.Empty, target.lblAmountDue.Text);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual(string.Empty, target.lblInterestRate.Text);
            Assert.AreEqual(string.Empty, target.lblNoOfYear.Text);
            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);

            Assert.IsTrue(target.radStandard.Checked);
            Assert.IsFalse(target.chkStereoSystem.Checked);
            Assert.IsFalse(target.chkLeatherInterior.Checked);
            Assert.IsFalse(target.chkComputerNavigation.Checked);
        }

        /// <summary>
        ///A test for btnCalculateQuote_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void btnCalculateQuote_ClickTestPositive()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "12345";

            target.chkStereoSystem.Checked = true;
            target.chkLeatherInterior.Checked = true;
            target.chkComputerNavigation.Checked = true;

            target.radStandard.Checked = true;

            target.btnCalculateQuote_Click(sender, e);

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("12345", target.txtTradeInAllowance.Text);

            Assert.IsTrue(target.chkStereoSystem.Checked);
            Assert.IsTrue(target.chkLeatherInterior.Checked);
            Assert.IsTrue(target.chkComputerNavigation.Checked);

            Assert.IsTrue(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsFalse(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00",target.lblVehicleSalePrice.Text);
            Assert.AreEqual("3,030.30", target.lblOptions.Text);
            Assert.AreEqual("$15,371.30", target.lblSubtotal.Text);
            Assert.AreEqual("1,998.27", target.lblSalesTax.Text);
            Assert.AreEqual("$17,369.57", target.lblTotal.Text);
            Assert.AreEqual("-12,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$5,024.57", target.lblAmountDue.Text);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.00%",target.lblInterestRate.Text);
            Assert.AreEqual("3", target.lblNoOfYear.Text);
            Assert.AreEqual("$150.59", target.lblMonthlyPayment.Text);
            Assert.IsTrue(target.grpFinance.Enabled);
            //Assert.IsTrue(target.txtVehicleSalePrice.Focused);
        }

        /// <summary>
        ///A test for btnCalculateQuote_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void btnCalculateQuote_ClickTestNegative()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value

            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "15000";

            target.chkStereoSystem.Checked = false;
            target.chkLeatherInterior.Checked = false;
            target.chkComputerNavigation.Checked = false;

            target.radStandard.Checked = true;

            target.btnCalculateQuote_Click(sender, e);

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("15000", target.txtTradeInAllowance.Text);

            Assert.IsFalse(target.chkStereoSystem.Checked);
            Assert.IsFalse(target.chkLeatherInterior.Checked);
            Assert.IsFalse(target.chkComputerNavigation.Checked);

            Assert.IsTrue(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsFalse(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("0.00", target.lblOptions.Text);
            Assert.AreEqual("$12,341.00", target.lblSubtotal.Text);
            Assert.AreEqual("1,604.33", target.lblSalesTax.Text);
            Assert.AreEqual("$13,945.33", target.lblTotal.Text);
            Assert.AreEqual("-15,000.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("-$1,054.67", target.lblAmountDue.Text);
            Assert.AreEqual(string.Empty, target.lblInterestRate.Text);
            Assert.AreEqual(string.Empty, target.lblNoOfYear.Text);
            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);
            Assert.IsFalse(target.grpFinance.Enabled);
        }

        /// <summary>
        ///A test for btnCalculateQuote_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void btnCalculateQuote_ClickTestZero()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value

            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "15086.74";

            target.chkStereoSystem.Checked = false;
            target.chkLeatherInterior.Checked = true;
            target.chkComputerNavigation.Checked = false;

            target.radStandard.Checked = true;

            target.btnCalculateQuote_Click(sender, e);

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("15086.74", target.txtTradeInAllowance.Text);

            Assert.IsFalse(target.chkStereoSystem.Checked);
            Assert.IsTrue(target.chkLeatherInterior.Checked);
            Assert.IsFalse(target.chkComputerNavigation.Checked);

            Assert.IsTrue(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsFalse(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("1,010.10", target.lblOptions.Text);
            Assert.AreEqual("$13,351.10", target.lblSubtotal.Text);
            Assert.AreEqual("1,735.64", target.lblSalesTax.Text);
            Assert.AreEqual("$15,086.74", target.lblTotal.Text);
            Assert.AreEqual("-15,086.74", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$0.00", target.lblAmountDue.Text);
            Assert.AreEqual(string.Empty, target.lblInterestRate.Text);
            Assert.AreEqual(string.Empty, target.lblNoOfYear.Text);
            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);
            Assert.IsFalse(target.grpFinance.Enabled);
        }

        /// <summary>
        ///A test for btnCalculateQuote_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void btnCalculateQuote_ClickTestZeroThenPositive()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value

            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.lblVehicleSalePrice.Text = "$12,341.00";
            target.lblOptions.Text="1,010.10";
            target.lblSubtotal.Text = "$13,351.10";
            target.lblSalesTax.Text = "1,735.64";
            target.lblTotal.Text = "$15,086.74";
            target.lblTradeInAllowance.Text = "-15,086.74";
            target.lblAmountDue.Text = "$0.00";

            target.grpFinance.Enabled = false;
            target.lblInterestRate.Text = string.Empty;
            target.lblNoOfYear.Text = string.Empty;
            target.lblMonthlyPayment.Text = string.Empty;

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "12345";

            target.chkStereoSystem.Checked = true;
            target.chkLeatherInterior.Checked = true;
            target.chkComputerNavigation.Checked = true;

            target.radStandard.Checked = true;

            target.btnCalculateQuote_Click(sender, e);

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("12345", target.txtTradeInAllowance.Text);

            Assert.IsTrue(target.chkStereoSystem.Checked);
            Assert.IsTrue(target.chkLeatherInterior.Checked);
            Assert.IsTrue(target.chkComputerNavigation.Checked);

            Assert.IsTrue(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsFalse(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("3,030.30", target.lblOptions.Text);
            Assert.AreEqual("$15,371.30", target.lblSubtotal.Text);
            Assert.AreEqual("1,998.27", target.lblSalesTax.Text);
            Assert.AreEqual("$17,369.57", target.lblTotal.Text);
            Assert.AreEqual("-12,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$5,024.57", target.lblAmountDue.Text);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.00%", target.lblInterestRate.Text);
            Assert.AreEqual("3", target.lblNoOfYear.Text);
            Assert.AreEqual("$150.59", target.lblMonthlyPayment.Text);
            Assert.IsTrue(target.grpFinance.Enabled);
        }

        /// <summary>
        ///A test for btnCalculateQuote_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void btnCalculateQuote_ClickTestPositiveAndScrollThenZero()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value

            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.lblVehicleSalePrice.Text = "$12,341.00";
            target.lblOptions.Text = "3,030.30";
            target.lblSubtotal.Text = "$15,371.30";
            target.lblSalesTax.Text = "1,998.27";
            target.lblTotal.Text = "$17,369.57";
            target.lblTradeInAllowance.Text = "-12,345.00";
            target.lblAmountDue.Text = "$5,024.57";

            target.grpFinance.Enabled = true;
            target.lblInterestRate.Text = "5.25%";
            target.lblNoOfYear.Text = "6";
            target.lblMonthlyPayment.Text = "$81.50";
            target.hsbInterestRate.Value = 525;
            target.hsbNoOfYear.Value = 6;

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "19000";

            target.chkStereoSystem.Checked = true;
            target.chkLeatherInterior.Checked = true;
            target.chkComputerNavigation.Checked = true;

            target.radStandard.Checked = true;

            target.btnCalculateQuote_Click(sender, e);

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("19000", target.txtTradeInAllowance.Text);

            Assert.IsTrue(target.chkStereoSystem.Checked);
            Assert.IsTrue(target.chkLeatherInterior.Checked);
            Assert.IsTrue(target.chkComputerNavigation.Checked);

            Assert.IsTrue(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsFalse(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("3,030.30", target.lblOptions.Text);
            Assert.AreEqual("$15,371.30", target.lblSubtotal.Text);
            Assert.AreEqual("1,998.27", target.lblSalesTax.Text);
            Assert.AreEqual("$17,369.57", target.lblTotal.Text);
            Assert.AreEqual("-19,000.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("-$1,630.43", target.lblAmountDue.Text);
            Assert.AreEqual(525, target.hsbInterestRate.Value);
            Assert.AreEqual(6, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.25%", target.lblInterestRate.Text);
            Assert.AreEqual("6", target.lblNoOfYear.Text);
            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);
            Assert.IsFalse(target.grpFinance.Enabled);
        }

        /// <summary>
        ///A test for btnCalculateQuote_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void btnCalculateQuote_ClickTestPositiveAndScrollThenPositive()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value

            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.lblVehicleSalePrice.Text = "$12,341.00";
            target.lblOptions.Text = "3,030.30";
            target.lblSubtotal.Text = "$15,371.30";
            target.lblSalesTax.Text = "1,998.27";
            target.lblTotal.Text = "$17,369.57";
            target.lblTradeInAllowance.Text = "-12,345.00";
            target.lblAmountDue.Text = "$5,024.57";

            target.grpFinance.Enabled = true;
            target.lblInterestRate.Text = "5.25%";
            target.lblNoOfYear.Text = "6";
            target.lblMonthlyPayment.Text = "$81.50";
            target.hsbInterestRate.Value = 525;
            target.hsbNoOfYear.Value = 6;

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "12300";

            target.chkStereoSystem.Checked = true;
            target.chkLeatherInterior.Checked = true;
            target.chkComputerNavigation.Checked = true;

            target.radStandard.Checked = true;

            target.btnCalculateQuote_Click(sender, e);

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("12300", target.txtTradeInAllowance.Text);

            Assert.IsTrue(target.chkStereoSystem.Checked);
            Assert.IsTrue(target.chkLeatherInterior.Checked);
            Assert.IsTrue(target.chkComputerNavigation.Checked);

            Assert.IsTrue(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsFalse(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("3,030.30", target.lblOptions.Text);
            Assert.AreEqual("$15,371.30", target.lblSubtotal.Text);
            Assert.AreEqual("1,998.27", target.lblSalesTax.Text);
            Assert.AreEqual("$17,369.57", target.lblTotal.Text);
            Assert.AreEqual("-12,300.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$5,069.57", target.lblAmountDue.Text);
            Assert.AreEqual(525, target.hsbInterestRate.Value);
            Assert.AreEqual(6, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.25%", target.lblInterestRate.Text);
            Assert.AreEqual("6", target.lblNoOfYear.Text);
            Assert.AreEqual("$82.23", target.lblMonthlyPayment.Text);
            Assert.IsTrue(target.grpFinance.Enabled);
        }

        /// <summary>
        ///A test for checkboxRadioButton_CheckedChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void checkboxRadioButton_CheckedChangedTestCheckbox()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "12345";

            target.btnCalculateQuote_Click(sender, e);

            target.chkLeatherInterior.Checked = true;

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("12345", target.txtTradeInAllowance.Text);

            Assert.IsFalse(target.chkStereoSystem.Checked);
            Assert.IsTrue(target.chkLeatherInterior.Checked);
            Assert.IsFalse(target.chkComputerNavigation.Checked);

            Assert.IsTrue(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsFalse(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("1,010.10", target.lblOptions.Text);
            Assert.AreEqual("$13,351.10", target.lblSubtotal.Text);
            Assert.AreEqual("1,735.64", target.lblSalesTax.Text);
            Assert.AreEqual("$15,086.74", target.lblTotal.Text);
            Assert.AreEqual("-12,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$2,741.74", target.lblAmountDue.Text);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.00%", target.lblInterestRate.Text);
            Assert.AreEqual("3", target.lblNoOfYear.Text);
            Assert.AreEqual("$82.17", target.lblMonthlyPayment.Text);
            Assert.IsTrue(target.grpFinance.Enabled);
        }

        /// <summary>
        ///A test for checkboxRadioButton_CheckedChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void checkboxRadioButton_CheckedChangedTestRadio()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "12345";

            target.btnCalculateQuote_Click(sender, e);

            target.radCustomizedDetailing.Checked = true;

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("12345", target.txtTradeInAllowance.Text);

            Assert.IsFalse(target.chkStereoSystem.Checked);
            Assert.IsFalse(target.chkLeatherInterior.Checked);
            Assert.IsFalse(target.chkComputerNavigation.Checked);

            Assert.IsFalse(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsTrue(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("606.06", target.lblOptions.Text);
            Assert.AreEqual("$12,947.06", target.lblSubtotal.Text);
            Assert.AreEqual("1,683.12", target.lblSalesTax.Text);
            Assert.AreEqual("$14,630.18", target.lblTotal.Text);
            Assert.AreEqual("-12,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$2,285.18", target.lblAmountDue.Text);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.00%", target.lblInterestRate.Text);
            Assert.AreEqual("3", target.lblNoOfYear.Text);
            Assert.AreEqual("$68.49", target.lblMonthlyPayment.Text);
            Assert.IsTrue(target.grpFinance.Enabled);
        }

        /// <summary>
        ///A test for hsbInterestRate_ValueChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void hsbInterestRate_ValueChangedTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "12345";
            target.radCustomizedDetailing.Checked = true;

            target.btnCalculateQuote_Click(sender, e);

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("12345", target.txtTradeInAllowance.Text);

            Assert.IsFalse(target.chkStereoSystem.Checked);
            Assert.IsFalse(target.chkLeatherInterior.Checked);
            Assert.IsFalse(target.chkComputerNavigation.Checked);

            Assert.IsFalse(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsTrue(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("606.06", target.lblOptions.Text);
            Assert.AreEqual("$12,947.06", target.lblSubtotal.Text);
            Assert.AreEqual("1,683.12", target.lblSalesTax.Text);
            Assert.AreEqual("$14,630.18", target.lblTotal.Text);
            Assert.AreEqual("-12,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$2,285.18", target.lblAmountDue.Text);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.00%", target.lblInterestRate.Text);
            Assert.AreEqual("3", target.lblNoOfYear.Text);
            Assert.AreEqual("$68.49", target.lblMonthlyPayment.Text);
            Assert.IsTrue(target.grpFinance.Enabled);

            target.hsbInterestRate.Value = 538;

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("12345", target.txtTradeInAllowance.Text);

            Assert.IsFalse(target.chkStereoSystem.Checked);
            Assert.IsFalse(target.chkLeatherInterior.Checked);
            Assert.IsFalse(target.chkComputerNavigation.Checked);

            Assert.IsFalse(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsTrue(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("606.06", target.lblOptions.Text);
            Assert.AreEqual("$12,947.06", target.lblSubtotal.Text);
            Assert.AreEqual("1,683.12", target.lblSalesTax.Text);
            Assert.AreEqual("$14,630.18", target.lblTotal.Text);
            Assert.AreEqual("-12,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$2,285.18", target.lblAmountDue.Text);
            Assert.AreEqual(538, target.hsbInterestRate.Value);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.38%", target.lblInterestRate.Text);
            Assert.AreEqual("3", target.lblNoOfYear.Text);
            Assert.AreEqual("$68.88", target.lblMonthlyPayment.Text);
            Assert.IsTrue(target.grpFinance.Enabled);
        }

        /// <summary>
        ///A test for hsbNoOfYear_ValueChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void hsbNoOfYear_ValueChangedTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "12345";
            target.radCustomizedDetailing.Checked = true;

            target.btnCalculateQuote_Click(sender, e);

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("12345", target.txtTradeInAllowance.Text);

            Assert.IsFalse(target.chkStereoSystem.Checked);
            Assert.IsFalse(target.chkLeatherInterior.Checked);
            Assert.IsFalse(target.chkComputerNavigation.Checked);

            Assert.IsFalse(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsTrue(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("606.06", target.lblOptions.Text);
            Assert.AreEqual("$12,947.06", target.lblSubtotal.Text);
            Assert.AreEqual("1,683.12", target.lblSalesTax.Text);
            Assert.AreEqual("$14,630.18", target.lblTotal.Text);
            Assert.AreEqual("-12,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$2,285.18", target.lblAmountDue.Text);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.00%", target.lblInterestRate.Text);
            Assert.AreEqual("3", target.lblNoOfYear.Text);
            Assert.AreEqual("$68.49", target.lblMonthlyPayment.Text);
            Assert.IsTrue(target.grpFinance.Enabled);

            target.hsbNoOfYear.Value = 6;

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("12345", target.txtTradeInAllowance.Text);

            Assert.IsFalse(target.chkStereoSystem.Checked);
            Assert.IsFalse(target.chkLeatherInterior.Checked);
            Assert.IsFalse(target.chkComputerNavigation.Checked);

            Assert.IsFalse(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsTrue(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("606.06", target.lblOptions.Text);
            Assert.AreEqual("$12,947.06", target.lblSubtotal.Text);
            Assert.AreEqual("1,683.12", target.lblSalesTax.Text);
            Assert.AreEqual("$14,630.18", target.lblTotal.Text);
            Assert.AreEqual("-12,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$2,285.18", target.lblAmountDue.Text);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
            Assert.AreEqual(6, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.00%", target.lblInterestRate.Text);
            Assert.AreEqual("6", target.lblNoOfYear.Text);
            Assert.AreEqual("$36.80", target.lblMonthlyPayment.Text);
            Assert.IsTrue(target.grpFinance.Enabled);
        }

        /// <summary>
        ///A test for textbox_TextChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void textbox_TextChangedTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "12345";
            target.radCustomizedDetailing.Checked = true;

            target.btnCalculateQuote_Click(sender, e);

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("12345", target.txtTradeInAllowance.Text);

            Assert.IsFalse(target.chkStereoSystem.Checked);
            Assert.IsFalse(target.chkLeatherInterior.Checked);
            Assert.IsFalse(target.chkComputerNavigation.Checked);

            Assert.IsFalse(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsTrue(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("606.06", target.lblOptions.Text);
            Assert.AreEqual("$12,947.06", target.lblSubtotal.Text);
            Assert.AreEqual("1,683.12", target.lblSalesTax.Text);
            Assert.AreEqual("$14,630.18", target.lblTotal.Text);
            Assert.AreEqual("-12,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$2,285.18", target.lblAmountDue.Text);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.00%", target.lblInterestRate.Text);
            Assert.AreEqual("3", target.lblNoOfYear.Text);
            Assert.AreEqual("$68.49", target.lblMonthlyPayment.Text);
            Assert.IsTrue(target.grpFinance.Enabled);

            target.txtVehicleSalePrice.Text = "12333";

            Assert.AreEqual("12333", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("12345", target.txtTradeInAllowance.Text);

            Assert.IsFalse(target.chkStereoSystem.Checked);
            Assert.IsFalse(target.chkLeatherInterior.Checked);
            Assert.IsFalse(target.chkComputerNavigation.Checked);

            Assert.IsFalse(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsTrue(target.radCustomizedDetailing.Checked);

            Assert.AreEqual(500, target.hsbInterestRate.Value);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.00%", target.lblInterestRate.Text);
            Assert.AreEqual("3", target.lblNoOfYear.Text);
            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);

            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);
            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);
            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);
            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);
            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);
            Assert.AreEqual(string.Empty, target.lblMonthlyPayment.Text);

        }

        /// <summary>
        ///A test for lnkResetForm_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("NETZhiyueZhao.exe")]
        public void lnkResetForm_ClickTest()
        {
            frmQuote_Accessor target = new frmQuote_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value

            target.txtVehicleSalePrice.Text = "12341";
            target.txtTradeInAllowance.Text = "12345";
            target.radCustomizedDetailing.Checked = true;
            target.chkStereoSystem.Checked = true;
            target.chkLeatherInterior.Checked = true;
            target.chkComputerNavigation.Checked = true;

            target.btnCalculateQuote_Click(sender, e);

            Assert.AreEqual("12341", target.txtVehicleSalePrice.Text);
            Assert.AreEqual("12345", target.txtTradeInAllowance.Text);

            Assert.IsTrue(target.chkStereoSystem.Checked);
            Assert.IsTrue(target.chkLeatherInterior.Checked);
            Assert.IsTrue(target.chkComputerNavigation.Checked);

            Assert.IsFalse(target.radStandard.Checked);
            Assert.IsFalse(target.radPearlized.Checked);
            Assert.IsTrue(target.radCustomizedDetailing.Checked);

            Assert.AreEqual("$12,341.00", target.lblVehicleSalePrice.Text);
            Assert.AreEqual("3,636.36", target.lblOptions.Text);
            Assert.AreEqual("$15,977.36", target.lblSubtotal.Text);
            Assert.AreEqual("2,077.06", target.lblSalesTax.Text);
            Assert.AreEqual("$18,054.42", target.lblTotal.Text);
            Assert.AreEqual("-12,345.00", target.lblTradeInAllowance.Text);
            Assert.AreEqual("$5,709.42", target.lblAmountDue.Text);
            Assert.AreEqual(500, target.hsbInterestRate.Value);
            Assert.AreEqual(3, target.hsbNoOfYear.Value);
            Assert.AreEqual("5.00%", target.lblInterestRate.Text);
            Assert.AreEqual("3", target.lblNoOfYear.Text);
            Assert.AreEqual("$171.12", target.lblMonthlyPayment.Text);
            Assert.IsTrue(target.grpFinance.Enabled);

            AutomotiveManager_Accessor._isBeingTested = true;
            //auto click yes
            AutomotiveManager_Accessor._messageBoxResult = DialogResult.Yes;

            target.lnkResetForm_Click(sender, e);
            clearTest(target);
        }
    }
}
