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
    public partial class formCashier : Form
    {
        private decimal price = 0;
        private decimal totalPrice = 0;

        public formCashier()
        {
            InitializeComponent();
        }

        private void formCashier_Load(object sender, EventArgs e)
        {
            dataGridViewCart.ColumnCount = 4;
            dataGridViewCart.Columns[0].Name = "ID Product";
            dataGridViewCart.Columns[1].Name = "Product";
            dataGridViewCart.Columns[2].Name = "Quantity";
            dataGridViewCart.Columns[3].Name = "Price";

            var context = new UDPojokContextEntities();
            List<Products> products = (from p in context.Products
                                      select p).ToList();
            products.Insert(0, new Products
            {
                product_id = 0,
                product_name = "Please Select"
            });

            comboBoxProduct.DataSource = products;
            comboBoxProduct.ValueMember = "product_id";
            comboBoxProduct.DisplayMember = "product_name";
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            countPrice(comboBoxProduct.SelectedValue.ToString(), textBoxAmount.Text);
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            countPrice(comboBoxProduct.SelectedValue.ToString(), textBoxAmount.Text);
        }

        private void countPrice(string idProduct, string textBoxAmount)
        {
            if (idProduct != "0" && textBoxAmount != "")
            {
                var context = new UDPojokContextEntities();
                var product = context.Products.Find(Convert.ToInt32(idProduct));
                price = Convert.ToDecimal(product.order_price) * Convert.ToDecimal(textBoxAmount);
                labelPrice.Text = Convert.ToString(price);
            }
            else
                labelPrice.Text = "0";

        }
        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            string[] dataCart = { Convert.ToString(comboBoxProduct.SelectedValue),
                Convert.ToString(comboBoxProduct.Text),
                Convert.ToString(textBoxAmount.Text), Convert.ToString(price) };
            dataGridViewCart.Rows.Add(dataCart);

            totalPrice += price;
            labelTotalPrice.Text = Convert.ToString(totalPrice);

            price = 0;
            comboBoxProduct.SelectedValue = 0;
            textBoxAmount.Text = "";
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            var context = new UDPojokContextEntities();
            var order = new Orders();
            order.order_date = DateTime.Now;
            context.Orders.Add(order);
            context.SaveChanges();

            for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
            {
                int productId = Convert.ToInt32(dataGridViewCart.Rows[i].Cells[0].Value);
                int quantity = Convert.ToInt32(dataGridViewCart.Rows[i].Cells[2].Value);
                decimal itemPrice = Convert.ToDecimal(dataGridViewCart.Rows[i].Cells[3].Value);

                var orderItem = new OrderItems();
                orderItem.order_id = order.order_id;
                orderItem.product_id = productId;
                orderItem.quantity = quantity;
                orderItem.price = itemPrice;
                context.OrderItems.Add(orderItem);
                context.SaveChanges();

                var product = context.Products.Find(productId);
                product.stock -= quantity;
                context.SaveChanges();
            }
            dataGridViewCart.Rows.Clear();
            labelTotalPrice.Text = "0";
            MessageBox.Show("Checkout successful");
        }

        private void dataGridViewCart_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            totalPrice -= Convert.ToDecimal(e.Row.Cells[3].Value);
            labelTotalPrice.Text = Convert.ToString(totalPrice);
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            FormPurchase f = new FormPurchase();
            f.Show();
            this.Hide();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            FormInventory f = new FormInventory();
            f.Show();
            this.Hide();
        }

        private void buttonTransactionHistory_Click(object sender, EventArgs e)
        {
            FormTransactionHistory f = new FormTransactionHistory();
            f.Show();
            this.Hide();
        }
    }
}
