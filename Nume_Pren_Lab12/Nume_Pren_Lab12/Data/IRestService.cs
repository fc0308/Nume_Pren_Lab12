using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using Nume_Pren_Lab12.Models;


namespace Nume_Pren_Lab12.Data
{
	public interface IRestService
	{
	
		Task<List<Sales>> RefreshDataChartAsync();

	}
}
