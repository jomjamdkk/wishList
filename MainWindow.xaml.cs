using System.Windows;

namespace wishList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            int day = int.Parse(txtPrice.Text)/(int.Parse(txtIncome.Text)-int.Parse(txtExpeneses.Text));
            txtDay.Text = day.ToString();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            txtDay.Text = "";
            txtIncome.Text = "";
            txtExpeneses.Text = "";
            txtPrice.Text = "";
        }
    }
}
