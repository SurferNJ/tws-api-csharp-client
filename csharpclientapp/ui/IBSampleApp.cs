/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IBSampleApp.messages;
using IBApi;
using IBSampleApp.ui;
using IBSampleApp.util;
using IBSampleApp.types;
using System.Windows.Forms.DataVisualization.Charting;
using CSharpClientApp.usercontrols;
using System.Collections.ObjectModel;
using CSharpClientApp.ui;


namespace IBSampleApp
{
    public partial class IBSampleApp : Form
    {
        delegate void MessageHandlerDelegate(IBMessage message);

        private MarketDataManager marketDataManager;
        private DeepBookManager deepBookManager;

        // manages multuple charts
        private List<HistoricalDataManager> historicalDataManagers = new List<HistoricalDataManager>();

        // manages multiple chart annotations, eg buy/sell lines, support/resistance lines, etc
        public PriceLineManager priceLineManager; 

        private RealTimeBarsManager realTimeBarManager;
        private ScannerManager scannerManager;
        private OrderManager orderManager;
        private AccountManager accountManager;
        private ContractManager contractManager;
        private AdvisorManager advisorManager;
        private OptionsManager optionsManager;

        private ChartsSyncManager chartsSyncManager;

        protected IBClient ibClient;

        private bool isConnected = false;

        public IBSampleApp()
        {
            InitializeComponent();

            //this.dataChart1M = new CSharpClientApp.usercontrols.DataChart();
            //this.orderFormBuy = new CSharpClientApp.usercontrols.OrderForm();
            //this.orderFormSell = new CSharpClientApp.usercontrols.OrderForm();
            this.priceLineManager = new PriceLineManager();
            this.dataChartDaily.PriceLineManager = this.priceLineManager;
            this.dataChart1M.PriceLineManager = this.priceLineManager;
            this.dataChartDaily.DataChartDoubleClick += this.DataChart_DoubleClick;
            
            ibClient = new IBClient(this);
            marketDataManager = new MarketDataManager(ibClient, marketDataGrid_MDT);
            deepBookManager = new DeepBookManager(ibClient, deepBookGrid);
            historicalDataManagers.Add(new HistoricalDataManager(0, ibClient, dataChartDaily)); // Daily histoy
            historicalDataManagers.Add(new HistoricalDataManager(1, ibClient, dataChart1M)); // Intraday (1min) history
            realTimeBarManager = new RealTimeBarsManager(0, ibClient, dataChartDaily, rtBarsGrid);
            scannerManager = new ScannerManager(ibClient, scannerGrid);
            orderManager = new OrderManager(ibClient, liveOrdersGrid, tradeLogGrid);
            accountManager = new AccountManager(ibClient, accountSelector, accSummaryGrid, accountValuesGrid, accountPortfolioGrid, positionsGrid);
            contractManager = new ContractManager(ibClient, fundamentalsOutput, contractDetailsGrid);
            advisorManager = new AdvisorManager(ibClient, advisorAliasesGrid, advisorGroupsGrid, advisorProfilesGrid);
            optionsManager = new OptionsManager(ibClient, optionChainCallGrid, optionChainPutGrid, optionPositionsGrid);

            var chartsSyncManager = new ChartsSyncManager(historicalDataManagers);

            mdContractRight.Items.AddRange(ContractRight.GetAll());
            mdContractRight.SelectedIndex = 0;

            conDetRight.Items.AddRange(ContractRight.GetAll());
            conDetRight.SelectedIndex = 0;

            fundamentalsReportType.Items.AddRange(FundamentalsReport.GetAll());
            fundamentalsReportType.SelectedIndex = 0;

            this.groupMethod.DataSource = AllocationGroupMethod.GetAsData();
            this.groupMethod.ValueMember = "Value";
            this.groupMethod.DisplayMember = "Name";

            this.profileType.DataSource = AllocationProfileType.GetAsData();
            this.profileType.ValueMember = "Value";
            this.profileType.DisplayMember = "Name";

            // TODO: Added this to speed up debugging. Remove when ready to deploy.
            this.TabControl.SelectedTab = marketDataTab;
            this.marketData_MDT.SelectedTab = historicalDataTab;
            ConnectToTWS();
        }

       
        public bool IsConnected
        {
            get { return isConnected; }
            set { isConnected = value; }
        }

