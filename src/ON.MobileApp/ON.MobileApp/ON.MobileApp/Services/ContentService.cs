using Newtonsoft.Json;
using ON.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ON.MobileApp.Services
{
    public class ContentService
    {
        //public readonly ONUser User;

        public ContentService()
        {
        }

        public async Task<IEnumerable<Item>> GetAll()
        {
            string json = await (new WebClient()).DownloadStringTaskAsync("http://localhost/api/content");
            var items = JsonConvert.DeserializeObject<IEnumerable<Item>>(json);
            return items;
        }

        public async Task<Item> GetContent(string contentId)
        {
            string json = await (new WebClient()).DownloadStringTaskAsync("http://localhost/api/content/" + contentId);
            var item = JsonConvert.DeserializeObject<Item>(json);
            return item;
        }
    }
}
