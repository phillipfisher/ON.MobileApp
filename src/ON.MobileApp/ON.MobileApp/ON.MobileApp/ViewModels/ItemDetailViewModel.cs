using ON.MobileApp.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ON.MobileApp.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string heading;
        private string date;
        private string subtitle;
        private string body;
        public string Id { get; set; }

        public string Heading
        {
            get => heading;
            set => SetProperty(ref heading, value);
        }

        public string Date
        {
            get => date;
            set => SetProperty(ref date, value);
        }

        public string Subtitle
        {
            get => subtitle;
            set => SetProperty(ref subtitle, value);
        }

        public string Body
        {
            get => body;
            set {
                SetProperty(ref body, value);
                HtmlSource.Html = @"<html><body>" + body + @"</body></html>";
            }
        }

        public HtmlWebViewSource HtmlSource { get; private set; } = new HtmlWebViewSource() { Html = "<html><body>body</body></html>" };

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Heading = item.Title;
                Subtitle = item.Subtitle;
                Date = item.DatePretty;
                Body = item.Body;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
