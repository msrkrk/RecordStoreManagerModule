using AutoMapper;
using RecordStoreManagerModule.BLL.Dtos;
using RecordStoreManagerModule.BLL.Services;
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
    public partial class RegisterForm : Form
    {
        private readonly IMapper _mapper;
        private readonly IHashService _hashService;
        private readonly IAdminService _adminService;
        private readonly IAlbumService _albumService;

        public RegisterForm(IAdminService adminService, IMapper mapper, IHashService hashService, IAlbumService albumService)
        {
            InitializeComponent();
            _mapper = mapper;
            _hashService = hashService;
            _adminService = adminService;
            _albumService = albumService;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var admin = new AdminDto();

                string username = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();
                string repeatPassword = txtRepeatPassword.Text.Trim(); 

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(repeatPassword))
                {
                    MessageBox.Show("Kullanıcı adı, şifre ve şifre tekrar alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidPassword(password))
                {
                    MessageBox.Show("Şifreniz en az 8 karakter uzunluğunda olmalı, en az 2 büyük harf, 3 küçük harf ve '!:+*' gibi özel karakterlerden en az 2 tanesini içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password != repeatPassword)
                {
                    MessageBox.Show("Şifreler uyuşmuyor. Lütfen şifrelerinizi kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
              
                var existingAdmin = _adminService.GetAdminByUserName(username);
                if (existingAdmin != null)
                {
                    MessageBox.Show("Girilen kullanıcı adı başka bir kullanıcı tarafından kullanılmaktadır. Lütfen farklı bir kullanıcı adı ile tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               
                admin.UserName = username;
                admin.Password = _hashService.GetHashCode(password);

                _adminService.Register(_mapper.Map<AdminDto>(admin));
                MessageBox.Show("Kayıt işlemi başarı ile gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form loginForm = new LoginForm(_adminService, _mapper, _hashService, _albumService);
                this.Hide();
                loginForm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu! " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            int uppercaseCount = password.Count(char.IsUpper);
            int lowercaseCount = password.Count(char.IsLower);
            int specialCharCount = password.Count(c => "!:+*".Contains(c));

            if (uppercaseCount < 2)
                return false;
            if (lowercaseCount < 3)
                return false;
            if (specialCharCount < 2)
                return false;

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm(_adminService, _mapper, _hashService, _albumService);
            this.Hide();
            loginForm.ShowDialog();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtRepeatPassword.PasswordChar = '*';
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void chkShowRepeatPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtRepeatPassword.PasswordChar = '\0';
            }
            else
            {
                txtRepeatPassword.PasswordChar = '*';
            }
        }
    }
}
