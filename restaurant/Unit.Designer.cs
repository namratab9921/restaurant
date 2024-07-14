namespace restaurant
{
    partial class Unit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unit));
            this.label1 = new System.Windows.Forms.Label();
            this.labunino = new System.Windows.Forms.Label();
            this.labuni = new System.Windows.Forms.Label();
            this.txtunino = new System.Windows.Forms.TextBox();
            this.txtuniname = new System.Windows.Forms.TextBox();
            this.butnew = new System.Windows.Forms.Button();
            this.butdel = new System.Windows.Forms.Button();
            this.butview = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.unitnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSet = new restaurant.restaurantDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.unitTableAdapter = new restaurant.restaurantDataSetTableAdapters.UnitTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 70);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOTEL SHIVNERI";
            // 
            // labunino
            // 
            this.labunino.AutoSize = true;
            this.labunino.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labunino.Location = new System.Drawing.Point(43, 38);
            this.labunino.Name = "labunino";
            this.labunino.Size = new System.Drawing.Size(85, 23);
            this.labunino.TabIndex = 0;
            this.labunino.Text = "Unit No";
            // 
            // labuni
            // 
            this.labuni.AutoSize = true;
            this.labuni.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labuni.Location = new System.Drawing.Point(43, 83);
            this.labuni.Name = "labuni";
            this.labuni.Size = new System.Drawing.Size(53, 23);
            this.labuni.TabIndex = 1;
            this.labuni.Text = "Unit";
            // 
            // txtunino
            // 
            this.txtunino.Location = new System.Drawing.Point(199, 40);
            this.txtunino.Name = "txtunino";
            this.txtunino.Size = new System.Drawing.Size(296, 22);
            this.txtunino.TabIndex = 2;
            // 
            // txtuniname
            // 
            this.txtuniname.Location = new System.Drawing.Point(199, 85);
            this.txtuniname.Name = "txtuniname";
            this.txtuniname.Size = new System.Drawing.Size(296, 22);
            this.txtuniname.TabIndex = 3;
            // 
            // butnew
            // 
            this.butnew.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnew.Location = new System.Drawing.Point(568, 20);
            this.butnew.Name = "butnew";
            this.butnew.Size = new System.Drawing.Size(145, 41);
            this.butnew.TabIndex = 4;
            this.butnew.Text = "New";
            this.butnew.UseVisualStyleBackColor = true;
            this.butnew.Click += new System.EventHandler(this.butnew_Click);
            // 
            // butdel
            // 
            this.butdel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdel.Location = new System.Drawing.Point(731, 81);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(145, 41);
            this.butdel.TabIndex = 6;
            this.butdel.Text = "Delete";
            this.butdel.UseVisualStyleBackColor = true;
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butview
            // 
            this.butview.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butview.Location = new System.Drawing.Point(568, 81);
            this.butview.Name = "butview";
            this.butview.Size = new System.Drawing.Size(145, 41);
            this.butview.TabIndex = 7;
            this.butview.Text = "View";
            this.butview.UseVisualStyleBackColor = true;
            this.butview.Click += new System.EventHandler(this.butview_Click);
            // 
            // butsave
            // 
            this.butsave.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.Location = new System.Drawing.Point(731, 20);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(145, 41);
            this.butsave.TabIndex = 8;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = true;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitnoDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.unitBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(117, 140);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(706, 309);
            this.dataGridView2.TabIndex = 9;
            // 
            // unitnoDataGridViewTextBoxColumn
            // 
            this.unitnoDataGridViewTextBoxColumn.DataPropertyName = "Unit_no";
            this.unitnoDataGridViewTextBoxColumn.HeaderText = "Unit_no";
            this.unitnoDataGridViewTextBoxColumn.Name = "unitnoDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.restaurantDataSet;
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "restaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.butsave);
            this.panel2.Controls.Add(this.butview);
            this.panel2.Controls.Add(this.butdel);
            this.panel2.Controls.Add(this.butnew);
            this.panel2.Controls.Add(this.txtuniname);
            this.panel2.Controls.Add(this.txtunino);
            this.panel2.Controls.Add(this.labuni);
            this.panel2.Controls.Add(this.labunino);
            this.panel2.Location = new System.Drawing.Point(27, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 480);
            this.panel2.TabIndex = 5;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add Unit";
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(982, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Unit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit";
            this.Load += new System.EventHandler(this.Unit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labunino;
        private System.Windows.Forms.Label labuni;
        private System.Windows.Forms.TextBox txtunino;
        private System.Windows.Forms.TextBox txtuniname;
        private System.Windows.Forms.Button butnew;
        private System.Windows.Forms.Button butdel;
        private System.Windows.Forms.Button butview;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private restaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private restaurantDataSetTableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}