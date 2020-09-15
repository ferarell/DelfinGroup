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
	public partial interface IBLDepTemporalEntidad
	{
		#region [ Consultas ]
		ObservableCollection<DepTemporalEntidad> GetAll(Int32? x_ENTC_Codigo);
		DepTemporalEntidad GetOne(Int32 DETE_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref DepTemporalEntidad Item);
		Boolean Save(ref ObservableCollection<DepTemporalEntidad> Items);
		#endregion
	}
}
