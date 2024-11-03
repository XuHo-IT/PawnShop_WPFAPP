﻿using BussinessObject;
using DataAccessLayer;
using Repository;
using System;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for BillMemberWindow.xaml
    /// </summary>
    public partial class BillMemberWindow : Window
    {
        int loggedInUserId = SessionManager.UserId;
        private readonly BillRepository billRepository;

        public BillMemberWindow()
        {
            InitializeComponent();
            billRepository = new BillRepository(); // Initialize your repository
            LoadUserBills(); // Load bills when the window is opened
        }

        // Method to load user bills and bind them to the DataGrid
        private void LoadUserBills()
        {
            var userBills = billRepository.GetBillsByUserId(loggedInUserId);
            PawnItemsGrid.ItemsSource = userBills; // Set the DataGrid's source to the fetched bills
        }

        // Optionally, you can call LoadUserBills() from other parts of your code 
        // if you need to refresh the data after an operation.
    }
}
