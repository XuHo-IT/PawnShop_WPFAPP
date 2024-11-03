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
    /// Interaction logic for AminWindow.xaml
    /// </summary>
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
