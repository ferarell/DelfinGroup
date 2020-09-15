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
	public partial interface IBLDet_Tarjas
	{
		#region [ Consultas ]
        ObservableCollection<Det_Tarjas> GetAllDet_TarjasPorTARJ_Codigo(Int32 x_TARJ_Codigo);
		Det_Tarjas GetOne(Int32 DTAJ_Item, Int32 TARJ_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save( Det_Tarjas Item);
		Boolean Save(ref ObservableCollection<Det_Tarjas> Items);
		#endregion
	}
}
