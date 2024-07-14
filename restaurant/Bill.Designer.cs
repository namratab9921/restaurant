namespace restaurant
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.butsave = new System.Windows.Forms.Button();
            this.txttot = new System.Windows.Forms.TextBox();
            this.labtot = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butbillprint = new System.Windows.Forms.Button();
            this.comboitemname = new System.Windows.Forms.ComboBox();
            this.butadditemlist = new System.Windows.Forms.Button();
            this.txtitemrate = new System.Windows.Forms.TextBox();
            this.txtitemquantity = new System.Windows.Forms.TextBox();
            this.txtbilltotal = new System.Windows.Forms.TextBox();
            this.labbilltot = new System.Windows.Forms.Label();
            this.labrate = new System.Windows.Forms.Label();
            this.labitemquantity = new System.Windows.Forms.Label();
            this.labitemname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butsave
            // 
            this.butsave.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.Location = new System.Drawing.Point(576, 660);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(152, 35);
            this.butsave.TabIndex = 98;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = true;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // txttot
            // 
            this.txttot.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttot.Location = new System.Drawing.Point(646, 175);
            this.txttot.Name = "txttot";
            this.txttot.Size = new System.Drawing.Size(276, 31);
            this.txttot.TabIndex = 86;
            // 
            // labtot
            // 
            this.labtot.AutoSize = true;
            this.labtot.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtot.Location = new System.Drawing.Point(516, 178);
            this.labtot.Name = "labtot";
            this.labtot.Size = new System.Drawing.Size(59, 23);
            this.labtot.TabIndex = 97;
            this.labtot.Text = "Total";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 264);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(896, 336);
            this.listView1.TabIndex = 96;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 215;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rate";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // butbillprint
            // 
            this.butbillprint.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butbillprint.Location = new System.Drawing.Point(758, 660);
            this.butbillprint.Name = "butbillprint";
            this.butbillprint.Size = new System.Drawing.Size(140, 35);
            this.butbillprint.TabIndex = 89;
            this.butbillprint.Text = "Print";
            this.butbillprint.UseVisualStyleBackColor = true;
            this.butbillprint.Click += new System.EventHandler(this.butbillprint_Click);
            // 
            // comboitemname
            // 
            this.comboitemname.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboitemname.FormattingEnabled = true;
            this.comboitemname.Location = new System.Drawing.Point(134, 122);
            this.comboitemname.Name = "comboitemname";
            this.comboitemname.Size = new System.Drawing.Size(337, 31);
            this.comboitemname.TabIndex = 83;
            this.comboitemname.SelectedIndexChanged += new System.EventHandler(this.comboitemname_SelectedIndexChanged);
            // 
            // butadditemlist
            // 
            this.butadditemlist.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butadditemlist.Location = new System.Drawing.Point(804, 223);
            this.butadditemlist.Name = "butadditemlist";
            this.butadditemlist.Size = new System.Drawing.Size(118, 35);
            this.butadditemlist.TabIndex = 87;
            this.butadditemlist.Text = "Add item";
            this.butadditemlist.UseVisualStyleBackColor = true;
            this.butadditemlist.Click += new System.EventHandler(this.butadditemlist_Click);
            // 
            // txtitemrate
            // 
            this.txtitemrate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemrate.Location = new System.Drawing.Point(134, 175);
            this.txtitemrate.Name = "txtitemrate";
            this.txtitemrate.Size = new System.Drawing.Size(337, 31);
            this.txtitemrate.TabIndex = 84;
            this.txtitemrate.TextChanged += new System.EventHandler(this.txtitemrate_TextChanged);
            // 
            // txtitemquantity
            // 
            this.txtitemquantity.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemquantity.Location = new System.Drawing.Point(646, 122);
            this.txtitemquantity.Name = "txtitemquantity";
            this.txtitemquantity.Size = new System.Drawing.Size(276, 31);
            this.txtitemquantity.TabIndex = 85;
            this.txtitemquantity.TextChanged += new System.EventHandler(this.txtitemquantity_TextChanged);
            // 
            // txtbilltotal
            // 
            this.txtbilltotal.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbilltotal.Location = new System.Drawing.Point(690, 608);
            this.txtbilltotal.Name = "txtbilltotal";
            this.txtbilltotal.Size = new System.Drawing.Size(229, 31);
            this.txtbilltotal.TabIndex = 88;
            this.txtbilltotal.Text = "0";
            this.txtbilltotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbilltotal.TextChanged += new System.EventHandler(this.txtbilltotal_TextChanged);
            // 
            // labbilltot
            // 
            this.labbilltot.AutoSize = true;
            this.labbilltot.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labbilltot.Location = new System.Drawing.Point(553, 616);
            this.labbilltot.Name = "labbilltot";
            this.labbilltot.Size = new System.Drawing.Size(104, 23);
            this.labbilltot.TabIndex = 95;
            this.labbilltot.Text = "Sub Total";
            // 
            // labrate
            // 
            this.labrate.AutoSize = true;
            this.labrate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labrate.Location = new System.Drawing.Point(49, 183);
            this.labrate.Name = "labrate";
            this.labrate.Size = new System.Drawing.Size(55, 23);
            this.labrate.TabIndex = 94;
            this.labrate.Text = "Rate";
            // 
            // labitemquantity
            // 
            this.labitemquantity.AutoSize = true;
            this.labitemquantity.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labitemquantity.Location = new System.Drawing.Point(512, 125);
            this.labitemquantity.Name = "labitemquantity";
            this.labitemquantity.Size = new System.Drawing.Size(98, 23);
            this.labitemquantity.TabIndex = 93;
            this.labitemquantity.Text = "Quantity";
            // 
            // labitemname
            // 
            this.labitemname.AutoSize = true;
            this.labitemname.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labitemname.Location = new System.Drawing.Point(49, 130);
            this.labitemname.Name = "labitemname";
            this.labitemname.Size = new System.Drawing.Size(55, 23);
            this.labitemname.TabIndex = 92;
            this.labitemname.Text = "Item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Felix Titling", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(156, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(531, 70);
            this.label7.TabIndex = 91;
            this.label7.Text = "HOTEL SHIVNERI";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 711);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.txttot);
            this.Controls.Add(this.labtot);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.butbillprint);
            this.Controls.Add(this.comboitemname);
            this.Controls.Add(this.butadditemlist);
            this.Controls.Add(this.txtitemrate);
            this.Controls.Add(this.txtitemquantity);
            this.Controls.Add(this.txtbilltotal);
            this.Controls.Add(this.labbilltot);
            this.Controls.Add(this.labrate);
            this.Controls.Add(this.labitemquantity);
            this.Controls.Add(this.labitemname);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.TextBox txttot;
        private System.Windows.Forms.Label labtot;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button butbillprint;
        private System.Windows.Forms.ComboBox comboitemname;
        private System.Windows.Forms.Button butadditemlist;
        private System.Windows.Forms.TextBox txtitemrate;
        private System.Windows.Forms.TextBox txtitemquantity;
        private System.Windows.Forms.TextBox txtbilltotal;
        private System.Windows.Forms.Label labbilltot;
        private System.Windows.Forms.Label labrate;
        private System.Windows.Forms.Label labitemquantity;
        private System.Windows.Forms.Label labitemname;
        private System.Windows.Forms.Label label7;
    }
}