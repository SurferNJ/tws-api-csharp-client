﻿/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IBApi;

namespace IBSampleApp.ui
{
    public abstract class DataManager
    {
        protected Control uiControl;
        protected IBClient ibClient;
        protected int currentTicker = 1;

        protected delegate void UpdateUICallback(IBMessage msg);

        public DataManager(IBClient client, Control dataGrid)
        {
            ibClient = client;
            uiControl = dataGrid;
        }
        
        public abstract void NotifyError(int requestId);
        
        public abstract void Clear();

        public abstract void UpdateUI(IBMessage message);

    }
}
