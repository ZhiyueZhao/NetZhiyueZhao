using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BusinessTier;
using System.Configuration;

namespace NETZhiyueZhao
{
    public partial class frmCarWash : Form
    {
        #region variables, structure and the Properties
        private decimal packagePrice = 0;
        private decimal fragrancePrice = 0;

        private struct DropDownItem
        {
            public string Description { get; set; }
            public decimal Price { get; set; }
        }

        private List<DropDownItem> _packageItems;

        private List<DropDownItem> _fragranceItems;

        private List<string> _interiorItem;

        private List<string> _exteriorItem;

        public bool CobListLoad { get; private set; }

        public string[] TransferInfor { get; private set; }
        #endregion

        #region Constructor
        public frmCarWash()
        {
            InitializeComponent();
            //initial the CobListLoad
            CobListLoad = true;

            try
            {
                loadData();

                //set the data to the combom box
                foreach (DropDownItem item in _packageItems)
                {
                    cboPackage.Items.Add(item.Description);
                }

                foreach (DropDownItem item in _fragranceItems)
                {
                    cboFragrance.Items.Add(item.Description);
                }
            }
            catch (FileNotFoundException fileNotFoundException)
            {

                AutomotiveManager.ShowMessage("An error occurred while loading car wash data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //when occour the error print the error file
                AutomotiveManager.recordError(fileNotFoundException);
                //when occour the error set to false
                CobListLoad = false;
            }

            cboPackage.SelectedValueChanged += new EventHandler(cboPackage_SelectedValueChanged);
            cboFragrance.SelectedValueChanged += new EventHandler(cboFragrance_SelectedValueChanged);
            mnuCarWashGenerateInvoice.Click += new EventHandler(mnuCarWashGenerateInvoice_Click);

            //check if the cobom box have load the items
            if (cboPackage.Items.Count * cboFragrance.Items.Count > 0)
            {
                cboPackage.SelectedIndex = 0;
                cboFragrance.SelectedIndex = 2;
            }
        }
        #endregion

        #region EventHandlers
        /// <summary>
        /// event handler that when the user click the CarWashGenerateInvoice button
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        void mnuCarWashGenerateInvoice_Click(object sender, EventArgs e)
        {
            frmCarWashInvoice carWashInvoiceForm = new frmCarWashInvoice(this.TransferInfor);
            carWashInvoiceForm.MdiParent = this.MdiParent;
            carWashInvoiceForm.Show();

            cboPackage.SelectedIndex = 0;
            cboFragrance.SelectedIndex = 2;
            mnuCarWashGenerateInvoice.Enabled = false;

            lblSubTotal.Text = string.Empty;
            lblPst.Text = string.Empty;
            lblGst.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }

        /// <summary>
        /// event handler that when change the value of the Fragrance combom box
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        void cboFragrance_SelectedValueChanged(object sender, EventArgs e)
        {
            lstInterior.Items[0] = lstInterior.Items[0].ToString().Split('-')[0] + "-" + cboFragrance.SelectedItem.ToString();

            fragrancePrice = _fragranceItems[cboFragrance.SelectedIndex].Price;

            displayAmount();

            mnuCarWashGenerateInvoice.Enabled = true;
        }

        /// <summary>
        /// event handler that when change the value of the Package combom box
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        void cboPackage_SelectedValueChanged(object sender, EventArgs e)
        {
            //clear the terior list box
            lstInterior.Items.Clear();
            lstExterior.Items.Clear();

            for (int i = 0; i <= cboPackage.SelectedIndex; i++)
            {
                //when the Interior item is the Fragrance, show the Fragrance and the Fragrance used
                //when the Interior item is not, just show the Item
                lstInterior.Items.Add((i == 0 && cboFragrance.SelectedIndex != -1) ? 
                                      (_interiorItem[i] + "-" + cboFragrance.SelectedItem.ToString()) : 
                                      _interiorItem[i]);

                lstExterior.Items.Add(_exteriorItem[i]);
            }

            packagePrice = _packageItems[cboPackage.SelectedIndex].Price;

            displayAmount();

            mnuCarWashGenerateInvoice.Enabled = true;
        }
        #endregion

        #region methods
        /// <summary>
        /// display the amount of the lable and make Transfer Information that used to the CarWashInvoice
        /// </summary>
        private void displayAmount()
        {
            CarWashInvoice carWashInvoice = new CarWashInvoice(Decimal.Parse(ConfigurationManager.AppSettings.Get("Provincial Sales Tax (PST) Rate")),
                                                               Decimal.Parse(ConfigurationManager.AppSettings.Get("Government Sales Tax (GST) Rate")),
                                                               packagePrice,
                                                               fragrancePrice);

            lblSubTotal.Text = carWashInvoice.SubTotal.ToString("c");
            lblPst.Text = carWashInvoice.PSTCharged.ToString("f2");
            lblGst.Text = carWashInvoice.GSTCharged.ToString("f2");
            lblTotal.Text = carWashInvoice.Total.ToString("c");

            this.TransferInfor = new string[] {carWashInvoice.PackageCost.ToString("c"), 
                                               carWashInvoice.FragranceCost.ToString("f2"),
                                               carWashInvoice.SubTotal.ToString("c"),
                                               (carWashInvoice.PSTCharged + carWashInvoice.GSTCharged).ToString("f2"),
                                               carWashInvoice.Total.ToString("c")};
        }

        /// <summary>
        /// load all the Data needed
        /// </summary>
        private void loadData()
        {
            string record = string.Empty;
            string filePathTemplate = Application.StartupPath + @"\Data\{0}";
            string filePath = string.Format(filePathTemplate, "Interior.txt");

            _interiorItem = loadTerior(record, filePath);

            filePath = string.Format(filePathTemplate, "Exterior.txt");

            _exteriorItem = loadTerior(record, filePath);

            //load Package combo box
            filePath = string.Format(filePathTemplate, "PackageData.txt");

            _packageItems = loadDropDown(record, filePath);

            filePath = string.Format(filePathTemplate, "FragranceData.txt");

            _fragranceItems = loadDropDown(record, filePath);

        }

        /// <summary>
        /// load the Terior that show in the listbox
        /// </summary>
        /// <param name="record">a empty string</param>
        /// <param name="filePath">a string value, the file path of the data source</param>
        /// <returns>a list of string</returns>
        private List<string> loadTerior(string record, string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open);

            StreamReader reader = new StreamReader(stream);

            List<string> teriorItem = new List<string>();

            while ((record = reader.ReadLine()) != null)
            {
                teriorItem.Add(record);
            }

            reader.Close();

            return teriorItem;
        }

        /// <summary>
        /// read the dropDown box items from the txt files
        /// </summary>
        /// <param name="record">a empty string value</param>
        /// <param name="filePath">a string value, the file path of the data source</param>
        /// <returns>a list of the DropDownItem</returns>
        private List<DropDownItem> loadDropDown(string record, string filePath)
        {
            List<DropDownItem> dropDownItems = new List<DropDownItem>();

            FileStream stream = new FileStream(filePath, FileMode.Open);

            StreamReader reader = new StreamReader(stream);

            while ((record = reader.ReadLine()) != null)
            {
                //accord to ',' to separate the string value
                string[] field = record.Split(',');

                DropDownItem item = new DropDownItem()
                {
                    Description = field[0],
                    Price = Decimal.Parse(field[1])
                };

                dropDownItems.Add(item);
            }

            reader.Close();

            return dropDownItems;
        }

        #endregion
    }
}
