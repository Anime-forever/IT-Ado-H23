namespace H23
{
    partial class frmKlantenDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKlantenDetails));
            System.Windows.Forms.Label klantnummerLabel;
            System.Windows.Forms.Label naamLabel;
            System.Windows.Forms.Label straatLabel;
            System.Windows.Forms.Label postnrLabel;
            System.Windows.Forms.Label gemeenteLabel;
            System.Windows.Forms.Label ondernemingsnrLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label saldoLabel;
            System.Windows.Forms.Label opmerkingLabel;
            this.dstsKlanten = new H23.dstsKlanten();
            this.tblKlantenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKlantenTableAdapter = new H23.dstsKlantenTableAdapters.tblKlantenTableAdapter();
            this.tableAdapterManager = new H23.dstsKlantenTableAdapters.TableAdapterManager();
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
            this.ondernemingsnrTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.saldoTextBox = new System.Windows.Forms.TextBox();
            this.opmerkingTextBox = new System.Windows.Forms.TextBox();
            klantnummerLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            straatLabel = new System.Windows.Forms.Label();
            postnrLabel = new System.Windows.Forms.Label();
            gemeenteLabel = new System.Windows.Forms.Label();
            ondernemingsnrLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            saldoLabel = new System.Windows.Forms.Label();
            opmerkingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dstsKlanten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingNavigator)).BeginInit();
            this.tblKlantenBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dstsKlanten
            // 
            this.dstsKlanten.DataSetName = "dstsKlanten";
            this.dstsKlanten.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKlantenBindingSource
            // 
            this.tblKlantenBindingSource.DataMember = "tblKlanten";
            this.tblKlantenBindingSource.DataSource = this.dstsKlanten;
            // 
            // tblKlantenTableAdapter
            // 
            this.tblKlantenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblKlantenTableAdapter = this.tblKlantenTableAdapter;
            this.tableAdapterManager.UpdateOrder = H23.dstsKlantenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.tblKlantenBindingNavigator.Size = new System.Drawing.Size(800, 25);
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
            klantnummerLabel.Location = new System.Drawing.Point(202, 60);
            klantnummerLabel.Name = "klantnummerLabel";
            klantnummerLabel.Size = new System.Drawing.Size(71, 13);
            klantnummerLabel.TabIndex = 1;
            klantnummerLabel.Text = "Klantnummer:";
            // 
            // klantnummerLabel1
            // 
            this.klantnummerLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Klantnummer", true));
            this.klantnummerLabel1.Location = new System.Drawing.Point(295, 60);
            this.klantnummerLabel1.Name = "klantnummerLabel1";
            this.klantnummerLabel1.Size = new System.Drawing.Size(121, 23);
            this.klantnummerLabel1.TabIndex = 2;
            this.klantnummerLabel1.Text = "label1";
            // 
            // naamLabel
            // 
            naamLabel.AutoSize = true;
            naamLabel.Location = new System.Drawing.Point(202, 89);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(38, 13);
            naamLabel.TabIndex = 3;
            naamLabel.Text = "Naam:";
            // 
            // naamTextBox
            // 
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Naam", true));
            this.naamTextBox.Location = new System.Drawing.Point(295, 86);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(121, 20);
            this.naamTextBox.TabIndex = 4;
            // 
            // straatLabel
            // 
            straatLabel.AutoSize = true;
            straatLabel.Location = new System.Drawing.Point(202, 115);
            straatLabel.Name = "straatLabel";
            straatLabel.Size = new System.Drawing.Size(38, 13);
            straatLabel.TabIndex = 5;
            straatLabel.Text = "Straat:";
            // 
            // straatTextBox
            // 
            this.straatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Straat", true));
            this.straatTextBox.Location = new System.Drawing.Point(295, 112);
            this.straatTextBox.Name = "straatTextBox";
            this.straatTextBox.Size = new System.Drawing.Size(121, 20);
            this.straatTextBox.TabIndex = 6;
            // 
            // postnrLabel
            // 
            postnrLabel.AutoSize = true;
            postnrLabel.Location = new System.Drawing.Point(202, 141);
            postnrLabel.Name = "postnrLabel";
            postnrLabel.Size = new System.Drawing.Size(40, 13);
            postnrLabel.TabIndex = 7;
            postnrLabel.Text = "Postnr:";
            // 
            // postnrTextBox
            // 
            this.postnrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Postnr", true));
            this.postnrTextBox.Location = new System.Drawing.Point(295, 138);
            this.postnrTextBox.Name = "postnrTextBox";
            this.postnrTextBox.Size = new System.Drawing.Size(121, 20);
            this.postnrTextBox.TabIndex = 8;
            // 
            // gemeenteLabel
            // 
            gemeenteLabel.AutoSize = true;
            gemeenteLabel.Location = new System.Drawing.Point(202, 167);
            gemeenteLabel.Name = "gemeenteLabel";
            gemeenteLabel.Size = new System.Drawing.Size(59, 13);
            gemeenteLabel.TabIndex = 9;
            gemeenteLabel.Text = "Gemeente:";
            // 
            // gemeenteTextBox
            // 
            this.gemeenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Gemeente", true));
            this.gemeenteTextBox.Location = new System.Drawing.Point(295, 164);
            this.gemeenteTextBox.Name = "gemeenteTextBox";
            this.gemeenteTextBox.Size = new System.Drawing.Size(121, 20);
            this.gemeenteTextBox.TabIndex = 10;
            // 
            // ondernemingsnrLabel
            // 
            ondernemingsnrLabel.AutoSize = true;
            ondernemingsnrLabel.Location = new System.Drawing.Point(202, 193);
            ondernemingsnrLabel.Name = "ondernemingsnrLabel";
            ondernemingsnrLabel.Size = new System.Drawing.Size(87, 13);
            ondernemingsnrLabel.TabIndex = 11;
            ondernemingsnrLabel.Text = "Ondernemingsnr:";
            // 
            // ondernemingsnrTextBox
            // 
            this.ondernemingsnrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Ondernemingsnr", true));
            this.ondernemingsnrTextBox.Location = new System.Drawing.Point(295, 190);
            this.ondernemingsnrTextBox.Name = "ondernemingsnrTextBox";
            this.ondernemingsnrTextBox.Size = new System.Drawing.Size(121, 20);
            this.ondernemingsnrTextBox.TabIndex = 12;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(202, 219);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 13;
            typeLabel.Text = "Type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Type", true));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(295, 216);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 14;
            // 
            // saldoLabel
            // 
            saldoLabel.AutoSize = true;
            saldoLabel.Location = new System.Drawing.Point(202, 246);
            saldoLabel.Name = "saldoLabel";
            saldoLabel.Size = new System.Drawing.Size(37, 13);
            saldoLabel.TabIndex = 15;
            saldoLabel.Text = "Saldo:";
            // 
            // saldoTextBox
            // 
            this.saldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Saldo", true));
            this.saldoTextBox.Location = new System.Drawing.Point(295, 243);
            this.saldoTextBox.Name = "saldoTextBox";
            this.saldoTextBox.Size = new System.Drawing.Size(121, 20);
            this.saldoTextBox.TabIndex = 16;
            // 
            // opmerkingLabel
            // 
            opmerkingLabel.AutoSize = true;
            opmerkingLabel.Location = new System.Drawing.Point(202, 272);
            opmerkingLabel.Name = "opmerkingLabel";
            opmerkingLabel.Size = new System.Drawing.Size(61, 13);
            opmerkingLabel.TabIndex = 17;
            opmerkingLabel.Text = "Opmerking:";
            // 
            // opmerkingTextBox
            // 
            this.opmerkingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKlantenBindingSource, "Opmerking", true));
            this.opmerkingTextBox.Location = new System.Drawing.Point(295, 269);
            this.opmerkingTextBox.Name = "opmerkingTextBox";
            this.opmerkingTextBox.Size = new System.Drawing.Size(121, 20);
            this.opmerkingTextBox.TabIndex = 18;
            // 
            // frmKlantenDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(ondernemingsnrLabel);
            this.Controls.Add(this.ondernemingsnrTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(saldoLabel);
            this.Controls.Add(this.saldoTextBox);
            this.Controls.Add(opmerkingLabel);
            this.Controls.Add(this.opmerkingTextBox);
            this.Controls.Add(this.tblKlantenBindingNavigator);
            this.Name = "frmKlantenDetails";
            this.Text = "frmKlantenDetails";
            this.Load += new System.EventHandler(this.frmKlantenDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dstsKlanten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKlantenBindingNavigator)).EndInit();
            this.tblKlantenBindingNavigator.ResumeLayout(false);
            this.tblKlantenBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox postnrTextBox;
        private System.Windows.Forms.TextBox gemeenteTextBox;
        private System.Windows.Forms.TextBox ondernemingsnrTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox saldoTextBox;
        private System.Windows.Forms.TextBox opmerkingTextBox;
    }
}