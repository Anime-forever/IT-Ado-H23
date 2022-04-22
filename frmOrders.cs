using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H23
{
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void tblKlantenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblKlantenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dstsKlanten);

        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsOrders.tblOrders' table. You can move, or remove it, as needed.
            this.tblOrdersTableAdapter.Fill(this.dtsOrders.tblOrders);
            // TODO: This line of code loads data into the 'dtsOrders.tblOrderinformatie' table. You can move, or remove it, as needed.
            this.tblOrderinformatieTableAdapter.Fill(this.dtsOrders.tblOrderinformatie);
            // TODO: This line of code loads data into the 'dstsKlanten.tblKlanten' table. You can move, or remove it, as needed.
            this.tblKlantenTableAdapter.Fill(this.dstsKlanten.tblKlanten);

        }

        private void tblKlantenBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblKlantenBindingSource1.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.dstsKlanten1);

        }

        private void frmOrders_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsOrders1.tblKlanten' table. You can move, or remove it, as needed.
            this.tblKlantenTableAdapter2.Fill(this.dtsOrders1.tblKlanten);
            // TODO: This line of code loads data into the 'dtsOrders1.tblOrders' table. You can move, or remove it, as needed.
            this.tblOrdersTableAdapter1.Fill(this.dtsOrders1.tblOrders);
            // TODO: This line of code loads data into the 'dtsOrders1.tblOrderinformatie' table. You can move, or remove it, as needed.
            this.tblOrderinformatieTableAdapter1.Fill(this.dtsOrders1.tblOrderinformatie);
            // TODO: This line of code loads data into the 'dstsKlanten1.tblKlanten' table. You can move, or remove it, as needed.
            this.tblKlantenTableAdapter1.Fill(this.dstsKlanten1.tblKlanten);

        }
    }
}
