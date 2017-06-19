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
    public partial class frmService : Form
    {
        #region Fields
        private int rowNumber = 1;
        private decimal _subtotalDisplay = 0;
        private decimal _pstDisplay = 0;
        private decimal _gstDisplay = 0;
        private decimal _totalDisplay = 0;
        #endregion

        #region Properties
        /// <summary>
        /// return the SubtotalDisplay property
        /// </summary>
        public decimal SubtotalDisplay
        {
            get
            {
                return _subtotalDisplay;
            }

            private set
            {
                _subtotalDisplay = value;
            }
        }

        /// <summary>
        /// return the PstDisplay property
        /// </summary>
        public decimal PstDisplay
        {
            get
            {
                return _pstDisplay;
            }

            private set
            {
                _pstDisplay = value;
            }
        }

        /// <summary>
        /// return the GstDisplay property
        /// </summary>
        public decimal GstDisplay
        {
            get
            {
                return _gstDisplay;
            }

            private set
            {
                _gstDisplay = value;
            }
        }

        /// <summary>
        /// return the TotalDisplay property
        /// </summary>
        public decimal TotalDisplay
        {
            get
            {
                return _totalDisplay;
            }

            private set
            {
                _totalDisplay = value;
            }
        }

        /// <summary>
        /// return the LabourCost property
        /// </summary>
        public decimal LabourCost { get; private set; }

        /// <summary>
        /// return the PartsCost property
        /// </summary>
        public decimal PartsCost { get; private set; }

        /// <summary>
        /// return the MatericalsCost property
        /// </summary>
        public decimal MatericalsCost { get; private set; }
        #endregion

        #region Constractor
        public frmService()
        {
            InitializeComponent();

            //initial the data in drop down box
            initialData();

            //Validation
            txtDescription.Validating += new CancelEventHandler(txtDescription_Validating);
            txtDescription.Validated += new EventHandler(txtDescription_Validated);
            cboType.Validating += new CancelEventHandler(cboType_Validating);
            cboType.Validated += new EventHandler(cboType_Validated);
            txtCost.Validating += new CancelEventHandler(txtCost_Validating);
            txtCost.Validated += new EventHandler(txtCost_Validated);

            //add eventhandler to the textbox when it got focus
            txtDescription.GotFocus += new EventHandler(txtBox_GotFocus);
            txtCost.GotFocus += new EventHandler(txtBox_GotFocus);

            //add button click eventhandler
            btnAdd.Click += new EventHandler(btnAdd_Click);

            dgvServiceList.SelectionChanged += new EventHandler(dgvServiceList_SelectionChanged);

            //initial data state
            dgvLblClear();
            clearForm();

            mnuDescriptionGenerate.Click += new EventHandler(mnuDescriptionGenerate_Click);
        }
        #endregion

        #region EventHandaler
        /// <summary>
        /// Generate menu stript click event, using the information of this form to generate a service invoice form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void mnuDescriptionGenerate_Click(object sender, EventArgs e)
        {
            //invoke the frmServiceInvoice constructor
            frmServiceInvoice serviceInvoiceForm = new frmServiceInvoice(this.LabourCost.ToString("c"),
                                                                         this.PartsCost.ToString("f2"),
                                                                         this.MatericalsCost.ToString("f2"),
                                                                         this.SubtotalDisplay.ToString("c"),
                                                                         this.PstDisplay.ToString("f2"),
                                                                         this.GstDisplay.ToString("f2"),
                                                                         this.TotalDisplay.ToString("c"));
            
            //set the mdi parent
            serviceInvoiceForm.MdiParent = this.MdiParent;

            //clear this form
            dgvLblClear();
            txtDescription.Focus();

            serviceInvoiceForm.Show();
        }

        /// <summary>
        /// select all when text box got focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtBox_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        /// <summary>
        /// disable selection change of the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgvServiceList_SelectionChanged(object sender, EventArgs e)
        {
            //disable the blue cell
            dgvServiceList.ClearSelection();
        }

        /// <summary>
        /// when click add button, add a list of the information input to the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnAdd_Click(object sender, EventArgs e)
        {
            //when validate
            if (this.ValidateChildren())
            {
                //invoke ServiceInvoice constructor
                ServiceInvoice serviceInvoice = new ServiceInvoice(Decimal.Parse(ConfigurationManager.AppSettings.Get("Provincial Sales Tax (PST) Rate")),
                                                                    Decimal.Parse(ConfigurationManager.AppSettings.Get("Government Sales Tax (GST) Rate")));

                CostType costType = (CostType)(cboType.SelectedIndex);

                serviceInvoice.AddCost(costType, Decimal.Parse(txtCost.Text));

                //add new row to the data grid view
                dgvServiceList.Rows.Add(new[] { rowNumber.ToString(), 
                                                txtDescription.Text, 
                                                cboType.SelectedItem.ToString(), 
                                                Decimal.Parse(txtCost.Text).ToString("c") });

                rowNumber++;

                //calculate display values
                this.LabourCost = this.LabourCost + serviceInvoice.LabourCost;
                this.PartsCost = this.PartsCost + serviceInvoice.PartsCost;
                this.MatericalsCost = this.MatericalsCost + serviceInvoice.MaterialsCost;

                //calculate the total values
                this.SubtotalDisplay += serviceInvoice.SubTotal;
                this.PstDisplay += serviceInvoice.PSTCharged;
                this.GstDisplay += serviceInvoice.GSTCharged;
                this.TotalDisplay += serviceInvoice.Total;

                //display the values
                lblSubtotal.Text = this.SubtotalDisplay.ToString("c");
                lblPst.Text = this.PstDisplay.ToString("F2");
                lblGst.Text = this.GstDisplay.ToString("F2");
                lblTotal.Text = this.TotalDisplay.ToString("c");

                clearForm();

                mnuDescriptionGenerate.Enabled = true;
                //enable context mune strip
                mnuContextClear.Enabled = true;
            }
        }

        /// <summary>
        /// Cost textbox validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtCost_Validated(object sender, EventArgs e)
        {
            //disable the error icon by invoke SetError method in errorProvider control and set empty to the Cost textbox
            errorProvider.SetError(txtCost, string.Empty);
        }

        /// <summary>
        /// Cost textbox validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtCost_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;

            if(!AutomotiveManager.IsNumber(txtCost.Text))
            {
                errorMessage = "Please enter a numeric value.";
            }
            else if(Decimal.Parse(txtCost.Text) < 0)
            {
                errorMessage = "Please enter a value greater than zero.";
            }

            if(!errorMessage.Equals(string.Empty))
            {
                //set the CancelEventArgs' Cancel property to true
                e.Cancel = true;
                //invoke SetError method in errorProvider control and set the errorMessage to Cost textbox
                errorProvider.SetError(txtCost, errorMessage);
                //set focus to Cost textbox
                txtCost.Focus();
            }
        }

        /// <summary>
        /// Type combobox validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cboType_Validated(object sender, EventArgs e)
        {
            //disable the error icon by invoke SetError method in errorProvider control and set empty to the Type comboBox
            errorProvider.SetError(cboType, string.Empty);
        }
        
        /// <summary>
        /// Type combobox validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cboType_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;

            if (cboType.SelectedIndex==-1)
            {
                errorMessage = "Please select a service type.";

                //set the CancelEventArgs' Cancel property to true
                e.Cancel = true;
                //invoke SetError method in errorProvider control and set the errorMessage to Description textbox
                errorProvider.SetError(cboType, errorMessage);
            }
        }

        /// <summary>
        /// Description textbox validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtDescription_Validated(object sender, EventArgs e)
        {
            //disable the error icon by invoke SetError method in errorProvider control and set empty to the Description textbox
            errorProvider.SetError(txtDescription, string.Empty);
        }

        /// <summary>
        ///  Description textbox validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;

            if (txtDescription.Text.Trim().Equals(string.Empty))
            {
                errorMessage = "Please enter a description.";

                //set the CancelEventArgs' Cancel property to true
                e.Cancel = true;
                //invoke SetError method in errorProvider control and set the errorMessage to Description textbox
                errorProvider.SetError(txtDescription, errorMessage);
                //set focus to Description textbox
                txtDescription.Focus();
            }
        }

        /// <summary>
        /// clear Tool Strip Menu Item, clear the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvLblClear();
            txtDescription.Focus();
        }
        #endregion

        #region Method
        /// <summary>
        /// initial data of the drop down box
        /// </summary>
        private void initialData()
        {
            //option list
            List<String> TypesList = new List<string>();

            foreach (CostType ct in Enum.GetValues(typeof(CostType)))
            {
                //add to list
                TypesList.Add(ct.ToString());
            }

            cboType.DataSource = TypesList;
        }

        /// <summary>
        /// clear the Description and Cost text box, and type combo box
        /// </summary>
        private void clearForm()
        {
            txtDescription.Clear();

            txtCost.Clear();

            cboType.SelectedIndex = -1;
        }

        /// <summary>
        /// clear the data grid view
        /// </summary>
        private void dgvLblClear()
        {
            this.rowNumber = 1;
            this.LabourCost = 0;
            this.PartsCost = 0;
            this.MatericalsCost = 0;

            this.SubtotalDisplay = 0;
            this.GstDisplay = 0;
            this.PstDisplay = 0;
            this.TotalDisplay = 0;

            dgvServiceList.Rows.Clear();
            lblSubtotal.Text = string.Empty;
            lblPst.Text = string.Empty;
            lblGst.Text = string.Empty;
            lblTotal.Text = string.Empty;

            mnuContextClear.Enabled = false;

            mnuDescriptionGenerate.Enabled = false;
        }
        #endregion
    }
}
