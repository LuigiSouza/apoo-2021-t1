namespace apoo_2021_t1.src.gui
{
    partial class AdminForm
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
            this.flowLayoutOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.refresh = new System.Windows.Forms.Button();
            this.orderDetails = new apoo_2021_t1.src.gui.components.OrderDetailsControl(this.switchShow);
            this.SuspendLayout();
            // 
            // flowLayoutOrders
            // 
            this.flowLayoutOrders.AutoScroll = true;
            this.flowLayoutOrders.Location = new System.Drawing.Point(12, 25);
            this.flowLayoutOrders.Name = "flowLayoutOrders";
            this.flowLayoutOrders.Size = new System.Drawing.Size(705, 340);
            this.flowLayoutOrders.TabIndex = 0;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(12, 371);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 1;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // orderDetails
            // 
            this.orderDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderDetails.Id = 0;
            this.orderDetails.Location = new System.Drawing.Point(12, 25);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Price = 0F;
            this.orderDetails.Size = new System.Drawing.Size(705, 369);
            this.orderDetails.Status = null;
            this.orderDetails.TabIndex = 2;
            this.orderDetails.Load += new System.EventHandler(this.orderDetails_Load);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.orderDetails);
            this.Controls.Add(this.flowLayoutOrders);
            this.Controls.Add(this.refresh);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutOrders;
        private System.Windows.Forms.Button refresh;
        private components.OrderDetailsControl orderDetails;
    }
}