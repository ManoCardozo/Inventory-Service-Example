using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.Controllers;

namespace InventoryService.Services
{
    public interface IInventoryServices
    {
        InventoryItem AddInventoryItem(InventoryItem items);

        Dictionary<string, InventoryItem> GetInventoryItems();
    }
}
