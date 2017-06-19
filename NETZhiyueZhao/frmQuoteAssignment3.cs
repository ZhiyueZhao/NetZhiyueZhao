using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessTier;
using System.Configuration;

namespace NETZhiyueZhao
{
    /// <summary>
    /// the Trader form inherit Form class
    /// </summary>
    public partial class frmQuoteAssignment3 : Form
    {
        /// <summary>
        /// to create a new frmTrader
        /// </summary>
        public frmQuoteAssignment3()
        {
            //to set up an initial state of the form
            InitializeComponent();

            //Validation
            txtVehicleSalePrice.Validating += new CancelEventHandler(txtVehicleSalePrice_Validating);
            txtVehicleSalePrice.Validated += new EventHandler(txtVehicleSalePrice_Validated);
            txtTradeInAllowance.Validating += new CancelEventHandler(txtTradeInAllowance_Validating);
            txtTradeInAllowance.Validated += new EventHandler(txtTradeInAllowance_Validated);

            //add functions to ResetForm link
            lnkResetForm.Click += new EventHandler(lnkResetForm_Click);

            //add functions to CalculateQuote button
            btnCalculateQuote.Click += new EventHandler(btnCalculateQuote_Click);
            
            //Automatic get the text from app configuration for SalesTax lable
            lblSalesTaxText.Text = "Sales Tax" + "(" + ((Decimal.Parse(ConfigurationManager.AppSettings["Government Sales Tax (GST) Rate"]) + Decimal.Parse(ConfigurationManager.AppSettings["Provincial Sales Tax (PST) Rate"])) * 100m).ToString("F0") + "%):";
            //add functions to tVehicleSalePrice textbox, when gains focus, the text will be selected
            txtVehicleSalePrice.GotFocus += new EventHandler(textBox_GotFocus);
            //add functions to TradeInAllowance textbox, when gains focus, the text will be selected
            txtTradeInAllowance.GotFocus += new EventHandler(textBox_GotFocus);

            //add functions to tVehicleSalePrice textbox, when mosue click focus, the text will be selected
            txtVehicleSalePrice.MouseClick += new MouseEventHandler(textBox_GotFocus);
            //add functions to TradeInAllowance textbox, when mosue click focus, the text will be selected
            txtTradeInAllowance.MouseClick += new MouseEventHandler(textBox_GotFocus);

            //add functions to tVehicleSalePrice textbox, when the text was changed, the summary section gonna cleared
            txtVehicleSalePrice.TextChanged += new EventHandler(textbox_TextChanged);
            //add functions to tVehicleSalePrice textbox, when the text was changed, the summary section gonna cleared
            txtTradeInAllowance.TextChanged += new EventHandler(textbox_TextChanged);
            
            //initial data state
            clearForm();
        }

        void txtVehicleSalePrice_Validating(object sender, CancelEventArgs e)
        {
            //declare a errorMessage string and set it's default value to empty string
            string errorMessage = string.Empty;

            //invoke the IsNumber in the AutomotiveManager class to check if the text of VehicleSalePrice could be parse to a number
            if (!AutomotiveManager.IsNumber(txtVehicleSalePrice.Text))
            {
                //set error message
                errorMessage = "Please enter a numeric value.";
            }
            //parse the text of the TradeInAllowance textbox to decimal and check if it less than or equal to 0
            else if (!(Decimal.Parse(txtVehicleSalePrice.Text) > 0))
            {
                //set error message
                errorMessage = "Please enter a value greater than zero.";
            }

            //check if the errorMessage is not an empty string
            if (!errorMessage.Equals(string.Empty))
            {
                //set the CancelEventArgs' Cancel property to true
                e.Cancel = true;
                //invoke SetError method in errorProvider control and set the errorMessage to VehicleSalePrice textbox
                errorProvider.SetError(txtVehicleSalePrice, errorMessage);
                //set focus to VehicleSalePrice textbox
                txtVehicleSalePrice.Focus();
            }
        }

