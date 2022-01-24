
namespace apoo_2021_t1.src.gui.components
{
    partial class OrderDetailsControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backBtn = new System.Windows.Forms.Button();
            this.rejectBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(699, 227);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(222, 310);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Voltar";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // rejectBtn
            // 
            this.rejectBtn.Location = new System.Drawing.Point(303, 310);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(75, 23);
            this.rejectBtn.TabIndex = 2;
            this.rejectBtn.Text = "Recusar";
            this.rejectBtn.UseVisualStyleBackColor = true;
            this.rejectBtn.Click += new System.EventHandler(this.rejectBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(384, 310);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 3;
            this.acceptBtn.Text = "Aceitar";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(177, 39);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 24);
            this.status.TabIndex = 9;
            this.status.Text = "Status";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(322, 39);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 24);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(381, 45);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(39, 17);
            this.price.TabIndex = 7;
            this.price.Text = "price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pedido:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(106, 39);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(25, 24);
            this.id.TabIndex = 14;
            this.id.Text = "Id";
            // 
            // OrderDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.rejectBtn);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.status);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "OrderDetailsControl";
            this.Size = new System.Drawing.Size(705, 393);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button rejectBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id;
    }
}
