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
    public partial class Oef5H23 : Form
    {
        public Oef5H23()
        {
            InitializeComponent();
        }

        private void tblLeveranciersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblLeveranciersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtsOef5Twee);

        }

        private void Oef5H23_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsOef5Twee.tblProducten' table. You can move, or remove it, as needed.
            this.tblProductenTableAdapter.Fill(this.dtsOef5Twee.tblProducten);
            // TODO: This line of code loads data into the 'dtsOef5Twee.tblLeveranciers' table. You can move, or remove it, as needed.
            this.tblLeveranciersTableAdapter.Fill(this.dtsOef5Twee.tblLeveranciers);

        }
    }
}
