using BussinessObject;
using Repository;
using System.Windows;

namespace WpfApp
{
    public partial class StatisticAdminWindow : Window
    {
        private readonly PawnContractRepository pawnContractRepository;
        private readonly ItemRepository itemRepository;
        private readonly UserRepository userRepository;

        public StatisticAdminWindow()
        {
            pawnContractRepository = new PawnContractRepository();
            itemRepository = new ItemRepository();
            userRepository = new UserRepository();

            InitializeComponent();

            // Load transactions
            var transactions = pawnContractRepository.GetTransaction();

            // Prepare the list of view models to display in the DataGrid
            var transactionDetails = new List<TransactionDetailViewModel>();

            foreach (var transaction in transactions)
            {
                var item = itemRepository.GetItemById(transaction.ItemId);
                var user = userRepository.GetUserById(transaction.UserId);

                if (item != null && user != null)
                {
                    var transactionDetail = new TransactionDetailViewModel
                    {
                        ContractId = transaction.ContractId,
                        LoanAmount = transaction.LoanAmount,
                        ContractDate = transaction.ContractDate,
                        ExpirationDate = transaction.ExpirationDate,
                        ItemName = item.Name,
                        ItemValue = item.Value,
                        Description = item.Description,
                        UserRealName = user.UserRealName,             
                        UserPhone = user.Telephone,
                        UserEmail = user.EmailAddress,
                        Address = user.Address,
                        CID= user.CID
                    };

                    transactionDetails.Add(transactionDetail);
                }
            }

            // Bind the view model list to the DataGrid
            dataGridPawn.ItemsSource = transactionDetails;
        }
    }

}
