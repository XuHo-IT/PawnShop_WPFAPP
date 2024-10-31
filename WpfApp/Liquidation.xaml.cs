using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using BussinessObject;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace WpfApp
{
    public partial class Liquidation : Window
    {
        public DbSet<PawnContract> PawnContracts { get; set; }
        public Liquidation()
        {
            InitializeComponent();
            LoadPawnContracts();
        }

        private void LoadPawnContracts()
        {
            using (var context = new PawnShopContext())
            {
                // Fetch all pawn contracts from the database
                List<PawnContract> pawnContracts = context.PawnContracts.ToList();

                // Bind the fetched data to the DataGrid
                PawnItemsGrid.ItemsSource = pawnContracts;
            }
        }
        private void PawnItemsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Handle the selection changed event here
            // Example: Get the selected item
            if (PawnItemsGrid.SelectedItem is PawnContract selectedContract)
            {
                // You can now access the selected contract details
                MessageBox.Show($"Selected Contract: {selectedContract.ContractNumber}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
