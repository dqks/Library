using Library.Models;

namespace Library
{
    public partial class FormLogin : Form
    {
        public bool IsGuest { get; private set; }
        public User User { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(textBoxPassword.Text) || String.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private void ButtonGuest_Click(object sender, EventArgs e)
        {

            FormBooks form = new FormBooks();
            form.Show();
            this.Hide();

        }
    }
}
