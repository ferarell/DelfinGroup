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
	public partial interface IBLDet_Tarifa_Servicio
	{
		#region [ Consultas ]
		ObservableCollection<Det_Tarifa_Servicio> GetAll();
		Det_Tarifa_Servicio GetOne(Int32 CTAR_Codigo, String CTAR_Tipo, Int32 DTAS_Item);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Det_Tarifa_Servicio Item);
		Boolean Save(ref ObservableCollection<Det_Tarifa_Servicio> Items);
		#endregion
	}
}
