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
    public partial class FormPurchase : Form
    {
        private decimal price = 0;
        private decimal totalPrice = 0;

        public FormPurchase()
        {
            InitializeComponent();
        }

        private void FormPurchase_Load(object sender, EventArgs e)
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

            List<Suppliers> suppliers = (from s in context.Suppliers
                                         select s).ToList();
            suppliers.Insert(0, new Suppliers
            {
                supplier_id = 0,
                supplier_name = "Please Select"
            });

            comboBoxSupplier.DataSource = suppliers;
            comboBoxSupplier.ValueMember = "supplier_id";
            comboBoxSupplier.DisplayMember = "supplier_name";
        }

        private void buttonCashier_Click(object sender, EventArgs e)
        {
            formCashier f = new formCashier();
            f.Show();
            this.Close();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            FormInventory f = new FormInventory();
            f.Show();
            this.Close();
        }

        private void countPrice(string idProduct, string textBoxAmount)
        {
            if (idProduct != "0" && textBoxAmount != "")
            {
                var context = new UDPojokContextEntities();
                var product = context.Products.Find(Convert.ToInt32(idProduct));
                price = Convert.ToDecimal(product.purchase_price) * Convert.ToDecimal(textBoxAmount);
                labelPrice.Text = Convert.ToString(price);
            }
            else
                labelPrice.Text = "0";
        }

        private void comboBoxProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            countPrice(comboBoxProduct.SelectedValue.ToString(), textBoxAmount.Text);
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            countPrice(comboBoxProduct.SelectedValue.ToString(), textBoxAmount.Text);
        }
        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            string[] dataCart =
            {
                Convert.ToString(comboBoxProduct.SelectedValue),
                Convert.ToString(comboBoxProduct.Text),
                Convert.ToString(textBoxAmount.Text),
                Convert.ToString(price)
            };
            dataGridViewCart.Rows.Add(dataCart);

            totalPrice += price;
            labelTotalPrice.Text = Convert.ToString(totalPrice);

            price = 0;
            comboBoxProduct.SelectedValue = 0;
            textBoxAmount.Text = "";
        }
        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            string purchaseDate = DateTime.Now.ToShortDateString();
            string requiredDate = dateTimePickerRequiredDate.Value.ToShortDateString();
            var context = new UDPojokContextEntities();
            var purchase = new Purchases();
            purchase.purchase_date = Convert.ToDateTime(purchaseDate);
            purchase.required_date = Convert.ToDateTime(requiredDate);
            purchase.supplier_id = Convert.ToInt32(comboBoxSupplier.SelectedValue);

            Console.WriteLine(purchase.purchase_date + " " + purchase.required_date);

            if (purchaseDate.Equals(requiredDate))
            {
                purchase.purchase_status = "Done";
                purchase.shipped_date = purchase.required_date;
            }
            else
                purchase.purchase_status = "On Process";

            context.Purchases.Add(purchase);
            context.SaveChanges();

            for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
            {
                int productId = Convert.ToInt32(dataGridViewCart.Rows[i].Cells[0].Value);
                int quantity = Convert.ToInt32(dataGridViewCart.Rows[i].Cells[2].Value);
                decimal itemPrice = Convert.ToDecimal(dataGridViewCart.Rows[i].Cells[3].Value);

                var purchaseItem = new PurchaseItems();
                purchaseItem.purchase_id = purchase.purchase_id;
                purchaseItem.product_id = productId;
                purchaseItem.quantity = quantity;
                purchaseItem.price = itemPrice;
                context.PurchaseItems.Add(purchaseItem);
                context.SaveChanges();

                var product = context.Products.Find(productId);
                product.stock += quantity;
                context.SaveChanges();
            }
            dataGridViewCart.Rows.Clear();
            comboBoxSupplier.SelectedValue = 0;
            dateTimePickerRequiredDate.Value = DateTime.Now;
            labelTotalPrice.Text = "0";
            MessageBox.Show("Purchase successful");
        }

        private void dataGridViewCart_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            totalPrice -= Convert.ToDecimal(e.Row.Cells[3].Value);
            labelTotalPrice.Text = Convert.ToString(totalPrice);
        }

        private void buttonTransactionHistory_Click(object sender, EventArgs e)
        {
            FormTransactionHistory f = new FormTransactionHistory();
            f.Show();
            this.Hide();
        }
    }
}
