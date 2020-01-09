using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.Controllers;

namespace InventoryService.Services
{
    public class InventoryServices : IInventoryServices
    {
        private readonly Dictionary<string, InventoryItem> inventoryItems;

        public InventoryServices()
        {
            inventoryItems = new Dictionary<string, InventoryItem>();
        }

        public InventoryItem AddInventoryItem(InventoryItem item)
        {
            inventoryItems.Add(item.Name, item);

            return item;
        }

        public Dictionary<string, InventoryItem> GetInventoryItems()
        {
            return inventoryItems;
        }
    }
}
