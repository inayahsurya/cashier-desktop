
namespace UDPojok
{
    partial class FormTransactionHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransactionHistory));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCashier = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCashier = new System.Windows.Forms.Button();
            this.buttonTransactionHistory = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.buttonCashierHistory = new System.Windows.Forms.Button();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.buttonPurchaseHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashier)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            this.SuspendLayout();
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
            this.label1.TabIndex = 14;
            this.label1.Text = "Transaction History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewCashier
            // 
            this.dataGridViewCashier.AllowUserToAddRows = false;
            this.dataGridViewCashier.AllowUserToDeleteRows = false;
            this.dataGridViewCashier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCashier.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCashier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCashier.Location = new System.Drawing.Point(183, 102);
            this.dataGridViewCashier.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCashier.Name = "dataGridViewCashier";
            this.dataGridViewCashier.RowHeadersWidth = 51;
            this.dataGridViewCashier.RowTemplate.Height = 24;
            this.dataGridViewCashier.Size = new System.Drawing.Size(781, 498);
            this.dataGridViewCashier.TabIndex = 12;
            this.dataGridViewCashier.Visible = false;
            this.dataGridViewCashier.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCashier_RowHeaderMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonCashier);
            this.panel2.Controls.Add(this.buttonTransactionHistory);
            this.panel2.Controls.Add(this.buttonInventory);
            this.panel2.Controls.Add(this.buttonPurchase);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 611);
            this.panel2.TabIndex = 11;
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
            // buttonTransactionHistory
            // 
            this.buttonTransactionHistory.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.buttonTransactionHistory.TabIndex = 4;
            this.buttonTransactionHistory.Text = "Transaction";
            this.buttonTransactionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTransactionHistory.UseCompatibleTextRendering = true;
            this.buttonTransactionHistory.UseVisualStyleBackColor = false;
            this.buttonTransactionHistory.Click += new System.EventHandler(this.buttonTransactionHistory_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
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
            // buttonCashierHistory
            // 
            this.buttonCashierHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.buttonCashierHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCashierHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCashierHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCashierHistory.Location = new System.Drawing.Point(183, 64);
            this.buttonCashierHistory.Name = "buttonCashierHistory";
            this.buttonCashierHistory.Size = new System.Drawing.Size(121, 33);
            this.buttonCashierHistory.TabIndex = 15;
            this.buttonCashierHistory.Text = "Cashier History";
            this.buttonCashierHistory.UseVisualStyleBackColor = false;
            this.buttonCashierHistory.Click += new System.EventHandler(this.buttonCashierHistory_Click);
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.AllowUserToAddRows = false;
            this.dataGridViewPurchase.AllowUserToDeleteRows = false;
            this.dataGridViewPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPurchase.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Location = new System.Drawing.Point(183, 102);
            this.dataGridViewPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.RowHeadersWidth = 51;
            this.dataGridViewPurchase.RowTemplate.Height = 24;
            this.dataGridViewPurchase.Size = new System.Drawing.Size(781, 498);
            this.dataGridViewPurchase.TabIndex = 16;
            this.dataGridViewPurchase.Visible = false;
            this.dataGridViewPurchase.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPurchase_RowHeaderMouseDoubleClick);
            // 
            // buttonPurchaseHistory
            // 
            this.buttonPurchaseHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.buttonPurchaseHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchaseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchaseHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPurchaseHistory.Location = new System.Drawing.Point(310, 64);
            this.buttonPurchaseHistory.Name = "buttonPurchaseHistory";
            this.buttonPurchaseHistory.Size = new System.Drawing.Size(121, 33);
            this.buttonPurchaseHistory.TabIndex = 15;
            this.buttonPurchaseHistory.Text = "Purchase History";
            this.buttonPurchaseHistory.UseVisualStyleBackColor = false;
            this.buttonPurchaseHistory.Click += new System.EventHandler(this.buttonPurchaseHistory_Click);
            // 
            // FormTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.buttonPurchaseHistory);
            this.Controls.Add(this.buttonCashierHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewPurchase);
            this.Controls.Add(this.dataGridViewCashier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTransactionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransactionHistory";
            this.Load += new System.EventHandler(this.FormTransactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashier)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCashier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCashier;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Button buttonCashierHistory;
        private System.Windows.Forms.DataGridView dataGridViewPurchase;
        private System.Windows.Forms.Button buttonPurchaseHistory;
        private System.Windows.Forms.Button buttonTransactionHistory;
    }
}