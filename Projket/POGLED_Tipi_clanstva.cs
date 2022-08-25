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
    public partial class POGLED_Tipi_clanstva : Form
    {
        public POGLED_Tipi_clanstva()
        {
            InitializeComponent();
        }

        private void tip_clanstvaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tip_clanstvaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnesDataSet);

        }

        private void POGLED_Tipi_clanstva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnesDataSet.Tip_clanstva' table. You can move, or remove it, as needed.
            this.tip_clanstvaTableAdapter.Fill(this.fitnesDataSet.Tip_clanstva);

        }
    }
}
