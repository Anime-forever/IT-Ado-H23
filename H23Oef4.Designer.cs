namespace H23
{
    partial class H23Oef4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H23Oef4));
            this.dtsOef4 = new H23.dtsOef4();
            this.tblProductenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductenTableAdapter = new H23.dtsOef4TableAdapters.tblProductenTableAdapter();
            this.tableAdapterManager = new H23.dtsOef4TableAdapters.TableAdapterManager();
            this.tblProductenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblProductenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tblProductenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtsOef4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingNavigator)).BeginInit();
            this.tblProductenBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsOef4
            // 
            this.dtsOef4.DataSetName = "dtsOef4";
            this.dtsOef4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductenBindingSource
            // 
            this.tblProductenBindingSource.DataMember = "tblProducten";
            this.tblProductenBindingSource.DataSource = this.dtsOef4;
            // 
            // tblProductenTableAdapter
            // 
            this.tblProductenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblProductenTableAdapter = this.tblProductenTableAdapter;
            this.tableAdapterManager.UpdateOrder = H23.dtsOef4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblProductenBindingNavigator
            // 
            this.tblProductenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblProductenBindingNavigator.BindingSource = this.tblProductenBindingSource;
            this.tblProductenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblProductenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblProductenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblProductenBindingNavigatorSaveItem});
            this.tblProductenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblProductenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblProductenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblProductenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblProductenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblProductenBindingNavigator.Name = "tblProductenBindingNavigator";
            this.tblProductenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblProductenBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tblProductenBindingNavigator.TabIndex = 0;
            this.tblProductenBindingNavigator.Text = "bindingNavigator1";
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
            // tblProductenBindingNavigatorSaveItem
            // 
            this.tblProductenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblProductenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblProductenBindingNavigatorSaveItem.Image")));
            this.tblProductenBindingNavigatorSaveItem.Name = "tblProductenBindingNavigatorSaveItem";
            this.tblProductenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblProductenBindingNavigatorSaveItem.Text = "Save Data";
            this.tblProductenBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblProductenBindingNavigatorSaveItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tblProductenBindingSource1;
            this.listBox1.DisplayMember = "Productnaam";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(65, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(495, 290);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "Productnaam";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tblProductenBindingSource1
            // 
            this.tblProductenBindingSource1.DataMember = "tblProducten";
            this.tblProductenBindingSource1.DataSource = this.dtsOef4;
            // 
            // H23Oef4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tblProductenBindingNavigator);
            this.Name = "H23Oef4";
            this.Text = "H23Oef4";
            this.Load += new System.EventHandler(this.H23Oef4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsOef4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingNavigator)).EndInit();
            this.tblProductenBindingNavigator.ResumeLayout(false);
            this.tblProductenBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductenBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dtsOef4 dtsOef4;
        private System.Windows.Forms.BindingSource tblProductenBindingSource;
        private dtsOef4TableAdapters.tblProductenTableAdapter tblProductenTableAdapter;
        private dtsOef4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblProductenBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblProductenBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource tblProductenBindingSource1;
    }
}