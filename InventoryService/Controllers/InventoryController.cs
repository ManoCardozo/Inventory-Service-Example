using InventoryService.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InventoryService.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryServices services;

        public InventoryController(IInventoryServices services)
        {
            this.services = services;
        }

        [HttpPost]
        [Route("AddInventoryItems")]
        public ActionResult<InventoryItem> AddInventoryItem(InventoryItem item)
        {
            var inventoryItem = services.AddInventoryItem(item);

            if(inventoryItem == null)
            {
                return NotFound();
            }

            return inventoryItem;
        }

        [HttpGet]
        [Route("GetInventoryItems")]
        public ActionResult<Dictionary<string, InventoryItem>> GetInventoryItems()
        {
            var inventoryItems = services.GetInventoryItems();

            if (inventoryItems.Count == 0)
            {
                return NotFound();
            }

            return inventoryItems;
        }
    }
}