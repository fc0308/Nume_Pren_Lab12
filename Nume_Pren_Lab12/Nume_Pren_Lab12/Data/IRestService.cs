﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Nume_Pren_Lab12.Models;


namespace Nume_Pren_Lab12.Data
{
	public interface IRestService
	{
	//	Task<List<ShopList>> RefreshDataAsync();

		Task<List<Sales>> RefreshDataChartAsync();

	//	Task SaveShopListAsync(ShopList item, bool isNewItem);

	//	Task DeleteShopListAsync(int id);
	}
}
