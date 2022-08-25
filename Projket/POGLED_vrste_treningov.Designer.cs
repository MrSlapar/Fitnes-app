namespace Projket
{
    partial class POGLED_vrste_treningov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POGLED_vrste_treningov));
            this.fitnesDataSet = new Projket.FitnesDataSet();
            this.pogled_trenigovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pogled_trenigovTableAdapter = new Projket.FitnesDataSetTableAdapters.Pogled_trenigovTableAdapter();
            this.tableAdapterManager = new Projket.FitnesDataSetTableAdapters.TableAdapterManager();
            this.pogled_trenigovDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogled_trenigovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogled_trenigovDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fitnesDataSet
            // 
            this.fitnesDataSet.DataSetName = "FitnesDataSet";
            this.fitnesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pogled_trenigovBindingSource
            // 
            this.pogled_trenigovBindingSource.DataMember = "Pogled_trenigov";
            this.pogled_trenigovBindingSource.DataSource = this.fitnesDataSet;
            // 
            // pogled_trenigovTableAdapter
            // 
            this.pogled_trenigovTableAdapter.ClearBeforeFill = true;
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
            // pogled_trenigovDataGridView
            // 
            this.pogled_trenigovDataGridView.AllowUserToAddRows = false;
            this.pogled_trenigovDataGridView.AllowUserToDeleteRows = false;
            this.pogled_trenigovDataGridView.AutoGenerateColumns = false;
            this.pogled_trenigovDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.pogled_trenigovDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pogled_trenigovDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.pogled_trenigovDataGridView.DataSource = this.pogled_trenigovBindingSource;
            this.pogled_trenigovDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.pogled_trenigovDataGridView.Location = new System.Drawing.Point(14, 52);
            this.pogled_trenigovDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pogled_trenigovDataGridView.Name = "pogled_trenigovDataGridView";
            this.pogled_trenigovDataGridView.ReadOnly = true;
            this.pogled_trenigovDataGridView.Size = new System.Drawing.Size(144, 220);
            this.pogled_trenigovDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn1.HeaderText = "Imena treningov";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Treningi ";
            // 
            // POGLED_vrste_treningov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pogled_trenigovDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POGLED_vrste_treningov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vrste treningov";
            this.Load += new System.EventHandler(this.vrste_treningov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogled_trenigovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogled_trenigovDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FitnesDataSet fitnesDataSet;
        private System.Windows.Forms.BindingSource pogled_trenigovBindingSource;
        private FitnesDataSetTableAdapters.Pogled_trenigovTableAdapter pogled_trenigovTableAdapter;
        private FitnesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pogled_trenigovDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
    }
}