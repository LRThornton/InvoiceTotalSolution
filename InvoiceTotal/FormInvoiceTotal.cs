using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal {
    public partial class InvoiceTotal : Form {
        public InvoiceTotal() {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e) {

        }
        int numberofInvoices = 0;
        decimal totalofInvoicies = 0m;
        decimal invoiceAverage = 0m;


        private void btnExit_Click(object sender, EventArgs e) {
           this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);

            decimal discountPercent = 0.25m;
        
            decimal discountAmount = Math.Round(subtotal * discountPercent, 2);

            decimal invoiceTotal = subtotal - discountAmount;

            txtSubtotal.Text = subtotal.ToString("c");

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            numberofInvoices++;
            totalofInvoicies += invoiceTotal;
            invoiceAverage = totalofInvoicies / numberofInvoices;
            
            txtNumberofInvoices.Text = numberofInvoices.ToString();
            txtTotalofInvoices.Text = totalofInvoicies.ToString("c");
            txtInvoiceAverage.Text = invoiceAverage.ToString("c");

            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();


        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) {

        }

        private void btnClearTotals_Click(object sender, EventArgs e) {
            numberofInvoices = 0;
            totalofInvoicies = 0m;
            invoiceAverage = 0m;

            txtNumberofInvoices.Text = "";
            txtTotalofInvoices.Text = "";
            txtInvoiceAverage.Text = "";

            txtEnterSubtotal.Focus();
        }
    }
}
