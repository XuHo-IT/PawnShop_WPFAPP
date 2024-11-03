using BussinessObject;
using Repository;
using System;
using System.Diagnostics.Contracts;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for PawnAdmin.xaml
    /// </summary>
    public partial class PawnAdmin : Window
    {
        private readonly PawnContractRepository pawnContractRepository;
        private readonly ItemRepository itemRepository;

        public PawnAdmin()
        {
            itemRepository = new ItemRepository();
            pawnContractRepository = new PawnContractRepository();
            InitializeComponent();
            LoadPendingItems();
        }

        private void LoadPendingItems()
        {
            PawnItemsGrid.ItemsSource = pawnContractRepository.GetPendingItems();
        }

        private void PawnItemsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = PawnItemsGrid.SelectedItem as PendingItemViewModel;
            if (selectedItem != null)
            {
                var item = itemRepository.GetItemById(selectedItem.ItemId);
                pawnContractRepository.ApproveItem(item);
                MessageBox.Show("Item accepted.");
                LoadPendingItems();
            }
            else
            {
                MessageBox.Show("Please select an item first.");
            }
        }

        private void DenyButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = PawnItemsGrid.SelectedItem as PendingItemViewModel;
            if (selectedItem != null)
            {
                var item = itemRepository.GetItemById(selectedItem.ItemId);
                pawnContractRepository.RejectItem(item);
                MessageBox.Show("Item denied.");
                LoadPendingItems();
            }
            else
            {
                MessageBox.Show("Please select an item first.");
            }
        }


        private void RefreshPendingItems()
        {
            PawnItemsGrid.ItemsSource = null;
            PawnItemsGrid.ItemsSource = pawnContractRepository.GetPendingItems();
        }
    }
}
