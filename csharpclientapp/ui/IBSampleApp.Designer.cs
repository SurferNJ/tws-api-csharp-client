/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using IBSampleApp.types;
using IBSampleApp.ui;
using System.Data;


namespace IBSampleApp
{
    partial class IBSampleApp
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
            ibClient.ClientSocket.eDisconnect();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            CSharpClientApp.ui.PriceLineManager priceLineManager1 = new CSharpClientApp.ui.PriceLineManager();
            CSharpClientApp.ui.PriceLineManager priceLineManager2 = new CSharpClientApp.ui.PriceLineManager();
            CSharpClientApp.ui.PriceLineManager priceLineManager3 = new CSharpClientApp.ui.PriceLineManager();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IBSampleApp));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.connectionTab = new System.Windows.Forms.TabPage();
            this.connectButton = new System.Windows.Forms.Button();
            this.clientid_CT = new System.Windows.Forms.TextBox();
            this.cliet_label_CT = new System.Windows.Forms.Label();
            this.port_CT = new System.Windows.Forms.TextBox();
            this.port_label_CT = new System.Windows.Forms.Label();
            this.host_label_CT = new System.Windows.Forms.Label();
            this.host_CT = new System.Windows.Forms.TextBox();
            this.marketDataTab = new System.Windows.Forms.TabPage();
            this.marketData_MDT = new System.Windows.Forms.TabControl();
            this.topMarketDataTab_MDT = new System.Windows.Forms.TabPage();
            this.cancelMarketDataRequests = new System.Windows.Forms.Button();
            this.closeMketDataTab = new System.Windows.Forms.LinkLabel();
            this.marketDataGrid_MDT = new System.Windows.Forms.DataGridView();
            this.marketDataContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.askPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.askSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeTickerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicalDataTab = new System.Windows.Forms.TabPage();
            this.tabDashboard = new System.Windows.Forms.TabControl();
            this.tabBuy = new System.Windows.Forms.TabPage();
            this.tabSell = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabAlerts = new System.Windows.Forms.TabPage();
            this.checkMonthlyLinesStudy = new System.Windows.Forms.CheckBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.pickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.checkBottomLines = new System.Windows.Forms.CheckBox();
            this.comboDuration = new System.Windows.Forms.ComboBox();
            this.comboIDBarSize = new System.Windows.Forms.ComboBox();
            this.contractMDRTH = new System.Windows.Forms.CheckBox();
            this.hdRequest_WhatToShow = new System.Windows.Forms.ComboBox();
            this.checkDailyLinesStudy = new System.Windows.Forms.CheckBox();
            this.hdRequest_Duration = new System.Windows.Forms.TextBox();
            this.checkHighLowStudy = new System.Windows.Forms.CheckBox();
            this.hdRequest_TimeUnit = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.histDataTabClose_MDT = new System.Windows.Forms.LinkLabel();
            this.deepBookTab_MDT = new System.Windows.Forms.TabPage();
            this.closeDeepBookLink = new System.Windows.Forms.LinkLabel();
            this.deepBookGrid = new System.Windows.Forms.DataGridView();
            this.bidBookMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidBookSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.askBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.askBookSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.askBookMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtBarsTab_MDT = new System.Windows.Forms.TabPage();
            this.rtBarsCloseLink = new System.Windows.Forms.LinkLabel();
            this.rtBarsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scannerTab = new System.Windows.Forms.TabPage();
            this.scannerTab_link = new System.Windows.Forms.LinkLabel();
            this.scannerGrid = new System.Windows.Forms.DataGridView();
            this.scanRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanBenchmark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanProjection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanLegStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataResults_MDT = new System.Windows.Forms.TabControl();
            this.topMktData_MDT = new System.Windows.Forms.TabPage();
            this.deepBookGroupBox = new System.Windows.Forms.GroupBox();
            this.deepBookEntries = new System.Windows.Forms.TextBox();
            this.deepBookEntriesLabel = new System.Windows.Forms.Label();
            this.deepBook_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.primaryExchange = new System.Windows.Forms.TextBox();
            this.primaryExchLabel = new System.Windows.Forms.Label();
            this.genericTickList = new System.Windows.Forms.TextBox();
            this.genericTickListLabel = new System.Windows.Forms.Label();
            this.mdRightLabel = new System.Windows.Forms.Label();
            this.mdContractRight = new System.Windows.Forms.ComboBox();
            this.putcall_label_TMD_MDT = new System.Windows.Forms.Label();
            this.includeExpired = new System.Windows.Forms.CheckBox();
            this.multiplier_TMD_MDT = new System.Windows.Forms.TextBox();
            this.symbol_label_TMD_MDT = new System.Windows.Forms.Label();
            this.marketData_Button = new System.Windows.Forms.Button();
            this.secType_TMD_MDT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exchange_label_TMD_MDT = new System.Windows.Forms.Label();
            this.localSymbol_TMD_MDT = new System.Windows.Forms.TextBox();
            this.currency_label_TMD_MDT = new System.Windows.Forms.Label();
            this.expiry_TMD_MDT = new System.Windows.Forms.TextBox();
            this.symbol_TMD_MDT = new System.Windows.Forms.TextBox();
            this.strike_TMD_MDT = new System.Windows.Forms.TextBox();
            this.currency_TMD_MDT = new System.Windows.Forms.TextBox();
            this.exchange_TMD_MDT = new System.Windows.Forms.TextBox();
            this.localSymbol_label_TMD_MDT = new System.Windows.Forms.Label();
            this.expiry_label_TMD_MDT = new System.Windows.Forms.Label();
            this.strike_label_TMD_MDT = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkRTData = new System.Windows.Forms.CheckBox();
            this.histData_1M_Button = new System.Windows.Forms.Button();
            this.histData_Button = new System.Windows.Forms.Button();
            this.hdRequest_BarSize = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.marketScanner_MDT = new System.Windows.Forms.TabPage();
            this.scanLocation = new System.Windows.Forms.ComboBox();
            this.scannerRequest_Button = new System.Windows.Forms.Button();
            this.scanNumRows_label = new System.Windows.Forms.Label();
            this.scanStockType_label = new System.Windows.Forms.Label();
            this.scanLocation_label = new System.Windows.Forms.Label();
            this.scanInstrument_label = new System.Windows.Forms.Label();
            this.scanCode_label = new System.Windows.Forms.Label();
            this.scanNumRows = new System.Windows.Forms.TextBox();
            this.scanStockType = new System.Windows.Forms.ComboBox();
            this.scanInstrument = new System.Windows.Forms.ComboBox();
            this.scanCode = new System.Windows.Forms.ComboBox();
            this.tradingTab = new System.Windows.Forms.TabPage();
            this.globalCancelButton = new System.Windows.Forms.Button();
            this.clientOrdersButton = new System.Windows.Forms.Button();
            this.refreshOrdersButton = new System.Windows.Forms.Button();
            this.cancelOrdersButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.newOrderLink = new System.Windows.Forms.LinkLabel();
            this.executionsGroup = new System.Windows.Forms.GroupBox();
            this.refreshExecutionsButton = new System.Windows.Forms.Button();
            this.tradeLogGrid = new System.Windows.Forms.DataGridView();
            this.ExecutionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeExecColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountExecColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionExecColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityExecColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionExecColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceExecColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionExecColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealisedPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liveOrdersGroup = new System.Windows.Forms.GroupBox();
            this.liveOrdersGrid = new System.Windows.Forms.DataGridView();
            this.permIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountInfoTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.accSummaryTab = new System.Windows.Forms.TabPage();
            this.accSummaryRequest = new System.Windows.Forms.Button();
            this.accSummaryGrid = new System.Windows.Forms.DataGridView();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountSummaryAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accUpdatesTab = new System.Windows.Forms.TabPage();
            this.accUpdatesSubscribedAccount = new System.Windows.Forms.Label();
            this.accUpdatesAccountLabel = new System.Windows.Forms.Label();
            this.accUpdatesLastUpdateValue = new System.Windows.Forms.Label();
            this.accountPortfolioGrid = new System.Windows.Forms.DataGridView();
            this.updatePortfolioContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatePortfolioPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatePortfolioMarketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatePortfolioMarketValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatePortfolioAvgCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatePortfolioUnrealisedPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatePortfolioRealisedPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountValuesGrid = new System.Windows.Forms.DataGridView();
            this.accUpdatesKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accUpdatesValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accUpdatesCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accUpdatesSubscribe = new System.Windows.Forms.Button();
            this.lastUpdatedLabel = new System.Windows.Forms.Label();
            this.positionsTab = new System.Windows.Forms.TabPage();
            this.positionRequest = new System.Windows.Forms.Button();
            this.positionsGrid = new System.Windows.Forms.DataGridView();
            this.positionContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionAvgCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountSelectorLabel = new System.Windows.Forms.Label();
            this.accountSelector = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.queryOptionChain = new System.Windows.Forms.Button();
            this.optionChainUseSnapshot = new System.Windows.Forms.CheckBox();
            this.optionChainOptionExchangeLabel = new System.Windows.Forms.Label();
            this.optionChainExchange = new System.Windows.Forms.TextBox();
            this.contractFundamentalsGroupBox = new System.Windows.Forms.GroupBox();
            this.fundamentalsQueryButton = new System.Windows.Forms.Button();
            this.fundamentalsReportTypeLabel = new System.Windows.Forms.Label();
            this.fundamentalsReportType = new System.Windows.Forms.ComboBox();
            this.contractDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.searchContractDetails = new System.Windows.Forms.Button();
            this.conDetSymbolLabel = new System.Windows.Forms.Label();
            this.conDetRightLabel = new System.Windows.Forms.Label();
            this.conDetStrikeLabel = new System.Windows.Forms.Label();
            this.conDetRight = new System.Windows.Forms.ComboBox();
            this.conDetExpiryLabel = new System.Windows.Forms.Label();
            this.conDetSecType = new System.Windows.Forms.ComboBox();
            this.conDetMultiplierLabel = new System.Windows.Forms.Label();
            this.conDetSecTypeLabel = new System.Windows.Forms.Label();
            this.conDetLocalSymbolLabel = new System.Windows.Forms.Label();
            this.conDetExchangeLabel = new System.Windows.Forms.Label();
            this.conDetExchange = new System.Windows.Forms.TextBox();
            this.conDetLocalSymbol = new System.Windows.Forms.TextBox();
            this.conDetMultiplier = new System.Windows.Forms.TextBox();
            this.conDetCurrencyLabel = new System.Windows.Forms.Label();
            this.conDetCurrency = new System.Windows.Forms.TextBox();
            this.conDetExpiry = new System.Windows.Forms.TextBox();
            this.conDetStrike = new System.Windows.Forms.TextBox();
            this.conDetSymbol = new System.Windows.Forms.TextBox();
            this.contractInfoTab = new System.Windows.Forms.TabControl();
            this.contractDetailsPage = new System.Windows.Forms.TabPage();
            this.contractDetailsGrid = new System.Windows.Forms.DataGridView();
            this.conResSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conResLocalSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conResSecType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conResCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conResExchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conResPrimaryExch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conResExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conResMultiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conResStrike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conResRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conResConId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundamentalsPage = new System.Windows.Forms.TabPage();
            this.fundamentalsOutput = new System.Windows.Forms.TextBox();
            this.optionChainPage = new System.Windows.Forms.TabPage();
            this.optionChainCallGroup = new System.Windows.Forms.GroupBox();
            this.optionChainCallGrid = new System.Windows.Forms.DataGridView();
            this.callExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callStrike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callAsk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callImpliedVolatility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callDelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callGamma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callVega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callTheta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionChainPutGroup = new System.Windows.Forms.GroupBox();
            this.optionChainPutGrid = new System.Windows.Forms.DataGridView();
            this.putExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putStrike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putAsk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putImpliedVolatility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putDelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putGamma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putVega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putTheta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advisorTab = new System.Windows.Forms.TabPage();
            this.advisorProfilesBox = new System.Windows.Forms.GroupBox();
            this.saveProfiles = new System.Windows.Forms.Button();
            this.loadProfiles = new System.Windows.Forms.Button();
            this.advisorProfilesGrid = new System.Windows.Forms.DataGridView();
            this.profileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.profileAllocations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advisorGroupsBox = new System.Windows.Forms.GroupBox();
            this.saveGroups = new System.Windows.Forms.Button();
            this.loadGroups = new System.Windows.Forms.Button();
            this.advisorGroupsGrid = new System.Windows.Forms.DataGridView();
            this.groupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupAccounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advisorAliasesBox = new System.Windows.Forms.GroupBox();
            this.loadAliases = new System.Windows.Forms.Button();
            this.advisorAliasesGrid = new System.Windows.Forms.DataGridView();
            this.advisorAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advisorAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionsTab = new System.Windows.Forms.TabPage();
            this.optionExchange = new System.Windows.Forms.TextBox();
            this.optionExchangeLabel = new System.Windows.Forms.Label();
            this.optionsQuantityLabel = new System.Windows.Forms.Label();
            this.optionsPositionsGroupBox = new System.Windows.Forms.GroupBox();
            this.optionPositionsGrid = new System.Windows.Forms.DataGridView();
            this.optionContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionMarketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionMarketValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionAverageCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionUnrealisedPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionRealisedPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionExerciseQuan = new System.Windows.Forms.TextBox();
            this.overrideOption = new System.Windows.Forms.CheckBox();
            this.lapseOption = new System.Windows.Forms.Button();
            this.exerciseOption = new System.Windows.Forms.Button();
            this.exerciseAccountLabel = new System.Windows.Forms.Label();
            this.exerciseAccount = new System.Windows.Forms.ComboBox();
            this.comboTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.comboDeltaNeutralBox = new System.Windows.Forms.GroupBox();
            this.comboDeltaNeutralSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboLegsBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboLegAction = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboLegRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboLegDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboLegPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboContractBox = new System.Windows.Forms.GroupBox();
            this.findComboContract = new System.Windows.Forms.LinkLabel();
            this.comboSymbolLabel = new System.Windows.Forms.Label();
            this.comboSymbol = new System.Windows.Forms.TextBox();
            this.comboStrike = new System.Windows.Forms.TextBox();
            this.comboRightLabel = new System.Windows.Forms.Label();
            this.comboExpiry = new System.Windows.Forms.TextBox();
            this.comboStrikeLabel = new System.Windows.Forms.Label();
            this.comboCurrency = new System.Windows.Forms.TextBox();
            this.comboRight = new System.Windows.Forms.ComboBox();
            this.comboCurrencyLabel = new System.Windows.Forms.Label();
            this.comboExpiryLabel = new System.Windows.Forms.Label();
            this.comboMultiplier = new System.Windows.Forms.TextBox();
            this.comboSecType = new System.Windows.Forms.ComboBox();
            this.comboLocalSymbol = new System.Windows.Forms.TextBox();
            this.comboMultiplierLabel = new System.Windows.Forms.Label();
            this.comboExchange = new System.Windows.Forms.TextBox();
            this.comboSecTypeLabel = new System.Windows.Forms.Label();
            this.comboExchangeLabel = new System.Windows.Forms.Label();
            this.comboLocalSymbolLabel = new System.Windows.Forms.Label();
            this.contextMenuOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemBuyLMT = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemSellLMT = new System.Windows.Forms.ToolStripMenuItem();
            this.status_CT = new System.Windows.Forms.Label();
            this.status_label_CT = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.messagesTab = new System.Windows.Forms.TabPage();
            this.messageBoxClear_link = new System.Windows.Forms.LinkLabel();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.informationTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tabProbabilities = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dataChartRT = new CSharpClientApp.usercontrols.DataChart();
            this.orderFormBuy = new CSharpClientApp.usercontrols.OrderForm();
            this.orderFormSell = new CSharpClientApp.usercontrols.OrderForm();
            this.dataChartDaily = new CSharpClientApp.usercontrols.DataChart();
            this.dataChart1M = new CSharpClientApp.usercontrols.DataChart();
            this.TabControl.SuspendLayout();
            this.connectionTab.SuspendLayout();
            this.marketDataTab.SuspendLayout();
            this.marketData_MDT.SuspendLayout();
            this.topMarketDataTab_MDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataGrid_MDT)).BeginInit();
            this.historicalDataTab.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabBuy.SuspendLayout();
            this.tabSell.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.deepBookTab_MDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deepBookGrid)).BeginInit();
            this.rtBarsTab_MDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtBarsGrid)).BeginInit();
            this.scannerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scannerGrid)).BeginInit();
            this.dataResults_MDT.SuspendLayout();
            this.topMktData_MDT.SuspendLayout();
            this.deepBookGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.marketScanner_MDT.SuspendLayout();
            this.tradingTab.SuspendLayout();
            this.executionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tradeLogGrid)).BeginInit();
            this.liveOrdersGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liveOrdersGrid)).BeginInit();
            this.accountInfoTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.accSummaryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accSummaryGrid)).BeginInit();
            this.accUpdatesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountPortfolioGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountValuesGrid)).BeginInit();
            this.positionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contractFundamentalsGroupBox.SuspendLayout();
            this.contractDetailsGroupBox.SuspendLayout();
            this.contractInfoTab.SuspendLayout();
            this.contractDetailsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractDetailsGrid)).BeginInit();
            this.fundamentalsPage.SuspendLayout();
            this.optionChainPage.SuspendLayout();
            this.optionChainCallGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionChainCallGrid)).BeginInit();
            this.optionChainPutGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionChainPutGrid)).BeginInit();
            this.advisorTab.SuspendLayout();
            this.advisorProfilesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advisorProfilesGrid)).BeginInit();
            this.advisorGroupsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advisorGroupsGrid)).BeginInit();
            this.advisorAliasesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advisorAliasesGrid)).BeginInit();
            this.optionsTab.SuspendLayout();
            this.optionsPositionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionPositionsGrid)).BeginInit();
            this.comboTab.SuspendLayout();
            this.comboDeltaNeutralBox.SuspendLayout();
            this.comboLegsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.comboContractBox.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.messagesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.connectionTab);
            this.TabControl.Controls.Add(this.marketDataTab);
            this.TabControl.Controls.Add(this.tradingTab);
            this.TabControl.Controls.Add(this.accountInfoTab);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.advisorTab);
            this.TabControl.Controls.Add(this.optionsTab);
            this.TabControl.Controls.Add(this.comboTab);
            this.TabControl.Location = new System.Drawing.Point(0, 15);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1675, 685);
            this.TabControl.TabIndex = 0;
            // 
            // connectionTab
            // 
            this.connectionTab.BackColor = System.Drawing.Color.LightGray;
            this.connectionTab.Controls.Add(this.connectButton);
            this.connectionTab.Controls.Add(this.clientid_CT);
            this.connectionTab.Controls.Add(this.cliet_label_CT);
            this.connectionTab.Controls.Add(this.port_CT);
            this.connectionTab.Controls.Add(this.port_label_CT);
            this.connectionTab.Controls.Add(this.host_label_CT);
            this.connectionTab.Controls.Add(this.host_CT);
            this.connectionTab.Location = new System.Drawing.Point(4, 25);
            this.connectionTab.Margin = new System.Windows.Forms.Padding(4);
            this.connectionTab.Name = "connectionTab";
            this.connectionTab.Padding = new System.Windows.Forms.Padding(4);
            this.connectionTab.Size = new System.Drawing.Size(1667, 656);
            this.connectionTab.TabIndex = 0;
            this.connectionTab.Text = "Connection";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(95, 127);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 28);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.informationTooltip.SetToolTip(this.connectButton, "Connects to TWS or IB Gateway.");
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // clientid_CT
            // 
            this.clientid_CT.Location = new System.Drawing.Point(84, 79);
            this.clientid_CT.Margin = new System.Windows.Forms.Padding(4);
            this.clientid_CT.Name = "clientid_CT";
            this.clientid_CT.Size = new System.Drawing.Size(109, 22);
            this.clientid_CT.TabIndex = 5;
            this.clientid_CT.Text = "1";
            this.informationTooltip.SetToolTip(this.clientid_CT, "Each TWS can handle up to 8 simultaneous clients identifed by a unique Id.");
            // 
            // cliet_label_CT
            // 
            this.cliet_label_CT.AutoSize = true;
            this.cliet_label_CT.Location = new System.Drawing.Point(8, 87);
            this.cliet_label_CT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cliet_label_CT.Name = "cliet_label_CT";
            this.cliet_label_CT.Size = new System.Drawing.Size(58, 17);
            this.cliet_label_CT.TabIndex = 4;
            this.cliet_label_CT.Text = "Client Id";
            // 
            // port_CT
            // 
            this.port_CT.Location = new System.Drawing.Point(84, 43);
            this.port_CT.Margin = new System.Windows.Forms.Padding(4);
            this.port_CT.Name = "port_CT";
            this.port_CT.Size = new System.Drawing.Size(109, 22);
            this.port_CT.TabIndex = 3;
            this.port_CT.Text = "7496";
            this.informationTooltip.SetToolTip(this.port_CT, "TWS\' listening port.");
            // 
            // port_label_CT
            // 
            this.port_label_CT.AutoSize = true;
            this.port_label_CT.Location = new System.Drawing.Point(33, 52);
            this.port_label_CT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.port_label_CT.Name = "port_label_CT";
            this.port_label_CT.Size = new System.Drawing.Size(34, 17);
            this.port_label_CT.TabIndex = 2;
            this.port_label_CT.Text = "Port";
            // 
            // host_label_CT
            // 
            this.host_label_CT.AutoSize = true;
            this.host_label_CT.Location = new System.Drawing.Point(29, 16);
            this.host_label_CT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.host_label_CT.Name = "host_label_CT";
            this.host_label_CT.Size = new System.Drawing.Size(37, 17);
            this.host_label_CT.TabIndex = 1;
            this.host_label_CT.Text = "Host";
            // 
            // host_CT
            // 
            this.host_CT.Location = new System.Drawing.Point(84, 7);
            this.host_CT.Margin = new System.Windows.Forms.Padding(4);
            this.host_CT.Name = "host_CT";
            this.host_CT.Size = new System.Drawing.Size(109, 22);
            this.host_CT.TabIndex = 0;
            this.informationTooltip.SetToolTip(this.host_CT, "TWS host\'s IP address (leave blank if TWS is running on the same machine).");
            // 
            // marketDataTab
            // 
            this.marketDataTab.BackColor = System.Drawing.Color.LightGray;
            this.marketDataTab.Controls.Add(this.marketData_MDT);
            this.marketDataTab.Controls.Add(this.dataResults_MDT);
            this.marketDataTab.Location = new System.Drawing.Point(4, 25);
            this.marketDataTab.Margin = new System.Windows.Forms.Padding(4);
            this.marketDataTab.Name = "marketDataTab";
            this.marketDataTab.Padding = new System.Windows.Forms.Padding(4);
            this.marketDataTab.Size = new System.Drawing.Size(1667, 656);
            this.marketDataTab.TabIndex = 1;
            this.marketDataTab.Text = "Data";
            // 
            // marketData_MDT
            // 
            this.marketData_MDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marketData_MDT.Controls.Add(this.topMarketDataTab_MDT);
            this.marketData_MDT.Controls.Add(this.historicalDataTab);
            this.marketData_MDT.Controls.Add(this.deepBookTab_MDT);
            this.marketData_MDT.Controls.Add(this.rtBarsTab_MDT);
            this.marketData_MDT.Controls.Add(this.scannerTab);
            this.marketData_MDT.Location = new System.Drawing.Point(0, 258);
            this.marketData_MDT.Margin = new System.Windows.Forms.Padding(0);
            this.marketData_MDT.Name = "marketData_MDT";
            this.marketData_MDT.SelectedIndex = 0;
            this.marketData_MDT.Size = new System.Drawing.Size(1656, 450);
            this.marketData_MDT.TabIndex = 1;
            // 
            // topMarketDataTab_MDT
            // 
            this.topMarketDataTab_MDT.BackColor = System.Drawing.Color.LightGray;
            this.topMarketDataTab_MDT.Controls.Add(this.dataChartRT);
            this.topMarketDataTab_MDT.Controls.Add(this.cancelMarketDataRequests);
            this.topMarketDataTab_MDT.Controls.Add(this.closeMketDataTab);
            this.topMarketDataTab_MDT.Controls.Add(this.marketDataGrid_MDT);
            this.topMarketDataTab_MDT.Location = new System.Drawing.Point(4, 25);
            this.topMarketDataTab_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.topMarketDataTab_MDT.Name = "topMarketDataTab_MDT";
            this.topMarketDataTab_MDT.Padding = new System.Windows.Forms.Padding(4);
            this.topMarketDataTab_MDT.Size = new System.Drawing.Size(1648, 421);
            this.topMarketDataTab_MDT.TabIndex = 0;
            this.topMarketDataTab_MDT.Text = "Market Data";
            // 
            // cancelMarketDataRequests
            // 
            this.cancelMarketDataRequests.Location = new System.Drawing.Point(1300, 23);
            this.cancelMarketDataRequests.Margin = new System.Windows.Forms.Padding(4);
            this.cancelMarketDataRequests.Name = "cancelMarketDataRequests";
            this.cancelMarketDataRequests.Size = new System.Drawing.Size(100, 28);
            this.cancelMarketDataRequests.TabIndex = 2;
            this.cancelMarketDataRequests.Text = "Stop";
            this.cancelMarketDataRequests.UseVisualStyleBackColor = true;
            this.cancelMarketDataRequests.Click += new System.EventHandler(this.cancelMarketDataRequests_Click);
            // 
            // closeMketDataTab
            // 
            this.closeMketDataTab.AutoSize = true;
            this.closeMketDataTab.Location = new System.Drawing.Point(8, 4);
            this.closeMketDataTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeMketDataTab.Name = "closeMketDataTab";
            this.closeMketDataTab.Size = new System.Drawing.Size(43, 17);
            this.closeMketDataTab.TabIndex = 1;
            this.closeMketDataTab.TabStop = true;
            this.closeMketDataTab.Text = "Close";
            this.closeMketDataTab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.closeMketDataTab_LinkClicked);
            // 
            // marketDataGrid_MDT
            // 
            this.marketDataGrid_MDT.AllowUserToAddRows = false;
            this.marketDataGrid_MDT.AllowUserToDeleteRows = false;
            this.marketDataGrid_MDT.AllowUserToOrderColumns = true;
            this.marketDataGrid_MDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marketDataGrid_MDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marketDataGrid_MDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marketDataContract,
            this.bidSize,
            this.bidPrice,
            this.askPrice,
            this.askSize,
            this.lastPrice,
            this.volume,
            this.closeTickerColumn});
            this.marketDataGrid_MDT.Location = new System.Drawing.Point(-398, 8);
            this.marketDataGrid_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.marketDataGrid_MDT.Name = "marketDataGrid_MDT";
            this.marketDataGrid_MDT.ReadOnly = true;
            this.marketDataGrid_MDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marketDataGrid_MDT.Size = new System.Drawing.Size(954, 384);
            this.marketDataGrid_MDT.TabIndex = 0;
            this.marketDataGrid_MDT.Visible = false;
            // 
            // marketDataContract
            // 
            this.marketDataContract.HeaderText = "Description";
            this.marketDataContract.Name = "marketDataContract";
            this.marketDataContract.ReadOnly = true;
            this.marketDataContract.Width = 200;
            // 
            // bidSize
            // 
            this.bidSize.HeaderText = "Bid Size";
            this.bidSize.Name = "bidSize";
            this.bidSize.ReadOnly = true;
            // 
            // bidPrice
            // 
            this.bidPrice.HeaderText = "Bid";
            this.bidPrice.Name = "bidPrice";
            this.bidPrice.ReadOnly = true;
            // 
            // askPrice
            // 
            this.askPrice.HeaderText = "Ask";
            this.askPrice.Name = "askPrice";
            this.askPrice.ReadOnly = true;
            // 
            // askSize
            // 
            this.askSize.HeaderText = "Ask Size";
            this.askSize.Name = "askSize";
            this.askSize.ReadOnly = true;
            // 
            // lastPrice
            // 
            this.lastPrice.HeaderText = "Last Size";
            this.lastPrice.Name = "lastPrice";
            this.lastPrice.ReadOnly = true;
            // 
            // volume
            // 
            this.volume.HeaderText = "Volume";
            this.volume.Name = "volume";
            this.volume.ReadOnly = true;
            // 
            // closeTickerColumn
            // 
            this.closeTickerColumn.HeaderText = "Close";
            this.closeTickerColumn.Name = "closeTickerColumn";
            this.closeTickerColumn.ReadOnly = true;
            this.closeTickerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.closeTickerColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // historicalDataTab
            // 
            this.historicalDataTab.BackColor = System.Drawing.Color.LightGray;
            this.historicalDataTab.Controls.Add(this.tabDashboard);
            this.historicalDataTab.Controls.Add(this.histDataTabClose_MDT);
            this.historicalDataTab.Controls.Add(this.dataChartDaily);
            this.historicalDataTab.Controls.Add(this.dataChart1M);
            this.historicalDataTab.Location = new System.Drawing.Point(4, 25);
            this.historicalDataTab.Margin = new System.Windows.Forms.Padding(4);
            this.historicalDataTab.Name = "historicalDataTab";
            this.historicalDataTab.Padding = new System.Windows.Forms.Padding(4);
            this.historicalDataTab.Size = new System.Drawing.Size(1648, 421);
            this.historicalDataTab.TabIndex = 0;
            this.historicalDataTab.Text = "Historical Bars";
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.tabBuy);
            this.tabDashboard.Controls.Add(this.tabSell);
            this.tabDashboard.Controls.Add(this.tabProbabilities);
            this.tabDashboard.Controls.Add(this.tabAlerts);
            this.tabDashboard.Controls.Add(this.tabSettings);
            this.tabDashboard.Location = new System.Drawing.Point(635, 7);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.SelectedIndex = 0;
            this.tabDashboard.Size = new System.Drawing.Size(307, 330);
            this.tabDashboard.TabIndex = 69;
            // 
            // tabBuy
            // 
            this.tabBuy.BackColor = System.Drawing.Color.LightGray;
            this.tabBuy.Controls.Add(this.orderFormBuy);
            this.tabBuy.Location = new System.Drawing.Point(4, 25);
            this.tabBuy.Name = "tabBuy";
            this.tabBuy.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuy.Size = new System.Drawing.Size(299, 301);
            this.tabBuy.TabIndex = 0;
            this.tabBuy.Text = "Buy";
            // 
            // tabSell
            // 
            this.tabSell.BackColor = System.Drawing.Color.LightGray;
            this.tabSell.Controls.Add(this.orderFormSell);
            this.tabSell.Location = new System.Drawing.Point(4, 25);
            this.tabSell.Name = "tabSell";
            this.tabSell.Size = new System.Drawing.Size(299, 301);
            this.tabSell.TabIndex = 2;
            this.tabSell.Text = "Sell";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.LightGray;
            this.tabSettings.Controls.Add(this.label7);
            this.tabSettings.Controls.Add(this.hdRequest_WhatToShow);
            this.tabSettings.Controls.Add(this.checkBottomLines);
            this.tabSettings.Controls.Add(this.checkMonthlyLinesStudy);
            this.tabSettings.Controls.Add(this.contractMDRTH);
            this.tabSettings.Controls.Add(this.comboIDBarSize);
            this.tabSettings.Controls.Add(this.checkDailyLinesStudy);
            this.tabSettings.Controls.Add(this.comboDuration);
            this.tabSettings.Controls.Add(this.checkHighLowStudy);
            this.tabSettings.Controls.Add(this.pickerEndDate);
            this.tabSettings.Controls.Add(this.buttonShow);
            this.tabSettings.Controls.Add(this.label10);
            this.tabSettings.Controls.Add(this.hdRequest_TimeUnit);
            this.tabSettings.Controls.Add(this.hdRequest_Duration);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(299, 301);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            // 
            // tabAlerts
            // 
            this.tabAlerts.BackColor = System.Drawing.Color.LightGray;
            this.tabAlerts.Location = new System.Drawing.Point(4, 25);
            this.tabAlerts.Name = "tabAlerts";
            this.tabAlerts.Size = new System.Drawing.Size(299, 301);
            this.tabAlerts.TabIndex = 3;
            this.tabAlerts.Text = "Alerts";
            // 
            // checkMonthlyLinesStudy
            // 
            this.checkMonthlyLinesStudy.AutoSize = true;
            this.checkMonthlyLinesStudy.Location = new System.Drawing.Point(16, 149);
            this.checkMonthlyLinesStudy.Name = "checkMonthlyLinesStudy";
            this.checkMonthlyLinesStudy.Size = new System.Drawing.Size(76, 21);
            this.checkMonthlyLinesStudy.TabIndex = 68;
            this.checkMonthlyLinesStudy.Text = "Months";
            this.checkMonthlyLinesStudy.UseVisualStyleBackColor = true;
            this.checkMonthlyLinesStudy.CheckedChanged += new System.EventHandler(this.checkMonthlyLinesStudy_CheckedChanged);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(38, 105);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 26);
            this.buttonShow.TabIndex = 67;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // pickerEndDate
            // 
            this.pickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerEndDate.Location = new System.Drawing.Point(13, 44);
            this.pickerEndDate.Name = "pickerEndDate";
            this.pickerEndDate.Size = new System.Drawing.Size(97, 22);
            this.pickerEndDate.TabIndex = 66;
            this.pickerEndDate.Value = new System.DateTime(2015, 1, 28, 20, 1, 35, 0);
            // 
            // checkBottomLines
            // 
            this.checkBottomLines.AutoSize = true;
            this.checkBottomLines.Location = new System.Drawing.Point(184, 160);
            this.checkBottomLines.Name = "checkBottomLines";
            this.checkBottomLines.Size = new System.Drawing.Size(112, 21);
            this.checkBottomLines.TabIndex = 65;
            this.checkBottomLines.Text = "Bottom Lines";
            this.checkBottomLines.UseVisualStyleBackColor = true;
            this.checkBottomLines.CheckedChanged += new System.EventHandler(this.checkBottomLines_CheckedChanged);
            // 
            // comboDuration
            // 
            this.comboDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDuration.FormattingEnabled = true;
            this.comboDuration.Items.AddRange(new object[] {
            "1 D",
            "2 D",
            "3 D",
            "5 D",
            "10 D",
            "20 D",
            "30 D"});
            this.comboDuration.Location = new System.Drawing.Point(184, 44);
            this.comboDuration.Margin = new System.Windows.Forms.Padding(4);
            this.comboDuration.Name = "comboDuration";
            this.comboDuration.Size = new System.Drawing.Size(71, 25);
            this.comboDuration.TabIndex = 64;
            this.comboDuration.Text = "2 D";
            this.comboDuration.SelectedIndexChanged += new System.EventHandler(this.comboDuration_SelectedIndexChanged);
            // 
            // comboIDBarSize
            // 
            this.comboIDBarSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboIDBarSize.FormattingEnabled = true;
            this.comboIDBarSize.Items.AddRange(new object[] {
            "1 min",
            "2 mins",
            "3 mins",
            "5 mins",
            "15 mins",
            "30 mins",
            "1 hour"});
            this.comboIDBarSize.Location = new System.Drawing.Point(184, 73);
            this.comboIDBarSize.Margin = new System.Windows.Forms.Padding(4);
            this.comboIDBarSize.Name = "comboIDBarSize";
            this.comboIDBarSize.Size = new System.Drawing.Size(71, 25);
            this.comboIDBarSize.TabIndex = 63;
            this.comboIDBarSize.Text = "1 min";
            this.comboIDBarSize.SelectedIndexChanged += new System.EventHandler(this.comboIDBarSize_SelectedIndexChanged);
            // 
            // contractMDRTH
            // 
            this.contractMDRTH.AutoSize = true;
            this.contractMDRTH.Checked = true;
            this.contractMDRTH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contractMDRTH.Location = new System.Drawing.Point(185, 201);
            this.contractMDRTH.Margin = new System.Windows.Forms.Padding(4);
            this.contractMDRTH.Name = "contractMDRTH";
            this.contractMDRTH.Size = new System.Drawing.Size(89, 21);
            this.contractMDRTH.TabIndex = 60;
            this.contractMDRTH.Text = "RTH only";
            this.contractMDRTH.UseVisualStyleBackColor = true;
            // 
            // hdRequest_WhatToShow
            // 
            this.hdRequest_WhatToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdRequest_WhatToShow.FormattingEnabled = true;
            this.hdRequest_WhatToShow.Items.AddRange(new object[] {
            "TRADES",
            "MIDPOINT",
            "BID",
            "ASK",
            "BID_ASK",
            "HISTORICAL_VOLATILITY",
            "OPTION_IMPLIED_VOLATILITY",
            "YIELD_BID",
            "YIELD_ASK",
            "YIELD_BID_ASK",
            "YIELD_LAST"});
            this.hdRequest_WhatToShow.Location = new System.Drawing.Point(117, 264);
            this.hdRequest_WhatToShow.Margin = new System.Windows.Forms.Padding(4);
            this.hdRequest_WhatToShow.Name = "hdRequest_WhatToShow";
            this.hdRequest_WhatToShow.Size = new System.Drawing.Size(89, 21);
            this.hdRequest_WhatToShow.TabIndex = 52;
            this.hdRequest_WhatToShow.Text = "TRADES";
            // 
            // checkDailyLinesStudy
            // 
            this.checkDailyLinesStudy.AutoSize = true;
            this.checkDailyLinesStudy.Checked = true;
            this.checkDailyLinesStudy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDailyLinesStudy.Location = new System.Drawing.Point(184, 133);
            this.checkDailyLinesStudy.Name = "checkDailyLinesStudy";
            this.checkDailyLinesStudy.Size = new System.Drawing.Size(99, 21);
            this.checkDailyLinesStudy.TabIndex = 63;
            this.checkDailyLinesStudy.Text = "Daily Lines";
            this.checkDailyLinesStudy.UseVisualStyleBackColor = true;
            this.checkDailyLinesStudy.CheckedChanged += new System.EventHandler(this.checkDailyLinesStudy_CheckedChanged);
            // 
            // hdRequest_Duration
            // 
            this.hdRequest_Duration.Location = new System.Drawing.Point(16, 76);
            this.hdRequest_Duration.Margin = new System.Windows.Forms.Padding(4);
            this.hdRequest_Duration.Name = "hdRequest_Duration";
            this.hdRequest_Duration.Size = new System.Drawing.Size(42, 22);
            this.hdRequest_Duration.TabIndex = 47;
            this.hdRequest_Duration.Text = "3";
            // 
            // checkHighLowStudy
            // 
            this.checkHighLowStudy.AutoSize = true;
            this.checkHighLowStudy.Checked = true;
            this.checkHighLowStudy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHighLowStudy.Location = new System.Drawing.Point(185, 106);
            this.checkHighLowStudy.Name = "checkHighLowStudy";
            this.checkHighLowStudy.Size = new System.Drawing.Size(88, 21);
            this.checkHighLowStudy.TabIndex = 35;
            this.checkHighLowStudy.Text = "High/Low";
            this.checkHighLowStudy.UseVisualStyleBackColor = true;
            this.checkHighLowStudy.CheckedChanged += new System.EventHandler(this.checkHighLowStudy_CheckedChanged);
            // 
            // hdRequest_TimeUnit
            // 
            this.hdRequest_TimeUnit.FormattingEnabled = true;
            this.hdRequest_TimeUnit.Items.AddRange(new object[] {
            "W",
            "M",
            "Y"});
            this.hdRequest_TimeUnit.Location = new System.Drawing.Point(66, 75);
            this.hdRequest_TimeUnit.Margin = new System.Windows.Forms.Padding(4);
            this.hdRequest_TimeUnit.Name = "hdRequest_TimeUnit";
            this.hdRequest_TimeUnit.Size = new System.Drawing.Size(47, 24);
            this.hdRequest_TimeUnit.TabIndex = 49;
            this.hdRequest_TimeUnit.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Daily";
            // 
            // histDataTabClose_MDT
            // 
            this.histDataTabClose_MDT.AutoSize = true;
            this.histDataTabClose_MDT.Location = new System.Drawing.Point(8, 4);
            this.histDataTabClose_MDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.histDataTabClose_MDT.Name = "histDataTabClose_MDT";
            this.histDataTabClose_MDT.Size = new System.Drawing.Size(43, 17);
            this.histDataTabClose_MDT.TabIndex = 2;
            this.histDataTabClose_MDT.TabStop = true;
            this.histDataTabClose_MDT.Text = "Close";
            this.histDataTabClose_MDT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.histDataTabClose_MDT_LinkClicked);
            // 
            // deepBookTab_MDT
            // 
            this.deepBookTab_MDT.BackColor = System.Drawing.Color.LightGray;
            this.deepBookTab_MDT.Controls.Add(this.closeDeepBookLink);
            this.deepBookTab_MDT.Controls.Add(this.deepBookGrid);
            this.deepBookTab_MDT.Location = new System.Drawing.Point(4, 25);
            this.deepBookTab_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.deepBookTab_MDT.Name = "deepBookTab_MDT";
            this.deepBookTab_MDT.Padding = new System.Windows.Forms.Padding(4);
            this.deepBookTab_MDT.Size = new System.Drawing.Size(1648, 421);
            this.deepBookTab_MDT.TabIndex = 1;
            this.deepBookTab_MDT.Text = "Deep Book";
            // 
            // closeDeepBookLink
            // 
            this.closeDeepBookLink.AutoSize = true;
            this.closeDeepBookLink.Location = new System.Drawing.Point(8, 4);
            this.closeDeepBookLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeDeepBookLink.Name = "closeDeepBookLink";
            this.closeDeepBookLink.Size = new System.Drawing.Size(43, 17);
            this.closeDeepBookLink.TabIndex = 1;
            this.closeDeepBookLink.TabStop = true;
            this.closeDeepBookLink.Text = "Close";
            this.closeDeepBookLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.closeDeepBookLink_LinkClicked);
            // 
            // deepBookGrid
            // 
            this.deepBookGrid.AllowUserToAddRows = false;
            this.deepBookGrid.AllowUserToDeleteRows = false;
            this.deepBookGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deepBookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deepBookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bidBookMaker,
            this.bidBookSize,
            this.bidBookPrice,
            this.askBookPrice,
            this.askBookSize,
            this.askBookMaker});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deepBookGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.deepBookGrid.Location = new System.Drawing.Point(5, 23);
            this.deepBookGrid.Margin = new System.Windows.Forms.Padding(4);
            this.deepBookGrid.Name = "deepBookGrid";
            this.deepBookGrid.ReadOnly = true;
            this.deepBookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deepBookGrid.Size = new System.Drawing.Size(176, 34);
            this.deepBookGrid.TabIndex = 0;
            // 
            // bidBookMaker
            // 
            this.bidBookMaker.HeaderText = "Market Maker";
            this.bidBookMaker.Name = "bidBookMaker";
            this.bidBookMaker.ReadOnly = true;
            // 
            // bidBookSize
            // 
            this.bidBookSize.HeaderText = "Bid Size";
            this.bidBookSize.Name = "bidBookSize";
            this.bidBookSize.ReadOnly = true;
            // 
            // bidBookPrice
            // 
            this.bidBookPrice.HeaderText = "Bid Price";
            this.bidBookPrice.Name = "bidBookPrice";
            this.bidBookPrice.ReadOnly = true;
            // 
            // askBookPrice
            // 
            this.askBookPrice.HeaderText = "Ask Price";
            this.askBookPrice.Name = "askBookPrice";
            this.askBookPrice.ReadOnly = true;
            // 
            // askBookSize
            // 
            this.askBookSize.HeaderText = "Ask Size";
            this.askBookSize.Name = "askBookSize";
            this.askBookSize.ReadOnly = true;
            // 
            // askBookMaker
            // 
            this.askBookMaker.HeaderText = "Market Maker";
            this.askBookMaker.Name = "askBookMaker";
            this.askBookMaker.ReadOnly = true;
            // 
            // rtBarsTab_MDT
            // 
            this.rtBarsTab_MDT.BackColor = System.Drawing.Color.LightGray;
            this.rtBarsTab_MDT.Controls.Add(this.rtBarsCloseLink);
            this.rtBarsTab_MDT.Controls.Add(this.rtBarsGrid);
            this.rtBarsTab_MDT.Location = new System.Drawing.Point(4, 25);
            this.rtBarsTab_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.rtBarsTab_MDT.Name = "rtBarsTab_MDT";
            this.rtBarsTab_MDT.Padding = new System.Windows.Forms.Padding(4);
            this.rtBarsTab_MDT.Size = new System.Drawing.Size(1648, 421);
            this.rtBarsTab_MDT.TabIndex = 2;
            this.rtBarsTab_MDT.Text = "RT Bars";
            // 
            // rtBarsCloseLink
            // 
            this.rtBarsCloseLink.AutoSize = true;
            this.rtBarsCloseLink.Location = new System.Drawing.Point(8, 5);
            this.rtBarsCloseLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rtBarsCloseLink.Name = "rtBarsCloseLink";
            this.rtBarsCloseLink.Size = new System.Drawing.Size(43, 17);
            this.rtBarsCloseLink.TabIndex = 4;
            this.rtBarsCloseLink.TabStop = true;
            this.rtBarsCloseLink.Text = "Close";
            this.rtBarsCloseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.rtBarsCloseLink_LinkClicked);
            // 
            // rtBarsGrid
            // 
            this.rtBarsGrid.AllowUserToAddRows = false;
            this.rtBarsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtBarsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rtBarsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.rtBarsGrid.Location = new System.Drawing.Point(7, 25);
            this.rtBarsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.rtBarsGrid.Name = "rtBarsGrid";
            this.rtBarsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rtBarsGrid.Size = new System.Drawing.Size(672, 34);
            this.rtBarsGrid.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Open";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "High";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Low";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Close";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Volume";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "WAP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // scannerTab
            // 
            this.scannerTab.BackColor = System.Drawing.Color.LightGray;
            this.scannerTab.Controls.Add(this.scannerTab_link);
            this.scannerTab.Controls.Add(this.scannerGrid);
            this.scannerTab.Location = new System.Drawing.Point(4, 25);
            this.scannerTab.Margin = new System.Windows.Forms.Padding(4);
            this.scannerTab.Name = "scannerTab";
            this.scannerTab.Padding = new System.Windows.Forms.Padding(4);
            this.scannerTab.Size = new System.Drawing.Size(1648, 421);
            this.scannerTab.TabIndex = 3;
            this.scannerTab.Text = "Scanner";
            // 
            // scannerTab_link
            // 
            this.scannerTab_link.AutoSize = true;
            this.scannerTab_link.Location = new System.Drawing.Point(8, 4);
            this.scannerTab_link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scannerTab_link.Name = "scannerTab_link";
            this.scannerTab_link.Size = new System.Drawing.Size(43, 17);
            this.scannerTab_link.TabIndex = 1;
            this.scannerTab_link.TabStop = true;
            this.scannerTab_link.Text = "Close";
            this.scannerTab_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.scannerTab_link_LinkClicked);
            // 
            // scannerGrid
            // 
            this.scannerGrid.AllowUserToAddRows = false;
            this.scannerGrid.AllowUserToDeleteRows = false;
            this.scannerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scannerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scanRank,
            this.scanContract,
            this.scanDistance,
            this.scanBenchmark,
            this.scanProjection,
            this.scanLegStr});
            this.scannerGrid.Location = new System.Drawing.Point(5, 34);
            this.scannerGrid.Margin = new System.Windows.Forms.Padding(4);
            this.scannerGrid.Name = "scannerGrid";
            this.scannerGrid.ReadOnly = true;
            this.scannerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scannerGrid.Size = new System.Drawing.Size(1020, 258);
            this.scannerGrid.TabIndex = 0;
            // 
            // scanRank
            // 
            this.scanRank.HeaderText = "Rank";
            this.scanRank.Name = "scanRank";
            this.scanRank.ReadOnly = true;
            // 
            // scanContract
            // 
            this.scanContract.HeaderText = "Contract";
            this.scanContract.Name = "scanContract";
            this.scanContract.ReadOnly = true;
            this.scanContract.Width = 200;
            // 
            // scanDistance
            // 
            this.scanDistance.HeaderText = "Distance";
            this.scanDistance.Name = "scanDistance";
            this.scanDistance.ReadOnly = true;
            // 
            // scanBenchmark
            // 
            this.scanBenchmark.HeaderText = "Benchmark";
            this.scanBenchmark.Name = "scanBenchmark";
            this.scanBenchmark.ReadOnly = true;
            // 
            // scanProjection
            // 
            this.scanProjection.HeaderText = "Projection";
            this.scanProjection.Name = "scanProjection";
            this.scanProjection.ReadOnly = true;
            // 
            // scanLegStr
            // 
            this.scanLegStr.HeaderText = "Legs";
            this.scanLegStr.Name = "scanLegStr";
            this.scanLegStr.ReadOnly = true;
            // 
            // dataResults_MDT
            // 
            this.dataResults_MDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataResults_MDT.Controls.Add(this.topMktData_MDT);
            this.dataResults_MDT.Controls.Add(this.marketScanner_MDT);
            this.dataResults_MDT.Location = new System.Drawing.Point(0, 0);
            this.dataResults_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.dataResults_MDT.Name = "dataResults_MDT";
            this.dataResults_MDT.SelectedIndex = 0;
            this.dataResults_MDT.Size = new System.Drawing.Size(1651, 282);
            this.dataResults_MDT.TabIndex = 0;
            // 
            // topMktData_MDT
            // 
            this.topMktData_MDT.BackColor = System.Drawing.Color.LightGray;
            this.topMktData_MDT.Controls.Add(this.deepBookGroupBox);
            this.topMktData_MDT.Controls.Add(this.groupBox2);
            this.topMktData_MDT.Controls.Add(this.groupBox1);
            this.topMktData_MDT.Location = new System.Drawing.Point(4, 25);
            this.topMktData_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.topMktData_MDT.Name = "topMktData_MDT";
            this.topMktData_MDT.Padding = new System.Windows.Forms.Padding(4);
            this.topMktData_MDT.Size = new System.Drawing.Size(1643, 253);
            this.topMktData_MDT.TabIndex = 0;
            this.topMktData_MDT.Text = "Market Data";
            // 
            // deepBookGroupBox
            // 
            this.deepBookGroupBox.Controls.Add(this.deepBookEntries);
            this.deepBookGroupBox.Controls.Add(this.deepBookEntriesLabel);
            this.deepBookGroupBox.Controls.Add(this.deepBook_Button);
            this.deepBookGroupBox.Location = new System.Drawing.Point(1101, 7);
            this.deepBookGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.deepBookGroupBox.Name = "deepBookGroupBox";
            this.deepBookGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.deepBookGroupBox.Size = new System.Drawing.Size(285, 220);
            this.deepBookGroupBox.TabIndex = 58;
            this.deepBookGroupBox.TabStop = false;
            this.deepBookGroupBox.Text = "Market Depth";
            // 
            // deepBookEntries
            // 
            this.deepBookEntries.Location = new System.Drawing.Point(139, 25);
            this.deepBookEntries.Margin = new System.Windows.Forms.Padding(4);
            this.deepBookEntries.Name = "deepBookEntries";
            this.deepBookEntries.Size = new System.Drawing.Size(132, 22);
            this.deepBookEntries.TabIndex = 57;
            this.deepBookEntries.Text = "3";
            // 
            // deepBookEntriesLabel
            // 
            this.deepBookEntriesLabel.AutoSize = true;
            this.deepBookEntriesLabel.Location = new System.Drawing.Point(8, 28);
            this.deepBookEntriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deepBookEntriesLabel.Name = "deepBookEntriesLabel";
            this.deepBookEntriesLabel.Size = new System.Drawing.Size(121, 17);
            this.deepBookEntriesLabel.TabIndex = 56;
            this.deepBookEntriesLabel.Text = "Number of entries";
            // 
            // deepBook_Button
            // 
            this.deepBook_Button.Location = new System.Drawing.Point(168, 177);
            this.deepBook_Button.Margin = new System.Windows.Forms.Padding(4);
            this.deepBook_Button.Name = "deepBook_Button";
            this.deepBook_Button.Size = new System.Drawing.Size(109, 28);
            this.deepBook_Button.TabIndex = 16;
            this.deepBook_Button.Text = "Deep Book";
            this.deepBook_Button.UseVisualStyleBackColor = true;
            this.deepBook_Button.Click += new System.EventHandler(this.deepBook_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.primaryExchange);
            this.groupBox2.Controls.Add(this.primaryExchLabel);
            this.groupBox2.Controls.Add(this.genericTickList);
            this.groupBox2.Controls.Add(this.genericTickListLabel);
            this.groupBox2.Controls.Add(this.mdRightLabel);
            this.groupBox2.Controls.Add(this.mdContractRight);
            this.groupBox2.Controls.Add(this.putcall_label_TMD_MDT);
            this.groupBox2.Controls.Add(this.includeExpired);
            this.groupBox2.Controls.Add(this.multiplier_TMD_MDT);
            this.groupBox2.Controls.Add(this.symbol_label_TMD_MDT);
            this.groupBox2.Controls.Add(this.marketData_Button);
            this.groupBox2.Controls.Add(this.secType_TMD_MDT);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.exchange_label_TMD_MDT);
            this.groupBox2.Controls.Add(this.localSymbol_TMD_MDT);
            this.groupBox2.Controls.Add(this.currency_label_TMD_MDT);
            this.groupBox2.Controls.Add(this.expiry_TMD_MDT);
            this.groupBox2.Controls.Add(this.symbol_TMD_MDT);
            this.groupBox2.Controls.Add(this.strike_TMD_MDT);
            this.groupBox2.Controls.Add(this.currency_TMD_MDT);
            this.groupBox2.Controls.Add(this.exchange_TMD_MDT);
            this.groupBox2.Controls.Add(this.localSymbol_label_TMD_MDT);
            this.groupBox2.Controls.Add(this.expiry_label_TMD_MDT);
            this.groupBox2.Controls.Add(this.strike_label_TMD_MDT);
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(661, 220);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contract";
            // 
            // primaryExchange
            // 
            this.primaryExchange.Location = new System.Drawing.Point(113, 180);
            this.primaryExchange.Margin = new System.Windows.Forms.Padding(4);
            this.primaryExchange.Name = "primaryExchange";
            this.primaryExchange.Size = new System.Drawing.Size(132, 22);
            this.primaryExchange.TabIndex = 61;
            // 
            // primaryExchLabel
            // 
            this.primaryExchLabel.AutoSize = true;
            this.primaryExchLabel.Location = new System.Drawing.Point(11, 183);
            this.primaryExchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.primaryExchLabel.Name = "primaryExchLabel";
            this.primaryExchLabel.Size = new System.Drawing.Size(94, 17);
            this.primaryExchLabel.TabIndex = 60;
            this.primaryExchLabel.Text = "Primary Exch.";
            // 
            // genericTickList
            // 
            this.genericTickList.Location = new System.Drawing.Point(368, 18);
            this.genericTickList.Margin = new System.Windows.Forms.Padding(4);
            this.genericTickList.Name = "genericTickList";
            this.genericTickList.Size = new System.Drawing.Size(280, 22);
            this.genericTickList.TabIndex = 59;
            // 
            // genericTickListLabel
            // 
            this.genericTickListLabel.AutoSize = true;
            this.genericTickListLabel.Location = new System.Drawing.Point(255, 22);
            this.genericTickListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genericTickListLabel.Name = "genericTickListLabel";
            this.genericTickListLabel.Size = new System.Drawing.Size(104, 17);
            this.genericTickListLabel.TabIndex = 58;
            this.genericTickListLabel.Text = "Generic tick list";
            // 
            // mdRightLabel
            // 
            this.mdRightLabel.AutoSize = true;
            this.mdRightLabel.Location = new System.Drawing.Point(300, 82);
            this.mdRightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mdRightLabel.Name = "mdRightLabel";
            this.mdRightLabel.Size = new System.Drawing.Size(56, 17);
            this.mdRightLabel.TabIndex = 57;
            this.mdRightLabel.Text = "Put/Call";
            // 
            // mdContractRight
            // 
            this.mdContractRight.FormattingEnabled = true;
            this.mdContractRight.Location = new System.Drawing.Point(368, 81);
            this.mdContractRight.Margin = new System.Windows.Forms.Padding(4);
            this.mdContractRight.Name = "mdContractRight";
            this.mdContractRight.Size = new System.Drawing.Size(132, 24);
            this.mdContractRight.TabIndex = 56;
            // 
            // putcall_label_TMD_MDT
            // 
            this.putcall_label_TMD_MDT.AutoSize = true;
            this.putcall_label_TMD_MDT.Location = new System.Drawing.Point(295, 144);
            this.putcall_label_TMD_MDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.putcall_label_TMD_MDT.Name = "putcall_label_TMD_MDT";
            this.putcall_label_TMD_MDT.Size = new System.Drawing.Size(64, 17);
            this.putcall_label_TMD_MDT.TabIndex = 6;
            this.putcall_label_TMD_MDT.Text = "Multiplier";
            // 
            // includeExpired
            // 
            this.includeExpired.AutoSize = true;
            this.includeExpired.Location = new System.Drawing.Point(519, 52);
            this.includeExpired.Margin = new System.Windows.Forms.Padding(4);
            this.includeExpired.Name = "includeExpired";
            this.includeExpired.Size = new System.Drawing.Size(125, 21);
            this.includeExpired.TabIndex = 56;
            this.includeExpired.Text = "Include expired";
            this.includeExpired.UseVisualStyleBackColor = true;
            // 
            // multiplier_TMD_MDT
            // 
            this.multiplier_TMD_MDT.Location = new System.Drawing.Point(368, 144);
            this.multiplier_TMD_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.multiplier_TMD_MDT.Name = "multiplier_TMD_MDT";
            this.multiplier_TMD_MDT.Size = new System.Drawing.Size(132, 22);
            this.multiplier_TMD_MDT.TabIndex = 12;
            // 
            // symbol_label_TMD_MDT
            // 
            this.symbol_label_TMD_MDT.AutoSize = true;
            this.symbol_label_TMD_MDT.Location = new System.Drawing.Point(51, 22);
            this.symbol_label_TMD_MDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.symbol_label_TMD_MDT.Name = "symbol_label_TMD_MDT";
            this.symbol_label_TMD_MDT.Size = new System.Drawing.Size(54, 17);
            this.symbol_label_TMD_MDT.TabIndex = 1;
            this.symbol_label_TMD_MDT.Text = "Symbol";
            // 
            // marketData_Button
            // 
            this.marketData_Button.Location = new System.Drawing.Point(392, 180);
            this.marketData_Button.Margin = new System.Windows.Forms.Padding(4);
            this.marketData_Button.Name = "marketData_Button";
            this.marketData_Button.Size = new System.Drawing.Size(109, 28);
            this.marketData_Button.TabIndex = 17;
            this.marketData_Button.Text = "Add Ticker";
            this.marketData_Button.UseVisualStyleBackColor = true;
            this.marketData_Button.Click += new System.EventHandler(this.marketData_Click);
            // 
            // secType_TMD_MDT
            // 
            this.secType_TMD_MDT.FormattingEnabled = true;
            this.secType_TMD_MDT.Items.AddRange(new object[] {
            "STK",
            "OPT",
            "FUT",
            "CASH",
            "BOND",
            "CFD",
            "FOP",
            "WAR",
            "IOPT",
            "FWD",
            "BAG",
            "IND",
            "BILL",
            "FUND",
            "FIXED",
            "SLB",
            "NEWS",
            "CMDTY",
            "BSK",
            "ICU",
            "ICS"});
            this.secType_TMD_MDT.Location = new System.Drawing.Point(113, 49);
            this.secType_TMD_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.secType_TMD_MDT.Name = "secType_TMD_MDT";
            this.secType_TMD_MDT.Size = new System.Drawing.Size(132, 24);
            this.secType_TMD_MDT.TabIndex = 2;
            this.secType_TMD_MDT.Text = "STK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "SecType";
            // 
            // exchange_label_TMD_MDT
            // 
            this.exchange_label_TMD_MDT.AutoSize = true;
            this.exchange_label_TMD_MDT.Location = new System.Drawing.Point(32, 114);
            this.exchange_label_TMD_MDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exchange_label_TMD_MDT.Name = "exchange_label_TMD_MDT";
            this.exchange_label_TMD_MDT.Size = new System.Drawing.Size(70, 17);
            this.exchange_label_TMD_MDT.TabIndex = 7;
            this.exchange_label_TMD_MDT.Text = "Exchange";
            // 
            // localSymbol_TMD_MDT
            // 
            this.localSymbol_TMD_MDT.Location = new System.Drawing.Point(113, 148);
            this.localSymbol_TMD_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.localSymbol_TMD_MDT.Name = "localSymbol_TMD_MDT";
            this.localSymbol_TMD_MDT.Size = new System.Drawing.Size(132, 22);
            this.localSymbol_TMD_MDT.TabIndex = 15;
            // 
            // currency_label_TMD_MDT
            // 
            this.currency_label_TMD_MDT.AutoSize = true;
            this.currency_label_TMD_MDT.Location = new System.Drawing.Point(40, 82);
            this.currency_label_TMD_MDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currency_label_TMD_MDT.Name = "currency_label_TMD_MDT";
            this.currency_label_TMD_MDT.Size = new System.Drawing.Size(65, 17);
            this.currency_label_TMD_MDT.TabIndex = 8;
            this.currency_label_TMD_MDT.Text = "Currency";
            // 
            // expiry_TMD_MDT
            // 
            this.expiry_TMD_MDT.Location = new System.Drawing.Point(368, 49);
            this.expiry_TMD_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.expiry_TMD_MDT.Name = "expiry_TMD_MDT";
            this.expiry_TMD_MDT.Size = new System.Drawing.Size(132, 22);
            this.expiry_TMD_MDT.TabIndex = 14;
            // 
            // symbol_TMD_MDT
            // 
            this.symbol_TMD_MDT.Location = new System.Drawing.Point(113, 18);
            this.symbol_TMD_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.symbol_TMD_MDT.Name = "symbol_TMD_MDT";
            this.symbol_TMD_MDT.Size = new System.Drawing.Size(132, 22);
            this.symbol_TMD_MDT.TabIndex = 0;
            this.symbol_TMD_MDT.Text = "SPY";
            // 
            // strike_TMD_MDT
            // 
            this.strike_TMD_MDT.Location = new System.Drawing.Point(368, 114);
            this.strike_TMD_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.strike_TMD_MDT.Name = "strike_TMD_MDT";
            this.strike_TMD_MDT.Size = new System.Drawing.Size(132, 22);
            this.strike_TMD_MDT.TabIndex = 13;
            // 
            // currency_TMD_MDT
            // 
            this.currency_TMD_MDT.Location = new System.Drawing.Point(113, 82);
            this.currency_TMD_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.currency_TMD_MDT.Name = "currency_TMD_MDT";
            this.currency_TMD_MDT.Size = new System.Drawing.Size(132, 22);
            this.currency_TMD_MDT.TabIndex = 10;
            this.currency_TMD_MDT.Text = "USD";
            // 
            // exchange_TMD_MDT
            // 
            this.exchange_TMD_MDT.Location = new System.Drawing.Point(113, 114);
            this.exchange_TMD_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.exchange_TMD_MDT.Name = "exchange_TMD_MDT";
            this.exchange_TMD_MDT.Size = new System.Drawing.Size(132, 22);
            this.exchange_TMD_MDT.TabIndex = 11;
            this.exchange_TMD_MDT.Text = "SMART";
            // 
            // localSymbol_label_TMD_MDT
            // 
            this.localSymbol_label_TMD_MDT.AutoSize = true;
            this.localSymbol_label_TMD_MDT.Location = new System.Drawing.Point(12, 148);
            this.localSymbol_label_TMD_MDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.localSymbol_label_TMD_MDT.Name = "localSymbol_label_TMD_MDT";
            this.localSymbol_label_TMD_MDT.Size = new System.Drawing.Size(92, 17);
            this.localSymbol_label_TMD_MDT.TabIndex = 9;
            this.localSymbol_label_TMD_MDT.Text = "Local Symbol";
            // 
            // expiry_label_TMD_MDT
            // 
            this.expiry_label_TMD_MDT.AutoSize = true;
            this.expiry_label_TMD_MDT.Location = new System.Drawing.Point(313, 48);
            this.expiry_label_TMD_MDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expiry_label_TMD_MDT.Name = "expiry_label_TMD_MDT";
            this.expiry_label_TMD_MDT.Size = new System.Drawing.Size(46, 17);
            this.expiry_label_TMD_MDT.TabIndex = 4;
            this.expiry_label_TMD_MDT.Text = "Expiry";
            // 
            // strike_label_TMD_MDT
            // 
            this.strike_label_TMD_MDT.AutoSize = true;
            this.strike_label_TMD_MDT.Location = new System.Drawing.Point(315, 114);
            this.strike_label_TMD_MDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.strike_label_TMD_MDT.Name = "strike_label_TMD_MDT";
            this.strike_label_TMD_MDT.Size = new System.Drawing.Size(44, 17);
            this.strike_label_TMD_MDT.TabIndex = 5;
            this.strike_label_TMD_MDT.Text = "Strike";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkRTData);
            this.groupBox1.Controls.Add(this.histData_1M_Button);
            this.groupBox1.Controls.Add(this.histData_Button);
            this.groupBox1.Controls.Add(this.hdRequest_BarSize);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(677, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(416, 220);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bar request";
            // 
            // checkRTData
            // 
            this.checkRTData.AutoSize = true;
            this.checkRTData.Checked = true;
            this.checkRTData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRTData.Location = new System.Drawing.Point(295, 185);
            this.checkRTData.Name = "checkRTData";
            this.checkRTData.Size = new System.Drawing.Size(94, 21);
            this.checkRTData.TabIndex = 62;
            this.checkRTData.Text = "Real Time";
            this.checkRTData.UseVisualStyleBackColor = true;
            // 
            // histData_1M_Button
            // 
            this.histData_1M_Button.Location = new System.Drawing.Point(131, 180);
            this.histData_1M_Button.Margin = new System.Windows.Forms.Padding(4);
            this.histData_1M_Button.Name = "histData_1M_Button";
            this.histData_1M_Button.Size = new System.Drawing.Size(154, 28);
            this.histData_1M_Button.TabIndex = 61;
            this.histData_1M_Button.Text = "Test HD/RT Charts";
            this.histData_1M_Button.UseVisualStyleBackColor = true;
            this.histData_1M_Button.Click += new System.EventHandler(this.histData_1M_Button_Click);
            // 
            // histData_Button
            // 
            this.histData_Button.Location = new System.Drawing.Point(12, 180);
            this.histData_Button.Margin = new System.Windows.Forms.Padding(4);
            this.histData_Button.Name = "histData_Button";
            this.histData_Button.Size = new System.Drawing.Size(100, 28);
            this.histData_Button.TabIndex = 54;
            this.histData_Button.Text = "Historical";
            this.histData_Button.UseVisualStyleBackColor = true;
            // 
            // hdRequest_BarSize
            // 
            this.hdRequest_BarSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdRequest_BarSize.FormattingEnabled = true;
            this.hdRequest_BarSize.Items.AddRange(new object[] {
            "1 sec",
            "5 secs",
            "15 secs",
            "30 secs",
            "1 min",
            "2 mins",
            "3 mins",
            "5 mins",
            "15 mins",
            "30 mins",
            "1 hour",
            "1 day"});
            this.hdRequest_BarSize.Location = new System.Drawing.Point(79, 81);
            this.hdRequest_BarSize.Margin = new System.Windows.Forms.Padding(4);
            this.hdRequest_BarSize.Name = "hdRequest_BarSize";
            this.hdRequest_BarSize.Size = new System.Drawing.Size(207, 25);
            this.hdRequest_BarSize.TabIndex = 51;
            this.hdRequest_BarSize.Text = "1 day";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 50;
            this.label11.Text = "Bar Size";
            // 
            // marketScanner_MDT
            // 
            this.marketScanner_MDT.BackColor = System.Drawing.Color.LightGray;
            this.marketScanner_MDT.Controls.Add(this.scanLocation);
            this.marketScanner_MDT.Controls.Add(this.scannerRequest_Button);
            this.marketScanner_MDT.Controls.Add(this.scanNumRows_label);
            this.marketScanner_MDT.Controls.Add(this.scanStockType_label);
            this.marketScanner_MDT.Controls.Add(this.scanLocation_label);
            this.marketScanner_MDT.Controls.Add(this.scanInstrument_label);
            this.marketScanner_MDT.Controls.Add(this.scanCode_label);
            this.marketScanner_MDT.Controls.Add(this.scanNumRows);
            this.marketScanner_MDT.Controls.Add(this.scanStockType);
            this.marketScanner_MDT.Controls.Add(this.scanInstrument);
            this.marketScanner_MDT.Controls.Add(this.scanCode);
            this.marketScanner_MDT.Location = new System.Drawing.Point(4, 25);
            this.marketScanner_MDT.Margin = new System.Windows.Forms.Padding(4);
            this.marketScanner_MDT.Name = "marketScanner_MDT";
            this.marketScanner_MDT.Padding = new System.Windows.Forms.Padding(4);
            this.marketScanner_MDT.Size = new System.Drawing.Size(1643, 253);
            this.marketScanner_MDT.TabIndex = 4;
            this.marketScanner_MDT.Text = "Scanner";
            // 
            // scanLocation
            // 
            this.scanLocation.FormattingEnabled = true;
            this.scanLocation.Items.AddRange(new object[] {
            "STK.US",
            "STK.US.MAJOR",
            "STK.US.MINOR",
            "STK.HK.SEHK",
            "STK.HK.ASX",
            "STK.EU"});
            this.scanLocation.Location = new System.Drawing.Point(489, 17);
            this.scanLocation.Margin = new System.Windows.Forms.Padding(4);
            this.scanLocation.Name = "scanLocation";
            this.scanLocation.Size = new System.Drawing.Size(160, 24);
            this.scanLocation.TabIndex = 11;
            this.scanLocation.Text = "STK.EU.IBIS";
            // 
            // scannerRequest_Button
            // 
            this.scannerRequest_Button.Location = new System.Drawing.Point(521, 89);
            this.scannerRequest_Button.Margin = new System.Windows.Forms.Padding(4);
            this.scannerRequest_Button.Name = "scannerRequest_Button";
            this.scannerRequest_Button.Size = new System.Drawing.Size(101, 26);
            this.scannerRequest_Button.TabIndex = 10;
            this.scannerRequest_Button.Text = "Submit";
            this.scannerRequest_Button.UseVisualStyleBackColor = true;
            this.scannerRequest_Button.Click += new System.EventHandler(this.scannerRequest_Button_Click);
            // 
            // scanNumRows_label
            // 
            this.scanNumRows_label.AutoSize = true;
            this.scanNumRows_label.Location = new System.Drawing.Point(403, 54);
            this.scanNumRows_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scanNumRows_label.Name = "scanNumRows_label";
            this.scanNumRows_label.Size = new System.Drawing.Size(75, 17);
            this.scanNumRows_label.TabIndex = 9;
            this.scanNumRows_label.Text = "Num Rows";
            // 
            // scanStockType_label
            // 
            this.scanStockType_label.AutoSize = true;
            this.scanStockType_label.Location = new System.Drawing.Point(5, 85);
            this.scanStockType_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scanStockType_label.Name = "scanStockType_label";
            this.scanStockType_label.Size = new System.Drawing.Size(79, 17);
            this.scanStockType_label.TabIndex = 8;
            this.scanStockType_label.Text = "Stock Type";
            // 
            // scanLocation_label
            // 
            this.scanLocation_label.AutoSize = true;
            this.scanLocation_label.Location = new System.Drawing.Point(417, 17);
            this.scanLocation_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scanLocation_label.Name = "scanLocation_label";
            this.scanLocation_label.Size = new System.Drawing.Size(62, 17);
            this.scanLocation_label.TabIndex = 7;
            this.scanLocation_label.Text = "Location";
            // 
            // scanInstrument_label
            // 
            this.scanInstrument_label.AutoSize = true;
            this.scanInstrument_label.Location = new System.Drawing.Point(13, 50);
            this.scanInstrument_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scanInstrument_label.Name = "scanInstrument_label";
            this.scanInstrument_label.Size = new System.Drawing.Size(74, 17);
            this.scanInstrument_label.TabIndex = 6;
            this.scanInstrument_label.Text = "Instrument";
            // 
            // scanCode_label
            // 
            this.scanCode_label.AutoSize = true;
            this.scanCode_label.Location = new System.Drawing.Point(8, 17);
            this.scanCode_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scanCode_label.Name = "scanCode_label";
            this.scanCode_label.Size = new System.Drawing.Size(77, 17);
            this.scanCode_label.TabIndex = 5;
            this.scanCode_label.Text = "Scan Code";
            // 
            // scanNumRows
            // 
            this.scanNumRows.Location = new System.Drawing.Point(489, 54);
            this.scanNumRows.Margin = new System.Windows.Forms.Padding(4);
            this.scanNumRows.Name = "scanNumRows";
            this.scanNumRows.Size = new System.Drawing.Size(132, 22);
            this.scanNumRows.TabIndex = 4;
            this.scanNumRows.Text = "15";
            // 
            // scanStockType
            // 
            this.scanStockType.FormattingEnabled = true;
            this.scanStockType.Location = new System.Drawing.Point(96, 85);
            this.scanStockType.Margin = new System.Windows.Forms.Padding(4);
            this.scanStockType.Name = "scanStockType";
            this.scanStockType.Size = new System.Drawing.Size(160, 24);
            this.scanStockType.TabIndex = 3;
            this.scanStockType.Text = "ALL";
            // 
            // scanInstrument
            // 
            this.scanInstrument.FormattingEnabled = true;
            this.scanInstrument.Items.AddRange(new object[] {
            "STK",
            "STOCK.HK",
            "STOCK.EU"});
            this.scanInstrument.Location = new System.Drawing.Point(96, 50);
            this.scanInstrument.Margin = new System.Windows.Forms.Padding(4);
            this.scanInstrument.Name = "scanInstrument";
            this.scanInstrument.Size = new System.Drawing.Size(160, 24);
            this.scanInstrument.TabIndex = 1;
            this.scanInstrument.Text = "STOCK.EU";
            // 
            // scanCode
            // 
            this.scanCode.FormattingEnabled = true;
            this.scanCode.Items.AddRange(new object[] {
            "LOW_OPT_VOL_PUT_CALL_RATIO",
            "HIGH_OPT_IMP_VOLAT_OVER_HIST",
            "LOW_OPT_IMP_VOLAT_OVER_HIST",
            "HIGH_OPT_IMP_VOLAT",
            "TOP_OPT_IMP_VOLAT_GAIN",
            "TOP_OPT_IMP_VOLAT_LOSE",
            "HIGH_OPT_VOLUME_PUT_CALL_RATIO",
            "LOW_OPT_VOLUME_PUT_CALL_RATIO",
            "OPT_VOLUME_MOST_ACTIVE",
            "HOT_BY_OPT_VOLUME",
            "HIGH_OPT_OPEN_INTEREST_PUT_CALL_RATIO",
            "LOW_OPT_OPEN_INTEREST_PUT_CALL_RATIO",
            "TOP_PERC_GAIN",
            "MOST_ACTIVE",
            "TOP_PERC_LOSE",
            "HOT_BY_VOLUME",
            "TOP_PERC_GAIN",
            "HOT_BY_PRICE",
            "TOP_TRADE_COUNT",
            "TOP_TRADE_RATE",
            "TOP_PRICE_RANGE",
            "HOT_BY_PRICE_RANGE",
            "TOP_VOLUME_RATE",
            "LOW_OPT_IMP_VOLAT",
            "OPT_OPEN_INTEREST_MOST_ACTIVE",
            "NOT_OPEN",
            "HALTED",
            "TOP_OPEN_PERC_GAIN",
            "TOP_OPEN_PERC_LOSE",
            "HIGH_OPEN_GAP",
            "LOW_OPEN_GAP",
            "LOW_OPT_IMP_VOLAT",
            "TOP_OPT_IMP_VOLAT_GAIN",
            "TOP_OPT_IMP_VOLAT_LOSE",
            "HIGH_VS_13W_HL",
            "LOW_VS_13W_HL",
            "HIGH_VS_26W_HL",
            "LOW_VS_26W_HL",
            "HIGH_VS_52W_HL",
            "LOW_VS_52W_HL",
            "HIGH_SYNTH_BID_REV_NAT_YIELD",
            "LOW_SYNTH_BID_REV_NAT_YIELD"});
            this.scanCode.Location = new System.Drawing.Point(96, 17);
            this.scanCode.Margin = new System.Windows.Forms.Padding(4);
            this.scanCode.Name = "scanCode";
            this.scanCode.Size = new System.Drawing.Size(237, 24);
            this.scanCode.TabIndex = 0;
            this.scanCode.Text = "TOP_PERC_GAIN";
            // 
            // tradingTab
            // 
            this.tradingTab.BackColor = System.Drawing.Color.LightGray;
            this.tradingTab.Controls.Add(this.globalCancelButton);
            this.tradingTab.Controls.Add(this.clientOrdersButton);
            this.tradingTab.Controls.Add(this.refreshOrdersButton);
            this.tradingTab.Controls.Add(this.cancelOrdersButton);
            this.tradingTab.Controls.Add(this.button1);
            this.tradingTab.Controls.Add(this.newOrderLink);
            this.tradingTab.Controls.Add(this.executionsGroup);
            this.tradingTab.Controls.Add(this.liveOrdersGroup);
            this.tradingTab.Location = new System.Drawing.Point(4, 25);
            this.tradingTab.Margin = new System.Windows.Forms.Padding(4);
            this.tradingTab.Name = "tradingTab";
            this.tradingTab.Padding = new System.Windows.Forms.Padding(4);
            this.tradingTab.Size = new System.Drawing.Size(1667, 656);
            this.tradingTab.TabIndex = 2;
            this.tradingTab.Text = "Trading";
            // 
            // globalCancelButton
            // 
            this.globalCancelButton.Location = new System.Drawing.Point(1219, 206);
            this.globalCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.globalCancelButton.Name = "globalCancelButton";
            this.globalCancelButton.Size = new System.Drawing.Size(140, 28);
            this.globalCancelButton.TabIndex = 9;
            this.globalCancelButton.Text = "Global cancel";
            this.globalCancelButton.UseVisualStyleBackColor = true;
            this.globalCancelButton.Click += new System.EventHandler(this.globalCancelButton_Click);
            // 
            // clientOrdersButton
            // 
            this.clientOrdersButton.Location = new System.Drawing.Point(1219, 62);
            this.clientOrdersButton.Margin = new System.Windows.Forms.Padding(4);
            this.clientOrdersButton.Name = "clientOrdersButton";
            this.clientOrdersButton.Size = new System.Drawing.Size(140, 28);
            this.clientOrdersButton.TabIndex = 8;
            this.clientOrdersButton.Text = "Get client\'s orders";
            this.clientOrdersButton.UseVisualStyleBackColor = true;
            this.clientOrdersButton.Click += new System.EventHandler(this.clientOrdersButton_Click);
            // 
            // refreshOrdersButton
            // 
            this.refreshOrdersButton.Location = new System.Drawing.Point(1219, 97);
            this.refreshOrdersButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshOrdersButton.Name = "refreshOrdersButton";
            this.refreshOrdersButton.Size = new System.Drawing.Size(140, 28);
            this.refreshOrdersButton.TabIndex = 1;
            this.refreshOrdersButton.Text = "Get all orders";
            this.refreshOrdersButton.UseVisualStyleBackColor = true;
            this.refreshOrdersButton.Click += new System.EventHandler(this.refreshOrdersButton_Click);
            // 
            // cancelOrdersButton
            // 
            this.cancelOrdersButton.Location = new System.Drawing.Point(1219, 170);
            this.cancelOrdersButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelOrdersButton.Name = "cancelOrdersButton";
            this.cancelOrdersButton.Size = new System.Drawing.Size(140, 28);
            this.cancelOrdersButton.TabIndex = 7;
            this.cancelOrdersButton.Text = "Cancel selection";
            this.cancelOrdersButton.UseVisualStyleBackColor = true;
            this.cancelOrdersButton.Click += new System.EventHandler(this.cancelOrdersButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1219, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bind TWS orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bindOrdersButton_Click);
            // 
            // newOrderLink
            // 
            this.newOrderLink.AutoSize = true;
            this.newOrderLink.Location = new System.Drawing.Point(1215, 31);
            this.newOrderLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newOrderLink.Name = "newOrderLink";
            this.newOrderLink.Size = new System.Drawing.Size(76, 17);
            this.newOrderLink.TabIndex = 3;
            this.newOrderLink.TabStop = true;
            this.newOrderLink.Text = "New Order";
            this.newOrderLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newOrderLink_LinkClicked);
            // 
            // executionsGroup
            // 
            this.executionsGroup.Controls.Add(this.refreshExecutionsButton);
            this.executionsGroup.Controls.Add(this.tradeLogGrid);
            this.executionsGroup.Location = new System.Drawing.Point(12, 268);
            this.executionsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.executionsGroup.Name = "executionsGroup";
            this.executionsGroup.Padding = new System.Windows.Forms.Padding(4);
            this.executionsGroup.Size = new System.Drawing.Size(1280, 290);
            this.executionsGroup.TabIndex = 2;
            this.executionsGroup.TabStop = false;
            this.executionsGroup.Text = "Trade Log (Executions)";
            // 
            // refreshExecutionsButton
            // 
            this.refreshExecutionsButton.Location = new System.Drawing.Point(1169, 255);
            this.refreshExecutionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshExecutionsButton.Name = "refreshExecutionsButton";
            this.refreshExecutionsButton.Size = new System.Drawing.Size(100, 28);
            this.refreshExecutionsButton.TabIndex = 1;
            this.refreshExecutionsButton.Text = "Refresh";
            this.refreshExecutionsButton.UseVisualStyleBackColor = true;
            this.refreshExecutionsButton.Click += new System.EventHandler(this.refreshExecutionsButton_Click);
            // 
            // tradeLogGrid
            // 
            this.tradeLogGrid.AllowUserToAddRows = false;
            this.tradeLogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tradeLogGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExecutionId,
            this.dateTimeExecColumn,
            this.accountExecColumn,
            this.actionExecColumn,
            this.quantityExecColumn,
            this.descriptionExecColumn,
            this.priceExecColumn,
            this.commissionExecColumn,
            this.RealisedPnL});
            this.tradeLogGrid.Location = new System.Drawing.Point(8, 23);
            this.tradeLogGrid.Margin = new System.Windows.Forms.Padding(4);
            this.tradeLogGrid.Name = "tradeLogGrid";
            this.tradeLogGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tradeLogGrid.Size = new System.Drawing.Size(1261, 224);
            this.tradeLogGrid.TabIndex = 0;
            // 
            // ExecutionId
            // 
            this.ExecutionId.HeaderText = "Execution ID";
            this.ExecutionId.Name = "ExecutionId";
            this.ExecutionId.ReadOnly = true;
            // 
            // dateTimeExecColumn
            // 
            this.dateTimeExecColumn.HeaderText = "Date/Time";
            this.dateTimeExecColumn.Name = "dateTimeExecColumn";
            this.dateTimeExecColumn.ReadOnly = true;
            // 
            // accountExecColumn
            // 
            this.accountExecColumn.HeaderText = "Account";
            this.accountExecColumn.Name = "accountExecColumn";
            this.accountExecColumn.ReadOnly = true;
            // 
            // actionExecColumn
            // 
            this.actionExecColumn.HeaderText = "Action";
            this.actionExecColumn.Name = "actionExecColumn";
            this.actionExecColumn.ReadOnly = true;
            // 
            // quantityExecColumn
            // 
            this.quantityExecColumn.HeaderText = "Quantity";
            this.quantityExecColumn.Name = "quantityExecColumn";
            this.quantityExecColumn.ReadOnly = true;
            // 
            // descriptionExecColumn
            // 
            this.descriptionExecColumn.HeaderText = "Description";
            this.descriptionExecColumn.Name = "descriptionExecColumn";
            this.descriptionExecColumn.ReadOnly = true;
            // 
            // priceExecColumn
            // 
            this.priceExecColumn.HeaderText = "Price";
            this.priceExecColumn.Name = "priceExecColumn";
            this.priceExecColumn.ReadOnly = true;
            // 
            // commissionExecColumn
            // 
            this.commissionExecColumn.HeaderText = "Commissions";
            this.commissionExecColumn.Name = "commissionExecColumn";
            this.commissionExecColumn.ReadOnly = true;
            // 
            // RealisedPnL
            // 
            this.RealisedPnL.HeaderText = "RealisedPnL";
            this.RealisedPnL.Name = "RealisedPnL";
            this.RealisedPnL.ReadOnly = true;
            // 
            // liveOrdersGroup
            // 
            this.liveOrdersGroup.Controls.Add(this.liveOrdersGrid);
            this.liveOrdersGroup.Location = new System.Drawing.Point(12, 7);
            this.liveOrdersGroup.Margin = new System.Windows.Forms.Padding(4);
            this.liveOrdersGroup.Name = "liveOrdersGroup";
            this.liveOrdersGroup.Padding = new System.Windows.Forms.Padding(4);
            this.liveOrdersGroup.Size = new System.Drawing.Size(1173, 254);
            this.liveOrdersGroup.TabIndex = 1;
            this.liveOrdersGroup.TabStop = false;
            this.liveOrdersGroup.Text = "Live Orders - double click to modify.";
            // 
            // liveOrdersGrid
            // 
            this.liveOrdersGrid.AllowUserToAddRows = false;
            this.liveOrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liveOrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.permIdColumn,
            this.clientIdColumn,
            this.orderIdColumn,
            this.accountColumn,
            this.actionColumn,
            this.quantityColumn,
            this.contractColumn,
            this.statusColumn});
            this.liveOrdersGrid.Location = new System.Drawing.Point(8, 23);
            this.liveOrdersGrid.Margin = new System.Windows.Forms.Padding(4);
            this.liveOrdersGrid.Name = "liveOrdersGrid";
            this.liveOrdersGrid.ReadOnly = true;
            this.liveOrdersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.liveOrdersGrid.Size = new System.Drawing.Size(1157, 223);
            this.liveOrdersGrid.TabIndex = 0;
            this.liveOrdersGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.liveOrdersGrid_CellCoubleClick);
            // 
            // permIdColumn
            // 
            this.permIdColumn.HeaderText = "Perm ID";
            this.permIdColumn.Name = "permIdColumn";
            this.permIdColumn.ReadOnly = true;
            // 
            // clientIdColumn
            // 
            this.clientIdColumn.HeaderText = "Client ID";
            this.clientIdColumn.Name = "clientIdColumn";
            this.clientIdColumn.ReadOnly = true;
            // 
            // orderIdColumn
            // 
            this.orderIdColumn.HeaderText = "Order ID";
            this.orderIdColumn.Name = "orderIdColumn";
            this.orderIdColumn.ReadOnly = true;
            // 
            // accountColumn
            // 
            this.accountColumn.HeaderText = "Account";
            this.accountColumn.Name = "accountColumn";
            this.accountColumn.ReadOnly = true;
            // 
            // actionColumn
            // 
            this.actionColumn.HeaderText = "Action";
            this.actionColumn.Name = "actionColumn";
            this.actionColumn.ReadOnly = true;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            // 
            // contractColumn
            // 
            this.contractColumn.HeaderText = "Contract";
            this.contractColumn.Name = "contractColumn";
            this.contractColumn.ReadOnly = true;
            this.contractColumn.Width = 120;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // accountInfoTab
            // 
            this.accountInfoTab.BackColor = System.Drawing.Color.LightGray;
            this.accountInfoTab.Controls.Add(this.tabControl1);
            this.accountInfoTab.Controls.Add(this.accountSelectorLabel);
            this.accountInfoTab.Controls.Add(this.accountSelector);
            this.accountInfoTab.Location = new System.Drawing.Point(4, 25);
            this.accountInfoTab.Margin = new System.Windows.Forms.Padding(4);
            this.accountInfoTab.Name = "accountInfoTab";
            this.accountInfoTab.Padding = new System.Windows.Forms.Padding(4);
            this.accountInfoTab.Size = new System.Drawing.Size(1667, 656);
            this.accountInfoTab.TabIndex = 3;
            this.accountInfoTab.Text = "Account Info";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.accSummaryTab);
            this.tabControl1.Controls.Add(this.accUpdatesTab);
            this.tabControl1.Controls.Add(this.positionsTab);
            this.tabControl1.Location = new System.Drawing.Point(8, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1648, 566);
            this.tabControl1.TabIndex = 2;
            // 
            // accSummaryTab
            // 
            this.accSummaryTab.BackColor = System.Drawing.Color.LightGray;
            this.accSummaryTab.Controls.Add(this.accSummaryRequest);
            this.accSummaryTab.Controls.Add(this.accSummaryGrid);
            this.accSummaryTab.Location = new System.Drawing.Point(4, 25);
            this.accSummaryTab.Margin = new System.Windows.Forms.Padding(4);
            this.accSummaryTab.Name = "accSummaryTab";
            this.accSummaryTab.Padding = new System.Windows.Forms.Padding(4);
            this.accSummaryTab.Size = new System.Drawing.Size(1640, 537);
            this.accSummaryTab.TabIndex = 0;
            this.accSummaryTab.Text = "Account Summary";
            // 
            // accSummaryRequest
            // 
            this.accSummaryRequest.Location = new System.Drawing.Point(831, 7);
            this.accSummaryRequest.Margin = new System.Windows.Forms.Padding(4);
            this.accSummaryRequest.Name = "accSummaryRequest";
            this.accSummaryRequest.Size = new System.Drawing.Size(100, 28);
            this.accSummaryRequest.TabIndex = 1;
            this.accSummaryRequest.Text = "Request";
            this.accSummaryRequest.UseVisualStyleBackColor = true;
            this.accSummaryRequest.Click += new System.EventHandler(this.accSummaryRequest_Click);
            // 
            // accSummaryGrid
            // 
            this.accSummaryGrid.AllowUserToAddRows = false;
            this.accSummaryGrid.AllowUserToDeleteRows = false;
            this.accSummaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accSummaryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tag,
            this.value,
            this.currency,
            this.accountSummaryAccount});
            this.accSummaryGrid.Location = new System.Drawing.Point(8, 7);
            this.accSummaryGrid.Margin = new System.Windows.Forms.Padding(4);
            this.accSummaryGrid.Name = "accSummaryGrid";
            this.accSummaryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accSummaryGrid.Size = new System.Drawing.Size(815, 475);
            this.accSummaryGrid.TabIndex = 0;
            // 
            // tag
            // 
            this.tag.HeaderText = "Tag";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            this.tag.Width = 150;
            // 
            // value
            // 
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Width = 150;
            // 
            // currency
            // 
            this.currency.HeaderText = "Currency";
            this.currency.Name = "currency";
            this.currency.ReadOnly = true;
            this.currency.Width = 150;
            // 
            // accountSummaryAccount
            // 
            this.accountSummaryAccount.HeaderText = "Account";
            this.accountSummaryAccount.Name = "accountSummaryAccount";
            this.accountSummaryAccount.ReadOnly = true;
            // 
            // accUpdatesTab
            // 
            this.accUpdatesTab.BackColor = System.Drawing.Color.LightGray;
            this.accUpdatesTab.Controls.Add(this.accUpdatesSubscribedAccount);
            this.accUpdatesTab.Controls.Add(this.accUpdatesAccountLabel);
            this.accUpdatesTab.Controls.Add(this.accUpdatesLastUpdateValue);
            this.accUpdatesTab.Controls.Add(this.accountPortfolioGrid);
            this.accUpdatesTab.Controls.Add(this.accountValuesGrid);
            this.accUpdatesTab.Controls.Add(this.accUpdatesSubscribe);
            this.accUpdatesTab.Controls.Add(this.lastUpdatedLabel);
            this.accUpdatesTab.Location = new System.Drawing.Point(4, 25);
            this.accUpdatesTab.Margin = new System.Windows.Forms.Padding(4);
            this.accUpdatesTab.Name = "accUpdatesTab";
            this.accUpdatesTab.Padding = new System.Windows.Forms.Padding(4);
            this.accUpdatesTab.Size = new System.Drawing.Size(1640, 537);
            this.accUpdatesTab.TabIndex = 1;
            this.accUpdatesTab.Text = "Account Updates";
            // 
            // accUpdatesSubscribedAccount
            // 
            this.accUpdatesSubscribedAccount.AutoSize = true;
            this.accUpdatesSubscribedAccount.Location = new System.Drawing.Point(191, 14);
            this.accUpdatesSubscribedAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accUpdatesSubscribedAccount.Name = "accUpdatesSubscribedAccount";
            this.accUpdatesSubscribedAccount.Size = new System.Drawing.Size(20, 17);
            this.accUpdatesSubscribedAccount.TabIndex = 6;
            this.accUpdatesSubscribedAccount.Text = "...";
            // 
            // accUpdatesAccountLabel
            // 
            this.accUpdatesAccountLabel.AutoSize = true;
            this.accUpdatesAccountLabel.Location = new System.Drawing.Point(116, 14);
            this.accUpdatesAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accUpdatesAccountLabel.Name = "accUpdatesAccountLabel";
            this.accUpdatesAccountLabel.Size = new System.Drawing.Size(63, 17);
            this.accUpdatesAccountLabel.TabIndex = 5;
            this.accUpdatesAccountLabel.Text = "Account:";
            // 
            // accUpdatesLastUpdateValue
            // 
            this.accUpdatesLastUpdateValue.AutoSize = true;
            this.accUpdatesLastUpdateValue.Location = new System.Drawing.Point(404, 14);
            this.accUpdatesLastUpdateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accUpdatesLastUpdateValue.Name = "accUpdatesLastUpdateValue";
            this.accUpdatesLastUpdateValue.Size = new System.Drawing.Size(20, 17);
            this.accUpdatesLastUpdateValue.TabIndex = 4;
            this.accUpdatesLastUpdateValue.Text = "...";
            // 
            // accountPortfolioGrid
            // 
            this.accountPortfolioGrid.AllowUserToAddRows = false;
            this.accountPortfolioGrid.AllowUserToDeleteRows = false;
            this.accountPortfolioGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountPortfolioGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.updatePortfolioContract,
            this.updatePortfolioPosition,
            this.updatePortfolioMarketPrice,
            this.updatePortfolioMarketValue,
            this.updatePortfolioAvgCost,
            this.updatePortfolioUnrealisedPnL,
            this.updatePortfolioRealisedPnL});
            this.accountPortfolioGrid.Location = new System.Drawing.Point(501, 43);
            this.accountPortfolioGrid.Margin = new System.Windows.Forms.Padding(4);
            this.accountPortfolioGrid.Name = "accountPortfolioGrid";
            this.accountPortfolioGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountPortfolioGrid.Size = new System.Drawing.Size(1100, 426);
            this.accountPortfolioGrid.TabIndex = 1;
            // 
            // updatePortfolioContract
            // 
            this.updatePortfolioContract.HeaderText = "Contract";
            this.updatePortfolioContract.Name = "updatePortfolioContract";
            this.updatePortfolioContract.ReadOnly = true;
            this.updatePortfolioContract.Width = 140;
            // 
            // updatePortfolioPosition
            // 
            this.updatePortfolioPosition.HeaderText = "Position";
            this.updatePortfolioPosition.Name = "updatePortfolioPosition";
            this.updatePortfolioPosition.ReadOnly = true;
            // 
            // updatePortfolioMarketPrice
            // 
            this.updatePortfolioMarketPrice.HeaderText = "Market Price";
            this.updatePortfolioMarketPrice.Name = "updatePortfolioMarketPrice";
            this.updatePortfolioMarketPrice.ReadOnly = true;
            // 
            // updatePortfolioMarketValue
            // 
            this.updatePortfolioMarketValue.HeaderText = "Market Value";
            this.updatePortfolioMarketValue.Name = "updatePortfolioMarketValue";
            this.updatePortfolioMarketValue.ReadOnly = true;
            // 
            // updatePortfolioAvgCost
            // 
            this.updatePortfolioAvgCost.HeaderText = "Average Cost";
            this.updatePortfolioAvgCost.Name = "updatePortfolioAvgCost";
            this.updatePortfolioAvgCost.ReadOnly = true;
            // 
            // updatePortfolioUnrealisedPnL
            // 
            this.updatePortfolioUnrealisedPnL.HeaderText = "Unrealised P&L";
            this.updatePortfolioUnrealisedPnL.Name = "updatePortfolioUnrealisedPnL";
            this.updatePortfolioUnrealisedPnL.ReadOnly = true;
            this.updatePortfolioUnrealisedPnL.Width = 120;
            // 
            // updatePortfolioRealisedPnL
            // 
            this.updatePortfolioRealisedPnL.HeaderText = "Realised P&L";
            this.updatePortfolioRealisedPnL.Name = "updatePortfolioRealisedPnL";
            this.updatePortfolioRealisedPnL.ReadOnly = true;
            this.updatePortfolioRealisedPnL.Width = 120;
            // 
            // accountValuesGrid
            // 
            this.accountValuesGrid.AllowUserToAddRows = false;
            this.accountValuesGrid.AllowUserToDeleteRows = false;
            this.accountValuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountValuesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accUpdatesKey,
            this.accUpdatesValue,
            this.accUpdatesCurrency});
            this.accountValuesGrid.Location = new System.Drawing.Point(8, 43);
            this.accountValuesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.accountValuesGrid.Name = "accountValuesGrid";
            this.accountValuesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountValuesGrid.Size = new System.Drawing.Size(485, 426);
            this.accountValuesGrid.TabIndex = 0;
            // 
            // accUpdatesKey
            // 
            this.accUpdatesKey.HeaderText = "Key";
            this.accUpdatesKey.Name = "accUpdatesKey";
            this.accUpdatesKey.ReadOnly = true;
            this.accUpdatesKey.Width = 150;
            // 
            // accUpdatesValue
            // 
            this.accUpdatesValue.HeaderText = "Value";
            this.accUpdatesValue.Name = "accUpdatesValue";
            this.accUpdatesValue.ReadOnly = true;
            this.accUpdatesValue.Width = 90;
            // 
            // accUpdatesCurrency
            // 
            this.accUpdatesCurrency.HeaderText = "Currency";
            this.accUpdatesCurrency.Name = "accUpdatesCurrency";
            this.accUpdatesCurrency.ReadOnly = true;
            this.accUpdatesCurrency.Width = 60;
            // 
            // accUpdatesSubscribe
            // 
            this.accUpdatesSubscribe.Location = new System.Drawing.Point(8, 7);
            this.accUpdatesSubscribe.Margin = new System.Windows.Forms.Padding(4);
            this.accUpdatesSubscribe.Name = "accUpdatesSubscribe";
            this.accUpdatesSubscribe.Size = new System.Drawing.Size(100, 28);
            this.accUpdatesSubscribe.TabIndex = 2;
            this.accUpdatesSubscribe.Text = "Subscribe";
            this.accUpdatesSubscribe.UseVisualStyleBackColor = true;
            this.accUpdatesSubscribe.Click += new System.EventHandler(this.accUpdatesSubscribe_Click);
            // 
            // lastUpdatedLabel
            // 
            this.lastUpdatedLabel.AutoSize = true;
            this.lastUpdatedLabel.Location = new System.Drawing.Point(300, 14);
            this.lastUpdatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastUpdatedLabel.Name = "lastUpdatedLabel";
            this.lastUpdatedLabel.Size = new System.Drawing.Size(95, 17);
            this.lastUpdatedLabel.TabIndex = 3;
            this.lastUpdatedLabel.Text = "Last updated:";
            // 
            // positionsTab
            // 
            this.positionsTab.BackColor = System.Drawing.Color.LightGray;
            this.positionsTab.Controls.Add(this.positionRequest);
            this.positionsTab.Controls.Add(this.positionsGrid);
            this.positionsTab.Location = new System.Drawing.Point(4, 25);
            this.positionsTab.Margin = new System.Windows.Forms.Padding(4);
            this.positionsTab.Name = "positionsTab";
            this.positionsTab.Padding = new System.Windows.Forms.Padding(4);
            this.positionsTab.Size = new System.Drawing.Size(1640, 537);
            this.positionsTab.TabIndex = 2;
            this.positionsTab.Text = "Positions (all accounts)";
            // 
            // positionRequest
            // 
            this.positionRequest.Location = new System.Drawing.Point(676, 7);
            this.positionRequest.Margin = new System.Windows.Forms.Padding(4);
            this.positionRequest.Name = "positionRequest";
            this.positionRequest.Size = new System.Drawing.Size(100, 28);
            this.positionRequest.TabIndex = 1;
            this.positionRequest.Text = "Request";
            this.positionRequest.UseVisualStyleBackColor = true;
            this.positionRequest.Click += new System.EventHandler(this.positionRequest_Click);
            // 
            // positionsGrid
            // 
            this.positionsGrid.AllowUserToAddRows = false;
            this.positionsGrid.AllowUserToDeleteRows = false;
            this.positionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionContract,
            this.positionAccount,
            this.positionPosition,
            this.positionAvgCost});
            this.positionsGrid.Location = new System.Drawing.Point(8, 7);
            this.positionsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.positionsGrid.Name = "positionsGrid";
            this.positionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.positionsGrid.Size = new System.Drawing.Size(660, 450);
            this.positionsGrid.TabIndex = 0;
            // 
            // positionContract
            // 
            this.positionContract.HeaderText = "Contract";
            this.positionContract.Name = "positionContract";
            this.positionContract.ReadOnly = true;
            this.positionContract.Width = 150;
            // 
            // positionAccount
            // 
            this.positionAccount.HeaderText = "Account";
            this.positionAccount.Name = "positionAccount";
            this.positionAccount.ReadOnly = true;
            // 
            // positionPosition
            // 
            this.positionPosition.HeaderText = "Position";
            this.positionPosition.Name = "positionPosition";
            this.positionPosition.ReadOnly = true;
            this.positionPosition.Width = 80;
            // 
            // positionAvgCost
            // 
            this.positionAvgCost.HeaderText = "Average Cost";
            this.positionAvgCost.Name = "positionAvgCost";
            this.positionAvgCost.ReadOnly = true;
            // 
            // accountSelectorLabel
            // 
            this.accountSelectorLabel.AutoSize = true;
            this.accountSelectorLabel.Location = new System.Drawing.Point(11, 4);
            this.accountSelectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountSelectorLabel.Name = "accountSelectorLabel";
            this.accountSelectorLabel.Size = new System.Drawing.Size(110, 17);
            this.accountSelectorLabel.TabIndex = 1;
            this.accountSelectorLabel.Text = "Choose account";
            // 
            // accountSelector
            // 
            this.accountSelector.FormattingEnabled = true;
            this.accountSelector.Location = new System.Drawing.Point(132, 4);
            this.accountSelector.Margin = new System.Windows.Forms.Padding(4);
            this.accountSelector.Name = "accountSelector";
            this.accountSelector.Size = new System.Drawing.Size(160, 24);
            this.accountSelector.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.contractFundamentalsGroupBox);
            this.tabPage1.Controls.Add(this.contractDetailsGroupBox);
            this.tabPage1.Controls.Add(this.contractInfoTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1667, 656);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Contract Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.queryOptionChain);
            this.groupBox3.Controls.Add(this.optionChainUseSnapshot);
            this.groupBox3.Controls.Add(this.optionChainOptionExchangeLabel);
            this.groupBox3.Controls.Add(this.optionChainExchange);
            this.groupBox3.Location = new System.Drawing.Point(531, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(272, 117);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options chain";
            this.informationTooltip.SetToolTip(this.groupBox3, "Requests all options available for the description provided on the Contract\'s det" +
        "ails section.");
            // 
            // queryOptionChain
            // 
            this.queryOptionChain.Location = new System.Drawing.Point(160, 81);
            this.queryOptionChain.Margin = new System.Windows.Forms.Padding(4);
            this.queryOptionChain.Name = "queryOptionChain";
            this.queryOptionChain.Size = new System.Drawing.Size(100, 28);
            this.queryOptionChain.TabIndex = 44;
            this.queryOptionChain.Text = "Request";
            this.informationTooltip.SetToolTip(this.queryOptionChain, "Requests all options available for the underlying provided on the Contract\'s deta" +
        "ils section.");
            this.queryOptionChain.UseVisualStyleBackColor = true;
            this.queryOptionChain.Click += new System.EventHandler(this.queryOptionChain_Click);
            // 
            // optionChainUseSnapshot
            // 
            this.optionChainUseSnapshot.AutoSize = true;
            this.optionChainUseSnapshot.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optionChainUseSnapshot.Location = new System.Drawing.Point(49, 52);
            this.optionChainUseSnapshot.Margin = new System.Windows.Forms.Padding(4);
            this.optionChainUseSnapshot.Name = "optionChainUseSnapshot";
            this.optionChainUseSnapshot.Size = new System.Drawing.Size(149, 21);
            this.optionChainUseSnapshot.TabIndex = 38;
            this.optionChainUseSnapshot.Text = "Use snapshot data";
            this.optionChainUseSnapshot.UseVisualStyleBackColor = true;
            // 
            // optionChainOptionExchangeLabel
            // 
            this.optionChainOptionExchangeLabel.AutoSize = true;
            this.optionChainOptionExchangeLabel.Location = new System.Drawing.Point(45, 23);
            this.optionChainOptionExchangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optionChainOptionExchangeLabel.Name = "optionChainOptionExchangeLabel";
            this.optionChainOptionExchangeLabel.Size = new System.Drawing.Size(70, 17);
            this.optionChainOptionExchangeLabel.TabIndex = 36;
            this.optionChainOptionExchangeLabel.Text = "Exchange";
            // 
            // optionChainExchange
            // 
            this.optionChainExchange.Location = new System.Drawing.Point(127, 20);
            this.optionChainExchange.Margin = new System.Windows.Forms.Padding(4);
            this.optionChainExchange.Name = "optionChainExchange";
            this.optionChainExchange.Size = new System.Drawing.Size(132, 22);
            this.optionChainExchange.TabIndex = 37;
            this.optionChainExchange.Text = "SMART";
            // 
            // contractFundamentalsGroupBox
            // 
            this.contractFundamentalsGroupBox.Controls.Add(this.fundamentalsQueryButton);
            this.contractFundamentalsGroupBox.Controls.Add(this.fundamentalsReportTypeLabel);
            this.contractFundamentalsGroupBox.Controls.Add(this.fundamentalsReportType);
            this.contractFundamentalsGroupBox.Location = new System.Drawing.Point(531, 132);
            this.contractFundamentalsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.contractFundamentalsGroupBox.Name = "contractFundamentalsGroupBox";
            this.contractFundamentalsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.contractFundamentalsGroupBox.Size = new System.Drawing.Size(272, 89);
            this.contractFundamentalsGroupBox.TabIndex = 36;
            this.contractFundamentalsGroupBox.TabStop = false;
            this.contractFundamentalsGroupBox.Text = "Fundamentals";
            // 
            // fundamentalsQueryButton
            // 
            this.fundamentalsQueryButton.Location = new System.Drawing.Point(160, 53);
            this.fundamentalsQueryButton.Margin = new System.Windows.Forms.Padding(4);
            this.fundamentalsQueryButton.Name = "fundamentalsQueryButton";
            this.fundamentalsQueryButton.Size = new System.Drawing.Size(100, 28);
            this.fundamentalsQueryButton.TabIndex = 36;
            this.fundamentalsQueryButton.Text = "Query";
            this.informationTooltip.SetToolTip(this.fundamentalsQueryButton, "Requests Reuter\'s Fundamentals selected report for the given contract.");
            this.fundamentalsQueryButton.UseVisualStyleBackColor = true;
            this.fundamentalsQueryButton.Click += new System.EventHandler(this.fundamentalsQueryButton_Click);
            // 
            // fundamentalsReportTypeLabel
            // 
            this.fundamentalsReportTypeLabel.AutoSize = true;
            this.fundamentalsReportTypeLabel.Location = new System.Drawing.Point(8, 23);
            this.fundamentalsReportTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fundamentalsReportTypeLabel.Name = "fundamentalsReportTypeLabel";
            this.fundamentalsReportTypeLabel.Size = new System.Drawing.Size(82, 17);
            this.fundamentalsReportTypeLabel.TabIndex = 35;
            this.fundamentalsReportTypeLabel.Text = "Report type";
            // 
            // fundamentalsReportType
            // 
            this.fundamentalsReportType.FormattingEnabled = true;
            this.fundamentalsReportType.Location = new System.Drawing.Point(99, 20);
            this.fundamentalsReportType.Margin = new System.Windows.Forms.Padding(4);
            this.fundamentalsReportType.Name = "fundamentalsReportType";
            this.fundamentalsReportType.Size = new System.Drawing.Size(160, 24);
            this.fundamentalsReportType.TabIndex = 34;
            // 
            // contractDetailsGroupBox
            // 
            this.contractDetailsGroupBox.Controls.Add(this.searchContractDetails);
            this.contractDetailsGroupBox.Controls.Add(this.conDetSymbolLabel);
            this.contractDetailsGroupBox.Controls.Add(this.conDetRightLabel);
            this.contractDetailsGroupBox.Controls.Add(this.conDetStrikeLabel);
            this.contractDetailsGroupBox.Controls.Add(this.conDetRight);
            this.contractDetailsGroupBox.Controls.Add(this.conDetExpiryLabel);
            this.contractDetailsGroupBox.Controls.Add(this.conDetSecType);
            this.contractDetailsGroupBox.Controls.Add(this.conDetMultiplierLabel);
            this.contractDetailsGroupBox.Controls.Add(this.conDetSecTypeLabel);
            this.contractDetailsGroupBox.Controls.Add(this.conDetLocalSymbolLabel);
            this.contractDetailsGroupBox.Controls.Add(this.conDetExchangeLabel);
            this.contractDetailsGroupBox.Controls.Add(this.conDetExchange);
            this.contractDetailsGroupBox.Controls.Add(this.conDetLocalSymbol);
            this.contractDetailsGroupBox.Controls.Add(this.conDetMultiplier);
            this.contractDetailsGroupBox.Controls.Add(this.conDetCurrencyLabel);
            this.contractDetailsGroupBox.Controls.Add(this.conDetCurrency);
            this.contractDetailsGroupBox.Controls.Add(this.conDetExpiry);
            this.contractDetailsGroupBox.Controls.Add(this.conDetStrike);
            this.contractDetailsGroupBox.Controls.Add(this.conDetSymbol);
            this.contractDetailsGroupBox.Location = new System.Drawing.Point(11, 7);
            this.contractDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.contractDetailsGroupBox.Name = "contractDetailsGroupBox";
            this.contractDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.contractDetailsGroupBox.Size = new System.Drawing.Size(512, 213);
            this.contractDetailsGroupBox.TabIndex = 33;
            this.contractDetailsGroupBox.TabStop = false;
            this.contractDetailsGroupBox.Text = "Contract details";
            // 
            // searchContractDetails
            // 
            this.searchContractDetails.Location = new System.Drawing.Point(399, 177);
            this.searchContractDetails.Margin = new System.Windows.Forms.Padding(4);
            this.searchContractDetails.Name = "searchContractDetails";
            this.searchContractDetails.Size = new System.Drawing.Size(100, 28);
            this.searchContractDetails.TabIndex = 34;
            this.searchContractDetails.Text = "Search";
            this.informationTooltip.SetToolTip(this.searchContractDetails, "Looks for all contracts matching the description provided.");
            this.searchContractDetails.UseVisualStyleBackColor = true;
            this.searchContractDetails.Click += new System.EventHandler(this.searchContractDetails_Click);
            // 
            // conDetSymbolLabel
            // 
            this.conDetSymbolLabel.AutoSize = true;
            this.conDetSymbolLabel.Location = new System.Drawing.Point(27, 32);
            this.conDetSymbolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conDetSymbolLabel.Name = "conDetSymbolLabel";
            this.conDetSymbolLabel.Size = new System.Drawing.Size(54, 17);
            this.conDetSymbolLabel.TabIndex = 17;
            this.conDetSymbolLabel.Text = "Symbol";
            // 
            // conDetRightLabel
            // 
            this.conDetRightLabel.AutoSize = true;
            this.conDetRightLabel.Location = new System.Drawing.Point(21, 156);
            this.conDetRightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conDetRightLabel.Name = "conDetRightLabel";
            this.conDetRightLabel.Size = new System.Drawing.Size(56, 17);
            this.conDetRightLabel.TabIndex = 59;
            this.conDetRightLabel.Text = "Put/Call";
            // 
            // conDetStrikeLabel
            // 
            this.conDetStrikeLabel.AutoSize = true;
            this.conDetStrikeLabel.Location = new System.Drawing.Point(312, 92);
            this.conDetStrikeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conDetStrikeLabel.Name = "conDetStrikeLabel";
            this.conDetStrikeLabel.Size = new System.Drawing.Size(44, 17);
            this.conDetStrikeLabel.TabIndex = 21;
            this.conDetStrikeLabel.Text = "Strike";
            // 
            // conDetRight
            // 
            this.conDetRight.FormattingEnabled = true;
            this.conDetRight.Location = new System.Drawing.Point(115, 156);
            this.conDetRight.Margin = new System.Windows.Forms.Padding(4);
            this.conDetRight.Name = "conDetRight";
            this.conDetRight.Size = new System.Drawing.Size(132, 24);
            this.conDetRight.TabIndex = 58;
            // 
            // conDetExpiryLabel
            // 
            this.conDetExpiryLabel.AutoSize = true;
            this.conDetExpiryLabel.Location = new System.Drawing.Point(311, 59);
            this.conDetExpiryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conDetExpiryLabel.Name = "conDetExpiryLabel";
            this.conDetExpiryLabel.Size = new System.Drawing.Size(46, 17);
            this.conDetExpiryLabel.TabIndex = 20;
            this.conDetExpiryLabel.Text = "Expiry";
            // 
            // conDetSecType
            // 
            this.conDetSecType.FormattingEnabled = true;
            this.conDetSecType.Items.AddRange(new object[] {
            "STK",
            "OPT",
            "FUT",
            "CASH",
            "BOND",
            "CFD",
            "FOP",
            "WAR",
            "IOPT",
            "FWD",
            "BAG",
            "IND",
            "BILL",
            "FUND",
            "FIXED",
            "SLB",
            "NEWS",
            "CMDTY",
            "BSK",
            "ICU",
            "ICS"});
            this.conDetSecType.Location = new System.Drawing.Point(115, 59);
            this.conDetSecType.Margin = new System.Windows.Forms.Padding(4);
            this.conDetSecType.Name = "conDetSecType";
            this.conDetSecType.Size = new System.Drawing.Size(132, 24);
            this.conDetSecType.TabIndex = 18;
            this.conDetSecType.Text = "STK";
            // 
            // conDetMultiplierLabel
            // 
            this.conDetMultiplierLabel.AutoSize = true;
            this.conDetMultiplierLabel.Location = new System.Drawing.Point(293, 32);
            this.conDetMultiplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conDetMultiplierLabel.Name = "conDetMultiplierLabel";
            this.conDetMultiplierLabel.Size = new System.Drawing.Size(64, 17);
            this.conDetMultiplierLabel.TabIndex = 22;
            this.conDetMultiplierLabel.Text = "Multiplier";
            // 
            // conDetSecTypeLabel
            // 
            this.conDetSecTypeLabel.AutoSize = true;
            this.conDetSecTypeLabel.Location = new System.Drawing.Point(15, 59);
            this.conDetSecTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conDetSecTypeLabel.Name = "conDetSecTypeLabel";
            this.conDetSecTypeLabel.Size = new System.Drawing.Size(64, 17);
            this.conDetSecTypeLabel.TabIndex = 19;
            this.conDetSecTypeLabel.Text = "SecType";
            // 
            // conDetLocalSymbolLabel
            // 
            this.conDetLocalSymbolLabel.AutoSize = true;
            this.conDetLocalSymbolLabel.Location = new System.Drawing.Point(264, 124);
            this.conDetLocalSymbolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conDetLocalSymbolLabel.Name = "conDetLocalSymbolLabel";
            this.conDetLocalSymbolLabel.Size = new System.Drawing.Size(92, 17);
            this.conDetLocalSymbolLabel.TabIndex = 25;
            this.conDetLocalSymbolLabel.Text = "Local Symbol";
            // 
            // conDetExchangeLabel
            // 
            this.conDetExchangeLabel.AutoSize = true;
            this.conDetExchangeLabel.Location = new System.Drawing.Point(8, 124);
            this.conDetExchangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conDetExchangeLabel.Name = "conDetExchangeLabel";
            this.conDetExchangeLabel.Size = new System.Drawing.Size(70, 17);
            this.conDetExchangeLabel.TabIndex = 23;
            this.conDetExchangeLabel.Text = "Exchange";
            // 
            // conDetExchange
            // 
            this.conDetExchange.Location = new System.Drawing.Point(115, 124);
            this.conDetExchange.Margin = new System.Windows.Forms.Padding(4);
            this.conDetExchange.Name = "conDetExchange";
            this.conDetExchange.Size = new System.Drawing.Size(132, 22);
            this.conDetExchange.TabIndex = 27;
            this.conDetExchange.Text = "SMART";
            // 
            // conDetLocalSymbol
            // 
            this.conDetLocalSymbol.Location = new System.Drawing.Point(365, 124);
            this.conDetLocalSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.conDetLocalSymbol.Name = "conDetLocalSymbol";
            this.conDetLocalSymbol.Size = new System.Drawing.Size(132, 22);
            this.conDetLocalSymbol.TabIndex = 31;
            // 
            // conDetMultiplier
            // 
            this.conDetMultiplier.Location = new System.Drawing.Point(365, 32);
            this.conDetMultiplier.Margin = new System.Windows.Forms.Padding(4);
            this.conDetMultiplier.Name = "conDetMultiplier";
            this.conDetMultiplier.Size = new System.Drawing.Size(132, 22);
            this.conDetMultiplier.TabIndex = 28;
            // 
            // conDetCurrencyLabel
            // 
            this.conDetCurrencyLabel.AutoSize = true;
            this.conDetCurrencyLabel.Location = new System.Drawing.Point(16, 92);
            this.conDetCurrencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conDetCurrencyLabel.Name = "conDetCurrencyLabel";
            this.conDetCurrencyLabel.Size = new System.Drawing.Size(65, 17);
            this.conDetCurrencyLabel.TabIndex = 24;
            this.conDetCurrencyLabel.Text = "Currency";
            // 
            // conDetCurrency
            // 
            this.conDetCurrency.Location = new System.Drawing.Point(115, 92);
            this.conDetCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.conDetCurrency.Name = "conDetCurrency";
            this.conDetCurrency.Size = new System.Drawing.Size(132, 22);
            this.conDetCurrency.TabIndex = 26;
            this.conDetCurrency.Text = "USD";
            // 
            // conDetExpiry
            // 
            this.conDetExpiry.Location = new System.Drawing.Point(365, 60);
            this.conDetExpiry.Margin = new System.Windows.Forms.Padding(4);
            this.conDetExpiry.Name = "conDetExpiry";
            this.conDetExpiry.Size = new System.Drawing.Size(132, 22);
            this.conDetExpiry.TabIndex = 30;
            // 
            // conDetStrike
            // 
            this.conDetStrike.Location = new System.Drawing.Point(365, 92);
            this.conDetStrike.Margin = new System.Windows.Forms.Padding(4);
            this.conDetStrike.Name = "conDetStrike";
            this.conDetStrike.Size = new System.Drawing.Size(132, 22);
            this.conDetStrike.TabIndex = 29;
            this.conDetStrike.Text = "10";
            // 
            // conDetSymbol
            // 
            this.conDetSymbol.Location = new System.Drawing.Point(115, 28);
            this.conDetSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.conDetSymbol.Name = "conDetSymbol";
            this.conDetSymbol.Size = new System.Drawing.Size(132, 22);
            this.conDetSymbol.TabIndex = 16;
            this.conDetSymbol.Text = "IBKR";
            // 
            // contractInfoTab
            // 
            this.contractInfoTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contractInfoTab.Controls.Add(this.contractDetailsPage);
            this.contractInfoTab.Controls.Add(this.fundamentalsPage);
            this.contractInfoTab.Controls.Add(this.optionChainPage);
            this.contractInfoTab.Location = new System.Drawing.Point(8, 228);
            this.contractInfoTab.Margin = new System.Windows.Forms.Padding(4);
            this.contractInfoTab.Name = "contractInfoTab";
            this.contractInfoTab.SelectedIndex = 0;
            this.contractInfoTab.Size = new System.Drawing.Size(1648, 375);
            this.contractInfoTab.TabIndex = 32;
            // 
            // contractDetailsPage
            // 
            this.contractDetailsPage.BackColor = System.Drawing.Color.LightGray;
            this.contractDetailsPage.Controls.Add(this.contractDetailsGrid);
            this.contractDetailsPage.Location = new System.Drawing.Point(4, 25);
            this.contractDetailsPage.Margin = new System.Windows.Forms.Padding(4);
            this.contractDetailsPage.Name = "contractDetailsPage";
            this.contractDetailsPage.Padding = new System.Windows.Forms.Padding(4);
            this.contractDetailsPage.Size = new System.Drawing.Size(1640, 346);
            this.contractDetailsPage.TabIndex = 0;
            this.contractDetailsPage.Text = "Contract Details";
            // 
            // contractDetailsGrid
            // 
            this.contractDetailsGrid.AllowUserToAddRows = false;
            this.contractDetailsGrid.AllowUserToDeleteRows = false;
            this.contractDetailsGrid.AllowUserToOrderColumns = true;
            this.contractDetailsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contractDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractDetailsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conResSymbol,
            this.conResLocalSymbol,
            this.conResSecType,
            this.conResCurrency,
            this.conResExchange,
            this.conResPrimaryExch,
            this.conResExpiry,
            this.conResMultiplier,
            this.conResStrike,
            this.conResRight,
            this.conResConId});
            this.contractDetailsGrid.Location = new System.Drawing.Point(8, 7);
            this.contractDetailsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.contractDetailsGrid.Name = "contractDetailsGrid";
            this.contractDetailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contractDetailsGrid.Size = new System.Drawing.Size(1621, 325);
            this.contractDetailsGrid.TabIndex = 0;
            // 
            // conResSymbol
            // 
            this.conResSymbol.HeaderText = "Symbol";
            this.conResSymbol.Name = "conResSymbol";
            this.conResSymbol.ReadOnly = true;
            // 
            // conResLocalSymbol
            // 
            this.conResLocalSymbol.HeaderText = "Local Symbol";
            this.conResLocalSymbol.Name = "conResLocalSymbol";
            this.conResLocalSymbol.ReadOnly = true;
            // 
            // conResSecType
            // 
            this.conResSecType.HeaderText = "Type";
            this.conResSecType.Name = "conResSecType";
            this.conResSecType.ReadOnly = true;
            // 
            // conResCurrency
            // 
            this.conResCurrency.HeaderText = "Currency";
            this.conResCurrency.Name = "conResCurrency";
            this.conResCurrency.ReadOnly = true;
            // 
            // conResExchange
            // 
            this.conResExchange.HeaderText = "Exchange";
            this.conResExchange.Name = "conResExchange";
            this.conResExchange.ReadOnly = true;
            // 
            // conResPrimaryExch
            // 
            this.conResPrimaryExch.HeaderText = "Primary Exch.";
            this.conResPrimaryExch.Name = "conResPrimaryExch";
            this.conResPrimaryExch.ReadOnly = true;
            // 
            // conResExpiry
            // 
            this.conResExpiry.HeaderText = "Expiry";
            this.conResExpiry.Name = "conResExpiry";
            this.conResExpiry.ReadOnly = true;
            // 
            // conResMultiplier
            // 
            this.conResMultiplier.HeaderText = "Multiplier";
            this.conResMultiplier.Name = "conResMultiplier";
            this.conResMultiplier.ReadOnly = true;
            // 
            // conResStrike
            // 
            this.conResStrike.HeaderText = "Strike";
            this.conResStrike.Name = "conResStrike";
            this.conResStrike.ReadOnly = true;
            // 
            // conResRight
            // 
            this.conResRight.HeaderText = "P/C";
            this.conResRight.Name = "conResRight";
            this.conResRight.ReadOnly = true;
            // 
            // conResConId
            // 
            this.conResConId.HeaderText = "ConId";
            this.conResConId.Name = "conResConId";
            this.conResConId.ReadOnly = true;
            // 
            // fundamentalsPage
            // 
            this.fundamentalsPage.BackColor = System.Drawing.Color.LightGray;
            this.fundamentalsPage.Controls.Add(this.fundamentalsOutput);
            this.fundamentalsPage.Location = new System.Drawing.Point(4, 25);
            this.fundamentalsPage.Margin = new System.Windows.Forms.Padding(4);
            this.fundamentalsPage.Name = "fundamentalsPage";
            this.fundamentalsPage.Padding = new System.Windows.Forms.Padding(4);
            this.fundamentalsPage.Size = new System.Drawing.Size(1640, 346);
            this.fundamentalsPage.TabIndex = 1;
            this.fundamentalsPage.Text = "Fundamentals";
            // 
            // fundamentalsOutput
            // 
            this.fundamentalsOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fundamentalsOutput.Location = new System.Drawing.Point(8, 7);
            this.fundamentalsOutput.Margin = new System.Windows.Forms.Padding(4);
            this.fundamentalsOutput.Multiline = true;
            this.fundamentalsOutput.Name = "fundamentalsOutput";
            this.fundamentalsOutput.ReadOnly = true;
            this.fundamentalsOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fundamentalsOutput.Size = new System.Drawing.Size(1620, 280);
            this.fundamentalsOutput.TabIndex = 0;
            // 
            // optionChainPage
            // 
            this.optionChainPage.BackColor = System.Drawing.Color.LightGray;
            this.optionChainPage.Controls.Add(this.optionChainCallGroup);
            this.optionChainPage.Controls.Add(this.optionChainPutGroup);
            this.optionChainPage.Location = new System.Drawing.Point(4, 25);
            this.optionChainPage.Margin = new System.Windows.Forms.Padding(4);
            this.optionChainPage.Name = "optionChainPage";
            this.optionChainPage.Padding = new System.Windows.Forms.Padding(4);
            this.optionChainPage.Size = new System.Drawing.Size(1640, 346);
            this.optionChainPage.TabIndex = 2;
            this.optionChainPage.Text = "Options chain";
            // 
            // optionChainCallGroup
            // 
            this.optionChainCallGroup.Controls.Add(this.optionChainCallGrid);
            this.optionChainCallGroup.Location = new System.Drawing.Point(8, 7);
            this.optionChainCallGroup.Margin = new System.Windows.Forms.Padding(4);
            this.optionChainCallGroup.Name = "optionChainCallGroup";
            this.optionChainCallGroup.Padding = new System.Windows.Forms.Padding(4);
            this.optionChainCallGroup.Size = new System.Drawing.Size(787, 284);
            this.optionChainCallGroup.TabIndex = 43;
            this.optionChainCallGroup.TabStop = false;
            this.optionChainCallGroup.Text = "Calls";
            // 
            // optionChainCallGrid
            // 
            this.optionChainCallGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.optionChainCallGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.callExpiry,
            this.callStrike,
            this.callBid,
            this.callAsk,
            this.callImpliedVolatility,
            this.callDelta,
            this.callGamma,
            this.callVega,
            this.callTheta});
            this.optionChainCallGrid.Location = new System.Drawing.Point(8, 23);
            this.optionChainCallGrid.Margin = new System.Windows.Forms.Padding(4);
            this.optionChainCallGrid.Name = "optionChainCallGrid";
            this.optionChainCallGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.optionChainCallGrid.Size = new System.Drawing.Size(768, 254);
            this.optionChainCallGrid.TabIndex = 40;
            // 
            // callExpiry
            // 
            this.callExpiry.HeaderText = "Expiry";
            this.callExpiry.Name = "callExpiry";
            this.callExpiry.Width = 70;
            // 
            // callStrike
            // 
            this.callStrike.HeaderText = "Strike";
            this.callStrike.Name = "callStrike";
            this.callStrike.Width = 50;
            // 
            // callBid
            // 
            this.callBid.HeaderText = "Bid";
            this.callBid.Name = "callBid";
            this.callBid.ReadOnly = true;
            this.callBid.Width = 50;
            // 
            // callAsk
            // 
            this.callAsk.HeaderText = "Ask";
            this.callAsk.Name = "callAsk";
            this.callAsk.ReadOnly = true;
            this.callAsk.Width = 50;
            // 
            // callImpliedVolatility
            // 
            this.callImpliedVolatility.HeaderText = "Imp. Vol.";
            this.callImpliedVolatility.Name = "callImpliedVolatility";
            this.callImpliedVolatility.ReadOnly = true;
            this.callImpliedVolatility.Width = 80;
            // 
            // callDelta
            // 
            this.callDelta.HeaderText = "Delta";
            this.callDelta.Name = "callDelta";
            this.callDelta.ReadOnly = true;
            this.callDelta.Width = 50;
            // 
            // callGamma
            // 
            this.callGamma.HeaderText = "Gamma";
            this.callGamma.Name = "callGamma";
            this.callGamma.ReadOnly = true;
            this.callGamma.Width = 50;
            // 
            // callVega
            // 
            this.callVega.HeaderText = "Vega";
            this.callVega.Name = "callVega";
            this.callVega.ReadOnly = true;
            this.callVega.Width = 50;
            // 
            // callTheta
            // 
            this.callTheta.HeaderText = "Theta";
            this.callTheta.Name = "callTheta";
            this.callTheta.ReadOnly = true;
            this.callTheta.Width = 50;
            // 
            // optionChainPutGroup
            // 
            this.optionChainPutGroup.Controls.Add(this.optionChainPutGrid);
            this.optionChainPutGroup.Location = new System.Drawing.Point(829, 7);
            this.optionChainPutGroup.Margin = new System.Windows.Forms.Padding(4);
            this.optionChainPutGroup.Name = "optionChainPutGroup";
            this.optionChainPutGroup.Padding = new System.Windows.Forms.Padding(4);
            this.optionChainPutGroup.Size = new System.Drawing.Size(788, 284);
            this.optionChainPutGroup.TabIndex = 42;
            this.optionChainPutGroup.TabStop = false;
            this.optionChainPutGroup.Text = "Puts";
            // 
            // optionChainPutGrid
            // 
            this.optionChainPutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.optionChainPutGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.putExpiry,
            this.putStrike,
            this.putBid,
            this.putAsk,
            this.putImpliedVolatility,
            this.putDelta,
            this.putGamma,
            this.putVega,
            this.putTheta});
            this.optionChainPutGrid.Location = new System.Drawing.Point(8, 23);
            this.optionChainPutGrid.Margin = new System.Windows.Forms.Padding(4);
            this.optionChainPutGrid.Name = "optionChainPutGrid";
            this.optionChainPutGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.optionChainPutGrid.Size = new System.Drawing.Size(772, 254);
            this.optionChainPutGrid.TabIndex = 41;
            // 
            // putExpiry
            // 
            this.putExpiry.HeaderText = "Expiry";
            this.putExpiry.Name = "putExpiry";
            this.putExpiry.Width = 70;
            // 
            // putStrike
            // 
            this.putStrike.HeaderText = "Strike";
            this.putStrike.Name = "putStrike";
            this.putStrike.Width = 50;
            // 
            // putBid
            // 
            this.putBid.HeaderText = "Bid";
            this.putBid.Name = "putBid";
            this.putBid.ReadOnly = true;
            this.putBid.Width = 50;
            // 
            // putAsk
            // 
            this.putAsk.HeaderText = "Ask";
            this.putAsk.Name = "putAsk";
            this.putAsk.ReadOnly = true;
            this.putAsk.Width = 50;
            // 
            // putImpliedVolatility
            // 
            this.putImpliedVolatility.HeaderText = "Imp. Vol.";
            this.putImpliedVolatility.Name = "putImpliedVolatility";
            this.putImpliedVolatility.ReadOnly = true;
            this.putImpliedVolatility.Width = 80;
            // 
            // putDelta
            // 
            this.putDelta.HeaderText = "Delta";
            this.putDelta.Name = "putDelta";
            this.putDelta.ReadOnly = true;
            this.putDelta.Width = 50;
            // 
            // putGamma
            // 
            this.putGamma.HeaderText = "Gamma";
            this.putGamma.Name = "putGamma";
            this.putGamma.ReadOnly = true;
            this.putGamma.Width = 50;
            // 
            // putVega
            // 
            this.putVega.HeaderText = "Vega";
            this.putVega.Name = "putVega";
            this.putVega.ReadOnly = true;
            this.putVega.Width = 50;
            // 
            // putTheta
            // 
            this.putTheta.HeaderText = "Theta";
            this.putTheta.Name = "putTheta";
            this.putTheta.ReadOnly = true;
            this.putTheta.Width = 50;
            // 
            // advisorTab
            // 
            this.advisorTab.BackColor = System.Drawing.Color.LightGray;
            this.advisorTab.Controls.Add(this.advisorProfilesBox);
            this.advisorTab.Controls.Add(this.advisorGroupsBox);
            this.advisorTab.Controls.Add(this.advisorAliasesBox);
            this.advisorTab.Location = new System.Drawing.Point(4, 25);
            this.advisorTab.Margin = new System.Windows.Forms.Padding(4);
            this.advisorTab.Name = "advisorTab";
            this.advisorTab.Padding = new System.Windows.Forms.Padding(4);
            this.advisorTab.Size = new System.Drawing.Size(1667, 656);
            this.advisorTab.TabIndex = 5;
            this.advisorTab.Text = "Financial Advisor";
            // 
            // advisorProfilesBox
            // 
            this.advisorProfilesBox.Controls.Add(this.saveProfiles);
            this.advisorProfilesBox.Controls.Add(this.loadProfiles);
            this.advisorProfilesBox.Controls.Add(this.advisorProfilesGrid);
            this.advisorProfilesBox.Location = new System.Drawing.Point(488, 282);
            this.advisorProfilesBox.Margin = new System.Windows.Forms.Padding(4);
            this.advisorProfilesBox.Name = "advisorProfilesBox";
            this.advisorProfilesBox.Padding = new System.Windows.Forms.Padding(4);
            this.advisorProfilesBox.Size = new System.Drawing.Size(1032, 290);
            this.advisorProfilesBox.TabIndex = 2;
            this.advisorProfilesBox.TabStop = false;
            this.advisorProfilesBox.Text = "Profiles";
            // 
            // saveProfiles
            // 
            this.saveProfiles.Location = new System.Drawing.Point(116, 23);
            this.saveProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.saveProfiles.Name = "saveProfiles";
            this.saveProfiles.Size = new System.Drawing.Size(100, 28);
            this.saveProfiles.TabIndex = 3;
            this.saveProfiles.Text = "Save";
            this.saveProfiles.UseVisualStyleBackColor = true;
            this.saveProfiles.Click += new System.EventHandler(this.saveProfiles_Click);
            // 
            // loadProfiles
            // 
            this.loadProfiles.Location = new System.Drawing.Point(8, 23);
            this.loadProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.loadProfiles.Name = "loadProfiles";
            this.loadProfiles.Size = new System.Drawing.Size(100, 28);
            this.loadProfiles.TabIndex = 2;
            this.loadProfiles.Text = "Load";
            this.loadProfiles.UseVisualStyleBackColor = true;
            this.loadProfiles.Click += new System.EventHandler(this.loadProfiles_Click);
            // 
            // advisorProfilesGrid
            // 
            this.advisorProfilesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advisorProfilesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profileName,
            this.profileType,
            this.profileAllocations});
            this.advisorProfilesGrid.Location = new System.Drawing.Point(8, 59);
            this.advisorProfilesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.advisorProfilesGrid.Name = "advisorProfilesGrid";
            this.advisorProfilesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advisorProfilesGrid.Size = new System.Drawing.Size(1012, 224);
            this.advisorProfilesGrid.TabIndex = 1;
            // 
            // profileName
            // 
            this.profileName.HeaderText = "Name";
            this.profileName.Name = "profileName";
            this.profileName.Width = 150;
            // 
            // profileType
            // 
            this.profileType.HeaderText = "Type";
            this.profileType.Name = "profileType";
            this.profileType.Width = 150;
            // 
            // profileAllocations
            // 
            this.profileAllocations.HeaderText = "Allocations";
            this.profileAllocations.Name = "profileAllocations";
            this.profileAllocations.Width = 400;
            // 
            // advisorGroupsBox
            // 
            this.advisorGroupsBox.Controls.Add(this.saveGroups);
            this.advisorGroupsBox.Controls.Add(this.loadGroups);
            this.advisorGroupsBox.Controls.Add(this.advisorGroupsGrid);
            this.advisorGroupsBox.Location = new System.Drawing.Point(488, 7);
            this.advisorGroupsBox.Margin = new System.Windows.Forms.Padding(4);
            this.advisorGroupsBox.Name = "advisorGroupsBox";
            this.advisorGroupsBox.Padding = new System.Windows.Forms.Padding(4);
            this.advisorGroupsBox.Size = new System.Drawing.Size(1032, 267);
            this.advisorGroupsBox.TabIndex = 1;
            this.advisorGroupsBox.TabStop = false;
            this.advisorGroupsBox.Text = "Groups";
            // 
            // saveGroups
            // 
            this.saveGroups.Location = new System.Drawing.Point(116, 23);
            this.saveGroups.Margin = new System.Windows.Forms.Padding(4);
            this.saveGroups.Name = "saveGroups";
            this.saveGroups.Size = new System.Drawing.Size(100, 28);
            this.saveGroups.TabIndex = 2;
            this.saveGroups.Text = "Save";
            this.saveGroups.UseVisualStyleBackColor = true;
            this.saveGroups.Click += new System.EventHandler(this.saveGroups_Click);
            // 
            // loadGroups
            // 
            this.loadGroups.Location = new System.Drawing.Point(8, 23);
            this.loadGroups.Margin = new System.Windows.Forms.Padding(4);
            this.loadGroups.Name = "loadGroups";
            this.loadGroups.Size = new System.Drawing.Size(100, 28);
            this.loadGroups.TabIndex = 1;
            this.loadGroups.Text = "Load";
            this.loadGroups.UseVisualStyleBackColor = true;
            this.loadGroups.Click += new System.EventHandler(this.loadGroups_Click);
            // 
            // advisorGroupsGrid
            // 
            this.advisorGroupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advisorGroupsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupName,
            this.groupMethod,
            this.groupAccounts});
            this.advisorGroupsGrid.Location = new System.Drawing.Point(8, 59);
            this.advisorGroupsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.advisorGroupsGrid.Name = "advisorGroupsGrid";
            this.advisorGroupsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advisorGroupsGrid.Size = new System.Drawing.Size(1012, 201);
            this.advisorGroupsGrid.TabIndex = 0;
            // 
            // groupName
            // 
            this.groupName.HeaderText = "Name";
            this.groupName.Name = "groupName";
            this.groupName.Width = 150;
            // 
            // groupMethod
            // 
            this.groupMethod.HeaderText = "Default Method";
            this.groupMethod.Name = "groupMethod";
            this.groupMethod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.groupMethod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.groupMethod.Width = 150;
            // 
            // groupAccounts
            // 
            this.groupAccounts.HeaderText = "Accounts";
            this.groupAccounts.Name = "groupAccounts";
            this.groupAccounts.Width = 400;
            // 
            // advisorAliasesBox
            // 
            this.advisorAliasesBox.Controls.Add(this.loadAliases);
            this.advisorAliasesBox.Controls.Add(this.advisorAliasesGrid);
            this.advisorAliasesBox.Location = new System.Drawing.Point(8, 7);
            this.advisorAliasesBox.Margin = new System.Windows.Forms.Padding(4);
            this.advisorAliasesBox.Name = "advisorAliasesBox";
            this.advisorAliasesBox.Padding = new System.Windows.Forms.Padding(4);
            this.advisorAliasesBox.Size = new System.Drawing.Size(472, 565);
            this.advisorAliasesBox.TabIndex = 0;
            this.advisorAliasesBox.TabStop = false;
            this.advisorAliasesBox.Text = "Aliases";
            // 
            // loadAliases
            // 
            this.loadAliases.Location = new System.Drawing.Point(8, 23);
            this.loadAliases.Margin = new System.Windows.Forms.Padding(4);
            this.loadAliases.Name = "loadAliases";
            this.loadAliases.Size = new System.Drawing.Size(100, 28);
            this.loadAliases.TabIndex = 1;
            this.loadAliases.Text = "Load";
            this.loadAliases.UseVisualStyleBackColor = true;
            this.loadAliases.Click += new System.EventHandler(this.loadAliases_Click);
            // 
            // advisorAliasesGrid
            // 
            this.advisorAliasesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advisorAliasesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.advisorAccount,
            this.advisorAlias});
            this.advisorAliasesGrid.Location = new System.Drawing.Point(8, 59);
            this.advisorAliasesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.advisorAliasesGrid.Name = "advisorAliasesGrid";
            this.advisorAliasesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advisorAliasesGrid.Size = new System.Drawing.Size(456, 498);
            this.advisorAliasesGrid.TabIndex = 0;
            // 
            // advisorAccount
            // 
            this.advisorAccount.HeaderText = "Account";
            this.advisorAccount.Name = "advisorAccount";
            this.advisorAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.advisorAccount.Width = 130;
            // 
            // advisorAlias
            // 
            this.advisorAlias.HeaderText = "Alias";
            this.advisorAlias.Name = "advisorAlias";
            this.advisorAlias.Width = 150;
            // 
            // optionsTab
            // 
            this.optionsTab.BackColor = System.Drawing.Color.LightGray;
            this.optionsTab.Controls.Add(this.optionExchange);
            this.optionsTab.Controls.Add(this.optionExchangeLabel);
            this.optionsTab.Controls.Add(this.optionsQuantityLabel);
            this.optionsTab.Controls.Add(this.optionsPositionsGroupBox);
            this.optionsTab.Controls.Add(this.optionExerciseQuan);
            this.optionsTab.Controls.Add(this.overrideOption);
            this.optionsTab.Controls.Add(this.lapseOption);
            this.optionsTab.Controls.Add(this.exerciseOption);
            this.optionsTab.Controls.Add(this.exerciseAccountLabel);
            this.optionsTab.Controls.Add(this.exerciseAccount);
            this.optionsTab.Location = new System.Drawing.Point(4, 25);
            this.optionsTab.Margin = new System.Windows.Forms.Padding(4);
            this.optionsTab.Name = "optionsTab";
            this.optionsTab.Padding = new System.Windows.Forms.Padding(4);
            this.optionsTab.Size = new System.Drawing.Size(1667, 656);
            this.optionsTab.TabIndex = 7;
            this.optionsTab.Text = "Option exercising";
            // 
            // optionExchange
            // 
            this.optionExchange.Location = new System.Drawing.Point(1388, 95);
            this.optionExchange.Margin = new System.Windows.Forms.Padding(4);
            this.optionExchange.Name = "optionExchange";
            this.optionExchange.Size = new System.Drawing.Size(132, 22);
            this.optionExchange.TabIndex = 12;
            // 
            // optionExchangeLabel
            // 
            this.optionExchangeLabel.AutoSize = true;
            this.optionExchangeLabel.Location = new System.Drawing.Point(1307, 98);
            this.optionExchangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optionExchangeLabel.Name = "optionExchangeLabel";
            this.optionExchangeLabel.Size = new System.Drawing.Size(70, 17);
            this.optionExchangeLabel.TabIndex = 11;
            this.optionExchangeLabel.Text = "Exchange";
            // 
            // optionsQuantityLabel
            // 
            this.optionsQuantityLabel.AutoSize = true;
            this.optionsQuantityLabel.Location = new System.Drawing.Point(1307, 64);
            this.optionsQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optionsQuantityLabel.Name = "optionsQuantityLabel";
            this.optionsQuantityLabel.Size = new System.Drawing.Size(61, 17);
            this.optionsQuantityLabel.TabIndex = 10;
            this.optionsQuantityLabel.Text = "Quantity";
            // 
            // optionsPositionsGroupBox
            // 
            this.optionsPositionsGroupBox.Controls.Add(this.optionPositionsGrid);
            this.optionsPositionsGroupBox.Location = new System.Drawing.Point(16, 41);
            this.optionsPositionsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.optionsPositionsGroupBox.Name = "optionsPositionsGroupBox";
            this.optionsPositionsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.optionsPositionsGroupBox.Size = new System.Drawing.Size(1283, 292);
            this.optionsPositionsGroupBox.TabIndex = 9;
            this.optionsPositionsGroupBox.TabStop = false;
            this.optionsPositionsGroupBox.Text = "Option long positions";
            // 
            // optionPositionsGrid
            // 
            this.optionPositionsGrid.AllowUserToAddRows = false;
            this.optionPositionsGrid.AllowUserToDeleteRows = false;
            this.optionPositionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.optionPositionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.optionContract,
            this.optionAccount,
            this.optionPosition,
            this.optionMarketPrice,
            this.optionMarketValue,
            this.optionAverageCost,
            this.optionUnrealisedPnL,
            this.optionRealisedPnL});
            this.optionPositionsGrid.Location = new System.Drawing.Point(13, 23);
            this.optionPositionsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.optionPositionsGrid.Name = "optionPositionsGrid";
            this.optionPositionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.optionPositionsGrid.Size = new System.Drawing.Size(1261, 255);
            this.optionPositionsGrid.TabIndex = 4;
            // 
            // optionContract
            // 
            this.optionContract.HeaderText = "Contract";
            this.optionContract.Name = "optionContract";
            this.optionContract.ReadOnly = true;
            this.optionContract.Width = 140;
            // 
            // optionAccount
            // 
            this.optionAccount.HeaderText = "Account";
            this.optionAccount.Name = "optionAccount";
            this.optionAccount.ReadOnly = true;
            // 
            // optionPosition
            // 
            this.optionPosition.HeaderText = "Position";
            this.optionPosition.Name = "optionPosition";
            this.optionPosition.ReadOnly = true;
            // 
            // optionMarketPrice
            // 
            this.optionMarketPrice.HeaderText = "Market Price";
            this.optionMarketPrice.Name = "optionMarketPrice";
            this.optionMarketPrice.ReadOnly = true;
            // 
            // optionMarketValue
            // 
            this.optionMarketValue.HeaderText = "Market Value";
            this.optionMarketValue.Name = "optionMarketValue";
            this.optionMarketValue.ReadOnly = true;
            // 
            // optionAverageCost
            // 
            this.optionAverageCost.HeaderText = "Average Cost";
            this.optionAverageCost.Name = "optionAverageCost";
            this.optionAverageCost.ReadOnly = true;
            // 
            // optionUnrealisedPnL
            // 
            this.optionUnrealisedPnL.HeaderText = "Unrealised P&L";
            this.optionUnrealisedPnL.Name = "optionUnrealisedPnL";
            this.optionUnrealisedPnL.ReadOnly = true;
            this.optionUnrealisedPnL.Width = 120;
            // 
            // optionRealisedPnL
            // 
            this.optionRealisedPnL.HeaderText = "Realised P&L";
            this.optionRealisedPnL.Name = "optionRealisedPnL";
            this.optionRealisedPnL.ReadOnly = true;
            this.optionRealisedPnL.Width = 120;
            // 
            // optionExerciseQuan
            // 
            this.optionExerciseQuan.Location = new System.Drawing.Point(1388, 64);
            this.optionExerciseQuan.Margin = new System.Windows.Forms.Padding(4);
            this.optionExerciseQuan.Name = "optionExerciseQuan";
            this.optionExerciseQuan.Size = new System.Drawing.Size(132, 22);
            this.optionExerciseQuan.TabIndex = 8;
            this.optionExerciseQuan.Text = "0";
            // 
            // overrideOption
            // 
            this.overrideOption.AutoSize = true;
            this.overrideOption.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.overrideOption.Location = new System.Drawing.Point(1433, 127);
            this.overrideOption.Margin = new System.Windows.Forms.Padding(4);
            this.overrideOption.Name = "overrideOption";
            this.overrideOption.Size = new System.Drawing.Size(85, 21);
            this.overrideOption.TabIndex = 7;
            this.overrideOption.Text = "Override";
            this.overrideOption.UseVisualStyleBackColor = true;
            // 
            // lapseOption
            // 
            this.lapseOption.Location = new System.Drawing.Point(1307, 191);
            this.lapseOption.Margin = new System.Windows.Forms.Padding(4);
            this.lapseOption.Name = "lapseOption";
            this.lapseOption.Size = new System.Drawing.Size(100, 28);
            this.lapseOption.TabIndex = 6;
            this.lapseOption.Text = "Lapse";
            this.lapseOption.UseVisualStyleBackColor = true;
            this.lapseOption.Click += new System.EventHandler(this.lapseOption_Click);
            // 
            // exerciseOption
            // 
            this.exerciseOption.Location = new System.Drawing.Point(1307, 155);
            this.exerciseOption.Margin = new System.Windows.Forms.Padding(4);
            this.exerciseOption.Name = "exerciseOption";
            this.exerciseOption.Size = new System.Drawing.Size(100, 28);
            this.exerciseOption.TabIndex = 5;
            this.exerciseOption.Text = "Exercise";
            this.exerciseOption.UseVisualStyleBackColor = true;
            this.exerciseOption.Click += new System.EventHandler(this.exerciseOption_Click);
            // 
            // exerciseAccountLabel
            // 
            this.exerciseAccountLabel.AutoSize = true;
            this.exerciseAccountLabel.Location = new System.Drawing.Point(25, 21);
            this.exerciseAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exerciseAccountLabel.Name = "exerciseAccountLabel";
            this.exerciseAccountLabel.Size = new System.Drawing.Size(110, 17);
            this.exerciseAccountLabel.TabIndex = 3;
            this.exerciseAccountLabel.Text = "Choose account";
            // 
            // exerciseAccount
            // 
            this.exerciseAccount.FormattingEnabled = true;
            this.exerciseAccount.Location = new System.Drawing.Point(147, 17);
            this.exerciseAccount.Margin = new System.Windows.Forms.Padding(4);
            this.exerciseAccount.Name = "exerciseAccount";
            this.exerciseAccount.Size = new System.Drawing.Size(160, 24);
            this.exerciseAccount.TabIndex = 2;
            this.exerciseAccount.SelectedIndexChanged += new System.EventHandler(this.exerciseAccount_SelectedIndexChanged);
            // 
            // comboTab
            // 
            this.comboTab.BackColor = System.Drawing.Color.LightGray;
            this.comboTab.Controls.Add(this.button2);
            this.comboTab.Controls.Add(this.comboDeltaNeutralBox);
            this.comboTab.Controls.Add(this.comboLegsBox);
            this.comboTab.Controls.Add(this.comboContractBox);
            this.comboTab.Location = new System.Drawing.Point(4, 25);
            this.comboTab.Margin = new System.Windows.Forms.Padding(4);
            this.comboTab.Name = "comboTab";
            this.comboTab.Padding = new System.Windows.Forms.Padding(4);
            this.comboTab.Size = new System.Drawing.Size(1667, 656);
            this.comboTab.TabIndex = 6;
            this.comboTab.Text = "Combo Trading (in progress)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1056, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 84;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboDeltaNeutralBox
            // 
            this.comboDeltaNeutralBox.Controls.Add(this.comboDeltaNeutralSet);
            this.comboDeltaNeutralBox.Controls.Add(this.label2);
            this.comboDeltaNeutralBox.Controls.Add(this.label5);
            this.comboDeltaNeutralBox.Controls.Add(this.textBox1);
            this.comboDeltaNeutralBox.Controls.Add(this.label6);
            this.comboDeltaNeutralBox.Controls.Add(this.textBox2);
            this.comboDeltaNeutralBox.Controls.Add(this.textBox4);
            this.comboDeltaNeutralBox.Controls.Add(this.textBox3);
            this.comboDeltaNeutralBox.Controls.Add(this.comboBox1);
            this.comboDeltaNeutralBox.Controls.Add(this.label3);
            this.comboDeltaNeutralBox.Controls.Add(this.label4);
            this.comboDeltaNeutralBox.Location = new System.Drawing.Point(1187, 7);
            this.comboDeltaNeutralBox.Margin = new System.Windows.Forms.Padding(4);
            this.comboDeltaNeutralBox.Name = "comboDeltaNeutralBox";
            this.comboDeltaNeutralBox.Padding = new System.Windows.Forms.Padding(4);
            this.comboDeltaNeutralBox.Size = new System.Drawing.Size(253, 191);
            this.comboDeltaNeutralBox.TabIndex = 83;
            this.comboDeltaNeutralBox.TabStop = false;
            this.comboDeltaNeutralBox.Text = "Delta Neutral";
            // 
            // comboDeltaNeutralSet
            // 
            this.comboDeltaNeutralSet.Location = new System.Drawing.Point(193, 21);
            this.comboDeltaNeutralSet.Margin = new System.Windows.Forms.Padding(4);
            this.comboDeltaNeutralSet.Name = "comboDeltaNeutralSet";
            this.comboDeltaNeutralSet.Size = new System.Drawing.Size(49, 28);
            this.comboDeltaNeutralSet.TabIndex = 84;
            this.comboDeltaNeutralSet.Text = "Set";
            this.comboDeltaNeutralSet.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Symbol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "SecType";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 22);
            this.textBox1.TabIndex = 84;
            this.textBox1.Text = "IBKR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 89;
            this.label6.Text = "Exchange";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 153);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 22);
            this.textBox2.TabIndex = 93;
            this.textBox2.Text = "20130908";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 121);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 22);
            this.textBox4.TabIndex = 92;
            this.textBox4.Text = "ISLAND";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 89);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 22);
            this.textBox3.TabIndex = 91;
            this.textBox3.Text = "USD";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "STK",
            "OPT",
            "FUT",
            "CASH",
            "BOND",
            "CFD",
            "FOP",
            "WAR",
            "IOPT",
            "FWD",
            "BAG",
            "IND",
            "BILL",
            "FUND",
            "FIXED",
            "SLB",
            "NEWS",
            "CMDTY",
            "BSK",
            "ICU",
            "ICS"});
            this.comboBox1.Location = new System.Drawing.Point(95, 55);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 24);
            this.comboBox1.TabIndex = 86;
            this.comboBox1.Text = "STK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 90;
            this.label3.Text = "Currency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "Expiry";
            // 
            // comboLegsBox
            // 
            this.comboLegsBox.Controls.Add(this.dataGridView1);
            this.comboLegsBox.Location = new System.Drawing.Point(423, 7);
            this.comboLegsBox.Margin = new System.Windows.Forms.Padding(4);
            this.comboLegsBox.Name = "comboLegsBox";
            this.comboLegsBox.Padding = new System.Windows.Forms.Padding(4);
            this.comboLegsBox.Size = new System.Drawing.Size(625, 191);
            this.comboLegsBox.TabIndex = 80;
            this.comboLegsBox.TabStop = false;
            this.comboLegsBox.Text = "Combo legs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comboLegAction,
            this.comboLegRatio,
            this.comboLegDescription,
            this.comboLegPrice});
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 160);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboLegAction
            // 
            this.comboLegAction.HeaderText = "Action";
            this.comboLegAction.Name = "comboLegAction";
            this.comboLegAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comboLegAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comboLegAction.Width = 50;
            // 
            // comboLegRatio
            // 
            this.comboLegRatio.HeaderText = "Ratio";
            this.comboLegRatio.Name = "comboLegRatio";
            this.comboLegRatio.Width = 50;
            // 
            // comboLegDescription
            // 
            this.comboLegDescription.HeaderText = "Description";
            this.comboLegDescription.Name = "comboLegDescription";
            this.comboLegDescription.Width = 200;
            // 
            // comboLegPrice
            // 
            this.comboLegPrice.HeaderText = "Price";
            this.comboLegPrice.Name = "comboLegPrice";
            // 
            // comboContractBox
            // 
            this.comboContractBox.Controls.Add(this.findComboContract);
            this.comboContractBox.Controls.Add(this.comboSymbolLabel);
            this.comboContractBox.Controls.Add(this.comboSymbol);
            this.comboContractBox.Controls.Add(this.comboStrike);
            this.comboContractBox.Controls.Add(this.comboRightLabel);
            this.comboContractBox.Controls.Add(this.comboExpiry);
            this.comboContractBox.Controls.Add(this.comboStrikeLabel);
            this.comboContractBox.Controls.Add(this.comboCurrency);
            this.comboContractBox.Controls.Add(this.comboRight);
            this.comboContractBox.Controls.Add(this.comboCurrencyLabel);
            this.comboContractBox.Controls.Add(this.comboExpiryLabel);
            this.comboContractBox.Controls.Add(this.comboMultiplier);
            this.comboContractBox.Controls.Add(this.comboSecType);
            this.comboContractBox.Controls.Add(this.comboLocalSymbol);
            this.comboContractBox.Controls.Add(this.comboMultiplierLabel);
            this.comboContractBox.Controls.Add(this.comboExchange);
            this.comboContractBox.Controls.Add(this.comboSecTypeLabel);
            this.comboContractBox.Controls.Add(this.comboExchangeLabel);
            this.comboContractBox.Controls.Add(this.comboLocalSymbolLabel);
            this.comboContractBox.Location = new System.Drawing.Point(12, 7);
            this.comboContractBox.Margin = new System.Windows.Forms.Padding(4);
            this.comboContractBox.Name = "comboContractBox";
            this.comboContractBox.Padding = new System.Windows.Forms.Padding(4);
            this.comboContractBox.Size = new System.Drawing.Size(391, 191);
            this.comboContractBox.TabIndex = 79;
            this.comboContractBox.TabStop = false;
            this.comboContractBox.Text = "Contract";
            // 
            // findComboContract
            // 
            this.findComboContract.AutoSize = true;
            this.findComboContract.Location = new System.Drawing.Point(337, 161);
            this.findComboContract.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.findComboContract.Name = "findComboContract";
            this.findComboContract.Size = new System.Drawing.Size(35, 17);
            this.findComboContract.TabIndex = 84;
            this.findComboContract.TabStop = true;
            this.findComboContract.Text = "Find";
            this.findComboContract.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.findComboContract_LinkClicked);
            // 
            // comboSymbolLabel
            // 
            this.comboSymbolLabel.AutoSize = true;
            this.comboSymbolLabel.Location = new System.Drawing.Point(21, 27);
            this.comboSymbolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comboSymbolLabel.Name = "comboSymbolLabel";
            this.comboSymbolLabel.Size = new System.Drawing.Size(54, 17);
            this.comboSymbolLabel.TabIndex = 61;
            this.comboSymbolLabel.Text = "Symbol";
            // 
            // comboSymbol
            // 
            this.comboSymbol.Location = new System.Drawing.Point(84, 23);
            this.comboSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.comboSymbol.Name = "comboSymbol";
            this.comboSymbol.Size = new System.Drawing.Size(89, 22);
            this.comboSymbol.TabIndex = 60;
            this.comboSymbol.Text = "IBKR";
            // 
            // comboStrike
            // 
            this.comboStrike.Location = new System.Drawing.Point(284, 87);
            this.comboStrike.Margin = new System.Windows.Forms.Padding(4);
            this.comboStrike.Name = "comboStrike";
            this.comboStrike.Size = new System.Drawing.Size(88, 22);
            this.comboStrike.TabIndex = 73;
            // 
            // comboRightLabel
            // 
            this.comboRightLabel.AutoSize = true;
            this.comboRightLabel.Location = new System.Drawing.Point(16, 151);
            this.comboRightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comboRightLabel.Name = "comboRightLabel";
            this.comboRightLabel.Size = new System.Drawing.Size(56, 17);
            this.comboRightLabel.TabIndex = 78;
            this.comboRightLabel.Text = "Put/Call";
            // 
            // comboExpiry
            // 
            this.comboExpiry.Location = new System.Drawing.Point(284, 55);
            this.comboExpiry.Margin = new System.Windows.Forms.Padding(4);
            this.comboExpiry.Name = "comboExpiry";
            this.comboExpiry.Size = new System.Drawing.Size(88, 22);
            this.comboExpiry.TabIndex = 74;
            this.comboExpiry.Text = "20130908";
            // 
            // comboStrikeLabel
            // 
            this.comboStrikeLabel.AutoSize = true;
            this.comboStrikeLabel.Location = new System.Drawing.Point(231, 87);
            this.comboStrikeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comboStrikeLabel.Name = "comboStrikeLabel";
            this.comboStrikeLabel.Size = new System.Drawing.Size(44, 17);
            this.comboStrikeLabel.TabIndex = 65;
            this.comboStrikeLabel.Text = "Strike";
            // 
            // comboCurrency
            // 
            this.comboCurrency.Location = new System.Drawing.Point(84, 87);
            this.comboCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.comboCurrency.Name = "comboCurrency";
            this.comboCurrency.Size = new System.Drawing.Size(89, 22);
            this.comboCurrency.TabIndex = 70;
            this.comboCurrency.Text = "USD";
            // 
            // comboRight
            // 
            this.comboRight.FormattingEnabled = true;
            this.comboRight.Location = new System.Drawing.Point(84, 151);
            this.comboRight.Margin = new System.Windows.Forms.Padding(4);
            this.comboRight.Name = "comboRight";
            this.comboRight.Size = new System.Drawing.Size(89, 24);
            this.comboRight.TabIndex = 77;
            // 
            // comboCurrencyLabel
            // 
            this.comboCurrencyLabel.AutoSize = true;
            this.comboCurrencyLabel.Location = new System.Drawing.Point(11, 87);
            this.comboCurrencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comboCurrencyLabel.Name = "comboCurrencyLabel";
            this.comboCurrencyLabel.Size = new System.Drawing.Size(65, 17);
            this.comboCurrencyLabel.TabIndex = 68;
            this.comboCurrencyLabel.Text = "Currency";
            // 
            // comboExpiryLabel
            // 
            this.comboExpiryLabel.AutoSize = true;
            this.comboExpiryLabel.Location = new System.Drawing.Point(229, 54);
            this.comboExpiryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comboExpiryLabel.Name = "comboExpiryLabel";
            this.comboExpiryLabel.Size = new System.Drawing.Size(46, 17);
            this.comboExpiryLabel.TabIndex = 64;
            this.comboExpiryLabel.Text = "Expiry";
            // 
            // comboMultiplier
            // 
            this.comboMultiplier.Location = new System.Drawing.Point(284, 27);
            this.comboMultiplier.Margin = new System.Windows.Forms.Padding(4);
            this.comboMultiplier.Name = "comboMultiplier";
            this.comboMultiplier.Size = new System.Drawing.Size(88, 22);
            this.comboMultiplier.TabIndex = 72;
            // 
            // comboSecType
            // 
            this.comboSecType.FormattingEnabled = true;
            this.comboSecType.Items.AddRange(new object[] {
            "STK",
            "OPT",
            "FUT",
            "CASH",
            "BOND",
            "CFD",
            "FOP",
            "WAR",
            "IOPT",
            "FWD",
            "BAG",
            "IND",
            "BILL",
            "FUND",
            "FIXED",
            "SLB",
            "NEWS",
            "CMDTY",
            "BSK",
            "ICU",
            "ICS"});
            this.comboSecType.Location = new System.Drawing.Point(84, 54);
            this.comboSecType.Margin = new System.Windows.Forms.Padding(4);
            this.comboSecType.Name = "comboSecType";
            this.comboSecType.Size = new System.Drawing.Size(89, 24);
            this.comboSecType.TabIndex = 62;
            this.comboSecType.Text = "STK";
            // 
            // comboLocalSymbol
            // 
            this.comboLocalSymbol.Location = new System.Drawing.Point(284, 119);
            this.comboLocalSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.comboLocalSymbol.Name = "comboLocalSymbol";
            this.comboLocalSymbol.Size = new System.Drawing.Size(88, 22);
            this.comboLocalSymbol.TabIndex = 75;
            // 
            // comboMultiplierLabel
            // 
            this.comboMultiplierLabel.AutoSize = true;
            this.comboMultiplierLabel.Location = new System.Drawing.Point(212, 27);
            this.comboMultiplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comboMultiplierLabel.Name = "comboMultiplierLabel";
            this.comboMultiplierLabel.Size = new System.Drawing.Size(64, 17);
            this.comboMultiplierLabel.TabIndex = 66;
            this.comboMultiplierLabel.Text = "Multiplier";
            // 
            // comboExchange
            // 
            this.comboExchange.Location = new System.Drawing.Point(84, 119);
            this.comboExchange.Margin = new System.Windows.Forms.Padding(4);
            this.comboExchange.Name = "comboExchange";
            this.comboExchange.Size = new System.Drawing.Size(89, 22);
            this.comboExchange.TabIndex = 71;
            this.comboExchange.Text = "ISLAND";
            // 
            // comboSecTypeLabel
            // 
            this.comboSecTypeLabel.AutoSize = true;
            this.comboSecTypeLabel.Location = new System.Drawing.Point(9, 54);
            this.comboSecTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comboSecTypeLabel.Name = "comboSecTypeLabel";
            this.comboSecTypeLabel.Size = new System.Drawing.Size(64, 17);
            this.comboSecTypeLabel.TabIndex = 63;
            this.comboSecTypeLabel.Text = "SecType";
            // 
            // comboExchangeLabel
            // 
            this.comboExchangeLabel.AutoSize = true;
            this.comboExchangeLabel.Location = new System.Drawing.Point(3, 119);
            this.comboExchangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comboExchangeLabel.Name = "comboExchangeLabel";
            this.comboExchangeLabel.Size = new System.Drawing.Size(70, 17);
            this.comboExchangeLabel.TabIndex = 67;
            this.comboExchangeLabel.Text = "Exchange";
            // 
            // comboLocalSymbolLabel
            // 
            this.comboLocalSymbolLabel.AutoSize = true;
            this.comboLocalSymbolLabel.Location = new System.Drawing.Point(183, 119);
            this.comboLocalSymbolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comboLocalSymbolLabel.Name = "comboLocalSymbolLabel";
            this.comboLocalSymbolLabel.Size = new System.Drawing.Size(92, 17);
            this.comboLocalSymbolLabel.TabIndex = 69;
            this.comboLocalSymbolLabel.Text = "Local Symbol";
            // 
            // contextMenuOrder
            // 
            this.contextMenuOrder.Name = "contextMenuOrder";
            this.contextMenuOrder.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuItemBuyLMT
            // 
            this.contextMenuItemBuyLMT.Name = "contextMenuItemBuyLMT";
            this.contextMenuItemBuyLMT.Size = new System.Drawing.Size(32, 19);
            // 
            // contextMenuItemSellLMT
            // 
            this.contextMenuItemSellLMT.Name = "contextMenuItemSellLMT";
            this.contextMenuItemSellLMT.Size = new System.Drawing.Size(32, 19);
            // 
            // status_CT
            // 
            this.status_CT.AutoSize = true;
            this.status_CT.Location = new System.Drawing.Point(63, 177);
            this.status_CT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status_CT.Name = "status_CT";
            this.status_CT.Size = new System.Drawing.Size(106, 17);
            this.status_CT.TabIndex = 9;
            this.status_CT.Text = "Disconnected...";
            // 
            // status_label_CT
            // 
            this.status_label_CT.AutoSize = true;
            this.status_label_CT.Location = new System.Drawing.Point(8, 177);
            this.status_label_CT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status_label_CT.Name = "status_label_CT";
            this.status_label_CT.Size = new System.Drawing.Size(52, 17);
            this.status_label_CT.TabIndex = 8;
            this.status_label_CT.Text = "Status:";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.messagesTab);
            this.tabControl2.Location = new System.Drawing.Point(0, 704);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1675, 142);
            this.tabControl2.TabIndex = 1;
            // 
            // messagesTab
            // 
            this.messagesTab.BackColor = System.Drawing.Color.LightGray;
            this.messagesTab.Controls.Add(this.messageBoxClear_link);
            this.messagesTab.Controls.Add(this.messageBox);
            this.messagesTab.Controls.Add(this.status_CT);
            this.messagesTab.Controls.Add(this.status_label_CT);
            this.messagesTab.Location = new System.Drawing.Point(4, 25);
            this.messagesTab.Margin = new System.Windows.Forms.Padding(4);
            this.messagesTab.Name = "messagesTab";
            this.messagesTab.Padding = new System.Windows.Forms.Padding(4);
            this.messagesTab.Size = new System.Drawing.Size(1667, 113);
            this.messagesTab.TabIndex = 0;
            this.messagesTab.Text = "Messages";
            // 
            // messageBoxClear_link
            // 
            this.messageBoxClear_link.AutoSize = true;
            this.messageBoxClear_link.Location = new System.Drawing.Point(8, 2);
            this.messageBoxClear_link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageBoxClear_link.Name = "messageBoxClear_link";
            this.messageBoxClear_link.Size = new System.Drawing.Size(41, 17);
            this.messageBoxClear_link.TabIndex = 11;
            this.messageBoxClear_link.TabStop = true;
            this.messageBoxClear_link.Text = "Clear";
            this.messageBoxClear_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.messageBoxClear_link_LinkClicked);
            // 
            // messageBox
            // 
            this.messageBox.AcceptsReturn = true;
            this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox.Location = new System.Drawing.Point(8, 22);
            this.messageBox.Margin = new System.Windows.Forms.Padding(4);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(1647, 63);
            this.messageBox.TabIndex = 10;
            // 
            // informationTooltip
            // 
            this.informationTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tabProbabilities
            // 
            this.tabProbabilities.BackColor = System.Drawing.Color.LightGray;
            this.tabProbabilities.Location = new System.Drawing.Point(4, 25);
            this.tabProbabilities.Name = "tabProbabilities";
            this.tabProbabilities.Size = new System.Drawing.Size(299, 301);
            this.tabProbabilities.TabIndex = 4;
            this.tabProbabilities.Text = "Probabilities";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Intraday";
            // 
            // dataChartRT
            // 
            this.dataChartRT.BarSizeInSeconds = 0;
            this.dataChartRT.ChartEndDate = new System.DateTime(((long)(0)));
            this.dataChartRT.Location = new System.Drawing.Point(578, 23);
            this.dataChartRT.Name = "dataChartRT";
            this.dataChartRT.OrderFormBuy = null;
            this.dataChartRT.OrderFormSell = null;
            this.dataChartRT.PriceLineManager = priceLineManager1;
            this.dataChartRT.Size = new System.Drawing.Size(622, 331);
            this.dataChartRT.TabIndex = 3;
            this.dataChartRT.XLabelFormat = null;
            this.dataChartRT.XValue = 0D;
            this.dataChartRT.YValue = 0D;
            // 
            // orderFormBuy
            // 
            this.orderFormBuy.Location = new System.Drawing.Point(6, 16);
            this.orderFormBuy.Name = "orderFormBuy";
            this.orderFormBuy.Order = CSharpClientApp.usercontrols.OrderType.BUY;
            this.orderFormBuy.Size = new System.Drawing.Size(287, 279);
            this.orderFormBuy.TabIndex = 31;
            // 
            // orderFormSell
            // 
            this.orderFormSell.Location = new System.Drawing.Point(3, 16);
            this.orderFormSell.Name = "orderFormSell";
            this.orderFormSell.Order = CSharpClientApp.usercontrols.OrderType.SELL;
            this.orderFormSell.Size = new System.Drawing.Size(275, 282);
            this.orderFormSell.TabIndex = 32;
            // 
            // dataChartDaily
            // 
            this.dataChartDaily.BarSizeInSeconds = 0;
            this.dataChartDaily.ChartEndDate = new System.DateTime(((long)(0)));
            this.dataChartDaily.Location = new System.Drawing.Point(7, 24);
            this.dataChartDaily.Name = "dataChartDaily";
            this.dataChartDaily.OrderFormBuy = this.orderFormBuy;
            this.dataChartDaily.OrderFormSell = this.orderFormSell;
            this.dataChartDaily.PriceLineManager = priceLineManager2;
            this.dataChartDaily.Size = new System.Drawing.Size(622, 329);
            this.dataChartDaily.TabIndex = 34;
            this.dataChartDaily.XLabelFormat = null;
            this.dataChartDaily.XValue = 0D;
            this.dataChartDaily.YValue = 0D;
            // 
            // dataChart1M
            // 
            this.dataChart1M.BarSizeInSeconds = 0;
            this.dataChart1M.ChartEndDate = new System.DateTime(((long)(0)));
            this.dataChart1M.Location = new System.Drawing.Point(948, 23);
            this.dataChart1M.Name = "dataChart1M";
            this.dataChart1M.OrderFormBuy = this.orderFormBuy;
            this.dataChart1M.OrderFormSell = this.orderFormSell;
            this.dataChart1M.PriceLineManager = priceLineManager3;
            this.dataChart1M.Size = new System.Drawing.Size(626, 330);
            this.dataChart1M.TabIndex = 33;
            this.dataChart1M.XLabelFormat = null;
            this.dataChart1M.XValue = 0D;
            this.dataChart1M.YValue = 0D;
            // 
            // IBSampleApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1594, 857);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IBSampleApp";
            this.Text = "Interactive Brokers - C# Sample Application";
            this.TabControl.ResumeLayout(false);
            this.connectionTab.ResumeLayout(false);
            this.connectionTab.PerformLayout();
            this.marketDataTab.ResumeLayout(false);
            this.marketData_MDT.ResumeLayout(false);
            this.topMarketDataTab_MDT.ResumeLayout(false);
            this.topMarketDataTab_MDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataGrid_MDT)).EndInit();
            this.historicalDataTab.ResumeLayout(false);
            this.historicalDataTab.PerformLayout();
            this.tabDashboard.ResumeLayout(false);
            this.tabBuy.ResumeLayout(false);
            this.tabSell.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.deepBookTab_MDT.ResumeLayout(false);
            this.deepBookTab_MDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deepBookGrid)).EndInit();
            this.rtBarsTab_MDT.ResumeLayout(false);
            this.rtBarsTab_MDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtBarsGrid)).EndInit();
            this.scannerTab.ResumeLayout(false);
            this.scannerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scannerGrid)).EndInit();
            this.dataResults_MDT.ResumeLayout(false);
            this.topMktData_MDT.ResumeLayout(false);
            this.deepBookGroupBox.ResumeLayout(false);
            this.deepBookGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.marketScanner_MDT.ResumeLayout(false);
            this.marketScanner_MDT.PerformLayout();
            this.tradingTab.ResumeLayout(false);
            this.tradingTab.PerformLayout();
            this.executionsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tradeLogGrid)).EndInit();
            this.liveOrdersGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liveOrdersGrid)).EndInit();
            this.accountInfoTab.ResumeLayout(false);
            this.accountInfoTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.accSummaryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accSummaryGrid)).EndInit();
            this.accUpdatesTab.ResumeLayout(false);
            this.accUpdatesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountPortfolioGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountValuesGrid)).EndInit();
            this.positionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.positionsGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contractFundamentalsGroupBox.ResumeLayout(false);
            this.contractFundamentalsGroupBox.PerformLayout();
            this.contractDetailsGroupBox.ResumeLayout(false);
            this.contractDetailsGroupBox.PerformLayout();
            this.contractInfoTab.ResumeLayout(false);
            this.contractDetailsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractDetailsGrid)).EndInit();
            this.fundamentalsPage.ResumeLayout(false);
            this.fundamentalsPage.PerformLayout();
            this.optionChainPage.ResumeLayout(false);
            this.optionChainCallGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionChainCallGrid)).EndInit();
            this.optionChainPutGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionChainPutGrid)).EndInit();
            this.advisorTab.ResumeLayout(false);
            this.advisorProfilesBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advisorProfilesGrid)).EndInit();
            this.advisorGroupsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advisorGroupsGrid)).EndInit();
            this.advisorAliasesBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advisorAliasesGrid)).EndInit();
            this.optionsTab.ResumeLayout(false);
            this.optionsTab.PerformLayout();
            this.optionsPositionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionPositionsGrid)).EndInit();
            this.comboTab.ResumeLayout(false);
            this.comboDeltaNeutralBox.ResumeLayout(false);
            this.comboDeltaNeutralBox.PerformLayout();
            this.comboLegsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.comboContractBox.ResumeLayout(false);
            this.comboContractBox.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.messagesTab.ResumeLayout(false);
            this.messagesTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage connectionTab;
        private System.Windows.Forms.TabPage marketDataTab;
        private System.Windows.Forms.Label cliet_label_CT;
        private System.Windows.Forms.TextBox port_CT;
        private System.Windows.Forms.Label port_label_CT;
        private System.Windows.Forms.Label host_label_CT;
        private System.Windows.Forms.TextBox host_CT;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage messagesTab;
        private System.Windows.Forms.TextBox clientid_CT;
        private System.Windows.Forms.TabPage tradingTab;
        private System.Windows.Forms.TabPage accountInfoTab;
        private System.Windows.Forms.Label status_label_CT;
        private System.Windows.Forms.Label status_CT;
        private System.Windows.Forms.TabControl marketData_MDT;
        private System.Windows.Forms.TabPage topMarketDataTab_MDT;
        private System.Windows.Forms.DataGridView marketDataGrid_MDT;
        private System.Windows.Forms.LinkLabel closeMketDataTab;
        private System.Windows.Forms.TabPage deepBookTab_MDT;
        private System.Windows.Forms.DataGridView deepBookGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidBookMaker;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidBookSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidBookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn askBookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn askBookSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn askBookMaker;
        private System.Windows.Forms.LinkLabel closeDeepBookLink;
        private System.Windows.Forms.TabPage historicalDataTab;
        private System.Windows.Forms.TabControl dataResults_MDT;
        private System.Windows.Forms.TabPage topMktData_MDT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deepBook_Button;
        private System.Windows.Forms.Label symbol_label_TMD_MDT;
        private System.Windows.Forms.Button marketData_Button;
        private System.Windows.Forms.ComboBox secType_TMD_MDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exchange_label_TMD_MDT;
        private System.Windows.Forms.TextBox localSymbol_TMD_MDT;
        private System.Windows.Forms.Label currency_label_TMD_MDT;
        private System.Windows.Forms.TextBox expiry_TMD_MDT;
        private System.Windows.Forms.TextBox symbol_TMD_MDT;
        private System.Windows.Forms.TextBox strike_TMD_MDT;
        private System.Windows.Forms.TextBox currency_TMD_MDT;
        private System.Windows.Forms.TextBox multiplier_TMD_MDT;
        private System.Windows.Forms.TextBox exchange_TMD_MDT;
        private System.Windows.Forms.Label localSymbol_label_TMD_MDT;
        private System.Windows.Forms.Label putcall_label_TMD_MDT;
        private System.Windows.Forms.Label expiry_label_TMD_MDT;
        private System.Windows.Forms.Label strike_label_TMD_MDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button histData_Button;
        private System.Windows.Forms.ComboBox hdRequest_WhatToShow;
        private System.Windows.Forms.TextBox hdRequest_Duration;
        private System.Windows.Forms.ComboBox hdRequest_BarSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox hdRequest_TimeUnit;
        private System.Windows.Forms.TabPage marketScanner_MDT;
        private System.Windows.Forms.LinkLabel histDataTabClose_MDT;
        private System.Windows.Forms.TabPage rtBarsTab_MDT;
        private System.Windows.Forms.DataGridView rtBarsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.LinkLabel rtBarsCloseLink;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label scanNumRows_label;
        private System.Windows.Forms.Label scanStockType_label;
        private System.Windows.Forms.Label scanLocation_label;
        private System.Windows.Forms.Label scanInstrument_label;
        private System.Windows.Forms.Label scanCode_label;
        private System.Windows.Forms.TextBox scanNumRows;
        private System.Windows.Forms.ComboBox scanStockType;
        private System.Windows.Forms.ComboBox scanInstrument;
        private System.Windows.Forms.ComboBox scanCode;
        private System.Windows.Forms.Button scannerRequest_Button;
        private System.Windows.Forms.TabPage scannerTab;
        private System.Windows.Forms.DataGridView scannerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanBenchmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanProjection;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanLegStr;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.LinkLabel messageBoxClear_link;
        private System.Windows.Forms.ComboBox scanLocation;
        private System.Windows.Forms.LinkLabel scannerTab_link;
        private System.Windows.Forms.DataGridView liveOrdersGrid;
        private System.Windows.Forms.GroupBox executionsGroup;
        private System.Windows.Forms.GroupBox liveOrdersGroup;
        private System.Windows.Forms.DataGridView tradeLogGrid;
        private System.Windows.Forms.LinkLabel newOrderLink;
        private System.Windows.Forms.Button refreshExecutionsButton;
        private System.Windows.Forms.Button refreshOrdersButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelOrdersButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn permIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.Button clientOrdersButton;
        private System.Windows.Forms.Button globalCancelButton;
        private System.Windows.Forms.Label accountSelectorLabel;
        private System.Windows.Forms.ComboBox accountSelector;
        private System.Windows.Forms.Label lastUpdatedLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage accSummaryTab;
        private System.Windows.Forms.TabPage accUpdatesTab;
        private System.Windows.Forms.Label accUpdatesLastUpdateValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecutionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeExecColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountExecColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionExecColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityExecColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionExecColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceExecColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionExecColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealisedPnL;
        private System.Windows.Forms.TabPage positionsTab;
        private System.Windows.Forms.DataGridView accSummaryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency;
        private System.Windows.Forms.DataGridView accountValuesGrid;
        private System.Windows.Forms.DataGridView accountPortfolioGrid;
        private System.Windows.Forms.DataGridView positionsGrid;
        private System.Windows.Forms.Button accUpdatesSubscribe;
        private System.Windows.Forms.Button positionRequest;
        private System.Windows.Forms.Button accSummaryRequest;
        private System.Windows.Forms.Label accUpdatesAccountLabel;
        private System.Windows.Forms.Label accUpdatesSubscribedAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatePortfolioContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatePortfolioPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatePortfolioMarketPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatePortfolioMarketValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatePortfolioAvgCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatePortfolioUnrealisedPnL;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatePortfolioRealisedPnL;
        private System.Windows.Forms.DataGridViewTextBoxColumn accUpdatesKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn accUpdatesValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn accUpdatesCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionAvgCost;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label conDetSymbolLabel;
        private System.Windows.Forms.ComboBox conDetSecType;
        private System.Windows.Forms.Label conDetSecTypeLabel;
        private System.Windows.Forms.Label conDetExchangeLabel;
        private System.Windows.Forms.TextBox conDetLocalSymbol;
        private System.Windows.Forms.Label conDetCurrencyLabel;
        private System.Windows.Forms.TextBox conDetExpiry;
        private System.Windows.Forms.TextBox conDetSymbol;
        private System.Windows.Forms.TextBox conDetStrike;
        private System.Windows.Forms.TextBox conDetCurrency;
        private System.Windows.Forms.TextBox conDetMultiplier;
        private System.Windows.Forms.TextBox conDetExchange;
        private System.Windows.Forms.Label conDetLocalSymbolLabel;
        private System.Windows.Forms.Label conDetMultiplierLabel;
        private System.Windows.Forms.Label conDetExpiryLabel;
        private System.Windows.Forms.Label conDetStrikeLabel;
        private System.Windows.Forms.TabControl contractInfoTab;
        private System.Windows.Forms.TabPage contractDetailsPage;
        private System.Windows.Forms.TabPage fundamentalsPage;
        private System.Windows.Forms.DataGridView contractDetailsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn conResSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn conResLocalSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn conResSecType;
        private System.Windows.Forms.DataGridViewTextBoxColumn conResCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn conResExchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn conResPrimaryExch;
        private System.Windows.Forms.DataGridViewTextBoxColumn conResExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn conResMultiplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn conResStrike;
        private System.Windows.Forms.DataGridViewTextBoxColumn conResRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn conResConId;
        private System.Windows.Forms.GroupBox contractDetailsGroupBox;
        private System.Windows.Forms.TextBox fundamentalsOutput;
        private System.Windows.Forms.Button searchContractDetails;
        private System.Windows.Forms.ComboBox fundamentalsReportType;
        private System.Windows.Forms.Label fundamentalsReportTypeLabel;
        private System.Windows.Forms.GroupBox contractFundamentalsGroupBox;
        private System.Windows.Forms.Button fundamentalsQueryButton;
        private System.Windows.Forms.TabPage advisorTab;
        private System.Windows.Forms.GroupBox advisorAliasesBox;
        private System.Windows.Forms.GroupBox advisorGroupsBox;
        private System.Windows.Forms.GroupBox advisorProfilesBox;
        private System.Windows.Forms.DataGridView advisorGroupsGrid;
        private System.Windows.Forms.DataGridView advisorProfilesGrid;
        private System.Windows.Forms.DataGridView advisorAliasesGrid;
        private System.Windows.Forms.Button loadGroups;
        private System.Windows.Forms.Button loadAliases;
        private System.Windows.Forms.Button loadProfiles;
        private System.Windows.Forms.Button saveProfiles;
        private System.Windows.Forms.Button saveGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupName;
        private System.Windows.Forms.DataGridViewComboBoxColumn groupMethod;// = new System.Windows.Forms.DataGridViewComboBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn groupAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileName;
        private System.Windows.Forms.DataGridViewComboBoxColumn profileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileAllocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn advisorAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn advisorAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountSummaryAccount;
        private System.Windows.Forms.TabPage comboTab;
        private System.Windows.Forms.Label mdRightLabel;
        private System.Windows.Forms.ComboBox mdContractRight;
        private System.Windows.Forms.Label conDetRightLabel;
        private System.Windows.Forms.ComboBox conDetRight;
        private System.Windows.Forms.Label comboSymbolLabel;
        private System.Windows.Forms.Label comboRightLabel;
        private System.Windows.Forms.Label comboStrikeLabel;
        private System.Windows.Forms.ComboBox comboRight;
        private System.Windows.Forms.Label comboExpiryLabel;
        private System.Windows.Forms.ComboBox comboSecType;
        private System.Windows.Forms.Label comboMultiplierLabel;
        private System.Windows.Forms.Label comboSecTypeLabel;
        private System.Windows.Forms.Label comboLocalSymbolLabel;
        private System.Windows.Forms.Label comboExchangeLabel;
        private System.Windows.Forms.TextBox comboExchange;
        private System.Windows.Forms.TextBox comboLocalSymbol;
        private System.Windows.Forms.TextBox comboMultiplier;
        private System.Windows.Forms.Label comboCurrencyLabel;
        private System.Windows.Forms.TextBox comboCurrency;
        private System.Windows.Forms.TextBox comboExpiry;
        private System.Windows.Forms.TextBox comboStrike;
        private System.Windows.Forms.TextBox comboSymbol;
        private System.Windows.Forms.GroupBox comboContractBox;
        private System.Windows.Forms.GroupBox comboLegsBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox comboDeltaNeutralBox;
        private System.Windows.Forms.Button comboDeltaNeutralSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel findComboContract;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboLegAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn comboLegRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn comboLegDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn comboLegPrice;
        private System.Windows.Forms.CheckBox includeExpired;
        private System.Windows.Forms.TabPage optionsTab;
        private System.Windows.Forms.Label optionChainOptionExchangeLabel;
        private System.Windows.Forms.TextBox optionChainExchange;
        private System.Windows.Forms.CheckBox optionChainUseSnapshot;
        private System.Windows.Forms.DataGridView optionChainCallGrid;
        private System.Windows.Forms.DataGridView optionChainPutGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn putExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn putStrike;
        private System.Windows.Forms.DataGridViewTextBoxColumn putBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn putAsk;
        private System.Windows.Forms.DataGridViewTextBoxColumn putImpliedVolatility;
        private System.Windows.Forms.DataGridViewTextBoxColumn putDelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn putGamma;
        private System.Windows.Forms.DataGridViewTextBoxColumn putVega;
        private System.Windows.Forms.DataGridViewTextBoxColumn putTheta;
        private System.Windows.Forms.DataGridViewTextBoxColumn callExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn callStrike;
        private System.Windows.Forms.DataGridViewTextBoxColumn callBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn callAsk;
        private System.Windows.Forms.DataGridViewTextBoxColumn callImpliedVolatility;
        private System.Windows.Forms.DataGridViewTextBoxColumn callDelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn callGamma;
        private System.Windows.Forms.DataGridViewTextBoxColumn callVega;
        private System.Windows.Forms.DataGridViewTextBoxColumn callTheta;
        private System.Windows.Forms.GroupBox optionChainCallGroup;
        private System.Windows.Forms.GroupBox optionChainPutGroup;
        private System.Windows.Forms.Button queryOptionChain;
        private System.Windows.Forms.TabPage optionChainPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolTip informationTooltip;
        private System.Windows.Forms.Label exerciseAccountLabel;
        private System.Windows.Forms.ComboBox exerciseAccount;
        private System.Windows.Forms.DataGridView optionPositionsGrid;
        private System.Windows.Forms.TextBox optionExerciseQuan;
        private System.Windows.Forms.CheckBox overrideOption;
        private System.Windows.Forms.Button lapseOption;
        private System.Windows.Forms.Button exerciseOption;
        private System.Windows.Forms.GroupBox optionsPositionsGroupBox;
        private System.Windows.Forms.Label optionsQuantityLabel;
        private System.Windows.Forms.TextBox genericTickList;
        private System.Windows.Forms.Label genericTickListLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketDataContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn askPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn askSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeTickerColumn;
        private System.Windows.Forms.Button cancelMarketDataRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionMarketPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionMarketValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionAverageCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionUnrealisedPnL;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionRealisedPnL;
        private System.Windows.Forms.Label optionExchangeLabel;
        private System.Windows.Forms.TextBox optionExchange;
        private System.Windows.Forms.Label deepBookEntriesLabel;
        private System.Windows.Forms.TextBox deepBookEntries;
        private System.Windows.Forms.GroupBox deepBookGroupBox;
        private System.Windows.Forms.CheckBox contractMDRTH;
        private System.Windows.Forms.Label primaryExchLabel;
        private System.Windows.Forms.TextBox primaryExchange;
        private System.Windows.Forms.ContextMenuStrip contextMenuOrder;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemBuyLMT;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemSellLMT;
        private CSharpClientApp.usercontrols.OrderForm orderFormBuy;
        private CSharpClientApp.usercontrols.OrderForm orderFormSell;
        private System.Windows.Forms.Button histData_1M_Button;
        private CSharpClientApp.usercontrols.DataChart dataChart1M;
        private CSharpClientApp.usercontrols.DataChart dataChartDaily;
        private CSharpClientApp.usercontrols.DataChart dataChartRT;
        private System.Windows.Forms.CheckBox checkRTData;
        private System.Windows.Forms.CheckBox checkHighLowStudy;
        private System.Windows.Forms.CheckBox checkDailyLinesStudy;
        private System.Windows.Forms.ComboBox comboDuration;
        private System.Windows.Forms.ComboBox comboIDBarSize;
        private System.Windows.Forms.CheckBox checkBottomLines;
        private System.Windows.Forms.DateTimePicker pickerEndDate;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.CheckBox checkMonthlyLinesStudy;
        private System.Windows.Forms.TabControl tabDashboard;
        private System.Windows.Forms.TabPage tabBuy;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabSell;
        private System.Windows.Forms.TabPage tabAlerts;
        private System.Windows.Forms.TabPage tabProbabilities;
        private System.Windows.Forms.Label label7;
    }
}

