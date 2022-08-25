namespace Projket
{
    partial class Člani
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
            System.Windows.Forms.Label pridruzitevLabel;
            System.Windows.Forms.Label potek_clanstvaLabel;
            System.Windows.Forms.Label uporabnik_idLabel;
            System.Windows.Forms.Label tip_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Člani));
            this.fitnesDataSet = new Projket.FitnesDataSet();
            this.clanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clanTableAdapter = new Projket.FitnesDataSetTableAdapters.ClanTableAdapter();
            this.tableAdapterManager = new Projket.FitnesDataSetTableAdapters.TableAdapterManager();
            this.tip_clanstvaTableAdapter = new Projket.FitnesDataSetTableAdapters.Tip_clanstvaTableAdapter();
            this.uporabnikTableAdapter = new Projket.FitnesDataSetTableAdapters.UporabnikTableAdapter();
            this.clanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pridruzitevDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.potek_clanstvaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uporabnik_idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tip_idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip_clanstvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_clanstvaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uporabnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uporabnikDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            pridruzitevLabel = new System.Windows.Forms.Label();
            potek_clanstvaLabel = new System.Windows.Forms.Label();
            uporabnik_idLabel = new System.Windows.Forms.Label();
            tip_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingNavigator)).BeginInit();
            this.clanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnik_idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pridruzitevLabel
            // 
            pridruzitevLabel.AutoSize = true;
            pridruzitevLabel.Location = new System.Drawing.Point(26, 87);
            pridruzitevLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pridruzitevLabel.Name = "pridruzitevLabel";
            pridruzitevLabel.Size = new System.Drawing.Size(70, 13);
            pridruzitevLabel.TabIndex = 1;
            pridruzitevLabel.Text = "pridruzitev:";
            // 
            // potek_clanstvaLabel
            // 
            potek_clanstvaLabel.AutoSize = true;
            potek_clanstvaLabel.Location = new System.Drawing.Point(26, 113);
            potek_clanstvaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            potek_clanstvaLabel.Name = "potek_clanstvaLabel";
            potek_clanstvaLabel.Size = new System.Drawing.Size(95, 13);
            potek_clanstvaLabel.TabIndex = 3;
            potek_clanstvaLabel.Text = "potek clanstva:";
            // 
            // uporabnik_idLabel
            // 
            uporabnik_idLabel.AutoSize = true;
            uporabnik_idLabel.Location = new System.Drawing.Point(26, 135);
            uporabnik_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uporabnik_idLabel.Name = "uporabnik_idLabel";
            uporabnik_idLabel.Size = new System.Drawing.Size(86, 13);
            uporabnik_idLabel.TabIndex = 5;
            uporabnik_idLabel.Text = "Uporabnik ID:";
            // 
            // tip_idLabel
            // 
            tip_idLabel.AutoSize = true;
            tip_idLabel.Location = new System.Drawing.Point(26, 161);
            tip_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tip_idLabel.Name = "tip_idLabel";
            tip_idLabel.Size = new System.Drawing.Size(39, 13);
            tip_idLabel.TabIndex = 7;
            tip_idLabel.Text = "tip id:";
            // 
            // fitnesDataSet
            // 
            this.fitnesDataSet.DataSetName = "FitnesDataSet";
            this.fitnesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clanBindingSource
            // 
            this.clanBindingSource.DataMember = "Clan";
            this.clanBindingSource.DataSource = this.fitnesDataSet;
            // 
            // clanTableAdapter
            // 
            this.clanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClanTableAdapter = this.clanTableAdapter;
            this.tableAdapterManager.Plan_treningovTableAdapter = null;
            this.tableAdapterManager.Tip_clanstvaTableAdapter = this.tip_clanstvaTableAdapter;
            this.tableAdapterManager.TreningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projket.FitnesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UporabnikTableAdapter = this.uporabnikTableAdapter;
            // 
            // tip_clanstvaTableAdapter
            // 
            this.tip_clanstvaTableAdapter.ClearBeforeFill = true;
            // 
            // uporabnikTableAdapter
            // 
            this.uporabnikTableAdapter.ClearBeforeFill = true;
            // 
            // clanBindingNavigator
            // 
            this.clanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clanBindingNavigator.BindingSource = this.clanBindingSource;
            this.clanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clanBindingNavigatorSaveItem});
            this.clanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clanBindingNavigator.Name = "clanBindingNavigator";
            this.clanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clanBindingNavigator.Size = new System.Drawing.Size(967, 25);
            this.clanBindingNavigator.TabIndex = 0;
            this.clanBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // clanBindingNavigatorSaveItem
            // 
            this.clanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clanBindingNavigatorSaveItem.Image")));
            this.clanBindingNavigatorSaveItem.Name = "clanBindingNavigatorSaveItem";
            this.clanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clanBindingNavigatorSaveItem.Text = "Save Data";
            this.clanBindingNavigatorSaveItem.Click += new System.EventHandler(this.clanBindingNavigatorSaveItem_Click_1);
            // 
            // pridruzitevDateTimePicker
            // 
            this.pridruzitevDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clanBindingSource, "pridruzitev", true));
            this.pridruzitevDateTimePicker.Location = new System.Drawing.Point(126, 83);
            this.pridruzitevDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pridruzitevDateTimePicker.Name = "pridruzitevDateTimePicker";
            this.pridruzitevDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.pridruzitevDateTimePicker.TabIndex = 2;
            // 
            // potek_clanstvaDateTimePicker
            // 
            this.potek_clanstvaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clanBindingSource, "potek_clanstva", true));
            this.potek_clanstvaDateTimePicker.Location = new System.Drawing.Point(126, 109);
            this.potek_clanstvaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.potek_clanstvaDateTimePicker.Name = "potek_clanstvaDateTimePicker";
            this.potek_clanstvaDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.potek_clanstvaDateTimePicker.TabIndex = 4;
            // 
            // uporabnik_idNumericUpDown
            // 
            this.uporabnik_idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clanBindingSource, "uporabnik_id", true));
            this.uporabnik_idNumericUpDown.Location = new System.Drawing.Point(126, 135);
            this.uporabnik_idNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uporabnik_idNumericUpDown.Name = "uporabnik_idNumericUpDown";
            this.uporabnik_idNumericUpDown.Size = new System.Drawing.Size(233, 20);
            this.uporabnik_idNumericUpDown.TabIndex = 6;
            // 
            // tip_idNumericUpDown
            // 
            this.tip_idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clanBindingSource, "tip_id", true));
            this.tip_idNumericUpDown.Location = new System.Drawing.Point(126, 161);
            this.tip_idNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tip_idNumericUpDown.Name = "tip_idNumericUpDown";
            this.tip_idNumericUpDown.Size = new System.Drawing.Size(233, 20);
            this.tip_idNumericUpDown.TabIndex = 8;
            // 
            // clanDataGridView
            // 
            this.clanDataGridView.AutoGenerateColumns = false;
            this.clanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clanDataGridView.DataSource = this.clanBindingSource;
            this.clanDataGridView.Location = new System.Drawing.Point(13, 203);
            this.clanDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clanDataGridView.Name = "clanDataGridView";
            this.clanDataGridView.Size = new System.Drawing.Size(543, 220);
            this.clanDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "clan_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "clan_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pridruzitev";
            this.dataGridViewTextBoxColumn2.HeaderText = "pridruzitev";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "potek_clanstva";
            this.dataGridViewTextBoxColumn3.HeaderText = "potek_clanstva";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "uporabnik_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "uporabnik_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tip_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "tip_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tip_clanstvaBindingSource
            // 
            this.tip_clanstvaBindingSource.DataMember = "Tip_clanstva";
            this.tip_clanstvaBindingSource.DataSource = this.fitnesDataSet;
            // 
            // tip_clanstvaDataGridView
            // 
            this.tip_clanstvaDataGridView.AllowUserToAddRows = false;
            this.tip_clanstvaDataGridView.AllowUserToDeleteRows = false;
            this.tip_clanstvaDataGridView.AutoGenerateColumns = false;
            this.tip_clanstvaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tip_clanstvaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tip_clanstvaDataGridView.DataSource = this.tip_clanstvaBindingSource;
            this.tip_clanstvaDataGridView.Location = new System.Drawing.Point(705, 274);
            this.tip_clanstvaDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tip_clanstvaDataGridView.Name = "tip_clanstvaDataGridView";
            this.tip_clanstvaDataGridView.ReadOnly = true;
            this.tip_clanstvaDataGridView.Size = new System.Drawing.Size(244, 126);
            this.tip_clanstvaDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tip_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "tip_id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tip članstva gleda na ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // uporabnikBindingSource
            // 
            this.uporabnikBindingSource.DataMember = "Uporabnik";
            this.uporabnikBindingSource.DataSource = this.fitnesDataSet;
            // 
            // uporabnikDataGridView
            // 
            this.uporabnikDataGridView.AllowUserToAddRows = false;
            this.uporabnikDataGridView.AllowUserToDeleteRows = false;
            this.uporabnikDataGridView.AutoGenerateColumns = false;
            this.uporabnikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uporabnikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.uporabnikDataGridView.DataSource = this.uporabnikBindingSource;
            this.uporabnikDataGridView.Location = new System.Drawing.Point(605, 124);
            this.uporabnikDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uporabnikDataGridView.Name = "uporabnikDataGridView";
            this.uporabnikDataGridView.ReadOnly = true;
            this.uporabnikDataGridView.Size = new System.Drawing.Size(344, 126);
            this.uporabnikDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "uporabnik_id";
            this.dataGridViewTextBoxColumn11.HeaderText = "uporabnik_id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn12.HeaderText = "ime";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "priimek";
            this.dataGridViewTextBoxColumn13.HeaderText = "priimek";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(380, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Urejanje članov";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(600, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Za pomoč: ";
            // 
            // Člani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 435);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uporabnikDataGridView);
            this.Controls.Add(this.tip_clanstvaDataGridView);
            this.Controls.Add(this.clanDataGridView);
            this.Controls.Add(pridruzitevLabel);
            this.Controls.Add(this.pridruzitevDateTimePicker);
            this.Controls.Add(potek_clanstvaLabel);
            this.Controls.Add(this.potek_clanstvaDateTimePicker);
            this.Controls.Add(uporabnik_idLabel);
            this.Controls.Add(this.uporabnik_idNumericUpDown);
            this.Controls.Add(tip_idLabel);
            this.Controls.Add(this.tip_idNumericUpDown);
            this.Controls.Add(this.clanBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Člani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urejanje članov ";
            this.Load += new System.EventHandler(this.Člani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingNavigator)).EndInit();
            this.clanBindingNavigator.ResumeLayout(false);
            this.clanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnik_idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_clanstvaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FitnesDataSet fitnesDataSet;
        private System.Windows.Forms.BindingSource clanBindingSource;
        private FitnesDataSetTableAdapters.ClanTableAdapter clanTableAdapter;
        private FitnesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clanBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clanBindingNavigatorSaveItem;
        private FitnesDataSetTableAdapters.Tip_clanstvaTableAdapter tip_clanstvaTableAdapter;
        private System.Windows.Forms.DateTimePicker pridruzitevDateTimePicker;
        private System.Windows.Forms.DateTimePicker potek_clanstvaDateTimePicker;
        private System.Windows.Forms.NumericUpDown uporabnik_idNumericUpDown;
        private System.Windows.Forms.NumericUpDown tip_idNumericUpDown;
        private System.Windows.Forms.DataGridView clanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource tip_clanstvaBindingSource;
        private FitnesDataSetTableAdapters.UporabnikTableAdapter uporabnikTableAdapter;
        private System.Windows.Forms.DataGridView tip_clanstvaDataGridView;
        private System.Windows.Forms.BindingSource uporabnikBindingSource;
        private System.Windows.Forms.DataGridView uporabnikDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}