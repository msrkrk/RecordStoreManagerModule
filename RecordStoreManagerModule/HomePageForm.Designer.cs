namespace RecordStoreManagerModule
{
    partial class HomePageForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAlbumName = new TextBox();
            txtArtist = new TextBox();
            txtPrice = new TextBox();
            txtDiscountRatio = new TextBox();
            cbOnSale = new CheckBox();
            dtpReleaseDate = new DateTimePicker();
            dgvAlbums = new DataGridView();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 25);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Albüm Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 66);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Sanatçı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 106);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 136);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 166);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 4;
            label5.Text = "İndirim Oranı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 199);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 5;
            label6.Text = "Satış Devam Ediyor mu?";
            // 
            // txtAlbumName
            // 
            txtAlbumName.Location = new Point(195, 22);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(185, 23);
            txtAlbumName.TabIndex = 6;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(195, 63);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(185, 23);
            txtArtist.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(195, 133);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(185, 23);
            txtPrice.TabIndex = 9;
            // 
            // txtDiscountRatio
            // 
            txtDiscountRatio.Location = new Point(195, 163);
            txtDiscountRatio.Name = "txtDiscountRatio";
            txtDiscountRatio.Size = new Size(185, 23);
            txtDiscountRatio.TabIndex = 10;
            // 
            // cbOnSale
            // 
            cbOnSale.AutoSize = true;
            cbOnSale.Location = new Point(196, 203);
            cbOnSale.Name = "cbOnSale";
            cbOnSale.Size = new Size(60, 19);
            cbOnSale.TabIndex = 11;
            cbOnSale.Text = "Satışta";
            cbOnSale.UseVisualStyleBackColor = true;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(196, 100);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(184, 23);
            dtpReleaseDate.TabIndex = 13;
            // 
            // dgvAlbums
            // 
            dgvAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbums.Location = new Point(516, 12);
            dgvAlbums.Name = "dgvAlbums";
            dgvAlbums.ReadOnly = true;
            dgvAlbums.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAlbums.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbums.Size = new Size(724, 263);
            dgvAlbums.TabIndex = 14;
            dgvAlbums.CellClick += dgvAlbums_CellClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(34, 237);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 48);
            btnSave.TabIndex = 15;
            btnSave.Text = "EKLE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(196, 237);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 48);
            btnClear.TabIndex = 16;
            btnClear.Text = "TEMİZLE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(352, 237);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 48);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 992);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(dgvAlbums);
            Controls.Add(dtpReleaseDate);
            Controls.Add(cbOnSale);
            Controls.Add(txtDiscountRatio);
            Controls.Add(txtPrice);
            Controls.Add(txtArtist);
            Controls.Add(txtAlbumName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HomePageForm";
            Text = "HomePageForm";
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAlbumName;
        private TextBox txtArtist;
        private TextBox txtPrice;
        private TextBox txtDiscountRatio;
        private CheckBox cbOnSale;
        private DateTimePicker dtpReleaseDate;
        private DataGridView dgvAlbums;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
    }
}