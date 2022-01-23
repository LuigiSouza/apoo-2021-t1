
namespace apoo_2021_t1.src.gui.components
{
    partial class ItemControl
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
            this.title = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ControlLight;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(38, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(45, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Title";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.SystemColors.ControlLight;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(44, 76);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(39, 17);
            this.price.TabIndex = 1;
            this.price.Text = "price";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.quantity.Location = new System.Drawing.Point(466, 63);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(25, 13);
            this.quantity.TabIndex = 2;
            this.quantity.Text = "142";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(497, 58);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(385, 58);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(75, 23);
            this.minBtn.TabIndex = 4;
            this.minBtn.Text = "-";
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 135);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.minBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.price);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(608, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        public System.Windows.Forms.Button addBtn;
        public System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
