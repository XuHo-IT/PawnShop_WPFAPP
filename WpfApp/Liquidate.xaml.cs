using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using BussinessObject;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace WpfApp
{
    public partial class Liquidate : Window
    {
        private readonly IPawnContractRepository pawnContractRepository;

        public Liquidate()
        {
            InitializeComponent();
            pawnContractRepository = new PawnContractRepository();
            LoadPawnContracts();
            
        }

        private void LoadPawnContracts()
        {
            var pawnContracts = pawnContractRepository.GetAllPawnContracts();
            PawnContractsGrid.ItemsSource = pawnContracts;

        }

        

        private void BtnLiquidate_Click(object sender, RoutedEventArgs e)
        {
            var selectedContract = (PawnContract)PawnContractsGrid.SelectedItem;

            if (selectedContract == null)
            {
                MessageBox.Show("Please select a contract to liquidate.");
                return;
            }

            using (var context = new PawnShopContext())
            {
                var pawnContract = context.PawnContracts
                    .FirstOrDefault(pc => pc.ContractId == selectedContract.ContractId);

                if (pawnContract != null)
                {
                    // Fetch the associated item using ItemId
                    var item = context.Items.FirstOrDefault(i => i.ItemId == pawnContract.ItemId);

                    if (item != null)
                    {
                        var shopItem = new ShopItem
                        {
                            Name = item.Name,
                            Description = item.Description,
                            Price = item.Value,
                            DateAdded = DateTime.Now
                        };

                        try
                        {
                            context.ShopItems.Add(shopItem);
                            item.Status = "Liquidated"; // Update item's status
                            context.PawnContracts.Remove(pawnContract); // Remove the pawn contract
                            context.SaveChanges();

                            MessageBox.Show("The item has been successfully liquidated and added to the shop.");
                            LoadPawnContracts(); // Refresh the DataGrid
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error liquidating pawn contract: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item associated with this pawn contract not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Pawn contract not found.");
                }
            }
        }


        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            // Code to navigate back to the main menu
            this.Close(); // Or navigate to another window as needed
        }
    }
}
