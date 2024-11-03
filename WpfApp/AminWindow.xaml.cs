using System.Windows;

namespace WpfApp
{
    public partial class AminWindow : Window
    {
        public AminWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the PawnAdmin window
            PawnAdmin pawnAdminWindow = new PawnAdmin();
            // Show the PawnAdmin window
            pawnAdminWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TRANSACTION HISTORY button clicked!");
            // Your logic for TRANSACTION HISTORY button
        }
    }
}
