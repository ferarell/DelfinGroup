using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLCab_Tarjas
	{
		#region [ Consultas ]
	    ObservableCollection<Cab_Tarjas> GetAllTarjasPorFiltros(DateTime x_FecIni, DateTime x_FecFin);
	    DataTable GetAyudaTarjas();

        DataSet GetAllTarjasRebate(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin);

	    #endregion

	    #region [ Metodos ]

	    #endregion
	}
}
