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
    public partial class Form1 : Form
    {
 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnesDataSet1.Plani_treningi' table. You can move, or remove it, as needed.
            this.plani_treningiTableAdapter.Fill(this.fitnesDataSet1.Plani_treningi);
            // TODO: This line of code loads data into the 'fitnesDataSet1.Clan_uporabnik_pogled' table. You can move, or remove it, as needed.
            this.clan_uporabnik_pogledTableAdapter.Fill(this.fitnesDataSet1.Clan_uporabnik_pogled);
            // TODO: This line of code loads data into the 'fitnesDataSet1.Pogled_tipov_članstva' table. You can move, or remove it, as needed.
            this.pogled_tipov_članstvaTableAdapter.Fill(this.fitnesDataSet1.Pogled_tipov_članstva);
            // TODO: This line of code loads data into the 'fitnesDataSet1.Pogled_tipov_in_clanov' table. You can move, or remove it, as needed.
            this.pogled_tipov_in_clanovTableAdapter.Fill(this.fitnesDataSet1.Pogled_tipov_in_clanov);
            // TODO: This line of code loads data into the 'fitnesDataSet1.Plan_treningov' table. You can move, or remove it, as needed.
            this.plan_treningovTableAdapter.Fill(this.fitnesDataSet1.Plan_treningov);
            // TODO: This line of code loads data into the 'fitnesDataSet1.Pogled_trenigov' table. You can move, or remove it, as needed.
            this.pogled_trenigovTableAdapter.Fill(this.fitnesDataSet1.Pogled_trenigov);


        }

        private void vrsteTrenigovToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            POGLED_vrste_treningov sedemOkno = new POGLED_vrste_treningov();
            sedemOkno.ShowDialog();
        }

        private void tipiČlanstvaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            POGLED_Tipi_clanstva devetOkno = new POGLED_Tipi_clanstva();
            devetOkno.ShowDialog();
        }

        private void kdajTiPotečeČlanstvoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            POGLED_potek destOkno = new POGLED_potek();
            destOkno.ShowDialog();
        }

        private void uporabnikovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uporabniki drugoOkno = new Uporabniki();
            drugoOkno.ShowDialog(); 
        }

        private void članovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Člani tretjeOkno = new Člani();
            tretjeOkno.ShowDialog();
        }

        private void tipovČlanstvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipi_clanstva četrtoOkno = new Tipi_clanstva();
            četrtoOkno.ShowDialog();
        }

        private void planovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plani_treningov petkoOkno = new Plani_treningov();
            petkoOkno.ShowDialog();
        }

        private void treningovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Treningi šestoOkno = new Treningi();
            šestoOkno.ShowDialog();
        }

    }
}
