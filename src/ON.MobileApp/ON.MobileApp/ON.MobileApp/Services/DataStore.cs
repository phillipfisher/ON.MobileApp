﻿using ON.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ON.MobileApp.Services
{
    public class DataStore : IDataStore<Item>
    {
        readonly ContentService contentService;
        readonly List<Item> items = new List<Item>();

        public DataStore()
        {
            this.contentService = new ContentService();
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            if (!forceRefresh && items.Count != 0)
                return items;

            try
            {
                var records = await contentService.GetAll();

                items.Clear();
                items.AddRange(records);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to Load Items from server");
                Debug.WriteLine(ex.Message);
            }

            return items;
        }
    }
}