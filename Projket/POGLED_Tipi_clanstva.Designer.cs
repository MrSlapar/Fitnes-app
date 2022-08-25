namespace Projket
{
    partial class POGLED_Tipi_clanstva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POGLED_Tipi_clanstva));
            this.fitnesDataSet = new Projket.FitnesDataSet();
            this.tip_clanstvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_clanstvaTableAdapter = new Projket.FitnesDataSetTableAdapters.Tip_clanstvaTableAdapter();
            this.tableAdapterManager = new Projket.FitnesDataSetTableAdapters.TableAdapterManager();
            this.tip_clanstvaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fitnesDataSet
            // 
            this.fitnesDataSet.DataSetName = "FitnesDataSet";
            this.fitnesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tip_clanstvaBindingSource
            // 
            this.tip_clanstvaBindingSource.DataMember = "Tip_clanstva";
            this.tip_clanstvaBindingSource.DataSource = this.fitnesDataSet;
            // 
            // tip_clanstvaTableAdapter
            // 
            this.tip_clanstvaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClanTableAdapter = null;
            this.tableAdapterManager.Plan_treningovTableAdapter = null;
            this.tableAdapterManager.Tip_clanstvaTableAdapter = this.tip_clanstvaTableAdapter;
            this.tableAdapterManager.TreningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projket.FitnesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UporabnikTableAdapter = null;
            // 
            // tip_clanstvaDataGridView
            // 
            this.tip_clanstvaDataGridView.AllowUserToAddRows = false;
            this.tip_clanstvaDataGridView.AllowUserToDeleteRows = false;
            this.tip_clanstvaDataGridView.AutoGenerateColumns = false;
            this.tip_clanstvaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tip_clanstvaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tip_clanstvaDataGridView.DataSource = this.tip_clanstvaBindingSource;
            this.tip_clanstvaDataGridView.Location = new System.Drawing.Point(14, 57);
            this.tip_clanstvaDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tip_clanstvaDataGridView.Name = "tip_clanstvaDataGridView";
            this.tip_clanstvaDataGridView.ReadOnly = true;
            this.tip_clanstvaDataGridView.Size = new System.Drawing.Size(345, 156);
            this.tip_clanstvaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime članstva";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Znesek";
            this.dataGridViewTextBoxColumn3.HeaderText = "Znesek";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Trajanje";
            this.dataGridViewTextBoxColumn4.HeaderText = "Trajanje";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(137, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipi člansev";
            // 
            // POGLED_Tipi_clanstva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tip_clanstvaDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POGLED_Tipi_clanstva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipi članstev";
            this.Load += new System.EventHandler(this.POGLED_Tipi_clanstva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FitnesDataSet fitnesDataSet;
        private System.Windows.Forms.BindingSource tip_clanstvaBindingSource;
        private FitnesDataSetTableAdapters.Tip_clanstvaTableAdapter tip_clanstvaTableAdapter;
        private FitnesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tip_clanstvaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
    }
}