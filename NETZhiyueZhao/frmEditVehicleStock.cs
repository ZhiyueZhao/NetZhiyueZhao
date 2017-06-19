using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataTier;

namespace NETZhiyueZhao
{
    public partial class frmEditVehicleStock : Form
    {
        /// <summary>
        /// Defines the edit type for editing the Contact.
        /// </summary>
        public enum EditType
        {
            New,
            Eidt
        }

        private BindingSource _bindingSource;
        private VehicleStockData _vehicleStockData;
        private EditType _editType;
        private bool _errorFocus = false;
        private DialogResult _result;

        /// <summary>
        /// the constructor of this form
        /// </summary>
        /// <param name="editType">the type of how to open this form</param>
        /// <param name="bindingSource">the data source</param>
        /// <param name="vehicleStockData">the data use to connect to the database</param>
        public frmEditVehicleStock(EditType editType, BindingSource bindingSource, VehicleStockData vehicleStockData)
        {
            _bindingSource = bindingSource;
            _vehicleStockData = vehicleStockData;
            _editType = editType;

            InitializeComponent();
            frmEditVehicleStock_Load();

            //Validation
            txtStockNumber.Validating += new CancelEventHandler(txtStockNumber_Validating);
            txtStockNumber.Validated += new EventHandler(txtBox_Validated);

            txtMake.Validating += new CancelEventHandler(txtBoxRequired_Validating);
            txtMake.Validated += new EventHandler(txtBox_Validated);

            txtModel.Validating += new CancelEventHandler(txtBoxRequired_Validating);
            txtModel.Validated += new EventHandler(txtBox_Validated);

            txtColour.Validating += new CancelEventHandler(txtBoxRequired_Validating);
            txtColour.Validated += new EventHandler(txtBox_Validated);

            txtYear.Validating += new CancelEventHandler(txtYear_Validating);
            txtYear.Validated += new EventHandler(txtBox_Validated);


            txtMileage.Validating += new CancelEventHandler(txtNumeric_Validating);
            txtMileage.Validated += new EventHandler(txtBox_Validated);

            txtBasePrice.Validating += new CancelEventHandler(txtNumeric_Validating);
            txtBasePrice.Validated += new EventHandler(txtBox_Validated);

            this.FormClosing += new FormClosingEventHandler(frmEditVehicleStock_FormClosing);
        }

        /// <summary>
        /// the event handler when close the form
        /// </summary>
        void frmEditVehicleStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Applies pending changes to the binding source
            _bindingSource.EndEdit();

            // When the edit mode is new or current row has changes
            if (_editType == EditType.New || ((DataRowView)_bindingSource.Current).Row.RowState == DataRowState.Modified)
            {
                // When this event is not triggered from the btnSave_Click event
                if (_result == DialogResult.None)
                {
                    // Ask the user if they wish to save the changes
                    _result = AutomotiveManager.ShowMessage("Save changes?", "New Vehicle Stock or Edit Vehicle Stock", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3);
                }

                // Evaluate the users choice
                switch (_result)
                {
                    case DialogResult.Yes:
                        // Cancels the form close when the record cannot be saved
                        e.Cancel = !saveCurrentRecord();
                        break;
                    case DialogResult.No:
                        // Rollback changes made to the data source
                        ((DataTable)_bindingSource.DataSource).RejectChanges();
                        break;
                    case DialogResult.Cancel:
                        // Cancels the form close
                        e.Cancel = true;
                        break;
                }
            }

            // Reset the dialog result
            _result = DialogResult.None;
        }

        /// <summary>
        /// the event handler to check if the value of textbox is a numeric value
        /// </summary>
        void txtNumeric_Validating(object sender, CancelEventArgs e)
        {
            if (!AutomotiveManager.IsNumber(((TextBox)sender).Text.Trim()))
            {
                // Prevents the validated event from being triggered
                e.Cancel = true;

                if (!_errorFocus)
                {
                    ((TextBox)sender).Focus();
                    _errorFocus = true;
                }

                // Show the error icon beside the control
                errorProvider.SetError(((Control)sender), "Please enter a numeric value for this field.");
            }
        }

        /// <summary>
        /// the event handler to check if the value of textbox is a year value(4 digits)
        /// </summary>
        void txtYear_Validating(object sender, CancelEventArgs e)
        {
            if (!AutomotiveManager.IsNumber(txtYear.Text.Trim()) || txtYear.Text.Trim().Length != 4)
            {
                // Prevents the validated event from being triggered
                e.Cancel = true;

                if (!_errorFocus)
                {
                    ((TextBox)sender).Focus();
                    _errorFocus = true;
                }

                // Show the error icon beside the control
                errorProvider.SetError(txtYear, "Please enter a valid four digit year. Eg. 1977");
            }
        }