        void txtVehicleSalePrice_Validated(object sender, EventArgs e)
        {
            //disable the error icon by invoke SetError method in errorProvider control and set empty to the VehicleSalePrice textbox
            errorProvider.SetError(txtVehicleSalePrice, string.Empty);
        }

        void txtTradeInAllowance_Validating(object sender, CancelEventArgs e)
        {
            //declare a errorMessage string and set it's default value to empty string
            string errorMessage = string.Empty;

            //invoke the IsNumber in the AutomotiveManager class to check if the text of TradeInAllowance could be parse to a number
            if (!AutomotiveManager.IsNumber(txtTradeInAllowance.Text))
            {
                //set error message
                errorMessage = "Please enter a numeric value.";
            }
            //parse the text of the TradeInAllowance textbox to decimal and check if it less than 0
            else if (Decimal.Parse(txtTradeInAllowance.Text) < 0)
            {
                //set error message 
                errorMessage = "Please enter a value greater than or equal to zero.";
            }

            //check if the errorMessage is not an empty string
            if (!errorMessage.Equals(string.Empty))
            {
                //set the CancelEventArgs' Cancel property to true
                e.Cancel = true;

                //invoke SetError method in errorProvider control and set the errorMessage to TradeInAllowance textbox
                errorProvider.SetError(txtTradeInAllowance, errorMessage);

                //set focus to TradeInAllowance textbox
                txtTradeInAllowance.Focus();
            }
        }

        void txtTradeInAllowance_Validated(object sender, EventArgs e)
        {
            //disable the error icon by invoke SetError method in errorProvider control and set empty to the TradeInAllowance textbox
            errorProvider.SetError(txtTradeInAllowance, string.Empty);
        }

        void textbox_TextChanged(object sender, EventArgs e)
        {
            //invoke unwrapEventHandlerForRadChk method
            unwrapEventHandlerForRadChk();

            //invoke clearSummary method
            clearSummary();
        }

        void textBox_GotFocus(object sender, EventArgs e)
        {
            //cast sender to TextBox type and invoke it's SelectAll method
            //(sender as TextBox).SelectAll();
            ((TextBox)sender).SelectAll();
        }

        void hsbInterestRate_ValueChanged(object sender, EventArgs e)
        {
            //check if the user change the text or click the resetform link
            if (grpFinance.Enabled)
            {
                //when the user scroll the InterestRate ScrollBar, the text of the InterestRate lable changed according to the value of the InterestRate ScrollBar
                lblInterestRate.Text = ((Decimal)hsbInterestRate.Value / 100m).ToString("F2") + "%";

                //invoke the updateMonthlyPayment method
                updateMonthlyPayment();
            }
        }

        private void updateMonthlyPayment()
        {
            //invoke the Payment method in AutomotiveManager class use the parameter to calculate the value of MonthlyPayment lable
            lblMonthlyPayment.Text = (AutomotiveManager.Payment((Decimal)hsbInterestRate.Value / 10000m / 12m, 
                                        hsbNoOfYear.Value * 12m, 
                                        Decimal.Parse(lblAmountDue.Text.Substring(1, lblAmountDue.Text.Length - 1)))).ToString("c");

            //set focus to VehicleSalePrice textbox
            txtVehicleSalePrice.Focus();
        }

        void hsbNoOfYear_ValueChanged(object sender, EventArgs e)
        {
            //check if the user change the text or click the resetform link
            if (grpFinance.Enabled)
            {
                //when the user scroll the NoOfYear ScrollBar, the text of the NoOfYear lable changed according to the value of the NoOfYear ScrollBar
                lblNoOfYear.Text = hsbNoOfYear.Value.ToString();

                //invoke the updateMonthlyPayment method
                updateMonthlyPayment();
            }
        }

        void lnkResetForm_Click(object sender, EventArgs e)
        {
            //declare a DialogResult and invoke ShowMessage method in the AutomotiveManager class to set the default value
            DialogResult result =
                AutomotiveManager.ShowMessage("Do you want to reset this sales quote?", "Sales Quote", MessageBoxButtons.YesNo);

            //check if the user click the yes button
            if (result == DialogResult.Yes)
            {
                //invoke unwrapEventHandlerForRadChk method to unwrap the EventHandler from the checkbox and radio buttons
                unwrapEventHandlerForRadChk();
                //invoke clearForm method
                clearForm();
            }
            else
            {
                //set focus to VehicleSalePrice textbox
                txtVehicleSalePrice.Focus();
            }
        }

