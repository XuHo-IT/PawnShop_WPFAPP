﻿using BussinessObject;
using Repository;
using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for PawnAdmin.xaml
    /// </summary>
    public partial class PawnAdmin : Window
    {
        public PawnAdmin()
        {
            InitializeComponent();
            PawnItemsGrid.ItemsSource = PawnContractRepository.Instance.GetPendingItems();
        }

        private void PawnItemsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Optional: Logic when selection changes
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = PawnItemsGrid.SelectedItem as Item;
            if (selectedItem != null)
            {
                PawnContractRepository.Instance.ApproveItem(selectedItem, 1); 
                MessageBox.Show("Item accepted.");
                RefreshPendingItems();
            }
            else
            {
                MessageBox.Show("Please select an item first.");
            }
        }

        private void DenyButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = PawnItemsGrid.SelectedItem as Item;
            if (selectedItem != null)
            {
                PawnContractRepository.Instance.RejectItem(selectedItem); 
                MessageBox.Show("Item denied.");
                RefreshPendingItems();
            }
            else
            {
                MessageBox.Show("Please select an item first.");
            }
        }


        private void RefreshPendingItems()
        {
            PawnItemsGrid.ItemsSource = null;
            PawnItemsGrid.ItemsSource = PawnContractRepository.Instance.GetPendingItems();
        }
    }
}
