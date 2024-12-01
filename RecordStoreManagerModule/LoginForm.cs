using AutoMapper;
using RecordStoreManagerModule.BLL.Services;

namespace RecordStoreManagerModule
{
    public partial class LoginForm : Form
    {
        private readonly IMapper _mapper;
        private readonly IHashService _hashService;
        private readonly IAdminService _adminService;
        private readonly IAlbumService _albumService;

        public LoginForm(IAdminService adminService, IMapper mapper, IHashService hashService, IAlbumService albumService)
        {
            InitializeComponent();
            _mapper = mapper;
            _hashService = hashService;
            _adminService = adminService;
            _albumService = albumService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();


                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Kullanıcı adı ve parola alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string hashedPassword = _hashService.GetHashCode(password);
                var user = _adminService.Login(username, hashedPassword);
                if (user == null)
                {
                    MessageBox.Show("Giriş yaptığınız kullanıcı adi veya parolaya ait kullanıcı bulunmuyor, lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Form homePage = new HomePageForm(_albumService);
                this.Hide();
                homePage.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu! " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new RegisterForm(_adminService, _mapper, _hashService, _albumService);
            this.Hide();
            form.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
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
    }
}



