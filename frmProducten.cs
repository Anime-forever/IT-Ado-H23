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
    public partial class frmProducten : Form
    {
        public frmProducten()
        {
            InitializeComponent();
        }

        private void tblProductenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProductenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtsProducten);

        }

        private void frmProducten_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsProducten.tblVerzenders' table. You can move, or remove it, as needed.
            this.tblVerzendersTableAdapter.Fill(this.dtsProducten.tblVerzenders);
            // TODO: This line of code loads data into the 'dtsProducten.tblProducten' table. You can move, or remove it, as needed.
            //this.tblProductenTableAdapter.Fill(this.dtsProducten.tblProducten);

        }
    }
}
