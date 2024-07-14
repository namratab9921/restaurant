namespace restaurant
{
    partial class item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(item));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.inoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ientrydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSet = new restaurant.restaurantDataSet();
            this.butclose1 = new System.Windows.Forms.Button();
            this.butview1 = new System.Windows.Forms.Button();
            this.butdel = new System.Windows.Forms.Button();
            this.butedit1 = new System.Windows.Forms.Button();
            this.butsave1 = new System.Windows.Forms.Button();
            this.butnew1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.combounit = new System.Windows.Forms.ComboBox();
            this.combocat = new System.Windows.Forms.ComboBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtiname = new System.Windows.Forms.TextBox();
            this.txtino = new System.Windows.Forms.TextBox();
            this.labunit = new System.Windows.Forms.Label();
            this.labentrydate = new System.Windows.Forms.Label();
            this.labrate = new System.Windows.Forms.Label();
            this.labicat = new System.Windows.Forms.Label();
            this.labiname = new System.Windows.Forms.Label();
            this.labino = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemTableAdapter = new restaurant.restaurantDataSetTableAdapters.ItemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 70);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOTEL SHIVNERI";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inoDataGridViewTextBoxColumn,
            this.inameDataGridViewTextBoxColumn,
            this.icategoryDataGridViewTextBoxColumn,
            this.irateDataGridViewTextBoxColumn,
            this.iunitDataGridViewTextBoxColumn,
            this.ientrydateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.itemBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(133, 287);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1065, 390);
            this.dataGridView2.TabIndex = 21;
            // 
            // inoDataGridViewTextBoxColumn
            // 
            this.inoDataGridViewTextBoxColumn.DataPropertyName = "I_no";
            this.inoDataGridViewTextBoxColumn.HeaderText = "I_no";
            this.inoDataGridViewTextBoxColumn.Name = "inoDataGridViewTextBoxColumn";
            // 
            // inameDataGridViewTextBoxColumn
            // 
            this.inameDataGridViewTextBoxColumn.DataPropertyName = "I_name";
            this.inameDataGridViewTextBoxColumn.HeaderText = "I_name";
            this.inameDataGridViewTextBoxColumn.Name = "inameDataGridViewTextBoxColumn";
            // 
            // icategoryDataGridViewTextBoxColumn
            // 
            this.icategoryDataGridViewTextBoxColumn.DataPropertyName = "I_category";
            this.icategoryDataGridViewTextBoxColumn.HeaderText = "I_category";
            this.icategoryDataGridViewTextBoxColumn.Name = "icategoryDataGridViewTextBoxColumn";
            // 
            // irateDataGridViewTextBoxColumn
            // 
            this.irateDataGridViewTextBoxColumn.DataPropertyName = "I_rate";
            this.irateDataGridViewTextBoxColumn.HeaderText = "I_rate";
            this.irateDataGridViewTextBoxColumn.Name = "irateDataGridViewTextBoxColumn";
            // 
            // iunitDataGridViewTextBoxColumn
            // 
            this.iunitDataGridViewTextBoxColumn.DataPropertyName = "I_unit";
            this.iunitDataGridViewTextBoxColumn.HeaderText = "I_unit";
            this.iunitDataGridViewTextBoxColumn.Name = "iunitDataGridViewTextBoxColumn";
            // 
            // ientrydateDataGridViewTextBoxColumn
            // 
            this.ientrydateDataGridViewTextBoxColumn.DataPropertyName = "I_entrydate";
            this.ientrydateDataGridViewTextBoxColumn.HeaderText = "I_entrydate";
            this.ientrydateDataGridViewTextBoxColumn.Name = "ientrydateDataGridViewTextBoxColumn";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.restaurantDataSet;
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "restaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // butclose1
            // 
            this.butclose1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butclose1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butclose1.Location = new System.Drawing.Point(1024, 234);
            this.butclose1.Name = "butclose1";
            this.butclose1.Size = new System.Drawing.Size(154, 47);
            this.butclose1.TabIndex = 20;
            this.butclose1.Text = "Close";
            this.butclose1.UseVisualStyleBackColor = false;
            this.butclose1.Click += new System.EventHandler(this.butclose1_Click);
            // 
            // butview1
            // 
            this.butview1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butview1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butview1.Location = new System.Drawing.Point(850, 234);
            this.butview1.Name = "butview1";
            this.butview1.Size = new System.Drawing.Size(154, 47);
            this.butview1.TabIndex = 19;
            this.butview1.Text = "View";
            this.butview1.UseVisualStyleBackColor = false;
            this.butview1.Click += new System.EventHandler(this.butview1_Click);
            // 
            // butdel
            // 
            this.butdel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butdel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdel.Location = new System.Drawing.Point(674, 234);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(154, 47);
            this.butdel.TabIndex = 18;
            this.butdel.Text = "Delete";
            this.butdel.UseVisualStyleBackColor = false;
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butedit1
            // 
            this.butedit1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butedit1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butedit1.Location = new System.Drawing.Point(499, 234);
            this.butedit1.Name = "butedit1";
            this.butedit1.Size = new System.Drawing.Size(154, 47);
            this.butedit1.TabIndex = 17;
            this.butedit1.Text = "Edit";
            this.butedit1.UseVisualStyleBackColor = false;
            this.butedit1.Click += new System.EventHandler(this.butedit1_Click);
            this.butedit1.Leave += new System.EventHandler(this.txtiname_leave);
            // 
            // butsave1
            // 
            this.butsave1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butsave1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave1.Location = new System.Drawing.Point(324, 234);
            this.butsave1.Name = "butsave1";
            this.butsave1.Size = new System.Drawing.Size(154, 47);
            this.butsave1.TabIndex = 16;
            this.butsave1.Text = "Save";
            this.butsave1.UseVisualStyleBackColor = false;
            this.butsave1.Click += new System.EventHandler(this.butsave1_Click);
            // 
            // butnew1
            // 
            this.butnew1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butnew1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnew1.Location = new System.Drawing.Point(149, 234);
            this.butnew1.Name = "butnew1";
            this.butnew1.Size = new System.Drawing.Size(154, 47);
            this.butnew1.TabIndex = 15;
            this.butnew1.Text = "New";
            this.butnew1.UseVisualStyleBackColor = false;
            this.butnew1.Click += new System.EventHandler(this.butnew1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.butclose1);
            this.panel2.Controls.Add(this.butview1);
            this.panel2.Controls.Add(this.butdel);
            this.panel2.Controls.Add(this.butedit1);
            this.panel2.Controls.Add(this.butsave1);
            this.panel2.Controls.Add(this.butnew1);
            this.panel2.Controls.Add(this.combounit);
            this.panel2.Controls.Add(this.combocat);
            this.panel2.Controls.Add(this.txtrate);
            this.panel2.Controls.Add(this.txtiname);
            this.panel2.Controls.Add(this.txtino);
            this.panel2.Controls.Add(this.labunit);
            this.panel2.Controls.Add(this.labentrydate);
            this.panel2.Controls.Add(this.labrate);
            this.panel2.Controls.Add(this.labicat);
            this.panel2.Controls.Add(this.labiname);
            this.panel2.Controls.Add(this.labino);
            this.panel2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(67, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 725);
            this.panel2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(804, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 31);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // combounit
            // 
            this.combounit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combounit.FormattingEnabled = true;
            this.combounit.Location = new System.Drawing.Point(799, 114);
            this.combounit.Name = "combounit";
            this.combounit.Size = new System.Drawing.Size(317, 31);
            this.combounit.TabIndex = 14;
            // 
            // combocat
            // 
            this.combocat.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocat.FormattingEnabled = true;
            this.combocat.Location = new System.Drawing.Point(270, 181);
            this.combocat.Name = "combocat";
            this.combocat.Size = new System.Drawing.Size(296, 31);
            this.combocat.TabIndex = 13;
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(799, 47);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(317, 31);
            this.txtrate.TabIndex = 10;
            // 
            // txtiname
            // 
            this.txtiname.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiname.Location = new System.Drawing.Point(272, 113);
            this.txtiname.Name = "txtiname";
            this.txtiname.Size = new System.Drawing.Size(296, 31);
            this.txtiname.TabIndex = 8;
            // 
            // txtino
            // 
            this.txtino.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtino.Location = new System.Drawing.Point(272, 44);
            this.txtino.Name = "txtino";
            this.txtino.Size = new System.Drawing.Size(296, 31);
            this.txtino.TabIndex = 7;
            // 
            // labunit
            // 
            this.labunit.AutoSize = true;
            this.labunit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labunit.Location = new System.Drawing.Point(613, 116);
            this.labunit.Name = "labunit";
            this.labunit.Size = new System.Drawing.Size(80, 23);
            this.labunit.TabIndex = 6;
            this.labunit.Text = "Unit In";
            // 
            // labentrydate
            // 
            this.labentrydate.AutoSize = true;
            this.labentrydate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labentrydate.Location = new System.Drawing.Point(613, 182);
            this.labentrydate.Name = "labentrydate";
            this.labentrydate.Size = new System.Drawing.Size(168, 23);
            this.labentrydate.TabIndex = 5;
            this.labentrydate.Text = "Item Entry Date";
            // 
            // labrate
            // 
            this.labrate.AutoSize = true;
            this.labrate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labrate.Location = new System.Drawing.Point(613, 47);
            this.labrate.Name = "labrate";
            this.labrate.Size = new System.Drawing.Size(55, 23);
            this.labrate.TabIndex = 4;
            this.labrate.Text = "Rate";
            // 
            // labicat
            // 
            this.labicat.AutoSize = true;
            this.labicat.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labicat.Location = new System.Drawing.Point(129, 185);
            this.labicat.Name = "labicat";
            this.labicat.Size = new System.Drawing.Size(125, 23);
            this.labicat.TabIndex = 3;
            this.labicat.Text = "Category In";
            // 
            // labiname
            // 
            this.labiname.AutoSize = true;
            this.labiname.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labiname.Location = new System.Drawing.Point(129, 116);
            this.labiname.Name = "labiname";
            this.labiname.Size = new System.Drawing.Size(117, 23);
            this.labiname.TabIndex = 2;
            this.labiname.Text = "Item Name";
            // 
            // labino
            // 
            this.labino.AutoSize = true;
            this.labino.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labino.Location = new System.Drawing.Point(129, 47);
            this.labino.Name = "labino";
            this.labino.Size = new System.Drawing.Size(87, 23);
            this.labino.TabIndex = 1;
            this.labino.Text = "Item No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Details";
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1409, 826);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "item";
            this.Load += new System.EventHandler(this.item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button butclose1;
        private System.Windows.Forms.Button butview1;
        private System.Windows.Forms.Button butdel;
        private System.Windows.Forms.Button butedit1;
        private System.Windows.Forms.Button butsave1;
        private System.Windows.Forms.Button butnew1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox combounit;
        private System.Windows.Forms.ComboBox combocat;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtiname;
        private System.Windows.Forms.TextBox txtino;
        private System.Windows.Forms.Label labunit;
        private System.Windows.Forms.Label labentrydate;
        private System.Windows.Forms.Label labrate;
        private System.Windows.Forms.Label labicat;
        private System.Windows.Forms.Label labiname;
        private System.Windows.Forms.Label labino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private restaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private restaurantDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn irateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ientrydateDataGridViewTextBoxColumn;
    }
}