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
    public partial class POGLED_vrste_treningov : Form
    {
        public POGLED_vrste_treningov()
        {
            InitializeComponent();
        }

        private void vrste_treningov_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnesDataSet.Pogled_trenigov' table. You can move, or remove it, as needed.
            this.pogled_trenigovTableAdapter.Fill(this.fitnesDataSet.Pogled_trenigov);

        }

     
    }
}
