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
    /// Interaction logic for InformationWindow.xaml
    /// </summary>
    public partial class InformationWindow : Window
    {
        public InformationWindow()
        {
            InitializeComponent();
        }
        private void Username_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // Implement functionality for Username TextBox change
            // For example, you could validate the username or update a label
            // Example: 
            // MessageBox.Show("Username changed: " + Username.Text);
        }

        private void RealName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // Implement functionality for RealName TextBox change
            // Example: 
            // MessageBox.Show("Real Name changed: " + RealName.Text);
        }
    }
}
