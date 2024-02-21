using System;

namespace Application;
class CacheItem
{
    public MenuItem Item { get; set; }
    public DateTime Timestamp { get; set; }

    public CacheItem(MenuItem item)
    {
        Item = item;
        Timestamp = DateTime.Now.AddHours(-7);
    }
}