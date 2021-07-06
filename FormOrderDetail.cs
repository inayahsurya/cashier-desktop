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
    public partial class FormOrderDetail : Form
    {
        private Orders order;
        public FormOrderDetail(int idOrder)
        {
            InitializeComponent();
            var context = new UDPojokContextEntities();
            this.order = context.Orders.Find(idOrder);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormTransactionHistory f = new FormTransactionHistory();
            f.Show();
            this.Close();
        }

        private void FormOrderDetail_Load(object sender, EventArgs e)
        {
            var context = new UDPojokContextEntities();
            var orderItem = from oi in order.OrderItems
                            select new
                            {
                                ProductID = oi.product_id,
                                Product = oi.Products.product_name,
                                Quantity = oi.quantity,
                                TotalPrice = oi.price
                            };
            dataGridViewOrderItems.DataSource = orderItem.ToList();

            DateTime date = (DateTime) order.order_date;

            labelId.Text = order.order_id.ToString();
            labelDate.Text = date.ToShortDateString();
            labelTotal.Text = order.OrderItems.Select(oi => oi.price).Sum().ToString();
        }
    }
}
