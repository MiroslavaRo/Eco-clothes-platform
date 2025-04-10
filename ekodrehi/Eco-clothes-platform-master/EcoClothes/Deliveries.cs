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
    public partial class Deliveries : MetroFramework.Forms.MetroForm
    {
        public Deliveries()
        {
            InitializeComponent();
        }

        private void Deliveries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Kurieri' table. You can move, or remove it, as needed.
            this.kurieriTableAdapter.Fill(this.ekodrehiDataSet.Kurieri);

        }

        private void kurieriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kurieriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ekodrehiDataSet);

        }
    }
}
