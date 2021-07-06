using System;
using System.Windows.Forms;

namespace UDPojok
{
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormInventory f = new FormInventory();
            f.Show();
            this.Close();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var context = new UDPojokContextEntities();
            Products product = new Products();
            product.product_name = textBoxProductName.Text;
            product.order_price = Convert.ToDecimal(textBoxOrderPrice.Text);
            product.purchase_price = Convert.ToDecimal(textBoxPurchasePrice.Text);
            product.stock = Convert.ToInt32(textBoxStock.Text);
            product.unit = textBoxUnit.Text;

            context.Products.Add(product);
            context.SaveChanges();

            FormInventory f = new FormInventory();
            f.Show();
            this.Close();
        }

        private void buttonTransactionHistory_Click(object sender, EventArgs e)
        {
            FormTransactionHistory f = new FormTransactionHistory();
            f.Show();
            this.Close();
        }
    }
}
