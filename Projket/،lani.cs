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
    public partial class Člani : Form
    {
        public Člani()
        {
            InitializeComponent();
        }

        private void clanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnesDataSet);

        }

        private void clanBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnesDataSet);

        }

        private void Člani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnesDataSet.Uporabnik' table. You can move, or remove it, as needed.
            this.uporabnikTableAdapter.Fill(this.fitnesDataSet.Uporabnik);
            // TODO: This line of code loads data into the 'fitnesDataSet.Tip_clanstva' table. You can move, or remove it, as needed.
            this.tip_clanstvaTableAdapter.Fill(this.fitnesDataSet.Tip_clanstva);
            // TODO: This line of code loads data into the 'fitnesDataSet.Clan' table. You can move, or remove it, as needed.
            this.clanTableAdapter.Fill(this.fitnesDataSet.Clan);

        }

  
    }
}
