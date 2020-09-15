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
		[OperationContract]
		System.Data.DataTable GetDTSeries(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<Series> GetAllSeriesFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		[OperationContract]
		ObservableCollection<Series> GetAllSeries();
		[OperationContract]
		Series GetOneSeries(Int16 EMPR_Codigo, String SERI_Serie, String TIPO_TabTDO, String TIPO_CodTDO);

		#endregion

		#region [ Metodos ]
		[OperationContract]
		Boolean SaveSeries(ref Series Item);
		#endregion
   }
}
