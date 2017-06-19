using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace NETZhiyueZhao
{
    public partial class frmInvoice : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public frmInvoice()
        {
            InitializeComponent();
            intialData();
        }

        /// <summary>
        /// set the company name, address, post code, and date
        /// </summary>
        protected void intialData()
        {
            lblCompanyName.Text = ConfigurationManager.AppSettings["Company Name"];
            lblCompanyAddress.Text = ConfigurationManager.AppSettings["Company Address"];
            lblCityProvincePostal.Text = ConfigurationManager.AppSettings["Company City"] +
                                         ", " +
                                         ConfigurationManager.AppSettings["Company Province"] +
                                         " " +
                                         ConfigurationManager.AppSettings["Company Postal"];
            lblCompanyPhone.Text = ConfigurationManager.AppSettings["Company Phone"];
            
            lblData.Text = "Date: " + DateTime.Now.ToString("MM/dd/yyyy").Replace("-", "/");
        }

        /// <summary>
        /// set eventhandler to the print mune
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFilePrint_Click(object sender, EventArgs e)
        {
            printForm.Print(this, Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly);
        }
    }
}