        //This is the "UI entry point" and as such will handle the UI update by another thread
        public void HandleMessage(IBMessage message)
        {
            if (this.InvokeRequired)
            {
                MessageHandlerDelegate callback = new MessageHandlerDelegate(HandleMessage);
                this.Invoke(callback, new object[] { message });
            }
            else
            {
                UpdateUI(message);
            }
        }

        private void UpdateUI(IBMessage message)
        {
            switch (message.Type)
            {
                case MessageType.ConnectionStatus:
                    {
                        ConnectionStatusMessage statusMessage = (ConnectionStatusMessage)message;
                        if (statusMessage.IsConnected)
                        {
                            status_CT.Text = "Connected! Your client Id: "+ibClient.ClientId;
                            connectButton.Text = "Disconnect";
                        }
                        else
                        {
                            status_CT.Text = "Disconnected...";
                            connectButton.Text = "Connect";
                        }
                        break;
                    }
                case MessageType.Error:
                    {
                        ErrorMessage error = (ErrorMessage)message;
                        ShowMessageOnPanel("Request " + error.RequestId + ", Code: " + error.ErrorCode + " - " + error.Message + "\r\n");
                        HandleErrorMessage(error);
                        break;
                    }
                case MessageType.TickOptionComputation:
                case MessageType.TickPrice:
                case MessageType.TickSize:
                    {
                        HandleTickMessage((MarketDataMessage)message);
                        break;
                    }
                case MessageType.MarketDepth:
                case MessageType.MarketDepthL2:
                    {
                        deepBookManager.UpdateUI(message);
                        break;
                    }
                case MessageType.HistoricalData:
                    {
                        var msg = (HistoricalDataMessage)message;
                        switch (msg.RequestId - HistoricalDataManager.HISTORICAL_ID_BASE)
                        {
                            case 0:                               
                                historicalDataManagers[0].UpdateUI(message);
                                break;                                
                            case 1:
                                historicalDataManagers[1].UpdateUI(message);
                                break;
                        }
                        break;
                    }
                        
                case MessageType.HistoricalDataEnd:
                    {
                        var msg = (HistoricalDataEndMessage)message;
                        switch (msg.RequestId - HistoricalDataManager.HISTORICAL_ID_BASE)
                        {
                            case 0:                               
                                historicalDataManagers[0].UpdateUI(message);
                                break;                                
                            case 1:
                                historicalDataManagers[1].UpdateUI(message);
                                break;
                        }
                        break;
                    }
                case MessageType.RealTimeBars:
                    {
                        realTimeBarManager.UpdateUI(message);
                        break;
                    }
                case MessageType.ScannerData:
                    {
                        scannerManager.UpdateUI(message);
                        break;
                    }
                case MessageType.OpenOrder:
                case MessageType.OpenOrderEnd:
                case MessageType.OrderStatus:
                case MessageType.ExecutionData:
                case MessageType.CommissionsReport:
                    {
                        orderManager.UpdateUI(message);
                        break;
                    }
                case MessageType.ManagedAccounts:
                    {
                        orderManager.ManagedAccounts = ((ManagedAccountsMessage)message).ManagedAccounts;
                        accountManager.ManagedAccounts = ((ManagedAccountsMessage)message).ManagedAccounts;
                        exerciseAccount.Items.AddRange(((ManagedAccountsMessage)message).ManagedAccounts.ToArray());
                        break;
                    }
                case MessageType.AccountSummaryEnd:
                    {
                        accSummaryRequest.Text = "Request";
                        accountManager.UpdateUI(message);
                        break;
                    }
                case MessageType.AccountDownloadEnd:
                    {
                        break;
                    }
                case MessageType.AccountUpdateTime:
                    {
                        accUpdatesLastUpdateValue.Text = ((UpdateAccountTimeMessage)message).Timestamp;
                        break;
                    }
                case MessageType.PortfolioValue:
                    {
                        accountManager.UpdateUI(message);
                        if (exerciseAccount.SelectedItem != null)
                            optionsManager.HandlePosition((UpdatePortfolioMessage)message);
                        break;
                    }
                case MessageType.AccountSummary:
                case MessageType.AccountValue:
                case MessageType.Position:
                case MessageType.PositionEnd:
                    {
                        accountManager.UpdateUI(message);
                        break;
                    }
                case MessageType.ContractDataEnd:
                    {
                        searchContractDetails.Enabled = true;
                        contractManager.UpdateUI(message);
                        break;
                    }
                case MessageType.ContractData:
                    {
                        HandleContractDataMessage((ContractDetailsMessage)message);
                        break;
                    }
                case MessageType.FundamentalData:
                    {
                        fundamentalsQueryButton.Enabled = true;
                        contractManager.UpdateUI(message);
                        break;
                    }
                case MessageType.ReceiveFA:
                    {
                        advisorManager.UpdateUI((AdvisorDataMessage)message);
                        break;
                    }
                default:
                    {
                        HandleMessage(new ErrorMessage(-1, -1, message.ToString()));
                        break;
                    }
            }
        }

