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
		
		System.Data.DataTable GetDTEntidadCuentaBancaria(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<EntidadCuentaBancaria> GetAllEntidadCuentaBancariaFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<EntidadCuentaBancaria> GetAllEntidadCuentaBancaria();
		
		EntidadCuentaBancaria GetOneEntidadCuentaBancaria(Int32 ENTC_Codigo, String TIPO_TabBCO, String TIPO_CodBCO);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveEntidadCuentaBancaria(ref EntidadCuentaBancaria Item);
		#endregion
   }
}
