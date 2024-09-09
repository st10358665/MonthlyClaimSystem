using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MonthlyClaimSystem
{
    public partial class ViewReviewsView : UserControl
    {
        // ObservableCollection to hold the reviews data
        public ObservableCollection<Review> Reviews { get; set; }

        public ViewReviewsView()
        {
            InitializeComponent();
            Reviews = new ObservableCollection<Review>();
            ReviewsListView.ItemsSource = Reviews; // Bind the ListView to the Reviews collection
        }

        // Event handler for the Search button click
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string moduleName = ModuleTextBox.Text.Trim();
            if (string.IsNullOrEmpty(moduleName))
            {
                StatusMessageTextBlock.Text = "Please enter a module name.";
                return;
            }

            // Simulate searching for reviews (replace with actual search logic)
            ObservableCollection<Review> searchResults = SearchReviews(moduleName);
            if (searchResults.Count > 0)
            {
                Reviews.Clear();
                foreach (var review in searchResults)
                {
                    Reviews.Add(review);
                }
                StatusMessageTextBlock.Text = $"Found {searchResults.Count} reviews for module '{moduleName}'.";
            }
            else
            {
                StatusMessageTextBlock.Text = $"No reviews found for module '{moduleName}'.";
            }
        }

        // Simulated method to search for reviews (replace with actual implementation)
        private ObservableCollection<Review> SearchReviews(string moduleName)
        {
            // Example data for demonstration purposes
            ObservableCollection<Review> searchResults = new ObservableCollection<Review>();
            if (moduleName == "Module A")
            {
                searchResults.Add(new Review
                {
                    Module = "Module A",
                    Rating = 4,
                    Comment = "Great module, learned a lot!"
                });
                searchResults.Add(new Review
                {
                    Module = "Module A",
                    Rating = 3,
                    Comment = "Average module, could be improved."
                });
            }
            return searchResults;
        }
    }
}

    