        private void HandleTickMessage(MarketDataMessage tickMessage)
        {
            if (tickMessage.RequestId < OptionsManager.OPTIONS_ID_BASE)
            {
                marketDataManager.UpdateUI(tickMessage);
            }
            else
            {
                if (!queryOptionChain.Enabled)
                {
                    queryOptionChain.Enabled = true;
                }
                optionsManager.UpdateUI(tickMessage);
            }
           
        }

        private void HandleContractDataMessage(ContractDetailsMessage message)
        {
            if (message.RequestId > ContractManager.CONTRACT_ID_BASE && message.RequestId < OptionsManager.OPTIONS_ID_BASE)
            {
                contractManager.UpdateUI(message);
            }
            else if (message.RequestId >= OptionsManager.OPTIONS_ID_BASE)
            {
                optionsManager.UpdateUI(message);
            }
        }

        private void HandleErrorMessage(ErrorMessage message)
        {
            if (message.RequestId > MarketDataManager.TICK_ID_BASE && message.RequestId < DeepBookManager.TICK_ID_BASE)
                marketDataManager.NotifyError(message.RequestId);
            else if (message.RequestId > DeepBookManager.TICK_ID_BASE && message.RequestId < HistoricalDataManager.HISTORICAL_ID_BASE)
                deepBookManager.NotifyError(message.RequestId);
            else if (message.RequestId == ContractManager.CONTRACT_DETAILS_ID)
            {
                contractManager.HandleRequestError(message.RequestId);
                searchContractDetails.Enabled = true;
            }
            else if (message.RequestId == ContractManager.FUNDAMENTALS_ID)
            {
                contractManager.HandleRequestError(message.RequestId);
                fundamentalsQueryButton.Enabled = true;
            }
            else if (message.RequestId == OptionsManager.OPTIONS_ID_BASE)
            {
                optionsManager.Clear();
                queryOptionChain.Enabled = true;
            }
            else if (message.RequestId > OptionsManager.OPTIONS_ID_BASE)
            {
                queryOptionChain.Enabled = true;
            }
            if (message.ErrorCode == 202)
            {
            }
        }
               
        private void connectButton_Click(object sender, EventArgs e)
        {
            ConnectToTWS();           
        }

        private void ConnectToTWS()
        {
            if (!IsConnected)
            {
                int port;
                string host = this.host_CT.Text;

                if (host == null || host.Equals(""))
                    host = "127.0.0.1";
                try
                {
                    port = Int32.Parse(this.port_CT.Text);
                    ibClient.ClientId = Int32.Parse(this.clientid_CT.Text);
                    ibClient.ClientSocket.eConnect(host, port, ibClient.ClientId);
                }
                catch (Exception)
                {
                    HandleMessage(new ErrorMessage(-1, -1, "Please check your connection attributes."));
                }
            }
            else
            {
                IsConnected = false;
                ibClient.ClientSocket.eDisconnect();
            }
        }

