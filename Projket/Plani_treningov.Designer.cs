namespace Projket
{
    partial class Plani_treningov
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
            System.Windows.Forms.Label clan_idLabel;
            System.Windows.Forms.Label trener_idLabel;
            System.Windows.Forms.Label trening_idLabel;
            System.Windows.Forms.Label dnevi_treningovLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plani_treningov));
            this.plan_treningovBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.plan_treningovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnesDataSet = new Projket.FitnesDataSet();
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
            this.plan_treningovBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clan_idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.trener_idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.trening_idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dnevi_treningovTextBox = new System.Windows.Forms.TextBox();
            this.plan_treningovDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan_treningovTableAdapter = new Projket.FitnesDataSetTableAdapters.Plan_treningovTableAdapter();
            this.tableAdapterManager = new Projket.FitnesDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            clan_idLabel = new System.Windows.Forms.Label();
            trener_idLabel = new System.Windows.Forms.Label();
            trening_idLabel = new System.Windows.Forms.Label();
            dnevi_treningovLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plan_treningovBindingNavigator)).BeginInit();
            this.plan_treningovBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plan_treningovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan_idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trener_idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trening_idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_treningovDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clan_idLabel
            // 
            clan_idLabel.AutoSize = true;
            clan_idLabel.Location = new System.Drawing.Point(603, 110);
            clan_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            clan_idLabel.Name = "clan_idLabel";
            clan_idLabel.Size = new System.Drawing.Size(50, 13);
            clan_idLabel.TabIndex = 1;
            clan_idLabel.Text = "Clan id:";
            // 
            // trener_idLabel
            // 
            trener_idLabel.AutoSize = true;
            trener_idLabel.Location = new System.Drawing.Point(603, 136);
            trener_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trener_idLabel.Name = "trener_idLabel";
            trener_idLabel.Size = new System.Drawing.Size(62, 13);
            trener_idLabel.TabIndex = 3;
            trener_idLabel.Text = "Trener id:";
            // 
            // trening_idLabel
            // 
            trening_idLabel.AutoSize = true;
            trening_idLabel.Location = new System.Drawing.Point(603, 162);
            trening_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trening_idLabel.Name = "trening_idLabel";
            trening_idLabel.Size = new System.Drawing.Size(68, 13);
            trening_idLabel.TabIndex = 5;
            trening_idLabel.Text = "Trening id:";
            // 
            // dnevi_treningovLabel
            // 
            dnevi_treningovLabel.AutoSize = true;
            dnevi_treningovLabel.Location = new System.Drawing.Point(603, 191);
            dnevi_treningovLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dnevi_treningovLabel.Name = "dnevi_treningovLabel";
            dnevi_treningovLabel.Size = new System.Drawing.Size(101, 13);
            dnevi_treningovLabel.TabIndex = 7;
            dnevi_treningovLabel.Text = "Dnevi treningov:";
            // 
            // plan_treningovBindingNavigator
            // 
            this.plan_treningovBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.plan_treningovBindingNavigator.BindingSource = this.plan_treningovBindingSource;
            this.plan_treningovBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.plan_treningovBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.plan_treningovBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.plan_treningovBindingNavigatorSaveItem});
            this.plan_treningovBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.plan_treningovBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.plan_treningovBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.plan_treningovBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.plan_treningovBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.plan_treningovBindingNavigator.Name = "plan_treningovBindingNavigator";
            this.plan_treningovBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.plan_treningovBindingNavigator.Size = new System.Drawing.Size(876, 25);
            this.plan_treningovBindingNavigator.TabIndex = 0;
            this.plan_treningovBindingNavigator.Text = "bindingNavigator1";
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
            // plan_treningovBindingSource
            // 
            this.plan_treningovBindingSource.DataMember = "Plan_treningov";
            this.plan_treningovBindingSource.DataSource = this.fitnesDataSet;
            // 
            // fitnesDataSet
            // 
            this.fitnesDataSet.DataSetName = "FitnesDataSet";
            this.fitnesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // plan_treningovBindingNavigatorSaveItem
            // 
            this.plan_treningovBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plan_treningovBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("plan_treningovBindingNavigatorSaveItem.Image")));
            this.plan_treningovBindingNavigatorSaveItem.Name = "plan_treningovBindingNavigatorSaveItem";
            this.plan_treningovBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.plan_treningovBindingNavigatorSaveItem.Text = "Save Data";
            this.plan_treningovBindingNavigatorSaveItem.Click += new System.EventHandler(this.plan_treningovBindingNavigatorSaveItem_Click);
            // 
            // clan_idNumericUpDown
            // 
            this.clan_idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.plan_treningovBindingSource, "clan_id", true));
            this.clan_idNumericUpDown.Location = new System.Drawing.Point(707, 110);
            this.clan_idNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clan_idNumericUpDown.Name = "clan_idNumericUpDown";
            this.clan_idNumericUpDown.Size = new System.Drawing.Size(140, 20);
            this.clan_idNumericUpDown.TabIndex = 2;
            // 
            // trener_idNumericUpDown
            // 
            this.trener_idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.plan_treningovBindingSource, "trener_id", true));
            this.trener_idNumericUpDown.Location = new System.Drawing.Point(707, 136);
            this.trener_idNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trener_idNumericUpDown.Name = "trener_idNumericUpDown";
            this.trener_idNumericUpDown.Size = new System.Drawing.Size(140, 20);
            this.trener_idNumericUpDown.TabIndex = 4;
            // 
            // trening_idNumericUpDown
            // 
            this.trening_idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.plan_treningovBindingSource, "trening_id", true));
            this.trening_idNumericUpDown.Location = new System.Drawing.Point(707, 162);
            this.trening_idNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trening_idNumericUpDown.Name = "trening_idNumericUpDown";
            this.trening_idNumericUpDown.Size = new System.Drawing.Size(140, 20);
            this.trening_idNumericUpDown.TabIndex = 6;
            // 
            // dnevi_treningovTextBox
            // 
            this.dnevi_treningovTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plan_treningovBindingSource, "dnevi_treningov", true));
            this.dnevi_treningovTextBox.Location = new System.Drawing.Point(707, 188);
            this.dnevi_treningovTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dnevi_treningovTextBox.Name = "dnevi_treningovTextBox";
            this.dnevi_treningovTextBox.Size = new System.Drawing.Size(139, 20);
            this.dnevi_treningovTextBox.TabIndex = 8;
            // 
            // plan_treningovDataGridView
            // 
            this.plan_treningovDataGridView.AutoGenerateColumns = false;
            this.plan_treningovDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plan_treningovDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.plan_treningovDataGridView.DataSource = this.plan_treningovBindingSource;
            this.plan_treningovDataGridView.Location = new System.Drawing.Point(28, 110);
            this.plan_treningovDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plan_treningovDataGridView.Name = "plan_treningovDataGridView";
            this.plan_treningovDataGridView.Size = new System.Drawing.Size(543, 220);
            this.plan_treningovDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "plan_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "plan_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "clan_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "clan_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "trener_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "trener_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "trening_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "trening_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dnevi_treningov";
            this.dataGridViewTextBoxColumn5.HeaderText = "dnevi_treningov";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // plan_treningovTableAdapter
            // 
            this.plan_treningovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClanTableAdapter = null;
            this.tableAdapterManager.Plan_treningovTableAdapter = this.plan_treningovTableAdapter;
            this.tableAdapterManager.Tip_clanstvaTableAdapter = null;
            this.tableAdapterManager.TreningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projket.FitnesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UporabnikTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(289, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Urejanje planov treningov";
            // 
            // Plani_treningov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plan_treningovDataGridView);
            this.Controls.Add(clan_idLabel);
            this.Controls.Add(this.clan_idNumericUpDown);
            this.Controls.Add(trener_idLabel);
            this.Controls.Add(this.trener_idNumericUpDown);
            this.Controls.Add(trening_idLabel);
            this.Controls.Add(this.trening_idNumericUpDown);
            this.Controls.Add(dnevi_treningovLabel);
            this.Controls.Add(this.dnevi_treningovTextBox);
            this.Controls.Add(this.plan_treningovBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Plani_treningov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urejanje planov treningov";
            this.Load += new System.EventHandler(this.Plani_treningov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plan_treningovBindingNavigator)).EndInit();
            this.plan_treningovBindingNavigator.ResumeLayout(false);
            this.plan_treningovBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plan_treningovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clan_idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trener_idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trening_idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_treningovDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FitnesDataSet fitnesDataSet;
        private System.Windows.Forms.BindingSource plan_treningovBindingSource;
        private FitnesDataSetTableAdapters.Plan_treningovTableAdapter plan_treningovTableAdapter;
        private FitnesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator plan_treningovBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton plan_treningovBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown clan_idNumericUpDown;
        private System.Windows.Forms.NumericUpDown trener_idNumericUpDown;
        private System.Windows.Forms.NumericUpDown trening_idNumericUpDown;
        private System.Windows.Forms.TextBox dnevi_treningovTextBox;
        private System.Windows.Forms.DataGridView plan_treningovDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
    }
}