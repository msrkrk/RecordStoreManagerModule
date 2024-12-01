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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvNotOnSale = new DataGridView();
            tabPage2 = new TabPage();
            dgvOnSale = new DataGridView();
            tabPage3 = new TabPage();
            dgvLastTen = new DataGridView();
            tabPage4 = new TabPage();
            dgvDiscount = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotOnSale).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOnSale).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLastTen).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 0;
            label1.Text = "Albüm Adı:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 1;
            label2.Text = "Sanatçı:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 56);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 2;
            label3.Text = "Çıkış Tarihi:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 84);
            label4.Name = "label4";
            label4.Size = new Size(192, 28);
            label4.TabIndex = 3;
            label4.Text = "Fiyatı";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 112);
            label5.Name = "label5";
            label5.Size = new Size(192, 28);
            label5.TabIndex = 4;
            label5.Text = "İndirim Oranı:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 140);
            label6.Name = "label6";
            label6.Size = new Size(192, 29);
            label6.TabIndex = 5;
            label6.Text = "Satış Devam Ediyor mu?";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAlbumName
            // 
            txtAlbumName.Dock = DockStyle.Fill;
            txtAlbumName.Location = new Point(198, 0);
            txtAlbumName.Margin = new Padding(0);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(390, 23);
            txtAlbumName.TabIndex = 6;
            // 
            // txtArtist
            // 
            txtArtist.Dock = DockStyle.Fill;
            txtArtist.Location = new Point(198, 28);
            txtArtist.Margin = new Padding(0);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(390, 23);
            txtArtist.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Location = new Point(198, 84);
            txtPrice.Margin = new Padding(0);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(390, 23);
            txtPrice.TabIndex = 9;
            // 
            // txtDiscountRatio
            // 
            txtDiscountRatio.Dock = DockStyle.Fill;
            txtDiscountRatio.Location = new Point(198, 112);
            txtDiscountRatio.Margin = new Padding(0);
            txtDiscountRatio.Name = "txtDiscountRatio";
            txtDiscountRatio.Size = new Size(390, 23);
            txtDiscountRatio.TabIndex = 10;
            // 
            // cbOnSale
            // 
            cbOnSale.AutoSize = true;
            cbOnSale.Dock = DockStyle.Fill;
            cbOnSale.Location = new Point(201, 143);
            cbOnSale.Name = "cbOnSale";
            cbOnSale.Size = new Size(384, 23);
            cbOnSale.TabIndex = 11;
            cbOnSale.UseVisualStyleBackColor = true;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Dock = DockStyle.Fill;
            dtpReleaseDate.Location = new Point(201, 59);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(384, 23);
            dtpReleaseDate.TabIndex = 13;
            // 
            // dgvAlbums
            // 
            dgvAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbums.Dock = DockStyle.Fill;
            dgvAlbums.Location = new Point(603, 3);
            dgvAlbums.Name = "dgvAlbums";
            dgvAlbums.ReadOnly = true;
            dgvAlbums.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAlbums.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbums.Size = new Size(883, 484);
            dgvAlbums.TabIndex = 14;
            dgvAlbums.CellClick += dgvAlbums_CellClick;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(190, 38);
            btnSave.TabIndex = 15;
            btnSave.Text = "EKLE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(199, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(190, 38);
            btnClear.TabIndex = 16;
            btnClear.Text = "TEMİZLE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(395, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 38);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1495, 992);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvAlbums, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1489, 490);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(594, 484);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(btnSave, 0, 0);
            tableLayoutPanel4.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel4.Controls.Add(btnClear, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 178);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(588, 44);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.68644F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.31356F));
            tableLayoutPanel5.Controls.Add(txtAlbumName, 1, 0);
            tableLayoutPanel5.Controls.Add(label5, 0, 4);
            tableLayoutPanel5.Controls.Add(cbOnSale, 1, 5);
            tableLayoutPanel5.Controls.Add(label4, 0, 3);
            tableLayoutPanel5.Controls.Add(dtpReleaseDate, 1, 2);
            tableLayoutPanel5.Controls.Add(label3, 0, 2);
            tableLayoutPanel5.Controls.Add(txtDiscountRatio, 1, 4);
            tableLayoutPanel5.Controls.Add(label2, 0, 1);
            tableLayoutPanel5.Controls.Add(txtArtist, 1, 1);
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Controls.Add(txtPrice, 1, 3);
            tableLayoutPanel5.Controls.Add(label6, 0, 5);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.Size = new Size(588, 169);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 499);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1489, 490);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvNotOnSale);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1481, 462);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Satışı Durmuş";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvNotOnSale
            // 
            dgvNotOnSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotOnSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotOnSale.Dock = DockStyle.Fill;
            dgvNotOnSale.Location = new Point(3, 3);
            dgvNotOnSale.Name = "dgvNotOnSale";
            dgvNotOnSale.Size = new Size(1475, 456);
            dgvNotOnSale.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvOnSale);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1481, 462);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Satışı Devam Eden";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvOnSale
            // 
            dgvOnSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOnSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOnSale.Dock = DockStyle.Fill;
            dgvOnSale.Location = new Point(3, 3);
            dgvOnSale.Name = "dgvOnSale";
            dgvOnSale.Size = new Size(1475, 456);
            dgvOnSale.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvLastTen);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1481, 462);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Son 10 Eklenen";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvLastTen
            // 
            dgvLastTen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLastTen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLastTen.Dock = DockStyle.Fill;
            dgvLastTen.Location = new Point(3, 3);
            dgvLastTen.Name = "dgvLastTen";
            dgvLastTen.Size = new Size(1475, 456);
            dgvLastTen.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvDiscount);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1481, 462);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "İndirimdekiler";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvDiscount
            // 
            dgvDiscount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiscount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscount.Dock = DockStyle.Fill;
            dgvDiscount.Location = new Point(3, 3);
            dgvDiscount.Name = "dgvDiscount";
            dgvDiscount.Size = new Size(1475, 456);
            dgvDiscount.TabIndex = 0;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1495, 992);
            Controls.Add(tableLayoutPanel1);
            Name = "HomePageForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HomePageForm";
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotOnSale).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOnSale).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLastTen).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDiscount).EndInit();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvNotOnSale;
        private DataGridView dgvOnSale;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dgvLastTen;
        private DataGridView dgvDiscount;
    }
}