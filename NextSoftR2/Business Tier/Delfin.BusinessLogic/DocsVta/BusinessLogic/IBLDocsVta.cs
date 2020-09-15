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
	public partial interface IBLDocsVta
	{
		#region [ Consultas ]
        ObservableCollection<DocsVta> GetAllPorFiltrosLView(String x_DOCV_Numero, DateTime x_DOCV_FechaEmisionIni, DateTime x_DOCV_FechaEmisionFin, Int32? x_ENTC_Codigo, String x_Estado );
		DocsVta GetOne(Int32 DOCV_Codigo);
        Boolean ModificarCliente(Int32 x_DOCV_Codigo, Int32 x_ENTC_Codigo, String x_AUDI_UsrMod, Int16 x_TIPE_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref DocsVta Item);
		Boolean Save(ref ObservableCollection<DocsVta> Items);
		#endregion
	}
}
