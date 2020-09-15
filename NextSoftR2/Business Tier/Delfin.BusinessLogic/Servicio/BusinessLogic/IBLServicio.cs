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
	public partial interface IBLServicio
	{
		#region [ Consultas ]
		ObservableCollection<Servicio> GetAll();
		Servicio GetOne(Int32 SERV_Codigo);
      System.Data.DataTable GetServiciosAdicionales(Int32 SERV_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Servicio Item);
		Boolean Save(ref ObservableCollection<Servicio> Items);
		#endregion
	}
}
