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
    public partial class POGLED_potek : Form
    {
        public POGLED_potek()
        {
            InitializeComponent();
        }

        private void POGLED_potek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnesDataSet.Clan_uporabnik_pogled' table. You can move, or remove it, as needed.
            this.clan_uporabnik_pogledTableAdapter.Fill(this.fitnesDataSet.Clan_uporabnik_pogled);

        }
    }
}
