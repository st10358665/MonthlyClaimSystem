using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MonthlyClaimSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentArea.Content = new SubmitClaimView(); // Default view
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new SubmitClaimView();
        }

        private void TrackClaim_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new TrackClaimView();
        }

        private void ViewReviews_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new ViewReviewsView();
        }
        private void ApproveClaims_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new ApproveClaimsView(); 
        }
    }
    }