        /// <summary>
        /// the event handler to check if the value of textbox is a required value
        /// </summary>
        void txtBoxRequired_Validating(object sender, CancelEventArgs e)
        {
            if ((((TextBox)sender).Text = ((TextBox)sender).Text.Trim()) == string.Empty)
            {
                // Prevents the validated event from being triggered
                e.Cancel = true;

                if (!_errorFocus)
                {
                    ((TextBox)sender).Focus();
                    _errorFocus = true;
                }

                // Show the error icon beside the control
                errorProvider.SetError(((Control)sender), "Please enter a value for this field.");
            }
        }

        /// <summary>
        /// the event handler to Clear the error icon from the control
        /// </summary>
        void txtBox_Validated(object sender, EventArgs e)
        {
            // Clear the error icon from the control
            errorProvider.SetError(((Control)sender), string.Empty); 
        }

        /// <summary>
        /// the event handler to check if the StockNumber is exist or not
        /// </summary>
        void txtStockNumber_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;

            if ((txtStockNumber.Text = txtStockNumber.Text.Trim()) == string.Empty)
            {
                // Set the error message
                errorMessage = "Please enter a value for this field.";
            }
            else if (_vehicleStockData.IsDuplicateStockNumber(txtStockNumber.Text) && _editType != EditType.Eidt)
            {
                errorMessage = "This stock number is used by another vehicle. Please enter another stock number.";
            }

            // If an error occured
            if (errorMessage != string.Empty)
            {
                // Prevents the validated event from being triggered
                e.Cancel = true;

                if (!_errorFocus)
                {
                    // Set focus to the field
                    txtStockNumber.Focus();

                    _errorFocus = true;
                }

                // Show the error icon beside the control
                errorProvider.SetError(txtStockNumber, errorMessage);
            }
        }



        /// <summary>
        /// Handles the Load event of the form.
        /// </summary>
        private void frmEditVehicleStock_Load()
        {
            if (_editType == EditType.Eidt)
            {
                // Set the title of the form
                this.Text = "Edit Vehicle";

                try
                {
                    // Bind data source to the form controls
                    bindControls();
                }
                catch (Exception ex)
                {
                    // Display an error message
                    AutomotiveManager.ShowMessage("Could not load record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    AutomotiveManager.recordError(ex);

                    this.Shown += new EventHandler(delegate(object s, EventArgs evt)
                    {
                        this.Close();
                    });
                } 
            }
            else
            {
                // Set the title of the form
                this.Text = "New Vehicle";
                radAutomatic.Checked = true;
            }
        }

        /// <summary>
        /// Binds the form controls to the binding source.
        /// </summary>
        private void bindControls()
        {
            txtStockNumber.DataBindings.Add("Text", this._bindingSource, "StockNumber");
            txtYear.DataBindings.Add("Text", this._bindingSource, "ManufacturedYear");
            txtMake.DataBindings.Add("Text", this._bindingSource, "Make");
            txtModel.DataBindings.Add("Text", this._bindingSource, "Model");
            txtMileage.DataBindings.Add("Text", this._bindingSource, "Mileage");
            txtColour.DataBindings.Add("Text", this._bindingSource, "Colour");
            txtBasePrice.DataBindings.Add("Text", this._bindingSource, "BasePrice");
            radAutomatic.DataBindings.Add("Checked", this._bindingSource, "Automatic");

            txtStockNumber.Enabled = false;
        }

        /// <summary>
        /// the event handler when click the save button
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Used in the switch statment in the FormClosing
            _result = DialogResult.Yes;

            // Close this form
            this.Close();
        }

        /// <summary>
        /// the method to save the current insert
        /// </summary>
        /// <returns>ture if SuccessfulSaved, false when failed</returns>
        private bool saveCurrentRecord()
        {
            _errorFocus = false;

            bool isSuccessfulSaved = false;

            if (this.ValidateChildren())
            {
                try
                {
                    // When the edit mode of the form is new
                    if (_editType == EditType.New)
                    {
                        // Get a reference to the data table from the bind source object
                        DataTable dataTable = (DataTable)_bindingSource.DataSource;

                        // Add a new row to the data table
                        DataRow row = dataTable.NewRow();

                        // Define all the columns and values in the row
                        row["StockNumber"] = txtStockNumber.Text.Trim();
                        row["ManufacturedYear"] = txtYear.Text.Trim();
                        row["Make"] = txtMake.Text.Trim();
                        row["Model"] = txtModel.Text.Trim();
                        row["Mileage"] = txtMileage.Text.Trim();
                        row["Automatic"] = radAutomatic.Checked;
                        row["Colour"] = txtColour.Text.Trim();
                        row["BasePrice"] = txtBasePrice.Text.Trim();

                        // Add the new row to the data table
                        dataTable.Rows.Add(row);
                    }

                    // Update the data set to the data source
                    _vehicleStockData.Update();

                    isSuccessfulSaved = true;
                }
                catch (Exception ex)
                {
                    // Display an error message
                    AutomotiveManager.ShowMessage("An error occured while saving the contact.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AutomotiveManager.recordError(ex);
                }
            }

            return isSuccessfulSaved;
        }
    }
}
