using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
		#region [ Consultas ]
		
		System.Data.DataTable GetDTMovimientoFlujo(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<MovimientoFlujo> GetAllMovimientoFlujoFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<MovimientoFlujo> GetAllMovimientoFlujo();
		
		MovimientoFlujo GetOneMovimientoFlujo(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Int16 MFLU_Item);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveMovimientoFlujo(ref MovimientoFlujo Item);
		#endregion
   }
}
