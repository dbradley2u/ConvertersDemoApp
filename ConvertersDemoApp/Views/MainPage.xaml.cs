using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ConvertersDemoApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        ViewModels.MainPageViewModel ViewModelA => this.DataContext as ViewModels.MainPageViewModel;

        private void DisplayText_Click(object sender, RoutedEventArgs e)
        {
            ValueWhenConverterText.Visibility = Visibility.Visible;
        }

        private void SetFirstComboItem_Click(object sender, RoutedEventArgs e)
        {
            ViewModelA.SelectedSimpleModel = ViewModelA.SimpleModels.FirstOrDefault();
        }

        private void SetNullValueToCombo_Click(object sender, RoutedEventArgs e)
        {
            ViewModelA.SelectedSimpleModel = null;
        }
    }
}
