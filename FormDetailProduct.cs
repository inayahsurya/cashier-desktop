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
    public partial class FormDetailProduct : Form
    {
        int idProduct = 0;
        public FormDetailProduct(int idProduct)
        {
            InitializeComponent();
            this.idProduct = idProduct;
        }

        private void FormDetailProduct_Load(object sender, EventArgs e)
        {
            var context = new UDPojokContextEntities();
            var product = context.Products.Find(idProduct);
            textBoxProductName.Text = product.product_name;
            textBoxOrderPrice.Text = product.order_price.ToString();
            textBoxPurchasePrice.Text = product.purchase_price.ToString();
            textBoxStock.Text = product.stock.ToString();
            textBoxUnit.Text = product.unit;
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            var context = new UDPojokContextEntities();
            var product = context.Products.Find(idProduct);
            product.product_name = textBoxProductName.Text;
            product.order_price = Convert.ToDecimal(textBoxOrderPrice.Text);
            product.purchase_price = Convert.ToDecimal(textBoxPurchasePrice.Text);
            product.stock = Convert.ToInt32(textBoxStock.Text);
            product.unit = textBoxUnit.Text;
            context.SaveChanges();

            MessageBox.Show("Update successful");

            FormInventory f = new FormInventory();
            f.Show();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormInventory f = new FormInventory();
            f.Show();
            this.Close();
        }
    }
}