        /// <summary>
        /// use to unwrap the fuctions from radio buttons and check box
        /// </summary>
        private void unwrapEventHandlerForRadChk()
        {
            //make an array to store the radio buttons
            RadioButton[] radioButtons = { radStandard, radPearlized, radCustomizedDetailing };
            //make a loop to traversal all the radion buttons
            for (int i = 0; i < radioButtons.Length; i++)
            {
                // use "-=" lable to erase fuctions
                radioButtons[i].CheckedChanged -= new EventHandler(checkboxRadioButton_CheckedChanged);
            }

            //change checkbox change summary
            //make an array to store the checkboxs
            CheckBox[] checkboxs = { chkComputerNavigation, chkLeatherInterior, chkStereoSystem };
            //make a loop to traversal all the checkboxs
            foreach (CheckBox checkbox in checkboxs)
            {
                // use "-=" lable to erase fuctions
                checkbox.CheckedChanged -= new EventHandler(checkboxRadioButton_CheckedChanged);
            }
        }

        /// <summary>
        /// clear the form
        /// </summary>
        private void clearForm()
        {
            //invoke the clearSummary method
            clearSummary();

            //invoke the clearFinance method
            clearFinance();

            //clear the textboxes
            txtVehicleSalePrice.Clear();
            txtTradeInAllowance.Text = "0";

            //uncheck the checkboxes
            chkComputerNavigation.Checked = false;
            chkLeatherInterior.Checked = false;
            chkStereoSystem.Checked = false;

            //check the Standard radiobutton
            radStandard.Checked = true;
            
            //set focus
            txtVehicleSalePrice.Focus();

            //make a Control array to store the textboxes
            Control[] controlWithValidation = { txtVehicleSalePrice, txtTradeInAllowance };

            //make a loop to traversal all the Controls
            foreach (Control c in controlWithValidation)
            {
                //disable the error icon
                errorProvider.SetError(c, string.Empty);
            }
        }

        /// <summary>
        /// clear the Summary section
        /// </summary>
        private void clearSummary()
        {
            //disable the Finance section
            grpFinance.Enabled = false;

            //set the Empty string to the text of lables
            lblVehicleSalePrice.Text = string.Empty;
            lblOptions.Text = string.Empty;
            lblSubtotal.Text = string.Empty;
            lblSalesTax.Text = string.Empty;
            lblTotal.Text = string.Empty;
            lblTradeInAllowance.Text = string.Empty;
            lblAmountDue.Text = string.Empty;
            lblMonthlyPayment.Text = string.Empty;
        }

        /// <summary>
        /// clear Finance section
        /// </summary>
        private void clearFinance()
        {
            //set default value to scroll bars
            hsbNoOfYear.Value = 3;
            hsbInterestRate.Value = 500;

            //set blank to NoOfYear and InterestRate lable
            lblNoOfYear.Text = string.Empty;
            lblInterestRate.Text = string.Empty;
        }

        void btnCalculateQuote_Click(object sender, EventArgs e)
        {
            //check if all the controls Validate or not
            if (this.ValidateChildren())
            {
                //invoke bindEventHandlerForRadChk method to bind functions to radio buttons and checkboxes
                bindEventHandlerForRadChk();

                //invoke UpdateSummaryFinance method to update summary and finance section
                UpdateSummaryFinance();
            }
        }

