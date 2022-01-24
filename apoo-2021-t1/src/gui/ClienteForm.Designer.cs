
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.finishCart = new System.Windows.Forms.Button();
            this.clearCart = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Principal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pedidos";
            this.button2.UseVisualStyleBackColor = true;
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
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.total);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.clearCart);
            this.Controls.Add(this.finishCart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button finishCart;
        private System.Windows.Forms.Button clearCart;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label total;
    }
}