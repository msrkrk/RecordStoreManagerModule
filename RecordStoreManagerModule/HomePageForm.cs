using RecordStoreManagerModule.BLL.Dtos;
using RecordStoreManagerModule.BLL.Services;
using RecordStoreManagerModule.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordStoreManagerModule
{
    public partial class HomePageForm : Form
    {
        private readonly IAlbumService _albumService;

        private AlbumDto? _selectedAlbum;

        public HomePageForm(IAlbumService albumService)
        {
            InitializeComponent();

            _albumService = albumService;

            LoadAlbums();
        }

        private void LoadAlbums()
        {
            dgvAlbums.DataSource = _albumService.GetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedAlbum != null)
            {
                _selectedAlbum.Name = txtAlbumName.Text;
                _selectedAlbum.Artist = txtArtist.Text;
                _selectedAlbum.Discount = Convert.ToDouble(txtDiscountRatio.Text);
                _selectedAlbum.Price = Convert.ToDecimal(txtPrice.Text);
                _selectedAlbum.ReleaseDate = dtpReleaseDate.Value;
                _selectedAlbum.IsOnSale = cbOnSale.Checked;

                _albumService.Update(_selectedAlbum);

            }
            else
            {
                var newAlbum = new AlbumDto();

                newAlbum.Name = txtAlbumName.Text;
                newAlbum.Artist = txtArtist.Text;
                newAlbum.Discount = Convert.ToDouble(txtDiscountRatio.Text);
                newAlbum.Price = Convert.ToDecimal(txtPrice.Text);
                newAlbum.ReleaseDate = dtpReleaseDate.Value;
                newAlbum.IsOnSale = cbOnSale.Checked;

                _albumService.Add(newAlbum);
            }

            LoadAlbums();

            btnClear_Click(sender, e);
        }

        private void dgvAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            _selectedAlbum = dgvAlbums.Rows[e.RowIndex].DataBoundItem as AlbumDto;

            if (_selectedAlbum == null) return;

            txtAlbumName.Text = _selectedAlbum.Name;
            txtArtist.Text = _selectedAlbum.Artist;
            txtDiscountRatio.Text = _selectedAlbum.Discount.ToString();
            txtPrice.Text = _selectedAlbum.Price.ToString();
            cbOnSale.Checked = _selectedAlbum.IsOnSale;
            dtpReleaseDate.Value = _selectedAlbum.ReleaseDate;

            btnSave.Text = "GÜNCELLE";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _selectedAlbum = null;

            txtAlbumName.Text = null;
            txtArtist.Text = null;
            txtDiscountRatio.Text = null;
            txtPrice.Text = null;
            cbOnSale.Checked = false;
            dtpReleaseDate.Value = DateTime.Now;

            btnSave.Text = "EKLE";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_selectedAlbum == null) return;

            _albumService.Delete(_selectedAlbum.Id);

            LoadAlbums();

            btnClear_Click(sender, e);
        }
    }
}
