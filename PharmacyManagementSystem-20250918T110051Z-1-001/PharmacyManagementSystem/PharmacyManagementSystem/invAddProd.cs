using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class invAddProd : UserControl
    {
        public invAddProd()
        {
            InitializeComponent();

            // Mag-setup ng columns para sa DataGridView
            prodAddView.ColumnCount = 5;
            prodAddView.Columns[0].Name = "Medicine Name";
            prodAddView.Columns[1].Name = "Dosage Form";
            prodAddView.Columns[2].Name = "Expiration Date";
            prodAddView.Columns[3].Name = "Quantity";
            prodAddView.Columns[4].Name = "Supplier";
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            // Basahin ang values galing sa TextBoxes
            string medName = medNameBox.Text.Trim();
            string dosageForm = dosFormBox.Text.Trim();
            string expDate = expDateBox.Text.Trim();
            string qty = QtyBox.Text.Trim();
            string supplier = suppBox.Text.Trim();

            // Basic validation (optional)
            if (string.IsNullOrWhiteSpace(medName) || string.IsNullOrWhiteSpace(qty))
            {
                MessageBox.Show("Please fill in at least Medicine Name and Quantity.");
                return;
            }

            // Idagdag sa DataGridView
            prodAddView.Rows.Add(medName, dosageForm, expDate, qty, supplier);

            // I-clear ang inputs pagkatapos mag-add
            medNameBox.Clear();
            dosFormBox.Clear();
            expDateBox.Clear();
            QtyBox.Clear();
            suppBox.Clear();
        }

       
    }

}