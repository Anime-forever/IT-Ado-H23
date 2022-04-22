namespace H23
{
    partial class Oef5H23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oef5H23));
            System.Windows.Forms.Label leveranciersnummerLabel;
            System.Windows.Forms.Label bedrijfLabel;
            this.dtsOef5Twee = new H23.dtsOef5Twee();
            this.tblLeveranciersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLeveranciersTableAdapter = new H23.dtsOef5TweeTableAdapters.tblLeveranciersTableAdapter();
            this.tableAdapterManager = new H23.dtsOef5TweeTableAdapters.TableAdapterManager();
            this.tblLeveranciersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblLeveranciersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.leveranciersnummerTextBox = new System.Windows.Forms.TextBox();
            this.bedrijfTextBox = new System.Windows.Forms.TextBox();
            this.tblProductenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductenTableAdapter = new H23.dtsOef5TweeTableAdapters.tblProductenTableAdapter();
            this.tblProductenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            leveranciersnummerLabel = new System.Windows.Forms.Label();
            bedrijfLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtsOef5Twee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLeveranciersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLeveranciersBindingNavigator)).BeginInit();
            this.tblLeveranciersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsOef5Twee
            // 
            this.dtsOef5Twee.DataSetName = "dtsOef5Twee";
            this.dtsOef5Twee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLeveranciersBindingSource
            // 
            this.tblLeveranciersBindingSource.DataMember = "tblLeveranciers";
            this.tblLeveranciersBindingSource.DataSource = this.dtsOef5Twee;
            // 
            // tblLeveranciersTableAdapter
            // 
            this.tblLeveranciersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblLeveranciersTableAdapter = this.tblLeveranciersTableAdapter;
            this.tableAdapterManager.tblProductenTableAdapter = this.tblProductenTableAdapter;
            this.tableAdapterManager.UpdateOrder = H23.dtsOef5TweeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblLeveranciersBindingNavigator
            // 
            this.tblLeveranciersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblLeveranciersBindingNavigator.BindingSource = this.tblLeveranciersBindingSource;
            this.tblLeveranciersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblLeveranciersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblLeveranciersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblLeveranciersBindingNavigatorSaveItem});
            this.tblLeveranciersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblLeveranciersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblLeveranciersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblLeveranciersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblLeveranciersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblLeveranciersBindingNavigator.Name = "tblLeveranciersBindingNavigator";
            this.tblLeveranciersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblLeveranciersBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tblLeveranciersBindingNavigator.TabIndex = 0;
            this.tblLeveranciersBindingNavigator.Text = "bindingNavigator1";
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
            // tblLeveranciersBindingNavigatorSaveItem
            // 
            this.tblLeveranciersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblLeveranciersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblLeveranciersBindingNavigatorSaveItem.Image")));
            this.tblLeveranciersBindingNavigatorSaveItem.Name = "tblLeveranciersBindingNavigatorSaveItem";
            this.tblLeveranciersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblLeveranciersBindingNavigatorSaveItem.Text = "Save Data";
            this.tblLeveranciersBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblLeveranciersBindingNavigatorSaveItem_Click);
            // 
            // leveranciersnummerLabel
            // 
            leveranciersnummerLabel.AutoSize = true;
            leveranciersnummerLabel.Location = new System.Drawing.Point(91, 61);
            leveranciersnummerLabel.Name = "leveranciersnummerLabel";
            leveranciersnummerLabel.Size = new System.Drawing.Size(108, 13);
            leveranciersnummerLabel.TabIndex = 1;
            leveranciersnummerLabel.Text = "Leveranciersnummer:";
            // 
            // leveranciersnummerTextBox
            // 
            this.leveranciersnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblLeveranciersBindingSource, "Leveranciersnummer", true));
            this.leveranciersnummerTextBox.Location = new System.Drawing.Point(205, 58);
            this.leveranciersnummerTextBox.Name = "leveranciersnummerTextBox";
            this.leveranciersnummerTextBox.Size = new System.Drawing.Size(100, 20);
            this.leveranciersnummerTextBox.TabIndex = 2;
            // 
            // bedrijfLabel
            // 
            bedrijfLabel.AutoSize = true;
            bedrijfLabel.Location = new System.Drawing.Point(91, 87);
            bedrijfLabel.Name = "bedrijfLabel";
            bedrijfLabel.Size = new System.Drawing.Size(39, 13);
            bedrijfLabel.TabIndex = 3;
            bedrijfLabel.Text = "Bedrijf:";
            // 
            // bedrijfTextBox
            // 
            this.bedrijfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblLeveranciersBindingSource, "Bedrijf", true));
            this.bedrijfTextBox.Location = new System.Drawing.Point(205, 84);
            this.bedrijfTextBox.Name = "bedrijfTextBox";
            this.bedrijfTextBox.Size = new System.Drawing.Size(100, 20);
            this.bedrijfTextBox.TabIndex = 4;
            // 
            // tblProductenBindingSource
            // 
            this.tblProductenBindingSource.DataMember = "tblLeveranciers_tblProducten";
            this.tblProductenBindingSource.DataSource = this.tblLeveranciersBindingSource;
            // 
            // tblProductenTableAdapter
            // 
            this.tblProductenTableAdapter.ClearBeforeFill = true;
            // 
            // tblProductenDataGridView
            // 
            this.tblProductenDataGridView.AutoGenerateColumns = false;
            this.tblProductenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tblProductenDataGridView.DataSource = this.tblProductenBindingSource;
            this.tblProductenDataGridView.Location = new System.Drawing.Point(0, 145);
            this.tblProductenDataGridView.Name = "tblProductenDataGridView";
            this.tblProductenDataGridView.Size = new System.Drawing.Size(800, 220);
            this.tblProductenDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Productnummer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Productnummer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Leveranciersnummer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Leveranciersnummer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Categorienummer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Categorienummer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Productnaam";
            this.dataGridViewTextBoxColumn4.HeaderText = "Productnaam";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NederlandseNaam";
            this.dataGridViewTextBoxColumn5.HeaderText = "NederlandseNaam";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HoeveelheidPerEenheid";
            this.dataGridViewTextBoxColumn6.HeaderText = "HoeveelheidPerEenheid";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PrijsPerEenheid";
            this.dataGridViewTextBoxColumn7.HeaderText = "PrijsPerEenheid";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Voorraad";
            this.dataGridViewTextBoxColumn8.HeaderText = "Voorraad";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Oef5H23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblProductenDataGridView);
            this.Controls.Add(leveranciersnummerLabel);
            this.Controls.Add(this.leveranciersnummerTextBox);
            this.Controls.Add(bedrijfLabel);
            this.Controls.Add(this.bedrijfTextBox);
            this.Controls.Add(this.tblLeveranciersBindingNavigator);
            this.Name = "Oef5H23";
            this.Text = "Oef5H23";
            this.Load += new System.EventHandler(this.Oef5H23_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsOef5Twee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLeveranciersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLeveranciersBindingNavigator)).EndInit();
            this.tblLeveranciersBindingNavigator.ResumeLayout(false);
            this.tblLeveranciersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dtsOef5Twee dtsOef5Twee;
        private System.Windows.Forms.BindingSource tblLeveranciersBindingSource;
        private dtsOef5TweeTableAdapters.tblLeveranciersTableAdapter tblLeveranciersTableAdapter;
        private dtsOef5TweeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblLeveranciersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblLeveranciersBindingNavigatorSaveItem;
        private dtsOef5TweeTableAdapters.tblProductenTableAdapter tblProductenTableAdapter;
        private System.Windows.Forms.TextBox leveranciersnummerTextBox;
        private System.Windows.Forms.TextBox bedrijfTextBox;
        private System.Windows.Forms.BindingSource tblProductenBindingSource;
        private System.Windows.Forms.DataGridView tblProductenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}