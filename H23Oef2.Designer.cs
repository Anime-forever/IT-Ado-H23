namespace H23
{
    partial class H23Oef2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H23Oef2));
            System.Windows.Forms.Label klantnummerLabel;
            System.Windows.Forms.Label naamLabel;
            System.Windows.Forms.Label straatLabel;
            System.Windows.Forms.Label postnrLabel;
            System.Windows.Forms.Label gemeenteLabel;
            this.dtsOrders = new H23.dtsOrders();
            this.tblKlantenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKlantenTableAdapter = new H23.dtsOrdersTableAdapters.tblKlantenTableAdapter();
            this.tableAdapterManager = new H23.dtsOrdersTableAdapters.TableAdapterManager();
            this.tblKlantenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblKlantenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.klantnummerLabel1 = new System.Windows.Forms.Label();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.straatTextBox = new System.Windows.Forms.TextBox();
            this.postnrTextBox = new System.Windows.Forms.TextBox();
            this.gemeenteTextBox = new System.Windows.Forms.TextBox();
            this.tblOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrdersTableAdapter = new H23.dtsOrdersTableAdapters.tblOrdersTableAdapter();
            this.tblOrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOrderinformatieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrderinformatieTableAdapter = new H23.dtsOrdersTableAdapters.tblOrderinformatieTableAdapter();
            this.tblOrderinformatieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            klantnummerLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            straatLabel = new System.Windows.Forms.Label();
            postnrLabel = new System.Windows.Forms.Label();
            gemeenteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtsOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingNavigator)).BeginInit();
            this.tblKlantenBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderinformatieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderinformatieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsOrders
            // 
            this.dtsOrders.DataSetName = "dtsOrders";
            this.dtsOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKlantenBindingSource
            // 
            this.tblKlantenBindingSource.DataMember = "tblKlanten";
            this.tblKlantenBindingSource.DataSource = this.dtsOrders;
            // 
            // tblKlantenTableAdapter
            // 
            this.tblKlantenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblKlantenTableAdapter = this.tblKlantenTableAdapter;
            this.tableAdapterManager.tblOrderinformatieTableAdapter = this.tblOrderinformatieTableAdapter;
            this.tableAdapterManager.tblOrdersTableAdapter = this.tblOrdersTableAdapter;
            this.tableAdapterManager.UpdateOrder = H23.dtsOrdersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblKlantenBindingNavigator
            // 
            this.tblKlantenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblKlantenBindingNavigator.BindingSource = this.tblKlantenBindingSource;
            this.tblKlantenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblKlantenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblKlantenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblKlantenBindingNavigatorSaveItem});
            this.tblKlantenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblKlantenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblKlantenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblKlantenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblKlantenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblKlantenBindingNavigator.Name = "tblKlantenBindingNavigator";
            this.tblKlantenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblKlantenBindingNavigator.Size = new System.Drawing.Size(956, 25);
            this.tblKlantenBindingNavigator.TabIndex = 0;
            this.tblKlantenBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tblKlantenBindingNavigatorSaveItem
            // 
            this.tblKlantenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblKlantenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblKlantenBindingNavigatorSaveItem.Image")));
            this.tblKlantenBindingNavigatorSaveItem.Name = "tblKlantenBindingNavigatorSaveItem";
            this.tblKlantenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblKlantenBindingNavigatorSaveItem.Text = "Save Data";
            this.tblKlantenBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblKlantenBindingNavigatorSaveItem_Click);
            // 
            // klantnummerLabel
            // 
            klantnummerLabel.AutoSize = true;
            klantnummerLabel.Location = new System.Drawing.Point(56, 37);
            klantnummerLabel.Name = "klantnummerLabel";
            klantnummerLabel.Size = new System.Drawing.Size(71, 13);
            klantnummerLabel.TabIndex = 1;
            klantnummerLabel.Text = "Klantnummer:";
            // 
            // klantnummerLabel1
            // 
            this.klantnummerLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Klantnummer", true));
            this.klantnummerLabel1.Location = new System.Drawing.Point(133, 37);
            this.klantnummerLabel1.Name = "klantnummerLabel1";
            this.klantnummerLabel1.Size = new System.Drawing.Size(100, 23);
            this.klantnummerLabel1.TabIndex = 2;
            this.klantnummerLabel1.Text = "label1";
            // 
            // naamLabel
            // 
            naamLabel.AutoSize = true;
            naamLabel.Location = new System.Drawing.Point(56, 66);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(38, 13);
            naamLabel.TabIndex = 3;
            naamLabel.Text = "Naam:";
            // 
            // naamTextBox
            // 
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Naam", true));
            this.naamTextBox.Location = new System.Drawing.Point(133, 63);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(100, 20);
            this.naamTextBox.TabIndex = 4;
            // 
            // straatLabel
            // 
            straatLabel.AutoSize = true;
            straatLabel.Location = new System.Drawing.Point(56, 92);
            straatLabel.Name = "straatLabel";
            straatLabel.Size = new System.Drawing.Size(38, 13);
            straatLabel.TabIndex = 5;
            straatLabel.Text = "Straat:";
            // 
            // straatTextBox
            // 
            this.straatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Straat", true));
            this.straatTextBox.Location = new System.Drawing.Point(133, 89);
            this.straatTextBox.Name = "straatTextBox";
            this.straatTextBox.Size = new System.Drawing.Size(100, 20);
            this.straatTextBox.TabIndex = 6;
            // 
            // postnrLabel
            // 
            postnrLabel.AutoSize = true;
            postnrLabel.Location = new System.Drawing.Point(56, 118);
            postnrLabel.Name = "postnrLabel";
            postnrLabel.Size = new System.Drawing.Size(40, 13);
            postnrLabel.TabIndex = 7;
            postnrLabel.Text = "Postnr:";
            // 
            // postnrTextBox
            // 
            this.postnrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Postnr", true));
            this.postnrTextBox.Location = new System.Drawing.Point(133, 115);
            this.postnrTextBox.Name = "postnrTextBox";
            this.postnrTextBox.Size = new System.Drawing.Size(100, 20);
            this.postnrTextBox.TabIndex = 8;
            // 
            // gemeenteLabel
            // 
            gemeenteLabel.AutoSize = true;
            gemeenteLabel.Location = new System.Drawing.Point(56, 144);
            gemeenteLabel.Name = "gemeenteLabel";
            gemeenteLabel.Size = new System.Drawing.Size(59, 13);
            gemeenteLabel.TabIndex = 9;
            gemeenteLabel.Text = "Gemeente:";
            // 
            // gemeenteTextBox
            // 
            this.gemeenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Gemeente", true));
            this.gemeenteTextBox.Location = new System.Drawing.Point(133, 141);
            this.gemeenteTextBox.Name = "gemeenteTextBox";
            this.gemeenteTextBox.Size = new System.Drawing.Size(100, 20);
            this.gemeenteTextBox.TabIndex = 10;
            // 
            // tblOrdersBindingSource
            // 
            this.tblOrdersBindingSource.DataMember = "tblOrders_FK00";
            this.tblOrdersBindingSource.DataSource = this.tblKlantenBindingSource;
            // 
            // tblOrdersTableAdapter
            // 
            this.tblOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // tblOrdersDataGridView
            // 
            this.tblOrdersDataGridView.AutoGenerateColumns = false;
            this.tblOrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tblOrdersDataGridView.DataSource = this.tblOrdersBindingSource;
            this.tblOrdersDataGridView.Location = new System.Drawing.Point(0, 227);
            this.tblOrdersDataGridView.Name = "tblOrdersDataGridView";
            this.tblOrdersDataGridView.Size = new System.Drawing.Size(843, 220);
            this.tblOrdersDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Klantnummer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Klantnummer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WerknemerID";
            this.dataGridViewTextBoxColumn3.HeaderText = "WerknemerID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VerzendID";
            this.dataGridViewTextBoxColumn4.HeaderText = "VerzendID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Orderdatum";
            this.dataGridViewTextBoxColumn5.HeaderText = "Orderdatum";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Vervaldatum";
            this.dataGridViewTextBoxColumn6.HeaderText = "Vervaldatum";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Leverdatum";
            this.dataGridViewTextBoxColumn7.HeaderText = "Leverdatum";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Vrachtkosten";
            this.dataGridViewTextBoxColumn8.HeaderText = "Vrachtkosten";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // tblOrderinformatieBindingSource
            // 
            this.tblOrderinformatieBindingSource.DataMember = "tblOrderinformatie_FK00";
            this.tblOrderinformatieBindingSource.DataSource = this.tblOrdersBindingSource;
            // 
            // tblOrderinformatieTableAdapter
            // 
            this.tblOrderinformatieTableAdapter.ClearBeforeFill = true;
            // 
            // tblOrderinformatieDataGridView
            // 
            this.tblOrderinformatieDataGridView.AutoGenerateColumns = false;
            this.tblOrderinformatieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOrderinformatieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.tblOrderinformatieDataGridView.DataSource = this.tblOrderinformatieBindingSource;
            this.tblOrderinformatieDataGridView.Location = new System.Drawing.Point(482, 4);
            this.tblOrderinformatieDataGridView.Name = "tblOrderinformatieDataGridView";
            this.tblOrderinformatieDataGridView.Size = new System.Drawing.Size(420, 220);
            this.tblOrderinformatieDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn9.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Productnummer";
            this.dataGridViewTextBoxColumn10.HeaderText = "Productnummer";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Hoeveelheid";
            this.dataGridViewTextBoxColumn11.HeaderText = "Hoeveelheid";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Korting";
            this.dataGridViewTextBoxColumn12.HeaderText = "Korting";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // H23Oef2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.tblOrderinformatieDataGridView);
            this.Controls.Add(this.tblOrdersDataGridView);
            this.Controls.Add(klantnummerLabel);
            this.Controls.Add(this.klantnummerLabel1);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(straatLabel);
            this.Controls.Add(this.straatTextBox);
            this.Controls.Add(postnrLabel);
            this.Controls.Add(this.postnrTextBox);
            this.Controls.Add(gemeenteLabel);
            this.Controls.Add(this.gemeenteTextBox);
            this.Controls.Add(this.tblKlantenBindingNavigator);
            this.Name = "H23Oef2";
            this.Text = "H23Oef2";
            this.Load += new System.EventHandler(this.H23Oef2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingNavigator)).EndInit();
            this.tblKlantenBindingNavigator.ResumeLayout(false);
            this.tblKlantenBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderinformatieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderinformatieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dtsOrders dtsOrders;
        private System.Windows.Forms.BindingSource tblKlantenBindingSource;
        private dtsOrdersTableAdapters.tblKlantenTableAdapter tblKlantenTableAdapter;
        private dtsOrdersTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox postnrTextBox;
        private System.Windows.Forms.TextBox gemeenteTextBox;
        private dtsOrdersTableAdapters.tblOrdersTableAdapter tblOrdersTableAdapter;
        private System.Windows.Forms.BindingSource tblOrdersBindingSource;
        private dtsOrdersTableAdapters.tblOrderinformatieTableAdapter tblOrderinformatieTableAdapter;
        private System.Windows.Forms.DataGridView tblOrdersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource tblOrderinformatieBindingSource;
        private System.Windows.Forms.DataGridView tblOrderinformatieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}