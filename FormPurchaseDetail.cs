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
    public partial class FormPurchaseDetail : Form
    {
        Purchases purchases;
        public FormPurchaseDetail(int idPurchase)
        {
            InitializeComponent();
            var context = new UDPojokContextEntities();
            this.purchases = context.Purchases.Find(idPurchase);
        }

        private void FormPurchaseDetail_Load(object sender, EventArgs e)
        {
            var context = new UDPojokContextEntities();
            var purchaseItems = from pi in purchases.PurchaseItems
                                select new
                                {
                                    ProductID = pi.product_id,
                                    Product = pi.Products.product_name,
                                    Quantity = pi.quantity,
                                    TotalPrice = pi.price
                                };
            dataGridViewPurchaseItems.DataSource = purchaseItems.ToList();

            DateTime date = (DateTime)purchases.purchase_date;
            DateTime requiredDate = (DateTime)purchases.required_date;
            DateTime shippedDate;

            if (purchases.shipped_date == null)
                labelShippedDate.Text = "Not yet sent";
            else
            {
                shippedDate = (DateTime)purchases.shipped_date;
                labelShippedDate.Text = shippedDate.ToShortDateString();
            }

            labelId.Text = purchases.purchase_id.ToString();
            labelSupplier.Text = purchases.Suppliers.supplier_name;
            labelDate.Text = date.ToShortDateString();
            labelStatus.Text = purchases.purchase_status;
            labelRequiredDate.Text = requiredDate.ToShortDateString();
            labelTotal.Text = purchases.PurchaseItems.Select(pi => pi.price).Sum().ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormTransactionHistory f = new FormTransactionHistory();
            f.Show();
            this.Close();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            FormInventory f = new FormInventory();
            f.Show();
            this.Close();
        }
    }
}
