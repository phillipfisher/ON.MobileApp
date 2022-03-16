using ON.MobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ON.MobileApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
            //var htmlSource = new HtmlWebViewSource();
            //htmlSource.Html = @"<html><body>"+Mode+@""</body></html>";
            //bodyWebView.Source = htmlSource;
        }
    }
}