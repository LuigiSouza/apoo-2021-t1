
namespace apoo_2021_t1.src.gui
{
    partial class ClienteForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mainBtn = new System.Windows.Forms.Button();
            this.oderbtn = new System.Windows.Forms.Button();
            this.finishCart = new System.Windows.Forms.Button();
            this.clearCart = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.orderDetails = new apoo_2021_t1.src.gui.components.OrderDetailsControl(this.switchShow);
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(155, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(633, 343);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // mainBtn
            // 
            this.mainBtn.Location = new System.Drawing.Point(12, 12);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(137, 45);
            this.mainBtn.TabIndex = 0;
            this.mainBtn.Text = "Principal";
            this.mainBtn.UseVisualStyleBackColor = true;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // oderbtn
            // 
            this.oderbtn.Location = new System.Drawing.Point(12, 72);
            this.oderbtn.Name = "oderbtn";
            this.oderbtn.Size = new System.Drawing.Size(137, 45);
            this.oderbtn.TabIndex = 1;
            this.oderbtn.Text = "Pedidos";
            this.oderbtn.UseVisualStyleBackColor = true;
            this.oderbtn.Click += new System.EventHandler(this.oderbtn_Click);
            // 
            // finishCart
            // 
            this.finishCart.Location = new System.Drawing.Point(397, 361);
            this.finishCart.Name = "finishCart";
            this.finishCart.Size = new System.Drawing.Size(137, 45);
            this.finishCart.TabIndex = 2;
            this.finishCart.Text = "Pedir";
            this.finishCart.UseVisualStyleBackColor = true;
            this.finishCart.Click += new System.EventHandler(this.finishCart_Click);
            // 
            // clearCart
            // 
            this.clearCart.Location = new System.Drawing.Point(254, 361);
            this.clearCart.Name = "clearCart";
            this.clearCart.Size = new System.Drawing.Size(137, 45);
            this.clearCart.TabIndex = 3;
            this.clearCart.Text = "Zerar";
            this.clearCart.UseVisualStyleBackColor = true;
            this.clearCart.Click += new System.EventHandler(this.clearCart_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(540, 368);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(65, 26);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(611, 368);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(70, 26);
            this.total.TabIndex = 5;
            this.total.Text = "R$ 00";
            // 
            // orderDetails
            // 
            this.orderDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderDetails.Id = 0;
            this.orderDetails.Location = new System.Drawing.Point(155, 12);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Price = 0F;
            this.orderDetails.Size = new System.Drawing.Size(633, 426);
            this.orderDetails.Status = null;
            this.orderDetails.TabIndex = 6;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderDetails);
            this.Controls.Add(this.total);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.clearCart);
            this.Controls.Add(this.finishCart);
            this.Controls.Add(this.oderbtn);
            this.Controls.Add(this.mainBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ClienteForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.Button oderbtn;
        private System.Windows.Forms.Button finishCart;
        private System.Windows.Forms.Button clearCart;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label total;
        private components.OrderDetailsControl orderDetails;
    }
}