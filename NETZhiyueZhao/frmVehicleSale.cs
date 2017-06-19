using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataTier;
using BusinessTier;
using System.Data.Common;

namespace NETZhiyueZhao
{
    public partial class frmVehicleSale : Form
    {
        private BindingSource _salesStaffBindingSource;
        private SalesStaffData _salesStaffData;
        private DataRow _currentRow;
        private decimal _optionsCharge;
        private VehicleStockData _vehicleStockData;
        private DataTable _vehicleStockTable;
        private BindingSource _bindingSource;

        /// <summary>
        /// the constructor
        /// </summary>
        /// <param name="currentIndex">the index of current row</param>
        /// <param name="optionsCharge">the option fee</param>
        /// <param name="vehicleStockData">the data retrive form the database</param>
        public frmVehicleSale(int currentIndex, decimal optionsCharge, VehicleStockData vehicleStockData)
        {
            _optionsCharge = optionsCharge;
            _vehicleStockData = vehicleStockData;
            //_vehicleStockTable = vehicleStockData.GetAllRows();
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _vehicleStockData.GetAllRows();

            //Filters the data source to only show rows that have a value of 0 in column SoldBy
            _bindingSource.Filter = "SoldBy = 0";
            //_vehicleStockTable = (DataTable)_bindingSource.DataSource;
            //_currentRow = _vehicleStockTable.Rows[currentIndex];
            _currentRow = ((DataTable)_bindingSource.DataSource).Rows[currentIndex];

            InitializeComponent();
            frmVehicleSaleSection_Load();
            frmSalesStaffSection_Load();

            btnFirst.Click += new EventHandler(btnFirst_Click);
            btnLast.Click += new EventHandler(btnLast_Click);
            btnPrevious.Click += new EventHandler(btnPrevious_Click);
            btnNext.Click += new EventHandler(btnNext_Click);
            btnSell.Click += new EventHandler(btnSell_Click);
        }

        /// <summary>
        /// event handler when click sell button, update the vehicle table
        /// </summary>
        void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                _currentRow["OptionsPrice"] = _optionsCharge;
                _currentRow["SoldBy"] = ((DataRowView)_salesStaffBindingSource.Current).Row["ID"];
                

                _vehicleStockData.Update();

                this.Close();
            }
            catch (Exception ex)
            {
                // Display an error message
                AutomotiveManager.ShowMessage("An error occurred while attempting to sell the vehicle.",
                                              "Database Error",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);

                AutomotiveManager.recordError(ex);
                //close the form
                this.Shown += new EventHandler(frmVehicleSale_Shown);
            }
        }

        /// <summary>
        /// load the sales section of the form by using the passed in values
        /// </summary>
        private void frmVehicleSaleSection_Load()
        {
            lblStockNumber.Text = _currentRow["StockNumber"].ToString();
            lblYear.Text = _currentRow["ManufacturedYear"].ToString();
            lblBasePrice.Text = Decimal.Parse(_currentRow["BasePrice"].ToString()).ToString("c");
            lblMake.Text = _currentRow["Make"].ToString();
            lblOptions.Text = _optionsCharge.ToString("c");
            lblModel.Text = _currentRow["Model"].ToString();

        }

        /// <summary>
        /// load the salses staff information form the database
        /// </summary>
        private void frmSalesStaffSection_Load()
        {
            try
            {
                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AMDatabase.mdb";

                string tableName = "SalesStaff";
                string selectQuery =
                    string.Format("SELECT * FROM {0}", tableName);

                // Construct an instance of the DataTier
                _salesStaffData = new SalesStaffData(connectionString, tableName, selectQuery);

                _salesStaffBindingSource = new BindingSource();

                _salesStaffBindingSource.PositionChanged += new EventHandler(_salesStaffBindingSource_PositionChanged);

                _salesStaffBindingSource.DataSource = _salesStaffData.GetAllRows();

                bindControls();

                updateUI();
            }
            catch (DbException dbex)
            {
                // Display an error message
                AutomotiveManager.ShowMessage("An error occurred fetching sales staff data.",
                                              "Database Error",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);

                AutomotiveManager.recordError(dbex);
                //close the form
                this.Shown += new EventHandler(frmVehicleSale_Shown);
            }
            catch (NullReferenceException nuex)
            {
                // Display an error message
                AutomotiveManager.ShowMessage("There are currently no sales staff entered in the system.",
                                              "Vehicle Sale",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Exclamation);

                AutomotiveManager.recordError(nuex);
                //close the form
                this.Shown += new EventHandler(frmVehicleSale_Shown);
            }
        }

        /// <summary>
        /// when occur an exception, handle to close the form
        /// </summary>
        void frmVehicleSale_Shown(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// event handler that when click next, previous, last or first button, update the sales staff info
        /// </summary>
        void _salesStaffBindingSource_PositionChanged(object sender, EventArgs e)
        {
            updateUI();
        }

        /// <summary>
        /// event handler that when click next button
        /// </summary>
        void btnNext_Click(object sender, EventArgs e)
        {
            _salesStaffBindingSource.MoveNext();
        }

        /// <summary>
        /// event handler that when click previous button
        /// </summary>
        void btnPrevious_Click(object sender, EventArgs e)
        {
            _salesStaffBindingSource.MovePrevious();
        }

        /// <summary>
        /// event handler that when click last button
        /// </summary>
        void btnLast_Click(object sender, EventArgs e)
        {
            _salesStaffBindingSource.MoveLast();
        }

        /// <summary>
        /// event handler that when click first button
        /// </summary>
        void btnFirst_Click(object sender, EventArgs e)
        {
            _salesStaffBindingSource.MoveFirst();
        }

        /// <summary>
        /// Binds the form controls to the BindingSource.
        /// </summary>
        private void bindControls()
        {
            //DataBindings is a property of the control
            lblFirstName.DataBindings.Add("Text", _salesStaffBindingSource, "FirstName");
            lblLastName.DataBindings.Add("Text", _salesStaffBindingSource, "LastName");
        }

        /// <summary>
        /// Updates controls on the form that are unbound.
        /// also for final exam
        /// </summary>
        private void updateUI()
        {
            lblCommission.Text = Commission.GetCommission((DateTime)(((DataRowView)_salesStaffBindingSource.Current).Row["StartDate"]),
                decimal.Parse(_currentRow["BasePrice"].ToString()), _optionsCharge).ToString("C");
            lblPosition.Text = string.Format("{0} of {1}", _salesStaffBindingSource.Position + 1, _salesStaffBindingSource.Count);
        }
    }    
}
