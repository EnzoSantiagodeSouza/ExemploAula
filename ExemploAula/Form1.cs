namespace ExemploAula
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtSenha.Text == "007")
            {
                MessageBox.Show("Uus�rio logado com sucesso");
                txtUsuario.Clear();
                txtSenha.Clear();

                Hide();
                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
            }

            else
            {
                MessageBox.Show("Usuario/Senha inv�lidos");
                txtUsuario.Clear();
                txtSenha.Clear();
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
