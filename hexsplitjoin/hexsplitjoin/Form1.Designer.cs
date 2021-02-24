namespace hexsplitjoin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigurationbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.ConfigurationbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configurationDataSet1 = new hexsplitjoin.ConfigurationDataSet();
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.defaultSourcetoolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.defaultSourcePath = new System.Windows.Forms.ToolStripTextBox();
            this.defaultDestinationtoolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.defaultDestinationPath = new System.Windows.Forms.ToolStripTextBox();
            this.ConfigurationdataGridView = new System.Windows.Forms.DataGridView();
            this.SectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceFilePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceStartAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceEndAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceLenghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationFilePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationStartAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigurationbindingNavigator)).BeginInit();
            this.ConfigurationbindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigurationbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigurationdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.executeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator3,
            this.openConfigurationToolStripMenuItem,
            this.saveConfigurationToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // openConfigurationToolStripMenuItem
            // 
            this.openConfigurationToolStripMenuItem.Name = "openConfigurationToolStripMenuItem";
            this.openConfigurationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openConfigurationToolStripMenuItem.Text = "Open Configuration";
            this.openConfigurationToolStripMenuItem.Click += new System.EventHandler(this.openConfigurationToolStripMenuItem_Click);
            // 
            // saveConfigurationToolStripMenuItem
            // 
            this.saveConfigurationToolStripMenuItem.Name = "saveConfigurationToolStripMenuItem";
            this.saveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveConfigurationToolStripMenuItem.Text = "Save Configuration";
            this.saveConfigurationToolStripMenuItem.Click += new System.EventHandler(this.saveConfigurationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // ConfigurationbindingNavigator
            // 
            this.ConfigurationbindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ConfigurationbindingNavigator.BindingSource = this.ConfigurationbindingSource;
            this.ConfigurationbindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ConfigurationbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ConfigurationbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripSeparator2,
            this.defaultSourcetoolStripLabel1,
            this.defaultSourcePath,
            this.defaultDestinationtoolStripLabel2,
            this.defaultDestinationPath});
            this.ConfigurationbindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.ConfigurationbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ConfigurationbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ConfigurationbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ConfigurationbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ConfigurationbindingNavigator.Name = "ConfigurationbindingNavigator";
            this.ConfigurationbindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ConfigurationbindingNavigator.Size = new System.Drawing.Size(971, 25);
            this.ConfigurationbindingNavigator.TabIndex = 1;
            this.ConfigurationbindingNavigator.Text = "bindingNavigator1";
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
            // ConfigurationbindingSource
            // 
            this.ConfigurationbindingSource.DataMember = "Configuration";
            this.ConfigurationbindingSource.DataSource = this.configurationDataSet1;
            // 
            // configurationDataSet1
            // 
            this.configurationDataSet1.DataSetName = "ConfigurationDataSet";
            this.configurationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // defaultSourcetoolStripLabel1
            // 
            this.defaultSourcetoolStripLabel1.Name = "defaultSourcetoolStripLabel1";
            this.defaultSourcetoolStripLabel1.Size = new System.Drawing.Size(128, 22);
            this.defaultSourcetoolStripLabel1.Text = "Default sourse file path";
            this.defaultSourcetoolStripLabel1.Click += new System.EventHandler(this.defaultSourcetoolStripLabel1_Click);
            // 
            // defaultSourcePath
            // 
            this.defaultSourcePath.Name = "defaultSourcePath";
            this.defaultSourcePath.Size = new System.Drawing.Size(200, 25);
            this.defaultSourcePath.Text = global::hexsplitjoin.Properties.Settings.Default.defaultSource;
            // 
            // defaultDestinationtoolStripLabel2
            // 
            this.defaultDestinationtoolStripLabel2.Name = "defaultDestinationtoolStripLabel2";
            this.defaultDestinationtoolStripLabel2.Size = new System.Drawing.Size(153, 22);
            this.defaultDestinationtoolStripLabel2.Text = "Default destination file path";
            this.defaultDestinationtoolStripLabel2.Click += new System.EventHandler(this.defaultDestinationtoolStripLabel2_Click);
            // 
            // defaultDestinationPath
            // 
            this.defaultDestinationPath.Name = "defaultDestinationPath";
            this.defaultDestinationPath.Size = new System.Drawing.Size(200, 25);
            this.defaultDestinationPath.Text = global::hexsplitjoin.Properties.Settings.Default.defaultDestionation;
            // 
            // ConfigurationdataGridView
            // 
            this.ConfigurationdataGridView.AutoGenerateColumns = false;
            this.ConfigurationdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConfigurationdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SectionName,
            this.sourceFilePathDataGridViewTextBoxColumn,
            this.sourceStartAddressDataGridViewTextBoxColumn,
            this.sourceEndAddressDataGridViewTextBoxColumn,
            this.sourceLenghtDataGridViewTextBoxColumn,
            this.destinationFilePathDataGridViewTextBoxColumn,
            this.destinationStartAddressDataGridViewTextBoxColumn});
            this.ConfigurationdataGridView.DataSource = this.ConfigurationbindingSource;
            this.ConfigurationdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigurationdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ConfigurationdataGridView.Location = new System.Drawing.Point(0, 49);
            this.ConfigurationdataGridView.Name = "ConfigurationdataGridView";
            this.ConfigurationdataGridView.Size = new System.Drawing.Size(971, 428);
            this.ConfigurationdataGridView.TabIndex = 2;
            // 
            // SectionName
            // 
            this.SectionName.DataPropertyName = "SectionName";
            this.SectionName.HeaderText = "SectionName";
            this.SectionName.Name = "SectionName";
            // 
            // sourceFilePathDataGridViewTextBoxColumn
            // 
            this.sourceFilePathDataGridViewTextBoxColumn.DataPropertyName = "SourceFilePath";
            this.sourceFilePathDataGridViewTextBoxColumn.HeaderText = "SourceFilePath";
            this.sourceFilePathDataGridViewTextBoxColumn.Name = "sourceFilePathDataGridViewTextBoxColumn";
            // 
            // sourceStartAddressDataGridViewTextBoxColumn
            // 
            this.sourceStartAddressDataGridViewTextBoxColumn.DataPropertyName = "SourceStartAddress";
            this.sourceStartAddressDataGridViewTextBoxColumn.HeaderText = "SourceStartAddress";
            this.sourceStartAddressDataGridViewTextBoxColumn.Name = "sourceStartAddressDataGridViewTextBoxColumn";
            // 
            // sourceEndAddressDataGridViewTextBoxColumn
            // 
            this.sourceEndAddressDataGridViewTextBoxColumn.DataPropertyName = "SourceEndAddress";
            this.sourceEndAddressDataGridViewTextBoxColumn.HeaderText = "SourceEndAddress";
            this.sourceEndAddressDataGridViewTextBoxColumn.Name = "sourceEndAddressDataGridViewTextBoxColumn";
            // 
            // sourceLenghtDataGridViewTextBoxColumn
            // 
            this.sourceLenghtDataGridViewTextBoxColumn.DataPropertyName = "SourceLenght";
            this.sourceLenghtDataGridViewTextBoxColumn.HeaderText = "SourceLenght";
            this.sourceLenghtDataGridViewTextBoxColumn.Name = "sourceLenghtDataGridViewTextBoxColumn";
            // 
            // destinationFilePathDataGridViewTextBoxColumn
            // 
            this.destinationFilePathDataGridViewTextBoxColumn.DataPropertyName = "DestinationFilePath";
            this.destinationFilePathDataGridViewTextBoxColumn.HeaderText = "DestinationFilePath";
            this.destinationFilePathDataGridViewTextBoxColumn.Name = "destinationFilePathDataGridViewTextBoxColumn";
            // 
            // destinationStartAddressDataGridViewTextBoxColumn
            // 
            this.destinationStartAddressDataGridViewTextBoxColumn.DataPropertyName = "DestinationStartAddress";
            this.destinationStartAddressDataGridViewTextBoxColumn.HeaderText = "DestinationStartAddress";
            this.destinationStartAddressDataGridViewTextBoxColumn.Name = "destinationStartAddressDataGridViewTextBoxColumn";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Configuration|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Configuration.xml";
            this.saveFileDialog1.Filter = "Configuration|*.xml";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Binary files|*.bin";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "Binary files|*.bin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 477);
            this.Controls.Add(this.ConfigurationdataGridView);
            this.Controls.Add(this.ConfigurationbindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Hex Split Join utility (powered by Sergey Azarenko)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigurationbindingNavigator)).EndInit();
            this.ConfigurationbindingNavigator.ResumeLayout(false);
            this.ConfigurationbindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigurationbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigurationdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.BindingNavigator ConfigurationbindingNavigator;
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
        private System.Windows.Forms.DataGridView ConfigurationdataGridView;
        private ConfigurationDataSet configurationDataSet1;
        private System.Windows.Forms.BindingSource ConfigurationbindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel defaultSourcetoolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox defaultSourcePath;
        private System.Windows.Forms.ToolStripLabel defaultDestinationtoolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox defaultDestinationPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceFilePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceStartAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceEndAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceLenghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationFilePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationStartAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

