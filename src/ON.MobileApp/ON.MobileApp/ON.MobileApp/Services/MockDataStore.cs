using ON.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ON.MobileApp.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            var date = DateTime.Now;
            items = new List<Item>();
            items.Add(new Item { Id = Guid.NewGuid().ToString(), Title = "First item", Subtitle = "This is an item description.", Date = date });
            date = date.AddDays(-1);
            items.Add(new Item { Id = Guid.NewGuid().ToString(), Title = "Second item", Subtitle = "This is an item description.", Date = date });
            date = date.AddDays(-1);
            items.Add(new Item { Id = Guid.NewGuid().ToString(), Title = "Third item", Subtitle = "This is an item description.", Date = date });
            date = date.AddDays(-1);
            items.Add(new Item { Id = Guid.NewGuid().ToString(), Title = "Fourth item", Subtitle = "This is an item description.", Date = date });
            date = date.AddDays(-1);
            items.Add(new Item { Id = Guid.NewGuid().ToString(), Title = "Fifth item", Subtitle = "This is an item description.", Date = date });
            date = date.AddDays(-1);
            items.Add(new Item { Id = Guid.NewGuid().ToString(), Title = "Sixth item", Subtitle = "This is an item description.", Date = date });
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}