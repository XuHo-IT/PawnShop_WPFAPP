using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Liquidate.xaml
    /// </summary>
    public partial class Liquidate : Window
    {
        public Liquidate()
        {
            InitializeComponent();
        }

        private void PawnItemsGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Implement logic for when a selection changes in the DataGrid
            // For example, display details of the selected pawn item
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic for the Liquidate button click
            // For example, perform liquidation process
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic for the Search button click
            // For example, filter the DataGrid based on search criteria
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic for the Menu button click
            // For example, navigate to another menu or window
        }
    }
}
