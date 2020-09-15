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
		
		System.Data.DataTable GetDTTransferencia(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Transferencia> GetAllTransferenciaFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Transferencia> GetAllTransferencia();
		
		Transferencia GetOneTransferencia(Int16 EMPR_Codigo, Int32 TRAN_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveTransferencia(ref Transferencia Item);
		#endregion
   }
}
