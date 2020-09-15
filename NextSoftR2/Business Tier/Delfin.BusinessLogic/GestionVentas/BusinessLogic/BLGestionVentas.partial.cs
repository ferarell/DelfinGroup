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
	public partial class BLGestionVentas
	{
		#region [ Consultas ]
      public ObservableCollection<GestionVentas> GetAllByProspecto(Int32 PROS_Codigo)
      {
         try
         {
            return SelectAllByProspecto(PROS_Codigo);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataTable GetKPIContactados(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
      {
         try
         {
            return SelectKPIContactados(EMPR_Codigo, SUCR_Codigo, GEST_FechaDesde, GEST_FechaHasta, PorEjecutivo, ENTC_CodEjecutivo);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataTable GetKPIReuniones(Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime GEST_FechaDesde, DateTime GEST_FechaHasta, Boolean PorEjecutivo, Nullable<Int32> ENTC_CodEjecutivo)
      {
         try
         {
            return SelectKPIReuniones(EMPR_Codigo, SUCR_Codigo, GEST_FechaDesde, GEST_FechaHasta, PorEjecutivo, ENTC_CodEjecutivo);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
