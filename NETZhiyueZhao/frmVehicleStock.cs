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
    public partial class frmVehicleStock : Form
    {
        private VehicleStockData _vehicleStockData;
        private BindingSource _bindingSource;
        public bool loadError = false;

        /// <summary>
        /// the constructor of the form
        /// </summary>
        public frmVehicleStock()
        {
            InitializeComponent();
            frmVehicleStock_Load();

            this.FormClosed += new FormClosedEventHandler(frmVehicleStock_FormClosed);
        }

        /// <summary>
        /// Handles the FormClosed event of the form.
        /// </summary>
        void frmVehicleStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            // When an instance of the DataTier is constructed
            if (_vehicleStockData != null)
            {
                // Close the connection to the data source
                _vehicleStockData.Close();
            }
        }

        /// <summary>
        /// Handles the Load event of the form.
        /// </summary>
        private void frmVehicleStock_Load()
        {
            // Get string data from the Resources.resx file
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AMDatabase.mdb";
            string tableName = "VehicleStock";
            string selectQuery =
                string.Format("SELECT ID, StockNumber, ManufacturedYear, Make, Model, Mileage, Automatic, Colour, BasePrice, SoldBy, OptionsPrice FROM {0} WHERE SoldBy = 0", tableName);

            try
            {
                // Construct an instance of the DataTier
                _vehicleStockData = new VehicleStockData(connectionString, tableName, selectQuery);

                // Constructs a BindingSource object
                // BindingSource - defines the data source of the form.
                _bindingSource = new BindingSource();

                // Set the data source of the form to the data table from the DataTier
                _bindingSource.DataSource = _vehicleStockData.GetAllRows();

                // Set the data source of the DataGridView to the binding source
                dgvVehicles.DataSource = _bindingSource;

                // Hides the ID column in the datagrid view
                dgvVehicles.Columns["ID"].Visible = false;

                // Hides the SoldBy column in the datagrid view
                dgvVehicles.Columns["SoldBy"].Visible = false;

                // Hides the OptionsPrice column in the datagrid view
                dgvVehicles.Columns["OptionsPrice"].Visible = false;
            }
            catch (Exception ex)
            {
                // Display an error message
                AutomotiveManager.ShowMessage("An error occurred fetching vehicle stock data.",
                                              "Database Error",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);

                AutomotiveManager.recordError(ex);

                this.Shown += new EventHandler(frmVehicleStock_Shown);
            }
        }

        void frmVehicleStock_Shown(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// open EditVehicleStockForm with the editype
        /// </summary>
        /// <param name="editype">the edit type</param>
        private void openEditVehicleStockForm(frmEditVehicleStock.EditType editype)
        {
            mnuFileNewVehicle.Visible = false;

            // Disable this form
            // Prevents the user from interacting with the form while the edit form is open
            this.Enabled = false;

            // Construct a new edit form
            frmEditVehicleStock editForm = new frmEditVehicleStock(editype, _bindingSource, _vehicleStockData);

            // Adds an FormClosedEventHandler to the edit form
            // An anonymous method is used to implement the handler
            // Reason: we can use the 'this' reference in the handler to reference this
            //         form in the other form
            editForm.FormClosed += new FormClosedEventHandler(delegate(object sender, FormClosedEventArgs e)
            {
                this.Enabled = true;
                mnuFileNewVehicle.Visible = true;
            });

            editForm.MdiParent = this.MdiParent;

            // Show the form
            editForm.Show();
        }

        /// <summary>
        /// the event handler when the mnuEdit button clicked
        /// </summary>
        private void mnuEdit_Click(object sender, EventArgs e)
        {
            openEditVehicleStockForm(frmEditVehicleStock.EditType.Eidt);
        }

        /// <summary>
        /// the event handler when newVehicleToolStripMenuItem clicked
        /// </summary>
        private void newVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openEditVehicleStockForm(frmEditVehicleStock.EditType.New);
        }

        /// <summary>
        /// the event handler when double click the item in vehicle data grid view
        /// </summary>
        private void dgvVehicles_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            openEditVehicleStockForm(frmEditVehicleStock.EditType.Eidt);
        }

        /// <summary>
        /// the event handler when click the remove context menu in vehicle data grid view
        /// </summary>
        private void mnuRemove_Click(object sender, EventArgs e)
        {
            
            // Get a reference to the selected row
            DataGridViewRow selectedRow = dgvVehicles.CurrentRow;

            DialogResult result = AutomotiveManager.ShowMessage(String.Format("Are you sure you want to remove {0} {1} {2}",
                                          selectedRow.Cells["ManufacturedYear"].Value,
                                          selectedRow.Cells["Make"].Value,
                                          selectedRow.Cells["Model"].Value),
                                "Remove Vehicle",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Remove the row from the datagridview's row collection
                    dgvVehicles.Rows.Remove(selectedRow);

                    // Update the data source bound to the datagridview
                    this._vehicleStockData.Update();

                    // When rows still exist in the data grid view
                    if (dgvVehicles.Rows.Count > 0)
                    {
                        // Select the last row
                        dgvVehicles.Rows[dgvVehicles.Rows.Count - 1].Selected = true;
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message
                    AutomotiveManager.ShowMessage(String.Format("An error occurred removing {0} {1} {2}",
                                                    selectedRow.Cells["ManufacturedYear"].Value,
                                                    selectedRow.Cells["Make"].Value,
                                                    selectedRow.Cells["Model"].Value),
                                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    AutomotiveManager.recordError(ex);
                } 
            }
        }

        /// <summary>
        /// Handles the RowsAdded event of the DataGridView.
        /// Sets the context menu of the row.
        /// </summary>
        private void dgvVehicles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // e.RowIndex - the index of the added row
            dgvVehicles.Rows[e.RowIndex].ContextMenuStrip = this.contextMenuStrip;
        }

        /// <summary>
        /// the event handler after delete the row in the data grid view
        /// </summary>
        private void dgvVehicles_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // When the mouse button is the right button
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // Set the active cell of the DataGridView
                dgvVehicles.CurrentCell = dgvVehicles.Rows[e.RowIndex].Cells[1];
            }
        } 
    }
}
