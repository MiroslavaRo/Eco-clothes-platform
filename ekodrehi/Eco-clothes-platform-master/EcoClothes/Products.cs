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
    public partial class Products : MetroFramework.Forms.MetroForm
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Kategorii' table. You can move, or remove it, as needed.
            this.kategoriiTableAdapter.Fill(this.ekodrehiDataSet.Kategorii);
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Skladove' table. You can move, or remove it, as needed.
            this.skladoveTableAdapter.Fill(this.ekodrehiDataSet.Skladove);
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Materiali' table. You can move, or remove it, as needed.
            this.materialiTableAdapter.Fill(this.ekodrehiDataSet.Materiali);
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Materiali_Produkti' table. You can move, or remove it, as needed.
            this.materiali_ProduktiTableAdapter.Fill(this.ekodrehiDataSet.Materiali_Produkti);
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Produkti' table. You can move, or remove it, as needed.
            this.produktiTableAdapter.Fill(this.ekodrehiDataSet.Produkti);

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void produktiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produktiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ekodrehiDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //new AddProduct().ShowDialog();
        }

        private void id_skladLabel1_Click(object sender, EventArgs e)
        {

        }

        private void id_skladComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materiali_ProduktiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void id_produktLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
