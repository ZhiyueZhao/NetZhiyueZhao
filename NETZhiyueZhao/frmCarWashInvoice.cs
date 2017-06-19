using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NETZhiyueZhao
{
    public partial class frmCarWashInvoice : NETZhiyueZhao.frmInvoice
    {
        public frmCarWashInvoice(string[] _transferInfor)
        {
            InitializeComponent();
            initialData(_transferInfor);
        }

        /// <summary>
        /// set the value of the lables in this form
        /// </summary>
        /// <param name="_transferInfor">a string array get from CarWash form</param>
        private void initialData(string[] _transferInfor)
        {
            lblPackagePrice.Text = _transferInfor[0];
            lblFragrancePrice.Text = _transferInfor[1];
            lblSubtotal.Text = _transferInfor[2];
            lblTaxes.Text = _transferInfor[3];
            lblTotal.Text = _transferInfor[4];
        }
    }
}
