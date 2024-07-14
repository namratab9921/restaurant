namespace restaurant
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridcategory = new System.Windows.Forms.DataGridView();
            this.butsave = new System.Windows.Forms.Button();
            this.butview = new System.Windows.Forms.Button();
            this.butdel = new System.Windows.Forms.Button();
            this.butnew = new System.Windows.Forms.Button();
            this.txtcategoryname = new System.Windows.Forms.TextBox();
            this.txtcategoryno = new System.Windows.Forms.TextBox();
            this.labcategory = new System.Windows.Forms.Label();
            this.labcategoryno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.restaurantDataSet = new restaurant.restaurantDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new restaurant.restaurantDataSetTableAdapters.CategoryTableAdapter();
            this.icategorynoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOTEL SHIVNERI";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.gridcategory);
            this.panel2.Controls.Add(this.butsave);
            this.panel2.Controls.Add(this.butview);
            this.panel2.Controls.Add(this.butdel);
            this.panel2.Controls.Add(this.butnew);
            this.panel2.Controls.Add(this.txtcategoryname);
            this.panel2.Controls.Add(this.txtcategoryno);
            this.panel2.Controls.Add(this.labcategory);
            this.panel2.Controls.Add(this.labcategoryno);
            this.panel2.Location = new System.Drawing.Point(23, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 531);
            this.panel2.TabIndex = 2;
            // 
            // gridcategory
            // 
            this.gridcategory.AutoGenerateColumns = false;
            this.gridcategory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.icategorynoDataGridViewTextBoxColumn,
            this.icategoryDataGridViewTextBoxColumn});
            this.gridcategory.DataSource = this.categoryBindingSource;
            this.gridcategory.Location = new System.Drawing.Point(73, 163);
            this.gridcategory.Name = "gridcategory";
            this.gridcategory.RowTemplate.Height = 24;
            this.gridcategory.Size = new System.Drawing.Size(647, 226);
            this.gridcategory.TabIndex = 9;
            // 
            // butsave
            // 
            this.butsave.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.Location = new System.Drawing.Point(790, 29);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(145, 41);
            this.butsave.TabIndex = 8;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = true;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // butview
            // 
            this.butview.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butview.Location = new System.Drawing.Point(627, 96);
            this.butview.Name = "butview";
            this.butview.Size = new System.Drawing.Size(145, 41);
            this.butview.TabIndex = 7;
            this.butview.Text = "View";
            this.butview.UseVisualStyleBackColor = true;
            this.butview.Click += new System.EventHandler(this.butview_Click);
            // 
            // butdel
            // 
            this.butdel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdel.Location = new System.Drawing.Point(790, 96);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(145, 41);
            this.butdel.TabIndex = 6;
            this.butdel.Text = "Delete";
            this.butdel.UseVisualStyleBackColor = true;
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butnew
            // 
            this.butnew.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnew.Location = new System.Drawing.Point(627, 29);
            this.butnew.Name = "butnew";
            this.butnew.Size = new System.Drawing.Size(145, 41);
            this.butnew.TabIndex = 4;
            this.butnew.Text = "New";
            this.butnew.UseVisualStyleBackColor = true;
            this.butnew.Click += new System.EventHandler(this.butnew_Click);
            // 
            // txtcategoryname
            // 
            this.txtcategoryname.Location = new System.Drawing.Point(219, 98);
            this.txtcategoryname.Name = "txtcategoryname";
            this.txtcategoryname.Size = new System.Drawing.Size(352, 22);
            this.txtcategoryname.TabIndex = 3;
            // 
            // txtcategoryno
            // 
            this.txtcategoryno.Location = new System.Drawing.Point(221, 40);
            this.txtcategoryno.Name = "txtcategoryno";
            this.txtcategoryno.Size = new System.Drawing.Size(350, 22);
            this.txtcategoryno.TabIndex = 2;
            // 
            // labcategory
            // 
            this.labcategory.AutoSize = true;
            this.labcategory.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcategory.Location = new System.Drawing.Point(69, 96);
            this.labcategory.Name = "labcategory";
            this.labcategory.Size = new System.Drawing.Size(98, 23);
            this.labcategory.TabIndex = 1;
            this.labcategory.Text = "Category";
            // 
            // labcategoryno
            // 
            this.labcategoryno.AutoSize = true;
            this.labcategoryno.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcategoryno.Location = new System.Drawing.Point(69, 38);
            this.labcategoryno.Name = "labcategoryno";
            this.labcategoryno.Size = new System.Drawing.Size(130, 23);
            this.labcategoryno.TabIndex = 0;
            this.labcategoryno.Text = "Category No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Category";
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "restaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.restaurantDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // icategorynoDataGridViewTextBoxColumn
            // 
            this.icategorynoDataGridViewTextBoxColumn.DataPropertyName = "I_categoryno";
            this.icategorynoDataGridViewTextBoxColumn.HeaderText = "I_categoryno";
            this.icategorynoDataGridViewTextBoxColumn.Name = "icategorynoDataGridViewTextBoxColumn";
            // 
            // icategoryDataGridViewTextBoxColumn
            // 
            this.icategoryDataGridViewTextBoxColumn.DataPropertyName = "I_category";
            this.icategoryDataGridViewTextBoxColumn.HeaderText = "I_category";
            this.icategoryDataGridViewTextBoxColumn.Name = "icategoryDataGridViewTextBoxColumn";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1038, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridcategory;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.Button butview;
        private System.Windows.Forms.Button butdel;
        private System.Windows.Forms.Button butnew;
        private System.Windows.Forms.TextBox txtcategoryname;
        private System.Windows.Forms.TextBox txtcategoryno;
        private System.Windows.Forms.Label labcategory;
        private System.Windows.Forms.Label labcategoryno;
        private System.Windows.Forms.Label label2;
        private restaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private restaurantDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn icategorynoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icategoryDataGridViewTextBoxColumn;
    }
}