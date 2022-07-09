using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Nume_Pren_Lab12.Models;

namespace Nume_Pren_Lab12.Data
{
    public class ShoppingListDatabase
    {
        IRestService restService;

        public ShoppingListDatabase(IRestService service)
        {
            restService = service;
            
        }


      /*  public Task<List<ShopList>> GetShopListsAsync()
        {
            return restService.RefreshDataAsync();
        }
      */

        public Task<List<Sales>> GetSalesAsync()
        {
            return restService.RefreshDataChartAsync();
        }
        // de creat o metoda similara pentru tabelul Sales


    /*    public Task SaveShopListAsync(ShopList item, bool isNewItem = true)
        {
            return restService.SaveShopListAsync(item, isNewItem);
        }

        public Task DeleteShopListAsync(ShopList item)
        {
            return restService.DeleteShopListAsync(item.ID);
        }
    */
        
    }

}

   
