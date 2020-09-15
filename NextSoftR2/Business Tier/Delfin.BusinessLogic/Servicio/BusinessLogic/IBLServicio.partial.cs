using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial interface IBLServicio
	{
		#region [ Consultas ]
      ObservableCollection<Servicio> GetAllByViaRegimen(String CONS_TabVia, String CONS_CodVia, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabLNG, String CONS_CodLNG);
      ObservableCollection<Servicio> GetAllByFiltros(Boolean AcceptNulls, String CONS_TabVia, String CONS_CodVia, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabLNG, String CONS_CodLNG, String SERV_TipoMov, Boolean SERV_AfeIgv, Boolean SERV_AfeDet);
      ObservableCollection<Servicio> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);

      System.Data.DataTable GetAllDTByFilters(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      String VerificaServicio(Servicio x_Item);

      //ObservableCollection<Servicio> GetAllByCachetes(String Nombre);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
