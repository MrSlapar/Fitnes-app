namespace Projket
{
    partial class Tipi_clanstva
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
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label znesekLabel;
            System.Windows.Forms.Label trajanjeLabel;
            System.Windows.Forms.Label provizijaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tipi_clanstva));
            this.fitnesDataSet = new Projket.FitnesDataSet();
            this.tip_clanstvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_clanstvaTableAdapter = new Projket.FitnesDataSetTableAdapters.Tip_clanstvaTableAdapter();
            this.tableAdapterManager = new Projket.FitnesDataSetTableAdapters.TableAdapterManager();
            this.tip_clanstvaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tip_clanstvaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.znesekTextBox = new System.Windows.Forms.TextBox();
            this.trajanjeTextBox = new System.Windows.Forms.TextBox();
            this.provizijaTextBox = new System.Windows.Forms.TextBox();
            this.tip_clanstvaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pogled_uporabnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pogled_uporabnikTableAdapter = new Projket.FitnesDataSetTableAdapters.Pogled_uporabnikTableAdapter();
            this.fitnesDataSet1 = new Projket.FitnesDataSet();
            imeLabel = new System.Windows.Forms.Label();
            znesekLabel = new System.Windows.Forms.Label();
            trajanjeLabel = new System.Windows.Forms.Label();
            provizijaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaBindingNavigator)).BeginInit();
            this.tip_clanstvaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogled_uporabnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            imeLabel.Location = new System.Drawing.Point(589, 96);
            imeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(31, 13);
            imeLabel.TabIndex = 1;
            imeLabel.Text = "Ime:";
            // 
            // znesekLabel
            // 
            znesekLabel.AutoSize = true;
            znesekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            znesekLabel.Location = new System.Drawing.Point(589, 122);
            znesekLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            znesekLabel.Name = "znesekLabel";
            znesekLabel.Size = new System.Drawing.Size(53, 13);
            znesekLabel.TabIndex = 3;
            znesekLabel.Text = "Znesek:";
            // 
            // trajanjeLabel
            // 
            trajanjeLabel.AutoSize = true;
            trajanjeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            trajanjeLabel.Location = new System.Drawing.Point(589, 148);
            trajanjeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trajanjeLabel.Name = "trajanjeLabel";
            trajanjeLabel.Size = new System.Drawing.Size(57, 13);
            trajanjeLabel.TabIndex = 5;
            trajanjeLabel.Text = "Trajanje:";
            // 
            // provizijaLabel
            // 
            provizijaLabel.AutoSize = true;
            provizijaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            provizijaLabel.Location = new System.Drawing.Point(589, 174);
            provizijaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            provizijaLabel.Name = "provizijaLabel";
            provizijaLabel.Size = new System.Drawing.Size(59, 13);
            provizijaLabel.TabIndex = 7;
            provizijaLabel.Text = "Provizija:";
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
            // tip_clanstvaBindingNavigator
            // 
            this.tip_clanstvaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tip_clanstvaBindingNavigator.BindingSource = this.tip_clanstvaBindingSource;
            this.tip_clanstvaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tip_clanstvaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tip_clanstvaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tip_clanstvaBindingNavigatorSaveItem});
            this.tip_clanstvaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tip_clanstvaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tip_clanstvaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tip_clanstvaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tip_clanstvaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tip_clanstvaBindingNavigator.Name = "tip_clanstvaBindingNavigator";
            this.tip_clanstvaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tip_clanstvaBindingNavigator.Size = new System.Drawing.Size(789, 25);
            this.tip_clanstvaBindingNavigator.TabIndex = 0;
            this.tip_clanstvaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tip_clanstvaBindingNavigatorSaveItem
            // 
            this.tip_clanstvaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tip_clanstvaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tip_clanstvaBindingNavigatorSaveItem.Image")));
            this.tip_clanstvaBindingNavigatorSaveItem.Name = "tip_clanstvaBindingNavigatorSaveItem";
            this.tip_clanstvaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tip_clanstvaBindingNavigatorSaveItem.Text = "Save Data";
            this.tip_clanstvaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tip_clanstvaBindingNavigatorSaveItem_Click);
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tip_clanstvaBindingSource, "ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(653, 93);
            this.imeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(116, 20);
            this.imeTextBox.TabIndex = 2;
            // 
            // znesekTextBox
            // 
            this.znesekTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tip_clanstvaBindingSource, "Znesek", true));
            this.znesekTextBox.Location = new System.Drawing.Point(653, 119);
            this.znesekTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.znesekTextBox.Name = "znesekTextBox";
            this.znesekTextBox.Size = new System.Drawing.Size(116, 20);
            this.znesekTextBox.TabIndex = 4;
            // 
            // trajanjeTextBox
            // 
            this.trajanjeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tip_clanstvaBindingSource, "Trajanje", true));
            this.trajanjeTextBox.Location = new System.Drawing.Point(653, 145);
            this.trajanjeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trajanjeTextBox.Name = "trajanjeTextBox";
            this.trajanjeTextBox.Size = new System.Drawing.Size(116, 20);
            this.trajanjeTextBox.TabIndex = 6;
            // 
            // provizijaTextBox
            // 
            this.provizijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tip_clanstvaBindingSource, "Provizija", true));
            this.provizijaTextBox.Location = new System.Drawing.Point(653, 171);
            this.provizijaTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.provizijaTextBox.Name = "provizijaTextBox";
            this.provizijaTextBox.Size = new System.Drawing.Size(116, 20);
            this.provizijaTextBox.TabIndex = 8;
            // 
            // tip_clanstvaDataGridView
            // 
            this.tip_clanstvaDataGridView.AutoGenerateColumns = false;
            this.tip_clanstvaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tip_clanstvaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tip_clanstvaDataGridView.DataSource = this.tip_clanstvaBindingSource;
            this.tip_clanstvaDataGridView.Location = new System.Drawing.Point(14, 94);
            this.tip_clanstvaDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tip_clanstvaDataGridView.Name = "tip_clanstvaDataGridView";
            this.tip_clanstvaDataGridView.Size = new System.Drawing.Size(544, 178);
            this.tip_clanstvaDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tip_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "tip_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Znesek";
            this.dataGridViewTextBoxColumn3.HeaderText = "Znesek";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Trajanje";
            this.dataGridViewTextBoxColumn4.HeaderText = "Trajanje";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Provizija";
            this.dataGridViewTextBoxColumn5.HeaderText = "Provizija";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(255, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Urejanje tipov članstva";
            // 
            // pogled_uporabnikBindingSource
            // 
            this.pogled_uporabnikBindingSource.DataMember = "Pogled_uporabnik";
            this.pogled_uporabnikBindingSource.DataSource = this.fitnesDataSet;
            // 
            // pogled_uporabnikTableAdapter
            // 
            this.pogled_uporabnikTableAdapter.ClearBeforeFill = true;
            // 
            // fitnesDataSet1
            // 
            this.fitnesDataSet1.DataSetName = "FitnesDataSet";
            this.fitnesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tipi_clanstva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tip_clanstvaDataGridView);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(znesekLabel);
            this.Controls.Add(this.znesekTextBox);
            this.Controls.Add(trajanjeLabel);
            this.Controls.Add(this.trajanjeTextBox);
            this.Controls.Add(provizijaLabel);
            this.Controls.Add(this.provizijaTextBox);
            this.Controls.Add(this.tip_clanstvaBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tipi_clanstva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipi_clanstva";
            this.Load += new System.EventHandler(this.Tipi_clanstva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaBindingNavigator)).EndInit();
            this.tip_clanstvaBindingNavigator.ResumeLayout(false);
            this.tip_clanstvaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogled_uporabnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FitnesDataSet fitnesDataSet;
        private System.Windows.Forms.BindingSource tip_clanstvaBindingSource;
        private FitnesDataSetTableAdapters.Tip_clanstvaTableAdapter tip_clanstvaTableAdapter;
        private FitnesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tip_clanstvaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tip_clanstvaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox znesekTextBox;
        private System.Windows.Forms.TextBox trajanjeTextBox;
        private System.Windows.Forms.TextBox provizijaTextBox;
        private System.Windows.Forms.DataGridView tip_clanstvaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pogled_uporabnikBindingSource;
        private FitnesDataSetTableAdapters.Pogled_uporabnikTableAdapter pogled_uporabnikTableAdapter;
        private FitnesDataSet fitnesDataSet1;
    }
}