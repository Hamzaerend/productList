namespace AdoNett
{
    partial class gbxAdd
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.tbxStokUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblFiyatUpdate = new System.Windows.Forms.Label();
            this.tbxFiyatUpdate = new System.Windows.Forms.TextBox();
            this.lblStokUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.ad.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(73, 24);
            this.dgwProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(789, 213);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 33);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "İsim";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(119, 26);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(141, 23);
            this.tbxName.TabIndex = 2;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(119, 71);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(141, 23);
            this.tbxPrice.TabIndex = 3;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(19, 123);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(39, 16);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stok";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(19, 78);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 16);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Fiyat";
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(119, 116);
            this.tbxStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(141, 23);
            this.tbxStock.TabIndex = 6;
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ad.Controls.Add(this.btnAdd);
            this.ad.Controls.Add(this.lblName);
            this.ad.Controls.Add(this.tbxStock);
            this.ad.Controls.Add(this.tbxName);
            this.ad.Controls.Add(this.lblPrice);
            this.ad.Controls.Add(this.tbxPrice);
            this.ad.Controls.Add(this.lblStock);
            this.ad.Location = new System.Drawing.Point(73, 266);
            this.ad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ad.Name = "ad";
            this.ad.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ad.Size = new System.Drawing.Size(326, 221);
            this.ad.TabIndex = 7;
            this.ad.TabStop = false;
            this.ad.Text = "Ürün Ekle";
            this.ad.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(119, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxStokUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblFiyatUpdate);
            this.gbxUpdate.Controls.Add(this.tbxFiyatUpdate);
            this.gbxUpdate.Controls.Add(this.lblStokUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(536, 266);
            this.gbxUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxUpdate.Size = new System.Drawing.Size(326, 221);
            this.gbxUpdate.TabIndex = 8;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Ürün Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(119, 175);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 40);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(19, 33);
            this.lblNameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(39, 16);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "İsim";
            // 
            // tbxStokUpdate
            // 
            this.tbxStokUpdate.Location = new System.Drawing.Point(119, 116);
            this.tbxStokUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxStokUpdate.Name = "tbxStokUpdate";
            this.tbxStokUpdate.Size = new System.Drawing.Size(141, 23);
            this.tbxStokUpdate.TabIndex = 6;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(119, 26);
            this.tbxNameUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(141, 23);
            this.tbxNameUpdate.TabIndex = 2;
            // 
            // lblFiyatUpdate
            // 
            this.lblFiyatUpdate.AutoSize = true;
            this.lblFiyatUpdate.Location = new System.Drawing.Point(19, 78);
            this.lblFiyatUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiyatUpdate.Name = "lblFiyatUpdate";
            this.lblFiyatUpdate.Size = new System.Drawing.Size(44, 16);
            this.lblFiyatUpdate.TabIndex = 5;
            this.lblFiyatUpdate.Text = "Fiyat";
            // 
            // tbxFiyatUpdate
            // 
            this.tbxFiyatUpdate.Location = new System.Drawing.Point(119, 71);
            this.tbxFiyatUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxFiyatUpdate.Name = "tbxFiyatUpdate";
            this.tbxFiyatUpdate.Size = new System.Drawing.Size(141, 23);
            this.tbxFiyatUpdate.TabIndex = 3;
            // 
            // lblStokUpdate
            // 
            this.lblStokUpdate.AutoSize = true;
            this.lblStokUpdate.Location = new System.Drawing.Point(19, 123);
            this.lblStokUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStokUpdate.Name = "lblStokUpdate";
            this.lblStokUpdate.Size = new System.Drawing.Size(39, 16);
            this.lblStokUpdate.TabIndex = 4;
            this.lblStokUpdate.Text = "Stok";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(423, 352);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 83);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gbxAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 499);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.dgwProducts);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "gbxAdd";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ad.ResumeLayout(false);
            this.ad.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.GroupBox ad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox tbxStokUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblFiyatUpdate;
        private System.Windows.Forms.TextBox tbxFiyatUpdate;
        private System.Windows.Forms.Label lblStokUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

