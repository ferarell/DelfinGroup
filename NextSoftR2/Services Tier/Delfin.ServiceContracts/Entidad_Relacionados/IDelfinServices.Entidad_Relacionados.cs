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
		
		System.Data.DataTable GetDTEntidad_Relacionados(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Entidad_Relacionados> GetAllEntidad_RelacionadosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		
		ObservableCollection<Entidad_Relacionados> GetAllEntidad_Relacionados();
		
		Entidad_Relacionados GetOneEntidad_Relacionados(Int32 RELA_Codigo);

		#endregion

		#region [ Metodos ]
		
		Boolean SaveEntidad_Relacionados(ref Entidad_Relacionados Item);
		#endregion
   }
}
