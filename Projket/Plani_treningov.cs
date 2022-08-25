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
    public partial class Plani_treningov : Form
    {
        public Plani_treningov()
        {
            InitializeComponent();
        }

        private void plan_treningovBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plan_treningovBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnesDataSet);

        }

        private void Plani_treningov_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnesDataSet.Plan_treningov' table. You can move, or remove it, as needed.
            this.plan_treningovTableAdapter.Fill(this.fitnesDataSet.Plan_treningov);

        }
    }
}
