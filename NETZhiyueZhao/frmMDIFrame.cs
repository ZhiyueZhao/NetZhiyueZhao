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
    /// <summary>
    /// the main form inherit Form class
    /// </summary>
    public partial class frmMDIFrame : Form
    {
        private frmVehicleStock vehicleStockForm = null;
        /// <summary>
        /// to create a new frmFrame
        /// </summary>
        public frmMDIFrame()
        {
            //to set up an initial state of the form
            InitializeComponent();

            //set the title of the frmMDIFrame to the ApplicationName in the app configuration file
            this.Text = ConfigurationManager.AppSettings["ApplicationName"];

            //add the fuction of FileOpenSalesQuote button
            mnuFileOpenSalesQuote.Click += new EventHandler(mnuFileOpenSalesQuote_Click);
            //add the fuction of FileExit button
            mnuFileExit.Click += new EventHandler(mnuFileExit_Click);
            //add the fuction of HelpAbout button
            mnuHelpAbout.Click += new EventHandler(mnuHelpAbout_Click);
            //add the fuction of WindowTile button
            mnuWindowTile.Click += new EventHandler(mnuWindowTile_Click);
            //add the fuction of WindowLayer button
            mnuWindowLayer.Click += new EventHandler(mnuWindowLayer_Click);
            //add the fuction of WindowCascade button
            mnuWindowCascade.Click += new EventHandler(mnuWindowCascade_Click);
            //add the fuction of OpenSalesQuote button
            tsiOpenSalesQuote.Click += new EventHandler(mnuFileOpenSalesQuote_Click);
            //add the fuction of Exit button
            tsiExit.Click += new EventHandler(mnuFileExit_Click);
            //add the fuction of About button
            tsiAbout.Click += new EventHandler(mnuHelpAbout_Click);
            //add the fuction of Title button
            tsiTitle.Click += new EventHandler(mnuWindowTile_Click);
            //add the fuction of Layer button
            tsiLayer.Click += new EventHandler(mnuWindowLayer_Click);
            //add the fuction of Cascade button
            tsiCascade.Click += new EventHandler(mnuWindowCascade_Click);
        }

        /// <summary>
        /// Cascade all open forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void mnuWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// Layer all open forms horizontally
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void mnuWindowLayer_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// Tile all open forms vertically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void mnuWindowTile_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary>
        /// Open the About Form as a modal form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Open the Sales Quote form within the MDI frame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void mnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            frmQuote quoteForm = new frmQuote();
            quoteForm.MdiParent = this;
            quoteForm.Show();
        }

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// show the Service form
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void mnuFileOpenService_Click(object sender, EventArgs e)
        {
            frmService serviceForm = new frmService();
            serviceForm.MdiParent = this;
            serviceForm.Show();
        }

        /// <summary>
        /// show the CarWash form
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void mnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            frmCarWash carWashForm = new frmCarWash();

            //when the data load properly
            if(carWashForm.CobListLoad)
            {
                
                carWashForm.MdiParent = this;

                carWashForm.Show();
            }
            //when the data load error
            else
            {
                carWashForm.Close();
            }
            
        }

        /// <summary>
        /// show the form vehicleStock
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void vehicleStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vehicleStockForm == null)
            {
                vehicleStockForm = new frmVehicleStock();

                vehicleStockForm.MdiParent = this;

                vehicleStockForm.Show();

                vehicleStockForm.FormClosed += new FormClosedEventHandler(vehicleStockForm_FormClosed);
            }
            else
            {
                vehicleStockForm.Focus();
            }
        }

        void vehicleStockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            vehicleStockForm = null;
        }
    }
}
