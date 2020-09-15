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
	public partial interface IBLEntidad_Servicio
	{
		#region [ Consultas ]
		ObservableCollection<Entidad_Servicio> GetAll(Int32 x_ENTC_Codigo);
		Entidad_Servicio GetOne(Int32 ESER_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Entidad_Servicio Item);
		Boolean Save(ref ObservableCollection<Entidad_Servicio> Items);
		#endregion
	}
}
