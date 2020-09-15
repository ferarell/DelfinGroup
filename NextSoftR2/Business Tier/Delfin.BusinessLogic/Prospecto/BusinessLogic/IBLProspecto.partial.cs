using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using System.Data;

namespace Delfin.BusinessLogic
{
	public partial interface IBLProspecto
	{
		#region [ Consultas ]
      ObservableCollection<Prospecto> GetAllValidos(DataTable Items, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime PROS_FecAsignacion);
      ObservableCollection<Prospecto> GetAllByEjecutivo(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 ENTC_CodEjecutivo, Nullable<Int32> ENTC_CodAgenteCarga, Nullable<DateTime> PROS_FecAsignacion, Nullable<DateTime> PROS_FecAsignacionInicio, Nullable<DateTime> PROS_FecAsignacionFinal);
      ObservableCollection<Prospecto> GetAllByEjecutivoGestionVentas(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 ENTC_CodEjecutivo, Nullable<Int32> ENTC_CodAgenteCarga, Nullable<DateTime> GEST_FechaProximaGestion);
      #endregion
		
		#region [ Metodos ]
      Boolean Asignar(DataTable Items, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime PROS_FecAsignacion, String AUDI_Usuario);
      Boolean ReAsignar(DataTable Items, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime PROS_FecAsignacion, String AUDI_Usuario);
		#endregion
	}
}
