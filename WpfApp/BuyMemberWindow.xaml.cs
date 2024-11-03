﻿using BussinessObject;
using DataAccessLayer;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for BuyMemberWindow.xaml
    /// </summary>
    public partial class BuyMemberWindow : Window
    {

        int loggedInUserId = SessionManager.UserId;
        private readonly ShopItemRepository shopItemRepository;
        private readonly BillRepository billRepository;
       
        public BuyMemberWindow()
        {
            InitializeComponent(); 
            shopItemRepository = new ShopItemRepository();
            PawnItemsGrid.ItemsSource = shopItemRepository.GetItemShops();
            billRepository = new BillRepository();
        }
        private void PawnItemsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
            MessageBox.Show("Selection changed in PawnItemsGrid.");
        }
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            if (PawnItemsGrid.SelectedItem is ShopItem selectedItem)
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to buy '{selectedItem.Name}' for {selectedItem.Price:C}?",
                    "Confirm Purchase", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
              
                    Bill bill = new Bill
                    {
                        ShopItemId = selectedItem.ShopItemId,
                        UserId = loggedInUserId,
                        DateBuy = DateTime.Now
                    };

          
                    if (billRepository.InsertBill(bill))
                    {
           
                        if (shopItemRepository.UpdateItemExpirationStatus(selectedItem.ShopItemId, false))
                        {
                            MessageBox.Show("Purchase successful! Item is now available.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while updating the item status.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

            
                        PawnItemsGrid.ItemsSource = shopItemRepository.GetItemShops();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while processing the purchase.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to buy.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


    }
}
