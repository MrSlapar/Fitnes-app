using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projket
{
    public partial class Uporabniki : Form
    {
        public Uporabniki()
        {
            InitializeComponent();
        }

        private void uporabnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uporabnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnesDataSet);

        }

        private void uporabnikBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.uporabnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnesDataSet);

        }

        private void Uporabniki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnesDataSet.Uporabnik' table. You can move, or remove it, as needed.
            this.uporabnikTableAdapter.Fill(this.fitnesDataSet.Uporabnik);

        }
    }
}
