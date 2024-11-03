using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for InformationWindow.xaml
    /// </summary>
    public partial class InformationWindow : Window
    {
        public InformationWindow()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // Implement functionality for Username TextBox change
            // For example, you could validate the username or update a label
            // Example: 
            // MessageBox.Show("Username changed: " + Username.Text);
        }

        private void RealName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // Implement functionality for RealName TextBox change
            // Example: 
            // MessageBox.Show("Real Name changed: " + RealName.Text);
        }
    }
}
