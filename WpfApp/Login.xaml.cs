using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UserNameTextBox.Text;
            string password = PasswordBox.Password;

            // Implement your sign-in logic here
            // For example, validate credentials and navigate to the main application window
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear the username and password fields
            UserNameTextBox.Clear();
            PasswordBox.Clear();
        }
    }
}
