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
	public partial interface IBLGestionVentas
	{
		#region [ Consultas ]
      ObservableCollection<GestionVentas> GetAllByProspecto(Int32 PROS_Codigo);
      System.Data.DataTable GetKPIContactados(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo);
      System.Data.DataTable GetKPIReuniones(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo);
      #endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
