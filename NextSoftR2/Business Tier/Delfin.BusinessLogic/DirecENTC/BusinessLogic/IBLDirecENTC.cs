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
	public partial interface IBLDirecENTC
	{
		#region [ Consultas ]
        ObservableCollection<DirecENTC> GetAll(Int32 x_ENTC_Codigo);
		DirecENTC GetOne(Int32 ENTC_Codigo, Int16 DIRE_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref DirecENTC Item);
		Boolean Save(ref ObservableCollection<DirecENTC> Items);
		#endregion
	}
}
