using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoClothes
{
    public partial class OrdersInvoices : MetroFramework.Forms.MetroForm
    {
        public OrdersInvoices()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Produkti' table. You can move, or remove it, as needed.
            this.produktiTableAdapter.Fill(this.ekodrehiDataSet.Produkti);
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Klienti' table. You can move, or remove it, as needed.
            this.klientiTableAdapter.Fill(this.ekodrehiDataSet.Klienti);
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Kurieri' table. You can move, or remove it, as needed.
            this.kurieriTableAdapter.Fill(this.ekodrehiDataSet.Kurieri);
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Slujiteli' table. You can move, or remove it, as needed.
            this.slujiteliTableAdapter.Fill(this.ekodrehiDataSet.Slujiteli);
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Fakturi' table. You can move, or remove it, as needed.
            this.fakturiTableAdapter.Fill(this.ekodrehiDataSet.Fakturi);
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Porychki_Produkti' table. You can move, or remove it, as needed.
            this.porychki_ProduktiTableAdapter.Fill(this.ekodrehiDataSet.Porychki_Produkti);
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Porychki' table. You can move, or remove it, as needed.
            this.porychkiTableAdapter.Fill(this.ekodrehiDataSet.Porychki);

        }

        private void поръчкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porychkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.porychkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ekodrehiDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //new Orders().ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void fakturiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
