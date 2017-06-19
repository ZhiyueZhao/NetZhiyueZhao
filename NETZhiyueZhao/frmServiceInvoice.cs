using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NETZhiyueZhao
{
    /// <summary>
    /// frmServiceInvoice inherent from frmInvoice
    /// </summary>
    public partial class frmServiceInvoice : NETZhiyueZhao.frmInvoice
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="labourCost"></param>
        /// <param name="partsCost"></param>
        /// <param name="materialsCost"></param>
        /// <param name="subtotal"></param>
        /// <param name="Pst"></param>
        /// <param name="Gst"></param>
        /// <param name="total"></param>
        public frmServiceInvoice(string labourCost, string partsCost,
                                 string materialsCost, string subtotal,
                                 string Pst, string Gst, string total)
        {
            InitializeComponent();
            //invoke intialServiceInvoiceData method to set the data
            intialServiceInvoiceData(labourCost, partsCost, materialsCost, subtotal, Pst, Gst, total);
        }

        /// <summary>
        /// set the data according to the input
        /// </summary>
        /// <param name="labourCost"></param>
        /// <param name="partsCost"></param>
        /// <param name="materialsCost"></param>
        /// <param name="subtotal"></param>
        /// <param name="Pst"></param>
        /// <param name="Gst"></param>
        /// <param name="total"></param>
        private void intialServiceInvoiceData(string labourCost, string partsCost, 
                                                string materialsCost, string subtotal, 
                                                string Pst, string Gst, string total)
        {
            this.lblLabourCost.Text = labourCost;
            this.lblPartsCost.Text = partsCost;
            this.lblMaterialsCost.Text = materialsCost;
            this.lblSubtotal.Text = subtotal;
            this.lblPst.Text = Pst;
            this.lblGst.Text = Gst;
            this.lblTotal.Text = total;
        }
    }
}
