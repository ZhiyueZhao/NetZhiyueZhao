namespace NETZhiyueZhao
{
    partial class frmQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuote));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTradeInAllowance = new System.Windows.Forms.TextBox();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkComputerNavigation = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.radCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.lnkResetForm = new System.Windows.Forms.LinkLabel();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSalesTaxText = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTradeInAllowance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNoOfYear = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.hsbNoOfYear = new System.Windows.Forms.HScrollBar();
            this.hsbInterestRate = new System.Windows.Forms.HScrollBar();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboVehicleStock = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileAcceptQuote = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grpSummary.SuspendLayout();
            this.grpFinance.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Stock #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "T&rade-in Allowance:";
            // 
            // txtTradeInAllowance
            // 
            this.errorProvider.SetIconPadding(this.txtTradeInAllowance, 3);
            this.txtTradeInAllowance.Location = new System.Drawing.Point(180, 76);
            this.txtTradeInAllowance.Name = "txtTradeInAllowance";
            this.txtTradeInAllowance.Size = new System.Drawing.Size(143, 22);
            this.txtTradeInAllowance.TabIndex = 3;
            this.txtTradeInAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkComputerNavigation);
            this.grpAccessories.Controls.Add(this.chkLeatherInterior);
            this.grpAccessories.Controls.Add(this.chkStereoSystem);
            this.grpAccessories.Location = new System.Drawing.Point(37, 115);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(286, 151);
            this.grpAccessories.TabIndex = 5;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkComputerNavigation
            // 
            this.chkComputerNavigation.AutoSize = true;
            this.chkComputerNavigation.Location = new System.Drawing.Point(32, 118);
            this.chkComputerNavigation.Name = "chkComputerNavigation";
            this.chkComputerNavigation.Size = new System.Drawing.Size(162, 21);
            this.chkComputerNavigation.TabIndex = 2;
            this.chkComputerNavigation.Text = "Computer &Navigation";
            this.chkComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Location = new System.Drawing.Point(32, 76);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(127, 21);
            this.chkLeatherInterior.TabIndex = 1;
            this.chkLeatherInterior.Text = "Leather &Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Location = new System.Drawing.Point(32, 37);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(122, 21);
            this.chkStereoSystem.TabIndex = 0;
            this.chkStereoSystem.Text = "S&tereo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.radCustomizedDetailing);
            this.grpExteriorFinish.Controls.Add(this.radPearlized);
            this.grpExteriorFinish.Controls.Add(this.radStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(37, 282);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Size = new System.Drawing.Size(286, 158);
            this.grpExteriorFinish.TabIndex = 6;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // radCustomizedDetailing
            // 
            this.radCustomizedDetailing.AutoSize = true;
            this.radCustomizedDetailing.Location = new System.Drawing.Point(32, 120);
            this.radCustomizedDetailing.Name = "radCustomizedDetailing";
            this.radCustomizedDetailing.Size = new System.Drawing.Size(161, 21);
            this.radCustomizedDetailing.TabIndex = 2;
            this.radCustomizedDetailing.TabStop = true;
            this.radCustomizedDetailing.Text = "Customized &Detailing";
            this.radCustomizedDetailing.UseVisualStyleBackColor = true;
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(32, 82);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(88, 21);
            this.radPearlized.TabIndex = 1;
            this.radPearlized.TabStop = true;
            this.radPearlized.Text = "Pearli&zed";
            this.radPearlized.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(32, 42);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(87, 21);
            this.radStandard.TabIndex = 0;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "&Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // lnkResetForm
            // 
            this.lnkResetForm.AutoSize = true;
            this.lnkResetForm.Location = new System.Drawing.Point(37, 472);
            this.lnkResetForm.Name = "lnkResetForm";
            this.lnkResetForm.Size = new System.Drawing.Size(81, 17);
            this.lnkResetForm.TabIndex = 7;
            this.lnkResetForm.TabStop = true;
            this.lnkResetForm.Text = "Reset Form";
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(204, 458);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(119, 34);
            this.btnCalculateQuote.TabIndex = 8;
            this.btnCalculateQuote.Text = "&Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vehicle\'s Sale Price:";
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(174, 32);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(172, 23);
            this.lblVehicleSalePrice.TabIndex = 1;
            this.lblVehicleSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Options:";
            // 
            // lblOptions
            // 
            this.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptions.Location = new System.Drawing.Point(174, 69);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(172, 23);
            this.lblOptions.TabIndex = 3;
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(174, 106);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(172, 23);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTaxText
            // 
            this.lblSalesTaxText.AutoSize = true;
            this.lblSalesTaxText.Location = new System.Drawing.Point(48, 144);
            this.lblSalesTaxText.Name = "lblSalesTaxText";
            this.lblSalesTaxText.Size = new System.Drawing.Size(0, 17);
            this.lblSalesTaxText.TabIndex = 6;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTax.Location = new System.Drawing.Point(174, 144);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(172, 23);
            this.lblSalesTax.TabIndex = 7;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(174, 181);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(172, 23);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Trade-in Allowance:";
            // 
            // lblTradeInAllowance
            // 
            this.lblTradeInAllowance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTradeInAllowance.Location = new System.Drawing.Point(174, 218);
            this.lblTradeInAllowance.Name = "lblTradeInAllowance";
            this.lblTradeInAllowance.Size = new System.Drawing.Size(172, 23);
            this.lblTradeInAllowance.TabIndex = 11;
            this.lblTradeInAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Amount Due:";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.BackColor = System.Drawing.Color.LightBlue;
            this.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDue.Location = new System.Drawing.Point(174, 253);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(172, 23);
            this.lblAmountDue.TabIndex = 13;
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblAmountDue);
            this.grpSummary.Controls.Add(this.label9);
            this.grpSummary.Controls.Add(this.lblTradeInAllowance);
            this.grpSummary.Controls.Add(this.label8);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.label7);
            this.grpSummary.Controls.Add(this.lblSalesTax);
            this.grpSummary.Controls.Add(this.lblSalesTaxText);
            this.grpSummary.Controls.Add(this.lblSubtotal);
            this.grpSummary.Controls.Add(this.label5);
            this.grpSummary.Controls.Add(this.lblOptions);
            this.grpSummary.Controls.Add(this.label4);
            this.grpSummary.Controls.Add(this.lblVehicleSalePrice);
            this.grpSummary.Controls.Add(this.label3);
            this.grpSummary.Location = new System.Drawing.Point(372, 33);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(405, 312);
            this.grpSummary.TabIndex = 9;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "No. of Years";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Interest Rate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Monthly Payment";
            // 
            // lblNoOfYear
            // 
            this.lblNoOfYear.Location = new System.Drawing.Point(24, 67);
            this.lblNoOfYear.Name = "lblNoOfYear";
            this.lblNoOfYear.Size = new System.Drawing.Size(87, 23);
            this.lblNoOfYear.TabIndex = 3;
            this.lblNoOfYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.Location = new System.Drawing.Point(147, 67);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(89, 23);
            this.lblInterestRate.TabIndex = 4;
            this.lblInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.Color.LightBlue;
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(262, 67);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(116, 23);
            this.lblMonthlyPayment.TabIndex = 5;
            this.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hsbNoOfYear
            // 
            this.hsbNoOfYear.LargeChange = 3;
            this.hsbNoOfYear.Location = new System.Drawing.Point(24, 104);
            this.hsbNoOfYear.Maximum = 12;
            this.hsbNoOfYear.Minimum = 1;
            this.hsbNoOfYear.Name = "hsbNoOfYear";
            this.hsbNoOfYear.Size = new System.Drawing.Size(87, 21);
            this.hsbNoOfYear.TabIndex = 6;
            this.hsbNoOfYear.Value = 1;
            // 
            // hsbInterestRate
            // 
            this.hsbInterestRate.LargeChange = 25;
            this.hsbInterestRate.Location = new System.Drawing.Point(147, 107);
            this.hsbInterestRate.Maximum = 2524;
            this.hsbInterestRate.Name = "hsbInterestRate";
            this.hsbInterestRate.Size = new System.Drawing.Size(89, 21);
            this.hsbInterestRate.TabIndex = 7;
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.hsbInterestRate);
            this.grpFinance.Controls.Add(this.hsbNoOfYear);
            this.grpFinance.Controls.Add(this.lblMonthlyPayment);
            this.grpFinance.Controls.Add(this.lblInterestRate);
            this.grpFinance.Controls.Add(this.lblNoOfYear);
            this.grpFinance.Controls.Add(this.label12);
            this.grpFinance.Controls.Add(this.label11);
            this.grpFinance.Controls.Add(this.label10);
            this.grpFinance.Enabled = false;
            this.grpFinance.Location = new System.Drawing.Point(372, 364);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(405, 131);
            this.grpFinance.TabIndex = 10;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(351, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 506);
            this.label6.TabIndex = 11;
            // 
            // cboVehicleStock
            // 
            this.cboVehicleStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleStock.FormattingEnabled = true;
            this.cboVehicleStock.Location = new System.Drawing.Point(180, 42);
            this.cboVehicleStock.Name = "cboVehicleStock";
            this.cboVehicleStock.Size = new System.Drawing.Size(143, 24);
            this.cboVehicleStock.TabIndex = 12;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(807, 28);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.Visible = false;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileAcceptQuote});
            this.mnuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileAcceptQuote
            // 
            this.mnuFileAcceptQuote.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuFileAcceptQuote.MergeIndex = 1;
            this.mnuFileAcceptQuote.Name = "mnuFileAcceptQuote";
            this.mnuFileAcceptQuote.Size = new System.Drawing.Size(169, 24);
            this.mnuFileAcceptQuote.Text = "Accept Quote";
            this.mnuFileAcceptQuote.Click += new System.EventHandler(this.mnuFileAcceptQuote_Click);
            // 
            // frmQuote
            // 
            this.AcceptButton = this.btnCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(807, 524);
            this.Controls.Add(this.cboVehicleStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.lnkResetForm);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.txtTradeInAllowance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmQuote";
            this.Text = "Sales Quote";
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTradeInAllowance;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.CheckBox chkComputerNavigation;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radCustomizedDetailing;
        private System.Windows.Forms.LinkLabel lnkResetForm;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.HScrollBar hsbInterestRate;
        private System.Windows.Forms.HScrollBar hsbNoOfYear;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblNoOfYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTradeInAllowance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblSalesTaxText;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboVehicleStock;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileAcceptQuote;

    }
}