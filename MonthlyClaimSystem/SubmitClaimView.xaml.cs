using Microsoft.Win32;
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
    /// Interaction logic for SubmitClaimView.xaml
    /// </summary>
    public partial class SubmitClaimView : UserControl
    {
        public SubmitClaimView()
        {
            InitializeComponent();
        }
        private void BrowseFiles_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "Documents|*.pdf;*.doc;*.docx;*.jpg;*.png"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                SupportingDocumentsTextBox.Text = openFileDialog.FileName; 
            }
           
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            string moduleName = ModuleNameTextBox.Text;
            string claimAmount = ClaimAmountTextBox.Text;
            string supportingDocuments = SupportingDocumentsTextBox.Text;

            // TODO: Add claim submission logic (e.g., save to database)
            MessageBox.Show("Claim submitted successfully!");
        }
        private void AddModule_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Another Module Added Successfully");
        }
    }
} 

