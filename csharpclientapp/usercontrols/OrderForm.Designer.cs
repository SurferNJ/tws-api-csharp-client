namespace CSharpClientApp.usercontrols
{
    partial class OrderForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkOrder = new System.Windows.Forms.CheckBox();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.chkLimitOrder = new System.Windows.Forms.CheckBox();
            this.buttonOffsetDecrease = new System.Windows.Forms.Button();
            this.lblTriggerPriceLabel = new System.Windows.Forms.Label();
            this.buttonOffsetIncrease = new System.Windows.Forms.Button();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.lblOffsetLabel = new System.Windows.Forms.Label();
            this.txtLimitPrice = new System.Windows.Forms.TextBox();
            this.lblLimitPriceLabel = new System.Windows.Forms.Label();
            this.txtTriggerPrice = new System.Windows.Forms.TextBox();
            this.buttonQueueOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkOrder
            // 
            this.chkOrder.AutoSize = true;
            this.chkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrder.Location = new System.Drawing.Point(3, 3);
            this.chkOrder.Name = "chkOrder";
            this.chkOrder.Size = new System.Drawing.Size(61, 21);
            this.chkOrder.TabIndex = 60;
            this.chkOrder.Text = "BUY";
            this.chkOrder.UseVisualStyleBackColor = true;
            this.chkOrder.CheckedChanged += new System.EventHandler(this.chkOrder_CheckedChanged);
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Location = new System.Drawing.Point(3, 202);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(59, 30);
            this.buttonPlaceOrder.TabIndex = 58;
            this.buttonPlaceOrder.Text = "Place";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // chkLimitOrder
            // 
            this.chkLimitOrder.AutoSize = true;
            this.chkLimitOrder.Location = new System.Drawing.Point(3, 30);
            this.chkLimitOrder.Name = "chkLimitOrder";
            this.chkLimitOrder.Size = new System.Drawing.Size(100, 21);
            this.chkLimitOrder.TabIndex = 57;
            this.chkLimitOrder.Text = "Limit Order";
            this.chkLimitOrder.UseVisualStyleBackColor = true;
            // 
            // buttonOffsetDecrease
            // 
            this.buttonOffsetDecrease.Location = new System.Drawing.Point(24, 119);
            this.buttonOffsetDecrease.Name = "buttonOffsetDecrease";
            this.buttonOffsetDecrease.Size = new System.Drawing.Size(23, 22);
            this.buttonOffsetDecrease.TabIndex = 54;
            this.buttonOffsetDecrease.Text = "-";
            this.buttonOffsetDecrease.UseVisualStyleBackColor = true;
            this.buttonOffsetDecrease.Click += new System.EventHandler(this.buttonOffsetDecrease_Click);
            // 
            // lblTriggerPriceLabel
            // 
            this.lblTriggerPriceLabel.AutoSize = true;
            this.lblTriggerPriceLabel.Location = new System.Drawing.Point(0, 54);
            this.lblTriggerPriceLabel.Name = "lblTriggerPriceLabel";
            this.lblTriggerPriceLabel.Size = new System.Drawing.Size(90, 17);
            this.lblTriggerPriceLabel.TabIndex = 47;
            this.lblTriggerPriceLabel.Text = "Trigger Price";
            // 
            // buttonOffsetIncrease
            // 
            this.buttonOffsetIncrease.Location = new System.Drawing.Point(94, 119);
            this.buttonOffsetIncrease.Name = "buttonOffsetIncrease";
            this.buttonOffsetIncrease.Size = new System.Drawing.Size(23, 22);
            this.buttonOffsetIncrease.TabIndex = 53;
            this.buttonOffsetIncrease.Text = "+";
            this.buttonOffsetIncrease.UseVisualStyleBackColor = true;
            this.buttonOffsetIncrease.Click += new System.EventHandler(this.buttonOffsetIncrease_Click);
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(53, 119);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(35, 22);
            this.txtOffset.TabIndex = 52;
            this.txtOffset.Text = "1";
            this.txtOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOffsetLabel
            // 
            this.lblOffsetLabel.AutoSize = true;
            this.lblOffsetLabel.Location = new System.Drawing.Point(3, 99);
            this.lblOffsetLabel.Name = "lblOffsetLabel";
            this.lblOffsetLabel.Size = new System.Drawing.Size(67, 17);
            this.lblOffsetLabel.TabIndex = 51;
            this.lblOffsetLabel.Text = "+/- Offset";
            // 
            // txtLimitPrice
            // 
            this.txtLimitPrice.Location = new System.Drawing.Point(30, 164);
            this.txtLimitPrice.Name = "txtLimitPrice";
            this.txtLimitPrice.Size = new System.Drawing.Size(73, 22);
            this.txtLimitPrice.TabIndex = 50;
            // 
            // lblLimitPriceLabel
            // 
            this.lblLimitPriceLabel.AutoSize = true;
            this.lblLimitPriceLabel.Location = new System.Drawing.Point(3, 144);
            this.lblLimitPriceLabel.Name = "lblLimitPriceLabel";
            this.lblLimitPriceLabel.Size = new System.Drawing.Size(73, 17);
            this.lblLimitPriceLabel.TabIndex = 49;
            this.lblLimitPriceLabel.Text = "Limit Price";
            // 
            // txtTriggerPrice
            // 
            this.txtTriggerPrice.Location = new System.Drawing.Point(31, 74);
            this.txtTriggerPrice.Name = "txtTriggerPrice";
            this.txtTriggerPrice.Size = new System.Drawing.Size(73, 22);
            this.txtTriggerPrice.TabIndex = 48;
            // 
            // buttonQueueOrder
            // 
            this.buttonQueueOrder.Location = new System.Drawing.Point(68, 202);
            this.buttonQueueOrder.Name = "buttonQueueOrder";
            this.buttonQueueOrder.Size = new System.Drawing.Size(59, 29);
            this.buttonQueueOrder.TabIndex = 59;
            this.buttonQueueOrder.Text = "Queue";
            this.buttonQueueOrder.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkOrder);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.chkLimitOrder);
            this.Controls.Add(this.buttonOffsetDecrease);
            this.Controls.Add(this.lblTriggerPriceLabel);
            this.Controls.Add(this.buttonOffsetIncrease);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.lblOffsetLabel);
            this.Controls.Add(this.txtLimitPrice);
            this.Controls.Add(this.lblLimitPriceLabel);
            this.Controls.Add(this.txtTriggerPrice);
            this.Controls.Add(this.buttonQueueOrder);
            this.Name = "OrderForm";
            this.Size = new System.Drawing.Size(131, 235);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOrder;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.CheckBox chkLimitOrder;
        private System.Windows.Forms.Button buttonOffsetDecrease;
        private System.Windows.Forms.Label lblTriggerPriceLabel;
        private System.Windows.Forms.Button buttonOffsetIncrease;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label lblOffsetLabel;
        private System.Windows.Forms.TextBox txtLimitPrice;
        private System.Windows.Forms.Label lblLimitPriceLabel;
        private System.Windows.Forms.TextBox txtTriggerPrice;
        private System.Windows.Forms.Button buttonQueueOrder;
    }
}
