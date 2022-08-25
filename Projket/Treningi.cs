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
    public partial class Treningi : Form
    {
        public Treningi()
        {
            InitializeComponent();
        }

        private void treningBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.treningBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnesDataSet);

        }

        private void treningBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.treningBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnesDataSet);

        }

        private void Treningi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnesDataSet.Trening' table. You can move, or remove it, as needed.
            this.treningTableAdapter.Fill(this.fitnesDataSet.Trening);

        }
    }
}
