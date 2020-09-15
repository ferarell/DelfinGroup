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
	public partial interface IBLPreDetDocsVta
	{
		#region [ Consultas ]
        ObservableCollection<PreDetDocsVta> GetAllPorDOCV_Codigo(Int32 x_DOCV_Codigo);
		PreDetDocsVta GetOne(Int16 PDDO_Item, Int32 DOCV_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref PreDetDocsVta Item);
		Boolean Save(ref ObservableCollection<PreDetDocsVta> Items);
		#endregion
	}
}
