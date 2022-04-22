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
    public partial class H23Oef2 : Form
    {
        public H23Oef2()
        {
            InitializeComponent();
        }

        private void tblKlantenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblKlantenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtsOrders);

        }

        private void H23Oef2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsOrders.tblOrderinformatie' table. You can move, or remove it, as needed.
            this.tblOrderinformatieTableAdapter.Fill(this.dtsOrders.tblOrderinformatie);
            // TODO: This line of code loads data into the 'dtsOrders.tblOrders' table. You can move, or remove it, as needed.
            this.tblOrdersTableAdapter.Fill(this.dtsOrders.tblOrders);
            // TODO: This line of code loads data into the 'dtsOrders.tblKlanten' table. You can move, or remove it, as needed.
            this.tblKlantenTableAdapter.Fill(this.dtsOrders.tblKlanten);

        }
    }
}