        /// <summary>
        /// add functions to radiobuttons and checkboxes
        /// </summary>
        private void bindEventHandlerForRadChk()
        {
            //change radio change summary
            //make an array to store the radio buttons
            RadioButton[] radioButtons = { radStandard, radPearlized, radCustomizedDetailing };
            //make a loop to traversal all the radion buttons
            for (int i = 0; i < radioButtons.Length; i++)
            {
                // use "+=" lable to add fuctions
                radioButtons[i].CheckedChanged += new EventHandler(checkboxRadioButton_CheckedChanged);
            }

            //change checkbox change summary
            //make an array to store the checkboxes
            CheckBox[] checkboxs = { chkComputerNavigation, chkLeatherInterior, chkStereoSystem };
            //make a loop to traversal all the checkboxes
            foreach (CheckBox checkbox in checkboxs)
            {
                // use "+=" lable to add fuctions
                checkbox.CheckedChanged += new EventHandler(checkboxRadioButton_CheckedChanged);
            }
        }

        void checkboxRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //set focus to VehicleSalePrice textbox
            txtVehicleSalePrice.Focus();
            //invoke UpdateSummaryFinance method
            UpdateSummaryFinance();
        }

        void UpdateSummaryFinance()
        {
            //declare a int variable about the Accessories
            int AccessoriesIndex = 0;
            //when the checkbox is checked change AccessoriesIndex
            AccessoriesIndex += chkStereoSystem.Checked ? 1 : 0;
            AccessoriesIndex += chkLeatherInterior.Checked ? 2 : 0;
            AccessoriesIndex += chkComputerNavigation.Checked ? 4 : 0;

            //make an array to store the radioButtons
            RadioButton[] radioButtons = { radStandard, radPearlized, radCustomizedDetailing };
            //declare an int variable use to check which checkbox is checked
            int ExteriorFinishIndex = -1;
            //make a loop to traversal all the radioButtons
            for (int i = 0; i < radioButtons.Length && ExteriorFinishIndex == -1; i++)
            {
                //check which radiobutton is checked
                if (radioButtons[i].Checked)
                {
                    ExteriorFinishIndex = i+1;
                }
            }
            
            //make an instance of SalesQuote according to the inserted values
            SalesQuote salesQuote = new SalesQuote(Decimal.Parse(txtVehicleSalePrice.Text),
                                                    Decimal.Parse(txtTradeInAllowance.Text),
                                                    Decimal.Parse(ConfigurationManager.AppSettings["Government Sales Tax (GST) Rate"]) + Decimal.Parse(ConfigurationManager.AppSettings["Provincial Sales Tax (PST) Rate"]),
                                                    (Accessories)AccessoriesIndex,
                                                    (ExteriorFinish)ExteriorFinishIndex);
            
            //set the text of lables in the summary section
            lblVehicleSalePrice.Text = (Decimal.Parse(txtVehicleSalePrice.Text)).ToString("c");
            lblOptions.Text = (salesQuote.AccessoryCost + salesQuote.FinishCost).ToString("N");
            lblSubtotal.Text = salesQuote.SubTotal.ToString("c");
            lblSalesTax.Text = salesQuote.SalesTax.ToString("N");
            lblTotal.Text = salesQuote.Total.ToString("c");
            lblTradeInAllowance.Text = (0 - Decimal.Parse(txtTradeInAllowance.Text)).ToString("N");
            lblAmountDue.Text = salesQuote.AmountDue.ToString("c");
            
            //check if the AmountDue is greater than 0
            if (Decimal.Parse(lblAmountDue.Text.Replace("$",""))>0)
            {
                //enable the Finance section
                grpFinance.Enabled = true;


                //set the value of the scrool bars to NoOfYear and InterestRate lable
                lblNoOfYear.Text = hsbNoOfYear.Value.ToString();
                lblInterestRate.Text = ((Decimal)hsbInterestRate.Value / 100m).ToString("F2") + "%";

                //add fuctions for the scroll bars
                hsbNoOfYear.ValueChanged += new EventHandler(hsbNoOfYear_ValueChanged);
                hsbInterestRate.ValueChanged += new EventHandler(hsbInterestRate_ValueChanged);

                //invoke the Payment method in AutomotiveManager class use the parameter to calculate the value of MonthlyPayment lable
                updateMonthlyPayment();
            }
            else
            {
                lblMonthlyPayment.Text = string.Empty;
                //disable the Finance section
                grpFinance.Enabled = false;

                txtVehicleSalePrice.Focus();
            }
        }
    }
}
