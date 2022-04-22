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
    public partial class frmKlantenDetails : Form
    {
        public frmKlantenDetails()
        {
            InitializeComponent();
        }

        private void tblKlantenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblKlantenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dstsKlanten);

        }

        private void frmKlantenDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dstsKlanten.tblKlanten' table. You can move, or remove it, as needed.
            this.tblKlantenTableAdapter.Fill(this.dstsKlanten.tblKlanten);

        }
    }
}
