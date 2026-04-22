namespace CityDB_Lab_2_Eric_Maslyanchuk
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
            System.Windows.Forms.Label cityIDLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label populationLabel;
            this.cityDBDataSet = new CityDB_Lab_2_Eric_Maslyanchuk.CityDBDataSet();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new CityDB_Lab_2_Eric_Maslyanchuk.CityDBDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new CityDB_Lab_2_Eric_Maslyanchuk.CityDBDataSetTableAdapters.TableAdapterManager();
            this.cityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIDTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.ascendingOrderBtn = new System.Windows.Forms.Button();
            this.descendingOrderBtn = new System.Windows.Forms.Button();
            this.sortCityNameBtn = new System.Windows.Forms.Button();
            this.averagePopulation = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.highestPopulationBtn = new System.Windows.Forms.Button();
            this.highestLabel = new System.Windows.Forms.Label();
            this.lowestPopulationBtn = new System.Windows.Forms.Button();
            this.lowestLabel = new System.Windows.Forms.Label();
            this.addCityBtn = new System.Windows.Forms.Button();
            this.deleteCityBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            cityIDLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).BeginInit();
            this.cityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cityDBDataSet
            // 
            this.cityDBDataSet.DataSetName = "CityDBDataSet";
            this.cityDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.cityDBDataSet;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.UpdateOrder = CityDB_Lab_2_Eric_Maslyanchuk.CityDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cityBindingNavigator
            // 
            this.cityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityBindingNavigator.BindingSource = this.cityBindingSource;
            this.cityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cityBindingNavigatorSaveItem});
            this.cityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityBindingNavigator.Name = "cityBindingNavigator";
            this.cityBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.cityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityBindingNavigator.Size = new System.Drawing.Size(1038, 25);
            this.cityBindingNavigator.TabIndex = 0;
            this.cityBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cityBindingNavigatorSaveItem
            // 
            this.cityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityBindingNavigatorSaveItem.Image")));
            this.cityBindingNavigatorSaveItem.Name = "cityBindingNavigatorSaveItem";
            this.cityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cityBindingNavigatorSaveItem.Text = "Save Data";
            this.cityBindingNavigatorSaveItem.Click += new System.EventHandler(this.cityBindingNavigatorSaveItem_Click);
            // 
            // cityDataGridView
            // 
            this.cityDataGridView.AutoGenerateColumns = false;
            this.cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cityDataGridView.DataSource = this.cityBindingSource;
            this.cityDataGridView.Location = new System.Drawing.Point(151, 124);
            this.cityDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cityDataGridView.Name = "cityDataGridView";
            this.cityDataGridView.Size = new System.Drawing.Size(446, 235);
            this.cityDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn2.HeaderText = "City";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn4.HeaderText = "Population";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // cityIDLabel
            // 
            cityIDLabel.AutoSize = true;
            cityIDLabel.Location = new System.Drawing.Point(640, 125);
            cityIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityIDLabel.Name = "cityIDLabel";
            cityIDLabel.Size = new System.Drawing.Size(57, 19);
            cityIDLabel.TabIndex = 2;
            cityIDLabel.Text = "City ID:";
            // 
            // cityIDTextBox
            // 
            this.cityIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityID", true));
            this.cityIDTextBox.Location = new System.Drawing.Point(740, 120);
            this.cityIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cityIDTextBox.Name = "cityIDTextBox";
            this.cityIDTextBox.Size = new System.Drawing.Size(148, 26);
            this.cityIDTextBox.TabIndex = 3;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(640, 163);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(37, 19);
            cityLabel.TabIndex = 4;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(740, 158);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(148, 26);
            this.cityTextBox.TabIndex = 5;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(640, 201);
            stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(43, 19);
            stateLabel.TabIndex = 6;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(740, 196);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(148, 26);
            this.stateTextBox.TabIndex = 7;
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(640, 239);
            populationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(76, 19);
            populationLabel.TabIndex = 8;
            populationLabel.Text = "Population:";
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(740, 234);
            this.populationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(148, 26);
            this.populationTextBox.TabIndex = 9;
            // 
            // ascendingOrderBtn
            // 
            this.ascendingOrderBtn.Location = new System.Drawing.Point(151, 390);
            this.ascendingOrderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ascendingOrderBtn.Name = "ascendingOrderBtn";
            this.ascendingOrderBtn.Size = new System.Drawing.Size(255, 34);
            this.ascendingOrderBtn.TabIndex = 10;
            this.ascendingOrderBtn.Text = "Population &Ascending Order";
            this.toolTip1.SetToolTip(this.ascendingOrderBtn, "Shows Citys in Acsending Order");
            this.ascendingOrderBtn.UseVisualStyleBackColor = true;
            this.ascendingOrderBtn.Click += new System.EventHandler(this.ascendingOrderBtn_Click);
            // 
            // descendingOrderBtn
            // 
            this.descendingOrderBtn.Location = new System.Drawing.Point(151, 433);
            this.descendingOrderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descendingOrderBtn.Name = "descendingOrderBtn";
            this.descendingOrderBtn.Size = new System.Drawing.Size(255, 34);
            this.descendingOrderBtn.TabIndex = 11;
            this.descendingOrderBtn.Text = "Population &Descending Order";
            this.toolTip1.SetToolTip(this.descendingOrderBtn, "Shows City in Descending Order");
            this.descendingOrderBtn.UseVisualStyleBackColor = true;
            this.descendingOrderBtn.Click += new System.EventHandler(this.descendingOrderBtn_Click);
            // 
            // sortCityNameBtn
            // 
            this.sortCityNameBtn.Location = new System.Drawing.Point(151, 475);
            this.sortCityNameBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortCityNameBtn.Name = "sortCityNameBtn";
            this.sortCityNameBtn.Size = new System.Drawing.Size(255, 34);
            this.sortCityNameBtn.TabIndex = 12;
            this.sortCityNameBtn.Text = "Sort &City Name";
            this.toolTip1.SetToolTip(this.sortCityNameBtn, "Sorts City from A-Z\\");
            this.sortCityNameBtn.UseVisualStyleBackColor = true;
            this.sortCityNameBtn.Click += new System.EventHandler(this.sortCityNameBtn_Click);
            // 
            // averagePopulation
            // 
            this.averagePopulation.Location = new System.Drawing.Point(151, 517);
            this.averagePopulation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.averagePopulation.Name = "averagePopulation";
            this.averagePopulation.Size = new System.Drawing.Size(255, 34);
            this.averagePopulation.TabIndex = 13;
            this.averagePopulation.Text = "Get Popluation &Average";
            this.toolTip1.SetToolTip(this.averagePopulation, "Gets Average Pop");
            this.averagePopulation.UseVisualStyleBackColor = true;
            this.averagePopulation.Click += new System.EventHandler(this.averagePopulation_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(415, 517);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(299, 33);
            this.averageLabel.TabIndex = 14;
            this.averageLabel.Text = "label1";
            this.toolTip1.SetToolTip(this.averageLabel, " results for the average pop");
            // 
            // highestPopulationBtn
            // 
            this.highestPopulationBtn.Location = new System.Drawing.Point(151, 560);
            this.highestPopulationBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.highestPopulationBtn.Name = "highestPopulationBtn";
            this.highestPopulationBtn.Size = new System.Drawing.Size(255, 34);
            this.highestPopulationBtn.TabIndex = 15;
            this.highestPopulationBtn.Text = "&Highest Population";
            this.toolTip1.SetToolTip(this.highestPopulationBtn, "Get Highest Pop");
            this.highestPopulationBtn.UseVisualStyleBackColor = true;
            this.highestPopulationBtn.Click += new System.EventHandler(this.highestPopulationBtn_Click);
            // 
            // highestLabel
            // 
            this.highestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highestLabel.Location = new System.Drawing.Point(415, 560);
            this.highestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highestLabel.Name = "highestLabel";
            this.highestLabel.Size = new System.Drawing.Size(299, 33);
            this.highestLabel.TabIndex = 16;
            this.highestLabel.Text = "label1";
            this.toolTip1.SetToolTip(this.highestLabel, "results for highest Pop");
            // 
            // lowestPopulationBtn
            // 
            this.lowestPopulationBtn.Location = new System.Drawing.Point(151, 604);
            this.lowestPopulationBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lowestPopulationBtn.Name = "lowestPopulationBtn";
            this.lowestPopulationBtn.Size = new System.Drawing.Size(255, 34);
            this.lowestPopulationBtn.TabIndex = 17;
            this.lowestPopulationBtn.Text = "&Lowest Population";
            this.toolTip1.SetToolTip(this.lowestPopulationBtn, "Lowest Pop");
            this.lowestPopulationBtn.UseVisualStyleBackColor = true;
            this.lowestPopulationBtn.Click += new System.EventHandler(this.lowestPopulationBtn_Click);
            // 
            // lowestLabel
            // 
            this.lowestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestLabel.Location = new System.Drawing.Point(415, 604);
            this.lowestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowestLabel.Name = "lowestLabel";
            this.lowestLabel.Size = new System.Drawing.Size(304, 33);
            this.lowestLabel.TabIndex = 18;
            this.lowestLabel.Text = "label1";
            this.toolTip1.SetToolTip(this.lowestLabel, "results for lowest pop");
            // 
            // addCityBtn
            // 
            this.addCityBtn.Location = new System.Drawing.Point(526, 390);
            this.addCityBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCityBtn.Name = "addCityBtn";
            this.addCityBtn.Size = new System.Drawing.Size(112, 34);
            this.addCityBtn.TabIndex = 19;
            this.addCityBtn.Text = "&Add City";
            this.addCityBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.addCityBtn, "Addes a city ");
            this.addCityBtn.UseVisualStyleBackColor = true;
            this.addCityBtn.Click += new System.EventHandler(this.addCityBtn_Click);
            // 
            // deleteCityBtn
            // 
            this.deleteCityBtn.Location = new System.Drawing.Point(526, 431);
            this.deleteCityBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteCityBtn.Name = "deleteCityBtn";
            this.deleteCityBtn.Size = new System.Drawing.Size(112, 34);
            this.deleteCityBtn.TabIndex = 20;
            this.deleteCityBtn.Text = "&Delete City";
            this.toolTip1.SetToolTip(this.deleteCityBtn, "Deletes a city");
            this.deleteCityBtn.UseVisualStyleBackColor = true;
            this.deleteCityBtn.Click += new System.EventHandler(this.deleteCityBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(526, 475);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 34);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "&Save";
            this.toolTip1.SetToolTip(this.saveBtn, "Saves the database");
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Population DataBase ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1038, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteCityBtn);
            this.Controls.Add(this.addCityBtn);
            this.Controls.Add(this.lowestLabel);
            this.Controls.Add(this.lowestPopulationBtn);
            this.Controls.Add(this.highestLabel);
            this.Controls.Add(this.highestPopulationBtn);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.averagePopulation);
            this.Controls.Add(this.sortCityNameBtn);
            this.Controls.Add(this.descendingOrderBtn);
            this.Controls.Add(this.ascendingOrderBtn);
            this.Controls.Add(cityIDLabel);
            this.Controls.Add(this.cityIDTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.cityDataGridView);
            this.Controls.Add(this.cityBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).EndInit();
            this.cityBindingNavigator.ResumeLayout(false);
            this.cityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityDBDataSet cityDBDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private CityDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private CityDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cityBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox cityIDTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.Button ascendingOrderBtn;
        private System.Windows.Forms.Button descendingOrderBtn;
        private System.Windows.Forms.Button sortCityNameBtn;
        private System.Windows.Forms.Button averagePopulation;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Button highestPopulationBtn;
        private System.Windows.Forms.Label highestLabel;
        private System.Windows.Forms.Button lowestPopulationBtn;
        private System.Windows.Forms.Label lowestLabel;
        private System.Windows.Forms.Button addCityBtn;
        private System.Windows.Forms.Button deleteCityBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

