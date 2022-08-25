namespace Projket
{
    partial class POGLED_potek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POGLED_potek));
            this.fitnesDataSet = new Projket.FitnesDataSet();
            this.clan_uporabnik_pogledBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clan_uporabnik_pogledTableAdapter = new Projket.FitnesDataSetTableAdapters.Clan_uporabnik_pogledTableAdapter();
            this.tableAdapterManager = new Projket.FitnesDataSetTableAdapters.TableAdapterManager();
            this.clan_uporabnik_pogledDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan_uporabnik_pogledBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan_uporabnik_pogledDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fitnesDataSet
            // 
            this.fitnesDataSet.DataSetName = "FitnesDataSet";
            this.fitnesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clan_uporabnik_pogledBindingSource
            // 
            this.clan_uporabnik_pogledBindingSource.DataMember = "Clan_uporabnik_pogled";
            this.clan_uporabnik_pogledBindingSource.DataSource = this.fitnesDataSet;
            // 
            // clan_uporabnik_pogledTableAdapter
            // 
            this.clan_uporabnik_pogledTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClanTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Plan_treningovTableAdapter = null;
            this.tableAdapterManager.Tip_clanstvaTableAdapter = null;
            this.tableAdapterManager.TreningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projket.FitnesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UporabnikTableAdapter = null;
            // 
            // clan_uporabnik_pogledDataGridView
            // 
            this.clan_uporabnik_pogledDataGridView.AllowUserToAddRows = false;
            this.clan_uporabnik_pogledDataGridView.AllowUserToDeleteRows = false;
            this.clan_uporabnik_pogledDataGridView.AutoGenerateColumns = false;
            this.clan_uporabnik_pogledDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clan_uporabnik_pogledDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.clan_uporabnik_pogledDataGridView.DataSource = this.clan_uporabnik_pogledBindingSource;
            this.clan_uporabnik_pogledDataGridView.Location = new System.Drawing.Point(16, 68);
            this.clan_uporabnik_pogledDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clan_uporabnik_pogledDataGridView.Name = "clan_uporabnik_pogledDataGridView";
            this.clan_uporabnik_pogledDataGridView.ReadOnly = true;
            this.clan_uporabnik_pogledDataGridView.Size = new System.Drawing.Size(444, 220);
            this.clan_uporabnik_pogledDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Priimek";
            this.dataGridViewTextBoxColumn2.HeaderText = "Priimek";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Datum pridruzitve";
            this.dataGridViewTextBoxColumn3.HeaderText = "Datum pridruzitve";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Datum poteka clanstva";
            this.dataGridViewTextBoxColumn4.HeaderText = "Datum poteka clanstva";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(177, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Potek članstva";
            // 
            // POGLED_potek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clan_uporabnik_pogledDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POGLED_potek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kdaj ti poteče članstvo";
            this.Load += new System.EventHandler(this.POGLED_potek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan_uporabnik_pogledBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan_uporabnik_pogledDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FitnesDataSet fitnesDataSet;
        private System.Windows.Forms.BindingSource clan_uporabnik_pogledBindingSource;
        private FitnesDataSetTableAdapters.Clan_uporabnik_pogledTableAdapter clan_uporabnik_pogledTableAdapter;
        private FitnesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clan_uporabnik_pogledDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
    }
}