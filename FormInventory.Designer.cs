
namespace UDPojok
{
    partial class FormInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventory));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCashier = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTransactionHistory = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.buttonTransactionHistory);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonCashier);
            this.panel2.Controls.Add(this.buttonInventory);
            this.panel2.Controls.Add(this.buttonPurchase);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 609);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::UDPojok.Properties.Resources.logo_udpojok;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCashier
            // 
            this.buttonCashier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCashier.FlatAppearance.BorderSize = 0;
            this.buttonCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCashier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCashier.Image = ((System.Drawing.Image)(resources.GetObject("buttonCashier.Image")));
            this.buttonCashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCashier.Location = new System.Drawing.Point(-7, 152);
            this.buttonCashier.Name = "buttonCashier";
            this.buttonCashier.Padding = new System.Windows.Forms.Padding(16, 0, 40, 0);
            this.buttonCashier.Size = new System.Drawing.Size(165, 62);
            this.buttonCashier.TabIndex = 3;
            this.buttonCashier.Text = "Cashier";
            this.buttonCashier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCashier.UseCompatibleTextRendering = true;
            this.buttonCashier.UseVisualStyleBackColor = false;
            this.buttonCashier.Click += new System.EventHandler(this.buttonCashier_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInventory.FlatAppearance.BorderSize = 0;
            this.buttonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonInventory.Image = global::UDPojok.Properties.Resources.stock_32px;
            this.buttonInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventory.Location = new System.Drawing.Point(-7, 276);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Padding = new System.Windows.Forms.Padding(16, 0, 30, 0);
            this.buttonInventory.Size = new System.Drawing.Size(165, 62);
            this.buttonInventory.TabIndex = 4;
            this.buttonInventory.Text = "Inventory";
            this.buttonInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInventory.UseCompatibleTextRendering = true;
            this.buttonInventory.UseVisualStyleBackColor = false;
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPurchase.FlatAppearance.BorderSize = 0;
            this.buttonPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPurchase.Image = global::UDPojok.Properties.Resources.product_32px;
            this.buttonPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPurchase.Location = new System.Drawing.Point(-7, 214);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Padding = new System.Windows.Forms.Padding(16, 0, 30, 0);
            this.buttonPurchase.Size = new System.Drawing.Size(165, 62);
            this.buttonPurchase.TabIndex = 5;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPurchase.UseCompatibleTextRendering = true;
            this.buttonPurchase.UseVisualStyleBackColor = false;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(183, 63);
            this.dataGridViewProduct.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(781, 552);
            this.dataGridViewProduct.TabIndex = 8;
            this.dataGridViewProduct.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProduct_RowHeaderMouseDoubleClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(844, 17);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 28);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add New Product";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(826, 61);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonTransactionHistory
            // 
            this.buttonTransactionHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTransactionHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransactionHistory.FlatAppearance.BorderSize = 0;
            this.buttonTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTransactionHistory.Image = global::UDPojok.Properties.Resources.transaction_32px;
            this.buttonTransactionHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTransactionHistory.Location = new System.Drawing.Point(-7, 338);
            this.buttonTransactionHistory.Name = "buttonTransactionHistory";
            this.buttonTransactionHistory.Padding = new System.Windows.Forms.Padding(16, 0, 17, 0);
            this.buttonTransactionHistory.Size = new System.Drawing.Size(165, 62);
            this.buttonTransactionHistory.TabIndex = 7;
            this.buttonTransactionHistory.Text = "Transaction";
            this.buttonTransactionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTransactionHistory.UseCompatibleTextRendering = true;
            this.buttonTransactionHistory.UseVisualStyleBackColor = false;
            this.buttonTransactionHistory.Click += new System.EventHandler(this.buttonTransactionHistory_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 609);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCashier;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTransactionHistory;
    }
}