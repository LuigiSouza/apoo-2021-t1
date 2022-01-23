
namespace apoo_2021_t1.src.gui.components
{
    partial class OrderControl
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
            this.price = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.expand = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.SystemColors.ControlLight;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(395, 76);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(39, 17);
            this.price.TabIndex = 7;
            this.price.Text = "price";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(110, 52);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(25, 24);
            this.id.TabIndex = 6;
            this.id.Text = "Id";
            this.id.Click += new System.EventHandler(this.title_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.expand);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.quantityLabel);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.totalLabel);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.id);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 135);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pedido:";
            // 
            // expand
            // 
            this.expand.Location = new System.Drawing.Point(525, 52);
            this.expand.Name = "expand";
            this.expand.Size = new System.Drawing.Size(75, 23);
            this.expand.TabIndex = 12;
            this.expand.Text = "Expandir";
            this.expand.UseVisualStyleBackColor = true;
            this.expand.Click += new System.EventHandler(this.expand_Click);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(395, 41);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(16, 17);
            this.quantity.TabIndex = 11;
            this.quantity.Text = "1";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(333, 35);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(59, 24);
            this.quantityLabel.TabIndex = 10;
            this.quantityLabel.Text = "Items:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.SystemColors.ControlLight;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(183, 52);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 24);
            this.status.TabIndex = 9;
            this.status.Text = "Status";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(333, 69);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 24);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total:";
            this.totalLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(660, 135);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button expand;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label1;
    }
}
