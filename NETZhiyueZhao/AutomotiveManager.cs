using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace NETZhiyueZhao
{
    //static class provides universal functionality to be used throughout the entire application
    static class AutomotiveManager
    {
        #region Fields
        //declare the bool field and set defalut value
        private static bool _isBeingTested = false;
        //declare the DialogResult field and set defalut value
        private static DialogResult _messageBoxResult = DialogResult.OK;
        #endregion

        #region Properties
        /// <summary>
        /// boolean property is used for unit testing future assignments. The property is used to retrieve the value of the private class variable isBeingTested.
        /// </summary>
        public static bool IsBeingTested
        {
            get
            {
                //return the value
                return _isBeingTested;
            }
        }

        /// <summary>
        /// this property is used for unit testing future assignments where the unit contains a MessageBox. The property is used to retrieve the value of the private class variable messageBoxResult.
        /// </summary>
        public static DialogResult MessageBoxResult
        {
            get
            {
                //return the value
                return _messageBoxResult;
            }
        }
        #endregion

        /// <summary>
        /// use to test if a string could be parsed to decimal
        /// </summary>
        /// <param name="stringValue">the string needed to be tested</param>
        /// <returns>returns true when the stringValue can be parsed to decimal, false when the string cannot be passed to a decimal.</returns>
        public static bool IsNumber(string stringValue)
        {
            decimal number;
            return Decimal.TryParse(stringValue, out number);
        }
        /// <summary>
        /// returns the payment for an annuity based on periodic fixed payments and fixed interest rate.
        /// </summary>
        /// <param name="rate">interest rate</param>
        /// <param name="numberOfPaymentPeriods">Payment Periods</param>
        /// <param name="presentValue">presentValue</param>
        /// <param name="futureValue">futureValue</param>
        /// <param name="type"></param>
        /// <returns>payment for an annuity</returns>
        public static decimal Payment(decimal rate, decimal numberOfPaymentPeriods, decimal presentValue, decimal futureValue = 0, decimal type = 0)
        {
            return (rate == 0) ? presentValue / numberOfPaymentPeriods : rate * (futureValue + presentValue * (decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods)) / (((decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods) - 1) * (1 + rate * type));
        }

        /// <summary>
        /// used to display a MessageBox. During unit testing the MessageBox is surpressed when the property IsBeingTested is true.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caption"></param>
        /// <param name="buttons"></param>
        /// <param name="icon"></param>
        /// <param name="defaultButton"></param>
        /// <returns>a dialog</returns>
        public static DialogResult ShowMessage(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return IsBeingTested ? MessageBoxResult : MessageBox.Show(text, caption, buttons, icon, defaultButton);
        }

        /// <summary>
        /// print the error StackTrace to log file
        /// </summary>
        /// <param name="fileNotFoundException">the Exception that not find the file</param>
        public static void recordError(Exception exception)
        {
            try
            {
                string fileName = string.Format("{0}{1}.log",
                                  ConfigurationManager.AppSettings["Log File Prefix"],
                                  DateTime.Now.ToString("MM-dd-yyyy"));

                string filePath = string.Format(@"{0}\Logs\{1}",
                                                Application.StartupPath,
                                                fileName);

                StreamWriter writer;

                if (!File.Exists(filePath))
                {
                    FileStream stream = new FileStream(filePath, FileMode.Create);
                    writer = new StreamWriter(stream);
                }
                else
                {
                    writer = new StreamWriter(filePath, true);
                }

                writer.WriteLine("Date: " + DateTime.Now.ToString("MM-dd-yyyy"));
                writer.WriteLine("Time: " + DateTime.Now.ToShortTimeString());
                writer.WriteLine("Message: Error reading from car wash data file.");
                writer.WriteLine("Stack trace: " + exception.StackTrace);
                writer.WriteLine("-----------------------------------------");

                writer.Flush();
                writer.Close();
            }
            catch (IOException)
            {
                ShowMessage("An error occurred while writing to the error log file.", "Log File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
