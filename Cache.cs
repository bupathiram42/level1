using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public class Cache
    {
        private readonly Dictionary<string, CacheItem> _cache;
        private readonly LinkedList<string> _accessOrder;
        private readonly int _maxSize;

        public Cache(int maxSize)
        {
            _cache = new Dictionary<string, CacheItem>();
            _accessOrder = new LinkedList<string>();
            _maxSize = maxSize;
        }

        public MenuItem GetMenuItem(string menuId)
        {
            EvictExpiredItems();
            if (_cache.ContainsKey(menuId))
            {
                Console.WriteLine($"Item with MenuID {menuId} found in cache");
                UpdateAccessOrder(menuId);
                return _cache[menuId].Item;
            }
            else
            {
                Console.WriteLine($"Item with MenuID {menuId} not found in cache, retrieving from source ...");
                try
                {
                    List<MenuItem> items = Operations.GetSearchMenuItems("MenuId", menuId);
                    if (items.Count > 0)
                    {
                        AddToCache(menuId, items[0]);
                        return items[0];
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to retrieve item with MenuID {menuId}: {ex.Message}");
                    return null;
                }
            }
        }

        public void AddToCache(string menuId, MenuItem item)
        {
            if (_cache.Count >= _maxSize)
            {
                string oldestItemId = _accessOrder.First.Value;
                _cache.Remove(oldestItemId);
                _accessOrder.RemoveFirst();
            }
            _cache.Add(menuId, new CacheItem(item));
            _accessOrder.AddLast(menuId);
        }

        private void UpdateAccessOrder(string menuId)
        {
            _accessOrder.Remove(menuId);
            _accessOrder.AddLast(menuId);
        }

        private void EvictExpiredItems()
        {
            DateTime sixHoursAgo = DateTime.Now.AddHours(-6);
            var expiredItems = _cache.Where(kvp => kvp.Value.Timestamp < sixHoursAgo).ToList();
            foreach (var kvp in expiredItems)
            {
                _cache.Remove(kvp.Key);
                _accessOrder.Remove(kvp.Key);
            }
        }
    
    }
}
