﻿using System;
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
    public partial class Employees : MetroFramework.Forms.MetroForm
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ekodrehiDataSet.Slujiteli' table. You can move, or remove it, as needed.
            this.slujiteliTableAdapter.Fill(this.ekodrehiDataSet.Slujiteli);

        }

        private void slujiteliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.slujiteliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ekodrehiDataSet);

        }
    }
}
