using Repository;
using System.Windows;

namespace WpfApp
{
    public partial class StatisticAdminWindow : Window
    {
        private readonly PawnContractRepository pawnContractRepository;

        public StatisticAdminWindow()
        {
            pawnContractRepository = new PawnContractRepository();
            InitializeComponent();

            // Load pawn statistics
            dataGridPawn.ItemsSource = pawnContractRepository.GetPendingItems(); // Assuming this fetches pending pawn contracts

            // Load liquidation statistics
           // Assuming this fetches liquidation items
        }
    }
}
