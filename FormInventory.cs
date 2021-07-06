using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPojok
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            var context = new UDPojokContextEntities();
            var dataProduct = from p in context.Products
                              select new
                              {
                                  ID = p.product_id,
                                  Product = p.product_name,
                                  Price = p.order_price,
                                  Stock = p.stock,
                                  Unit = p.unit
                              };
            dataGridViewProduct.DataSource = dataProduct.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddProduct f = new FormAddProduct();
            f.Show();
            this.Close();
        }

        private void buttonCashier_Click(object sender, EventArgs e)
        {
            formCashier f = new formCashier();
            f.Show();
            this.Close();
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            FormPurchase f = new FormPurchase();
            f.Show();
            this.Close();
        }

        private void dataGridViewProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int productId = (int) dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value;
            FormDetailProduct f = new FormDetailProduct(productId);
            f.Show();
            this.Close();
        }

        private void buttonTransactionHistory_Click(object sender, EventArgs e)
        {
            FormTransactionHistory f = new FormTransactionHistory();
            f.Show();
            this.Hide();
        }
    }
}
