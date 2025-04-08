namespace EcoClothes
{
    partial class Products
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
            System.Windows.Forms.Label id_kategoriaLabel;
            System.Windows.Forms.Label id_produktLabel;
            System.Windows.Forms.Label naimenovanieLabel;
            System.Windows.Forms.Label nalichnostLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label id_skladLabel1;
            System.Windows.Forms.Label id_kategoriaLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ekodrehiDataSet = new EcoClothes.EkodrehiDataSet();
            this.produktiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktiTableAdapter = new EcoClothes.EkodrehiDataSetTableAdapters.ProduktiTableAdapter();
            this.tableAdapterManager = new EcoClothes.EkodrehiDataSetTableAdapters.TableAdapterManager();
            this.kategoriiTableAdapter = new EcoClothes.EkodrehiDataSetTableAdapters.KategoriiTableAdapter();
            this.materiali_ProduktiTableAdapter = new EcoClothes.EkodrehiDataSetTableAdapters.Materiali_ProduktiTableAdapter();
            this.materialiTableAdapter = new EcoClothes.EkodrehiDataSetTableAdapters.MaterialiTableAdapter();
            this.skladoveTableAdapter = new EcoClothes.EkodrehiDataSetTableAdapters.SkladoveTableAdapter();
            this.produktiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.produktiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_produktTextBox = new System.Windows.Forms.TextBox();
            this.naimenovanieTextBox = new System.Windows.Forms.TextBox();
            this.nalichnostCheckBox = new System.Windows.Forms.CheckBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.materiali_ProduktiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiali_ProduktiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_skladComboBox = new System.Windows.Forms.ComboBox();
            this.skladoveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_kategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.kategoriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.produktiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_kategoriaLabel = new System.Windows.Forms.Label();
            id_produktLabel = new System.Windows.Forms.Label();
            naimenovanieLabel = new System.Windows.Forms.Label();
            nalichnostLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            id_skladLabel1 = new System.Windows.Forms.Label();
            id_kategoriaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ekodrehiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktiBindingNavigator)).BeginInit();
            this.produktiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiali_ProduktiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiali_ProduktiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladoveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriiBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_kategoriaLabel
            // 
            id_kategoriaLabel.AutoSize = true;
            id_kategoriaLabel.Location = new System.Drawing.Point(17, 115);
            id_kategoriaLabel.Name = "id_kategoriaLabel";
            id_kategoriaLabel.Size = new System.Drawing.Size(77, 16);
            id_kategoriaLabel.TabIndex = 3;
            id_kategoriaLabel.Text = "категория:";
            // 
            // id_produktLabel
            // 
            id_produktLabel.AutoSize = true;
            id_produktLabel.Location = new System.Drawing.Point(18, 32);
            id_produktLabel.Name = "id_produktLabel";
            id_produktLabel.Size = new System.Drawing.Size(98, 16);
            id_produktLabel.TabIndex = 5;
            id_produktLabel.Text = "код продукта:";
            // 
            // naimenovanieLabel
            // 
            naimenovanieLabel.AutoSize = true;
            naimenovanieLabel.Location = new System.Drawing.Point(17, 158);
            naimenovanieLabel.Name = "naimenovanieLabel";
            naimenovanieLabel.Size = new System.Drawing.Size(104, 16);
            naimenovanieLabel.TabIndex = 7;
            naimenovanieLabel.Text = "наименование";
            // 
            // nalichnostLabel
            // 
            nalichnostLabel.AutoSize = true;
            nalichnostLabel.Location = new System.Drawing.Point(17, 188);
            nalichnostLabel.Name = "nalichnostLabel";
            nalichnostLabel.Size = new System.Drawing.Size(80, 16);
            nalichnostLabel.TabIndex = 9;
            nalichnostLabel.Text = "наличност:";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(17, 216);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(42, 16);
            cenaLabel.TabIndex = 11;
            cenaLabel.Text = "цена:";
            // 
            // id_skladLabel1
            // 
            id_skladLabel1.AutoSize = true;
            id_skladLabel1.Location = new System.Drawing.Point(18, 72);
            id_skladLabel1.Name = "id_skladLabel1";
            id_skladLabel1.Size = new System.Drawing.Size(48, 16);
            id_skladLabel1.TabIndex = 14;
            id_skladLabel1.Text = "склад:";
            id_skladLabel1.Click += new System.EventHandler(this.id_skladLabel1_Click);
            // 
            // id_kategoriaLabel1
            // 
            id_kategoriaLabel1.AutoSize = true;
            id_kategoriaLabel1.Location = new System.Drawing.Point(103, 231);
            id_kategoriaLabel1.Name = "id_kategoriaLabel1";
            id_kategoriaLabel1.Size = new System.Drawing.Size(0, 16);
            id_kategoriaLabel1.TabIndex = 15;
            // 
            // ekodrehiDataSet
            // 
            this.ekodrehiDataSet.DataSetName = "EkodrehiDataSet";
            this.ekodrehiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktiBindingSource
            // 
            this.produktiBindingSource.DataMember = "Produkti";
            this.produktiBindingSource.DataSource = this.ekodrehiDataSet;
            // 
            // produktiTableAdapter
            // 
            this.produktiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FakturiTableAdapter = null;
            this.tableAdapterManager.KategoriiTableAdapter = this.kategoriiTableAdapter;
            this.tableAdapterManager.KlientiTableAdapter = null;
            this.tableAdapterManager.KurieriTableAdapter = null;
            this.tableAdapterManager.Materiali_ProduktiTableAdapter = this.materiali_ProduktiTableAdapter;
            this.tableAdapterManager.MaterialiTableAdapter = this.materialiTableAdapter;
            this.tableAdapterManager.Porychki_ProduktiTableAdapter = null;
            this.tableAdapterManager.PorychkiTableAdapter = null;
            this.tableAdapterManager.ProduktiTableAdapter = this.produktiTableAdapter;
            this.tableAdapterManager.SkladoveTableAdapter = this.skladoveTableAdapter;
            this.tableAdapterManager.SlujiteliTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EcoClothes.EkodrehiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kategoriiTableAdapter
            // 
            this.kategoriiTableAdapter.ClearBeforeFill = true;
            // 
            // materiali_ProduktiTableAdapter
            // 
            this.materiali_ProduktiTableAdapter.ClearBeforeFill = true;
            // 
            // materialiTableAdapter
            // 
            this.materialiTableAdapter.ClearBeforeFill = true;
            // 
            // skladoveTableAdapter
            // 
            this.skladoveTableAdapter.ClearBeforeFill = true;
            // 
            // produktiBindingNavigator
            // 
            this.produktiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produktiBindingNavigator.BindingSource = this.produktiBindingSource;
            this.produktiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produktiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produktiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.produktiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produktiBindingNavigatorSaveItem});
            this.produktiBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.produktiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produktiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produktiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produktiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produktiBindingNavigator.Name = "produktiBindingNavigator";
            this.produktiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produktiBindingNavigator.Size = new System.Drawing.Size(984, 27);
            this.produktiBindingNavigator.TabIndex = 0;
            this.produktiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // produktiBindingNavigatorSaveItem
            // 
            this.produktiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produktiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produktiBindingNavigatorSaveItem.Image")));
            this.produktiBindingNavigatorSaveItem.Name = "produktiBindingNavigatorSaveItem";
            this.produktiBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.produktiBindingNavigatorSaveItem.Text = "Save Data";
            this.produktiBindingNavigatorSaveItem.Click += new System.EventHandler(this.produktiBindingNavigatorSaveItem_Click);
            // 
            // id_produktTextBox
            // 
            this.id_produktTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktiBindingSource, "id_produkt", true));
            this.id_produktTextBox.Location = new System.Drawing.Point(133, 26);
            this.id_produktTextBox.Name = "id_produktTextBox";
            this.id_produktTextBox.Size = new System.Drawing.Size(104, 22);
            this.id_produktTextBox.TabIndex = 6;
            // 
            // naimenovanieTextBox
            // 
            this.naimenovanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktiBindingSource, "naimenovanie", true));
            this.naimenovanieTextBox.Location = new System.Drawing.Point(132, 152);
            this.naimenovanieTextBox.Name = "naimenovanieTextBox";
            this.naimenovanieTextBox.Size = new System.Drawing.Size(121, 22);
            this.naimenovanieTextBox.TabIndex = 8;
            // 
            // nalichnostCheckBox
            // 
            this.nalichnostCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.produktiBindingSource, "nalichnost", true));
            this.nalichnostCheckBox.Location = new System.Drawing.Point(132, 180);
            this.nalichnostCheckBox.Name = "nalichnostCheckBox";
            this.nalichnostCheckBox.Size = new System.Drawing.Size(104, 24);
            this.nalichnostCheckBox.TabIndex = 10;
            this.nalichnostCheckBox.UseVisualStyleBackColor = true;
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktiBindingSource, "cena", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "0.00 лв."));
            this.cenaTextBox.Location = new System.Drawing.Point(132, 210);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(121, 22);
            this.cenaTextBox.TabIndex = 12;
            // 
            // materiali_ProduktiBindingSource
            // 
            this.materiali_ProduktiBindingSource.DataMember = "R_3";
            this.materiali_ProduktiBindingSource.DataSource = this.produktiBindingSource;
            // 
            // materiali_ProduktiDataGridView
            // 
            this.materiali_ProduktiDataGridView.AutoGenerateColumns = false;
            this.materiali_ProduktiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materiali_ProduktiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.materiali_ProduktiDataGridView.DataSource = this.materiali_ProduktiBindingSource;
            this.materiali_ProduktiDataGridView.Location = new System.Drawing.Point(431, 21);
            this.materiali_ProduktiDataGridView.Name = "materiali_ProduktiDataGridView";
            this.materiali_ProduktiDataGridView.RowHeadersWidth = 51;
            this.materiali_ProduktiDataGridView.RowTemplate.Height = 24;
            this.materiali_ProduktiDataGridView.Size = new System.Drawing.Size(354, 220);
            this.materiali_ProduktiDataGridView.TabIndex = 13;
            this.materiali_ProduktiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materiali_ProduktiDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_material";
            this.dataGridViewTextBoxColumn1.DataSource = this.materialiBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "naimenovanaie";
            this.dataGridViewTextBoxColumn1.HeaderText = "материали";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "id_material";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // materialiBindingSource
            // 
            this.materialiBindingSource.DataMember = "Materiali";
            this.materialiBindingSource.DataSource = this.ekodrehiDataSet;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_produkt";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_produkt";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // id_skladComboBox
            // 
            this.id_skladComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktiBindingSource, "id_sklad", true));
            this.id_skladComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produktiBindingSource, "id_sklad", true));
            this.id_skladComboBox.DataSource = this.skladoveBindingSource;
            this.id_skladComboBox.DisplayMember = "naimenovanie";
            this.id_skladComboBox.FormattingEnabled = true;
            this.id_skladComboBox.Location = new System.Drawing.Point(132, 66);
            this.id_skladComboBox.Name = "id_skladComboBox";
            this.id_skladComboBox.Size = new System.Drawing.Size(121, 24);
            this.id_skladComboBox.TabIndex = 15;
            this.id_skladComboBox.ValueMember = "id_sklad";
            this.id_skladComboBox.SelectedIndexChanged += new System.EventHandler(this.id_skladComboBox_SelectedIndexChanged);
            // 
            // skladoveBindingSource
            // 
            this.skladoveBindingSource.DataMember = "Skladove";
            this.skladoveBindingSource.DataSource = this.ekodrehiDataSet;
            // 
            // id_kategoriaComboBox
            // 
            this.id_kategoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktiBindingSource, "id_kategoria", true));
            this.id_kategoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produktiBindingSource, "id_kategoria", true));
            this.id_kategoriaComboBox.DataSource = this.kategoriiBindingSource;
            this.id_kategoriaComboBox.DisplayMember = "naimenovanie";
            this.id_kategoriaComboBox.FormattingEnabled = true;
            this.id_kategoriaComboBox.Location = new System.Drawing.Point(132, 109);
            this.id_kategoriaComboBox.Name = "id_kategoriaComboBox";
            this.id_kategoriaComboBox.Size = new System.Drawing.Size(121, 24);
            this.id_kategoriaComboBox.TabIndex = 16;
            this.id_kategoriaComboBox.ValueMember = "id_kategoria";
            // 
            // kategoriiBindingSource
            // 
            this.kategoriiBindingSource.DataMember = "Kategorii";
            this.kategoriiBindingSource.DataSource = this.ekodrehiDataSet;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 373);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materiali_ProduktiDataGridView);
            this.tabPage1.Controls.Add(id_kategoriaLabel1);
            this.tabPage1.Controls.Add(this.cenaTextBox);
            this.tabPage1.Controls.Add(this.id_kategoriaComboBox);
            this.tabPage1.Controls.Add(cenaLabel);
            this.tabPage1.Controls.Add(id_skladLabel1);
            this.tabPage1.Controls.Add(this.nalichnostCheckBox);
            this.tabPage1.Controls.Add(this.id_skladComboBox);
            this.tabPage1.Controls.Add(nalichnostLabel);
            this.tabPage1.Controls.Add(this.naimenovanieTextBox);
            this.tabPage1.Controls.Add(id_kategoriaLabel);
            this.tabPage1.Controls.Add(naimenovanieLabel);
            this.tabPage1.Controls.Add(id_produktLabel);
            this.tabPage1.Controls.Add(this.id_produktTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Продукт";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.produktiDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Списък";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // produktiDataGridView
            // 
            this.produktiDataGridView.AutoGenerateColumns = false;
            this.produktiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produktiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.produktiDataGridView.DataSource = this.produktiBindingSource;
            this.produktiDataGridView.Location = new System.Drawing.Point(6, 11);
            this.produktiDataGridView.Name = "produktiDataGridView";
            this.produktiDataGridView.RowHeadersWidth = 51;
            this.produktiDataGridView.RowTemplate.Height = 24;
            this.produktiDataGridView.Size = new System.Drawing.Size(962, 330);
            this.produktiDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_produkt";
            this.dataGridViewTextBoxColumn5.HeaderText = "код на продукта";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_sklad";
            this.dataGridViewTextBoxColumn3.DataSource = this.skladoveBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "naimenovanie";
            this.dataGridViewTextBoxColumn3.HeaderText = "склад";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id_sklad";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_kategoria";
            this.dataGridViewTextBoxColumn4.DataSource = this.kategoriiBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "naimenovanie";
            this.dataGridViewTextBoxColumn4.HeaderText = "категория";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "id_kategoria";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "naimenovanie";
            this.dataGridViewTextBoxColumn6.HeaderText = "наименование";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "nalichnost";
            this.dataGridViewCheckBoxColumn1.HeaderText = "наличност";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cena";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0.00 лв";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn7.HeaderText = "цена";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 513);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.produktiBindingNavigator);
            this.Name = "Products";
            this.Text = "Продукти";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ekodrehiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktiBindingNavigator)).EndInit();
            this.produktiBindingNavigator.ResumeLayout(false);
            this.produktiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiali_ProduktiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiali_ProduktiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladoveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriiBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produktiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EkodrehiDataSet ekodrehiDataSet;
        private System.Windows.Forms.BindingSource produktiBindingSource;
        private EkodrehiDataSetTableAdapters.ProduktiTableAdapter produktiTableAdapter;
        private EkodrehiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produktiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produktiBindingNavigatorSaveItem;
        private EkodrehiDataSetTableAdapters.Materiali_ProduktiTableAdapter materiali_ProduktiTableAdapter;
        private System.Windows.Forms.TextBox id_produktTextBox;
        private System.Windows.Forms.TextBox naimenovanieTextBox;
        private System.Windows.Forms.CheckBox nalichnostCheckBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.BindingSource materiali_ProduktiBindingSource;
        private EkodrehiDataSetTableAdapters.MaterialiTableAdapter materialiTableAdapter;
        private System.Windows.Forms.DataGridView materiali_ProduktiDataGridView;
        private System.Windows.Forms.BindingSource materialiBindingSource;
        private System.Windows.Forms.ComboBox id_skladComboBox;
        private System.Windows.Forms.ComboBox id_kategoriaComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private EkodrehiDataSetTableAdapters.SkladoveTableAdapter skladoveTableAdapter;
        private System.Windows.Forms.BindingSource skladoveBindingSource;
        private EkodrehiDataSetTableAdapters.KategoriiTableAdapter kategoriiTableAdapter;
        private System.Windows.Forms.BindingSource kategoriiBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView produktiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}