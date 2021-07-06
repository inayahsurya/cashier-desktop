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
    public partial class FormTransactionHistory : Form
    {
        public FormTransactionHistory()
        {
            InitializeComponent();
        }

        private void buttonCashierHistory_Click(object sender, EventArgs e)
        {
            init();
            dataGridViewCashier.Visible = true;
            buttonCashierHistory.BackColor = SystemColors.ControlDark;
        }

        private void buttonPurchaseHistory_Click(object sender, EventArgs e)
        {
            init();
            dataGridViewPurchase.Visible = true;
            buttonPurchaseHistory.BackColor = SystemColors.ControlDark;
        }

        private void FormTransactionHistory_Load(object sender, EventArgs e)
        {
            var context = new UDPojokContextEntities();
            var dataOrder = (from oi in context.OrderItems
                             join o in context.Orders on oi.order_id equals o.order_id
                             group oi.price by new
                             {
                                 orderId = o.order_id,
                                 date = o.order_date,
                             } into data
                             select new
                             {
                                 ID = data.Key.orderId,
                                 Date = data.Key.date,
                                 Total = data.Sum()
                             });
            dataGridViewCashier.DataSource = dataOrder.ToList();

            var dataPurchase = (from pi in context.PurchaseItems
                                join p in context.Purchases on pi.purchase_id equals p.purchase_id
                                group pi.price by new
                                {
                                    purchaseId = p.purchase_id,
                                    purchaseDate = p.purchase_date,
                                    status = p.purchase_status,
                                    supplier = p.Suppliers.supplier_name,
                                } into data
                                select new 
                                {
                                    ID = data.Key.purchaseId,
                                    Date = data.Key.purchaseDate,
                                    Supplier = data.Key.supplier,
                                    Total = data.Sum(),
                                    Status = data.Key.status
                                });
            dataGridViewPurchase.DataSource = dataPurchase.ToList();
        }

        private void init()
        {
            buttonCashierHistory.BackColor = Color.FromArgb(27, 109, 193);
            buttonPurchaseHistory.BackColor = Color.FromArgb(27, 109, 193);
            dataGridViewCashier.Visible = false;
            dataGridViewPurchase.Visible = false;
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

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            FormInventory f = new FormInventory();
            f.Show();
            this.Close();
        }

        private void dataGridViewCashier_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int orderId = (int)dataGridViewCashier.Rows[e.RowIndex].Cells[0].Value;
            FormOrderDetail f = new FormOrderDetail(orderId);
            f.Show();
            this.Close();
        }

        private void dataGridViewPurchase_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int purchaseId = (int)dataGridViewPurchase.Rows[e.RowIndex].Cells[0].Value;
            FormPurchaseDetail f = new FormPurchaseDetail(purchaseId);
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
