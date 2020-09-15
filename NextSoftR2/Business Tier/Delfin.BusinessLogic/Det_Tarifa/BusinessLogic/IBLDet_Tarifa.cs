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
	public partial interface IBLDet_Tarifa
	{
		#region [ Consultas ]
		ObservableCollection<Det_Tarifa> GetAll();
		Det_Tarifa GetOne(Int32 CTAR_Codigo, String CTAR_Tipo, String DTAR_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Det_Tarifa Item);
        Boolean Saves(ref ObservableCollection<Det_Tarifa> Items);
		#endregion
	}
}
