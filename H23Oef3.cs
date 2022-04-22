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
    public partial class H23Oef3 : Form
    {
        public H23Oef3()
        {
            InitializeComponent();
        }

        private void tblProductenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProductenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtsOef3);

        }

        private void H23Oef3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsOef3.tblProducten' table. You can move, or remove it, as needed.
            this.tblProductenTableAdapter.Fill(this.dtsOef3.tblProducten);

        }
    }
}
