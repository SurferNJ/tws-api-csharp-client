using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpClientApp.usercontrols
{
    public partial class OrderForm : UserControl
    {
        private OrderType _order;

        public OrderForm()
        {
            InitializeComponent();
        }

        #region Public Properties and Methods

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Gets and sets Type Of Order")]
        public OrderType Order
        {
            get { return _order; }
            set
            {
                _order = value;
                                
                chkOrder.Text = IsBuyOrder() ? "BUY" : "SELL";
                chkLimitOrder.Checked = (_order == OrderType.BUY_LMT || _order == OrderType.SELL_LMT) ? true : false;
            }
        }
                
        //[Category("Data")]
        //[Description("Gets and sets the Trigger Price Of Order")]
        //public double TriggerPrice
        //{
        //    get { return Double.Parse(txtTriggerPrice.Text); }
        //    set
        //    {
        //        txtTriggerPrice.Text = value.ToString("0.000");
        //    }
        //}

        public void SetTriggerPrice(OrderType orderType, double price)
        {
            chkOrder.Checked = true;
            this.Order = orderType;
            txtTriggerPrice.Text = price.ToString("0.000");

            SyncLimitPrice();
        }

        #endregion

        #region Private Methods

        private bool IsBuyOrder()
        {
            return (_order == OrderType.BUY || _order == OrderType.BUY_LMT);
        }

        private void chkLimitOrder_CheckedChanged(object sender, EventArgs e)
        {

            if (chkLimitOrder.Checked)
            {
                var offset = Double.Parse(txtOffset.Text) / 1000;
                if (!string.IsNullOrEmpty(txtTriggerPrice.Text))
                    if (Order == OrderType.BUY)
                        txtLimitPrice.Text = (Double.Parse(txtTriggerPrice.Text) + offset).ToString("0.000");
                    else if (Order == OrderType.SELL)
                        txtLimitPrice.Text = (Double.Parse(txtTriggerPrice.Text) - offset).ToString("0.000");
            }
            else
            {
                txtLimitPrice.Text = string.Empty;
            }
        }

        private void buttonOffsetIncrease_Click(object sender, EventArgs e)
        {
            var offset = Int32.Parse(txtOffset.Text);
            txtOffset.Text = (++offset).ToString("0");

            SyncLimitPrice();
        }

        private void buttonOffsetDecrease_Click(object sender, EventArgs e)
        {
            var offset = Int32.Parse(txtOffset.Text);

            if (offset == 0) return;

            txtOffset.Text = (--offset).ToString("0");

            SyncLimitPrice();
        }

        private void chkOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrder.Checked)
                SyncLimitPrice();
        }

        private void SyncLimitPrice()
        {
            if (chkLimitOrder.Checked)
            {
                var offset = Double.Parse(txtOffset.Text) / 1000;
                if (!string.IsNullOrEmpty(txtTriggerPrice.Text))
                    if (IsBuyOrder())
                        txtLimitPrice.Text = (Double.Parse(txtTriggerPrice.Text) + offset).ToString("0.000");
                    else 
                        txtLimitPrice.Text = (Double.Parse(txtTriggerPrice.Text) - offset).ToString("0.000");
            }
            else
            {
                txtLimitPrice.Text = string.Empty;
            }
        }

        #endregion        
    }

    public enum OrderType
    {
        BUY = 1,
        SELL = 2,
        BUY_LMT = 3,
        SELL_LMT = 4
    }
}
