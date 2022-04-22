namespace H23
{
    partial class frmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            System.Windows.Forms.Label klantnummerLabel;
            System.Windows.Forms.Label naamLabel;
            System.Windows.Forms.Label straatLabel;
            System.Windows.Forms.Label postnrLabel;
            System.Windows.Forms.Label gemeenteLabel;
            this.dstsKlanten1 = new H23.dstsKlanten();
            this.tblKlantenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblKlantenTableAdapter1 = new H23.dstsKlantenTableAdapters.tblKlantenTableAdapter();
            this.tableAdapterManager2 = new H23.dstsKlantenTableAdapters.TableAdapterManager();
            this.tblKlantenBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tblKlantenBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblOrdersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtsOrders1 = new H23.dtsOrders();
            this.tblOrderinformatieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrderinformatieTableAdapter1 = new H23.dtsOrdersTableAdapters.tblOrderinformatieTableAdapter();
            this.tableAdapterManager3 = new H23.dtsOrdersTableAdapters.TableAdapterManager();
            this.tblOrdersTableAdapter1 = new H23.dtsOrdersTableAdapters.tblOrdersTableAdapter();
            this.tblKlantenBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblKlantenTableAdapter2 = new H23.dtsOrdersTableAdapters.tblKlantenTableAdapter();
            this.tblOrdersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrdersDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOrderinformatieBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrderinformatieDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klantnummerLabel2 = new System.Windows.Forms.Label();
            this.naamTextBox1 = new System.Windows.Forms.TextBox();
            this.straatTextBox1 = new System.Windows.Forms.TextBox();
            this.postnrTextBox = new System.Windows.Forms.TextBox();
            this.gemeenteTextBox1 = new System.Windows.Forms.TextBox();
            klantnummerLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            straatLabel = new System.Windows.Forms.Label();
            postnrLabel = new System.Windows.Forms.Label();
            gemeenteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dstsKlanten1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingSource1BindingNavigator)).BeginInit();
            this.tblKlantenBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsOrders1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderinformatieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderinformatieBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderinformatieDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dstsKlanten1
            // 
            this.dstsKlanten1.DataSetName = "dstsKlanten";
            this.dstsKlanten1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKlantenBindingSource1
            // 
            this.tblKlantenBindingSource1.DataMember = "tblKlanten";
            this.tblKlantenBindingSource1.DataSource = this.dstsKlanten1;
            // 
            // tblKlantenTableAdapter1
            // 
            this.tblKlantenTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.tblKlantenTableAdapter = this.tblKlantenTableAdapter1;
            this.tableAdapterManager2.UpdateOrder = H23.dstsKlantenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblKlantenBindingSource1BindingNavigator
            // 
            this.tblKlantenBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.tblKlantenBindingSource1BindingNavigator.BindingSource = this.tblKlantenBindingSource1;
            this.tblKlantenBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.tblKlantenBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.tblKlantenBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.tblKlantenBindingSource1BindingNavigatorSaveItem});
            this.tblKlantenBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblKlantenBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.tblKlantenBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.tblKlantenBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.tblKlantenBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.tblKlantenBindingSource1BindingNavigator.Name = "tblKlantenBindingSource1BindingNavigator";
            this.tblKlantenBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.tblKlantenBindingSource1BindingNavigator.Size = new System.Drawing.Size(862, 25);
            this.tblKlantenBindingSource1BindingNavigator.TabIndex = 0;
            this.tblKlantenBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tblKlantenBindingSource1BindingNavigatorSaveItem
            // 
            this.tblKlantenBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblKlantenBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblKlantenBindingSource1BindingNavigatorSaveItem.Image")));
            this.tblKlantenBindingSource1BindingNavigatorSaveItem.Name = "tblKlantenBindingSource1BindingNavigatorSaveItem";
            this.tblKlantenBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblKlantenBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.tblKlantenBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.tblKlantenBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // tblOrdersBindingSource1
            // 
            this.tblOrdersBindingSource1.DataMember = "tblOrders";
            this.tblOrdersBindingSource1.DataSource = this.dtsOrders1;
            // 
            // dtsOrders1
            // 
            this.dtsOrders1.DataSetName = "dtsOrders";
            this.dtsOrders1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOrderinformatieBindingSource1
            // 
            this.tblOrderinformatieBindingSource1.DataMember = "tblOrderinformatie";
            this.tblOrderinformatieBindingSource1.DataSource = this.dtsOrders1;
            // 
            // tblOrderinformatieTableAdapter1
            // 
            this.tblOrderinformatieTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.tblKlantenTableAdapter = null;
            this.tableAdapterManager3.tblOrderinformatieTableAdapter = this.tblOrderinformatieTableAdapter1;
            this.tableAdapterManager3.tblOrdersTableAdapter = this.tblOrdersTableAdapter1;
            this.tableAdapterManager3.UpdateOrder = H23.dtsOrdersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblOrdersTableAdapter1
            // 
            this.tblOrdersTableAdapter1.ClearBeforeFill = true;
            // 
            // tblKlantenBindingSource2
            // 
            this.tblKlantenBindingSource2.DataMember = "tblKlanten";
            this.tblKlantenBindingSource2.DataSource = this.dtsOrders1;
            // 
            // tblKlantenTableAdapter2
            // 
            this.tblKlantenTableAdapter2.ClearBeforeFill = true;
            // 
            // tblOrdersBindingSource2
            // 
            this.tblOrdersBindingSource2.DataMember = "tblOrders_FK00";
            this.tblOrdersBindingSource2.DataSource = this.tblKlantenBindingSource2;
            // 
            // tblOrdersDataGridView1
            // 
            this.tblOrdersDataGridView1.AutoGenerateColumns = false;
            this.tblOrdersDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOrdersDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.tblOrdersDataGridView1.DataSource = this.tblOrdersBindingSource2;
            this.tblOrdersDataGridView1.Location = new System.Drawing.Point(0, 156);
            this.tblOrdersDataGridView1.Name = "tblOrdersDataGridView1";
            this.tblOrdersDataGridView1.Size = new System.Drawing.Size(842, 218);
            this.tblOrdersDataGridView1.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn13.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Klantnummer";
            this.dataGridViewTextBoxColumn14.HeaderText = "Klantnummer";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "WerknemerID";
            this.dataGridViewTextBoxColumn15.HeaderText = "WerknemerID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "VerzendID";
            this.dataGridViewTextBoxColumn16.HeaderText = "VerzendID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Orderdatum";
            this.dataGridViewTextBoxColumn17.HeaderText = "Orderdatum";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Vervaldatum";
            this.dataGridViewTextBoxColumn18.HeaderText = "Vervaldatum";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Leverdatum";
            this.dataGridViewTextBoxColumn19.HeaderText = "Leverdatum";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Vrachtkosten";
            this.dataGridViewTextBoxColumn20.HeaderText = "Vrachtkosten";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // tblOrderinformatieBindingSource2
            // 
            this.tblOrderinformatieBindingSource2.DataMember = "tblOrderinformatie_FK00";
            this.tblOrderinformatieBindingSource2.DataSource = this.tblOrdersBindingSource2;
            // 
            // tblOrderinformatieDataGridView1
            // 
            this.tblOrderinformatieDataGridView1.AutoGenerateColumns = false;
            this.tblOrderinformatieDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOrderinformatieDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.tblOrderinformatieDataGridView1.DataSource = this.tblOrderinformatieBindingSource2;
            this.tblOrderinformatieDataGridView1.Location = new System.Drawing.Point(0, 395);
            this.tblOrderinformatieDataGridView1.Name = "tblOrderinformatieDataGridView1";
            this.tblOrderinformatieDataGridView1.Size = new System.Drawing.Size(446, 220);
            this.tblOrderinformatieDataGridView1.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn21.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Productnummer";
            this.dataGridViewTextBoxColumn22.HeaderText = "Productnummer";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Hoeveelheid";
            this.dataGridViewTextBoxColumn23.HeaderText = "Hoeveelheid";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Korting";
            this.dataGridViewTextBoxColumn24.HeaderText = "Korting";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // klantnummerLabel
            // 
            klantnummerLabel.AutoSize = true;
            klantnummerLabel.Location = new System.Drawing.Point(100, 32);
            klantnummerLabel.Name = "klantnummerLabel";
            klantnummerLabel.Size = new System.Drawing.Size(71, 13);
            klantnummerLabel.TabIndex = 20;
            klantnummerLabel.Text = "Klantnummer:";
            // 
            // klantnummerLabel2
            // 
            this.klantnummerLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource2, "Klantnummer", true));
            this.klantnummerLabel2.Location = new System.Drawing.Point(177, 32);
            this.klantnummerLabel2.Name = "klantnummerLabel2";
            this.klantnummerLabel2.Size = new System.Drawing.Size(100, 23);
            this.klantnummerLabel2.TabIndex = 21;
            this.klantnummerLabel2.Text = "label1";
            // 
            // naamLabel
            // 
            naamLabel.AutoSize = true;
            naamLabel.Location = new System.Drawing.Point(100, 61);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(38, 13);
            naamLabel.TabIndex = 22;
            naamLabel.Text = "Naam:";
            // 
            // naamTextBox1
            // 
            this.naamTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource2, "Naam", true));
            this.naamTextBox1.Location = new System.Drawing.Point(177, 58);
            this.naamTextBox1.Name = "naamTextBox1";
            this.naamTextBox1.Size = new System.Drawing.Size(100, 20);
            this.naamTextBox1.TabIndex = 23;
            // 
            // straatLabel
            // 
            straatLabel.AutoSize = true;
            straatLabel.Location = new System.Drawing.Point(100, 87);
            straatLabel.Name = "straatLabel";
            straatLabel.Size = new System.Drawing.Size(38, 13);
            straatLabel.TabIndex = 24;
            straatLabel.Text = "Straat:";
            // 
            // straatTextBox1
            // 
            this.straatTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource2, "Straat", true));
            this.straatTextBox1.Location = new System.Drawing.Point(177, 84);
            this.straatTextBox1.Name = "straatTextBox1";
            this.straatTextBox1.Size = new System.Drawing.Size(100, 20);
            this.straatTextBox1.TabIndex = 25;
            // 
            // postnrLabel
            // 
            postnrLabel.AutoSize = true;
            postnrLabel.Location = new System.Drawing.Point(100, 113);
            postnrLabel.Name = "postnrLabel";
            postnrLabel.Size = new System.Drawing.Size(40, 13);
            postnrLabel.TabIndex = 26;
            postnrLabel.Text = "Postnr:";
            // 
            // postnrTextBox
            // 
            this.postnrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource2, "Postnr", true));
            this.postnrTextBox.Location = new System.Drawing.Point(177, 110);
            this.postnrTextBox.Name = "postnrTextBox";
            this.postnrTextBox.Size = new System.Drawing.Size(100, 20);
            this.postnrTextBox.TabIndex = 27;
            // 
            // gemeenteLabel
            // 
            gemeenteLabel.AutoSize = true;
            gemeenteLabel.Location = new System.Drawing.Point(100, 139);
            gemeenteLabel.Name = "gemeenteLabel";
            gemeenteLabel.Size = new System.Drawing.Size(59, 13);
            gemeenteLabel.TabIndex = 28;
            gemeenteLabel.Text = "Gemeente:";
            // 
            // gemeenteTextBox1
            // 
            this.gemeenteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource2, "Gemeente", true));
            this.gemeenteTextBox1.Location = new System.Drawing.Point(177, 136);
            this.gemeenteTextBox1.Name = "gemeenteTextBox1";
            this.gemeenteTextBox1.Size = new System.Drawing.Size(100, 20);
            this.gemeenteTextBox1.TabIndex = 29;
            // 
            // frmOrders
            // 
            this.ClientSize = new System.Drawing.Size(862, 730);
            this.Controls.Add(klantnummerLabel);
            this.Controls.Add(this.klantnummerLabel2);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.naamTextBox1);
            this.Controls.Add(straatLabel);
            this.Controls.Add(this.straatTextBox1);
            this.Controls.Add(postnrLabel);
            this.Controls.Add(this.postnrTextBox);
            this.Controls.Add(gemeenteLabel);
            this.Controls.Add(this.gemeenteTextBox1);
            this.Controls.Add(this.tblOrderinformatieDataGridView1);
            this.Controls.Add(this.tblOrdersDataGridView1);
            this.Controls.Add(this.tblKlantenBindingSource1BindingNavigator);
            this.Name = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dstsKlanten1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingSource1BindingNavigator)).EndInit();
            this.tblKlantenBindingSource1BindingNavigator.ResumeLayout(false);
            this.tblKlantenBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsOrders1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderinformatieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderinformatieBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderinformatieDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dstsKlanten dstsKlanten;
        private System.Windows.Forms.BindingSource tblKlantenBindingSource;
        private dstsKlantenTableAdapters.tblKlantenTableAdapter tblKlantenTableAdapter;
        private dstsKlantenTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblKlantenBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblKlantenBindingNavigatorSaveItem;
        private System.Windows.Forms.Label klantnummerLabel1;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox straatTextBox;
        private System.Windows.Forms.TextBox gemeenteTextBox;
        private dtsOrders dtsOrders;
        private System.Windows.Forms.BindingSource tblOrderinformatieBindingSource;
        private dtsOrdersTableAdapters.tblOrderinformatieTableAdapter tblOrderinformatieTableAdapter;
        private dtsOrdersTableAdapters.TableAdapterManager tableAdapterManager1;
        private dtsOrdersTableAdapters.tblOrdersTableAdapter tblOrdersTableAdapter;
        private System.Windows.Forms.DataGridView tblOrderinformatieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource tblOrdersBindingSource;
        private System.Windows.Forms.DataGridView tblOrdersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private dstsKlanten dstsKlanten1;
        private System.Windows.Forms.BindingSource tblKlantenBindingSource1;
        private dstsKlantenTableAdapters.tblKlantenTableAdapter tblKlantenTableAdapter1;
        private dstsKlantenTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingNavigator tblKlantenBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tblKlantenBindingSource1BindingNavigatorSaveItem;
        private dtsOrders dtsOrders1;
        private System.Windows.Forms.BindingSource tblOrderinformatieBindingSource1;
        private dtsOrdersTableAdapters.tblOrderinformatieTableAdapter tblOrderinformatieTableAdapter1;
        private dtsOrdersTableAdapters.TableAdapterManager tableAdapterManager3;
        private dtsOrdersTableAdapters.tblOrdersTableAdapter tblOrdersTableAdapter1;
        private System.Windows.Forms.BindingSource tblOrdersBindingSource1;
        private System.Windows.Forms.BindingSource tblKlantenBindingSource2;
        private dtsOrdersTableAdapters.tblKlantenTableAdapter tblKlantenTableAdapter2;
        private System.Windows.Forms.BindingSource tblOrdersBindingSource2;
        private System.Windows.Forms.DataGridView tblOrdersDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.BindingSource tblOrderinformatieBindingSource2;
        private System.Windows.Forms.DataGridView tblOrderinformatieDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.Label klantnummerLabel2;
        private System.Windows.Forms.TextBox naamTextBox1;
        private System.Windows.Forms.TextBox straatTextBox1;
        private System.Windows.Forms.TextBox postnrTextBox;
        private System.Windows.Forms.TextBox gemeenteTextBox1;
    }
}