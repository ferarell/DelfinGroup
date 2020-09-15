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
	public partial interface IBLEntidad
	{
		#region [ Consultas ]
      ObservableCollection<Entidad> GetAll(Nullable<Int16> x_TIPE_Codigo = null, string x_ENTC_NomCompleto = null);
      Entidad GetOne(Int32 ENTC_Codigo, Nullable<Int16> x_TIPE_Codigo = null, Boolean x_soloentidad = false);
		#endregion
		
		#region [ Metodos ]
		Entidad Save(ref Entidad Item);
		Boolean Save(ref ObservableCollection<Entidad> Items);
		#endregion
	}
}
