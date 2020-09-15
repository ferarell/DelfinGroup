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
		
		System.Data.DataTable GetDTGRR_Contrato(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<GRR_Contrato> GetAllGRR_ContratoFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<GRR_Contrato> GetAllGRR_Contrato();

      GRR_Contrato GetOneGRR_Contrato(String REBA_Tipo, Int32 REBA_Codigo, Int32 CONT_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveGRR_Contrato(ref GRR_Contrato Item);
		#endregion
   }
}
