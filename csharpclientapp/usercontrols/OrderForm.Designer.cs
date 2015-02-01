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
            this.chkLimitOrder = new System.Windows.Forms.CheckBox();
            this.buttonOffsetDecrease = new System.Windows.Forms.Button();
            this.lblTargetPrice = new System.Windows.Forms.Label();
            this.buttonOffsetIncrease = new System.Windows.Forms.Button();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.txtLimitPrice = new System.Windows.Forms.TextBox();
            this.buttonQueueSelected = new System.Windows.Forms.Button();
            this.checkTarget = new System.Windows.Forms.CheckBox();
            this.txtTargetNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonSuggestTarget = new System.Windows.Forms.Button();
            this.buttonSendTarget = new System.Windows.Forms.Button();
            this.buttonTargetCancel = new System.Windows.Forms.Button();
            this.buttonCencelStop = new System.Windows.Forms.Button();
            this.buttonSendStop = new System.Windows.Forms.Button();
            this.buttonSuggestStop = new System.Windows.Forms.Button();
            this.checkStop = new System.Windows.Forms.CheckBox();
            this.txtStopNew = new System.Windows.Forms.TextBox();
            this.labelStop = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSendSelected = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.checkTriggerPrice = new System.Windows.Forms.CheckBox();
            this.txtTriggerPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // chkLimitOrder
            // 
            this.chkLimitOrder.AutoSize = true;
            this.chkLimitOrder.Location = new System.Drawing.Point(6, 144);
            this.chkLimitOrder.Name = "chkLimitOrder";
            this.chkLimitOrder.Size = new System.Drawing.Size(95, 21);
            this.chkLimitOrder.TabIndex = 57;
            this.chkLimitOrder.Text = "Limit Price";
            this.chkLimitOrder.UseVisualStyleBackColor = true;
            // 
            // buttonOffsetDecrease
            // 
            this.buttonOffsetDecrease.Location = new System.Drawing.Point(41, 118);
            this.buttonOffsetDecrease.Name = "buttonOffsetDecrease";
            this.buttonOffsetDecrease.Size = new System.Drawing.Size(23, 22);
            this.buttonOffsetDecrease.TabIndex = 54;
            this.buttonOffsetDecrease.Text = "-";
            this.buttonOffsetDecrease.UseVisualStyleBackColor = true;
            this.buttonOffsetDecrease.Click += new System.EventHandler(this.buttonOffsetDecrease_Click);
            // 
            // lblTargetPrice
            // 
            this.lblTargetPrice.AutoSize = true;
            this.lblTargetPrice.Location = new System.Drawing.Point(243, 142);
            this.lblTargetPrice.Name = "lblTargetPrice";
            this.lblTargetPrice.Size = new System.Drawing.Size(31, 17);
            this.lblTargetPrice.TabIndex = 47;
            this.lblTargetPrice.Text = "N/A";
            // 
            // buttonOffsetIncrease
            // 
            this.buttonOffsetIncrease.Location = new System.Drawing.Point(111, 118);
            this.buttonOffsetIncrease.Name = "buttonOffsetIncrease";
            this.buttonOffsetIncrease.Size = new System.Drawing.Size(23, 22);
            this.buttonOffsetIncrease.TabIndex = 53;
            this.buttonOffsetIncrease.Text = "+";
            this.buttonOffsetIncrease.UseVisualStyleBackColor = true;
            this.buttonOffsetIncrease.Click += new System.EventHandler(this.buttonOffsetIncrease_Click);
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(70, 118);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(35, 22);
            this.txtOffset.TabIndex = 52;
            this.txtOffset.Text = "1";
            this.txtOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLimitPrice
            // 
            this.txtLimitPrice.Location = new System.Drawing.Point(45, 172);
            this.txtLimitPrice.Name = "txtLimitPrice";
            this.txtLimitPrice.Size = new System.Drawing.Size(73, 22);
            this.txtLimitPrice.TabIndex = 50;
            // 
            // buttonQueueSelected
            // 
            this.buttonQueueSelected.Location = new System.Drawing.Point(6, 236);
            this.buttonQueueSelected.Name = "buttonQueueSelected";
            this.buttonQueueSelected.Size = new System.Drawing.Size(164, 28);
            this.buttonQueueSelected.TabIndex = 59;
            this.buttonQueueSelected.Text = "Queue Selected";
            this.buttonQueueSelected.UseVisualStyleBackColor = true;
            // 
            // checkTarget
            // 
            this.checkTarget.AutoSize = true;
            this.checkTarget.Location = new System.Drawing.Point(142, 118);
            this.checkTarget.Name = "checkTarget";
            this.checkTarget.Size = new System.Drawing.Size(72, 21);
            this.checkTarget.TabIndex = 62;
            this.checkTarget.Text = "Target";
            this.checkTarget.UseVisualStyleBackColor = true;
            // 
            // txtTargetNew
            // 
            this.txtTargetNew.Location = new System.Drawing.Point(142, 142);
            this.txtTargetNew.Name = "txtTargetNew";
            this.txtTargetNew.Size = new System.Drawing.Size(73, 22);
            this.txtTargetNew.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Status:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(176, 4);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(97, 17);
            this.labelStatus.TabIndex = 67;
            this.labelStatus.Text = "Not Submitted";
            // 
            // buttonSuggestTarget
            // 
            this.buttonSuggestTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuggestTarget.Location = new System.Drawing.Point(214, 118);
            this.buttonSuggestTarget.Name = "buttonSuggestTarget";
            this.buttonSuggestTarget.Size = new System.Drawing.Size(60, 21);
            this.buttonSuggestTarget.TabIndex = 68;
            this.buttonSuggestTarget.Text = "Suggest";
            this.buttonSuggestTarget.UseVisualStyleBackColor = true;
            // 
            // buttonSendTarget
            // 
            this.buttonSendTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendTarget.Location = new System.Drawing.Point(142, 170);
            this.buttonSendTarget.Name = "buttonSendTarget";
            this.buttonSendTarget.Size = new System.Drawing.Size(69, 24);
            this.buttonSendTarget.TabIndex = 70;
            this.buttonSendTarget.Text = "Replace";
            this.buttonSendTarget.UseVisualStyleBackColor = true;
            // 
            // buttonTargetCancel
            // 
            this.buttonTargetCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTargetCancel.Location = new System.Drawing.Point(211, 170);
            this.buttonTargetCancel.Name = "buttonTargetCancel";
            this.buttonTargetCancel.Size = new System.Drawing.Size(63, 24);
            this.buttonTargetCancel.TabIndex = 71;
            this.buttonTargetCancel.Text = "Cancel";
            this.buttonTargetCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCencelStop
            // 
            this.buttonCencelStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCencelStop.Location = new System.Drawing.Point(210, 82);
            this.buttonCencelStop.Name = "buttonCencelStop";
            this.buttonCencelStop.Size = new System.Drawing.Size(63, 24);
            this.buttonCencelStop.TabIndex = 78;
            this.buttonCencelStop.Text = "Cancel";
            this.buttonCencelStop.UseVisualStyleBackColor = true;
            // 
            // buttonSendStop
            // 
            this.buttonSendStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendStop.Location = new System.Drawing.Point(141, 82);
            this.buttonSendStop.Name = "buttonSendStop";
            this.buttonSendStop.Size = new System.Drawing.Size(69, 24);
            this.buttonSendStop.TabIndex = 77;
            this.buttonSendStop.Text = "Replace";
            this.buttonSendStop.UseVisualStyleBackColor = true;
            // 
            // buttonSuggestStop
            // 
            this.buttonSuggestStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuggestStop.Location = new System.Drawing.Point(213, 30);
            this.buttonSuggestStop.Name = "buttonSuggestStop";
            this.buttonSuggestStop.Size = new System.Drawing.Size(60, 21);
            this.buttonSuggestStop.TabIndex = 76;
            this.buttonSuggestStop.Text = "Suggest";
            this.buttonSuggestStop.UseVisualStyleBackColor = true;
            // 
            // checkStop
            // 
            this.checkStop.AutoSize = true;
            this.checkStop.Location = new System.Drawing.Point(141, 30);
            this.checkStop.Name = "checkStop";
            this.checkStop.Size = new System.Drawing.Size(59, 21);
            this.checkStop.TabIndex = 75;
            this.checkStop.Text = "Stop";
            this.checkStop.UseVisualStyleBackColor = true;
            // 
            // txtStopNew
            // 
            this.txtStopNew.Location = new System.Drawing.Point(141, 54);
            this.txtStopNew.Name = "txtStopNew";
            this.txtStopNew.Size = new System.Drawing.Size(73, 22);
            this.txtStopNew.TabIndex = 74;
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Location = new System.Drawing.Point(242, 54);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(31, 17);
            this.labelStop.TabIndex = 73;
            this.labelStop.Text = "N/A";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 63);
            this.button2.TabIndex = 82;
            this.button2.Text = "Clear Position";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonSendSelected
            // 
            this.buttonSendSelected.Location = new System.Drawing.Point(6, 202);
            this.buttonSendSelected.Name = "buttonSendSelected";
            this.buttonSendSelected.Size = new System.Drawing.Size(164, 28);
            this.buttonSendSelected.TabIndex = 80;
            this.buttonSendSelected.Text = "Send Selected";
            this.buttonSendSelected.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 24);
            this.button1.TabIndex = 88;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 24);
            this.button5.TabIndex = 87;
            this.button5.Text = "Replace";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(75, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 21);
            this.button6.TabIndex = 86;
            this.button6.Text = "Suggest";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // checkTriggerPrice
            // 
            this.checkTriggerPrice.AutoSize = true;
            this.checkTriggerPrice.Location = new System.Drawing.Point(3, 30);
            this.checkTriggerPrice.Name = "checkTriggerPrice";
            this.checkTriggerPrice.Size = new System.Drawing.Size(62, 21);
            this.checkTriggerPrice.TabIndex = 85;
            this.checkTriggerPrice.Text = "Price";
            this.checkTriggerPrice.UseVisualStyleBackColor = true;
            // 
            // txtTriggerPrice
            // 
            this.txtTriggerPrice.Location = new System.Drawing.Point(3, 54);
            this.txtTriggerPrice.Name = "txtTriggerPrice";
            this.txtTriggerPrice.Size = new System.Drawing.Size(73, 22);
            this.txtTriggerPrice.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Offset:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.checkTriggerPrice);
            this.Controls.Add(this.txtTriggerPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSendSelected);
            this.Controls.Add(this.buttonCencelStop);
            this.Controls.Add(this.buttonSendStop);
            this.Controls.Add(this.buttonSuggestStop);
            this.Controls.Add(this.checkStop);
            this.Controls.Add(this.txtStopNew);
            this.Controls.Add(this.labelStop);
            this.Controls.Add(this.buttonTargetCancel);
            this.Controls.Add(this.buttonSendTarget);
            this.Controls.Add(this.buttonSuggestTarget);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkTarget);
            this.Controls.Add(this.txtTargetNew);
            this.Controls.Add(this.chkOrder);
            this.Controls.Add(this.chkLimitOrder);
            this.Controls.Add(this.buttonOffsetDecrease);
            this.Controls.Add(this.lblTargetPrice);
            this.Controls.Add(this.buttonOffsetIncrease);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.txtLimitPrice);
            this.Controls.Add(this.buttonQueueSelected);
            this.Controls.Add(this.label3);
            this.Name = "OrderForm";
            this.Size = new System.Drawing.Size(279, 269);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOrder;
        private System.Windows.Forms.CheckBox chkLimitOrder;
        private System.Windows.Forms.Button buttonOffsetDecrease;
        private System.Windows.Forms.Label lblTargetPrice;
        private System.Windows.Forms.Button buttonOffsetIncrease;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.TextBox txtLimitPrice;
        private System.Windows.Forms.Button buttonQueueSelected;
        private System.Windows.Forms.CheckBox checkTarget;
        private System.Windows.Forms.TextBox txtTargetNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonSuggestTarget;
        private System.Windows.Forms.Button buttonSendTarget;
        private System.Windows.Forms.Button buttonTargetCancel;
        private System.Windows.Forms.Button buttonCencelStop;
        private System.Windows.Forms.Button buttonSendStop;
        private System.Windows.Forms.Button buttonSuggestStop;
        private System.Windows.Forms.CheckBox checkStop;
        private System.Windows.Forms.TextBox txtStopNew;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSendSelected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkTriggerPrice;
        private System.Windows.Forms.TextBox txtTriggerPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
