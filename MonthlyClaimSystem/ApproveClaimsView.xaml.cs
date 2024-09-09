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

namespace MonthlyClaimSystem
{
    /// <summary>
    /// Interaction logic for ApproveClaimsView.xaml
    /// </summary>
    public partial class ApproveClaimsView : UserControl
    {
        public ApproveClaimsView()
        {
            InitializeComponent();
            LoadClaims(); // Load claims into the ListView
        }

        private void LoadClaims()
        {
            // TODO: Load claims from the database and bind to ClaimsListView
        }

        private void ClaimsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Enable the Approve button if a claim is selected
            ApproveButton.IsEnabled = ClaimsListView.SelectedItem != null;
        }
  
        private void ApproveButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Implement logic to approve the selected claim
            MessageBox.Show("Claim approved successfully!");
        }
    }
}
