namespace Projket
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uporabnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnesDataSet1 = new Projket.FitnesDataSet();
            this.fitnesDataSet = new Projket.FitnesDataSet();
            this.fitnesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uporabnikTableAdapter = new Projket.FitnesDataSetTableAdapters.UporabnikTableAdapter();
            this.pogled_trenigovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pogled_trenigovTableAdapter = new Projket.FitnesDataSetTableAdapters.Pogled_trenigovTableAdapter();
            this.tableAdapterManager = new Projket.FitnesDataSetTableAdapters.TableAdapterManager();
            this.plan_treningovTableAdapter = new Projket.FitnesDataSetTableAdapters.Plan_treningovTableAdapter();
            this.pogled_tipov_članstvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plan_treningovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pogled_tipov_in_clanovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pogled_tipov_in_clanovTableAdapter = new Projket.FitnesDataSetTableAdapters.Pogled_tipov_in_clanovTableAdapter();
            this.pogled_tipov_članstvaTableAdapter = new Projket.FitnesDataSetTableAdapters.Pogled_tipov_članstvaTableAdapter();
            this.tipi_clanstva_po_tip_idBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipi_clanstva_po_tip_idTableAdapter = new Projket.FitnesDataSetTableAdapters.Tipi_clanstva_po_tip_idTableAdapter();
            this.clan_uporabnik_pogledBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clan_uporabnik_pogledTableAdapter = new Projket.FitnesDataSetTableAdapters.Clan_uporabnik_pogledTableAdapter();
            this.clanih_po_clan_idBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clanih_po_clan_idTableAdapter = new Projket.FitnesDataSetTableAdapters.Clanih_po_clan_idTableAdapter();
            this.plani_treningiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plani_treningiTableAdapter = new Projket.FitnesDataSetTableAdapters.Plani_treningiTableAdapter();
            this.fitnesDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pogledtrenigovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.infromacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vrsteTrenigovToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipiČlanstvaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.kdajTiPotečeČlanstvoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.urejanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uporabnikovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.članovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipovČlanstvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treningovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogled_trenigovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogled_tipov_članstvaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_treningovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogled_tipov_in_clanovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipi_clanstva_po_tip_idBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan_uporabnik_pogledBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanih_po_clan_idBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plani_treningiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledtrenigovBindingSource)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uporabnikBindingSource
            // 
            this.uporabnikBindingSource.DataMember = "Uporabnik";
            this.uporabnikBindingSource.DataSource = this.fitnesDataSet1;
            // 
            // fitnesDataSet1
            // 
            this.fitnesDataSet1.DataSetName = "FitnesDataSet";
            this.fitnesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fitnesDataSet
            // 
            this.fitnesDataSet.DataSetName = "FitnesDataSet";
            this.fitnesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fitnesDataSetBindingSource
            // 
            this.fitnesDataSetBindingSource.DataSource = this.fitnesDataSet;
            this.fitnesDataSetBindingSource.Position = 0;
            // 
            // uporabnikTableAdapter
            // 
            this.uporabnikTableAdapter.ClearBeforeFill = true;
            // 
            // pogled_trenigovBindingSource
            // 
            this.pogled_trenigovBindingSource.DataMember = "Pogled_trenigov";
            this.pogled_trenigovBindingSource.DataSource = this.fitnesDataSet1;
            // 
            // pogled_trenigovTableAdapter
            // 
            this.pogled_trenigovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClanTableAdapter = null;
            this.tableAdapterManager.Plan_treningovTableAdapter = this.plan_treningovTableAdapter;
            this.tableAdapterManager.Tip_clanstvaTableAdapter = null;
            this.tableAdapterManager.TreningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projket.FitnesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UporabnikTableAdapter = this.uporabnikTableAdapter;
            // 
            // plan_treningovTableAdapter
            // 
            this.plan_treningovTableAdapter.ClearBeforeFill = true;
            // 
            // pogled_tipov_članstvaBindingSource
            // 
            this.pogled_tipov_članstvaBindingSource.DataMember = "Pogled_tipov_članstva";
            this.pogled_tipov_članstvaBindingSource.DataSource = this.fitnesDataSet1;
            // 
            // plan_treningovBindingSource
            // 
            this.plan_treningovBindingSource.DataMember = "Plan_treningov";
            this.plan_treningovBindingSource.DataSource = this.fitnesDataSet1;
            // 
            // pogled_tipov_in_clanovBindingSource
            // 
            this.pogled_tipov_in_clanovBindingSource.DataMember = "Pogled_tipov_in_clanov";
            this.pogled_tipov_in_clanovBindingSource.DataSource = this.fitnesDataSet1;
            // 
            // pogled_tipov_in_clanovTableAdapter
            // 
            this.pogled_tipov_in_clanovTableAdapter.ClearBeforeFill = true;
            // 
            // pogled_tipov_članstvaTableAdapter
            // 
            this.pogled_tipov_članstvaTableAdapter.ClearBeforeFill = true;
            // 
            // tipi_clanstva_po_tip_idBindingSource
            // 
            this.tipi_clanstva_po_tip_idBindingSource.DataMember = "Tipi_clanstva_po_tip_id";
            this.tipi_clanstva_po_tip_idBindingSource.DataSource = this.fitnesDataSet1;
            // 
            // tipi_clanstva_po_tip_idTableAdapter
            // 
            this.tipi_clanstva_po_tip_idTableAdapter.ClearBeforeFill = true;
            // 
            // clan_uporabnik_pogledBindingSource
            // 
            this.clan_uporabnik_pogledBindingSource.DataMember = "Clan_uporabnik_pogled";
            this.clan_uporabnik_pogledBindingSource.DataSource = this.fitnesDataSet1;
            // 
            // clan_uporabnik_pogledTableAdapter
            // 
            this.clan_uporabnik_pogledTableAdapter.ClearBeforeFill = true;
            // 
            // clanih_po_clan_idBindingSource
            // 
            this.clanih_po_clan_idBindingSource.DataMember = "Clanih_po_clan_id";
            this.clanih_po_clan_idBindingSource.DataSource = this.fitnesDataSet1;
            // 
            // clanih_po_clan_idTableAdapter
            // 
            this.clanih_po_clan_idTableAdapter.ClearBeforeFill = true;
            // 
            // plani_treningiBindingSource
            // 
            this.plani_treningiBindingSource.DataMember = "Plani_treningi";
            this.plani_treningiBindingSource.DataSource = this.fitnesDataSet1;
            // 
            // plani_treningiTableAdapter
            // 
            this.plani_treningiTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.Snow;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infromacijeToolStripMenuItem,
            this.urejanjeToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(325, 29);
            this.menuStrip3.TabIndex = 21;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // infromacijeToolStripMenuItem
            // 
            this.infromacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vrsteTrenigovToolStripMenuItem1,
            this.tipiČlanstvaToolStripMenuItem2,
            this.kdajTiPotečeČlanstvoToolStripMenuItem1});
            this.infromacijeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infromacijeToolStripMenuItem.Name = "infromacijeToolStripMenuItem";
            this.infromacijeToolStripMenuItem.Size = new System.Drawing.Size(105, 25);
            this.infromacijeToolStripMenuItem.Text = "Infromacije";
            // 
            // vrsteTrenigovToolStripMenuItem1
            // 
            this.vrsteTrenigovToolStripMenuItem1.Name = "vrsteTrenigovToolStripMenuItem1";
            this.vrsteTrenigovToolStripMenuItem1.Size = new System.Drawing.Size(246, 26);
            this.vrsteTrenigovToolStripMenuItem1.Text = "Vrste trenigov";
            this.vrsteTrenigovToolStripMenuItem1.Click += new System.EventHandler(this.vrsteTrenigovToolStripMenuItem1_Click);
            // 
            // tipiČlanstvaToolStripMenuItem2
            // 
            this.tipiČlanstvaToolStripMenuItem2.Name = "tipiČlanstvaToolStripMenuItem2";
            this.tipiČlanstvaToolStripMenuItem2.Size = new System.Drawing.Size(246, 26);
            this.tipiČlanstvaToolStripMenuItem2.Text = "Tipi članstva";
            this.tipiČlanstvaToolStripMenuItem2.Click += new System.EventHandler(this.tipiČlanstvaToolStripMenuItem2_Click);
            // 
            // kdajTiPotečeČlanstvoToolStripMenuItem1
            // 
            this.kdajTiPotečeČlanstvoToolStripMenuItem1.Name = "kdajTiPotečeČlanstvoToolStripMenuItem1";
            this.kdajTiPotečeČlanstvoToolStripMenuItem1.Size = new System.Drawing.Size(246, 26);
            this.kdajTiPotečeČlanstvoToolStripMenuItem1.Text = "Kdaj ti poteče članstvo";
            this.kdajTiPotečeČlanstvoToolStripMenuItem1.Click += new System.EventHandler(this.kdajTiPotečeČlanstvoToolStripMenuItem1_Click);
            // 
            // urejanjeToolStripMenuItem
            // 
            this.urejanjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uporabnikovToolStripMenuItem,
            this.članovToolStripMenuItem,
            this.tipovČlanstvaToolStripMenuItem,
            this.planovToolStripMenuItem,
            this.treningovToolStripMenuItem});
            this.urejanjeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.urejanjeToolStripMenuItem.Name = "urejanjeToolStripMenuItem";
            this.urejanjeToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.urejanjeToolStripMenuItem.Text = "Urejanje";
            // 
            // uporabnikovToolStripMenuItem
            // 
            this.uporabnikovToolStripMenuItem.Name = "uporabnikovToolStripMenuItem";
            this.uporabnikovToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.uporabnikovToolStripMenuItem.Text = "Uporabnikov";
            this.uporabnikovToolStripMenuItem.Click += new System.EventHandler(this.uporabnikovToolStripMenuItem_Click);
            // 
            // članovToolStripMenuItem
            // 
            this.članovToolStripMenuItem.Name = "članovToolStripMenuItem";
            this.članovToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.članovToolStripMenuItem.Text = "Članov";
            this.članovToolStripMenuItem.Click += new System.EventHandler(this.članovToolStripMenuItem_Click);
            // 
            // tipovČlanstvaToolStripMenuItem
            // 
            this.tipovČlanstvaToolStripMenuItem.Name = "tipovČlanstvaToolStripMenuItem";
            this.tipovČlanstvaToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.tipovČlanstvaToolStripMenuItem.Text = "Tipov članstva";
            this.tipovČlanstvaToolStripMenuItem.Click += new System.EventHandler(this.tipovČlanstvaToolStripMenuItem_Click);
            // 
            // planovToolStripMenuItem
            // 
            this.planovToolStripMenuItem.Name = "planovToolStripMenuItem";
            this.planovToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.planovToolStripMenuItem.Text = "Planov ";
            this.planovToolStripMenuItem.Click += new System.EventHandler(this.planovToolStripMenuItem_Click);
            // 
            // treningovToolStripMenuItem
            // 
            this.treningovToolStripMenuItem.Name = "treningovToolStripMenuItem";
            this.treningovToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.treningovToolStripMenuItem.Text = "Treningov";
            this.treningovToolStripMenuItem.Click += new System.EventHandler(this.treningovToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dobrodošli v fitnes aplikaciji!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(85, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Made by Luka Slapnik";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(325, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fitnes aplikacija - domača stran";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogled_trenigovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogled_tipov_članstvaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_treningovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogled_tipov_in_clanovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipi_clanstva_po_tip_idBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan_uporabnik_pogledBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanih_po_clan_idBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plani_treningiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogledtrenigovBindingSource)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource fitnesDataSetBindingSource;
        private System.Windows.Forms.BindingSource fitnesDataSetBindingSource1;
        private Projket.FitnesDataSet fitnesDataSet;
        private FitnesDataSet fitnesDataSet1;
        private System.Windows.Forms.BindingSource uporabnikBindingSource;
        private FitnesDataSetTableAdapters.UporabnikTableAdapter uporabnikTableAdapter;
        private System.Windows.Forms.BindingSource pogledtrenigovBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pridruzitevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potekclanstvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uporabnikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pogled_trenigovBindingSource;
        private FitnesDataSetTableAdapters.Pogled_trenigovTableAdapter pogled_trenigovTableAdapter;
        private FitnesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FitnesDataSetTableAdapters.Plan_treningovTableAdapter plan_treningovTableAdapter;
        private System.Windows.Forms.BindingSource plan_treningovBindingSource;
        private System.Windows.Forms.BindingSource pogled_tipov_in_clanovBindingSource;
        private FitnesDataSetTableAdapters.Pogled_tipov_in_clanovTableAdapter pogled_tipov_in_clanovTableAdapter;
        private System.Windows.Forms.BindingSource pogled_tipov_članstvaBindingSource;
        private FitnesDataSetTableAdapters.Pogled_tipov_članstvaTableAdapter pogled_tipov_članstvaTableAdapter;
        private System.Windows.Forms.BindingSource tipi_clanstva_po_tip_idBindingSource;
        private FitnesDataSetTableAdapters.Tipi_clanstva_po_tip_idTableAdapter tipi_clanstva_po_tip_idTableAdapter;
        private System.Windows.Forms.BindingSource clan_uporabnik_pogledBindingSource;
        private FitnesDataSetTableAdapters.Clan_uporabnik_pogledTableAdapter clan_uporabnik_pogledTableAdapter;
        private System.Windows.Forms.BindingSource clanih_po_clan_idBindingSource;
        private FitnesDataSetTableAdapters.Clanih_po_clan_idTableAdapter clanih_po_clan_idTableAdapter;
        private System.Windows.Forms.BindingSource plani_treningiBindingSource;
        private FitnesDataSetTableAdapters.Plani_treningiTableAdapter plani_treningiTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem infromacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vrsteTrenigovToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipiČlanstvaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem kdajTiPotečeČlanstvoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem urejanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uporabnikovToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članovToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipovČlanstvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planovToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treningovToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

