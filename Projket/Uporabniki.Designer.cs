namespace Projket
{
    partial class Uporabniki
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
            System.Windows.Forms.Label priimekLabel;
            System.Windows.Forms.Label telefeonLabel;
            System.Windows.Forms.Label naslovLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label spolLabel;
            System.Windows.Forms.Label starostLabel;
            System.Windows.Forms.Label je_trenerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uporabniki));
            this.uporabnikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.uporabnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.uporabnikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.priimekTextBox = new System.Windows.Forms.TextBox();
            this.telefeonTextBox = new System.Windows.Forms.TextBox();
            this.naslovTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.spolComboBox = new System.Windows.Forms.ComboBox();
            this.starostTextBox = new System.Windows.Forms.TextBox();
            this.je_trenerCheckBox = new System.Windows.Forms.CheckBox();
            this.uporabnikTableAdapter = new Projket.FitnesDataSetTableAdapters.UporabnikTableAdapter();
            this.tableAdapterManager = new Projket.FitnesDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uporabnikDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            priimekLabel = new System.Windows.Forms.Label();
            telefeonLabel = new System.Windows.Forms.Label();
            naslovLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            spolLabel = new System.Windows.Forms.Label();
            starostLabel = new System.Windows.Forms.Label();
            je_trenerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikBindingNavigator)).BeginInit();
            this.uporabnikBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            imeLabel.Location = new System.Drawing.Point(42, 98);
            imeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(31, 13);
            imeLabel.TabIndex = 1;
            imeLabel.Text = "Ime:";
            // 
            // priimekLabel
            // 
            priimekLabel.AutoSize = true;
            priimekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            priimekLabel.Location = new System.Drawing.Point(42, 124);
            priimekLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            priimekLabel.Name = "priimekLabel";
            priimekLabel.Size = new System.Drawing.Size(52, 13);
            priimekLabel.TabIndex = 3;
            priimekLabel.Text = "Priimek:";
            // 
            // telefeonLabel
            // 
            telefeonLabel.AutoSize = true;
            telefeonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            telefeonLabel.Location = new System.Drawing.Point(275, 98);
            telefeonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefeonLabel.Name = "telefeonLabel";
            telefeonLabel.Size = new System.Drawing.Size(61, 13);
            telefeonLabel.TabIndex = 5;
            telefeonLabel.Text = "Telefeon:";
            // 
            // naslovLabel
            // 
            naslovLabel.AutoSize = true;
            naslovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            naslovLabel.Location = new System.Drawing.Point(275, 124);
            naslovLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new System.Drawing.Size(50, 13);
            naslovLabel.TabIndex = 7;
            naslovLabel.Text = "Naslov:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            emailLabel.Location = new System.Drawing.Point(532, 122);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(41, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // spolLabel
            // 
            spolLabel.AutoSize = true;
            spolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            spolLabel.Location = new System.Drawing.Point(532, 99);
            spolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            spolLabel.Name = "spolLabel";
            spolLabel.Size = new System.Drawing.Size(36, 13);
            spolLabel.TabIndex = 11;
            spolLabel.Text = "Spol:";
            // 
            // starostLabel
            // 
            starostLabel.AutoSize = true;
            starostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            starostLabel.Location = new System.Drawing.Point(758, 98);
            starostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            starostLabel.Name = "starostLabel";
            starostLabel.Size = new System.Drawing.Size(51, 13);
            starostLabel.TabIndex = 13;
            starostLabel.Text = "Starost:";
            // 
            // je_trenerLabel
            // 
            je_trenerLabel.AutoSize = true;
            je_trenerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            je_trenerLabel.Location = new System.Drawing.Point(758, 124);
            je_trenerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            je_trenerLabel.Name = "je_trenerLabel";
            je_trenerLabel.Size = new System.Drawing.Size(44, 13);
            je_trenerLabel.TabIndex = 15;
            je_trenerLabel.Text = "Trener";
            // 
            // uporabnikBindingNavigator
            // 
            this.uporabnikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uporabnikBindingNavigator.BindingSource = this.uporabnikBindingSource;
            this.uporabnikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uporabnikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uporabnikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uporabnikBindingNavigatorSaveItem});
            this.uporabnikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uporabnikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uporabnikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uporabnikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uporabnikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uporabnikBindingNavigator.Name = "uporabnikBindingNavigator";
            this.uporabnikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uporabnikBindingNavigator.Size = new System.Drawing.Size(1039, 25);
            this.uporabnikBindingNavigator.TabIndex = 0;
            this.uporabnikBindingNavigator.Text = "bindingNavigator1";
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
            // uporabnikBindingSource
            // 
            this.uporabnikBindingSource.DataMember = "Uporabnik";
            this.uporabnikBindingSource.DataSource = this.fitnesDataSet;
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
            // uporabnikBindingNavigatorSaveItem
            // 
            this.uporabnikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uporabnikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uporabnikBindingNavigatorSaveItem.Image")));
            this.uporabnikBindingNavigatorSaveItem.Name = "uporabnikBindingNavigatorSaveItem";
            this.uporabnikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uporabnikBindingNavigatorSaveItem.Text = "Save Data";
            this.uporabnikBindingNavigatorSaveItem.Click += new System.EventHandler(this.uporabnikBindingNavigatorSaveItem_Click_1);
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikBindingSource, "ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(105, 95);
            this.imeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(140, 20);
            this.imeTextBox.TabIndex = 2;
            // 
            // priimekTextBox
            // 
            this.priimekTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikBindingSource, "priimek", true));
            this.priimekTextBox.Location = new System.Drawing.Point(105, 121);
            this.priimekTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.priimekTextBox.Name = "priimekTextBox";
            this.priimekTextBox.Size = new System.Drawing.Size(140, 20);
            this.priimekTextBox.TabIndex = 4;
            // 
            // telefeonTextBox
            // 
            this.telefeonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikBindingSource, "telefeon", true));
            this.telefeonTextBox.Location = new System.Drawing.Point(348, 95);
            this.telefeonTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.telefeonTextBox.Name = "telefeonTextBox";
            this.telefeonTextBox.Size = new System.Drawing.Size(140, 20);
            this.telefeonTextBox.TabIndex = 6;
            // 
            // naslovTextBox
            // 
            this.naslovTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikBindingSource, "naslov", true));
            this.naslovTextBox.Location = new System.Drawing.Point(348, 121);
            this.naslovTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.naslovTextBox.Name = "naslovTextBox";
            this.naslovTextBox.Size = new System.Drawing.Size(140, 20);
            this.naslovTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(581, 122);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(140, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // spolComboBox
            // 
            this.spolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikBindingSource, "spol", true));
            this.spolComboBox.FormattingEnabled = true;
            this.spolComboBox.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.spolComboBox.Location = new System.Drawing.Point(581, 94);
            this.spolComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.spolComboBox.Name = "spolComboBox";
            this.spolComboBox.Size = new System.Drawing.Size(140, 21);
            this.spolComboBox.TabIndex = 12;
            // 
            // starostTextBox
            // 
            this.starostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikBindingSource, "starost", true));
            this.starostTextBox.Location = new System.Drawing.Point(821, 96);
            this.starostTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.starostTextBox.Name = "starostTextBox";
            this.starostTextBox.Size = new System.Drawing.Size(140, 20);
            this.starostTextBox.TabIndex = 14;
            // 
            // je_trenerCheckBox
            // 
            this.je_trenerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.uporabnikBindingSource, "je_trener", true));
            this.je_trenerCheckBox.Location = new System.Drawing.Point(821, 119);
            this.je_trenerCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.je_trenerCheckBox.Name = "je_trenerCheckBox";
            this.je_trenerCheckBox.Size = new System.Drawing.Size(141, 24);
            this.je_trenerCheckBox.TabIndex = 16;
            this.je_trenerCheckBox.Text = "(če je obklukaj)";
            this.je_trenerCheckBox.UseVisualStyleBackColor = true;
            // 
            // uporabnikTableAdapter
            // 
            this.uporabnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClanTableAdapter = null;
            this.tableAdapterManager.Plan_treningovTableAdapter = null;
            this.tableAdapterManager.Tip_clanstvaTableAdapter = null;
            this.tableAdapterManager.TreningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projket.FitnesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UporabnikTableAdapter = this.uporabnikTableAdapter;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "je_trener";
            this.dataGridViewCheckBoxColumn1.HeaderText = "je_trener";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "starost";
            this.dataGridViewTextBoxColumn8.HeaderText = "starost";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "spol";
            this.dataGridViewTextBoxColumn7.HeaderText = "spol";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "naslov";
            this.dataGridViewTextBoxColumn5.HeaderText = "naslov";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefeon";
            this.dataGridViewTextBoxColumn4.HeaderText = "telefeon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "priimek";
            this.dataGridViewTextBoxColumn3.HeaderText = "priimek";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "uporabnik_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "uporabnik_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // uporabnikDataGridView
            // 
            this.uporabnikDataGridView.AllowUserToOrderColumns = true;
            this.uporabnikDataGridView.AutoGenerateColumns = false;
            this.uporabnikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uporabnikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.uporabnikDataGridView.DataSource = this.uporabnikBindingSource;
            this.uporabnikDataGridView.Location = new System.Drawing.Point(45, 163);
            this.uporabnikDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uporabnikDataGridView.Name = "uporabnikDataGridView";
            this.uporabnikDataGridView.Size = new System.Drawing.Size(948, 220);
            this.uporabnikDataGridView.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(388, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Urejanje uporabnikov";
            // 
            // Uporabniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uporabnikDataGridView);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(priimekLabel);
            this.Controls.Add(this.priimekTextBox);
            this.Controls.Add(telefeonLabel);
            this.Controls.Add(this.telefeonTextBox);
            this.Controls.Add(naslovLabel);
            this.Controls.Add(this.naslovTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(spolLabel);
            this.Controls.Add(this.spolComboBox);
            this.Controls.Add(starostLabel);
            this.Controls.Add(this.starostTextBox);
            this.Controls.Add(je_trenerLabel);
            this.Controls.Add(this.je_trenerCheckBox);
            this.Controls.Add(this.uporabnikBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Uporabniki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urejanje uporabnikov";
            this.Load += new System.EventHandler(this.Uporabniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikBindingNavigator)).EndInit();
            this.uporabnikBindingNavigator.ResumeLayout(false);
            this.uporabnikBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FitnesDataSet fitnesDataSet;
        private System.Windows.Forms.BindingSource uporabnikBindingSource;
        private FitnesDataSetTableAdapters.UporabnikTableAdapter uporabnikTableAdapter;
        private FitnesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uporabnikBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uporabnikBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox priimekTextBox;
        private System.Windows.Forms.TextBox telefeonTextBox;
        private System.Windows.Forms.TextBox naslovTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox spolComboBox;
        private System.Windows.Forms.TextBox starostTextBox;
        private System.Windows.Forms.CheckBox je_trenerCheckBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView uporabnikDataGridView;
        private System.Windows.Forms.Label label1;
    }
}