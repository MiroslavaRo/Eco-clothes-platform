namespace EcoClothes
{
    partial class Deliveries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deliveries));
            this.ekodrehiDataSet = new EcoClothes.EkodrehiDataSet();
            this.kurieriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kurieriTableAdapter = new EcoClothes.EkodrehiDataSetTableAdapters.KurieriTableAdapter();
            this.tableAdapterManager = new EcoClothes.EkodrehiDataSetTableAdapters.TableAdapterManager();
            this.kurieriBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kurieriBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kurieriDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ekodrehiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurieriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurieriBindingNavigator)).BeginInit();
            this.kurieriBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kurieriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ekodrehiDataSet
            // 
            this.ekodrehiDataSet.DataSetName = "EkodrehiDataSet";
            this.ekodrehiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kurieriBindingSource
            // 
            this.kurieriBindingSource.DataMember = "Kurieri";
            this.kurieriBindingSource.DataSource = this.ekodrehiDataSet;
            // 
            // kurieriTableAdapter
            // 
            this.kurieriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FakturiTableAdapter = null;
            this.tableAdapterManager.KategoriiTableAdapter = null;
            this.tableAdapterManager.KlientiTableAdapter = null;
            this.tableAdapterManager.KurieriTableAdapter = this.kurieriTableAdapter;
            this.tableAdapterManager.Materiali_ProduktiTableAdapter = null;
            this.tableAdapterManager.MaterialiTableAdapter = null;
            this.tableAdapterManager.Porychki_ProduktiTableAdapter = null;
            this.tableAdapterManager.PorychkiTableAdapter = null;
            this.tableAdapterManager.ProduktiTableAdapter = null;
            this.tableAdapterManager.SkladoveTableAdapter = null;
            this.tableAdapterManager.SlujiteliTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EcoClothes.EkodrehiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kurieriBindingNavigator
            // 
            this.kurieriBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kurieriBindingNavigator.BindingSource = this.kurieriBindingSource;
            this.kurieriBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kurieriBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kurieriBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kurieriBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kurieriBindingNavigatorSaveItem});
            this.kurieriBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.kurieriBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kurieriBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kurieriBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kurieriBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kurieriBindingNavigator.Name = "kurieriBindingNavigator";
            this.kurieriBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kurieriBindingNavigator.Size = new System.Drawing.Size(760, 27);
            this.kurieriBindingNavigator.TabIndex = 0;
            this.kurieriBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // kurieriBindingNavigatorSaveItem
            // 
            this.kurieriBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kurieriBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kurieriBindingNavigatorSaveItem.Image")));
            this.kurieriBindingNavigatorSaveItem.Name = "kurieriBindingNavigatorSaveItem";
            this.kurieriBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.kurieriBindingNavigatorSaveItem.Text = "Save Data";
            this.kurieriBindingNavigatorSaveItem.Click += new System.EventHandler(this.kurieriBindingNavigatorSaveItem_Click);
            // 
            // kurieriDataGridView
            // 
            this.kurieriDataGridView.AutoGenerateColumns = false;
            this.kurieriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kurieriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.kurieriDataGridView.DataSource = this.kurieriBindingSource;
            this.kurieriDataGridView.Location = new System.Drawing.Point(23, 109);
            this.kurieriDataGridView.Name = "kurieriDataGridView";
            this.kurieriDataGridView.RowHeadersWidth = 51;
            this.kurieriDataGridView.RowTemplate.Height = 24;
            this.kurieriDataGridView.Size = new System.Drawing.Size(422, 220);
            this.kurieriDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_kurier";
            this.dataGridViewTextBoxColumn1.HeaderText = "код на куриер";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "naimenovanie";
            this.dataGridViewTextBoxColumn2.HeaderText = "наименование";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Deliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kurieriDataGridView);
            this.Controls.Add(this.kurieriBindingNavigator);
            this.Name = "Deliveries";
            this.Text = "Куриери";
            this.Load += new System.EventHandler(this.Deliveries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ekodrehiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurieriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurieriBindingNavigator)).EndInit();
            this.kurieriBindingNavigator.ResumeLayout(false);
            this.kurieriBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kurieriDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EkodrehiDataSet ekodrehiDataSet;
        private System.Windows.Forms.BindingSource kurieriBindingSource;
        private EkodrehiDataSetTableAdapters.KurieriTableAdapter kurieriTableAdapter;
        private EkodrehiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kurieriBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kurieriBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kurieriDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}