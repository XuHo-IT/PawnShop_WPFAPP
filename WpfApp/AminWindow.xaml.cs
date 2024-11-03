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
            MessageBox.Show("PAWN button clicked!");
            // Your logic for PAWN button
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TRANSACTION HISTORY button clicked!");
            // Your logic for TRANSACTION HISTORY button
        }
    }
}
