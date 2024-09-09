using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MonthlyClaimSystem
{
    public partial class TrackClaimView : UserControl
    {
        // ObservableCollection to hold the claims data
        public ObservableCollection<Claim> Claims { get; set; }

        public TrackClaimView()
        {
            InitializeComponent();
            Claims = new ObservableCollection<Claim>();
            ClaimsListView.ItemsSource = Claims; // Bind the ListView to the Claims collection
        }

        // Event handler for the Track Claim button click
        private void TrackClaimButton_Click(object sender, RoutedEventArgs e)
        {
            string claimId = ClaimIdTextBox.Text.Trim();
            if (string.IsNullOrEmpty(claimId))
            {
                StatusMessageTextBlock.Text = "Please enter a Claim ID.";
                return;
            }

            // Simulate tracking the claim (replace with actual tracking logic)
            Claim trackedClaim = TrackClaim(claimId);
            if (trackedClaim != null)
            {
                Claims.Add(trackedClaim);
                StatusMessageTextBlock.Text = $"Claim {claimId} tracked successfully.";
            }
            else
            {
                StatusMessageTextBlock.Text = $"Claim {claimId} not found.";
            }
        }

        // Simulated method to track a claim (replace with actual implementation)
        private Claim TrackClaim(string claimId)
        {
            // Example data for demonstration purposes
            if (claimId == "12345")
            {
                return new Claim
                {
                    ClaimId = "12345",
                    Status = "Approved",
                    DateFiled = "2024-01-15",
                    Amount = "$500.00"
                };
            }
            return null; // Claim not found
        }
    }
}

    