        private void marketData_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                Contract contract = GetMDContract();
                string genericTickList = this.genericTickList.Text;
                if (genericTickList == null)
                    genericTickList = "";
                marketDataManager.AddRequest(contract, genericTickList);
                ShowTab(marketData_MDT, topMarketDataTab_MDT);
            }
        }

        private void closeMketDataTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            marketDataManager.StopActiveRequests(true);
            this.marketData_MDT.TabPages.Remove(topMarketDataTab_MDT);
        }

        private void deepBook_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                Contract contract = GetMDContract();
                deepBookManager.AddRequest(contract, Int32.Parse(deepBookEntries.Text));
                deepBookTab_MDT.Text = Utils.ContractToString(contract) + " (Book)";
                ShowTab(marketData_MDT, deepBookTab_MDT);
            }
        }

        private void closeDeepBookLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deepBookManager.StopActiveRequests();
            deepBookTab_MDT.Text = "";
            this.marketData_MDT.TabPages.Remove(deepBookTab_MDT);
        }

        private void histDataButton_Click(object sender, EventArgs e)
        {            
            if (isConnected)
            {
                Contract contract = GetMDContract();
                string endTime = hdRequest_EndTime.Text.Trim();
                string duration = hdRequest_Duration.Text.Trim() + " " + hdRequest_TimeUnit.Text.Trim();
                string barSize = hdRequest_BarSize.Text.Trim();
                string whatToShow = hdRequest_WhatToShow.Text.Trim();
                int outsideRTH = this.contractMDRTH.Checked ? 1 : 0;
                historicalDataManagers[0].AddRequest(contract, endTime, duration, barSize, whatToShow, outsideRTH, 1);
                historicalDataTab.Text = Utils.ContractToString(contract) + " (HD)";
                ShowTab(marketData_MDT, historicalDataTab);
            }
        }

        private void histDataTabClose_MDT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.marketData_MDT.TabPages.Remove(historicalDataTab);
        }

        private void realTime_Button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                Contract contract = GetMDContract();
                string whatToShow = hdRequest_WhatToShow.Text.Trim();
                realTimeBarManager.AddRequest(contract, whatToShow, true);
                rtBarsTab_MDT.Text = Utils.ContractToString(contract) + " (RTB)";
                ShowTab(marketData_MDT, rtBarsTab_MDT);
            }
        }
        
        private void rtBarsCloseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            realTimeBarManager.Clear();
            this.marketData_MDT.TabPages.Remove(rtBarsTab_MDT);
        }

        private void scannerRequest_Button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                ScannerSubscription subscription = new ScannerSubscription();
                subscription.ScanCode = scanCode.Text;
                subscription.Instrument = scanInstrument.Text;
                subscription.LocationCode = scanLocation.Text;
                subscription.StockTypeFilter = scanStockType.Text;
                subscription.NumberOfRows = Int32.Parse(scanNumRows.Text);
                scannerManager.AddRequest(subscription);
                ShowTab(marketData_MDT, scannerTab);
            }
        }
        private void scannerTab_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            scannerManager.Clear();
            marketData_MDT.TabPages.Remove(scannerTab);
        }

        private double stringToDouble(string number)
        {
            if (number != null && !number.Equals(""))
                return Double.Parse(number);
            else
                return 0;
        }

        private Contract GetMDContract()
        {   
            Contract contract = new Contract();
            contract.SecType = this.secType_TMD_MDT.Text;
            contract.Symbol = this.symbol_TMD_MDT.Text;
            contract.Exchange = this.exchange_TMD_MDT.Text;
            contract.Currency = this.currency_TMD_MDT.Text;
            contract.Expiry = this.expiry_TMD_MDT.Text;
            contract.PrimaryExch = this.primaryExchange.Text;
            contract.IncludeExpired = includeExpired.Checked;

            if (!mdContractRight.Text.Equals("") && !mdContractRight.Text.Equals("None"))
                contract.Right = (string)((IBType)mdContractRight.SelectedItem).Value;
            
            contract.Strike = stringToDouble(this.strike_TMD_MDT.Text);
            contract.Multiplier = this.multiplier_TMD_MDT.Text;
            contract.LocalSymbol = this.localSymbol_TMD_MDT.Text;

            return contract;
        }

        private void messageBoxClear_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            messageBox.Clear();
        }

        private void ShowTab(TabControl tabControl, TabPage page)
        {
            if (!tabControl.Contains(page))
            {
                tabControl.TabPages.Add(page);
            }
            tabControl.SelectedTab = page;
        }

        private void newOrderLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            orderManager.OpenOrderDialog();
        }

        private void refreshOrdersButton_Click(object sender, EventArgs e)
        {
            liveOrdersGrid.Rows.Clear();
            ibClient.ClientSocket.reqAllOpenOrders();
        }

        private void refreshExecutionsButton_Click(object sender, EventArgs e)
        {
            tradeLogGrid.Rows.Clear();
            ibClient.ClientSocket.reqExecutions(1, new ExecutionFilter());
        }

        private void bindOrdersButton_Click(object sender, EventArgs e)
        {
            ibClient.ClientSocket.reqAutoOpenOrders(true);
        }

        private void liveOrdersGrid_CellCoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            orderManager.EditOrder();
        }

        private void cancelOrdersButton_Click(object sender, EventArgs e)
        {
            orderManager.CancelSelection();
            liveOrdersGrid.Rows.Clear();
            ibClient.ClientSocket.reqAllOpenOrders();
        }

        private void clientOrdersButton_Click(object sender, EventArgs e)
        {
            liveOrdersGrid.Rows.Clear();
            ibClient.ClientSocket.reqOpenOrders();
        }

        private void globalCancelButton_Click(object sender, EventArgs e)
        {
            ibClient.ClientSocket.reqGlobalCancel();
        }

        private void accSummaryRequest_Click(object sender, EventArgs e)
        {
            accSummaryRequest.Text = "Cancel";
            accountManager.RequestAccountSummary();
        }

        private void accUpdatesSubscribe_Click(object sender, EventArgs e)
        {
            if(accUpdatesSubscribe.Text.Equals("Subscribe"))
            {
                accUpdatesSubscribedAccount.Text = accountSelector.SelectedItem.ToString();
                accUpdatesSubscribe.Text = "Unsubscribe";
            }
            else
            {
                accUpdatesSubscribe.Text = "Subscribe";
            }
            accountManager.SubscribeAccountUpdates();
        }

        private void positionRequest_Click(object sender, EventArgs e)
        {
            accountManager.RequestPositions();
        }

        private void searchContractDetails_Click(object sender, EventArgs e)
        {
            ShowTab(contractInfoTab, contractDetailsPage);
            Contract contract = GetConDetContract();
            searchContractDetails.Enabled = false;
            contractManager.RequestContractDetails(contract);
        }

        private Contract GetConDetContract()
        {
            Contract contract = new Contract();
            contract.Symbol = this.conDetSymbol.Text;
            contract.SecType = this.conDetSecType.Text;
            contract.Exchange = this.conDetExchange.Text;
            contract.Currency = this.conDetCurrency.Text;
            contract.Expiry = this.conDetExpiry.Text;
            contract.Strike = stringToDouble(this.conDetStrike.Text);
            contract.Multiplier = this.conDetMultiplier.Text;
            contract.LocalSymbol = this.conDetLocalSymbol.Text;

            if (!conDetRight.Text.Equals("") && !conDetRight.Text.Equals("None"))
                contract.Right = (string)((IBType)conDetRight.SelectedItem).Value;

            return contract;
        }

        private void fundamentalsQueryButton_Click(object sender, EventArgs e)
        {
            ShowTab(contractInfoTab, fundamentalsPage);
            fundamentalsQueryButton.Enabled = false;
            Contract contract = GetConDetContract();
            contractManager.RequestFundamentals(contract, (string)((IBType)fundamentalsReportType.SelectedItem).Value);
        }

        private void loadAliases_Click(object sender, EventArgs e)
        {
            advisorAliasesGrid.Rows.Clear();
            advisorManager.RequestFAData(FinancialAdvisorDataType.Aliases);
        }

        private void loadGroups_Click(object sender, EventArgs e)
        {
            advisorGroupsGrid.Rows.Clear();
            advisorManager.RequestFAData(FinancialAdvisorDataType.Groups);
        }

        private void loadProfiles_Click(object sender, EventArgs e)
        {
            advisorProfilesGrid.Rows.Clear();
            advisorManager.RequestFAData(FinancialAdvisorDataType.Profiles);
        }

        private void saveProfiles_Click(object sender, EventArgs e)
        {
            advisorManager.SaveProfiles();
        }

        private void saveGroups_Click(object sender, EventArgs e)
        {
            advisorManager.SaveGroups();
        }

        private void findComboContract_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contractManager.IsComboLegRequest = true;
            contractManager.RequestContractDetails(GetComboContract());
        }

        private Contract GetComboContract()
        {
            Contract contract = new Contract();
            contract.Symbol = this.comboSymbol.Text;
            contract.SecType = this.comboSecType.Text;
            contract.Exchange = this.comboExchange.Text;
            contract.Currency = this.comboCurrency.Text;
            contract.Expiry = this.comboExpiry.Text;
            contract.Strike = stringToDouble(this.comboStrike.Text);
            contract.Multiplier = this.comboMultiplier.Text;
            contract.LocalSymbol = this.comboLocalSymbol.Text;

            if (!comboRight.Text.Equals("") && !comboRight.Text.Equals("None"))
                contract.Right = (string)((IBType)comboRight.SelectedItem).Value;

            return contract;
        }

        private void queryOptionChain_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                queryOptionChain.Enabled = false;
                Contract underlying = GetConDetContract();
                underlying.SecType = "OPT";
                optionsManager.AddOptionChainRequest(underlying, this.optionChainExchange.Text, optionChainUseSnapshot.Checked);
                ShowTab(contractInfoTab, optionChainPage);
               
            }
        }

        private void exerciseAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountSelector.SelectedItem = exerciseAccount.SelectedItem;
            accountManager.SubscribeAccountUpdates();
        }

        private void ShowMessageOnPanel(string message)
        {
            this.messageBox.Text += (message);
            messageBox.Select(messageBox.Text.Length, 0);
            messageBox.ScrollToCaret();
        }

        private void cancelMarketDataRequests_Click(object sender, EventArgs e)
        {
            marketDataManager.StopActiveRequests(false);
        }

        private void exerciseOption_Click(object sender, EventArgs e)
        {
            int ovrd = overrideOption.Checked == true ? 1 : 0;
            string exchange = optionExchange.Text;
            optionsManager.ExerciseOptions(ovrd, Int32.Parse(optionExerciseQuan.Text), exchange, 1);
        }

        private void lapseOption_Click(object sender, EventArgs e)
        {
            int ovrd = overrideOption.Checked == true ? 1 : 0;
            string exchange = optionExchange.Text;
            optionsManager.ExerciseOptions(ovrd, Int32.Parse(optionExerciseQuan.Text), exchange, 2);
        }

        private void optionsTab_Click(object sender, EventArgs e)
        {

        }

 
        private void histData_1M_Button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                Contract contract = GetMDContract();
                var endDate = DateTime.Now;

                string duration = hdRequest_Duration.Text.Trim() + " " + hdRequest_TimeUnit.Text.Trim();
                
                string barSize = hdRequest_BarSize.Text.Trim();
                barSize = String.Concat("_", barSize.Replace(" ", "_"));
                var barSizeType = (BarSizeType)Enum.Parse(typeof(BarSizeType), barSize);
                
                int useRTH = this.contractMDRTH.Checked ? 1 : 0;
                

                AddRequest(historicalDataManagers[0], endDate, duration, barSizeType, 1);
                AddRequest(historicalDataManagers[1], endDate, "1 D", BarSizeType._1_min, useRTH);

                historicalDataTab.Text = Utils.ContractToString(contract) + " (HD)";
                ShowTab(marketData_MDT, historicalDataTab);
            }
        }

        private void DataChart_DoubleClick(object sender, MouseEventArgs e)
        {
            var dataChart = (DataChart)sender;

            DateTime date;
            var dateText = dataChart.XLabelText;

            if (DateTime.TryParse(dateText, out date))
            {
                var rth = this.contractMDRTH.Checked ? 1 : 0;
                AddRequest(historicalDataManagers[1], date, "1 D", BarSizeType._1_min, rth);
            }
        }

        private void AddRequest(HistoricalDataManager dataManager, DateTime endDate, string duration, BarSizeType barSizeType, int useRTH)
        {
            Contract contract = GetMDContract();
            var endDateTime = endDate.ToString("yyyyMMdd") + " 23:59:59 GMT";
            dataManager.AddRequest(contract, endDateTime, duration, barSizeType, "MIDPOINT", useRTH, 1);

        }



    }
}
